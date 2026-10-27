using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020019BF RID: 6591
public class VisionTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600C091 RID: 49297 RVA: 0x002B6363 File Offset: 0x002B4563
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
