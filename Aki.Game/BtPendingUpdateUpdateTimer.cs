using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001239 RID: 4665
[RequiredMember]
public class BtPendingUpdateUpdateTimer : BehaviorTreePendingProcess
{
	// Token: 0x0600B966 RID: 47462 RVA: 0x0036BE5D File Offset: 0x0036A05D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateUpdateTimer()
	{
	}

	// Token: 0x04006AA6 RID: 27302
	[Nullable(1)]
	[RequiredMember]
	public TimerInfoPb TimerInfo;
}
