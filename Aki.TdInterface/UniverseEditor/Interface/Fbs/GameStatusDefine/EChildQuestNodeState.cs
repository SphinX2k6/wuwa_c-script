using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B48 RID: 19272
	public enum EChildQuestNodeState : byte
	{
		// Token: 0x0400D37F RID: 54143
		Inactive,
		// Token: 0x0400D380 RID: 54144
		EnteringNode,
		// Token: 0x0400D381 RID: 54145
		StartingAction,
		// Token: 0x0400D382 RID: 54146
		Running,
		// Token: 0x0400D383 RID: 54147
		CompletedButActionFailed,
		// Token: 0x0400D384 RID: 54148
		Completed,
		// Token: 0x0400D385 RID: 54149
		Failed
	}
}
