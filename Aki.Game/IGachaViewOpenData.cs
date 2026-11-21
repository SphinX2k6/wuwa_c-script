using System;

// Token: 0x02001153 RID: 4435
public interface IGachaViewOpenData
{
	// Token: 0x1700121A RID: 4634
	// (get) Token: 0x0600B0FC RID: 45308
	// (set) Token: 0x0600B0FD RID: 45309
	bool SkipOnLoadResourceFinish { get; set; }

	// Token: 0x1700121B RID: 4635
	// (get) Token: 0x0600B0FE RID: 45310
	// (set) Token: 0x0600B0FF RID: 45311
	bool ResultViewHideExtraReward { get; set; }

	// Token: 0x1700121C RID: 4636
	// (get) Token: 0x0600B100 RID: 45312
	// (set) Token: 0x0600B101 RID: 45313
	bool IsOnlyShowGold { get; set; }
}
