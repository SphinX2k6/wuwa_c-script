using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046E0 RID: 18144
	public enum EChildQuestNodeState : byte
	{
		// Token: 0x0400C950 RID: 51536
		Inactive,
		// Token: 0x0400C951 RID: 51537
		EnteringNode,
		// Token: 0x0400C952 RID: 51538
		StartingAction,
		// Token: 0x0400C953 RID: 51539
		Running,
		// Token: 0x0400C954 RID: 51540
		CompletedButActionFailed,
		// Token: 0x0400C955 RID: 51541
		Completed,
		// Token: 0x0400C956 RID: 51542
		Failed
	}
}
