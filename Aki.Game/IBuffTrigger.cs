using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E80 RID: 11904
[NullableContext(2)]
public interface IBuffTrigger
{
	// Token: 0x1700230E RID: 8974
	// (get) Token: 0x06019762 RID: 104290
	int ActiveHandleId { get; }

	// Token: 0x1700230F RID: 8975
	// (get) Token: 0x06019763 RID: 104291
	BaseBuffComponent InstigatorBuffComponent { get; }

	// Token: 0x06019764 RID: 104292
	[NullableContext(1)]
	bool TryExecute(Partial_RequirementPayload payload, IBuffComponent opponentBuffComp);
}
