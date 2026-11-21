using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015CF RID: 5583
	public enum BattlePassPayStatus
	{
		// Token: 0x0400AA7F RID: 43647
		[OriginalName("NoPaid")]
		NoPaid,
		// Token: 0x0400AA80 RID: 43648
		[OriginalName("Paid")]
		Paid,
		// Token: 0x0400AA81 RID: 43649
		[OriginalName("Advanced")]
		Advanced
	}
}
