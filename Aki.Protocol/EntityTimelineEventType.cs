using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D1 RID: 5585
	public enum EntityTimelineEventType
	{
		// Token: 0x0400BD79 RID: 48505
		[OriginalName("LeftIn")]
		LeftIn,
		// Token: 0x0400BD7A RID: 48506
		[OriginalName("LeftOut")]
		LeftOut,
		// Token: 0x0400BD7B RID: 48507
		[OriginalName("RightIn")]
		RightIn,
		// Token: 0x0400BD7C RID: 48508
		[OriginalName("RightOut")]
		RightOut
	}
}
