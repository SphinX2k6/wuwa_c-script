using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200167C RID: 5756
	public enum PhantomBatchOper
	{
		// Token: 0x0400C47C RID: 50300
		[OriginalName("Lock")]
		Lock,
		// Token: 0x0400C47D RID: 50301
		[OriginalName("Disuse")]
		Disuse,
		// Token: 0x0400C47E RID: 50302
		[OriginalName("Reset")]
		Reset
	}
}
