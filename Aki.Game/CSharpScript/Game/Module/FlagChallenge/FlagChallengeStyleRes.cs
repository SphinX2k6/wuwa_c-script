using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A19 RID: 18969
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeStyleRes : Singleton
	{
		// Token: 0x17005FBE RID: 24510
		// (get) Token: 0x0602F8C2 RID: 194754 RVA: 0x00D418DB File Offset: 0x00D3FADB
		public static FlagChallengeStyleRes Instance
		{
			get
			{
				if (FlagChallengeStyleRes._instance == null)
				{
					FlagChallengeStyleRes._instance = new FlagChallengeStyleRes();
					FlagChallengeStyleRes._instance.OnInit();
				}
				return FlagChallengeStyleRes._instance;
			}
		}

		// Token: 0x0602F8C3 RID: 194755 RVA: 0x00D418FE File Offset: 0x00D3FAFE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F8C4 RID: 194756 RVA: 0x00D41900 File Offset: 0x00D3FB00
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeStyleRes instance = FlagChallengeStyleRes._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			FlagChallengeStyleRes._instance = null;
		}

		// Token: 0x0602F8C5 RID: 194757 RVA: 0x00D41919 File Offset: 0x00D3FB19
		static FlagChallengeStyleRes()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeStyleRes.CreateStaticDefaultValue), new Action(FlagChallengeStyleRes.ResetStaticDefaultValue));
		}

		// Token: 0x0602F8C6 RID: 194758 RVA: 0x00D41938 File Offset: 0x00D3FB38
		public FlagChallengeStyleRes()
		{
			Dictionary<EFlagChallengeUiStyleType, FlagChallengeStyleFlat> dictionary = new Dictionary<EFlagChallengeUiStyleType, FlagChallengeStyleFlat>();
			dictionary[EFlagChallengeUiStyleType.Green] = new FlagChallengeStyleFlat
			{
				LevelTabItemNormal = "T_MoraleTabNorGreen",
				LevelTabItemHover = "T_MoraleTabHoldGreen",
				LevelTabItemSelect = "T_MoraleTabSleGreen",
				AreaItemBg = "T_MoraleItemBgGreen",
				AreaItemLevelBg = "SP_MoraleMonsterLvGreen",
				AreaItemMap1 = "T_MoraleMapGreen01",
				AreaItemMap2 = "T_MoraleMapGreen02",
				AreaItemMap3 = "T_MoraleMapGreen03",
				AreaItemMap4 = "T_MoraleMapGreen04",
				AreaItemMap5 = "T_MoraleMapGreen05",
				LevelMapBg = "T_MoraleMapBgGreen",
				LevelMapTopBg = "T_MoraleMapBgTopGreen",
				LevelListLight = "T_MoraleListLightGreen",
				LevelSetOffLight = "T_MoraleLightSetoffGreen",
				LevelFrame = "T_MoraleFrameGreen",
				LevelTitleBg = "T_MoraleTitleBgGreen",
				AreaDetailItemBg1 = "T_MoraleGreenItem1",
				AreaDetailItemBg2 = "T_MoraleGreenItem2",
				AreaDetailItemBg3 = "T_MoraleGreenItem3",
				AreaDetailItemBg4 = "T_MoraleGreenItem4",
				AreaDetailItemBg5 = "T_MoraleGreenItem5",
				StrongholdItemIncompleteBg1 = "T_UnOccFlagLargerGreenNor",
				StrongholdItemCompleteBg1 = "T_UnOccFlagLargerGreenDone",
				StrongholdItemIncompleteIcon1 = "T_UnOccFlagLargerGreenNor1",
				StrongholdItemCompleteIcon1 = "T_UnOccFlagLargerGreenDone1",
				StrongholdItemIncompleteBg2 = "T_UnOccFlagBossGreenNor",
				StrongholdItemCompleteBg2 = "T_UnOccFlagBossGreenDone",
				StrongholdItemIncompleteIcon2 = "T_UnOccFlagBossGreenNor1",
				StrongholdItemCompleteIcon2 = "T_UnOccFlagBossGreenDone1",
				MaskBg = "T_MoraleMaskGreen"
			};
			dictionary[EFlagChallengeUiStyleType.Yellow] = new FlagChallengeStyleFlat
			{
				LevelTabItemNormal = "T_MoraleTabNorYellow",
				LevelTabItemHover = "T_MoraleTabHoldYellow",
				LevelTabItemSelect = "T_MoraleTabSleYellow",
				AreaItemBg = "T_MoraleItemBgYellow",
				AreaItemLevelBg = "SP_MoraleMonsterLvYellow",
				AreaItemMap1 = "T_MoraleMapYellow01",
				AreaItemMap2 = "T_MoraleMapYellow02",
				AreaItemMap3 = "T_MoraleMapYellow03",
				AreaItemMap4 = "T_MoraleMapYellow04",
				AreaItemMap5 = "T_MoraleMapYellow05",
				LevelMapBg = "T_MoraleMapBgYellow",
				LevelMapTopBg = "T_MoraleMapBgTopYellow",
				LevelListLight = "T_MoraleListLightYellow",
				LevelSetOffLight = "T_MoraleLightSetoffYellow",
				LevelFrame = "T_MoraleFrameYellow",
				LevelTitleBg = "T_MoraleTitleBgYellow",
				AreaDetailItemBg1 = "T_MoraleYellowItem1",
				AreaDetailItemBg2 = "T_MoraleYellowItem2",
				AreaDetailItemBg3 = "T_MoraleYellowItem3",
				AreaDetailItemBg4 = "T_MoraleYellowItem4",
				AreaDetailItemBg5 = "T_MoraleYellowItem5",
				StrongholdItemIncompleteBg1 = "T_UnOccFlagLargerYellowNor",
				StrongholdItemCompleteBg1 = "T_UnOccFlagLargerYellowDone",
				StrongholdItemIncompleteIcon1 = "T_UnOccFlagLargerYellowNor1",
				StrongholdItemCompleteIcon1 = "T_UnOccFlagLargerYellowDone1",
				StrongholdItemIncompleteBg2 = "T_UnOccFlagBossYellowNor",
				StrongholdItemCompleteBg2 = "T_UnOccFlagBossYellowDone",
				StrongholdItemIncompleteIcon2 = "T_UnOccFlagBossYellowNor1",
				StrongholdItemCompleteIcon2 = "T_UnOccFlagBossYellowDone1",
				MaskBg = "T_MoraleMaskYellow"
			};
			dictionary[EFlagChallengeUiStyleType.Red] = new FlagChallengeStyleFlat
			{
				LevelTabItemNormal = "T_MoraleTabNorRed",
				LevelTabItemHover = "T_MoraleTabHoldRed",
				LevelTabItemSelect = "T_MoraleTabSleRed",
				AreaItemBg = "T_MoraleItemBgRed",
				AreaItemLevelBg = "SP_MoraleMonsterLvRed",
				AreaItemMap1 = "T_MoraleMapRed01",
				AreaItemMap2 = "T_MoraleMapRed02",
				AreaItemMap3 = "T_MoraleMapRed03",
				AreaItemMap4 = "T_MoraleMapRed04",
				AreaItemMap5 = "T_MoraleMapRed05",
				LevelMapBg = "T_MoraleMapBgRed",
				LevelMapTopBg = "T_MoraleMapBgTopRed",
				LevelListLight = "T_MoraleListLightRed",
				LevelSetOffLight = "T_MoraleLightSetoffRed",
				LevelFrame = "T_MoraleFrameRed",
				LevelTitleBg = "T_MoraleTitleBgRed",
				AreaDetailItemBg1 = "T_MoraleRedItem1",
				AreaDetailItemBg2 = "T_MoraleRedItem2",
				AreaDetailItemBg3 = "T_MoraleRedItem3",
				AreaDetailItemBg4 = "T_MoraleRedItem4",
				AreaDetailItemBg5 = "T_MoraleRedItem5",
				StrongholdItemIncompleteBg1 = "T_UnOccFlagLargerRedNor",
				StrongholdItemCompleteBg1 = "T_UnOccFlagLargerRedDone",
				StrongholdItemIncompleteIcon1 = "T_UnOccFlagLargerRedNor1",
				StrongholdItemCompleteIcon1 = "T_UnOccFlagLargerRedDone1",
				StrongholdItemIncompleteBg2 = "T_UnOccFlagBossRedNor",
				StrongholdItemCompleteBg2 = "T_UnOccFlagBossRedDone",
				StrongholdItemIncompleteIcon2 = "T_UnOccFlagBossRedNor1",
				StrongholdItemCompleteIcon2 = "T_UnOccFlagBossRedDone1",
				MaskBg = "T_MoraleMaskRed"
			};
			dictionary[EFlagChallengeUiStyleType.Hidden] = new FlagChallengeStyleFlat
			{
				LevelTabItemNormal = "T_MoraleTabNorRed",
				LevelTabItemHover = "T_MoraleTabHoldRed",
				LevelTabItemSelect = "T_MoraleTabSleRed",
				AreaItemBg = "T_MoraleItemBgRed",
				AreaItemLevelBg = "SP_MoraleMonsterLvRed",
				AreaItemMap1 = "T_MoraleMapRed01",
				AreaItemMap2 = "T_MoraleMapHide2",
				AreaItemMap3 = "T_MoraleMapHide3",
				AreaItemMap4 = "T_MoraleMapHide4",
				AreaItemMap5 = "T_MoraleMapRed05",
				LevelMapBg = "T_MoraleMapBgRed",
				LevelMapTopBg = "T_MoraleMapBgTopRed",
				LevelListLight = "T_MoraleListLightRed",
				LevelSetOffLight = "T_MoraleLightSetoffRed",
				LevelFrame = "T_MoraleFrameRed",
				LevelTitleBg = "T_MoraleTitleBgRed",
				AreaDetailItemBg1 = "T_MoraleRedItem1",
				AreaDetailItemBg2 = "T_MoraleRedItem2",
				AreaDetailItemBg3 = "T_MoraleRedItem3",
				AreaDetailItemBg4 = "T_MoraleRedItem4",
				AreaDetailItemBg5 = "T_MoraleRedItem5",
				StrongholdItemIncompleteBg1 = "T_UnOccFlagLargerRedNor",
				StrongholdItemCompleteBg1 = "T_UnOccFlagLargerRedDone",
				StrongholdItemIncompleteIcon1 = "T_UnOccFlagLargerRedNor1",
				StrongholdItemCompleteIcon1 = "T_UnOccFlagLargerRedDone1",
				StrongholdItemIncompleteBg2 = "T_UnOccFlagBossRedNor",
				StrongholdItemCompleteBg2 = "T_UnOccFlagBossRedDone",
				StrongholdItemIncompleteIcon2 = "T_UnOccFlagBossRedNor1",
				StrongholdItemCompleteIcon2 = "T_UnOccFlagBossRedDone1",
				MaskBg = "T_MoraleMaskRed"
			};
			this.Data = dictionary.ToFrozenDictionary(null);
			base..ctor();
		}

		// Token: 0x040192EF RID: 103151
		[StaticVariableRuleIgnore]
		public readonly FrozenDictionary<EFlagChallengeUiStyleType, FlagChallengeStyleFlat> Data;

		// Token: 0x040192F0 RID: 103152
		[Nullable(2)]
		private static FlagChallengeStyleRes _instance;
	}
}
