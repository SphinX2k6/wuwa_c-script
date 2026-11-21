using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F05 RID: 20229
	public static class WheelTowerDefine
	{
		// Token: 0x0401AFCD RID: 110541
		public const int LEVEL_BOSS_NUM = 4;

		// Token: 0x0401AFCE RID: 110542
		public const int TEMPLATE_ROLE_LEVEL = 90;

		// Token: 0x0401AFCF RID: 110543
		public const int WHEEL_TOWER_VERSION_32 = 32;

		// Token: 0x0401AFD0 RID: 110544
		public const float WHEEL_TOWER_RESULT_SCORE_TWEEN_DURATION = 0.4f;

		// Token: 0x0401AFD1 RID: 110545
		public const int WHEEL_TOWER_REPEAT_WAVE_ROUND = 3;

		// Token: 0x0401AFD2 RID: 110546
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<EScoreLevel, string> LevelItemMappingTable = new Dictionary<EScoreLevel, string>
		{
			{
				EScoreLevel.B,
				"UiItem_ScoreB"
			},
			{
				EScoreLevel.A,
				"UiItem_ScoreA"
			},
			{
				EScoreLevel.S,
				"UiItem_ScoreS"
			},
			{
				EScoreLevel.SS,
				"UiItem_ScoreSS"
			},
			{
				EScoreLevel.SSS,
				"UiItem_ScoreSSS"
			},
			{
				EScoreLevel.KingRed,
				"UiItem_ScoreKingRed"
			},
			{
				EScoreLevel.King,
				"UiItem_ScoreKingColor"
			}
		};
	}
}
