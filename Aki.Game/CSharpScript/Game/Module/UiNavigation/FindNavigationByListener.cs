using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F3 RID: 18675
	public class FindNavigationByListener : FindActionBase
	{
		// Token: 0x06030D60 RID: 200032 RVA: 0x00B577B4 File Offset: 0x00B559B4
		[NullableContext(1)]
		public override void FindNavigation(FindNavigationResult result)
		{
			TsUiNavigationBehaviorListener listener = this.Params[0] as TsUiNavigationBehaviorListener;
			this.PanelConfig.CommonFindNavigationByListener(result, listener, true);
		}
	}
}
