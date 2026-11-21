using System;
using System.Runtime.CompilerServices;

// Token: 0x020002DD RID: 733
[NullableContext(1)]
[Nullable(0)]
public class XboxGetRegionData
{
	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x06002A87 RID: 10887 RVA: 0x00101A0C File Offset: 0x000FFC0C
	// (set) Token: 0x06002A88 RID: 10888 RVA: 0x00101A14 File Offset: 0x000FFC14
	public int LoginType { get; set; }

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x06002A89 RID: 10889 RVA: 0x00101A1D File Offset: 0x000FFC1D
	// (set) Token: 0x06002A8A RID: 10890 RVA: 0x00101A25 File Offset: 0x000FFC25
	public string UserId { get; set; } = "";

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x06002A8B RID: 10891 RVA: 0x00101A2E File Offset: 0x000FFC2E
	// (set) Token: 0x06002A8C RID: 10892 RVA: 0x00101A36 File Offset: 0x000FFC36
	public string UserName { get; set; } = "";

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x06002A8D RID: 10893 RVA: 0x00101A3F File Offset: 0x000FFC3F
	// (set) Token: 0x06002A8E RID: 10894 RVA: 0x00101A47 File Offset: 0x000FFC47
	public string Token { get; set; } = "";
}
