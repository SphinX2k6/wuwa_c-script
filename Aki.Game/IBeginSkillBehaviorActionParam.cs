using System;
using System.Runtime.CompilerServices;

// Token: 0x02003155 RID: 12629
[NullableContext(1)]
public interface IBeginSkillBehaviorActionParam
{
	// Token: 0x170025A7 RID: 9639
	// (get) Token: 0x0601B2ED RID: 111341
	// (set) Token: 0x0601B2EE RID: 111342
	Entity Entity { get; set; }

	// Token: 0x170025A8 RID: 9640
	// (get) Token: 0x0601B2EF RID: 111343
	// (set) Token: 0x0601B2F0 RID: 111344
	BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x170025A9 RID: 9641
	// (get) Token: 0x0601B2F1 RID: 111345
	// (set) Token: 0x0601B2F2 RID: 111346
	Skill Skill { get; set; }
}
