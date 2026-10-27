using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001610 RID: 5648
	public enum PhantomBattleBoardSettleType
	{
		// Token: 0x0400BFA6 RID: 49062
		[OriginalName("CommonSettle")]
		CommonSettle,
		// Token: 0x0400BFA7 RID: 49063
		[OriginalName("RoundSettle")]
		RoundSettle,
		// Token: 0x0400BFA8 RID: 49064
		[OriginalName("LimitSettle")]
		LimitSettle,
		// Token: 0x0400BFA9 RID: 49065
		[OriginalName("Skip")]
		Skip
	}
}
