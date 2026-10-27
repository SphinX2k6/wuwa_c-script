using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200156A RID: 5482
	public enum ConditionTaskStatus
	{
		// Token: 0x0400A65D RID: 42589
		[OriginalName("Undone")]
		Undone,
		// Token: 0x0400A65E RID: 42590
		[OriginalName("TaskFinish")]
		TaskFinish,
		// Token: 0x0400A65F RID: 42591
		[OriginalName("Received")]
		Received
	}
}
