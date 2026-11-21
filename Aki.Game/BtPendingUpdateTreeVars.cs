using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200123C RID: 4668
[RequiredMember]
public class BtPendingUpdateTreeVars : BehaviorTreePendingProcess
{
	// Token: 0x0600B969 RID: 47465 RVA: 0x0036BE75 File Offset: 0x0036A075
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateTreeVars()
	{
	}

	// Token: 0x04006AB1 RID: 27313
	[Nullable(1)]
	[RequiredMember]
	public BtVarUpdateNotify Notify;
}
