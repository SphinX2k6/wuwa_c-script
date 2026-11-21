using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200203C RID: 8252
public class SurvivorsActivityDefine
{
	// Token: 0x0400AD46 RID: 44358
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static Dictionary<ESurvivorsTalentEffectShowType, string> effectShowTypeColorRecord = new Dictionary<ESurvivorsTalentEffectShowType, string>
	{
		{
			ESurvivorsTalentEffectShowType.Tips,
			"364c83ff"
		},
		{
			ESurvivorsTalentEffectShowType.Desc,
			"603683ff"
		},
		{
			ESurvivorsTalentEffectShowType.Item,
			"36837dff"
		}
	};

	// Token: 0x02008331 RID: 33585
	public class SurvivorsLevelInfo
	{
		// Token: 0x0402A630 RID: 173616
		public int LevelId;

		// Token: 0x0402A631 RID: 173617
		public int InstId;

		// Token: 0x0402A632 RID: 173618
		public int RoleId;

		// Token: 0x0402A633 RID: 173619
		public bool IsEndless;

		// Token: 0x0402A634 RID: 173620
		public bool IsSaveFile;

		// Token: 0x0402A635 RID: 173621
		public int Batch;

		// Token: 0x0402A636 RID: 173622
		public int MaxBatch;
	}
}
