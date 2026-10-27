using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015FD RID: 5629
	public enum EMatchPlayerUiState
	{
		// Token: 0x0400BF45 RID: 48965
		[OriginalName("Wait")]
		Wait,
		// Token: 0x0400BF46 RID: 48966
		[OriginalName("Confirm")]
		Confirm = 2,
		// Token: 0x0400BF47 RID: 48967
		[OriginalName("Matching")]
		Matching,
		// Token: 0x0400BF48 RID: 48968
		[OriginalName("Ready")]
		Ready,
		// Token: 0x0400BF49 RID: 48969
		[OriginalName("Selecting")]
		Selecting,
		// Token: 0x0400BF4A RID: 48970
		[OriginalName("Teleporting")]
		Teleporting,
		// Token: 0x0400BF4B RID: 48971
		[OriginalName("Max")]
		Max
	}
}
