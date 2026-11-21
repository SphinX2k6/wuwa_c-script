using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x02005187 RID: 20871
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipDefine : IStaticVariableResetter
	{
		// Token: 0x060341C5 RID: 213445 RVA: 0x00E93B6D File Offset: 0x00E91D6D
		static RhythmShipDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipDefine.CreateStaticDefaultValue), new Action(RhythmShipDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060341C6 RID: 213446 RVA: 0x00E93B8C File Offset: 0x00E91D8C
		public static void CreateStaticDefaultValue()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary[1] = "T_RhythmShipEndLevelBg03";
			dictionary[2] = "T_RhythmShipEndLevelBg03";
			dictionary[3] = "T_RhythmShipEndLevelBg03";
			dictionary[4] = "T_RhythmShipEndLevelBg01";
			dictionary[5] = "T_RhythmShipEndLevelBg02";
			dictionary[0] = "";
			RhythmShipDefine.rhythmShipLevelRatingBgTexture = dictionary;
			Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
			dictionary2[1] = "T_IconLevelSSS";
			dictionary2[2] = "T_IconLevelSS";
			dictionary2[3] = "T_IconLevelS";
			dictionary2[4] = "T_IconLevelA";
			dictionary2[5] = "T_IconLevelB";
			dictionary2[0] = "";
			RhythmShipDefine.rhythmShipLevelRatingSettlementTexture = dictionary2;
			Dictionary<int, string> dictionary3 = new Dictionary<int, string>();
			dictionary3[1] = "RhythmShipLevelDifficultyEasy";
			dictionary3[2] = "RhythmShipLevelDifficultyMiddle";
			dictionary3[3] = "RhythmShipLevelDifficultyDifficulty";
			RhythmShipDefine.rhythmShipDifficultyText = dictionary3;
			Dictionary<int, string> dictionary4 = new Dictionary<int, string>();
			dictionary4[0] = "Miss";
			dictionary4[1] = "OK";
			dictionary4[2] = "Good";
			dictionary4[3] = "Great";
			dictionary4[4] = "Perfect";
			RhythmShipDefine.rhythmShipSettlementText = dictionary4;
			Dictionary<int, FColor> dictionary5 = new Dictionary<int, FColor>();
			dictionary5[1] = FColor.FromHex("FFF59EFF");
			dictionary5[2] = FColor.FromHex("99E6FFFF");
			dictionary5[3] = FColor.FromHex("D3974EFF");
			dictionary5[0] = FColor.FromHex("FFFFFFFF");
			RhythmShipDefine.rhythmShipRankNiaLightColor = dictionary5;
		}

		// Token: 0x060341C7 RID: 213447 RVA: 0x00E93CFF File Offset: 0x00E91EFF
		public static void ResetStaticDefaultValue()
		{
			RhythmShipDefine.rhythmShipLevelRatingBgTexture = null;
			RhythmShipDefine.rhythmShipLevelRatingSettlementTexture = null;
			RhythmShipDefine.rhythmShipDifficultyText = null;
			RhythmShipDefine.rhythmShipSettlementText = null;
			RhythmShipDefine.rhythmShipRankNiaLightColor = null;
		}

		// Token: 0x0401B992 RID: 113042
		public const int RHYTHMSHIP_CAILBRATION_MOVE_TIME = 3000;

		// Token: 0x0401B993 RID: 113043
		public const int RHYTHMSHIP_RHYTHM_RANK_REQUEST_TIME = 1800;

		// Token: 0x0401B994 RID: 113044
		public const int RHYTHMSHIP_CAILBRATION_MAX_VALUE = 150;

		// Token: 0x0401B995 RID: 113045
		public const int RHYTHMSHIP_CAILBRATION_LONG_CLICK_CHANGE_TIME = 100;

		// Token: 0x0401B996 RID: 113046
		public const int RHYTHMSHIP_CAILBRATION_VIEW_MOVE_CIRCLE_MAX = 1000;

		// Token: 0x0401B997 RID: 113047
		public const int RHYTHMSHIP_CAILBRATION_STOP_CIRCLE_SHOW_TIME = 1000;

		// Token: 0x0401B998 RID: 113048
		public static Dictionary<int, string> rhythmShipLevelRatingBgTexture;

		// Token: 0x0401B999 RID: 113049
		public static Dictionary<int, string> rhythmShipLevelRatingSettlementTexture;

		// Token: 0x0401B99A RID: 113050
		public static Dictionary<int, string> rhythmShipDifficultyText;

		// Token: 0x0401B99B RID: 113051
		public static Dictionary<int, string> rhythmShipSettlementText;

		// Token: 0x0401B99C RID: 113052
		public static Dictionary<int, FColor> rhythmShipRankNiaLightColor;

		// Token: 0x0401B99D RID: 113053
		public const int RHYTHMSHIP_MAX_DIFFICUTY_STAR = 9;
	}
}
