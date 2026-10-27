using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000E58 RID: 3672
	[EnumExtensions]
	public enum EBtNode
	{
		// Token: 0x04002FC4 RID: 12228
		Start,
		// Token: 0x04002FC5 RID: 12229
		QuestSucceed,
		// Token: 0x04002FC6 RID: 12230
		QuestFailed,
		// Token: 0x04002FC7 RID: 12231
		AlwaysTrue,
		// Token: 0x04002FC8 RID: 12232
		AlwaysFalse,
		// Token: 0x04002FC9 RID: 12233
		Repeater,
		// Token: 0x04002FCA RID: 12234
		Sequence,
		// Token: 0x04002FCB RID: 12235
		Select,
		// Token: 0x04002FCC RID: 12236
		ParallelSelect,
		// Token: 0x04002FCD RID: 12237
		Condition,
		// Token: 0x04002FCE RID: 12238
		ConditionSelector,
		// Token: 0x04002FCF RID: 12239
		ChildQuest,
		// Token: 0x04002FD0 RID: 12240
		Action,
		// Token: 0x04002FD1 RID: 12241
		ActionWithResult
	}
}
