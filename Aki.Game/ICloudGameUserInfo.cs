using System;
using System.Runtime.CompilerServices;

// Token: 0x0200024B RID: 587
[NullableContext(1)]
public interface ICloudGameUserInfo
{
	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x06002447 RID: 9287
	// (set) Token: 0x06002448 RID: 9288
	LoginInfo LoginInfo { get; set; }

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x06002449 RID: 9289
	// (set) Token: 0x0600244A RID: 9290
	string TraceId { get; set; }

	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x0600244B RID: 9291
	// (set) Token: 0x0600244C RID: 9292
	string Platform { get; set; }

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x0600244D RID: 9293
	// (set) Token: 0x0600244E RID: 9294
	float Fps { get; set; }

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x0600244F RID: 9295
	// (set) Token: 0x06002450 RID: 9296
	float Dpi { get; set; }

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x06002451 RID: 9297
	// (set) Token: 0x06002452 RID: 9298
	ResolutionInfo DeviceResolution { get; set; }

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06002453 RID: 9299
	// (set) Token: 0x06002454 RID: 9300
	ResolutionInfo ScreenResolution { get; set; }

	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x06002455 RID: 9301
	// (set) Token: 0x06002456 RID: 9302
	string ServerTag { get; set; }

	// Token: 0x1700059D RID: 1437
	// (get) Token: 0x06002457 RID: 9303
	// (set) Token: 0x06002458 RID: 9304
	string Device { get; set; }
}
