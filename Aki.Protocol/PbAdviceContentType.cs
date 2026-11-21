using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C6 RID: 5574
	public enum PbAdviceContentType
	{
		// Token: 0x0400A9EF RID: 43503
		[OriginalName("Sentence")]
		Sentence,
		// Token: 0x0400A9F0 RID: 43504
		[OriginalName("Conjunction")]
		Conjunction,
		// Token: 0x0400A9F1 RID: 43505
		[OriginalName("Expression")]
		Expression,
		// Token: 0x0400A9F2 RID: 43506
		[OriginalName("Motion")]
		Motion
	}
}
