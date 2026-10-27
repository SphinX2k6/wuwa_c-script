using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B7 RID: 17079
	public enum TBtNode : byte
	{
		// Token: 0x0400BF65 RID: 48997
		NONE,
		// Token: 0x0400BF66 RID: 48998
		IActionBtNode,
		// Token: 0x0400BF67 RID: 48999
		IActionWithResultBtNode,
		// Token: 0x0400BF68 RID: 49000
		IAlwaysFalseBtNode,
		// Token: 0x0400BF69 RID: 49001
		IAlwaysTrueBtNode,
		// Token: 0x0400BF6A RID: 49002
		IChildQuestBtNode,
		// Token: 0x0400BF6B RID: 49003
		IConditionBtNode,
		// Token: 0x0400BF6C RID: 49004
		IConditionSelectorBtNode,
		// Token: 0x0400BF6D RID: 49005
		IParallelSelectBtNode,
		// Token: 0x0400BF6E RID: 49006
		IQuestFailedBtNode,
		// Token: 0x0400BF6F RID: 49007
		IQuestSucceedBtNode,
		// Token: 0x0400BF70 RID: 49008
		IRepeaterBtNode,
		// Token: 0x0400BF71 RID: 49009
		ISelectBtNode,
		// Token: 0x0400BF72 RID: 49010
		ISequenceBtNode,
		// Token: 0x0400BF73 RID: 49011
		IStartBtNode
	}
}
