using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E35 RID: 20021
	internal class RogueTokenCommonItemSmallItemGrid : CommonItemSmallItemGrid
	{
		// Token: 0x060339DE RID: 211422 RVA: 0x00C14573 File Offset: 0x00C12773
		protected override void OnExtendToggleClicked()
		{
			EventSystem.Instance.Emit(EEventName.RoguelikeGetTokenReward);
		}
	}
}
