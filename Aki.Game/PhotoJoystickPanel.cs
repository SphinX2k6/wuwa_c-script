using System;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02002578 RID: 9592
public class PhotoJoystickPanel : Joystick
{
	// Token: 0x060135FC RID: 79356 RVA: 0x004D2400 File Offset: 0x004D0600
	public override void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
	{
		this.JoystickVisible = bVisible;
	}

	// Token: 0x060135FD RID: 79357 RVA: 0x004D2409 File Offset: 0x004D0609
	protected override void UpdateJoystickVisible()
	{
	}
}
