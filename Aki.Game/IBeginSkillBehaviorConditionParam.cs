using System;
using System.Runtime.CompilerServices;

// Token: 0x020026C1 RID: 9921
[NullableContext(2)]
public interface IBeginSkillBehaviorConditionParam
{
	// Token: 0x17002795 RID: 10133
	// (get) Token: 0x06018DEC RID: 101868
	// (set) Token: 0x06018DED RID: 101869
	[Nullable(1)]
	Entity Entity { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17002796 RID: 10134
	// (get) Token: 0x06018DEE RID: 101870
	// (set) Token: 0x06018DEF RID: 101871
	BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x17002797 RID: 10135
	// (get) Token: 0x06018DF0 RID: 101872
	// (set) Token: 0x06018DF1 RID: 101873
	Skill Skill { get; set; }
}
