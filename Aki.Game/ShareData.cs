using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E06 RID: 3590
[NullableContext(1)]
[Nullable(0)]
public class ShareData : IShareData
{
	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x0600566B RID: 22123 RVA: 0x000F97BA File Offset: 0x000F79BA
	// (set) Token: 0x0600566C RID: 22124 RVA: 0x000F97C2 File Offset: 0x000F79C2
	public string platform { get; set; } = "";

	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x0600566D RID: 22125 RVA: 0x000F97CB File Offset: 0x000F79CB
	// (set) Token: 0x0600566E RID: 22126 RVA: 0x000F97D3 File Offset: 0x000F79D3
	public string title { get; set; } = "";

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x0600566F RID: 22127 RVA: 0x000F97DC File Offset: 0x000F79DC
	// (set) Token: 0x06005670 RID: 22128 RVA: 0x000F97E4 File Offset: 0x000F79E4
	public string text { get; set; } = "";

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x06005671 RID: 22129 RVA: 0x000F97ED File Offset: 0x000F79ED
	// (set) Token: 0x06005672 RID: 22130 RVA: 0x000F97F5 File Offset: 0x000F79F5
	public string topicId { get; set; } = "";

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x06005673 RID: 22131 RVA: 0x000F97FE File Offset: 0x000F79FE
	// (set) Token: 0x06005674 RID: 22132 RVA: 0x000F9806 File Offset: 0x000F7A06
	public string topicName { get; set; } = "";
}
