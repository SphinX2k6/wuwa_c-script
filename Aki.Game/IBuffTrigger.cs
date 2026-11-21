using System;
using System.Runtime.CompilerServices;

// Token: 0x020023D2 RID: 9170
[NullableContext(2)]
public interface IBuffTrigger
{
	// Token: 0x17002399 RID: 9113
	// (get) Token: 0x06017038 RID: 94264
	int ActiveHandleId { get; }

	// Token: 0x1700239A RID: 9114
	// (get) Token: 0x06017039 RID: 94265
	BaseBuffComponent InstigatorBuffComponent { get; }

	// Token: 0x0601703A RID: 94266
	[NullableContext(1)]
	bool TryExecute(Partial_RequirementPayload payload, IBuffComponent opponentBuffComp);
}
