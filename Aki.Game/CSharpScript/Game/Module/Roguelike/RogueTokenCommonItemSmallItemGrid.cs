using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DFE RID: 15870
	internal class RogueTokenCommonItemSmallItemGrid : CommonItemSmallItemGrid
	{
		// Token: 0x06028849 RID: 165961 RVA: 0x00B5DA9B File Offset: 0x00B5BC9B
		protected override void OnExtendToggleClicked()
		{
			EventSystem.Instance.Emit(EEventName.RoguelikeGetTokenReward);
		}
	}
}
