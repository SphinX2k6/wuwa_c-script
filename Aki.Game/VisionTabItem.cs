using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000E7D RID: 3709
public class VisionTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600949B RID: 38043 RVA: 0x002C12F3 File Offset: 0x002BF4F3
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
