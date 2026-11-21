using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.LevelConditions;

// Token: 0x02001C29 RID: 7209
[NullableContext(1)]
[Nullable(0)]
public class RandomPlotCondition : IRandomPlotCondition
{
	// Token: 0x17001B33 RID: 6963
	// (get) Token: 0x06011EA9 RID: 73385 RVA: 0x005463B6 File Offset: 0x005445B6
	// (set) Token: 0x06011EAA RID: 73386 RVA: 0x005463BE File Offset: 0x005445BE
	public int ConditionGroupId { get; set; }

	// Token: 0x17001B34 RID: 6964
	// (get) Token: 0x06011EAB RID: 73387 RVA: 0x005463C7 File Offset: 0x005445C7
	// (set) Token: 0x06011EAC RID: 73388 RVA: 0x005463CF File Offset: 0x005445CF
	public ConditionPassCallback Callback { get; set; }
}
