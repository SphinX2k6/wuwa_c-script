using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001609 RID: 5641
	public enum EntityState
	{
		// Token: 0x0400AC4F RID: 44111
		[OriginalName("Default")]
		Default,
		// Token: 0x0400AC50 RID: 44112
		[OriginalName("Sleep")]
		Sleep,
		// Token: 0x0400AC51 RID: 44113
		[OriginalName("Born")]
		Born,
		// Token: 0x0400AC52 RID: 44114
		[OriginalName("Other")]
		Other
	}
}
