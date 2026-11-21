using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B2 RID: 20658
	public class RoverlikeTabItem : CommonTabItem, ITabViewRegister
	{
		// Token: 0x06033B58 RID: 211800 RVA: 0x00E79172 File Offset: 0x00E77372
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}
	}
}
