using System;
using System.Runtime.CompilerServices;

// Token: 0x02001231 RID: 4657
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyRoundBuffData : IDangoMonopolyRoundBuffData
{
	// Token: 0x17000AA8 RID: 2728
	// (get) Token: 0x06007DE7 RID: 32231 RVA: 0x001AADA4 File Offset: 0x001A8FA4
	// (set) Token: 0x06007DE8 RID: 32232 RVA: 0x001AADAC File Offset: 0x001A8FAC
	public int DangoId { get; set; }

	// Token: 0x17000AA9 RID: 2729
	// (get) Token: 0x06007DE9 RID: 32233 RVA: 0x001AADB5 File Offset: 0x001A8FB5
	// (set) Token: 0x06007DEA RID: 32234 RVA: 0x001AADBD File Offset: 0x001A8FBD
	public int PropertyId { get; set; }

	// Token: 0x17000AAA RID: 2730
	// (get) Token: 0x06007DEB RID: 32235 RVA: 0x001AADC6 File Offset: 0x001A8FC6
	// (set) Token: 0x06007DEC RID: 32236 RVA: 0x001AADCE File Offset: 0x001A8FCE
	public int GridId { get; set; }

	// Token: 0x17000AAB RID: 2731
	// (get) Token: 0x06007DED RID: 32237 RVA: 0x001AADD7 File Offset: 0x001A8FD7
	// (set) Token: 0x06007DEE RID: 32238 RVA: 0x001AADDF File Offset: 0x001A8FDF
	public bool IsActive { get; set; }

	// Token: 0x17000AAC RID: 2732
	// (get) Token: 0x06007DEF RID: 32239 RVA: 0x001AADE8 File Offset: 0x001A8FE8
	// (set) Token: 0x06007DF0 RID: 32240 RVA: 0x001AADF0 File Offset: 0x001A8FF0
	public string DangoIcon { get; set; } = "";

	// Token: 0x17000AAD RID: 2733
	// (get) Token: 0x06007DF1 RID: 32241 RVA: 0x001AADF9 File Offset: 0x001A8FF9
	// (set) Token: 0x06007DF2 RID: 32242 RVA: 0x001AAE01 File Offset: 0x001A9001
	public string DangoName { get; set; } = "";

	// Token: 0x17000AAE RID: 2734
	// (get) Token: 0x06007DF3 RID: 32243 RVA: 0x001AAE0A File Offset: 0x001A900A
	// (set) Token: 0x06007DF4 RID: 32244 RVA: 0x001AAE12 File Offset: 0x001A9012
	public string PropertyDesc { get; set; } = "";

	// Token: 0x17000AAF RID: 2735
	// (get) Token: 0x06007DF5 RID: 32245 RVA: 0x001AAE1B File Offset: 0x001A901B
	// (set) Token: 0x06007DF6 RID: 32246 RVA: 0x001AAE23 File Offset: 0x001A9023
	public string PropertyTitle { get; set; } = "";
}
