using System;
using System.Runtime.CompilerServices;

// Token: 0x0200024C RID: 588
[NullableContext(1)]
[Nullable(0)]
public class CloudGameUserInfo : ICloudGameUserInfo
{
	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x06002459 RID: 9305 RVA: 0x000E1057 File Offset: 0x000DF257
	// (set) Token: 0x0600245A RID: 9306 RVA: 0x000E105F File Offset: 0x000DF25F
	public LoginInfo LoginInfo { get; set; }

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x0600245B RID: 9307 RVA: 0x000E1068 File Offset: 0x000DF268
	// (set) Token: 0x0600245C RID: 9308 RVA: 0x000E1070 File Offset: 0x000DF270
	public string TraceId { get; set; }

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x0600245D RID: 9309 RVA: 0x000E1079 File Offset: 0x000DF279
	// (set) Token: 0x0600245E RID: 9310 RVA: 0x000E1081 File Offset: 0x000DF281
	public string Platform { get; set; }

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x0600245F RID: 9311 RVA: 0x000E108A File Offset: 0x000DF28A
	// (set) Token: 0x06002460 RID: 9312 RVA: 0x000E1092 File Offset: 0x000DF292
	public float Fps { get; set; }

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x06002461 RID: 9313 RVA: 0x000E109B File Offset: 0x000DF29B
	// (set) Token: 0x06002462 RID: 9314 RVA: 0x000E10A3 File Offset: 0x000DF2A3
	public float Dpi { get; set; }

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x06002463 RID: 9315 RVA: 0x000E10AC File Offset: 0x000DF2AC
	// (set) Token: 0x06002464 RID: 9316 RVA: 0x000E10B4 File Offset: 0x000DF2B4
	public ResolutionInfo DeviceResolution { get; set; }

	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x06002465 RID: 9317 RVA: 0x000E10BD File Offset: 0x000DF2BD
	// (set) Token: 0x06002466 RID: 9318 RVA: 0x000E10C5 File Offset: 0x000DF2C5
	public ResolutionInfo ScreenResolution { get; set; }

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x06002467 RID: 9319 RVA: 0x000E10CE File Offset: 0x000DF2CE
	// (set) Token: 0x06002468 RID: 9320 RVA: 0x000E10D6 File Offset: 0x000DF2D6
	public string ServerTag { get; set; }

	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x06002469 RID: 9321 RVA: 0x000E10DF File Offset: 0x000DF2DF
	// (set) Token: 0x0600246A RID: 9322 RVA: 0x000E10E7 File Offset: 0x000DF2E7
	public string Device { get; set; }
}
