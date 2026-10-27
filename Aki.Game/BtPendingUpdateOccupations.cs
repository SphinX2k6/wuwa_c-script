using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D79 RID: 7545
[RequiredMember]
public class BtPendingUpdateOccupations : BehaviorTreePendingProcess
{
	// Token: 0x0600E54A RID: 58698 RVA: 0x00360219 File Offset: 0x0035E419
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateOccupations()
	{
	}

	// Token: 0x040069CE RID: 27086
	[RequiredMember]
	public int SuspendNodeId;

	// Token: 0x040069CF RID: 27087
	[RequiredMember]
	public int SuspendType;

	// Token: 0x040069D0 RID: 27088
	[Nullable(1)]
	[RequiredMember]
	public IReadOnlyList<OccupationPbInfo> OccupationInfo;
}
