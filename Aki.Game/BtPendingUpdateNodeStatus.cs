using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001235 RID: 4661
[RequiredMember]
public class BtPendingUpdateNodeStatus : BehaviorTreePendingProcess
{
	// Token: 0x0600B962 RID: 47458 RVA: 0x0036BE3D File Offset: 0x0036A03D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateNodeStatus()
	{
	}

	// Token: 0x04006A9D RID: 27293
	[RequiredMember]
	public ENodeStatusUpdateReason Reason;

	// Token: 0x04006A9E RID: 27294
	[RequiredMember]
	public int NodeId;

	// Token: 0x04006A9F RID: 27295
	[RequiredMember]
	public NodeStatus NodeStatus;
}
