using System;

// Token: 0x02001D67 RID: 7527
public class PhantomMonsterItemData : IPhantomMonsterItemData, IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001BDF RID: 7135
	// (get) Token: 0x060129B1 RID: 76209 RVA: 0x0057C010 File Offset: 0x0057A210
	// (set) Token: 0x060129B2 RID: 76210 RVA: 0x0057C018 File Offset: 0x0057A218
	public ERoleDevItemType Type { get; set; }

	// Token: 0x17001BE0 RID: 7136
	// (get) Token: 0x060129B3 RID: 76211 RVA: 0x0057C021 File Offset: 0x0057A221
	// (set) Token: 0x060129B4 RID: 76212 RVA: 0x0057C029 File Offset: 0x0057A229
	public int MonsterId { get; set; }

	// Token: 0x17001BE1 RID: 7137
	// (get) Token: 0x060129B5 RID: 76213 RVA: 0x0057C032 File Offset: 0x0057A232
	// (set) Token: 0x060129B6 RID: 76214 RVA: 0x0057C03A File Offset: 0x0057A23A
	public int QualityId { get; set; }

	// Token: 0x17001BE2 RID: 7138
	// (get) Token: 0x060129B7 RID: 76215 RVA: 0x0057C043 File Offset: 0x0057A243
	// (set) Token: 0x060129B8 RID: 76216 RVA: 0x0057C04B File Offset: 0x0057A24B
	public int RoleId { get; set; }
}
