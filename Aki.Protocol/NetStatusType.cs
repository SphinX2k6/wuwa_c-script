using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001555 RID: 5461
	public enum NetStatusType
	{
		// Token: 0x0400A5A8 RID: 42408
		[OriginalName("Wifi")]
		Wifi,
		// Token: 0x0400A5A9 RID: 42409
		[OriginalName("Stream")]
		Stream,
		// Token: 0x0400A5AA RID: 42410
		[OriginalName("Wired")]
		Wired,
		// Token: 0x0400A5AB RID: 42411
		[OriginalName("Other")]
		Other
	}
}
