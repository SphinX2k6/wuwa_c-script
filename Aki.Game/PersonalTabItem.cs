using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020019BD RID: 6589
public class PersonalTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600C08A RID: 49290 RVA: 0x002B6262 File Offset: 0x002B4462
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
