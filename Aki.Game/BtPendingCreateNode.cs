using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D72 RID: 7538
[RequiredMember]
public class BtPendingCreateNode : BehaviorTreePendingProcess
{
	// Token: 0x0600E543 RID: 58691 RVA: 0x003601E1 File Offset: 0x0035E3E1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingCreateNode()
	{
	}

	// Token: 0x040069BB RID: 27067
	[RequiredMember]
	public ENodeStatusUpdateReason Reason;

	// Token: 0x040069BC RID: 27068
	[Nullable(2)]
	[RequiredMember]
	public NodeInfo NodeInfo;
}
