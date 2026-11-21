using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000E7B RID: 3707
public class PersonalTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x06009494 RID: 38036 RVA: 0x002C11F2 File Offset: 0x002BF3F2
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
