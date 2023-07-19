using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace easyplan.Views;

public partial class ToDoList : UserControl
{
    public ToDoList()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}