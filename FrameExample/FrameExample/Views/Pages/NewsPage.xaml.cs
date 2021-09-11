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

namespace FrameExample
{
    /// <summary>
    /// Логика взаимодействия для NewPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        public NewsPage()
        {
            InitializeComponent();
        }

        private void btnHeigth_Click(object sender, RoutedEventArgs e)
        {
            image.Visibility = Visibility.Hidden;
        }
    }
}
