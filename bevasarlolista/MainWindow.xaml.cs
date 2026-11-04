using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bevasarlolista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> listaelemek = new List<String>();

        

        public MainWindow()
        {
            InitializeComponent();
            lbx_bevasarlolista.ItemsSource = listaelemek;
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if(tbx_ujtermek.Text != "")
            {
                listaelemek.Add(tbx_ujtermek.Text);
                lbx_bevasarlolista.Items.Refresh();
                tbx_ujtermek.Clear();
            }
            else
            {
                MessageBox.Show("Nincs megadva termék","Hiba",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void btn_eygtorles_Click(object sender, RoutedEventArgs e)
        {
            if (lbx_bevasarlolista.SelectedIndex != -1)
            {
                listaelemek.RemoveAt(lbx_bevasarlolista.SelectedIndex);
                lbx_bevasarlolista.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Nincs kiválasztva termék", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_ossztorles_Click(object sender, RoutedEventArgs e)
        {
            listaelemek.Clear();
            lbx_bevasarlolista.Items.Refresh();
        }
    }
}