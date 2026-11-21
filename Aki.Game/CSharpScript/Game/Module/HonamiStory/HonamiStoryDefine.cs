using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02004900 RID: 18688
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryDefine : Singleton
	{
		// Token: 0x17005EAF RID: 24239
		// (get) Token: 0x0602EEF3 RID: 192243 RVA: 0x00D195E1 File Offset: 0x00D177E1
		public static HonamiStoryDefine Instance
		{
			get
			{
				if (HonamiStoryDefine._instance == null)
				{
					HonamiStoryDefine._instance = new HonamiStoryDefine();
					HonamiStoryDefine._instance.OnInit();
				}
				return HonamiStoryDefine._instance;
			}
		}

		// Token: 0x0602EEF4 RID: 192244 RVA: 0x00D19604 File Offset: 0x00D17804
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EEF5 RID: 192245 RVA: 0x00D19606 File Offset: 0x00D17806
		public static void ResetStaticDefaultValue()
		{
			HonamiStoryDefine instance = HonamiStoryDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HonamiStoryDefine._instance = null;
		}

		// Token: 0x0602EEF6 RID: 192246 RVA: 0x00D1961F File Offset: 0x00D1781F
		static HonamiStoryDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryDefine.CreateStaticDefaultValue), new Action(HonamiStoryDefine.ResetStaticDefaultValue));
		}

		// Token: 0x04018E1E RID: 101918
		public const int HONAMI_GRID_ITEM_WIDTH = 86;

		// Token: 0x04018E1F RID: 101919
		public const int HONAMI_GRID_ITEM_HEIGHT = 86;

		// Token: 0x04018E20 RID: 101920
		public const int HONAMI_GRID_ITEM_WIDTH_MOBILE = 134;

		// Token: 0x04018E21 RID: 101921
		public const int HONAMI_GRID_ITEM_HEIGHT_MOBILE = 134;

		// Token: 0x04018E22 RID: 101922
		public const int HONAMI_GRID_ITEM_HORIZONTAL_INTERVAL = 2;

		// Token: 0x04018E23 RID: 101923
		public const int HONAMI_GRID_ITEM_VERTICAL_INTERVAL = 2;

		// Token: 0x04018E24 RID: 101924
		public const int HONAMI_GRID_ITEM_HORIZONTAL_INTERVAL_MOBILE = 2;

		// Token: 0x04018E25 RID: 101925
		public const int HONAMI_GRID_ITEM_VERTICAL_INTERVAL_MOBILE = 2;

		// Token: 0x04018E26 RID: 101926
		public const int HONAMI_ROLE_TEAM_COUNT = 3;

		// Token: 0x04018E27 RID: 101927
		public const int HONAMI_ROLE_SLOT_OFFSET = 100;

		// Token: 0x04018E28 RID: 101928
		public const int HONAMI_ROLE_SLOT_MAX = 6;

		// Token: 0x04018E29 RID: 101929
		public const int HONAMI_DUNGEON_DEFAULT_AREA_ID = 1;

		// Token: 0x04018E2A RID: 101930
		public const int HONAMI_ROLE_VIRTUAL_SCORE = 100;

		// Token: 0x04018E2B RID: 101931
		public const string HONAMI_EMPTY_GRID_BG = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStoryBackpack/SP_GridEmpty.SP_GridEmpty";

		// Token: 0x04018E2C RID: 101932
		public const string HONAMI_MASCOT_EMPTY_PATH = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity28/HonamiStory/HonamiStoryHead/T_HonamiStoryHeadBEmpty.T_HonamiStoryHeadBEmpty";

		// Token: 0x04018E2D RID: 101933
		public const string HONAMI_MASCOT_EMPTY_BIG_PATH = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity28/HonamiStory/HonamiStoryHead/T_HonamiStoryHeadAEmpty.T_HonamiStoryHeadAEmpty";

		// Token: 0x04018E2E RID: 101934
		public const int HONAMI_DUNGEON_ENTRANCE_ID = 1521;

		// Token: 0x04018E2F RID: 101935
		public const float HONAMI_ENABLE_ALPHA = 1f;

		// Token: 0x04018E30 RID: 101936
		public const float HONAMI_DISABLE_ALPHA = 0.4f;

		// Token: 0x04018E31 RID: 101937
		public const int HONAMI_BAKCPACK_CLICK_CD = 300;

		// Token: 0x04018E32 RID: 101938
		public const int HONAMI_DUNGEON_ID = 8760;

		// Token: 0x04018E33 RID: 101939
		public const int HONAMI_MAIN_QUEST_ID = 880000044;

		// Token: 0x04018E34 RID: 101940
		public const int HONAMI_MAX_SHOW_REVENUE = 99999999;

		// Token: 0x04018E35 RID: 101941
		public const string RICHTXT_QUEST = "<color=#b3dffa>{0}</color>";

		// Token: 0x04018E36 RID: 101942
		public readonly Dictionary<EHonamiStoryItemType, string> honamiItemTypeMap = new Dictionary<EHonamiStoryItemType, string>
		{
			{
				EHonamiStoryItemType.Plugin,
				"HonamiStory_ItemType_Plugin"
			},
			{
				EHonamiStoryItemType.Normal,
				"HonamiStory_ItemType_Normal"
			}
		};

		// Token: 0x04018E37 RID: 101943
		public readonly Dictionary<EHonamiStoryBackpackType, EHonamiStoryBackpack> HonamiBackpackTypeMap = new Dictionary<EHonamiStoryBackpackType, EHonamiStoryBackpack>
		{
			{
				EHonamiStoryBackpackType.Inventory,
				EHonamiStoryBackpack.Inventory
			},
			{
				EHonamiStoryBackpackType.Backpack,
				EHonamiStoryBackpack.Backpack
			},
			{
				EHonamiStoryBackpackType.PickUpBox,
				EHonamiStoryBackpack.PickUpBox
			},
			{
				EHonamiStoryBackpackType.Player,
				EHonamiStoryBackpack.Player
			}
		};

		// Token: 0x04018E38 RID: 101944
		public readonly Dictionary<EHonamiStoryCollectState, string> collectStateToScoreRewardMap = new Dictionary<EHonamiStoryCollectState, string>
		{
			{
				EHonamiStoryCollectState.Unfinished,
				"SP_HonamiStoryScoreReward_Unfinished"
			},
			{
				EHonamiStoryCollectState.Finished,
				"SP_HonamiStoryScoreReward_Finished"
			},
			{
				EHonamiStoryCollectState.GotReward,
				"SP_HonamiStoryScoreReward_GotReward"
			}
		};

		// Token: 0x04018E39 RID: 101945
		public readonly Dictionary<EHonamiStoryCollectState, string> honamiCollectStateMap = new Dictionary<EHonamiStoryCollectState, string>
		{
			{
				EHonamiStoryCollectState.Unfinished,
				"HonamiStory_Collect_Unfinished"
			},
			{
				EHonamiStoryCollectState.Finished,
				"HonamiStory_Collect_Finished"
			},
			{
				EHonamiStoryCollectState.GotReward,
				"HonamiStory_Collect_GotReward"
			}
		};

		// Token: 0x04018E3A RID: 101946
		public readonly Dictionary<EHonamiStoryWeaponType, string> honamiWeaponTypeMap = new Dictionary<EHonamiStoryWeaponType, string>
		{
			{
				EHonamiStoryWeaponType.Attack,
				"HonamiStory_Weapon_Type_1"
			},
			{
				EHonamiStoryWeaponType.Explore,
				"HonamiStory_Weapon_Type_2"
			},
			{
				EHonamiStoryWeaponType.Support,
				"HonamiStory_Weapon_Type_3"
			}
		};

		// Token: 0x04018E3B RID: 101947
		public const int HONAMI_HELP_MAIN = 431;

		// Token: 0x04018E3C RID: 101948
		public const int HONAMI_HELP_BACKPACK = 434;

		// Token: 0x04018E3D RID: 101949
		public const int HONAMI_HELP_WEAPONSELECT = 436;

		// Token: 0x04018E3E RID: 101950
		public const int HONAMI_HELP_READYGO = 437;

		// Token: 0x04018E3F RID: 101951
		public const int HONAMI_HELP_TALENT = 439;

		// Token: 0x04018E40 RID: 101952
		public const int HONAMI_HELP_WANTED = 440;

		// Token: 0x04018E41 RID: 101953
		public const int HONAMI_HELP_SHOP = 441;

		// Token: 0x04018E42 RID: 101954
		public const int HONAMI_HELP_COLLECT = 442;

		// Token: 0x04018E43 RID: 101955
		[Nullable(2)]
		private static HonamiStoryDefine _instance;
	}
}
