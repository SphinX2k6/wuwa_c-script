using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.LevelConditions;

// Token: 0x0200273E RID: 10046
[NullableContext(1)]
[Nullable(0)]
public class RandomPlotCondition : IRandomPlotCondition
{
	// Token: 0x17001AFB RID: 6907
	// (get) Token: 0x060149C7 RID: 84423 RVA: 0x005376AA File Offset: 0x005358AA
	// (set) Token: 0x060149C8 RID: 84424 RVA: 0x005376B2 File Offset: 0x005358B2
	public int ConditionGroupId { get; set; }

	// Token: 0x17001AFC RID: 6908
	// (get) Token: 0x060149C9 RID: 84425 RVA: 0x005376BB File Offset: 0x005358BB
	// (set) Token: 0x060149CA RID: 84426 RVA: 0x005376C3 File Offset: 0x005358C3
	public ConditionPassCallback Callback { get; set; }
}
