using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200166D RID: 5741
	public enum MatchFailReason
	{
		// Token: 0x0400C427 RID: 50215
		[OriginalName("TimeOut")]
		TimeOut,
		// Token: 0x0400C428 RID: 50216
		[OriginalName("NotAccept")]
		NotAccept,
		// Token: 0x0400C429 RID: 50217
		[OriginalName("ServerError")]
		ServerError
	}
}
