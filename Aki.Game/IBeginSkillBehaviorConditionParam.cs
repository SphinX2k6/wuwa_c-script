using System;
using System.Runtime.CompilerServices;

// Token: 0x02003154 RID: 12628
[NullableContext(2)]
public interface IBeginSkillBehaviorConditionParam
{
	// Token: 0x170025A4 RID: 9636
	// (get) Token: 0x0601B2E7 RID: 111335
	// (set) Token: 0x0601B2E8 RID: 111336
	[Nullable(1)]
	Entity Entity { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170025A5 RID: 9637
	// (get) Token: 0x0601B2E9 RID: 111337
	// (set) Token: 0x0601B2EA RID: 111338
	BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x170025A6 RID: 9638
	// (get) Token: 0x0601B2EB RID: 111339
	// (set) Token: 0x0601B2EC RID: 111340
	Skill Skill { get; set; }
}
