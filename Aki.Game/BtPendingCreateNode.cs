using System;
using System.Runtime.CompilerServices;

// Token: 0x02001234 RID: 4660
[RequiredMember]
public class BtPendingCreateNode : BehaviorTreePendingProcess
{
	// Token: 0x0600B961 RID: 47457 RVA: 0x0036BE35 File Offset: 0x0036A035
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingCreateNode()
	{
	}

	// Token: 0x04006A9B RID: 27291
	[RequiredMember]
	public ENodeStatusUpdateReason Reason;

	// Token: 0x04006A9C RID: 27292
	[Nullable(2)]
	[RequiredMember]
	public NodeInfo NodeInfo;
}
