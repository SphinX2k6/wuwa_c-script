using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200542A RID: 21546
	[NullableContext(1)]
	[Nullable(0)]
	public static class MatchThreeGameplayDefine
	{
		// Token: 0x06035860 RID: 219232 RVA: 0x00EF2668 File Offset: 0x00EF0868
		[return: TupleElementNames(new string[]
		{
			"PrefabId",
			"Icon"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			2
		})]
		public static ValueTuple<string, string> GetPieceRes(EPieceType type)
		{
			ValueTuple<string, string> result;
			switch (type)
			{
			case EPieceType.Ultimate:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileUltimate.ToEnumString(), EMatchThreeResourceId.IconTileUltimate.ToEnumString());
				break;
			case EPieceType.Hourglass:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileHourglass.ToEnumString(), EMatchThreeResourceId.IconTileHourglass.ToEnumString());
				break;
			case EPieceType.Charger:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileCharger.ToEnumString(), EMatchThreeResourceId.IconTileCharger.ToEnumString());
				break;
			case EPieceType.Ice:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileIce.ToEnumString(), EMatchThreeResourceId.IconTileIce.ToEnumString());
				break;
			case EPieceType.Red:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileNormal.ToEnumString(), EMatchThreeResourceId.IconTileRed.ToEnumString());
				break;
			case EPieceType.Yellow:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileNormal.ToEnumString(), EMatchThreeResourceId.IconTileYellow.ToEnumString());
				break;
			case EPieceType.Blue:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileNormal.ToEnumString(), EMatchThreeResourceId.IconTileBlue.ToEnumString());
				break;
			case EPieceType.Green:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileNormal.ToEnumString(), EMatchThreeResourceId.IconTileGreen.ToEnumString());
				break;
			case EPieceType.Purple:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileNormal.ToEnumString(), EMatchThreeResourceId.IconTilePurple.ToEnumString());
				break;
			default:
				result = new ValueTuple<string, string>(EMatchThreeResourceId.TileNormal.ToEnumString(), null);
				break;
			}
			return result;
		}

		// Token: 0x06035861 RID: 219233 RVA: 0x00EF277C File Offset: 0x00EF097C
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"PrefabId",
			"UiParent"
		})]
		public static ValueTuple<EMatchThreeResourceId?, EPieceViewComponent> GetComponentRes(EPieceComponentType type)
		{
			ValueTuple<EMatchThreeResourceId?, EPieceViewComponent> result;
			if (type != EPieceComponentType.Bomb)
			{
				if (type != EPieceComponentType.CrossClear)
				{
					if (type != EPieceComponentType.Chain)
					{
						result = new ValueTuple<EMatchThreeResourceId?, EPieceViewComponent>(null, EPieceViewComponent.PnlAdditionForward);
					}
					else
					{
						result = new ValueTuple<EMatchThreeResourceId?, EPieceViewComponent>(new EMatchThreeResourceId?(EMatchThreeResourceId.AdditionChain), EPieceViewComponent.PnlAdditionBack);
					}
				}
				else
				{
					result = new ValueTuple<EMatchThreeResourceId?, EPieceViewComponent>(new EMatchThreeResourceId?(EMatchThreeResourceId.AdditionCrossClear), EPieceViewComponent.PnlAdditionForward);
				}
			}
			else
			{
				result = new ValueTuple<EMatchThreeResourceId?, EPieceViewComponent>(new EMatchThreeResourceId?(EMatchThreeResourceId.AdditionBomb), EPieceViewComponent.PnlAdditionForward);
			}
			return result;
		}

		// Token: 0x06035862 RID: 219234 RVA: 0x00EF27D8 File Offset: 0x00EF09D8
		public static bool IsSplashed(EPieceClearReason reason)
		{
			return reason == EPieceClearReason.SplashedByBomb || reason == EPieceClearReason.SplashedByCross;
		}

		// Token: 0x0401C412 RID: 115730
		public const int ROWS = 7;

		// Token: 0x0401C413 RID: 115731
		public const int COLS = 8;

		// Token: 0x0401C414 RID: 115732
		public const float CELL_GAP_X = 5f;

		// Token: 0x0401C415 RID: 115733
		public const float CELL_GAP_Y = 3f;

		// Token: 0x0401C416 RID: 115734
		public const int CROSS_CLEAR_STEP_DELAY_MS = 55;

		// Token: 0x0401C417 RID: 115735
		public const int RESTART_CLEAN_WAVE_DELAY_MS = 20;

		// Token: 0x0401C418 RID: 115736
		public const string RESHUFFLE_TIPS_TEXT_ID = "MatchThree_ReshuffleTips";

		// Token: 0x0401C419 RID: 115737
		public const string AUDIO_MOVE_SUCCESS = "play_ui_match3game_game_move_success";

		// Token: 0x0401C41A RID: 115738
		public const string AUDIO_MOVE_FAIL = "play_ui_match3game_game_move_fail";

		// Token: 0x0401C41B RID: 115739
		public const string AUDIO_PLAY_GRADE_1 = "play_ui_match3game_game_playgrade_1";

		// Token: 0x0401C41C RID: 115740
		public const string AUDIO_PLAY_GRADE_2 = "play_ui_match3game_game_playgrade_2";

		// Token: 0x0401C41D RID: 115741
		public const string AUDIO_PLAY_GRADE_3 = "play_ui_match3game_game_playgrade_3";

		// Token: 0x0401C41E RID: 115742
		public const string AUDIO_PLAY_GRADE_4 = "play_ui_match3game_game_playgrade_4";

		// Token: 0x0401C41F RID: 115743
		public const string AUDIO_REFRESH = "play_ui_match3game_game_refresh";

		// Token: 0x0401C420 RID: 115744
		public const string AUDIO_BOOM_CROSS = "play_ui_match3game_game_boom_cross";

		// Token: 0x0401C421 RID: 115745
		public const string AUDIO_TILE_ADD = "play_ui_match3game_game_tile_add";

		// Token: 0x0401C422 RID: 115746
		public const float TRAIL_SPEED_PX_PER_SEC = 2500f;

		// Token: 0x0401C423 RID: 115747
		public const int TRAIL_LAUNCH_STEP_DELAY_MS = 40;

		// Token: 0x0401C424 RID: 115748
		public const int TRAIL_ARRIVE_STEP_DELAY_MS = 40;

		// Token: 0x0401C425 RID: 115749
		public const int ALLURE_ULTIMATE_RECOLOR_STEP_MS = 20;

		// Token: 0x0401C426 RID: 115750
		public const int COMPONENT_PARAM_BOMB_ROWS = 0;

		// Token: 0x0401C427 RID: 115751
		public const int COMPONENT_PARAM_BOMB_COLS = 1;

		// Token: 0x0401C428 RID: 115752
		public const int COMPONENT_PARAM_HEALTH_COUNT = 0;

		// Token: 0x0401C429 RID: 115753
		public const int COMPONENT_PARAM_CHAIN_LIVES = 0;

		// Token: 0x0401C42A RID: 115754
		public const int COMPONENT_PARAM_CHARGER_GAIN_ENERGY = 0;

		// Token: 0x0401C42B RID: 115755
		public const int COMPONENT_PARAM_HOURGLASS_GAIN_TURNS = 0;

		// Token: 0x0401C42C RID: 115756
		public const int CHAIN_SPREAD_DISTANCE = 3;

		// Token: 0x0401C42D RID: 115757
		public static readonly HashSet<EPieceType> NormalPieceTypes = new HashSet<EPieceType>
		{
			EPieceType.Red,
			EPieceType.Yellow,
			EPieceType.Blue,
			EPieceType.Green,
			EPieceType.Purple
		};

		// Token: 0x0401C42E RID: 115758
		public static readonly EMatchShape[] MatchShapePriority = new EMatchShape[]
		{
			EMatchShape.Line5,
			EMatchShape.L,
			EMatchShape.T,
			EMatchShape.Line4,
			EMatchShape.Line3
		};
	}
}
