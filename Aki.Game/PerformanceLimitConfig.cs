using System;

// Token: 0x02000278 RID: 632
public class PerformanceLimitConfig : IPerformanceLimitConfig
{
	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000EB58B File Offset: 0x000E978B
	// (set) Token: 0x060026E6 RID: 9958 RVA: 0x000EB593 File Offset: 0x000E9793
	public bool FrameLimit { get; set; }

	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000EB59C File Offset: 0x000E979C
	// (set) Token: 0x060026E8 RID: 9960 RVA: 0x000EB5A4 File Offset: 0x000E97A4
	public bool CacheWorldFrame { get; set; }
}
