using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B5 RID: 5557
	public enum ENewLinkStage
	{
		// Token: 0x0400BC79 RID: 48249
		[OriginalName("NewLinkStageNone")]
		NewLinkStageNone,
		// Token: 0x0400BC7A RID: 48250
		[OriginalName("NewLinkStageLock")]
		NewLinkStageLock,
		// Token: 0x0400BC7B RID: 48251
		[OriginalName("Accumulate")]
		Accumulate,
		// Token: 0x0400BC7C RID: 48252
		[OriginalName("Ready")]
		Ready,
		// Token: 0x0400BC7D RID: 48253
		[OriginalName("Burst")]
		Burst
	}
}
