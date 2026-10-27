using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002994 RID: 10644
public class ShipTowerDefine
{
	// Token: 0x0400A40F RID: 41999
	public const int SHIP_TOWER_MARK_ID = 302001;

	// Token: 0x0400A410 RID: 42000
	public const int SHIP_TOWER_ZERO_SEASON = 0;

	// Token: 0x0400A411 RID: 42001
	public const int SHIP_TOWER_HELP_ID = 201;

	// Token: 0x0400A412 RID: 42002
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<string, ShipTowerScoreGrade> shipTowerScoreGradeMap = new Dictionary<string, ShipTowerScoreGrade>
	{
		{
			"D",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreD",
				BigResId = "T_ScoreBigD",
				Index = 1
			}
		},
		{
			"C",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreC",
				BigResId = "T_ScoreBigC",
				Index = 2
			}
		},
		{
			"B",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreB",
				BigResId = "T_ScoreBigB",
				Index = 3
			}
		},
		{
			"A",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreA",
				BigResId = "T_ScoreBigA",
				Index = 4
			}
		},
		{
			"S",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreS",
				BigResId = "T_ScoreBigS",
				Index = 5
			}
		},
		{
			"SS",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreSS",
				BigResId = "T_ScoreBigSS",
				Index = 6
			}
		},
		{
			"SSS",
			new ShipTowerScoreGrade
			{
				ResId = "T_ScoreSSS",
				BigResId = "T_ScoreBigSSS",
				Index = 7
			}
		}
	};
}
