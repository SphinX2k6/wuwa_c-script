using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000E7E RID: 3710
public class WeaponTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600949D RID: 38045 RVA: 0x002C131F File Offset: 0x002BF51F
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
