using System;

// Token: 0x02000507 RID: 1287
public interface ICardPositionConfig
{
	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x06003EA1 RID: 16033
	// (set) Token: 0x06003EA2 RID: 16034
	float PositionRate { get; set; }

	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x06003EA3 RID: 16035
	// (set) Token: 0x06003EA4 RID: 16036
	float Spacing { get; set; }

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x06003EA5 RID: 16037
	// (set) Token: 0x06003EA6 RID: 16038
	float? UpOffset { get; set; }

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x06003EA7 RID: 16039
	// (set) Token: 0x06003EA8 RID: 16040
	float? Size { get; set; }

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x06003EA9 RID: 16041
	// (set) Token: 0x06003EAA RID: 16042
	float? Alpha { get; set; }
}
