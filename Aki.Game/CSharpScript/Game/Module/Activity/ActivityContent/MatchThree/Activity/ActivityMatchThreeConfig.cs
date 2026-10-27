using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x02006540 RID: 25920
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityMatchThreeConfig : ConfigBase
	{
		// Token: 0x06040F42 RID: 266050 RVA: 0x00FBD0C0 File Offset: 0x00FBB2C0
		public MatchThreeLevel? GetLevelConfig(int levelId)
		{
			if (levelId <= 0)
			{
				return null;
			}
			MatchThreeLevel? config = ConfigMatchThreeLevelById.GetConfig(levelId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "三消找不到对应关卡配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("levelId", levelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06040F43 RID: 266051 RVA: 0x00FBD11C File Offset: 0x00FBB31C
		public MatchThreeGoal? GetGoalConfig(int goalId)
		{
			if (goalId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeGoalById.GetConfig(goalId, true);
		}

		// Token: 0x06040F44 RID: 266052 RVA: 0x00FBD140 File Offset: 0x00FBB340
		public string BuildLevelDetailTitle(MatchThreeLevel levelConfig)
		{
			string text = this.ResolveLevelTitle(levelConfig);
			if (levelConfig.EndLess)
			{
				return text;
			}
			string text2 = ConfigMultiTextLang.GetLocalTextNew((levelConfig.Difficulty == 0) ? "Tetristext_06" : "Tetristext_07", null) ?? string.Empty;
			if (string.IsNullOrEmpty(text2))
			{
				return text;
			}
			if (string.IsNullOrEmpty(text))
			{
				return text2;
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("MatchThree_LevelDetailTitle", null) ?? string.Empty, new string[]
			{
				text,
				text2
			});
		}

		// Token: 0x06040F45 RID: 266053 RVA: 0x00FBD1C0 File Offset: 0x00FBB3C0
		public int GetReportDifficulty(int levelId)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(levelId);
			if (levelConfig == null)
			{
				return 1;
			}
			if (levelConfig.Value.EndLess)
			{
				return 3;
			}
			if (levelConfig.Value.Difficulty != 0)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x06040F46 RID: 266054 RVA: 0x00FBD207 File Offset: 0x00FBB407
		public string ResolveLevelTitle(MatchThreeLevel levelConfig)
		{
			if (!string.IsNullOrEmpty(levelConfig.Title))
			{
				return ActivityMatchThreeConfig.ResolveDisplayText(levelConfig.Title);
			}
			return string.Empty;
		}

		// Token: 0x06040F47 RID: 266055 RVA: 0x00FBD22C File Offset: 0x00FBB42C
		[NullableContext(2)]
		public string GetLevelTitleTextId(int levelId)
		{
			MatchThreeLevel? matchThreeLevel;
			string text = (this.GetLevelConfig(levelId) != null) ? matchThreeLevel.GetValueOrDefault().Title : null;
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06040F48 RID: 266056 RVA: 0x00FBD268 File Offset: 0x00FBB468
		[NullableContext(2)]
		public string GetLevelEnvironmentDescTextId(int levelId)
		{
			MatchThreeGameplay? matchThreeGameplay;
			string text = (this.GetGameplayConfig(levelId) != null) ? matchThreeGameplay.GetValueOrDefault().EnvironmentDesc : null;
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06040F49 RID: 266057 RVA: 0x00FBD2A4 File Offset: 0x00FBB4A4
		public bool HasLevelEnvironments(int levelId)
		{
			MatchThreeGameplay? gameplayConfig = this.GetGameplayConfig(levelId);
			return gameplayConfig != null && gameplayConfig.Value.EnviromentsLength > 0;
		}

		// Token: 0x06040F4A RID: 266058 RVA: 0x00FBD2D8 File Offset: 0x00FBB4D8
		public string GetGoalPieceDisplayName(MatchThreeGoal goal)
		{
			EGoalCondType condType = (EGoalCondType)goal.CondType;
			string text;
			if (condType != EGoalCondType.ClearCharger)
			{
				if (condType != EGoalCondType.ClearHourglass)
				{
					text = null;
				}
				else
				{
					text = "PieceName_2004";
				}
			}
			else
			{
				text = "PieceName_2003";
			}
			string text2 = text;
			if (text2 == null)
			{
				return string.Empty;
			}
			return ConfigMultiTextLang.GetLocalTextNew(text2, null) ?? string.Empty;
		}

		// Token: 0x06040F4B RID: 266059 RVA: 0x00FBD324 File Offset: 0x00FBB524
		public MatchThreeRole? GetRoleConfig(int roleId)
		{
			if (roleId <= 0)
			{
				return null;
			}
			MatchThreeRole? config = ConfigMatchThreeRoleById.GetConfig(roleId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "三消找不到对应角色配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06040F4C RID: 266060 RVA: 0x00FBD380 File Offset: 0x00FBB580
		public MatchThreeSkill? GetSkillConfig(int skillId)
		{
			if (skillId <= 0)
			{
				return null;
			}
			MatchThreeSkill? config = ConfigMatchThreeSkillById.GetConfig(skillId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "三消找不到对应技能配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x06040F4D RID: 266061 RVA: 0x00FBD3DC File Offset: 0x00FBB5DC
		public IReadOnlyList<MatchThreeRole> GetAllRoleConfigs()
		{
			IReadOnlyList<MatchThreeRole> configList = ConfigMatchThreeRoleAll.GetConfigList(true);
			if (configList == null || configList.Count == 0)
			{
				return Array.Empty<MatchThreeRole>();
			}
			return (from role in configList
			orderby role.Id
			select role).ToList<MatchThreeRole>();
		}

		// Token: 0x06040F4E RID: 266062 RVA: 0x00FBD42C File Offset: 0x00FBB62C
		public MatchThreeGameplay? GetGameplayConfig(int gameplayId)
		{
			if (gameplayId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeGameplayById.GetConfig(gameplayId, true);
		}

		// Token: 0x06040F4F RID: 266063 RVA: 0x00FBD450 File Offset: 0x00FBB650
		public MatchThreeEnviroment? GetEnviromentConfig(int enviromentId)
		{
			if (enviromentId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeEnviromentById.GetConfig(enviromentId, true);
		}

		// Token: 0x06040F50 RID: 266064 RVA: 0x00FBD474 File Offset: 0x00FBB674
		public MatchThreeTileDefine? GetTileDefineConfig(int tileId)
		{
			if (tileId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeTileDefineById.GetConfig(tileId, true);
		}

		// Token: 0x06040F51 RID: 266065 RVA: 0x00FBD498 File Offset: 0x00FBB698
		public MatchThreePopupInfoViewParams BuildPopupInfoParams(int levelId, int roleId = 0, bool includeTiles = true, int focusTileId = 0, int focusEnvId = 0)
		{
			MatchThreePopupInfoViewParams matchThreePopupInfoViewParams = new MatchThreePopupInfoViewParams();
			MatchThreeGameplay? gameplayConfig = this.GetGameplayConfig(levelId);
			if (gameplayConfig == null)
			{
				return matchThreePopupInfoViewParams;
			}
			if (includeTiles)
			{
				this.FillPopupTileList(matchThreePopupInfoViewParams, gameplayConfig.Value, roleId);
			}
			this.FillPopupEnvList(matchThreePopupInfoViewParams, gameplayConfig.Value);
			if (focusTileId > 0)
			{
				matchThreePopupInfoViewParams.FocusTileIndex = matchThreePopupInfoViewParams.TileList.FindIndex((MatchThreeInfoItemData item) => item.Id == focusTileId);
			}
			if (focusEnvId > 0)
			{
				matchThreePopupInfoViewParams.FocusEnvIndex = matchThreePopupInfoViewParams.EnvList.FindIndex((MatchThreeInfoItemData item) => item.Id == focusEnvId);
			}
			return matchThreePopupInfoViewParams;
		}

		// Token: 0x06040F52 RID: 266066 RVA: 0x00FBD544 File Offset: 0x00FBB744
		private void FillPopupTileList(MatchThreePopupInfoViewParams param, MatchThreeGameplay gameplay, int roleId)
		{
			HashSet<int> hashSet = new HashSet<int>();
			int num = 0;
			foreach (MatchThreeRole matchThreeRole in this.GetAllRoleConfigs())
			{
				if (matchThreeRole.SpecialTile > 0)
				{
					hashSet.Add(matchThreeRole.SpecialTile);
					if (matchThreeRole.Id == roleId)
					{
						num = matchThreeRole.SpecialTile;
					}
				}
			}
			HashSet<int> added = new HashSet<int>();
			for (int i = 0; i < gameplay.SpecialTilesLength; i++)
			{
				int num2 = gameplay.SpecialTiles(i);
				if (!hashSet.Contains(num2) || num2 == num)
				{
					this.TryAddPopupTile(param, num2, added);
				}
			}
			if (num > 0)
			{
				this.TryAddPopupTile(param, num, added);
			}
			param.TileList = (from item in param.TileList
			orderby item.SortId, item.Id
			select item).ToList<MatchThreeInfoItemData>();
		}

		// Token: 0x06040F53 RID: 266067 RVA: 0x00FBD664 File Offset: 0x00FBB864
		private void TryAddPopupTile(MatchThreePopupInfoViewParams param, int tileId, HashSet<int> added)
		{
			if (tileId <= 0 || !added.Add(tileId))
			{
				return;
			}
			MatchThreeTileDefine? tileDefineConfig = this.GetTileDefineConfig(tileId);
			if (tileDefineConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "三消特殊棋子定义缺失: MatchThreeTileDefine";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tileId", tileId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			param.TileList.Add(new MatchThreeInfoItemData
			{
				Id = tileDefineConfig.Value.Id,
				SortId = tileDefineConfig.Value.SortId,
				Name = (tileDefineConfig.Value.Name ?? string.Empty),
				Desc = (tileDefineConfig.Value.Description ?? string.Empty),
				IconPath = (tileDefineConfig.Value.TileIconPath ?? string.Empty)
			});
		}

		// Token: 0x06040F54 RID: 266068 RVA: 0x00FBD754 File Offset: 0x00FBB954
		private void FillPopupEnvList(MatchThreePopupInfoViewParams param, MatchThreeGameplay gameplay)
		{
			for (int i = 0; i < gameplay.EnviromentsLength; i++)
			{
				DicIntInt? dicIntInt = gameplay.Enviroments(i);
				if (dicIntInt != null)
				{
					MatchThreeEnviroment? enviromentConfig = this.GetEnviromentConfig(dicIntInt.Value.Value);
					if (enviromentConfig != null)
					{
						param.EnvList.Add(new MatchThreeInfoItemData
						{
							Id = enviromentConfig.Value.Id,
							SortId = enviromentConfig.Value.SortId,
							Name = (enviromentConfig.Value.Name ?? string.Empty),
							Desc = (enviromentConfig.Value.Description ?? string.Empty),
							AddDesc = (enviromentConfig.Value.Comment ?? string.Empty)
						});
					}
				}
			}
			param.EnvList = (from item in param.EnvList
			orderby item.SortId, item.Id
			select item).ToList<MatchThreeInfoItemData>();
		}

		// Token: 0x06040F55 RID: 266069 RVA: 0x00FBD8A2 File Offset: 0x00FBBAA2
		private static string ResolveDisplayText([Nullable(2)] string textOrId)
		{
			if (string.IsNullOrEmpty(textOrId))
			{
				return string.Empty;
			}
			return ConfigMultiTextLang.GetLocalTextNew(textOrId, null) ?? textOrId;
		}

		// Token: 0x06040F56 RID: 266070 RVA: 0x00FBD8C0 File Offset: 0x00FBBAC0
		public IReadOnlyList<MatchThreeLevel> GetChapterLevels(MatchThreeChapterSelectData chapterData)
		{
			List<MatchThreeLevel> list = new List<MatchThreeLevel>();
			foreach (int levelId in chapterData.LevelIds)
			{
				MatchThreeLevel? levelConfig = this.GetLevelConfig(levelId);
				if (levelConfig != null)
				{
					list.Add(levelConfig.Value);
				}
			}
			return (from level in list
			orderby level.Difficulty, level.Id
			select level).ToList<MatchThreeLevel>();
		}

		// Token: 0x06040F57 RID: 266071 RVA: 0x00FBD980 File Offset: 0x00FBBB80
		public IReadOnlyList<MatchThreeChapterSelectData> GetChapterSelectDataList(IReadOnlyList<int> levelIds)
		{
			if (levelIds.Count == 0)
			{
				return Array.Empty<MatchThreeChapterSelectData>();
			}
			Dictionary<int, List<MatchThreeLevel>> dictionary = new Dictionary<int, List<MatchThreeLevel>>();
			foreach (int levelId in levelIds)
			{
				MatchThreeLevel? levelConfig = this.GetLevelConfig(levelId);
				if (levelConfig != null && levelConfig.GetValueOrDefault().Chapter > 0)
				{
					MatchThreeLevel value = levelConfig.Value;
					List<MatchThreeLevel> list;
					if (!dictionary.TryGetValue(value.Chapter, out list))
					{
						list = new List<MatchThreeLevel>();
						dictionary[value.Chapter] = list;
					}
					list.Add(value);
				}
			}
			List<MatchThreeChapterSelectData> list2 = new List<MatchThreeChapterSelectData>();
			foreach (KeyValuePair<int, List<MatchThreeLevel>> keyValuePair in from pair in dictionary
			orderby pair.Key
			select pair)
			{
				List<MatchThreeLevel> source = keyValuePair.Value.OrderBy((MatchThreeLevel level) => level.Difficulty).ThenBy((MatchThreeLevel level) => level.Id).ToList<MatchThreeLevel>();
				List<MatchThreeChapterSelectData> list3 = list2;
				MatchThreeChapterSelectData matchThreeChapterSelectData = new MatchThreeChapterSelectData();
				matchThreeChapterSelectData.Chapter = keyValuePair.Key;
				matchThreeChapterSelectData.IsEndless = source.Any((MatchThreeLevel level) => level.EndLess);
				matchThreeChapterSelectData.LevelIds = source.Select((MatchThreeLevel level) => level.Id).ToList<int>();
				list3.Add(matchThreeChapterSelectData);
			}
			return list2;
		}

		// Token: 0x17009535 RID: 38197
		// (get) Token: 0x06040F58 RID: 266072 RVA: 0x00FBDB68 File Offset: 0x00FBBD68
		public static ActivityMatchThreeConfig Instance
		{
			get
			{
				return ActivityMatchThreeConfig._Instance;
			}
		}

		// Token: 0x06040F59 RID: 266073 RVA: 0x00FBDB6F File Offset: 0x00FBBD6F
		public static ActivityMatchThreeConfig GetOrCreateInstance()
		{
			if (ActivityMatchThreeConfig._Instance == null)
			{
				ActivityMatchThreeConfig.CreateInstance();
			}
			return ActivityMatchThreeConfig._Instance;
		}

		// Token: 0x06040F5A RID: 266074 RVA: 0x00FBDB83 File Offset: 0x00FBBD83
		public static bool CreateInstance()
		{
			if (ActivityMatchThreeConfig._Instance != null)
			{
				return true;
			}
			ActivityMatchThreeConfig._Instance = new ActivityMatchThreeConfig();
			return true;
		}

		// Token: 0x06040F5B RID: 266075 RVA: 0x00FBDB99 File Offset: 0x00FBBD99
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040F5C RID: 266076 RVA: 0x00FBDB9B File Offset: 0x00FBBD9B
		public static void ResetStaticDefaultValue()
		{
			ActivityMatchThreeConfig._Instance = null;
		}

		// Token: 0x06040F5D RID: 266077 RVA: 0x00FBDBA3 File Offset: 0x00FBBDA3
		static ActivityMatchThreeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMatchThreeConfig.CreateStaticDefaultValue), new Action(ActivityMatchThreeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021E0C RID: 138764
		[Nullable(2)]
		private static ActivityMatchThreeConfig _Instance;
	}
}
