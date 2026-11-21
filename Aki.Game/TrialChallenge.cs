using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200126C RID: 4716
[NullableContext(1)]
[Nullable(0)]
public class TrialChallenge : ITrialChallenge
{
	// Token: 0x17001293 RID: 4755
	// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x00370D8C File Offset: 0x0036EF8C
	// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x00370D94 File Offset: 0x0036EF94
	public int BoardId { get; set; }

	// Token: 0x17001294 RID: 4756
	// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x00370D9D File Offset: 0x0036EF9D
	// (set) Token: 0x0600BAA1 RID: 47777 RVA: 0x00370DA5 File Offset: 0x0036EFA5
	public IReadOnlyList<ITrialSubChallenge> SubChallenges { get; set; }
}
