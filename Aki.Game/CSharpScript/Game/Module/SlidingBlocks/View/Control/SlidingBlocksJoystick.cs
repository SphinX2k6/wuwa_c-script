using System;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;

namespace CSharpScript.Game.Module.SlidingBlocks.View.Control
{
	// Token: 0x02003B49 RID: 15177
	public class SlidingBlocksJoystick : Joystick
	{
		// Token: 0x06027025 RID: 159781 RVA: 0x00AEBD8B File Offset: 0x00AE9F8B
		public override void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			this.JoystickVisible = bVisible;
		}

		// Token: 0x06027026 RID: 159782 RVA: 0x00AEBD94 File Offset: 0x00AE9F94
		protected override void UpdateJoystickVisible()
		{
		}
	}
}
