using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B6 RID: 5558
	public enum SignState
	{
		// Token: 0x0400A9AE RID: 43438
		[OriginalName("Lock")]
		Lock,
		// Token: 0x0400A9AF RID: 43439
		[OriginalName("Unlock")]
		Unlock,
		// Token: 0x0400A9B0 RID: 43440
		[OriginalName("IsReceive")]
		IsReceive
	}
}
