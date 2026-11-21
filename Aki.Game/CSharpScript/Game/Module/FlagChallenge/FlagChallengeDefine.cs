using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A1B RID: 18971
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeDefine : Singleton
	{
		// Token: 0x17005FBF RID: 24511
		// (get) Token: 0x0602F8C8 RID: 194760 RVA: 0x00D41EBC File Offset: 0x00D400BC
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

		// Token: 0x0602F8C9 RID: 194761 RVA: 0x00D41EDF File Offset: 0x00D400DF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F8CA RID: 194762 RVA: 0x00D41EE1 File Offset: 0x00D400E1
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeDefine instance = FlagChallengeDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FlagChallengeDefine._instance = null;
		}

		// Token: 0x0602F8CB RID: 194763 RVA: 0x00D41EFA File Offset: 0x00D400FA
		static FlagChallengeDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeDefine.CreateStaticDefaultValue), new Action(FlagChallengeDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602F8CC RID: 194764 RVA: 0x00D41F1C File Offset: 0x00D4011C
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

		// Token: 0x0401930F RID: 103183
		public readonly Dictionary<EFlagChallengeUiStyleType, Dictionary<string, string>> flagChallengeStyleRes;

		// Token: 0x04019310 RID: 103184
		public readonly Dictionary<EFlagChallengeUiStyleType, string> flagChallengeStyleVideoPath;

		// Token: 0x04019311 RID: 103185
		public const int EXTRA_TEMP_FLAG_CHALLENGE_MAX_LEVEL_BUFF_ID = 632400018;

		// Token: 0x04019312 RID: 103186
		public const int EXTRA_TEMP_FLAG_CHALLENGE_MAX_LEVEL = 100;

		// Token: 0x04019313 RID: 103187
		public const string FLAG_CHALLENGE_CHARACTER_BUFF_TIPS_PARAM = "0";

		// Token: 0x04019314 RID: 103188
		public const int FLAG_CHALLENGE_EXP_ITEM_TWEEN_INTERVA = 20;

		// Token: 0x04019315 RID: 103189
		public const int FLAG_CHALLENGE_EXP_ITEM_CROSS_LEVEL_DIFF = 3;

		// Token: 0x04019316 RID: 103190
		public const int FLAG_CHALLENGE_EXP_ITEM_COUNT = 10;

		// Token: 0x04019317 RID: 103191
		public const float FLAG_CHALLENGE_EXP_PROGRESS_STEP = 0.1f;

		// Token: 0x04019318 RID: 103192
		public const int FLAG_CHALLENGE_SETTLE_AUTO_LEAVE_TIME = 30;

		// Token: 0x04019319 RID: 103193
		[Nullable(2)]
		private static FlagChallengeDefine _instance;
	}
}
