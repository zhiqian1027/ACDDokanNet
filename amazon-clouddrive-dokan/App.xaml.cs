﻿using DokanNet;
using System;
using System.Windows;

namespace Azi.ACDDokanNet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public enum Args
        {
            mountall
        }

        void ProcessArgs(string[] args)
        {
            try
            {

                //var cloudDrive = new VirtualDrive("D:\\CloudDriveTestCache");
                //cloudDrive.Mount("r:\\", DokanOptions.DebugMode | DokanOptions.StderrOutput | DokanOptions.RemovableDrive);
                //Console.WriteLine("Success");
                //Dokan.Unmount('r');
            }
            catch (DokanException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Dokan.Unmount('r');
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                ProcessArgs(e.Args);
                return;
            }

            var win = new MainWindow();
            win.Show();
        }
    }
}
