using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DE RID: 17118
	public enum TLeafBtNode : byte
	{
		// Token: 0x0400C00E RID: 49166
		NONE,
		// Token: 0x0400C00F RID: 49167
		IActionBtNode,
		// Token: 0x0400C010 RID: 49168
		IActionWithResultBtNode,
		// Token: 0x0400C011 RID: 49169
		IChildQuestBtNode,
		// Token: 0x0400C012 RID: 49170
		IConditionBtNode,
		// Token: 0x0400C013 RID: 49171
		IQuestFailedBtNode,
		// Token: 0x0400C014 RID: 49172
		IQuestSucceedBtNode,
		// Token: 0x0400C015 RID: 49173
		IStartBtNode,
		// Token: 0x0400C016 RID: 49174
		IAlwaysTrueBtNode,
		// Token: 0x0400C017 RID: 49175
		IAlwaysFalseBtNode,
		// Token: 0x0400C018 RID: 49176
		IRepeaterBtNode
	}
}
