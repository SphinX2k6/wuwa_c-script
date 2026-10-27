using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001DA9 RID: 7593
[NullableContext(1)]
public interface ITrialChallenge
{
	// Token: 0x17001267 RID: 4711
	// (get) Token: 0x0600E67C RID: 59004
	// (set) Token: 0x0600E67D RID: 59005
	int BoardId { get; set; }

	// Token: 0x17001268 RID: 4712
	// (get) Token: 0x0600E67E RID: 59006
	// (set) Token: 0x0600E67F RID: 59007
	IReadOnlyList<ITrialSubChallenge> SubChallenges { get; set; }
}
