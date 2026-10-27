using System;
using System.Runtime.CompilerServices;

// Token: 0x02000248 RID: 584
[NullableContext(1)]
[Nullable(0)]
public class CloudGameUserInfo : ICloudGameUserInfo
{
	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x060023A1 RID: 9121 RVA: 0x000DAB0F File Offset: 0x000D8D0F
	// (set) Token: 0x060023A2 RID: 9122 RVA: 0x000DAB17 File Offset: 0x000D8D17
	public LoginInfo LoginInfo { get; set; }

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000DAB20 File Offset: 0x000D8D20
	// (set) Token: 0x060023A4 RID: 9124 RVA: 0x000DAB28 File Offset: 0x000D8D28
	public string TraceId { get; set; }

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000DAB31 File Offset: 0x000D8D31
	// (set) Token: 0x060023A6 RID: 9126 RVA: 0x000DAB39 File Offset: 0x000D8D39
	public string Platform { get; set; }

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000DAB42 File Offset: 0x000D8D42
	// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000DAB4A File Offset: 0x000D8D4A
	public float Fps { get; set; }

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000DAB53 File Offset: 0x000D8D53
	// (set) Token: 0x060023AA RID: 9130 RVA: 0x000DAB5B File Offset: 0x000D8D5B
	public float Dpi { get; set; }

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x060023AB RID: 9131 RVA: 0x000DAB64 File Offset: 0x000D8D64
	// (set) Token: 0x060023AC RID: 9132 RVA: 0x000DAB6C File Offset: 0x000D8D6C
	public ResolutionInfo DeviceResolution { get; set; }

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x060023AD RID: 9133 RVA: 0x000DAB75 File Offset: 0x000D8D75
	// (set) Token: 0x060023AE RID: 9134 RVA: 0x000DAB7D File Offset: 0x000D8D7D
	public ResolutionInfo ScreenResolution { get; set; }

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x060023AF RID: 9135 RVA: 0x000DAB86 File Offset: 0x000D8D86
	// (set) Token: 0x060023B0 RID: 9136 RVA: 0x000DAB8E File Offset: 0x000D8D8E
	public string ServerTag { get; set; }

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000DAB97 File Offset: 0x000D8D97
	// (set) Token: 0x060023B2 RID: 9138 RVA: 0x000DAB9F File Offset: 0x000D8D9F
	public string Device { get; set; }
}
