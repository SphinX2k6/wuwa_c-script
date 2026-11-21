using System;
using System.Runtime.CompilerServices;

// Token: 0x020026C2 RID: 9922
[NullableContext(1)]
public interface IBeginSkillBehaviorActionParam
{
	// Token: 0x17002798 RID: 10136
	// (get) Token: 0x06018DF2 RID: 101874
	// (set) Token: 0x06018DF3 RID: 101875
	Entity Entity { get; set; }

	// Token: 0x17002799 RID: 10137
	// (get) Token: 0x06018DF4 RID: 101876
	// (set) Token: 0x06018DF5 RID: 101877
	BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x1700279A RID: 10138
	// (get) Token: 0x06018DF6 RID: 101878
	// (set) Token: 0x06018DF7 RID: 101879
	Skill Skill { get; set; }
}
