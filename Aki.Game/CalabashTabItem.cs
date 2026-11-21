using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000C0D RID: 3085
public class CalabashTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x060080B7 RID: 32951 RVA: 0x00277CF9 File Offset: 0x00275EF9
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
