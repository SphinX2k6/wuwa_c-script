using System;

// Token: 0x02001C06 RID: 7174
public class RacingBetsMatchTableDangoItemData : IRacingBetsMatchTableDangoItemData
{
	// Token: 0x17001B26 RID: 6950
	// (get) Token: 0x06011D24 RID: 72996 RVA: 0x0053D13B File Offset: 0x0053B33B
	// (set) Token: 0x06011D25 RID: 72997 RVA: 0x0053D143 File Offset: 0x0053B343
	public int DangoId { get; set; }

	// Token: 0x17001B27 RID: 6951
	// (get) Token: 0x06011D26 RID: 72998 RVA: 0x0053D14C File Offset: 0x0053B34C
	// (set) Token: 0x06011D27 RID: 72999 RVA: 0x0053D154 File Offset: 0x0053B354
	public bool IsNeedCheer { get; set; }

	// Token: 0x17001B28 RID: 6952
	// (get) Token: 0x06011D28 RID: 73000 RVA: 0x0053D15D File Offset: 0x0053B35D
	// (set) Token: 0x06011D29 RID: 73001 RVA: 0x0053D165 File Offset: 0x0053B365
	public bool IsMatchFinished { get; set; }

	// Token: 0x17001B29 RID: 6953
	// (get) Token: 0x06011D2A RID: 73002 RVA: 0x0053D16E File Offset: 0x0053B36E
	// (set) Token: 0x06011D2B RID: 73003 RVA: 0x0053D176 File Offset: 0x0053B376
	public bool IsPromote { get; set; }

	// Token: 0x17001B2A RID: 6954
	// (get) Token: 0x06011D2C RID: 73004 RVA: 0x0053D17F File Offset: 0x0053B37F
	// (set) Token: 0x06011D2D RID: 73005 RVA: 0x0053D187 File Offset: 0x0053B387
	public bool IsNeedPlayLevelSequence { get; set; }

	// Token: 0x17001B2B RID: 6955
	// (get) Token: 0x06011D2E RID: 73006 RVA: 0x0053D190 File Offset: 0x0053B390
	// (set) Token: 0x06011D2F RID: 73007 RVA: 0x0053D198 File Offset: 0x0053B398
	public bool IsCurMatch { get; set; }
}
