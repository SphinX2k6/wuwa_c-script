using System;

// Token: 0x02000DC5 RID: 3525
public interface IPerformanceLimitConfig
{
	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x0600536D RID: 21357
	// (set) Token: 0x0600536E RID: 21358
	bool FrameLimit { get; set; }

	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x0600536F RID: 21359
	// (set) Token: 0x06005370 RID: 21360
	bool CacheWorldFrame { get; set; }
}
