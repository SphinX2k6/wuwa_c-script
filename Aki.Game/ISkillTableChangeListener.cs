using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200269C RID: 9884
[NullableContext(1)]
public interface ISkillTableChangeListener
{
	// Token: 0x06018C70 RID: 101488
	void OnSkillIdsChanged(IReadOnlyList<int> candidateSkillIds);
}
