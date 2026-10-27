using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D73 RID: 7539
[RequiredMember]
public class BtPendingUpdateNodeStatus : BehaviorTreePendingProcess
{
	// Token: 0x0600E544 RID: 58692 RVA: 0x003601E9 File Offset: 0x0035E3E9
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateNodeStatus()
	{
	}

	// Token: 0x040069BD RID: 27069
	[RequiredMember]
	public ENodeStatusUpdateReason Reason;

	// Token: 0x040069BE RID: 27070
	[RequiredMember]
	public int NodeId;

	// Token: 0x040069BF RID: 27071
	[RequiredMember]
	public NodeStatus NodeStatus;
}
