using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001697 RID: 5783
	public enum ERechallengeResultResult
	{
		// Token: 0x0400C519 RID: 50457
		[OriginalName("Accept")]
		Accept,
		// Token: 0x0400C51A RID: 50458
		[OriginalName("ActiveRefuse")]
		ActiveRefuse,
		// Token: 0x0400C51B RID: 50459
		[OriginalName("TimeOutRefuse")]
		TimeOutRefuse
	}
}
