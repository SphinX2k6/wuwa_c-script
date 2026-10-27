using System;

// Token: 0x020027EC RID: 10220
public class PhantomMonsterItemData : IPhantomMonsterItemData, IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001B87 RID: 7047
	// (get) Token: 0x06014FB1 RID: 85937 RVA: 0x005512A0 File Offset: 0x0054F4A0
	// (set) Token: 0x06014FB2 RID: 85938 RVA: 0x005512A8 File Offset: 0x0054F4A8
	public ERoleDevItemType Type { get; set; }

	// Token: 0x17001B88 RID: 7048
	// (get) Token: 0x06014FB3 RID: 85939 RVA: 0x005512B1 File Offset: 0x0054F4B1
	// (set) Token: 0x06014FB4 RID: 85940 RVA: 0x005512B9 File Offset: 0x0054F4B9
	public int MonsterId { get; set; }

	// Token: 0x17001B89 RID: 7049
	// (get) Token: 0x06014FB5 RID: 85941 RVA: 0x005512C2 File Offset: 0x0054F4C2
	// (set) Token: 0x06014FB6 RID: 85942 RVA: 0x005512CA File Offset: 0x0054F4CA
	public int QualityId { get; set; }

	// Token: 0x17001B8A RID: 7050
	// (get) Token: 0x06014FB7 RID: 85943 RVA: 0x005512D3 File Offset: 0x0054F4D3
	// (set) Token: 0x06014FB8 RID: 85944 RVA: 0x005512DB File Offset: 0x0054F4DB
	public int RoleId { get; set; }
}
