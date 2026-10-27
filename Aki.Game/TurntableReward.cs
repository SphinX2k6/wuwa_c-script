using System;

// Token: 0x0200153C RID: 5436
public class TurntableReward : ITurntableReward
{
	// Token: 0x17000D59 RID: 3417
	// (get) Token: 0x06009B76 RID: 39798 RVA: 0x0021A97D File Offset: 0x00218B7D
	// (set) Token: 0x06009B77 RID: 39799 RVA: 0x0021A985 File Offset: 0x00218B85
	public int Id { get; set; }

	// Token: 0x17000D5A RID: 3418
	// (get) Token: 0x06009B78 RID: 39800 RVA: 0x0021A98E File Offset: 0x00218B8E
	// (set) Token: 0x06009B79 RID: 39801 RVA: 0x0021A996 File Offset: 0x00218B96
	public int RoundId { get; set; }

	// Token: 0x17000D5B RID: 3419
	// (get) Token: 0x06009B7A RID: 39802 RVA: 0x0021A99F File Offset: 0x00218B9F
	// (set) Token: 0x06009B7B RID: 39803 RVA: 0x0021A9A7 File Offset: 0x00218BA7
	public bool IsClaimed { get; set; }

	// Token: 0x17000D5C RID: 3420
	// (get) Token: 0x06009B7C RID: 39804 RVA: 0x0021A9B0 File Offset: 0x00218BB0
	// (set) Token: 0x06009B7D RID: 39805 RVA: 0x0021A9B8 File Offset: 0x00218BB8
	public TItem RewardItem { get; set; }

	// Token: 0x17000D5D RID: 3421
	// (get) Token: 0x06009B7E RID: 39806 RVA: 0x0021A9C1 File Offset: 0x00218BC1
	// (set) Token: 0x06009B7F RID: 39807 RVA: 0x0021A9C9 File Offset: 0x00218BC9
	public bool IsSpecial { get; set; }
}
