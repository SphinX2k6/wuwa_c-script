using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D77 RID: 7543
[RequiredMember]
public class BtPendingUpdateUpdateTimer : BehaviorTreePendingProcess
{
	// Token: 0x0600E548 RID: 58696 RVA: 0x00360209 File Offset: 0x0035E409
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateUpdateTimer()
	{
	}

	// Token: 0x040069C6 RID: 27078
	[Nullable(1)]
	[RequiredMember]
	public TimerInfoPb TimerInfo;
}
