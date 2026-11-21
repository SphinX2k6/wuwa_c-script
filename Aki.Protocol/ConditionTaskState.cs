using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C1 RID: 5569
	public enum ConditionTaskState
	{
		// Token: 0x0400A9DA RID: 43482
		[OriginalName("ConditionTaskRunning")]
		ConditionTaskRunning,
		// Token: 0x0400A9DB RID: 43483
		[OriginalName("ConditionTaskFinish")]
		ConditionTaskFinish,
		// Token: 0x0400A9DC RID: 43484
		[OriginalName("ConditionTaskTaken")]
		ConditionTaskTaken
	}
}
