using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        double top;
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    top = 20;
                    break;
                case Device.Android:
                case Device.UWP:
                default:
                    top = 30;
                    break;
            }

            Padding = new Thickness(5, top, 0, 0);

          

        }



    }
}