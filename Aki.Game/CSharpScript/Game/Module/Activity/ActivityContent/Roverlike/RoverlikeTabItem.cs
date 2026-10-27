using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006134 RID: 24884
	public class RoverlikeTabItem : CommonTabItem, ITabViewRegister
	{
		// Token: 0x0603EE98 RID: 257688 RVA: 0x00F32292 File Offset: 0x00F30492
		[NullableContext(1)]
		public void RegisterViewModule(UiTabViewBase tabView)
		{
			tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
		}
	}
}
