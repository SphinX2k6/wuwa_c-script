using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001624 RID: 5668
	public enum ERechallengeResultResult
	{
		// Token: 0x0400C01F RID: 49183
		[OriginalName("Accept")]
		Accept,
		// Token: 0x0400C020 RID: 49184
		[OriginalName("ActiveRefuse")]
		ActiveRefuse,
		// Token: 0x0400C021 RID: 49185
		[OriginalName("TimeOutRefuse")]
		TimeOutRefuse
	}
}
