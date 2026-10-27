using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001549 RID: 5449
	public enum ActivityOpenType
	{
		// Token: 0x0400A574 RID: 42356
		[OriginalName("TimeLimited")]
		TimeLimited,
		// Token: 0x0400A575 RID: 42357
		[OriginalName("Permanent")]
		Permanent,
		// Token: 0x0400A576 RID: 42358
		[OriginalName("LimitToPermanent")]
		LimitToPermanent
	}
}
