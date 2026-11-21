using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004749 RID: 18249
	public enum TOneChildBtNode : byte
	{
		// Token: 0x0400CA4B RID: 51787
		NONE,
		// Token: 0x0400CA4C RID: 51788
		IAlwaysFalseBtNode,
		// Token: 0x0400CA4D RID: 51789
		IAlwaysTrueBtNode,
		// Token: 0x0400CA4E RID: 51790
		IRepeaterBtNode,
		// Token: 0x0400CA4F RID: 51791
		IStartBtNode,
		// Token: 0x0400CA50 RID: 51792
		IQuestSucceedBtNode,
		// Token: 0x0400CA51 RID: 51793
		IQuestFailedBtNode,
		// Token: 0x0400CA52 RID: 51794
		IConditionBtNode,
		// Token: 0x0400CA53 RID: 51795
		IChildQuestBtNode,
		// Token: 0x0400CA54 RID: 51796
		IActionBtNode,
		// Token: 0x0400CA55 RID: 51797
		IActionWithResultBtNode
	}
}
