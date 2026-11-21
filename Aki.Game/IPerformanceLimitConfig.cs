using System;

// Token: 0x02000277 RID: 631
public interface IPerformanceLimitConfig
{
	// Token: 0x170005F1 RID: 1521
	// (get) Token: 0x060026E1 RID: 9953
	// (set) Token: 0x060026E2 RID: 9954
	bool FrameLimit { get; set; }

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x060026E3 RID: 9955
	// (set) Token: 0x060026E4 RID: 9956
	bool CacheWorldFrame { get; set; }
}
