using System;
using CSharpScript.Game.Ui;

// Token: 0x02001AE1 RID: 6881
public class PowerConfirmBoxData : UiPopViewData
{
	// Token: 0x0601113B RID: 69947 RVA: 0x00503CB9 File Offset: 0x00501EB9
	public PowerConfirmBoxData(int powerCount, EPowerMenuType type = EPowerMenuType.Supply, bool updateCurrentNeedPower = false, int autoClosePowerCount = -1)
	{
		this.PowerCount = powerCount;
		this.Type = type;
		this.UpdateCurrentNeedPower = updateCurrentNeedPower;
		this.AutoClosePowerCount = autoClosePowerCount;
	}

	// Token: 0x0400964E RID: 38478
	public int PowerCount;

	// Token: 0x0400964F RID: 38479
	public EPowerMenuType Type = EPowerMenuType.Supply;

	// Token: 0x04009650 RID: 38480
	public bool UpdateCurrentNeedPower;

	// Token: 0x04009651 RID: 38481
	public int AutoClosePowerCount = -1;
}
