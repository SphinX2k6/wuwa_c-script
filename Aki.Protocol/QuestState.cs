using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001619 RID: 5657
	public enum QuestState
	{
		// Token: 0x0400BFE6 RID: 49126
		[OriginalName("InActive")]
		InActive,
		// Token: 0x0400BFE7 RID: 49127
		[OriginalName("Ready")]
		Ready,
		// Token: 0x0400BFE8 RID: 49128
		[OriginalName("Progress")]
		Progress,
		// Token: 0x0400BFE9 RID: 49129
		[OriginalName("Finish")]
		Finish,
		// Token: 0x0400BFEA RID: 49130
		[OriginalName("Delete")]
		Delete
	}
}
