using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A7F RID: 19071
	[NullableContext(1)]
	[Nullable(0)]
	public static class TrapDefenseDefine
	{
		// Token: 0x060316A7 RID: 202407 RVA: 0x00B72D56 File Offset: 0x00B70F56
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

		// Token: 0x0401A6CE RID: 108238
		public const int PLAYER_MARK_ID = 0;

		// Token: 0x0401A6CF RID: 108239
		public const int CAMP_MARK_ID = 1;

		// Token: 0x0401A6D0 RID: 108240
		public const int PHANTOM_POINT_MARK_ID = 10000;

		// Token: 0x0401A6D1 RID: 108241
		public const int PHANTOM_MARK_ID = 20000;

		// Token: 0x0401A6D2 RID: 108242
		public const int BIG_MAP_CENTER_OFFSET_MULTIPLIER = 2;

		// Token: 0x0401A6D3 RID: 108243
		public const string MARK_PREFAB_PATH = "/Game/Aki/UI/UIResources/UiFight/Prefabs/Activity/TowerDefense/DynMapIcon.DynMapIcon";

		// Token: 0x0401A6D4 RID: 108244
		public const string ROUTE_POINT_PATH = "/Game/Aki/UI/UIResources/UiFight/Prefabs/Activity/TowerDefense/DynMapPointIcon.DynMapPointIcon";

		// Token: 0x0401A6D5 RID: 108245
		public const float MINI_MAP_MARK_SCALE = 0.5f;

		// Token: 0x0401A6D6 RID: 108246
		public const string CAMP_ICON_PATH = "/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon3.SP_IconTowerDefenseMapIcon3";

		// Token: 0x0401A6D7 RID: 108247
		public const string PHANTOM_POINT_ICON_PATH = "/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon1.SP_IconTowerDefenseMapIcon1";

		// Token: 0x0401A6D8 RID: 108248
		public const string PHANTOM_POINT_ACTIVATED_ICON_PATH = "/Game/Aki/UI/UIResources/UiFight/Atlas/TowerDefense/SP_IconTowerDefenseMapIcon2.SP_IconTowerDefenseMapIcon2";

		// Token: 0x0401A6D9 RID: 108249
		public const string ROUTE_POINT_ICON_PATH = "/Game/Aki/UI/UIResources/Common/Image/Com/T_ComPointWhite.T_ComPointWhite";

		// Token: 0x0401A6DA RID: 108250
		public const int TRAP_DEFENSE_BATTLE_ITEM_TYPE_LIMIT = 8;

		// Token: 0x0401A6DB RID: 108251
		public static readonly global::Vector worldToTrapDefenseUiUnit = global::Vector.Create(1.0, -1.0, 1.0);

		// Token: 0x0401A6DC RID: 108252
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

		// Token: 0x0401A6DD RID: 108253
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

		// Token: 0x0401A6DE RID: 108254
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

		// Token: 0x0401A6DF RID: 108255
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

		// Token: 0x0401A6E0 RID: 108256
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

		// Token: 0x0401A6E1 RID: 108257
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

		// Token: 0x0401A6E2 RID: 108258
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

		// Token: 0x0401A6E3 RID: 108259
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

		// Token: 0x0401A6E4 RID: 108260
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

		// Token: 0x0401A6E5 RID: 108261
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

		// Token: 0x0200ABCF RID: 43983
		[NullableContext(0)]
		public enum ETrapDefenseMarkType
		{
			// Token: 0x0403437A RID: 213882
			Player = 1,
			// Token: 0x0403437B RID: 213883
			PhantomPoint,
			// Token: 0x0403437C RID: 213884
			Phantom,
			// Token: 0x0403437D RID: 213885
			Camp
		}
	}
}
