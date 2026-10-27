using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064AC RID: 25772
	[NullableContext(1)]
	[Nullable(0)]
	public static class MatchThreeGameplayDefine
	{
		// Token: 0x06040B9C RID: 265116 RVA: 0x00FAB620 File Offset: 0x00FA9820
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

		// Token: 0x06040B9D RID: 265117 RVA: 0x00FAB734 File Offset: 0x00FA9934
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

		// Token: 0x06040B9E RID: 265118 RVA: 0x00FAB790 File Offset: 0x00FA9990
		public static bool IsSplashed(EPieceClearReason reason)
		{
			return reason == EPieceClearReason.SplashedByBomb || reason == EPieceClearReason.SplashedByCross;
		}

		// Token: 0x04021AE1 RID: 137953
		public const int ROWS = 7;

		// Token: 0x04021AE2 RID: 137954
		public const int COLS = 8;

		// Token: 0x04021AE3 RID: 137955
		public const float CELL_GAP_X = 5f;

		// Token: 0x04021AE4 RID: 137956
		public const float CELL_GAP_Y = 3f;

		// Token: 0x04021AE5 RID: 137957
		public const int CROSS_CLEAR_STEP_DELAY_MS = 55;

		// Token: 0x04021AE6 RID: 137958
		public const int RESTART_CLEAN_WAVE_DELAY_MS = 20;

		// Token: 0x04021AE7 RID: 137959
		public const string RESHUFFLE_TIPS_TEXT_ID = "MatchThree_ReshuffleTips";

		// Token: 0x04021AE8 RID: 137960
		public const string AUDIO_MOVE_SUCCESS = "play_ui_match3game_game_move_success";

		// Token: 0x04021AE9 RID: 137961
		public const string AUDIO_MOVE_FAIL = "play_ui_match3game_game_move_fail";

		// Token: 0x04021AEA RID: 137962
		public const string AUDIO_PLAY_GRADE_1 = "play_ui_match3game_game_playgrade_1";

		// Token: 0x04021AEB RID: 137963
		public const string AUDIO_PLAY_GRADE_2 = "play_ui_match3game_game_playgrade_2";

		// Token: 0x04021AEC RID: 137964
		public const string AUDIO_PLAY_GRADE_3 = "play_ui_match3game_game_playgrade_3";

		// Token: 0x04021AED RID: 137965
		public const string AUDIO_PLAY_GRADE_4 = "play_ui_match3game_game_playgrade_4";

		// Token: 0x04021AEE RID: 137966
		public const string AUDIO_REFRESH = "play_ui_match3game_game_refresh";

		// Token: 0x04021AEF RID: 137967
		public const string AUDIO_BOOM_CROSS = "play_ui_match3game_game_boom_cross";

		// Token: 0x04021AF0 RID: 137968
		public const string AUDIO_TILE_ADD = "play_ui_match3game_game_tile_add";

		// Token: 0x04021AF1 RID: 137969
		public const float TRAIL_SPEED_PX_PER_SEC = 2500f;

		// Token: 0x04021AF2 RID: 137970
		public const int TRAIL_LAUNCH_STEP_DELAY_MS = 40;

		// Token: 0x04021AF3 RID: 137971
		public const int TRAIL_ARRIVE_STEP_DELAY_MS = 40;

		// Token: 0x04021AF4 RID: 137972
		public const int ALLURE_ULTIMATE_RECOLOR_STEP_MS = 20;

		// Token: 0x04021AF5 RID: 137973
		public const int COMPONENT_PARAM_BOMB_ROWS = 0;

		// Token: 0x04021AF6 RID: 137974
		public const int COMPONENT_PARAM_BOMB_COLS = 1;

		// Token: 0x04021AF7 RID: 137975
		public const int COMPONENT_PARAM_HEALTH_COUNT = 0;

		// Token: 0x04021AF8 RID: 137976
		public const int COMPONENT_PARAM_CHAIN_LIVES = 0;

		// Token: 0x04021AF9 RID: 137977
		public const int COMPONENT_PARAM_CHARGER_GAIN_ENERGY = 0;

		// Token: 0x04021AFA RID: 137978
		public const int COMPONENT_PARAM_HOURGLASS_GAIN_TURNS = 0;

		// Token: 0x04021AFB RID: 137979
		public const int CHAIN_SPREAD_DISTANCE = 3;

		// Token: 0x04021AFC RID: 137980
		public static readonly HashSet<EPieceType> NormalPieceTypes = new HashSet<EPieceType>
		{
			EPieceType.Red,
			EPieceType.Yellow,
			EPieceType.Blue,
			EPieceType.Green,
			EPieceType.Purple
		};

		// Token: 0x04021AFD RID: 137981
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
