using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001524 RID: 5412
public class KurotatoTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600D88A RID: 55434 RVA: 0x00403529 File Offset: 0x00401729
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
