using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004154 RID: 16724
	public enum IBtNode_Union : byte
	{
		// Token: 0x0400BFAF RID: 49071
		NONE,
		// Token: 0x0400BFB0 RID: 49072
		IBtNode,
		// Token: 0x0400BFB1 RID: 49073
		IStartBtNode,
		// Token: 0x0400BFB2 RID: 49074
		IQuestSucceedBtNode,
		// Token: 0x0400BFB3 RID: 49075
		IQuestFailedBtNode,
		// Token: 0x0400BFB4 RID: 49076
		IAlwaysTrueBtNode,
		// Token: 0x0400BFB5 RID: 49077
		IAlwaysFalseBtNode,
		// Token: 0x0400BFB6 RID: 49078
		IRepeaterBtNode,
		// Token: 0x0400BFB7 RID: 49079
		ILogicBtNode,
		// Token: 0x0400BFB8 RID: 49080
		ISequenceBtNode,
		// Token: 0x0400BFB9 RID: 49081
		ISelectBtNode,
		// Token: 0x0400BFBA RID: 49082
		IParallelSelectBtNode,
		// Token: 0x0400BFBB RID: 49083
		IConditionSelectorBtNode,
		// Token: 0x0400BFBC RID: 49084
		IConditionBtNode,
		// Token: 0x0400BFBD RID: 49085
		IChildQuestBtNode,
		// Token: 0x0400BFBE RID: 49086
		IActionBtNode,
		// Token: 0x0400BFBF RID: 49087
		IActionWithResultBtNode
	}
}
