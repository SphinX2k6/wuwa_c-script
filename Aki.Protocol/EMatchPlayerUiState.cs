using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001670 RID: 5744
	public enum EMatchPlayerUiState
	{
		// Token: 0x0400C43F RID: 50239
		[OriginalName("Wait")]
		Wait,
		// Token: 0x0400C440 RID: 50240
		[OriginalName("Confirm")]
		Confirm = 2,
		// Token: 0x0400C441 RID: 50241
		[OriginalName("Matching")]
		Matching,
		// Token: 0x0400C442 RID: 50242
		[OriginalName("Ready")]
		Ready,
		// Token: 0x0400C443 RID: 50243
		[OriginalName("Selecting")]
		Selecting,
		// Token: 0x0400C444 RID: 50244
		[OriginalName("Teleporting")]
		Teleporting,
		// Token: 0x0400C445 RID: 50245
		[OriginalName("Max")]
		Max
	}
}
