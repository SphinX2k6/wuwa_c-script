using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005927 RID: 22823
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryDefine : Singleton
	{
		// Token: 0x17008AE3 RID: 35555
		// (get) Token: 0x06039FD0 RID: 237520 RVA: 0x00DCA32D File Offset: 0x00DC852D
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

		// Token: 0x06039FD1 RID: 237521 RVA: 0x00DCA350 File Offset: 0x00DC8550
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039FD2 RID: 237522 RVA: 0x00DCA352 File Offset: 0x00DC8552
		public static void ResetStaticDefaultValue()
		{
			HonamiStoryDefine instance = HonamiStoryDefine._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			HonamiStoryDefine._instance = null;
		}

		// Token: 0x06039FD3 RID: 237523 RVA: 0x00DCA36B File Offset: 0x00DC856B
		static HonamiStoryDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryDefine.CreateStaticDefaultValue), new Action(HonamiStoryDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0401E381 RID: 123777
		public const int HONAMI_GRID_ITEM_WIDTH = 86;

		// Token: 0x0401E382 RID: 123778
		public const int HONAMI_GRID_ITEM_HEIGHT = 86;

		// Token: 0x0401E383 RID: 123779
		public const int HONAMI_GRID_ITEM_WIDTH_MOBILE = 134;

		// Token: 0x0401E384 RID: 123780
		public const int HONAMI_GRID_ITEM_HEIGHT_MOBILE = 134;

		// Token: 0x0401E385 RID: 123781
		public const int HONAMI_GRID_ITEM_HORIZONTAL_INTERVAL = 2;

		// Token: 0x0401E386 RID: 123782
		public const int HONAMI_GRID_ITEM_VERTICAL_INTERVAL = 2;

		// Token: 0x0401E387 RID: 123783
		public const int HONAMI_GRID_ITEM_HORIZONTAL_INTERVAL_MOBILE = 2;

		// Token: 0x0401E388 RID: 123784
		public const int HONAMI_GRID_ITEM_VERTICAL_INTERVAL_MOBILE = 2;

		// Token: 0x0401E389 RID: 123785
		public const int HONAMI_ROLE_TEAM_COUNT = 3;

		// Token: 0x0401E38A RID: 123786
		public const int HONAMI_ROLE_SLOT_OFFSET = 100;

		// Token: 0x0401E38B RID: 123787
		public const int HONAMI_ROLE_SLOT_MAX = 6;

		// Token: 0x0401E38C RID: 123788
		public const int HONAMI_DUNGEON_DEFAULT_AREA_ID = 1;

		// Token: 0x0401E38D RID: 123789
		public const int HONAMI_ROLE_VIRTUAL_SCORE = 100;

		// Token: 0x0401E38E RID: 123790
		public const string HONAMI_EMPTY_GRID_BG = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStoryBackpack/SP_GridEmpty.SP_GridEmpty";

		// Token: 0x0401E38F RID: 123791
		public const string HONAMI_MASCOT_EMPTY_PATH = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity28/HonamiStory/HonamiStoryHead/T_HonamiStoryHeadBEmpty.T_HonamiStoryHeadBEmpty";

		// Token: 0x0401E390 RID: 123792
		public const string HONAMI_MASCOT_EMPTY_BIG_PATH = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity28/HonamiStory/HonamiStoryHead/T_HonamiStoryHeadAEmpty.T_HonamiStoryHeadAEmpty";

		// Token: 0x0401E391 RID: 123793
		public const int HONAMI_DUNGEON_ENTRANCE_ID = 1521;

		// Token: 0x0401E392 RID: 123794
		public const float HONAMI_ENABLE_ALPHA = 1f;

		// Token: 0x0401E393 RID: 123795
		public const float HONAMI_DISABLE_ALPHA = 0.4f;

		// Token: 0x0401E394 RID: 123796
		public const int HONAMI_BAKCPACK_CLICK_CD = 300;

		// Token: 0x0401E395 RID: 123797
		public const int HONAMI_DUNGEON_ID = 8760;

		// Token: 0x0401E396 RID: 123798
		public const int HONAMI_MAIN_QUEST_ID = 880000044;

		// Token: 0x0401E397 RID: 123799
		public const int HONAMI_MAX_SHOW_REVENUE = 99999999;

		// Token: 0x0401E398 RID: 123800
		public const string RICHTXT_QUEST = "<color=#b3dffa>{0}</color>";

		// Token: 0x0401E399 RID: 123801
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

		// Token: 0x0401E39A RID: 123802
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

		// Token: 0x0401E39B RID: 123803
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

		// Token: 0x0401E39C RID: 123804
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

		// Token: 0x0401E39D RID: 123805
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

		// Token: 0x0401E39E RID: 123806
		public const int HONAMI_HELP_MAIN = 431;

		// Token: 0x0401E39F RID: 123807
		public const int HONAMI_HELP_BACKPACK = 434;

		// Token: 0x0401E3A0 RID: 123808
		public const int HONAMI_HELP_WEAPONSELECT = 436;

		// Token: 0x0401E3A1 RID: 123809
		public const int HONAMI_HELP_READYGO = 437;

		// Token: 0x0401E3A2 RID: 123810
		public const int HONAMI_HELP_TALENT = 439;

		// Token: 0x0401E3A3 RID: 123811
		public const int HONAMI_HELP_WANTED = 440;

		// Token: 0x0401E3A4 RID: 123812
		public const int HONAMI_HELP_SHOP = 441;

		// Token: 0x0401E3A5 RID: 123813
		public const int HONAMI_HELP_COLLECT = 442;

		// Token: 0x0401E3A6 RID: 123814
		[Nullable(2)]
		private static HonamiStoryDefine _instance;
	}
}
