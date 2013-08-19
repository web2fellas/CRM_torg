using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CRMmobileGPS8._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void tfieldServerAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            //check server name string
        }

        private void tfieldUserName_LostFocus(object sender, RoutedEventArgs e)
        {
            //check user name spelling
        }

        private void switchSaveSettings_Toggled(object sender, RoutedEventArgs e)
        {
            //check state

            //update list of serveres if necessary

            //change 'save settings' accordingly
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            //check credentials

            //check permissions

            //proceed with login if everything is OK (home) otherwise popup a warning message with details

            
            //temporary shitycode
            this.Frame.Navigate(typeof(home));
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            //clear all fields
        }
    }
}
