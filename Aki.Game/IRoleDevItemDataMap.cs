using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D68 RID: 7528
[NullableContext(1)]
public interface IRoleDevItemDataMap
{
	// Token: 0x17001BE3 RID: 7139
	// (get) Token: 0x060129BA RID: 76218
	// (set) Token: 0x060129BB RID: 76219
	IMaterialItemData Material { get; set; }

	// Token: 0x17001BE4 RID: 7140
	// (get) Token: 0x060129BC RID: 76220
	// (set) Token: 0x060129BD RID: 76221
	IDropRewardItemData Reward { get; set; }

	// Token: 0x17001BE5 RID: 7141
	// (get) Token: 0x060129BE RID: 76222
	// (set) Token: 0x060129BF RID: 76223
	IPhantomMonsterItemData Monster { get; set; }
}
