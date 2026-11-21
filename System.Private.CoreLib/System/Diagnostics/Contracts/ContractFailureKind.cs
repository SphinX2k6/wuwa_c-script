using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Contracts
{
	// Token: 0x020008A1 RID: 2209
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	public enum ContractFailureKind
	{
		// Token: 0x04001E5F RID: 7775
		Precondition,
		// Token: 0x04001E60 RID: 7776
		Postcondition,
		// Token: 0x04001E61 RID: 7777
		PostconditionOnException,
		// Token: 0x04001E62 RID: 7778
		Invariant,
		// Token: 0x04001E63 RID: 7779
		Assert,
		// Token: 0x04001E64 RID: 7780
		Assume
	}
}
