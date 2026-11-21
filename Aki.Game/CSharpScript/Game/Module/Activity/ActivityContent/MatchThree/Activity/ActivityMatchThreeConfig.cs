using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054BE RID: 21694
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityMatchThreeConfig : ConfigBase
	{
		// Token: 0x06035C07 RID: 220167 RVA: 0x00F04104 File Offset: 0x00F02304
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

		// Token: 0x06035C08 RID: 220168 RVA: 0x00F04160 File Offset: 0x00F02360
		public MatchThreeGoal? GetGoalConfig(int goalId)
		{
			if (goalId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeGoalById.GetConfig(goalId, true);
		}

		// Token: 0x06035C09 RID: 220169 RVA: 0x00F04184 File Offset: 0x00F02384
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

		// Token: 0x06035C0A RID: 220170 RVA: 0x00F04204 File Offset: 0x00F02404
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

		// Token: 0x06035C0B RID: 220171 RVA: 0x00F0424B File Offset: 0x00F0244B
		public string ResolveLevelTitle(MatchThreeLevel levelConfig)
		{
			if (!string.IsNullOrEmpty(levelConfig.Title))
			{
				return ActivityMatchThreeConfig.ResolveDisplayText(levelConfig.Title);
			}
			return string.Empty;
		}

		// Token: 0x06035C0C RID: 220172 RVA: 0x00F04270 File Offset: 0x00F02470
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

		// Token: 0x06035C0D RID: 220173 RVA: 0x00F042AC File Offset: 0x00F024AC
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

		// Token: 0x06035C0E RID: 220174 RVA: 0x00F042E8 File Offset: 0x00F024E8
		public bool HasLevelEnvironments(int levelId)
		{
			MatchThreeGameplay? gameplayConfig = this.GetGameplayConfig(levelId);
			return gameplayConfig != null && gameplayConfig.Value.EnviromentsLength > 0;
		}

		// Token: 0x06035C0F RID: 220175 RVA: 0x00F0431C File Offset: 0x00F0251C
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

		// Token: 0x06035C10 RID: 220176 RVA: 0x00F04368 File Offset: 0x00F02568
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

		// Token: 0x06035C11 RID: 220177 RVA: 0x00F043C4 File Offset: 0x00F025C4
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

		// Token: 0x06035C12 RID: 220178 RVA: 0x00F04420 File Offset: 0x00F02620
		public IReadOnlyList<MatchThreeRole> GetAllRoleConfigs()
		{
			IReadOnlyList<MatchThreeRole> configList = ConfigMatchThreeRoleAll.GetConfigList(true);
			if (configList == null || configList.Count == 0)
			{
				return Array.Empty<MatchThreeRole>();
			}
			List<MatchThreeRole> list = new List<MatchThreeRole>(configList);
			list.Sort((MatchThreeRole a, MatchThreeRole b) => a.Id.CompareTo(b.Id));
			return list;
		}

		// Token: 0x06035C13 RID: 220179 RVA: 0x00F04470 File Offset: 0x00F02670
		public MatchThreeGameplay? GetGameplayConfig(int gameplayId)
		{
			if (gameplayId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeGameplayById.GetConfig(gameplayId, true);
		}

		// Token: 0x06035C14 RID: 220180 RVA: 0x00F04494 File Offset: 0x00F02694
		public MatchThreeEnviroment? GetEnviromentConfig(int enviromentId)
		{
			if (enviromentId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeEnviromentById.GetConfig(enviromentId, true);
		}

		// Token: 0x06035C15 RID: 220181 RVA: 0x00F044B8 File Offset: 0x00F026B8
		public MatchThreeTileDefine? GetTileDefineConfig(int tileId)
		{
			if (tileId <= 0)
			{
				return null;
			}
			return ConfigMatchThreeTileDefineById.GetConfig(tileId, true);
		}

		// Token: 0x06035C16 RID: 220182 RVA: 0x00F044DC File Offset: 0x00F026DC
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

		// Token: 0x06035C17 RID: 220183 RVA: 0x00F04588 File Offset: 0x00F02788
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
			List<MatchThreeInfoItemData> list = new List<MatchThreeInfoItemData>(param.TileList);
			list.Sort(delegate(MatchThreeInfoItemData a, MatchThreeInfoItemData b)
			{
				int num3 = a.SortId.CompareTo(b.SortId);
				if (num3 == 0)
				{
					return a.Id.CompareTo(b.Id);
				}
				return num3;
			});
			param.TileList = list;
		}

		// Token: 0x06035C18 RID: 220184 RVA: 0x00F0468C File Offset: 0x00F0288C
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

		// Token: 0x06035C19 RID: 220185 RVA: 0x00F0477C File Offset: 0x00F0297C
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
			List<MatchThreeInfoItemData> list = new List<MatchThreeInfoItemData>(param.EnvList);
			list.Sort(delegate(MatchThreeInfoItemData a, MatchThreeInfoItemData b)
			{
				int num = a.SortId.CompareTo(b.SortId);
				if (num == 0)
				{
					return a.Id.CompareTo(b.Id);
				}
				return num;
			});
			param.EnvList = list;
		}

		// Token: 0x06035C1A RID: 220186 RVA: 0x00F048AA File Offset: 0x00F02AAA
		private static string ResolveDisplayText([Nullable(2)] string textOrId)
		{
			if (string.IsNullOrEmpty(textOrId))
			{
				return string.Empty;
			}
			return ConfigMultiTextLang.GetLocalTextNew(textOrId, null) ?? textOrId;
		}

		// Token: 0x06035C1B RID: 220187 RVA: 0x00F048C8 File Offset: 0x00F02AC8
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
			list.Sort(delegate(MatchThreeLevel a, MatchThreeLevel b)
			{
				int num = a.Difficulty.CompareTo(b.Difficulty);
				if (num == 0)
				{
					return a.Id.CompareTo(b.Id);
				}
				return num;
			});
			return list;
		}

		// Token: 0x06035C1C RID: 220188 RVA: 0x00F04960 File Offset: 0x00F02B60
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
			List<KeyValuePair<int, List<MatchThreeLevel>>> list3 = new List<KeyValuePair<int, List<MatchThreeLevel>>>(dictionary);
			list3.Sort(([Nullable(new byte[]
			{
				0,
				1
			})] KeyValuePair<int, List<MatchThreeLevel>> a, [Nullable(new byte[]
			{
				0,
				1
			})] KeyValuePair<int, List<MatchThreeLevel>> b) => a.Key.CompareTo(b.Key));
			foreach (KeyValuePair<int, List<MatchThreeLevel>> keyValuePair in list3)
			{
				List<MatchThreeLevel> list4 = new List<MatchThreeLevel>(keyValuePair.Value);
				list4.Sort(delegate(MatchThreeLevel a, MatchThreeLevel b)
				{
					int num = a.Difficulty.CompareTo(b.Difficulty);
					if (num == 0)
					{
						return a.Id.CompareTo(b.Id);
					}
					return num;
				});
				bool isEndless = false;
				for (int i = 0; i < list4.Count; i++)
				{
					if (list4[i].EndLess)
					{
						isEndless = true;
						break;
					}
				}
				List<int> list5 = new List<int>(list4.Count);
				for (int j = 0; j < list4.Count; j++)
				{
					list5.Add(list4[j].Id);
				}
				list2.Add(new MatchThreeChapterSelectData
				{
					Chapter = keyValuePair.Key,
					IsEndless = isEndless,
					LevelIds = list5
				});
			}
			return list2;
		}

		// Token: 0x17006897 RID: 26775
		// (get) Token: 0x06035C1D RID: 220189 RVA: 0x00F04B50 File Offset: 0x00F02D50
		public static ActivityMatchThreeConfig Instance
		{
			get
			{
				return ActivityMatchThreeConfig._Instance;
			}
		}

		// Token: 0x06035C1E RID: 220190 RVA: 0x00F04B57 File Offset: 0x00F02D57
		public static ActivityMatchThreeConfig GetOrCreateInstance()
		{
			if (ActivityMatchThreeConfig._Instance == null)
			{
				ActivityMatchThreeConfig.CreateInstance();
			}
			return ActivityMatchThreeConfig._Instance;
		}

		// Token: 0x06035C1F RID: 220191 RVA: 0x00F04B6B File Offset: 0x00F02D6B
		public static bool CreateInstance()
		{
			if (ActivityMatchThreeConfig._Instance != null)
			{
				return true;
			}
			ActivityMatchThreeConfig._Instance = new ActivityMatchThreeConfig();
			return true;
		}

		// Token: 0x06035C20 RID: 220192 RVA: 0x00F04B81 File Offset: 0x00F02D81
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035C21 RID: 220193 RVA: 0x00F04B83 File Offset: 0x00F02D83
		public static void ResetStaticDefaultValue()
		{
			ActivityMatchThreeConfig._Instance = null;
		}

		// Token: 0x06035C22 RID: 220194 RVA: 0x00F04B8B File Offset: 0x00F02D8B
		static ActivityMatchThreeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMatchThreeConfig.CreateStaticDefaultValue), new Action(ActivityMatchThreeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C73D RID: 116541
		[Nullable(2)]
		private static ActivityMatchThreeConfig _Instance;
	}
}
