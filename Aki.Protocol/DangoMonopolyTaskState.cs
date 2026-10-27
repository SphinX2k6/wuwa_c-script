using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001546 RID: 5446
	public enum DangoMonopolyTaskState
	{
		// Token: 0x0400A568 RID: 42344
		[OriginalName("NotCompleted")]
		NotCompleted,
		// Token: 0x0400A569 RID: 42345
		[OriginalName("Completed")]
		Completed,
		// Token: 0x0400A56A RID: 42346
		[OriginalName("HasGet")]
		HasGet
	}
}
