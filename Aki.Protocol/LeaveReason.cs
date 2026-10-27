using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001648 RID: 5704
	public enum LeaveReason
	{
		// Token: 0x0400C0EB RID: 49387
		[OriginalName("Initiative")]
		Initiative,
		// Token: 0x0400C0EC RID: 49388
		[OriginalName("BeKick")]
		BeKick,
		// Token: 0x0400C0ED RID: 49389
		[OriginalName("Dissolve")]
		Dissolve
	}
}
