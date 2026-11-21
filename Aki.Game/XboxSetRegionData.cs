using System;
using System.Runtime.CompilerServices;

// Token: 0x020002DF RID: 735
[NullableContext(1)]
[Nullable(0)]
public class XboxSetRegionData
{
	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x06002A97 RID: 10903 RVA: 0x00101ABF File Offset: 0x000FFCBF
	// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00101AC7 File Offset: 0x000FFCC7
	public int LoginType { get; set; }

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x06002A99 RID: 10905 RVA: 0x00101AD0 File Offset: 0x000FFCD0
	// (set) Token: 0x06002A9A RID: 10906 RVA: 0x00101AD8 File Offset: 0x000FFCD8
	public string Region { get; set; } = "";

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x06002A9B RID: 10907 RVA: 0x00101AE1 File Offset: 0x000FFCE1
	// (set) Token: 0x06002A9C RID: 10908 RVA: 0x00101AE9 File Offset: 0x000FFCE9
	public string UserId { get; set; } = "";

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x06002A9D RID: 10909 RVA: 0x00101AF2 File Offset: 0x000FFCF2
	// (set) Token: 0x06002A9E RID: 10910 RVA: 0x00101AFA File Offset: 0x000FFCFA
	public string UserName { get; set; } = "";

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x06002A9F RID: 10911 RVA: 0x00101B03 File Offset: 0x000FFD03
	// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x00101B0B File Offset: 0x000FFD0B
	public string Token { get; set; } = "";
}
