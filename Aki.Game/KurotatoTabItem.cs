using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002051 RID: 8273
public class KurotatoTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x06010423 RID: 66595 RVA: 0x003F7031 File Offset: 0x003F5231
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
