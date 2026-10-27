using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020019C0 RID: 6592
public class WeaponTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600C093 RID: 49299 RVA: 0x002B638F File Offset: 0x002B458F
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
