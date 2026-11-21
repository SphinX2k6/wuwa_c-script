using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200126B RID: 4715
[NullableContext(1)]
public interface ITrialChallenge
{
	// Token: 0x17001291 RID: 4753
	// (get) Token: 0x0600BA9A RID: 47770
	// (set) Token: 0x0600BA9B RID: 47771
	int BoardId { get; set; }

	// Token: 0x17001292 RID: 4754
	// (get) Token: 0x0600BA9C RID: 47772
	// (set) Token: 0x0600BA9D RID: 47773
	IReadOnlyList<ITrialSubChallenge> SubChallenges { get; set; }
}
