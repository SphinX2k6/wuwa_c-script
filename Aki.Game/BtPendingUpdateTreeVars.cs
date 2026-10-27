using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D7A RID: 7546
[RequiredMember]
public class BtPendingUpdateTreeVars : BehaviorTreePendingProcess
{
	// Token: 0x0600E54B RID: 58699 RVA: 0x00360221 File Offset: 0x0035E421
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateTreeVars()
	{
	}

	// Token: 0x040069D1 RID: 27089
	[Nullable(1)]
	[RequiredMember]
	public BtVarUpdateNotify Notify;
}
