using System;
using System.Runtime.CompilerServices;

// Token: 0x020008DB RID: 2267
[NullableContext(2)]
[Nullable(0)]
public class PinballItemDataRole : IPinballItemDataRole
{
	// Token: 0x17000CC3 RID: 3267
	// (get) Token: 0x06006525 RID: 25893 RVA: 0x001FBA6D File Offset: 0x001F9C6D
	// (set) Token: 0x06006526 RID: 25894 RVA: 0x001FBA75 File Offset: 0x001F9C75
	public EPinballItemType Type { get; set; }

	// Token: 0x17000CC4 RID: 3268
	// (get) Token: 0x06006527 RID: 25895 RVA: 0x001FBA7E File Offset: 0x001F9C7E
	// (set) Token: 0x06006528 RID: 25896 RVA: 0x001FBA86 File Offset: 0x001F9C86
	public int Id { get; set; }

	// Token: 0x17000CC5 RID: 3269
	// (get) Token: 0x06006529 RID: 25897 RVA: 0x001FBA8F File Offset: 0x001F9C8F
	// (set) Token: 0x0600652A RID: 25898 RVA: 0x001FBA97 File Offset: 0x001F9C97
	public bool? IsRecommend { get; set; }

	// Token: 0x17000CC6 RID: 3270
	// (get) Token: 0x0600652B RID: 25899 RVA: 0x001FBAA0 File Offset: 0x001F9CA0
	// (set) Token: 0x0600652C RID: 25900 RVA: 0x001FBAA8 File Offset: 0x001F9CA8
	public int? BdId { get; set; }

	// Token: 0x17000CC7 RID: 3271
	// (get) Token: 0x0600652D RID: 25901 RVA: 0x001FBAB1 File Offset: 0x001F9CB1
	// (set) Token: 0x0600652E RID: 25902 RVA: 0x001FBAB9 File Offset: 0x001F9CB9
	public bool? IsLocked { get; set; }

	// Token: 0x17000CC8 RID: 3272
	// (get) Token: 0x0600652F RID: 25903 RVA: 0x001FBAC2 File Offset: 0x001F9CC2
	// (set) Token: 0x06006530 RID: 25904 RVA: 0x001FBACA File Offset: 0x001F9CCA
	public bool? IsUnavailable { get; set; }

	// Token: 0x17000CC9 RID: 3273
	// (get) Token: 0x06006531 RID: 25905 RVA: 0x001FBAD3 File Offset: 0x001F9CD3
	// (set) Token: 0x06006532 RID: 25906 RVA: 0x001FBADB File Offset: 0x001F9CDB
	public TableTextArgNew BottomText { get; set; }

	// Token: 0x17000CCA RID: 3274
	// (get) Token: 0x06006533 RID: 25907 RVA: 0x001FBAE4 File Offset: 0x001F9CE4
	// (set) Token: 0x06006534 RID: 25908 RVA: 0x001FBAEC File Offset: 0x001F9CEC
	public string BottomPlainText { get; set; }

	// Token: 0x17000CCB RID: 3275
	// (get) Token: 0x06006535 RID: 25909 RVA: 0x001FBAF5 File Offset: 0x001F9CF5
	// (set) Token: 0x06006536 RID: 25910 RVA: 0x001FBAFD File Offset: 0x001F9CFD
	public int? ClassId { get; set; }
}
