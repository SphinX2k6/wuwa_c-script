using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D7D RID: 7549
[NullableContext(2)]
public interface IRoleDevPhantomSuitDisplayItemData
{
	// Token: 0x17001C04 RID: 7172
	// (get) Token: 0x06012A40 RID: 76352
	// (set) Token: 0x06012A41 RID: 76353
	IPhantomMonsterItemData MonsterData { get; set; }

	// Token: 0x17001C05 RID: 7173
	// (get) Token: 0x06012A42 RID: 76354
	// (set) Token: 0x06012A43 RID: 76355
	IDropRewardItemData RewardData { get; set; }
}
