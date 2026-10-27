using System;

// Token: 0x0200124A RID: 4682
public class DangoMonopolyRoundRewardItemData : IDangoMonopolyRoundRewardItemData
{
	// Token: 0x17000AC7 RID: 2759
	// (get) Token: 0x06007F1A RID: 32538 RVA: 0x001AEE4A File Offset: 0x001AD04A
	// (set) Token: 0x06007F1B RID: 32539 RVA: 0x001AEE52 File Offset: 0x001AD052
	public bool IsReceived { get; set; }

	// Token: 0x17000AC8 RID: 2760
	// (get) Token: 0x06007F1C RID: 32540 RVA: 0x001AEE5B File Offset: 0x001AD05B
	// (set) Token: 0x06007F1D RID: 32541 RVA: 0x001AEE63 File Offset: 0x001AD063
	public bool IsCanReceived { get; set; }

	// Token: 0x17000AC9 RID: 2761
	// (get) Token: 0x06007F1E RID: 32542 RVA: 0x001AEE6C File Offset: 0x001AD06C
	// (set) Token: 0x06007F1F RID: 32543 RVA: 0x001AEE74 File Offset: 0x001AD074
	public int ItemId { get; set; }

	// Token: 0x17000ACA RID: 2762
	// (get) Token: 0x06007F20 RID: 32544 RVA: 0x001AEE7D File Offset: 0x001AD07D
	// (set) Token: 0x06007F21 RID: 32545 RVA: 0x001AEE85 File Offset: 0x001AD085
	public int Count { get; set; }

	// Token: 0x17000ACB RID: 2763
	// (get) Token: 0x06007F22 RID: 32546 RVA: 0x001AEE8E File Offset: 0x001AD08E
	// (set) Token: 0x06007F23 RID: 32547 RVA: 0x001AEE96 File Offset: 0x001AD096
	public int BoardId { get; set; }

	// Token: 0x17000ACC RID: 2764
	// (get) Token: 0x06007F24 RID: 32548 RVA: 0x001AEE9F File Offset: 0x001AD09F
	// (set) Token: 0x06007F25 RID: 32549 RVA: 0x001AEEA7 File Offset: 0x001AD0A7
	public bool IsCurrent { get; set; }

	// Token: 0x17000ACD RID: 2765
	// (get) Token: 0x06007F26 RID: 32550 RVA: 0x001AEEB0 File Offset: 0x001AD0B0
	// (set) Token: 0x06007F27 RID: 32551 RVA: 0x001AEEB8 File Offset: 0x001AD0B8
	public int Position { get; set; }
}
