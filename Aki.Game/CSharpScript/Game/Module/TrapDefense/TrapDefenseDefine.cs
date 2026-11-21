using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A27 RID: 14887
	[NullableContext(1)]
	[Nullable(0)]
	public static class TrapDefenseDefine
	{
		// Token: 0x06026437 RID: 156727 RVA: 0x00AB6CDA File Offset: 0x00AB4EDA
		public static int LineIndex2NodeIndex(int lineIndex)
		{
			if (lineIndex >= 18)
			{
				return lineIndex - 18;
			}
			if (lineIndex >= 12)
			{
				return lineIndex - 12;
			}
			if (lineIndex >= 6)
			{
				return lineIndex - 6;
			}
			return lineIndex;
		}

		// Token: 0x04015020 RID: 86048
		public const int PLAYER_MARK_ID = 0;

		// Token: 0x04015021 RID: 86049
		public const int CAMP_MARK_ID = 1;

		// Token: 0x04015022 RID: 86050
		public const int PHANTOM_POINT_MARK_ID = 10000;

		// Token: 0x04015023 RID: 86051
		public const int PHANTOM_MARK_ID = 20000;

		// Token: 0x04015024 RID: 86052
		public const int BIG_MAP_CENTER_OFFSET_MULTIPLIER = 2;

		// Token: 0x04015025 RID: 86053
		public const string MARK_PREFAB_PATH = "/Game/Aki/UI/UIResources/UiFight/Prefabs/Activity/TowerDefense/DynMapIcon.DynMapIcon";

		// Token: 0x04015026 RID: 86054
		public const string ROUTE_POINT_PATH = "/Game/Aki/UI/UIResources/UiFight/Prefabs/Activity/TowerDefense/DynMapPointIcon.DynMapPointIcon";

		// Token: 0x04015027 RID: 86055
		public const float MINI_MAP_MARK_SCALE = 0.5f;

		// Token: 0x04015028 RID: 86056
		public const string CAMP_ICON_PATH = "/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon3.SP_IconTowerDefenseMapIcon3";

		// Token: 0x04015029 RID: 86057
		public const string PHANTOM_POINT_ICON_PATH = "/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon1.SP_IconTowerDefenseMapIcon1";

		// Token: 0x0401502A RID: 86058
		public const string PHANTOM_POINT_ACTIVATED_ICON_PATH = "/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon2.SP_IconTowerDefenseMapIcon2";

		// Token: 0x0401502B RID: 86059
		public const string ROUTE_POINT_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/Com/T_ComPointWhite.T_ComPointWhite";

		// Token: 0x0401502C RID: 86060
		public const int TRAP_DEFENSE_BATTLE_ITEM_TYPE_LIMIT = 8;

		// Token: 0x0401502D RID: 86061
		public static readonly global::Vector worldToTrapDefenseUiUnit = global::Vector.Create(1.0, -1.0, 1.0);

		// Token: 0x0401502E RID: 86062
		public static readonly Dictionary<ETrapDefenseDifficultyLevel, ITrapDefenseDifficultyLevelInfo> trapDefenseDifficultyLevelRecord = new Dictionary<ETrapDefenseDifficultyLevel, ITrapDefenseDifficultyLevelInfo>
		{
			{
				ETrapDefenseDifficultyLevel.None,
				new TrapDefenseDifficultyLevelInfo
				{
					DifficultyLevel = ETrapDefenseDifficultyLevel.None,
					NameKey = ETrapDefenseTextKey.LevelDifficultyNormal.ToString(),
					BgKey = "T_TitleBgFrameGray",
					NameBgKey = "SP_MapDifficultyNormal",
					BgLightKey = "T_TitleBgLightGray",
					BgTitleKey = "SP_LevelTitleBgFrameGray",
					BgFlowerColor = "#FFFFFF1E",
					ArtTextShadowColor = "#FFFFFF4C"
				}
			},
			{
				ETrapDefenseDifficultyLevel.Normal,
				new TrapDefenseDifficultyLevelInfo
				{
					DifficultyLevel = ETrapDefenseDifficultyLevel.Normal,
					NameKey = ETrapDefenseTextKey.LevelDifficultyNormal.ToString(),
					BgKey = "T_TitleBgFrameBlue",
					NameBgKey = "SP_MapDifficultyNormal",
					BgLightKey = "T_TitleBgLightBlue",
					BgTitleKey = "SP_LevelTitleBgFrameBlue",
					BgFlowerColor = "#28F2FF1E",
					ArtTextShadowColor = "#00FFFF7F"
				}
			},
			{
				ETrapDefenseDifficultyLevel.Nightmare,
				new TrapDefenseDifficultyLevelInfo
				{
					DifficultyLevel = ETrapDefenseDifficultyLevel.Nightmare,
					NameKey = ETrapDefenseTextKey.LevelDifficultyNightmare.ToString(),
					BgKey = "T_TitleBgFrameYellow",
					NameBgKey = "SP_MapDifficultyNightmare",
					BgLightKey = "T_TitleBgLightYellow",
					BgTitleKey = "SP_LevelTitleBgFrameYellow",
					BgFlowerColor = "#FBC2021E",
					ArtTextShadowColor = "#FFEA487F"
				}
			},
			{
				ETrapDefenseDifficultyLevel.Hell,
				new TrapDefenseDifficultyLevelInfo
				{
					DifficultyLevel = ETrapDefenseDifficultyLevel.Hell,
					NameKey = ETrapDefenseTextKey.LevelDifficultyHell.ToString(),
					BgKey = "T_TitleBgFrameRed",
					NameBgKey = "SP_MapDifficultyHell",
					BgLightKey = "T_TitleBgLightRed",
					BgTitleKey = "SP_LevelTitleBgFrameRed",
					BgFlowerColor = "#FE39392E",
					ArtTextShadowColor = "#FF82837F"
				}
			}
		};

		// Token: 0x0401502F RID: 86063
		public static readonly Dictionary<ETrapDefenseLevelTarget, ITrapDefenseLevelTargetInfo> trapDefenseLevelTargetRecord = new Dictionary<ETrapDefenseLevelTarget, ITrapDefenseLevelTargetInfo>
		{
			{
				ETrapDefenseLevelTarget.Hp,
				new TrapDefenseLevelTargetInfo
				{
					TargetType = ETrapDefenseLevelTarget.Hp,
					NameKey = ETrapDefenseTextKey.LevelTargetHp.ToString(),
					IconKey = ETrapDefenseResKey.LevelTargetHp.ToString()
				}
			},
			{
				ETrapDefenseLevelTarget.Wave,
				new TrapDefenseLevelTargetInfo
				{
					TargetType = ETrapDefenseLevelTarget.Wave,
					NameKey = ETrapDefenseTextKey.LevelTargetWave.ToString(),
					IconKey = ETrapDefenseResKey.LevelTargetWave.ToString()
				}
			}
		};

		// Token: 0x04015030 RID: 86064
		public static readonly Dictionary<ConditionTaskState, ETrapDefenseRewardState> trapDefenseRewardServerState2ClientState = new Dictionary<ConditionTaskState, ETrapDefenseRewardState>
		{
			{
				ConditionTaskState.ConditionTaskRunning,
				ETrapDefenseRewardState.InProgress
			},
			{
				ConditionTaskState.ConditionTaskFinish,
				ETrapDefenseRewardState.CanClaim
			},
			{
				ConditionTaskState.ConditionTaskTaken,
				ETrapDefenseRewardState.Claimed
			}
		};

		// Token: 0x04015031 RID: 86065
		public static readonly Dictionary<ETrapDefenseRewardType, string> rewardTypeNames = new Dictionary<ETrapDefenseRewardType, string>
		{
			{
				ETrapDefenseRewardType.Default,
				""
			},
			{
				ETrapDefenseRewardType.Main,
				"TrapDefense_RewardType_Main"
			},
			{
				ETrapDefenseRewardType.Level,
				"TrapDefense_RewardType_Level"
			},
			{
				ETrapDefenseRewardType.Endless,
				"TrapDefense_RewardType_Endless"
			},
			{
				ETrapDefenseRewardType.Other,
				"TrapDefense_RewardType_Other"
			},
			{
				ETrapDefenseRewardType.Length,
				""
			}
		};

		// Token: 0x04015032 RID: 86066
		public static readonly Dictionary<ETrapDefenseTalentTreeType, string> trapDefenseTalentTreeTypeNames = new Dictionary<ETrapDefenseTalentTreeType, string>
		{
			{
				ETrapDefenseTalentTreeType.Economy,
				"TrapDefense_TalentTree_Economy"
			},
			{
				ETrapDefenseTalentTreeType.Build,
				"TrapDefense_TalentTree_Build"
			},
			{
				ETrapDefenseTalentTreeType.Ability,
				"TrapDefense_TalentTree_Ability"
			},
			{
				ETrapDefenseTalentTreeType.Length,
				""
			}
		};

		// Token: 0x04015033 RID: 86067
		public static readonly Dictionary<ETrapDefenseShopGoodsType, string> trapDefenseGoodsTypeNames = new Dictionary<ETrapDefenseShopGoodsType, string>
		{
			{
				ETrapDefenseShopGoodsType.Item,
				"TrapDefense_Shop_GoodsType_Item"
			},
			{
				ETrapDefenseShopGoodsType.Buff,
				"TrapDefense_Shop_GoodsType_Buff"
			}
		};

		// Token: 0x04015034 RID: 86068
		public static readonly Dictionary<ETrapDefenseEnemyType, string> enemyResourceBattleRecord = new Dictionary<ETrapDefenseEnemyType, string>
		{
			{
				ETrapDefenseEnemyType.None,
				""
			},
			{
				ETrapDefenseEnemyType.Phantom,
				"/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIconS3.SP_IconTowerDefenseMapIconS3"
			},
			{
				ETrapDefenseEnemyType.ElitePhantom,
				"/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIconM2.SP_IconTowerDefenseMapIconM2"
			},
			{
				ETrapDefenseEnemyType.Money,
				"/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIconS2.SP_IconTowerDefenseMapIconS2"
			}
		};

		// Token: 0x04015035 RID: 86069
		public static readonly Dictionary<ETrapDefenseEnemyType, string> enemyResourcePreviewRecord = new Dictionary<ETrapDefenseEnemyType, string>
		{
			{
				ETrapDefenseEnemyType.None,
				""
			},
			{
				ETrapDefenseEnemyType.Phantom,
				"/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIconS1.SP_IconTowerDefenseMapIconS1"
			},
			{
				ETrapDefenseEnemyType.ElitePhantom,
				"/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIconM1.SP_IconTowerDefenseMapIconM1"
			},
			{
				ETrapDefenseEnemyType.Money,
				"/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIconS2.SP_IconTowerDefenseMapIconS2"
			}
		};

		// Token: 0x04015036 RID: 86070
		public static readonly Dictionary<TrapDefenseDefine.ETrapDefenseMarkType, ETrapDefenseMapComponent[]> markAssembleRegisterMap = new Dictionary<TrapDefenseDefine.ETrapDefenseMarkType, ETrapDefenseMapComponent[]>
		{
			{
				TrapDefenseDefine.ETrapDefenseMarkType.Player,
				Array.Empty<ETrapDefenseMapComponent>()
			},
			{
				TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint,
				Array.Empty<ETrapDefenseMapComponent>()
			},
			{
				TrapDefenseDefine.ETrapDefenseMarkType.Phantom,
				Array.Empty<ETrapDefenseMapComponent>()
			},
			{
				TrapDefenseDefine.ETrapDefenseMarkType.Camp,
				Array.Empty<ETrapDefenseMapComponent>()
			}
		};

		// Token: 0x04015037 RID: 86071
		public static readonly Dictionary<ETrapDefenseMapComponent, Func<TrapMapEntity, TrapMapComponentBase>> towerMapComponentConstructors = new Dictionary<ETrapDefenseMapComponent, Func<TrapMapEntity, TrapMapComponentBase>>
		{
			{
				ETrapDefenseMapComponent.EntityPosSyncComponent,
				(TrapMapEntity parent) => new EntityPosSyncComponent(parent)
			},
			{
				ETrapDefenseMapComponent.MarkTransformComponent,
				(TrapMapEntity parent) => new MarkTransformComponent(parent)
			}
		};

		// Token: 0x020095EF RID: 38383
		[NullableContext(0)]
		public enum ETrapDefenseMarkType
		{
			// Token: 0x0402ED2B RID: 191787
			Player = 1,
			// Token: 0x0402ED2C RID: 191788
			PhantomPoint,
			// Token: 0x0402ED2D RID: 191789
			Phantom,
			// Token: 0x0402ED2E RID: 191790
			Camp
		}
	}
}
