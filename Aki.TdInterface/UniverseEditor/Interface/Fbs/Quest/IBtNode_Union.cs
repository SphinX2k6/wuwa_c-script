using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D3D RID: 15677
	public enum IBtNode_Union : byte
	{
		// Token: 0x0400B602 RID: 46594
		NONE,
		// Token: 0x0400B603 RID: 46595
		IBtNode,
		// Token: 0x0400B604 RID: 46596
		IStartBtNode,
		// Token: 0x0400B605 RID: 46597
		IQuestSucceedBtNode,
		// Token: 0x0400B606 RID: 46598
		IQuestFailedBtNode,
		// Token: 0x0400B607 RID: 46599
		IAlwaysTrueBtNode,
		// Token: 0x0400B608 RID: 46600
		IAlwaysFalseBtNode,
		// Token: 0x0400B609 RID: 46601
		IRepeaterBtNode,
		// Token: 0x0400B60A RID: 46602
		ILogicBtNode,
		// Token: 0x0400B60B RID: 46603
		ISequenceBtNode,
		// Token: 0x0400B60C RID: 46604
		ISelectBtNode,
		// Token: 0x0400B60D RID: 46605
		IParallelSelectBtNode,
		// Token: 0x0400B60E RID: 46606
		IConditionSelectorBtNode,
		// Token: 0x0400B60F RID: 46607
		IConditionBtNode,
		// Token: 0x0400B610 RID: 46608
		IChildQuestBtNode,
		// Token: 0x0400B611 RID: 46609
		IActionBtNode,
		// Token: 0x0400B612 RID: 46610
		IActionWithResultBtNode
	}
}
