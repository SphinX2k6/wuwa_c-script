using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FAE RID: 12206
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisDefine
	{
		// Token: 0x0400F404 RID: 62468
		public const int BOARD_ROWS = 8;

		// Token: 0x0400F405 RID: 62469
		public const int BOARD_COLS = 8;

		// Token: 0x0400F406 RID: 62470
		public const int GRID_SIZE = 5;

		// Token: 0x0400F407 RID: 62471
		public const int GRID_CENTER = 2;

		// Token: 0x0400F408 RID: 62472
		public const int MAX_BLOCK_NUM = 4;

		// Token: 0x0400F409 RID: 62473
		public const string DONE_TEXT = "Tetristext_03";

		// Token: 0x0400F40A RID: 62474
		public const string OPEN_TEXT = "Tetristext_04";

		// Token: 0x0400F40B RID: 62475
		public const string LOCK_TEXT = "Tetristext_05";

		// Token: 0x0400F40C RID: 62476
		public const string PREVLOCK_TEXT = "Tetristext_12";

		// Token: 0x0400F40D RID: 62477
		public const int TETRIS_REDPOINT_KEY = 10001;

		// Token: 0x0400F40E RID: 62478
		public const int TETRIS_CELL_START_TIME = 50;

		// Token: 0x0400F40F RID: 62479
		public const int TETRIS_CELL_REMOVE_DELAY = 25;

		// Token: 0x0400F410 RID: 62480
		public const int BOMB_SCORE_PER_CELL = 25;

		// Token: 0x0400F411 RID: 62481
		public const string COMPLETE_COLOR_0 = "5c89a0";

		// Token: 0x0400F412 RID: 62482
		public const string OPEN_COLOR_0 = "9277fc";

		// Token: 0x0400F413 RID: 62483
		public const string LOCK_COLOR_0 = "4c4c4c";

		// Token: 0x0400F414 RID: 62484
		public const string COMPLETE_COLOR_1 = "7bffad";

		// Token: 0x0400F415 RID: 62485
		public const string OPEN_COLOR_1 = "ebd4ff";

		// Token: 0x0400F416 RID: 62486
		public const string LOCK_COLOR_1 = "8f8f8e";

		// Token: 0x0400F417 RID: 62487
		public const string LOSE_EFX = "play_ui_cube_efx_stone";

		// Token: 0x0400F418 RID: 62488
		public const string GREAT_EFX = "play_ui_cube_efx_match_level2";

		// Token: 0x0400F419 RID: 62489
		public const string NORMAL_EFX = "play_ui_cube_efx_match_level1";

		// Token: 0x0400F41A RID: 62490
		public const string TETRIS_CELL_START_EFX = "play_ui_cube_efx_up";

		// Token: 0x0400F41B RID: 62491
		public const string ROTATE_EFX = "play_ui_cube_spin_click";

		// Token: 0x0400F41C RID: 62492
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
