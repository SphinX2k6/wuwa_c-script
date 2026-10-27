using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001559 RID: 5465
	public enum BattlePassPayStatus
	{
		// Token: 0x0400A5F2 RID: 42482
		[OriginalName("NoPaid")]
		NoPaid,
		// Token: 0x0400A5F3 RID: 42483
		[OriginalName("Paid")]
		Paid,
		// Token: 0x0400A5F4 RID: 42484
		[OriginalName("Advanced")]
		Advanced
	}
}
