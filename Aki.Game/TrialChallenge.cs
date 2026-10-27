using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001DAA RID: 7594
[NullableContext(1)]
[Nullable(0)]
public class TrialChallenge : ITrialChallenge
{
	// Token: 0x17001269 RID: 4713
	// (get) Token: 0x0600E680 RID: 59008 RVA: 0x0036512C File Offset: 0x0036332C
	// (set) Token: 0x0600E681 RID: 59009 RVA: 0x00365134 File Offset: 0x00363334
	public int BoardId { get; set; }

	// Token: 0x1700126A RID: 4714
	// (get) Token: 0x0600E682 RID: 59010 RVA: 0x0036513D File Offset: 0x0036333D
	// (set) Token: 0x0600E683 RID: 59011 RVA: 0x00365145 File Offset: 0x00363345
	public IReadOnlyList<ITrialSubChallenge> SubChallenges { get; set; }
}
