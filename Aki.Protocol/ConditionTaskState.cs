using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154B RID: 5451
	public enum ConditionTaskState
	{
		// Token: 0x0400A57C RID: 42364
		[OriginalName("ConditionTaskRunning")]
		ConditionTaskRunning,
		// Token: 0x0400A57D RID: 42365
		[OriginalName("ConditionTaskFinish")]
		ConditionTaskFinish,
		// Token: 0x0400A57E RID: 42366
		[OriginalName("ConditionTaskTaken")]
		ConditionTaskTaken
	}
}
