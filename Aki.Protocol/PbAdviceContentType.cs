using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001550 RID: 5456
	public enum PbAdviceContentType
	{
		// Token: 0x0400A591 RID: 42385
		[OriginalName("Sentence")]
		Sentence,
		// Token: 0x0400A592 RID: 42386
		[OriginalName("Conjunction")]
		Conjunction,
		// Token: 0x0400A593 RID: 42387
		[OriginalName("Expression")]
		Expression,
		// Token: 0x0400A594 RID: 42388
		[OriginalName("Motion")]
		Motion
	}
}
