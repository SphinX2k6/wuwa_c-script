using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.LevelConditions;

// Token: 0x02001C28 RID: 7208
[NullableContext(1)]
public interface IRandomPlotCondition
{
	// Token: 0x17001B31 RID: 6961
	// (get) Token: 0x06011EA5 RID: 73381
	// (set) Token: 0x06011EA6 RID: 73382
	int ConditionGroupId { get; set; }

	// Token: 0x17001B32 RID: 6962
	// (get) Token: 0x06011EA7 RID: 73383
	// (set) Token: 0x06011EA8 RID: 73384
	ConditionPassCallback Callback { get; set; }
}
