using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005717 RID: 22295
	[NullableContext(1)]
	[Nullable(0)]
	public static class KurotatoDefine
	{
		// Token: 0x0401DBF1 RID: 121841
		public const int KUTOTATO_COMBO_LEVEL_CONFIG_LENGTH = 4;

		// Token: 0x0401DBF2 RID: 121842
		public const float NOT_FINISH_ALPHA = 1f;

		// Token: 0x0401DBF3 RID: 121843
		public const float FINISH_ALPHA = 0.5f;

		// Token: 0x0401DBF4 RID: 121844
		public const int KUROTATO_LEVEL_SELECT_HELPID = 573;

		// Token: 0x0401DBF5 RID: 121845
		public const int KUROTATO_ROLE_SELECT_HELPID = 574;

		// Token: 0x0401DBF6 RID: 121846
		public const int KUROTATO_HAND_BOOK_HELPID = 575;

		// Token: 0x0401DBF7 RID: 121847
		public const int KUROTATO_ENDLESS_LEVEL_SELECT_HELPID = 614;

		// Token: 0x0401DBF8 RID: 121848
		public const int KUROTATO_ARCHIVE_HELPID = 630;

		// Token: 0x0401DBF9 RID: 121849
		public const string KUROTATO_COLOR_UP = "#31dea7";

		// Token: 0x0401DBFA RID: 121850
		public const string KUROTATO_COLOR_DOWN = "#f53864";

		// Token: 0x0401DBFB RID: 121851
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

		// Token: 0x0401DBFC RID: 121852
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
