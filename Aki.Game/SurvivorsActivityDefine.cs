using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002AC0 RID: 10944
public class SurvivorsActivityDefine
{
	// Token: 0x0400A940 RID: 43328
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

	// Token: 0x020090ED RID: 37101
	public class SurvivorsLevelInfo
	{
		// Token: 0x0402EF2A RID: 192298
		public int LevelId;

		// Token: 0x0402EF2B RID: 192299
		public int InstId;

		// Token: 0x0402EF2C RID: 192300
		public int RoleId;

		// Token: 0x0402EF2D RID: 192301
		public bool IsEndless;

		// Token: 0x0402EF2E RID: 192302
		public bool IsSaveFile;

		// Token: 0x0402EF2F RID: 192303
		public int Batch;

		// Token: 0x0402EF30 RID: 192304
		public int MaxBatch;
	}
}
