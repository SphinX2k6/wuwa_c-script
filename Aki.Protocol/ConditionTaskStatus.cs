using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015E0 RID: 5600
	public enum ConditionTaskStatus
	{
		// Token: 0x0400AAEA RID: 43754
		[OriginalName("Undone")]
		Undone,
		// Token: 0x0400AAEB RID: 43755
		[OriginalName("TaskFinish")]
		TaskFinish,
		// Token: 0x0400AAEC RID: 43756
		[OriginalName("Received")]
		Received
	}
}
