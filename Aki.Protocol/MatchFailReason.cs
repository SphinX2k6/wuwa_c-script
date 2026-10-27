using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015FA RID: 5626
	public enum MatchFailReason
	{
		// Token: 0x0400BF2D RID: 48941
		[OriginalName("TimeOut")]
		TimeOut,
		// Token: 0x0400BF2E RID: 48942
		[OriginalName("NotAccept")]
		NotAccept,
		// Token: 0x0400BF2F RID: 48943
		[OriginalName("ServerError")]
		ServerError
	}
}
