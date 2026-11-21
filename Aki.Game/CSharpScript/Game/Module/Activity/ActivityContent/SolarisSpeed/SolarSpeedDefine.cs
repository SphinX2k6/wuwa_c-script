using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200502A RID: 20522
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedDefine : IStaticVariableResetter
	{
		// Token: 0x060335F7 RID: 210423 RVA: 0x00E66F02 File Offset: 0x00E65102
		static SolarSpeedDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSpeedDefine.CreateStaticDefaultValue), new Action(SolarSpeedDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060335F8 RID: 210424 RVA: 0x00E66F24 File Offset: 0x00E65124
		public static void CreateStaticDefaultValue()
		{
			SolarSpeedDefine.rankBgPathMap = new List<string>
			{
				"/Game/Aki/UI/UIResources/UiTips/Image/GongduolaOnlineResult/T_ResultBgPlayer.T_ResultBgPlayer",
				"/Game/Aki/UI/UIResources/UiTips/Image/GongduolaOnlineResult/T_ResultBgOtherPlayer.T_ResultBgOtherPlayer",
				"/Game/Aki/UI/UIResources/UiTips/Image/GongduolaOnlineResult/T_ResultBgBronze.T_ResultBgBronze"
			};
			SolarSpeedDefine.medalTexPathMap = new List<string>
			{
				"/Game/Aki/UI/UIResources/Common/Image/Com/T_IconMedalGold.T_IconMedalGold",
				"/Game/Aki/UI/UIResources/Common/Image/Com/T_IconMedalSilver.T_IconMedalSilver",
				"/Game/Aki/UI/UIResources/Common/Image/Com/T_IconMedalBronze.T_IconMedalBronze"
			};
			SolarSpeedDefine.medalColorHex = new List<string>
			{
				"e1a846",
				"5488C2",
				"c89b76"
			};
			SolarSpeedDefine.fxColorHex = new List<string>
			{
				"FFFFFF",
				"96C4FF",
				"B4A8E4"
			};
			SolarSpeedDefine.playerIndexIconMap = new List<string>
			{
				"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common1P.SP_Common1P",
				"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common2P.SP_Common2P",
				"/Game/Aki/UI/UIResources/Common/Atlas/SP_Common3P.SP_Common3P"
			};
			SolarSpeedDefine.playerIndexSelfIconMap = new List<string>
			{
				"/Game/Aki/UI/UIResources/Common/Atlas/SP_CommonSelf1P.SP_CommonSelf1P",
				"/Game/Aki/UI/UIResources/Common/Atlas/SP_CommonSelf2P.SP_CommonSelf2P",
				"/Game/Aki/UI/UIResources/Common/Atlas/SP_CommonSelf3P.SP_CommonSelf3P"
			};
			SolarSpeedDefine.avatarPattern = new List<string>
			{
				"T_AvatarPatternGold",
				"T_AvatarPatternSilver",
				"T_AvatarPatternCopper"
			};
			SolarSpeedDefine.linePattern = new List<string>
			{
				"T_DescLineGold",
				"T_DescLineSilver",
				"T_DescLineCopper"
			};
			SolarSpeedDefine.bgPattern = new List<string>
			{
				"T_ResultBgPlayer",
				"T_ResultBgOtherPlayer",
				"T_ResultBgBronze"
			};
			SolarSpeedDefine.bonusRewardList = new List<int>
			{
				25,
				26,
				27,
				28,
				29,
				30
			};
		}

		// Token: 0x060335F9 RID: 210425 RVA: 0x00E670EE File Offset: 0x00E652EE
		public static void ResetStaticDefaultValue()
		{
			SolarSpeedDefine.rankBgPathMap = null;
			SolarSpeedDefine.medalTexPathMap = null;
			SolarSpeedDefine.medalColorHex = null;
			SolarSpeedDefine.fxColorHex = null;
			SolarSpeedDefine.playerIndexIconMap = null;
			SolarSpeedDefine.playerIndexSelfIconMap = null;
			SolarSpeedDefine.avatarPattern = null;
			SolarSpeedDefine.linePattern = null;
			SolarSpeedDefine.bgPattern = null;
			SolarSpeedDefine.bonusRewardList = null;
		}

		// Token: 0x0401B4C4 RID: 111812
		public const int SOLAR_SPEED_INSTANCE_ENTRANCE_ID = 9000;

		// Token: 0x0401B4C5 RID: 111813
		public const int SOLAR_SPEED_BONUS_LEVEL_ID = 99;

		// Token: 0x0401B4C6 RID: 111814
		public const string SOLAR_SPEED_REWARD_TITLE_TEXT_ID = "LianjiPaoku_Reward_Title";

		// Token: 0x0401B4C7 RID: 111815
		public const string SOLAR_SPEED_REWARD_PROGRESS_TEXT_ID = "LianjiPaoku_Reward_Desc";

		// Token: 0x0401B4C8 RID: 111816
		public const string SOLAR_SPEED_REWARD_BUTTON_TEXT_ID = "LianjiPaoku_Button_Receive";

		// Token: 0x0401B4C9 RID: 111817
		public const string SOLAR_SPEED_CLOSE_BUTTON_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_Leave";

		// Token: 0x0401B4CA RID: 111818
		public const string SOLAR_SPEED_CONFIRM_BUTTON_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_Again";

		// Token: 0x0401B4CB RID: 111819
		public const string SOLAR_SPEED_CONFIRM_DESC_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_BestScore";

		// Token: 0x0401B4CC RID: 111820
		public const string SOLAR_SPEED_RANK_SCORE_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_RankScore";

		// Token: 0x0401B4CD RID: 111821
		public const string SOLAR_SPEED_GOLD_SCORE_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_PickRank";

		// Token: 0x0401B4CE RID: 111822
		public const string SOLAR_SPEED_DISTANCE_SCORE_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_CompleteRank";

		// Token: 0x0401B4CF RID: 111823
		public const string SOLAR_SPEED_RECORD_TEXT_ID_IN_SETTLE = "LianjiPaoku_End_HistoryRank";

		// Token: 0x0401B4D0 RID: 111824
		public const string SOLAR_SPEED_HIGHEST_RANK_TEXT_ID = "LianjiPaoku_Top_Rank";

		// Token: 0x0401B4D1 RID: 111825
		public const string SOLAR_SPEED_HIGHEST_SCORE_TEXT_ID = "LianjiPaoku_Top_Score";

		// Token: 0x0401B4D2 RID: 111826
		public const string SOLAR_SPEED_LAP_RECORD_TEXT_ID = "LianjiPaoku_Top_Time";

		// Token: 0x0401B4D3 RID: 111827
		public const string SOLAR_SPEED_LAP_RECORD_NO_RECORD_TEXT_ID = "LianjiPaoku_Top_Time_No_Time";

		// Token: 0x0401B4D4 RID: 111828
		public const string SOLAR_SPEED_UNLOCK_AFTER_DAYS = "LianjiPaokuReward_Level_UnLock";

		// Token: 0x0401B4D5 RID: 111829
		public const string SOLAR_SPEED_MOST_RECORD_TEXT_ID = "LianjiPaokuReward_Level_TopScore";

		// Token: 0x0401B4D6 RID: 111830
		public const string SOLAR_SPEED_NO_RECORD_TEXT_ID = "LianjiPaokuReward_Level_NoRecords";

		// Token: 0x0401B4D7 RID: 111831
		public const string SOLAR_SPEED_REWARD_TITLE_TEXT_ID_IN_SUBVIEW = "LianjiPaokuReward_9000_Preview";

		// Token: 0x0401B4D8 RID: 111832
		public const string SOLAR_SPEED_REWARD_PROGRESS_TEXT_ID_IN_SUBVIEW = "parkour_award_2_1";

		// Token: 0x0401B4D9 RID: 111833
		public const string SOLAR_SPEED_CONFIRM_BUTTON_TEXT_ID_IN_SUBVIEW = "PrefabTextItem_3950726357_Text";

		// Token: 0x0401B4DA RID: 111834
		public const string SOLAR_SPEED_BONUS_REWARD_TEXT_ID_IN_REWARD = "LianjiPaoku_Bonus_Level_Title";

		// Token: 0x0401B4DB RID: 111835
		public const string SOLAR_SPEED_CONFIRM_BUTTON_TEXT_ID_IN_RESULT = "PrefabTextItem_1234291298_Text";

		// Token: 0x0401B4DC RID: 111836
		public const string SOLAR_SPEED_ADD_FRIEND_TIPS_TEXT_ID = "LianjiPaoku_Button_AddFr_Tip";

		// Token: 0x0401B4DD RID: 111837
		public const string SOLAR_SPEED_REWARD_CANNOT_OPEN_TIPS_TEXT_ID = "LianjiPaoku_Reward_Cannot_Open_Tips";

		// Token: 0x0401B4DE RID: 111838
		public const string SOLAR_SPEED_BONUS_LEVEL_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/ComImg/T_ComRomeText_07.T_ComRomeText_07";

		// Token: 0x0401B4DF RID: 111839
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> rankBgPathMap;

		// Token: 0x0401B4E0 RID: 111840
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> medalTexPathMap;

		// Token: 0x0401B4E1 RID: 111841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> medalColorHex;

		// Token: 0x0401B4E2 RID: 111842
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> fxColorHex;

		// Token: 0x0401B4E3 RID: 111843
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> playerIndexIconMap;

		// Token: 0x0401B4E4 RID: 111844
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> playerIndexSelfIconMap;

		// Token: 0x0401B4E5 RID: 111845
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> avatarPattern;

		// Token: 0x0401B4E6 RID: 111846
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> linePattern;

		// Token: 0x0401B4E7 RID: 111847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static IReadOnlyList<string> bgPattern;

		// Token: 0x0401B4E8 RID: 111848
		[Nullable(2)]
		public static IReadOnlyList<int> bonusRewardList;
	}
}
