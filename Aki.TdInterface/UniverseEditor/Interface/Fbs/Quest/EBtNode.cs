using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A2 RID: 16546
	public enum EBtNode : byte
	{
		// Token: 0x0400BC9D RID: 48285
		Start,
		// Token: 0x0400BC9E RID: 48286
		QuestSucceed,
		// Token: 0x0400BC9F RID: 48287
		QuestFailed,
		// Token: 0x0400BCA0 RID: 48288
		AlwaysTrue,
		// Token: 0x0400BCA1 RID: 48289
		AlwaysFalse,
		// Token: 0x0400BCA2 RID: 48290
		Repeater,
		// Token: 0x0400BCA3 RID: 48291
		Sequence,
		// Token: 0x0400BCA4 RID: 48292
		Select,
		// Token: 0x0400BCA5 RID: 48293
		ParallelSelect,
		// Token: 0x0400BCA6 RID: 48294
		Condition,
		// Token: 0x0400BCA7 RID: 48295
		ConditionSelector,
		// Token: 0x0400BCA8 RID: 48296
		ChildQuest,
		// Token: 0x0400BCA9 RID: 48297
		Action,
		// Token: 0x0400BCAA RID: 48298
		ActionWithResult
	}
}
