using System;

// Token: 0x020027EB RID: 10219
public interface IPhantomMonsterItemData : IUniversalSmallItemData<ERoleDevItemType>
{
	// Token: 0x17001B84 RID: 7044
	// (get) Token: 0x06014FAB RID: 85931
	// (set) Token: 0x06014FAC RID: 85932
	int MonsterId { get; set; }

	// Token: 0x17001B85 RID: 7045
	// (get) Token: 0x06014FAD RID: 85933
	// (set) Token: 0x06014FAE RID: 85934
	int QualityId { get; set; }

	// Token: 0x17001B86 RID: 7046
	// (get) Token: 0x06014FAF RID: 85935
	// (set) Token: 0x06014FB0 RID: 85936
	int RoleId { get; set; }
}
