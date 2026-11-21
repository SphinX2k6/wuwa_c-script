using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200386A RID: 14442
	public class FindNavigationByListener : FindActionBase
	{
		// Token: 0x0602588D RID: 153741 RVA: 0x00A92624 File Offset: 0x00A90824
		[NullableContext(1)]
		public override void FindNavigation(FindNavigationResult result)
		{
			TsUiNavigationBehaviorListener listener = this.Params[0] as TsUiNavigationBehaviorListener;
			this.PanelConfig.CommonFindNavigationByListener(result, listener, true);
		}
	}
}
