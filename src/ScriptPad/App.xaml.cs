﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace ScriptPad
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ScriptGlobals.InitAssemblies = new List<System.Reflection.Assembly>();
            ScriptGlobals.InitAssemblies.Add(typeof(object).Assembly);
        }
    }
}
