using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003C90 RID: 15504
	public enum EBtNode : byte
	{
		// Token: 0x0400B306 RID: 45830
		Start,
		// Token: 0x0400B307 RID: 45831
		QuestSucceed,
		// Token: 0x0400B308 RID: 45832
		QuestFailed,
		// Token: 0x0400B309 RID: 45833
		AlwaysTrue,
		// Token: 0x0400B30A RID: 45834
		AlwaysFalse,
		// Token: 0x0400B30B RID: 45835
		Repeater,
		// Token: 0x0400B30C RID: 45836
		Sequence,
		// Token: 0x0400B30D RID: 45837
		Select,
		// Token: 0x0400B30E RID: 45838
		ParallelSelect,
		// Token: 0x0400B30F RID: 45839
		Condition,
		// Token: 0x0400B310 RID: 45840
		ConditionSelector,
		// Token: 0x0400B311 RID: 45841
		ChildQuest,
		// Token: 0x0400B312 RID: 45842
		Action,
		// Token: 0x0400B313 RID: 45843
		ActionWithResult
	}
}
