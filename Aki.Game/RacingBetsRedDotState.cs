using System;

// Token: 0x02001BEB RID: 7147
public class RacingBetsRedDotState : IRacingBetsRedDotState
{
	// Token: 0x17001B16 RID: 6934
	// (get) Token: 0x06011C7B RID: 72827 RVA: 0x0053A969 File Offset: 0x00538B69
	// (set) Token: 0x06011C7C RID: 72828 RVA: 0x0053A971 File Offset: 0x00538B71
	public bool HasViewed { get; set; }

	// Token: 0x17001B17 RID: 6935
	// (get) Token: 0x06011C7D RID: 72829 RVA: 0x0053A97A File Offset: 0x00538B7A
	// (set) Token: 0x06011C7E RID: 72830 RVA: 0x0053A982 File Offset: 0x00538B82
	public long LastViewedData { get; set; }
}
