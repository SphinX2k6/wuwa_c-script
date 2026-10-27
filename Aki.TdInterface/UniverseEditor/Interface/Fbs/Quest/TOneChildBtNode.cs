using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EA RID: 17130
	public enum TOneChildBtNode : byte
	{
		// Token: 0x0400C033 RID: 49203
		NONE,
		// Token: 0x0400C034 RID: 49204
		IAlwaysFalseBtNode,
		// Token: 0x0400C035 RID: 49205
		IAlwaysTrueBtNode,
		// Token: 0x0400C036 RID: 49206
		IRepeaterBtNode,
		// Token: 0x0400C037 RID: 49207
		IStartBtNode,
		// Token: 0x0400C038 RID: 49208
		IQuestSucceedBtNode,
		// Token: 0x0400C039 RID: 49209
		IQuestFailedBtNode,
		// Token: 0x0400C03A RID: 49210
		IConditionBtNode,
		// Token: 0x0400C03B RID: 49211
		IChildQuestBtNode,
		// Token: 0x0400C03C RID: 49212
		IActionBtNode,
		// Token: 0x0400C03D RID: 49213
		IActionWithResultBtNode
	}
}
