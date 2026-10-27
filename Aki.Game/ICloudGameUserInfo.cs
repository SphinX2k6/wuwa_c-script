using System;
using System.Runtime.CompilerServices;

// Token: 0x02000247 RID: 583
[NullableContext(1)]
public interface ICloudGameUserInfo
{
	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x0600238F RID: 9103
	// (set) Token: 0x06002390 RID: 9104
	LoginInfo LoginInfo { get; set; }

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x06002391 RID: 9105
	// (set) Token: 0x06002392 RID: 9106
	string TraceId { get; set; }

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x06002393 RID: 9107
	// (set) Token: 0x06002394 RID: 9108
	string Platform { get; set; }

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x06002395 RID: 9109
	// (set) Token: 0x06002396 RID: 9110
	float Fps { get; set; }

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x06002397 RID: 9111
	// (set) Token: 0x06002398 RID: 9112
	float Dpi { get; set; }

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x06002399 RID: 9113
	// (set) Token: 0x0600239A RID: 9114
	ResolutionInfo DeviceResolution { get; set; }

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x0600239B RID: 9115
	// (set) Token: 0x0600239C RID: 9116
	ResolutionInfo ScreenResolution { get; set; }

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x0600239D RID: 9117
	// (set) Token: 0x0600239E RID: 9118
	string ServerTag { get; set; }

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x0600239F RID: 9119
	// (set) Token: 0x060023A0 RID: 9120
	string Device { get; set; }
}
