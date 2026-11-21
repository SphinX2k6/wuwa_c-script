using System;

// Token: 0x02001D66 RID: 7526
public interface IPhantomMonsterItemData : IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001BDC RID: 7132
	// (get) Token: 0x060129AB RID: 76203
	// (set) Token: 0x060129AC RID: 76204
	int MonsterId { get; set; }

	// Token: 0x17001BDD RID: 7133
	// (get) Token: 0x060129AD RID: 76205
	// (set) Token: 0x060129AE RID: 76206
	int QualityId { get; set; }

	// Token: 0x17001BDE RID: 7134
	// (get) Token: 0x060129AF RID: 76207
	// (set) Token: 0x060129B0 RID: 76208
	int RoleId { get; set; }
}
