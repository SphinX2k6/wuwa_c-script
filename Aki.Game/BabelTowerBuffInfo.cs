using System;

// Token: 0x0200112F RID: 4399
public class BabelTowerBuffInfo : IBabelTowerBuffInfo
{
	// Token: 0x170009CB RID: 2507
	// (get) Token: 0x06007368 RID: 29544 RVA: 0x0017B9A6 File Offset: 0x00179BA6
	// (set) Token: 0x06007369 RID: 29545 RVA: 0x0017B9AE File Offset: 0x00179BAE
	public int Id { get; set; }

	// Token: 0x170009CC RID: 2508
	// (get) Token: 0x0600736A RID: 29546 RVA: 0x0017B9B7 File Offset: 0x00179BB7
	// (set) Token: 0x0600736B RID: 29547 RVA: 0x0017B9BF File Offset: 0x00179BBF
	public EBabelTowerBuffState State { get; set; }

	// Token: 0x170009CD RID: 2509
	// (get) Token: 0x0600736C RID: 29548 RVA: 0x0017B9C8 File Offset: 0x00179BC8
	// (set) Token: 0x0600736D RID: 29549 RVA: 0x0017B9D0 File Offset: 0x00179BD0
	public int? LevelId { get; set; }

	// Token: 0x170009CE RID: 2510
	// (get) Token: 0x0600736E RID: 29550 RVA: 0x0017B9D9 File Offset: 0x00179BD9
	// (set) Token: 0x0600736F RID: 29551 RVA: 0x0017B9E1 File Offset: 0x00179BE1
	public bool IsRecommend { get; set; }
}
