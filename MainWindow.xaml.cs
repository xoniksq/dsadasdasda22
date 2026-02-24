using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SportsStoreLogin2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text == "Поиск товаров...")
            {
                txtSearch.Text = "";
                txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(51, 51, 51));
            }
        }

        private void txtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Поиск товаров...";
                txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(153, 153, 153));
            }
        }
    }
}