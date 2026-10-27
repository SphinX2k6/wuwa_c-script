using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FE3 RID: 24547
	[NullableContext(1)]
	[Nullable(0)]
	public class TerisDefine
	{
		// Token: 0x040207B1 RID: 133041
		public const int BOARDROWS = 8;

		// Token: 0x040207B2 RID: 133042
		public const int BOARDCOLS = 8;

		// Token: 0x040207B3 RID: 133043
		public const int GRID_SIZE = 5;

		// Token: 0x040207B4 RID: 133044
		public const int GRID_CENTER = 2;

		// Token: 0x040207B5 RID: 133045
		public const string DONE_TEXT = "Tetristext_03";

		// Token: 0x040207B6 RID: 133046
		public const string OPEN_TEXT = "Tetristext_04";

		// Token: 0x040207B7 RID: 133047
		public const string LOCK_TEXT = "Tetristext_05";

		// Token: 0x040207B8 RID: 133048
		public const string PREVLOCK_TEXT = "Tetristext_12";

		// Token: 0x040207B9 RID: 133049
		public const int TETRIS_REDPOINT_KEY = 10001;

		// Token: 0x040207BA RID: 133050
		public const int TETRIS_CELL_START_TIME = 50;

		// Token: 0x040207BB RID: 133051
		public const int TETRIS_CELL_REMOVE_DELAY = 25;

		// Token: 0x040207BC RID: 133052
		public const string COMPLETE_COLOR_0 = "5c89a0";

		// Token: 0x040207BD RID: 133053
		public const string OPEN_COLOR_0 = "9277fc";

		// Token: 0x040207BE RID: 133054
		public const string LOCK_COLOR_0 = "4c4c4c";

		// Token: 0x040207BF RID: 133055
		public const string COMPLETE_COLOR_1 = "7bffad";

		// Token: 0x040207C0 RID: 133056
		public const string OPEN_COLOR_1 = "ebd4ff";

		// Token: 0x040207C1 RID: 133057
		public const string LOCK_COLOR_1 = "8f8f8e";

		// Token: 0x040207C2 RID: 133058
		public const string LOSE_EFX = "play_ui_cube_efx_stone";

		// Token: 0x040207C3 RID: 133059
		public const string GREAT_EFX = "play_ui_cube_efx_match_level2";

		// Token: 0x040207C4 RID: 133060
		public const string NORMAL_EFX = "play_ui_cube_efx_match_level1";

		// Token: 0x040207C5 RID: 133061
		public const string TETRIS_CELL_START_EFX = "play_ui_cube_efx_up";

		// Token: 0x040207C6 RID: 133062
		[TupleElementNames(new string[]
		{
			"Gem",
			"Color"
		})]
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<string, ValueTuple<EGemType, int>> configMap = new Dictionary<string, ValueTuple<EGemType, int>>
		{
			{
				"O",
				new ValueTuple<EGemType, int>(EGemType.Orange, 1)
			},
			{
				"B",
				new ValueTuple<EGemType, int>(EGemType.Blue, 2)
			},
			{
				"G",
				new ValueTuple<EGemType, int>(EGemType.Green, 3)
			},
			{
				"P",
				new ValueTuple<EGemType, int>(EGemType.Purple, 4)
			},
			{
				"Y",
				new ValueTuple<EGemType, int>(EGemType.Yellow, 5)
			},
			{
				"R",
				new ValueTuple<EGemType, int>(EGemType.Red, 6)
			}
		};
	}
}
