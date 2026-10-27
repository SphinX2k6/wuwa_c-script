using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A3F RID: 23103
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeDefine : Singleton
	{
		// Token: 0x17008BF1 RID: 35825
		// (get) Token: 0x0603A97F RID: 239999 RVA: 0x00DF1938 File Offset: 0x00DEFB38
		public static FlagChallengeDefine Instance
		{
			get
			{
				if (FlagChallengeDefine._instance == null)
				{
					FlagChallengeDefine._instance = new FlagChallengeDefine();
					FlagChallengeDefine._instance.OnInit();
				}
				return FlagChallengeDefine._instance;
			}
		}

		// Token: 0x0603A980 RID: 240000 RVA: 0x00DF195B File Offset: 0x00DEFB5B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A981 RID: 240001 RVA: 0x00DF195D File Offset: 0x00DEFB5D
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeDefine instance = FlagChallengeDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FlagChallengeDefine._instance = null;
		}

		// Token: 0x0603A982 RID: 240002 RVA: 0x00DF1976 File Offset: 0x00DEFB76
		static FlagChallengeDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeDefine.CreateStaticDefaultValue), new Action(FlagChallengeDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0603A983 RID: 240003 RVA: 0x00DF1998 File Offset: 0x00DEFB98
		public FlagChallengeDefine()
		{
			Dictionary<EFlagChallengeUiStyleType, Dictionary<string, string>> dictionary = new Dictionary<EFlagChallengeUiStyleType, Dictionary<string, string>>();
			dictionary[EFlagChallengeUiStyleType.Green] = new Dictionary<string, string>
			{
				{
					"LevelTabItemNormal",
					"T_MoraleTabNorGreen"
				},
				{
					"LevelTabItemHover",
					"T_MoraleTabHoldGreen"
				},
				{
					"LevelTabItemSelect",
					"T_MoraleTabSleGreen"
				},
				{
					"AreaItemBg",
					"T_MoraleItemBgGreen"
				},
				{
					"AreaItemLevelBg",
					"SP_MoraleMonsterLvGreen"
				},
				{
					"AreaItemMap1",
					"T_MoraleMapGreen01"
				},
				{
					"AreaItemMap2",
					"T_MoraleMapGreen02"
				},
				{
					"AreaItemMap3",
					"T_MoraleMapGreen03"
				},
				{
					"AreaItemMap4",
					"T_MoraleMapGreen04"
				},
				{
					"AreaItemMap5",
					"T_MoraleMapGreen05"
				},
				{
					"LevelMapBg",
					"T_MoraleMapBgGreen"
				},
				{
					"LevelMapTopBg",
					"T_MoraleMapBgTopGreen"
				},
				{
					"LevelListLight",
					"T_MoraleListLightGreen"
				},
				{
					"LevelSetOffLight",
					"T_MoraleLightSetoffGreen"
				},
				{
					"LevelFrame",
					"T_MoraleFrameGreen"
				},
				{
					"LevelTitleBg",
					"T_MoraleTitleBgGreen"
				},
				{
					"AreaDetailItemBg1",
					"T_MoraleGreenItem1"
				},
				{
					"AreaDetailItemBg2",
					"T_MoraleGreenItem2"
				},
				{
					"AreaDetailItemBg3",
					"T_MoraleGreenItem3"
				},
				{
					"AreaDetailItemBg4",
					"T_MoraleGreenItem4"
				},
				{
					"AreaDetailItemBg5",
					"T_MoraleGreenItem5"
				},
				{
					"StrongholdItemIncompleteBg1",
					"T_UnOccFlagLargerGreenNor"
				},
				{
					"StrongholdItemCompleteBg1",
					"T_UnOccFlagLargerGreenDone"
				},
				{
					"StrongholdItemIncompleteIcon1",
					"T_UnOccFlagLargerGreenNor1"
				},
				{
					"StrongholdItemCompleteIcon1",
					"T_UnOccFlagLargerGreenDone1"
				},
				{
					"StrongholdItemIncompleteBg2",
					"T_UnOccFlagBossGreenNor"
				},
				{
					"StrongholdItemCompleteBg2",
					"T_UnOccFlagBossGreenDone"
				},
				{
					"StrongholdItemIncompleteIcon2",
					"T_UnOccFlagBossGreenNor1"
				},
				{
					"StrongholdItemCompleteIcon2",
					"T_UnOccFlagBossGreenDone1"
				},
				{
					"MaskBg",
					"T_MoraleMaskGreen"
				}
			};
			dictionary[EFlagChallengeUiStyleType.Yellow] = new Dictionary<string, string>
			{
				{
					"LevelTabItemNormal",
					"T_MoraleTabNorYellow"
				},
				{
					"LevelTabItemHover",
					"T_MoraleTabHoldYellow"
				},
				{
					"LevelTabItemSelect",
					"T_MoraleTabSleYellow"
				},
				{
					"AreaItemBg",
					"T_MoraleItemBgYellow"
				},
				{
					"AreaItemLevelBg",
					"SP_MoraleMonsterLvYellow"
				},
				{
					"AreaItemMap1",
					"T_MoraleMapYellow01"
				},
				{
					"AreaItemMap2",
					"T_MoraleMapYellow02"
				},
				{
					"AreaItemMap3",
					"T_MoraleMapYellow03"
				},
				{
					"AreaItemMap4",
					"T_MoraleMapYellow04"
				},
				{
					"AreaItemMap5",
					"T_MoraleMapYellow05"
				},
				{
					"LevelMapBg",
					"T_MoraleMapBgYellow"
				},
				{
					"LevelMapTopBg",
					"T_MoraleMapBgTopYellow"
				},
				{
					"LevelListLight",
					"T_MoraleListLightYellow"
				},
				{
					"LevelSetOffLight",
					"T_MoraleLightSetoffYellow"
				},
				{
					"LevelFrame",
					"T_MoraleFrameYellow"
				},
				{
					"LevelTitleBg",
					"T_MoraleTitleBgYellow"
				},
				{
					"AreaDetailItemBg1",
					"T_MoraleYellowItem1"
				},
				{
					"AreaDetailItemBg2",
					"T_MoraleYellowItem2"
				},
				{
					"AreaDetailItemBg3",
					"T_MoraleYellowItem3"
				},
				{
					"AreaDetailItemBg4",
					"T_MoraleYellowItem4"
				},
				{
					"AreaDetailItemBg5",
					"T_MoraleYellowItem5"
				},
				{
					"StrongholdItemIncompleteBg1",
					"T_UnOccFlagLargerYellowNor"
				},
				{
					"StrongholdItemCompleteBg1",
					"T_UnOccFlagLargerYellowDone"
				},
				{
					"StrongholdItemIncompleteIcon1",
					"T_UnOccFlagLargerYellowNor1"
				},
				{
					"StrongholdItemCompleteIcon1",
					"T_UnOccFlagLargerYellowDone1"
				},
				{
					"StrongholdItemIncompleteBg2",
					"T_UnOccFlagBossYellowNor"
				},
				{
					"StrongholdItemCompleteBg2",
					"T_UnOccFlagBossYellowDone"
				},
				{
					"StrongholdItemIncompleteIcon2",
					"T_UnOccFlagBossYellowNor1"
				},
				{
					"StrongholdItemCompleteIcon2",
					"T_UnOccFlagBossYellowDone1"
				},
				{
					"MaskBg",
					"T_MoraleMaskYellow"
				}
			};
			dictionary[EFlagChallengeUiStyleType.Red] = new Dictionary<string, string>
			{
				{
					"LevelTabItemNormal",
					"T_MoraleTabNorRed"
				},
				{
					"LevelTabItemHover",
					"T_MoraleTabHoldRed"
				},
				{
					"LevelTabItemSelect",
					"T_MoraleTabSleRed"
				},
				{
					"AreaItemBg",
					"T_MoraleItemBgRed"
				},
				{
					"AreaItemLevelBg",
					"SP_MoraleMonsterLvRed"
				},
				{
					"AreaItemMap1",
					"T_MoraleMapRed01"
				},
				{
					"AreaItemMap2",
					"T_MoraleMapRed02"
				},
				{
					"AreaItemMap3",
					"T_MoraleMapRed03"
				},
				{
					"AreaItemMap4",
					"T_MoraleMapRed04"
				},
				{
					"AreaItemMap5",
					"T_MoraleMapRed05"
				},
				{
					"LevelMapBg",
					"T_MoraleMapBgRed"
				},
				{
					"LevelMapTopBg",
					"T_MoraleMapBgTopRed"
				},
				{
					"LevelListLight",
					"T_MoraleListLightRed"
				},
				{
					"LevelSetOffLight",
					"T_MoraleLightSetoffRed"
				},
				{
					"LevelFrame",
					"T_MoraleFrameRed"
				},
				{
					"LevelTitleBg",
					"T_MoraleTitleBgRed"
				},
				{
					"AreaDetailItemBg1",
					"T_MoraleRedItem1"
				},
				{
					"AreaDetailItemBg2",
					"T_MoraleRedItem2"
				},
				{
					"AreaDetailItemBg3",
					"T_MoraleRedItem3"
				},
				{
					"AreaDetailItemBg4",
					"T_MoraleRedItem4"
				},
				{
					"AreaDetailItemBg5",
					"T_MoraleRedItem5"
				},
				{
					"StrongholdItemIncompleteBg1",
					"T_UnOccFlagLargerRedNor"
				},
				{
					"StrongholdItemCompleteBg1",
					"T_UnOccFlagLargerRedDone"
				},
				{
					"StrongholdItemIncompleteIcon1",
					"T_UnOccFlagLargerRedNor1"
				},
				{
					"StrongholdItemCompleteIcon1",
					"T_UnOccFlagLargerRedDone1"
				},
				{
					"StrongholdItemIncompleteBg2",
					"T_UnOccFlagBossRedNor"
				},
				{
					"StrongholdItemCompleteBg2",
					"T_UnOccFlagBossRedDone"
				},
				{
					"StrongholdItemIncompleteIcon2",
					"T_UnOccFlagBossRedNor1"
				},
				{
					"StrongholdItemCompleteIcon2",
					"T_UnOccFlagBossRedDone1"
				},
				{
					"MaskBg",
					"T_MoraleMaskRed"
				}
			};
			dictionary[EFlagChallengeUiStyleType.Hidden] = new Dictionary<string, string>
			{
				{
					"LevelTabItemNormal",
					"T_MoraleTabNorRed"
				},
				{
					"LevelTabItemHover",
					"T_MoraleTabHoldRed"
				},
				{
					"LevelTabItemSelect",
					"T_MoraleTabSleRed"
				},
				{
					"AreaItemBg",
					"T_MoraleItemBgRed"
				},
				{
					"AreaItemLevelBg",
					"SP_MoraleMonsterLvRed"
				},
				{
					"AreaItemMap1",
					"T_MoraleMapRed01"
				},
				{
					"AreaItemMap2",
					"T_MoraleMapHide2"
				},
				{
					"AreaItemMap3",
					"T_MoraleMapHide3"
				},
				{
					"AreaItemMap4",
					"T_MoraleMapHide4"
				},
				{
					"AreaItemMap5",
					"T_MoraleMapRed05"
				},
				{
					"LevelMapBg",
					"T_MoraleMapBgRed"
				},
				{
					"LevelMapTopBg",
					"T_MoraleMapBgTopRed"
				},
				{
					"LevelListLight",
					"T_MoraleListLightRed"
				},
				{
					"LevelSetOffLight",
					"T_MoraleLightSetoffRed"
				},
				{
					"LevelFrame",
					"T_MoraleFrameRed"
				},
				{
					"LevelTitleBg",
					"T_MoraleTitleBgRed"
				},
				{
					"AreaDetailItemBg1",
					"T_MoraleRedItem1"
				},
				{
					"AreaDetailItemBg2",
					"T_MoraleRedItem2"
				},
				{
					"AreaDetailItemBg3",
					"T_MoraleRedItem3"
				},
				{
					"AreaDetailItemBg4",
					"T_MoraleRedItem4"
				},
				{
					"AreaDetailItemBg5",
					"T_MoraleRedItem5"
				},
				{
					"StrongholdItemIncompleteBg1",
					"T_UnOccFlagLargerRedNor"
				},
				{
					"StrongholdItemCompleteBg1",
					"T_UnOccFlagLargerRedDone"
				},
				{
					"StrongholdItemIncompleteIcon1",
					"T_UnOccFlagLargerRedNor1"
				},
				{
					"StrongholdItemCompleteIcon1",
					"T_UnOccFlagLargerRedDone1"
				},
				{
					"StrongholdItemIncompleteBg2",
					"T_UnOccFlagBossRedNor"
				},
				{
					"StrongholdItemCompleteBg2",
					"T_UnOccFlagBossRedDone"
				},
				{
					"StrongholdItemIncompleteIcon2",
					"T_UnOccFlagBossRedNor1"
				},
				{
					"StrongholdItemCompleteIcon2",
					"T_UnOccFlagBossRedDone1"
				},
				{
					"MaskBg",
					"T_MoraleMaskRed"
				}
			};
			this.flagChallengeStyleRes = dictionary;
			this.flagChallengeStyleVideoPath = new Dictionary<EFlagChallengeUiStyleType, string>
			{
				{
					EFlagChallengeUiStyleType.Green,
					"/Game/Aki/UI/UIResources/UiActivity/Mp4/Morale/M_I_Morale_Green.M_I_Morale_Green"
				},
				{
					EFlagChallengeUiStyleType.Yellow,
					"/Game/Aki/UI/UIResources/UiActivity/Mp4/Morale/M_I_Morale_Yellow.M_I_Morale_Yellow"
				},
				{
					EFlagChallengeUiStyleType.Red,
					"/Game/Aki/UI/UIResources/UiActivity/Mp4/Morale/M_I_Morale_Red.M_I_Morale_Red"
				},
				{
					EFlagChallengeUiStyleType.Hidden,
					"/Game/Aki/UI/UIResources/UiActivity/Mp4/Morale/M_I_Morale_Red.M_I_Morale_Red"
				}
			};
			base..ctor();
		}

		// Token: 0x0401E868 RID: 125032
		public readonly Dictionary<EFlagChallengeUiStyleType, Dictionary<string, string>> flagChallengeStyleRes;

		// Token: 0x0401E869 RID: 125033
		public readonly Dictionary<EFlagChallengeUiStyleType, string> flagChallengeStyleVideoPath;

		// Token: 0x0401E86A RID: 125034
		public const int EXTRA_TEMP_FLAG_CHALLENGE_MAX_LEVEL_BUFF_ID = 632400018;

		// Token: 0x0401E86B RID: 125035
		public const int EXTRA_TEMP_FLAG_CHALLENGE_MAX_LEVEL = 100;

		// Token: 0x0401E86C RID: 125036
		public const string FLAG_CHALLENGE_CHARACTER_BUFF_TIPS_PARAM = "0";

		// Token: 0x0401E86D RID: 125037
		public const int FLAG_CHALLENGE_EXP_ITEM_TWEEN_INTERVA = 20;

		// Token: 0x0401E86E RID: 125038
		public const int FLAG_CHALLENGE_EXP_ITEM_CROSS_LEVEL_DIFF = 3;

		// Token: 0x0401E86F RID: 125039
		public const int FLAG_CHALLENGE_EXP_ITEM_COUNT = 10;

		// Token: 0x0401E870 RID: 125040
		public const float FLAG_CHALLENGE_EXP_PROGRESS_STEP = 0.1f;

		// Token: 0x0401E871 RID: 125041
		public const int FLAG_CHALLENGE_SETTLE_AUTO_LEAVE_TIME = 30;

		// Token: 0x0401E872 RID: 125042
		[Nullable(2)]
		private static FlagChallengeDefine _instance;
	}
}
