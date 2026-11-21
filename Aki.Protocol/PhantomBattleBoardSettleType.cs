using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001683 RID: 5763
	public enum PhantomBattleBoardSettleType
	{
		// Token: 0x0400C4A0 RID: 50336
		[OriginalName("CommonSettle")]
		CommonSettle,
		// Token: 0x0400C4A1 RID: 50337
		[OriginalName("RoundSettle")]
		RoundSettle,
		// Token: 0x0400C4A2 RID: 50338
		[OriginalName("LimitSettle")]
		LimitSettle,
		// Token: 0x0400C4A3 RID: 50339
		[OriginalName("Skip")]
		Skip
	}
}
