using System;
using System.Runtime.CompilerServices;

// Token: 0x020002DE RID: 734
[NullableContext(1)]
[Nullable(0)]
public class XboxRegionInfo
{
	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x06002A90 RID: 10896 RVA: 0x00101A79 File Offset: 0x000FFC79
	// (set) Token: 0x06002A91 RID: 10897 RVA: 0x00101A81 File Offset: 0x000FFC81
	public int Code { get; set; }

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x06002A92 RID: 10898 RVA: 0x00101A8A File Offset: 0x000FFC8A
	// (set) Token: 0x06002A93 RID: 10899 RVA: 0x00101A92 File Offset: 0x000FFC92
	public int SdkLoginCode { get; set; }

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x06002A94 RID: 10900 RVA: 0x00101A9B File Offset: 0x000FFC9B
	// (set) Token: 0x06002A95 RID: 10901 RVA: 0x00101AA3 File Offset: 0x000FFCA3
	public string Region { get; set; } = "";
}
