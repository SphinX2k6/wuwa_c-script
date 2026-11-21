using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004713 RID: 18195
	public enum TBtNode : byte
	{
		// Token: 0x0400C972 RID: 51570
		NONE,
		// Token: 0x0400C973 RID: 51571
		IActionBtNode,
		// Token: 0x0400C974 RID: 51572
		IActionWithResultBtNode,
		// Token: 0x0400C975 RID: 51573
		IAlwaysFalseBtNode,
		// Token: 0x0400C976 RID: 51574
		IAlwaysTrueBtNode,
		// Token: 0x0400C977 RID: 51575
		IChildQuestBtNode,
		// Token: 0x0400C978 RID: 51576
		IConditionBtNode,
		// Token: 0x0400C979 RID: 51577
		IConditionSelectorBtNode,
		// Token: 0x0400C97A RID: 51578
		IParallelSelectBtNode,
		// Token: 0x0400C97B RID: 51579
		IQuestFailedBtNode,
		// Token: 0x0400C97C RID: 51580
		IQuestSucceedBtNode,
		// Token: 0x0400C97D RID: 51581
		IRepeaterBtNode,
		// Token: 0x0400C97E RID: 51582
		ISelectBtNode,
		// Token: 0x0400C97F RID: 51583
		ISequenceBtNode,
		// Token: 0x0400C980 RID: 51584
		IStartBtNode
	}
}
