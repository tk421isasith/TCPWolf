using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace IPWolf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public int Port { get; set; }
        public IPAddress Ipaddress { get; private set; }
        public IPAddress[] hostIps = Dns.GetHostAddresses(Dns.GetHostName()).Where(address => address.AddressFamily == AddressFamily.InterNetwork).ToArray();

        public MainWindow()
        {
            //InitializeComponent();
        }       

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }          
                
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            // ComboBoxips.ItemsSource = hostIps.ToList();
        }

    }
}
