using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001754 RID: 5972
public class CalabashTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600ACD0 RID: 44240 RVA: 0x0026D87D File Offset: 0x0026BA7D
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
