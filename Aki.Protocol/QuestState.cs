using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200168C RID: 5772
	public enum QuestState
	{
		// Token: 0x0400C4E0 RID: 50400
		[OriginalName("InActive")]
		InActive,
		// Token: 0x0400C4E1 RID: 50401
		[OriginalName("Ready")]
		Ready,
		// Token: 0x0400C4E2 RID: 50402
		[OriginalName("Progress")]
		Progress,
		// Token: 0x0400C4E3 RID: 50403
		[OriginalName("Finish")]
		Finish,
		// Token: 0x0400C4E4 RID: 50404
		[OriginalName("Delete")]
		Delete
	}
}
