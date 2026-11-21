using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200123B RID: 4667
[RequiredMember]
public class BtPendingUpdateOccupations : BehaviorTreePendingProcess
{
	// Token: 0x0600B968 RID: 47464 RVA: 0x0036BE6D File Offset: 0x0036A06D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateOccupations()
	{
	}

	// Token: 0x04006AAE RID: 27310
	[RequiredMember]
	public int SuspendNodeId;

	// Token: 0x04006AAF RID: 27311
	[RequiredMember]
	public int SuspendType;

	// Token: 0x04006AB0 RID: 27312
	[Nullable(1)]
	[RequiredMember]
	public IReadOnlyList<OccupationPbInfo> OccupationInfo;
}
