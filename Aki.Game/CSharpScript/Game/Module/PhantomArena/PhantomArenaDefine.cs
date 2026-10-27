using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005106 RID: 20742
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDefine
	{
		// Token: 0x06035129 RID: 217385 RVA: 0x00C93ABB File Offset: 0x00C91CBB
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

		// Token: 0x0603512B RID: 217387 RVA: 0x00C93ADC File Offset: 0x00C91CDC
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

		// Token: 0x0401C3B5 RID: 115637
		public const int CARD_COUNT_PER_PAGE = 8;

		// Token: 0x0401C3B6 RID: 115638
		public const string CARD_ALL_ELEMENT_TAB_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/IconElementRound/T_IconElementAll.T_IconElementAll";

		// Token: 0x0401C3B7 RID: 115639
		public const string CARD_ALL_ELEMENT_TAB_COLOR = "FFFFFFFF";

		// Token: 0x0401C3B8 RID: 115640
		public const string CARD_SLOT_FRAME_NORMAL_ICON_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListNor.SP_IconOutsideTeamListNor";

		// Token: 0x0401C3B9 RID: 115641
		public const string CARD_SLOT_FRAME_GOLD_ICON_PATH = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity24/SoundRemnantArena/Outside/SP_IconOutsideTeamListGold.SP_IconOutsideTeamListGold";

		// Token: 0x0401C3BA RID: 115642
		public const string CARD_COST_TEXT_ID = "PhantomBattle_1001";

		// Token: 0x0401C3BB RID: 115643
		public const string CARD_ATTACK_TEXT_ID = "PhantomBattle_1002";

		// Token: 0x0401C3BC RID: 115644
		public const string CARD_LIFE_TEXT_ID = "PhantomBattle_1003";

		// Token: 0x0401C3BD RID: 115645
		public const string CARD_CRIT_RATE_TEXT_ID = "PhantomBattle_1004";

		// Token: 0x0401C3BE RID: 115646
		public const string CARD_CRIT_DAMAGE_TEXT_ID = "PhantomBattle_1005";

		// Token: 0x0401C3BF RID: 115647
		public const string POINTS_NAME_TEXT = "PhantomBattle_1106";

		// Token: 0x0401C3C0 RID: 115648
		public const string ACTIVITY_SUBVIEW_TEXT_UNLOCK = "PhantomBattle_1103";

		// Token: 0x0401C3C1 RID: 115649
		public const int GYM_MAX_LEVEL = 7;

		// Token: 0x0401C3C2 RID: 115650
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

		// Token: 0x0401C3C3 RID: 115651
		public const int REPEAT_GYM_MAX_DIFFICULTY = 2;

		// Token: 0x0401C3C4 RID: 115652
		public const float GYM_INERTIA_TWEEN_TIME = 0.618f;

		// Token: 0x0401C3C5 RID: 115653
		public const int GYM_BG_OFFSET_MAX = 330;

		// Token: 0x0401C3C6 RID: 115654
		public const int GYM_GYM_OFFSET_MIDDLE = -700;

		// Token: 0x0401C3C7 RID: 115655
		public const string ENTRANCE_TASK_TEXT_ID = "PhantomBattle_1093";

		// Token: 0x0401C3C8 RID: 115656
		public const string ENTRANCE_SHOP_TEXT_ID = "PhantomBattle_1094";

		// Token: 0x0401C3C9 RID: 115657
		public const string ENTRANCE_CARD_TEXT_ID = "PhantomBattle_1095";

		// Token: 0x0401C3CA RID: 115658
		public const string ENTRANCE_ROLE_TEXT_ID = "PhantomBattle_1096";

		// Token: 0x0401C3CB RID: 115659
		public const string ENTRANCE_COLLECTION_TEXT_ID = "PhantomBattle_1097";

		// Token: 0x0401C3CC RID: 115660
		public const string ENTRANCE_MAINSHOP_ID = "PhantomBattle_1098";

		// Token: 0x0401C3CD RID: 115661
		public const string ENTRANCE_LEVEL_COUNT_ID = "PhantomBattle_1025";

		// Token: 0x0401C3CE RID: 115662
		public const string ENTRANCE_SHOP_COUNT_ID = "PhantomBattle_1100";

		// Token: 0x0401C3CF RID: 115663
		public const string BVB_SPEEDUP_TIPS = "PhantomBattle_1107";

		// Token: 0x0401C3D0 RID: 115664
		public const string ENTRANCE_GYM_LOCK_TEXT_ID = "PhantomBattleGym_Locked";

		// Token: 0x0401C3D1 RID: 115665
		public const string ENTRANCE_NPC_LOCK_TEXT_ID = "PhantomBattleNpc_Locked";

		// Token: 0x0401C3D2 RID: 115666
		public const string ENTRANCE_MASTER_INFO_EXP_TEXT_ID = "TowerDefence_LV";

		// Token: 0x0401C3D3 RID: 115667
		public const string COLLECT_BADGE_GROUP_TITLE = "PrefabTextItem_3661046131_Text";

		// Token: 0x0401C3D4 RID: 115668
		public const string COLLECT_ELEMENT_PHYSICAL_NAME = "PhantomBattle_1123";

		// Token: 0x0401C3D5 RID: 115669
		public const int HELP_ID_ENTRANCE = 334;

		// Token: 0x0401C3D6 RID: 115670
		public const int HELP_ID_SHOP = 335;

		// Token: 0x0401C3D7 RID: 115671
		public const int HELP_ID_COLLECT = 338;

		// Token: 0x0401C3D8 RID: 115672
		public const int HELP_ID_COLLECT_NEW = 477;

		// Token: 0x0401C3D9 RID: 115673
		public const int HELP_ID_LEVEL = 341;

		// Token: 0x0401C3DA RID: 115674
		public const int INSTANCE_SUCCESS = 3029;

		// Token: 0x0401C3DB RID: 115675
		public const int INSTANCE_FAIL = 3030;

		// Token: 0x0401C3DC RID: 115676
		public const string TEXT_RESULT_LEVEL_SKILL_DESC = "Text_ResultLevelSkillDesc_Text";

		// Token: 0x0401C3DD RID: 115677
		public const string GYM_BG_LEFT_COLOR = "GymTabViewTextureBgLeftColor";

		// Token: 0x0401C3DE RID: 115678
		public const string GYM_BG_LEFT_GRAY = "GymTabViewTextureBgLeftGray";

		// Token: 0x0401C3DF RID: 115679
		public const string GYM_BG_LEFT_WHITE = "GymTabViewTextureBgLeftWhite";

		// Token: 0x0401C3E0 RID: 115680
		public const string GYM_BG_MIDDLE_COLOR = "GymTabViewTextureBgMiddleColor";

		// Token: 0x0401C3E1 RID: 115681
		public const string GYM_BG_MIDDLE_GRAY = "GymTabViewTextureBgMiddleGray";

		// Token: 0x0401C3E2 RID: 115682
		public const string GYM_BG_MIDDLE_WHITE = "GymTabViewTextureBgMiddleWhite";

		// Token: 0x0401C3E3 RID: 115683
		public const string GYM_BG_RIGHT_COLOR = "GymTabViewTextureBgRightColor";

		// Token: 0x0401C3E4 RID: 115684
		public const string GYM_BG_RIGHT_GRAY = "GymTabViewTextureBgRightGray";

		// Token: 0x0401C3E5 RID: 115685
		public const int DECK_ID_NONE = -1;

		// Token: 0x0401C3E6 RID: 115686
		public const int DECK_ID_EMPTY_TEMP = -100;

		// Token: 0x0401C3E7 RID: 115687
		public const int SPECIAL_TASK_TABTYPE = 0;

		// Token: 0x0401C3E8 RID: 115688
		public const string MYSTERY_NPC_HEAD = "MysteryNpcHead";

		// Token: 0x0401C3E9 RID: 115689
		public const int HAND_PHANTOMARENA_INDEX = -1;

		// Token: 0x0401C3EA RID: 115690
		public const int UNVALID_FIGHT_ID = -1;

		// Token: 0x0401C3EB RID: 115691
		public const int COST_ONE = 1;

		// Token: 0x0401C3EC RID: 115692
		public const int COST_THREE = 3;

		// Token: 0x0401C3ED RID: 115693
		[StaticVariableRuleIgnore]
		public static Dictionary<ECardTabType, ECardElement[]> cardTabTypeToFilterElementList;

		// Token: 0x0401C3EE RID: 115694
		[StaticVariableRuleIgnore]
		public static Dictionary<ECardTabType, ECardElement> cardTabTypeToElementConfigId;

		// Token: 0x0401C3EF RID: 115695
		[StaticVariableRuleIgnore]
		public static Dictionary<ECardSlotSortType, TCardSlotSortFunc> cardSlotSortTypeToSortFunc;

		// Token: 0x0401C3F0 RID: 115696
		[StaticVariableRuleIgnore]
		public static TCardSlotSortFunc cardSlotDefaultSortFunc;

		// Token: 0x0401C3F1 RID: 115697
		[StaticVariableRuleIgnore]
		public static TDeckCardSlotSortFunc deckCardSlotDefaultSortFunc;

		// Token: 0x0401C3F2 RID: 115698
		[StaticVariableRuleIgnore]
		public static TDeckBuilderCardItemDataSortFunc deckBuilderCardItemDataSortFunc;

		// Token: 0x0401C3F3 RID: 115699
		[StaticVariableRuleIgnore]
		public static Dictionary<EAddCardResult, string> addCardFailedResultToTipTextId;

		// Token: 0x0401C3F4 RID: 115700
		[StaticVariableRuleIgnore]
		public static Dictionary<EUiTabViewName, string[]> phantomArenaEntranceShopTabIconMap;

		// Token: 0x0401C3F5 RID: 115701
		[StaticVariableRuleIgnore]
		public static Dictionary<int, string> difficultNumTextures;

		// Token: 0x0401C3F6 RID: 115702
		[StaticVariableRuleIgnore]
		public static Dictionary<PhantomArenaDefine.EPhantomBattleSettleReason, string> phantomBattleSettleReasonToTextId;

		// Token: 0x0200B299 RID: 45721
		[NullableContext(0)]
		public enum EPhantomBattleSettleReason
		{
			// Token: 0x040361CE RID: 221646
			CommonSettle,
			// Token: 0x040361CF RID: 221647
			RoundSettle,
			// Token: 0x040361D0 RID: 221648
			LimitSettle
		}
	}
}
