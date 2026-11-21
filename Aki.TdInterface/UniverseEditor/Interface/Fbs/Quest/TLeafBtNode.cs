using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200473D RID: 18237
	public enum TLeafBtNode : byte
	{
		// Token: 0x0400CA26 RID: 51750
		NONE,
		// Token: 0x0400CA27 RID: 51751
		IActionBtNode,
		// Token: 0x0400CA28 RID: 51752
		IActionWithResultBtNode,
		// Token: 0x0400CA29 RID: 51753
		IChildQuestBtNode,
		// Token: 0x0400CA2A RID: 51754
		IConditionBtNode,
		// Token: 0x0400CA2B RID: 51755
		IQuestFailedBtNode,
		// Token: 0x0400CA2C RID: 51756
		IQuestSucceedBtNode,
		// Token: 0x0400CA2D RID: 51757
		IStartBtNode,
		// Token: 0x0400CA2E RID: 51758
		IAlwaysTrueBtNode,
		// Token: 0x0400CA2F RID: 51759
		IAlwaysFalseBtNode,
		// Token: 0x0400CA30 RID: 51760
		IRepeaterBtNode
	}
}
