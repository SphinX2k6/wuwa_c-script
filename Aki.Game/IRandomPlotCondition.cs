using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.LevelConditions;

// Token: 0x0200273D RID: 10045
[NullableContext(1)]
public interface IRandomPlotCondition
{
	// Token: 0x17001AF9 RID: 6905
	// (get) Token: 0x060149C3 RID: 84419
	// (set) Token: 0x060149C4 RID: 84420
	int ConditionGroupId { get; set; }

	// Token: 0x17001AFA RID: 6906
	// (get) Token: 0x060149C5 RID: 84421
	// (set) Token: 0x060149C6 RID: 84422
	ConditionPassCallback Callback { get; set; }
}
