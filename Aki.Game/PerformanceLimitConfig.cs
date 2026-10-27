using System;

// Token: 0x02000DC6 RID: 3526
public class PerformanceLimitConfig : IPerformanceLimitConfig
{
	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06005371 RID: 21361 RVA: 0x000E4FEB File Offset: 0x000E31EB
	// (set) Token: 0x06005372 RID: 21362 RVA: 0x000E4FF3 File Offset: 0x000E31F3
	public bool FrameLimit { get; set; }

	// Token: 0x170005CE RID: 1486
	// (get) Token: 0x06005373 RID: 21363 RVA: 0x000E4FFC File Offset: 0x000E31FC
	// (set) Token: 0x06005374 RID: 21364 RVA: 0x000E5004 File Offset: 0x000E3204
	public bool CacheWorldFrame { get; set; }
}
