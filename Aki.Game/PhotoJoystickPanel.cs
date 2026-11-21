using System;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02001A63 RID: 6755
public class PhotoJoystickPanel : Joystick
{
	// Token: 0x06010ADF RID: 68319 RVA: 0x004E1068 File Offset: 0x004DF268
	public override void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
	{
		this.JoystickVisible = bVisible;
	}

	// Token: 0x06010AE0 RID: 68320 RVA: 0x004E1071 File Offset: 0x004DF271
	protected override void UpdateJoystickVisible()
	{
	}
}
