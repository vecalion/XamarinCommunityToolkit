using System;
using System.Diagnostics;
using Xamarin.CommunityToolkit.ObjectModel;

namespace Xamarin.CommunityToolkit.Sample.Pages.Views.TabView
{
	public partial class GettingStartedPage : BasePage
	{
		public GettingStartedPage()
		{
			BindingContext = new FirstViewModel();
			InitializeComponent();
		}
	}

	public class FirstViewModel : ObservableObject
	{
		int index;
		public int Index
		{
			get => index;
			set
			{
				SetProperty(ref index, value);
				Debug.WriteLine($"{DateTime.Now} - New index: {value}");
			}
		}

		public FirstViewModel()
		{
			Index = 1;
		}
	}
}