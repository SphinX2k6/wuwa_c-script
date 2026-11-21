using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D7E RID: 7550
[NullableContext(2)]
[Nullable(0)]
public class RoleDevPhantomSuitDisplayItemData : IRoleDevPhantomSuitDisplayItemData
{
	// Token: 0x17001C06 RID: 7174
	// (get) Token: 0x06012A44 RID: 76356 RVA: 0x0057D85C File Offset: 0x0057BA5C
	// (set) Token: 0x06012A45 RID: 76357 RVA: 0x0057D864 File Offset: 0x0057BA64
	public IPhantomMonsterItemData MonsterData { get; set; }

	// Token: 0x17001C07 RID: 7175
	// (get) Token: 0x06012A46 RID: 76358 RVA: 0x0057D86D File Offset: 0x0057BA6D
	// (set) Token: 0x06012A47 RID: 76359 RVA: 0x0057D875 File Offset: 0x0057BA75
	public IDropRewardItemData RewardData { get; set; }
}
