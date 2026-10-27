using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F1E RID: 24350
	public static class WheelTowerDefine
	{
		// Token: 0x040204FB RID: 132347
		public const int LEVEL_BOSS_NUM = 4;

		// Token: 0x040204FC RID: 132348
		public const int TEMPLATE_ROLE_LEVEL = 90;

		// Token: 0x040204FD RID: 132349
		public const int WHEEL_TOWER_VERSION_32 = 32;

		// Token: 0x040204FE RID: 132350
		public const float WHEEL_TOWER_RESULT_SCORE_TWEEN_DURATION = 0.4f;

		// Token: 0x040204FF RID: 132351
		public const int WHEEL_TOWER_REPEAT_WAVE_ROUND = 3;

		// Token: 0x04020500 RID: 132352
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
