using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x02006209 RID: 25097
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipDefine : IStaticVariableResetter
	{
		// Token: 0x0603F504 RID: 259332 RVA: 0x00F4CC15 File Offset: 0x00F4AE15
		static RhythmShipDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipDefine.CreateStaticDefaultValue), new Action(RhythmShipDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603F505 RID: 259333 RVA: 0x00F4CC34 File Offset: 0x00F4AE34
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

		// Token: 0x0603F506 RID: 259334 RVA: 0x00F4CDA7 File Offset: 0x00F4AFA7
		public static void ResetStaticDefaultValue()
		{
			RhythmShipDefine.rhythmShipLevelRatingBgTexture = null;
			RhythmShipDefine.rhythmShipLevelRatingSettlementTexture = null;
			RhythmShipDefine.rhythmShipDifficultyText = null;
			RhythmShipDefine.rhythmShipSettlementText = null;
			RhythmShipDefine.rhythmShipRankNiaLightColor = null;
		}

		// Token: 0x04021063 RID: 135267
		public const int RHYTHMSHIP_CAILBRATION_MOVE_TIME = 3000;

		// Token: 0x04021064 RID: 135268
		public const int RHYTHMSHIP_RHYTHM_RANK_REQUEST_TIME = 1800;

		// Token: 0x04021065 RID: 135269
		public const int RHYTHMSHIP_CAILBRATION_MAX_VALUE = 150;

		// Token: 0x04021066 RID: 135270
		public const int RHYTHMSHIP_CAILBRATION_LONG_CLICK_CHANGE_TIME = 100;

		// Token: 0x04021067 RID: 135271
		public const int RHYTHMSHIP_CAILBRATION_VIEW_MOVE_CIRCLE_MAX = 1000;

		// Token: 0x04021068 RID: 135272
		public const int RHYTHMSHIP_CAILBRATION_STOP_CIRCLE_SHOW_TIME = 1000;

		// Token: 0x04021069 RID: 135273
		public static Dictionary<int, string> rhythmShipLevelRatingBgTexture;

		// Token: 0x0402106A RID: 135274
		public static Dictionary<int, string> rhythmShipLevelRatingSettlementTexture;

		// Token: 0x0402106B RID: 135275
		public static Dictionary<int, string> rhythmShipDifficultyText;

		// Token: 0x0402106C RID: 135276
		public static Dictionary<int, string> rhythmShipSettlementText;

		// Token: 0x0402106D RID: 135277
		public static Dictionary<int, FColor> rhythmShipRankNiaLightColor;

		// Token: 0x0402106E RID: 135278
		public const int RHYTHMSHIP_MAX_DIFFICUTY_STAR = 9;
	}
}
