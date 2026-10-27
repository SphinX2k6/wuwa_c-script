using System;
using CSharpScript.Game.Ui;

// Token: 0x020025F6 RID: 9718
public class PowerConfirmBoxData : UiPopViewData
{
	// Token: 0x06013C59 RID: 80985 RVA: 0x004F4F2D File Offset: 0x004F312D
	public PowerConfirmBoxData(int powerCount, EPowerMenuType type = EPowerMenuType.Supply, bool updateCurrentNeedPower = false, int autoClosePowerCount = -1)
	{
		this.PowerCount = powerCount;
		this.Type = type;
		this.UpdateCurrentNeedPower = updateCurrentNeedPower;
		this.AutoClosePowerCount = autoClosePowerCount;
	}

	// Token: 0x040094F7 RID: 38135
	public int PowerCount;

	// Token: 0x040094F8 RID: 38136
	public EPowerMenuType Type = EPowerMenuType.Supply;

	// Token: 0x040094F9 RID: 38137
	public bool UpdateCurrentNeedPower;

	// Token: 0x040094FA RID: 38138
	public int AutoClosePowerCount = -1;
}
