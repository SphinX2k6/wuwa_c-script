using System;
using System.Runtime.CompilerServices;

// Token: 0x02002802 RID: 10242
[NullableContext(2)]
public interface IRoleDevPhantomSuitDisplayItemData
{
	// Token: 0x17001BAC RID: 7084
	// (get) Token: 0x06015040 RID: 86080
	// (set) Token: 0x06015041 RID: 86081
	IPhantomMonsterItemData MonsterData { get; set; }

	// Token: 0x17001BAD RID: 7085
	// (get) Token: 0x06015042 RID: 86082
	// (set) Token: 0x06015043 RID: 86083
	IDropRewardItemData RewardData { get; set; }
}
