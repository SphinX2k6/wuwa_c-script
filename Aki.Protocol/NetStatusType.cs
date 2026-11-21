using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015CB RID: 5579
	public enum NetStatusType
	{
		// Token: 0x0400AA06 RID: 43526
		[OriginalName("Wifi")]
		Wifi,
		// Token: 0x0400AA07 RID: 43527
		[OriginalName("Stream")]
		Stream,
		// Token: 0x0400AA08 RID: 43528
		[OriginalName("Wired")]
		Wired,
		// Token: 0x0400AA09 RID: 43529
		[OriginalName("Other")]
		Other
	}
}
