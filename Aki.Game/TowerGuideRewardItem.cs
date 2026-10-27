using System;

// Token: 0x0200152C RID: 5420
public class TowerGuideRewardItem : ITowerGuideRewardItem
{
	// Token: 0x17000D49 RID: 3401
	// (get) Token: 0x06009A95 RID: 39573 RVA: 0x00217231 File Offset: 0x00215431
	// (set) Token: 0x06009A96 RID: 39574 RVA: 0x00217239 File Offset: 0x00215439
	public TItem Item { get; set; }

	// Token: 0x17000D4A RID: 3402
	// (get) Token: 0x06009A97 RID: 39575 RVA: 0x00217242 File Offset: 0x00215442
	// (set) Token: 0x06009A98 RID: 39576 RVA: 0x0021724A File Offset: 0x0021544A
	public bool IsLock { get; set; }

	// Token: 0x17000D4B RID: 3403
	// (get) Token: 0x06009A99 RID: 39577 RVA: 0x00217253 File Offset: 0x00215453
	// (set) Token: 0x06009A9A RID: 39578 RVA: 0x0021725B File Offset: 0x0021545B
	public bool IsReceivableVisible { get; set; }
}
