using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046EE RID: 18158
	[NullableContext(1)]
	[Nullable(0)]
	public static class KurotatoDefine
	{
		// Token: 0x04018687 RID: 99975
		public const int KUTOTATO_COMBO_LEVEL_CONFIG_LENGTH = 4;

		// Token: 0x04018688 RID: 99976
		public const float NOT_FINISH_ALPHA = 1f;

		// Token: 0x04018689 RID: 99977
		public const float FINISH_ALPHA = 0.5f;

		// Token: 0x0401868A RID: 99978
		public const int KUROTATO_LEVEL_SELECT_HELPID = 573;

		// Token: 0x0401868B RID: 99979
		public const int KUROTATO_ROLE_SELECT_HELPID = 574;

		// Token: 0x0401868C RID: 99980
		public const int KUROTATO_HAND_BOOK_HELPID = 575;

		// Token: 0x0401868D RID: 99981
		public const int KUROTATO_ENDLESS_LEVEL_SELECT_HELPID = 614;

		// Token: 0x0401868E RID: 99982
		public const int KUROTATO_ARCHIVE_HELPID = 630;

		// Token: 0x0401868F RID: 99983
		public const string KUROTATO_COLOR_UP = "#31dea7";

		// Token: 0x04018690 RID: 99984
		public const string KUROTATO_COLOR_DOWN = "#f53864";

		// Token: 0x04018691 RID: 99985
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EKurotatoCardType, string> KurotatoHandBookTabName = new Dictionary<EKurotatoCardType, string>
		{
			{
				EKurotatoCardType.None,
				""
			},
			{
				EKurotatoCardType.Weapon,
				"Kurotato_HandBook_Weapon_Tab"
			},
			{
				EKurotatoCardType.Item,
				"Kurotato_HandBook_Item_Tab"
			}
		};

		// Token: 0x04018692 RID: 99986
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EKurotatoLevelDifficulty, string> KurotatoLevelDifficultyToText = new Dictionary<EKurotatoLevelDifficulty, string>
		{
			{
				EKurotatoLevelDifficulty.TeachEasy,
				"Kurotato_LevelTab_TeachEasy"
			},
			{
				EKurotatoLevelDifficulty.TeachDifficulty,
				"Kurotato_LevelTab_TeachDifficulty"
			},
			{
				EKurotatoLevelDifficulty.Interest,
				"Kurotato_LevelTab_Interest"
			},
			{
				EKurotatoLevelDifficulty.Endless,
				"Kurotato_LevelTab_Endless"
			}
		};
	}
}
