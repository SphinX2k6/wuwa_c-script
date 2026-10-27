using System;

// Token: 0x0200153B RID: 5435
public interface ITurntableReward
{
	// Token: 0x17000D54 RID: 3412
	// (get) Token: 0x06009B6C RID: 39788
	// (set) Token: 0x06009B6D RID: 39789
	int Id { get; set; }

	// Token: 0x17000D55 RID: 3413
	// (get) Token: 0x06009B6E RID: 39790
	// (set) Token: 0x06009B6F RID: 39791
	int RoundId { get; set; }

	// Token: 0x17000D56 RID: 3414
	// (get) Token: 0x06009B70 RID: 39792
	// (set) Token: 0x06009B71 RID: 39793
	bool IsClaimed { get; set; }

	// Token: 0x17000D57 RID: 3415
	// (get) Token: 0x06009B72 RID: 39794
	// (set) Token: 0x06009B73 RID: 39795
	TItem RewardItem { get; set; }

	// Token: 0x17000D58 RID: 3416
	// (get) Token: 0x06009B74 RID: 39796
	// (set) Token: 0x06009B75 RID: 39797
	bool IsSpecial { get; set; }
}
