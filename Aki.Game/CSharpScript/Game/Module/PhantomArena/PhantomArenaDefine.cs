using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040D6 RID: 16598
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDefine
	{
		// Token: 0x0602A022 RID: 172066 RVA: 0x00BE0ECF File Offset: 0x00BDF0CF
		private static TCardSlotSortFunc CreateElementSortFunc(ECardElement element)
		{
			return delegate(CardSlotSortInfo a, CardSlotSortInfo b)
			{
				if (a.Element != b.Element)
				{
					if (a.Element == (int)element)
					{
						return -1;
					}
					if (b.Element == (int)element)
					{
						return 1;
					}
				}
				return 0;
			};
		}

		// Token: 0x0602A024 RID: 172068 RVA: 0x00BE0EF0 File Offset: 0x00BDF0F0
		// Note: this type is marked as 'beforefieldinit'.
		static PhantomArenaDefine()
		{
			Dictionary<ECardTabType, ECardElement[]> dictionary = new Dictionary<ECardTabType, ECardElement[]>();
			Dictionary<ECardTabType, ECardElement[]> dictionary2 = dictionary;
			ECardTabType key = ECardTabType.Ice;
			ECardElement[] array = new ECardElement[2];
			array[0] = ECardElement.Ice;
			dictionary2.Add(key, array);
			Dictionary<ECardTabType, ECardElement[]> dictionary3 = dictionary;
			ECardTabType key2 = ECardTabType.Fire;
			ECardElement[] array2 = new ECardElement[2];
			array2[0] = ECardElement.Fire;
			dictionary3.Add(key2, array2);
			Dictionary<ECardTabType, ECardElement[]> dictionary4 = dictionary;
			ECardTabType key3 = ECardTabType.Thunder;
			ECardElement[] array3 = new ECardElement[2];
			array3[0] = ECardElement.Thunder;
			dictionary4.Add(key3, array3);
			Dictionary<ECardTabType, ECardElement[]> dictionary5 = dictionary;
			ECardTabType key4 = ECardTabType.Wind;
			ECardElement[] array4 = new ECardElement[2];
			array4[0] = ECardElement.Wind;
			dictionary5.Add(key4, array4);
			Dictionary<ECardTabType, ECardElement[]> dictionary6 = dictionary;
			ECardTabType key5 = ECardTabType.Light;
			ECardElement[] array5 = new ECardElement[2];
			array5[0] = ECardElement.Light;
			dictionary6.Add(key5, array5);
			Dictionary<ECardTabType, ECardElement[]> dictionary7 = dictionary;
			ECardTabType key6 = ECardTabType.Dark;
			ECardElement[] array6 = new ECardElement[2];
			array6[0] = ECardElement.Dark;
			dictionary7.Add(key6, array6);
			PhantomArenaDefine.cardTabTypeToFilterElementList = dictionary;
			PhantomArenaDefine.cardTabTypeToElementConfigId = new Dictionary<ECardTabType, ECardElement>
			{
				{
					ECardTabType.Ice,
					ECardElement.Ice
				},
				{
					ECardTabType.Fire,
					ECardElement.Fire
				},
				{
					ECardTabType.Thunder,
					ECardElement.Thunder
				},
				{
					ECardTabType.Wind,
					ECardElement.Wind
				},
				{
					ECardTabType.Light,
					ECardElement.Light
				},
				{
					ECardTabType.Dark,
					ECardElement.Dark
				}
			};
			PhantomArenaDefine.cardSlotSortTypeToSortFunc = new Dictionary<ECardSlotSortType, TCardSlotSortFunc>
			{
				{
					ECardSlotSortType.Cost,
					(CardSlotSortInfo a, CardSlotSortInfo b) => b.Cost - a.Cost
				},
				{
					ECardSlotSortType.IceFirst,
					PhantomArenaDefine.CreateElementSortFunc(ECardElement.Ice)
				},
				{
					ECardSlotSortType.FireFirst,
					PhantomArenaDefine.CreateElementSortFunc(ECardElement.Fire)
				},
				{
					ECardSlotSortType.ThunderFirst,
					PhantomArenaDefine.CreateElementSortFunc(ECardElement.Thunder)
				},
				{
					ECardSlotSortType.WindFirst,
					PhantomArenaDefine.CreateElementSortFunc(ECardElement.Wind)
				},
				{
					ECardSlotSortType.LightFirst,
					PhantomArenaDefine.CreateElementSortFunc(ECardElement.Light)
				},
				{
					ECardSlotSortType.DarkFirst,
					PhantomArenaDefine.CreateElementSortFunc(ECardElement.Dark)
				}
			};
			PhantomArenaDefine.cardSlotDefaultSortFunc = delegate(CardSlotSortInfo a, CardSlotSortInfo b)
			{
				if (a.CardType != b.CardType)
				{
					if (a.CardType == ECardType.Field)
					{
						return -1;
					}
					if (b.CardType == ECardType.Field)
					{
						return 1;
					}
					return a.CardType - b.CardType;
				}
				else
				{
					if (a.Cost != b.Cost)
					{
						return b.Cost - a.Cost;
					}
					if (a.Element == b.Element)
					{
						return a.CardId - b.CardId;
					}
					if (a.Element == 0)
					{
						return 1;
					}
					if (b.Element == 0)
					{
						return -1;
					}
					return a.Element - b.Element;
				}
			};
			PhantomArenaDefine.deckCardSlotDefaultSortFunc = delegate(DeckCardSlotInfo a, DeckCardSlotInfo b)
			{
				if (a.CardType != b.CardType)
				{
					if (a.CardType == ECardType.Field)
					{
						return -1;
					}
					if (b.CardType == ECardType.Field)
					{
						return 1;
					}
					return a.CardType - b.CardType;
				}
				else
				{
					if (a.Cost != b.Cost)
					{
						return b.Cost - a.Cost;
					}
					if (a.Element == b.Element)
					{
						return a.CardId - b.CardId;
					}
					if (a.Element == 0)
					{
						return 1;
					}
					if (b.Element == 0)
					{
						return -1;
					}
					return a.Element - b.Element;
				}
			};
			PhantomArenaDefine.deckBuilderCardItemDataSortFunc = delegate(CardInfoBase a, CardInfoBase b)
			{
				if (a.CardType != b.CardType)
				{
					if (a.CardType == ECardType.Field)
					{
						return -1;
					}
					if (b.CardType == ECardType.Field)
					{
						return 1;
					}
					return a.CardType - b.CardType;
				}
				else
				{
					if (a.Cost != b.Cost)
					{
						return b.Cost - a.Cost;
					}
					if (a.Element == b.Element)
					{
						return a.CardId - b.CardId;
					}
					if (a.Element == 0)
					{
						return 1;
					}
					if (b.Element == 0)
					{
						return -1;
					}
					return a.Element - b.Element;
				}
			};
			PhantomArenaDefine.addCardFailedResultToTipTextId = new Dictionary<EAddCardResult, string>
			{
				{
					EAddCardResult.CoreSlotLocked,
					"PhantomBattle_1056"
				},
				{
					EAddCardResult.TotalCoreCardCountLimit,
					"PhantomBattle_1073"
				},
				{
					EAddCardResult.TotalNormalCardCountLimit,
					"PhantomBattle_1074"
				},
				{
					EAddCardResult.TotalFieldCardCountLimit,
					"PhantomBattle_1141"
				},
				{
					EAddCardResult.TotalItemCardCountLimit,
					"PhantomBattle_1142"
				},
				{
					EAddCardResult.ElementLimit,
					"PhantomBattle_1054"
				},
				{
					EAddCardResult.CoreCardSlotLimit,
					"PhantomBattle_1052"
				},
				{
					EAddCardResult.NormalCardSlotLimit,
					"PhantomBattle_1052"
				},
				{
					EAddCardResult.CardMaxLimitByCost3,
					"PhantomBattleGym_cost3_Limit"
				},
				{
					EAddCardResult.CardMaxLimitByCost1,
					"PhantomBattleGym_cost1_Limit"
				}
			};
			PhantomArenaDefine.phantomArenaEntranceShopTabIconMap = new Dictionary<EUiTabViewName, string[]>
			{
				{
					EUiTabViewName.PhantomArenaEntranceTaskTabView,
					new string[]
					{
						"SP_IconOutsideShop1Nor",
						"SP_IconOutsideShop1Sle"
					}
				},
				{
					EUiTabViewName.PhantomArenaEntranceShopTabView,
					new string[]
					{
						"SP_IconOutsideShop2Nor",
						"SP_IconOutsideShop2Sle"
					}
				}
			};
			PhantomArenaDefine.difficultNumTextures = new Dictionary<int, string>
			{
				{
					1,
					"T_ComRomeText_01"
				},
				{
					2,
					"T_ComRomeText_02"
				},
				{
					3,
					"T_ComRomeText_03"
				},
				{
					4,
					"T_ComRomeText_04"
				},
				{
					5,
					"T_ComRomeText_05"
				},
				{
					6,
					"T_ComRomeText_06"
				},
				{
					7,
					"T_ComRomeText_07"
				},
				{
					8,
					"T_ComRomeText_08"
				},
				{
					9,
					"T_ComRomeText_09"
				},
				{
					10,
					"T_ComRomeText_10"
				},
				{
					11,
					"T_ComRomeText_11"
				},
				{
					12,
					"T_ComRomeText_12"
				}
			};
			PhantomArenaDefine.phantomBattleSettleReasonToTextId = new Dictionary<PhantomArenaDefine.EPhantomBattleSettleReason, string>
			{
				{
					PhantomArenaDefine.EPhantomBattleSettleReason.CommonSettle,
					"PhantomBattle_1145"
				},
				{
					PhantomArenaDefine.EPhantomBattleSettleReason.RoundSettle,
					"PhantomBattle_1146"
				},
				{
					PhantomArenaDefine.EPhantomBattleSettleReason.LimitSettle,
					"PhantomBattle_1147"
				}
			};
		}

		// Token: 0x04016DE8 RID: 93672
		public const int CARD_COUNT_PER_PAGE = 8;

		// Token: 0x04016DE9 RID: 93673
		public const string CARD_ALL_ELEMENT_TAB_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconElementRound/T_IconElementAll.T_IconElementAll";

		// Token: 0x04016DEA RID: 93674
		public const string CARD_ALL_ELEMENT_TAB_COLOR = "FFFFFFFF";

		// Token: 0x04016DEB RID: 93675
		public const string CARD_SLOT_FRAME_NORMAL_ICON_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListNor.SP_IconOutsideTeamListNor";

		// Token: 0x04016DEC RID: 93676
		public const string CARD_SLOT_FRAME_GOLD_ICON_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListGold.SP_IconOutsideTeamListGold";

		// Token: 0x04016DED RID: 93677
		public const string CARD_COST_TEXT_ID = "PhantomBattle_1001";

		// Token: 0x04016DEE RID: 93678
		public const string CARD_ATTACK_TEXT_ID = "PhantomBattle_1002";

		// Token: 0x04016DEF RID: 93679
		public const string CARD_LIFE_TEXT_ID = "PhantomBattle_1003";

		// Token: 0x04016DF0 RID: 93680
		public const string CARD_CRIT_RATE_TEXT_ID = "PhantomBattle_1004";

		// Token: 0x04016DF1 RID: 93681
		public const string CARD_CRIT_DAMAGE_TEXT_ID = "PhantomBattle_1005";

		// Token: 0x04016DF2 RID: 93682
		public const string POINTS_NAME_TEXT = "PhantomBattle_1106";

		// Token: 0x04016DF3 RID: 93683
		public const string ACTIVITY_SUBVIEW_TEXT_UNLOCK = "PhantomBattle_1103";

		// Token: 0x04016DF4 RID: 93684
		public const int GYM_MAX_LEVEL = 7;

		// Token: 0x04016DF5 RID: 93685
		public const int GYM_UNLOCK_CHECKED_CACHE_KEY = 2;

		// Token: 0x04016DF6 RID: 93686
		public const int GYM_RED_DOT_CHECKED_CACHE_KEY = 3;

		// Token: 0x04016DF7 RID: 93687
		[StaticVariableRuleIgnore]
		public static readonly string[] positionGymLevel = new string[]
		{
			"left",
			"left",
			"middle",
			"middle",
			"right",
			"right",
			"right"
		};

		// Token: 0x04016DF8 RID: 93688
		public const int REPEAT_GYM_MAX_DIFFICULTY = 2;

		// Token: 0x04016DF9 RID: 93689
		public const float GYM_INERTIA_TWEEN_TIME = 0.618f;

		// Token: 0x04016DFA RID: 93690
		public const int GYM_BG_OFFSET_MAX = 330;

		// Token: 0x04016DFB RID: 93691
		public const int GYM_GYM_OFFSET_MIDDLE = -700;

		// Token: 0x04016DFC RID: 93692
		public const string ENTRANCE_TASK_TEXT_ID = "PhantomBattle_1093";

		// Token: 0x04016DFD RID: 93693
		public const string ENTRANCE_SHOP_TEXT_ID = "PhantomBattle_1094";

		// Token: 0x04016DFE RID: 93694
		public const string ENTRANCE_CARD_TEXT_ID = "PhantomBattle_1095";

		// Token: 0x04016DFF RID: 93695
		public const string ENTRANCE_ROLE_TEXT_ID = "PhantomBattle_1096";

		// Token: 0x04016E00 RID: 93696
		public const string ENTRANCE_COLLECTION_TEXT_ID = "PhantomBattle_1097";

		// Token: 0x04016E01 RID: 93697
		public const string ENTRANCE_MAINSHOP_ID = "PhantomBattle_1098";

		// Token: 0x04016E02 RID: 93698
		public const string ENTRANCE_LEVEL_COUNT_ID = "PhantomBattle_1025";

		// Token: 0x04016E03 RID: 93699
		public const string ENTRANCE_SHOP_COUNT_ID = "PhantomBattle_1100";

		// Token: 0x04016E04 RID: 93700
		public const string BVB_SPEEDUP_TIPS = "PhantomBattle_1107";

		// Token: 0x04016E05 RID: 93701
		public const string ENTRANCE_GYM_LOCK_TEXT_ID = "PhantomBattleGym_Locked";

		// Token: 0x04016E06 RID: 93702
		public const string ENTRANCE_NPC_LOCK_TEXT_ID = "PhantomBattleNpc_Locked";

		// Token: 0x04016E07 RID: 93703
		public const string ENTRANCE_MASTER_INFO_EXP_TEXT_ID = "TowerDefence_LV";

		// Token: 0x04016E08 RID: 93704
		public const string COLLECT_BADGE_GROUP_TITLE = "PrefabTextItem_3661046131_Text";

		// Token: 0x04016E09 RID: 93705
		public const string COLLECT_ELEMENT_PHYSICAL_NAME = "PhantomBattle_1123";

		// Token: 0x04016E0A RID: 93706
		public const int HELP_ID_ENTRANCE = 334;

		// Token: 0x04016E0B RID: 93707
		public const int HELP_ID_SHOP = 335;

		// Token: 0x04016E0C RID: 93708
		public const int HELP_ID_COLLECT = 338;

		// Token: 0x04016E0D RID: 93709
		public const int HELP_ID_COLLECT_NEW = 477;

		// Token: 0x04016E0E RID: 93710
		public const int HELP_ID_LEVEL = 341;

		// Token: 0x04016E0F RID: 93711
		public const int INSTANCE_SUCCESS = 3029;

		// Token: 0x04016E10 RID: 93712
		public const int INSTANCE_FAIL = 3030;

		// Token: 0x04016E11 RID: 93713
		public const string TEXT_RESULT_LEVEL_SKILL_DESC = "Text_ResultLevelSkillDesc_Text";

		// Token: 0x04016E12 RID: 93714
		public const string GYM_BG_LEFT_COLOR = "GymTabViewTextureBgLeftColor";

		// Token: 0x04016E13 RID: 93715
		public const string GYM_BG_LEFT_GRAY = "GymTabViewTextureBgLeftGray";

		// Token: 0x04016E14 RID: 93716
		public const string GYM_BG_LEFT_WHITE = "GymTabViewTextureBgLeftWhite";

		// Token: 0x04016E15 RID: 93717
		public const string GYM_BG_MIDDLE_COLOR = "GymTabViewTextureBgMiddleColor";

		// Token: 0x04016E16 RID: 93718
		public const string GYM_BG_MIDDLE_GRAY = "GymTabViewTextureBgMiddleGray";

		// Token: 0x04016E17 RID: 93719
		public const string GYM_BG_MIDDLE_WHITE = "GymTabViewTextureBgMiddleWhite";

		// Token: 0x04016E18 RID: 93720
		public const string GYM_BG_RIGHT_COLOR = "GymTabViewTextureBgRightColor";

		// Token: 0x04016E19 RID: 93721
		public const string GYM_BG_RIGHT_GRAY = "GymTabViewTextureBgRightGray";

		// Token: 0x04016E1A RID: 93722
		public const int DECK_ID_NONE = -1;

		// Token: 0x04016E1B RID: 93723
		public const int DECK_ID_EMPTY_TEMP = -100;

		// Token: 0x04016E1C RID: 93724
		public const int SPECIAL_TASK_TABTYPE = 0;

		// Token: 0x04016E1D RID: 93725
		public const string MYSTERY_NPC_HEAD = "MysteryNpcHead";

		// Token: 0x04016E1E RID: 93726
		public const int HAND_PHANTOMARENA_INDEX = -1;

		// Token: 0x04016E1F RID: 93727
		public const int UNVALID_FIGHT_ID = -1;

		// Token: 0x04016E20 RID: 93728
		public const int COST_ONE = 1;

		// Token: 0x04016E21 RID: 93729
		public const int COST_THREE = 3;

		// Token: 0x04016E22 RID: 93730
		[StaticVariableRuleIgnore]
		public static Dictionary<ECardTabType, ECardElement[]> cardTabTypeToFilterElementList;

		// Token: 0x04016E23 RID: 93731
		[StaticVariableRuleIgnore]
		public static Dictionary<ECardTabType, ECardElement> cardTabTypeToElementConfigId;

		// Token: 0x04016E24 RID: 93732
		[StaticVariableRuleIgnore]
		public static Dictionary<ECardSlotSortType, TCardSlotSortFunc> cardSlotSortTypeToSortFunc;

		// Token: 0x04016E25 RID: 93733
		[StaticVariableRuleIgnore]
		public static TCardSlotSortFunc cardSlotDefaultSortFunc;

		// Token: 0x04016E26 RID: 93734
		[StaticVariableRuleIgnore]
		public static TDeckCardSlotSortFunc deckCardSlotDefaultSortFunc;

		// Token: 0x04016E27 RID: 93735
		[StaticVariableRuleIgnore]
		public static TDeckBuilderCardItemDataSortFunc deckBuilderCardItemDataSortFunc;

		// Token: 0x04016E28 RID: 93736
		[StaticVariableRuleIgnore]
		public static Dictionary<EAddCardResult, string> addCardFailedResultToTipTextId;

		// Token: 0x04016E29 RID: 93737
		[StaticVariableRuleIgnore]
		public static Dictionary<EUiTabViewName, string[]> phantomArenaEntranceShopTabIconMap;

		// Token: 0x04016E2A RID: 93738
		[StaticVariableRuleIgnore]
		public static Dictionary<int, string> difficultNumTextures;

		// Token: 0x04016E2B RID: 93739
		[StaticVariableRuleIgnore]
		public static Dictionary<PhantomArenaDefine.EPhantomBattleSettleReason, string> phantomBattleSettleReasonToTextId;

		// Token: 0x02009CD2 RID: 40146
		[NullableContext(0)]
		public enum EPhantomBattleSettleReason
		{
			// Token: 0x04030C23 RID: 199715
			CommonSettle,
			// Token: 0x04030C24 RID: 199716
			RoundSettle,
			// Token: 0x04030C25 RID: 199717
			LimitSettle
		}
	}
}
