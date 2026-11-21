using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F69 RID: 3945
	[EnumExtensions]
	public enum EBtNode
	{
		// Token: 0x040032BB RID: 12987
		Start,
		// Token: 0x040032BC RID: 12988
		QuestSucceed,
		// Token: 0x040032BD RID: 12989
		QuestFailed,
		// Token: 0x040032BE RID: 12990
		AlwaysTrue,
		// Token: 0x040032BF RID: 12991
		AlwaysFalse,
		// Token: 0x040032C0 RID: 12992
		Repeater,
		// Token: 0x040032C1 RID: 12993
		Sequence,
		// Token: 0x040032C2 RID: 12994
		Select,
		// Token: 0x040032C3 RID: 12995
		ParallelSelect,
		// Token: 0x040032C4 RID: 12996
		Condition,
		// Token: 0x040032C5 RID: 12997
		ConditionSelector,
		// Token: 0x040032C6 RID: 12998
		ChildQuest,
		// Token: 0x040032C7 RID: 12999
		Action,
		// Token: 0x040032C8 RID: 13000
		ActionWithResult
	}
}
