using System;
using System.Runtime.CompilerServices;

// Token: 0x02001343 RID: 4931
[NullableContext(2)]
[Nullable(0)]
public class MemoryItemData : IMemoryItemData
{
	// Token: 0x17000BB0 RID: 2992
	// (get) Token: 0x06008939 RID: 35129 RVA: 0x001D51CB File Offset: 0x001D33CB
	// (set) Token: 0x0600893A RID: 35130 RVA: 0x001D51D3 File Offset: 0x001D33D3
	public EMemoryContentId Type { get; set; }

	// Token: 0x17000BB1 RID: 2993
	// (get) Token: 0x0600893B RID: 35131 RVA: 0x001D51DC File Offset: 0x001D33DC
	// (set) Token: 0x0600893C RID: 35132 RVA: 0x001D51E4 File Offset: 0x001D33E4
	public EMemoryClassify Classify { get; set; }

	// Token: 0x17000BB2 RID: 2994
	// (get) Token: 0x0600893D RID: 35133 RVA: 0x001D51ED File Offset: 0x001D33ED
	// (set) Token: 0x0600893E RID: 35134 RVA: 0x001D51F5 File Offset: 0x001D33F5
	[Nullable(1)]
	public string Title { [NullableContext(1)] get; [NullableContext(1)] set; } = "";

	// Token: 0x17000BB3 RID: 2995
	// (get) Token: 0x0600893F RID: 35135 RVA: 0x001D51FE File Offset: 0x001D33FE
	// (set) Token: 0x06008940 RID: 35136 RVA: 0x001D5206 File Offset: 0x001D3406
	public bool HasData { get; set; }

	// Token: 0x17000BB4 RID: 2996
	// (get) Token: 0x06008941 RID: 35137 RVA: 0x001D520F File Offset: 0x001D340F
	// (set) Token: 0x06008942 RID: 35138 RVA: 0x001D5217 File Offset: 0x001D3417
	public bool IsDelegate { get; set; }

	// Token: 0x17000BB5 RID: 2997
	// (get) Token: 0x06008943 RID: 35139 RVA: 0x001D5220 File Offset: 0x001D3420
	// (set) Token: 0x06008944 RID: 35140 RVA: 0x001D5228 File Offset: 0x001D3428
	public int Sort { get; set; }

	// Token: 0x17000BB6 RID: 2998
	// (get) Token: 0x06008945 RID: 35141 RVA: 0x001D5231 File Offset: 0x001D3431
	// (set) Token: 0x06008946 RID: 35142 RVA: 0x001D5239 File Offset: 0x001D3439
	public string Content { get; set; }

	// Token: 0x17000BB7 RID: 2999
	// (get) Token: 0x06008947 RID: 35143 RVA: 0x001D5242 File Offset: 0x001D3442
	// (set) Token: 0x06008948 RID: 35144 RVA: 0x001D524A File Offset: 0x001D344A
	public string SubContent { get; set; }

	// Token: 0x17000BB8 RID: 3000
	// (get) Token: 0x06008949 RID: 35145 RVA: 0x001D5253 File Offset: 0x001D3453
	// (set) Token: 0x0600894A RID: 35146 RVA: 0x001D525B File Offset: 0x001D345B
	public string IconPath { get; set; }
}
