using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015BF RID: 5567
	public enum ActivityOpenType
	{
		// Token: 0x0400A9D2 RID: 43474
		[OriginalName("TimeLimited")]
		TimeLimited,
		// Token: 0x0400A9D3 RID: 43475
		[OriginalName("Permanent")]
		Permanent,
		// Token: 0x0400A9D4 RID: 43476
		[OriginalName("LimitToPermanent")]
		LimitToPermanent
	}
}
