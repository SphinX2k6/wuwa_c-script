using System;

// Token: 0x02001C95 RID: 7317
public class GachaViewOpenData : IGachaViewOpenData
{
	// Token: 0x170011F7 RID: 4599
	// (get) Token: 0x0600DCEC RID: 56556 RVA: 0x00338FAD File Offset: 0x003371AD
	// (set) Token: 0x0600DCED RID: 56557 RVA: 0x00338FB5 File Offset: 0x003371B5
	public bool SkipOnLoadResourceFinish { get; set; }

	// Token: 0x170011F8 RID: 4600
	// (get) Token: 0x0600DCEE RID: 56558 RVA: 0x00338FBE File Offset: 0x003371BE
	// (set) Token: 0x0600DCEF RID: 56559 RVA: 0x00338FC6 File Offset: 0x003371C6
	public bool ResultViewHideExtraReward { get; set; }

	// Token: 0x170011F9 RID: 4601
	// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x00338FCF File Offset: 0x003371CF
	// (set) Token: 0x0600DCF1 RID: 56561 RVA: 0x00338FD7 File Offset: 0x003371D7
	public bool IsOnlyShowGold { get; set; }
}
