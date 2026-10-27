using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001540 RID: 5440
	public enum SignState
	{
		// Token: 0x0400A550 RID: 42320
		[OriginalName("Lock")]
		Lock,
		// Token: 0x0400A551 RID: 42321
		[OriginalName("Unlock")]
		Unlock,
		// Token: 0x0400A552 RID: 42322
		[OriginalName("IsReceive")]
		IsReceive
	}
}
