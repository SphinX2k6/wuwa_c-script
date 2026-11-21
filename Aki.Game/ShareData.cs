using System;
using System.Runtime.CompilerServices;

// Token: 0x020002B9 RID: 697
[NullableContext(1)]
[Nullable(0)]
public class ShareData : IShareData
{
	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x060029FA RID: 10746 RVA: 0x00100F82 File Offset: 0x000FF182
	// (set) Token: 0x060029FB RID: 10747 RVA: 0x00100F8A File Offset: 0x000FF18A
	public string platform { get; set; } = "";

	// Token: 0x1700062E RID: 1582
	// (get) Token: 0x060029FC RID: 10748 RVA: 0x00100F93 File Offset: 0x000FF193
	// (set) Token: 0x060029FD RID: 10749 RVA: 0x00100F9B File Offset: 0x000FF19B
	public string title { get; set; } = "";

	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x060029FE RID: 10750 RVA: 0x00100FA4 File Offset: 0x000FF1A4
	// (set) Token: 0x060029FF RID: 10751 RVA: 0x00100FAC File Offset: 0x000FF1AC
	public string text { get; set; } = "";

	// Token: 0x17000630 RID: 1584
	// (get) Token: 0x06002A00 RID: 10752 RVA: 0x00100FB5 File Offset: 0x000FF1B5
	// (set) Token: 0x06002A01 RID: 10753 RVA: 0x00100FBD File Offset: 0x000FF1BD
	public string topicId { get; set; } = "";

	// Token: 0x17000631 RID: 1585
	// (get) Token: 0x06002A02 RID: 10754 RVA: 0x00100FC6 File Offset: 0x000FF1C6
	// (set) Token: 0x06002A03 RID: 10755 RVA: 0x00100FCE File Offset: 0x000FF1CE
	public string topicName { get; set; } = "";
}
