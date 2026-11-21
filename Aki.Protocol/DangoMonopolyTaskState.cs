using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015BC RID: 5564
	public enum DangoMonopolyTaskState
	{
		// Token: 0x0400A9C6 RID: 43462
		[OriginalName("NotCompleted")]
		NotCompleted,
		// Token: 0x0400A9C7 RID: 43463
		[OriginalName("Completed")]
		Completed,
		// Token: 0x0400A9C8 RID: 43464
		[OriginalName("HasGet")]
		HasGet
	}
}
