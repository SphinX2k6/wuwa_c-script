using System;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Control
{
	// Token: 0x02004B9F RID: 19359
	public class SlidingBlocksJoystick : Joystick
	{
		// Token: 0x06032295 RID: 205461 RVA: 0x00BA7C3F File Offset: 0x00BA5E3F
		public override void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			this.JoystickVisible = bVisible;
		}

		// Token: 0x06032296 RID: 205462 RVA: 0x00BA7C48 File Offset: 0x00BA5E48
		protected override void UpdateJoystickVisible()
		{
		}
	}
}
