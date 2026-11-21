using System;

// Token: 0x020009E4 RID: 2532
public class TowerGuideRewardItem : ITowerGuideRewardItem
{
	// Token: 0x17000D6A RID: 3434
	// (get) Token: 0x06006E73 RID: 28275 RVA: 0x00220FCD File Offset: 0x0021F1CD
	// (set) Token: 0x06006E74 RID: 28276 RVA: 0x00220FD5 File Offset: 0x0021F1D5
	public TItem Item { get; set; }

	// Token: 0x17000D6B RID: 3435
	// (get) Token: 0x06006E75 RID: 28277 RVA: 0x00220FDE File Offset: 0x0021F1DE
	// (set) Token: 0x06006E76 RID: 28278 RVA: 0x00220FE6 File Offset: 0x0021F1E6
	public bool IsLock { get; set; }

	// Token: 0x17000D6C RID: 3436
	// (get) Token: 0x06006E77 RID: 28279 RVA: 0x00220FEF File Offset: 0x0021F1EF
	// (set) Token: 0x06006E78 RID: 28280 RVA: 0x00220FF7 File Offset: 0x0021F1F7
	public bool IsReceivableVisible { get; set; }
}
