using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006035 RID: 24629
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class SpringManorConfig : ConfigBase
	{
		// Token: 0x0603E526 RID: 255270 RVA: 0x00F0D182 File Offset: 0x00F0B382
		public SpringFestival? GetActivityConfigByActivityId(int activityId)
		{
			return ConfigSpringFestivalByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x0603E527 RID: 255271 RVA: 0x00F0D18C File Offset: 0x00F0B38C
		public int GetWorldTeleportId()
		{
			return ConfigCommonParamById.GetIntConfig("Spring26WorldTeleportId").Value;
		}

		// Token: 0x0603E528 RID: 255272 RVA: 0x00F0D1AB File Offset: 0x00F0B3AB
		public SpringFestivalMainTask? GetMainTaskConfigById(int id)
		{
			return ConfigSpringFestivalMainTaskById.GetConfig(id, true);
		}

		// Token: 0x0603E529 RID: 255273 RVA: 0x00F0D1B4 File Offset: 0x00F0B3B4
		public SpringFestivalMainTask? GetMainTaskConfigByQuestId(int questId)
		{
			return ConfigSpringFestivalMainTaskByQuestId.GetConfig(questId, true);
		}

		// Token: 0x0603E52A RID: 255274 RVA: 0x00F0D1BD File Offset: 0x00F0B3BD
		public IReadOnlyList<SpringFestivalMainTask> GetAllMainTaskConfig()
		{
			return ConfigSpringFestivalMainTaskAll.GetConfigList(true);
		}

		// Token: 0x0603E52B RID: 255275 RVA: 0x00F0D1C5 File Offset: 0x00F0B3C5
		public SpringFestivalSubTask? GetSubTaskConfigByQuestId(int questId)
		{
			return ConfigSpringFestivalSubTaskByQuestId.GetConfig(questId, true);
		}

		// Token: 0x0603E52C RID: 255276 RVA: 0x00F0D1CE File Offset: 0x00F0B3CE
		public IReadOnlyList<SpringFestivalSubTask> GetAllSubTaskConfig()
		{
			return ConfigSpringFestivalSubTaskAll.GetConfigList(true);
		}

		// Token: 0x0603E52D RID: 255277 RVA: 0x00F0D1D6 File Offset: 0x00F0B3D6
		public AtmosphereLevel? GetLevelConfigById(int id)
		{
			return ConfigAtmosphereLevelById.GetConfig(id, true);
		}

		// Token: 0x0603E52E RID: 255278 RVA: 0x00F0D1E0 File Offset: 0x00F0B3E0
		[NullableContext(1)]
		public IReadOnlyList<AtmosphereLevel> GetLevelConfigByActivityId(int activityId)
		{
			List<AtmosphereLevel> list = new List<AtmosphereLevel>();
			IReadOnlyList<AtmosphereLevel> configList = ConfigAtmosphereLevelAll.GetConfigList(true);
			if (configList != null)
			{
				foreach (AtmosphereLevel item in configList)
				{
					if (item.ActivityId == activityId)
					{
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x0603E52F RID: 255279 RVA: 0x00F0D244 File Offset: 0x00F0B444
		public SpringFestivalSkipEntry? GetSkipEntryConfigById(int id)
		{
			return ConfigSpringFestivalSkipEntryById.GetConfig(id, true);
		}

		// Token: 0x0603E530 RID: 255280 RVA: 0x00F0D24D File Offset: 0x00F0B44D
		public SpringFestivalReward? GetRewardTaskConfigById(int configId)
		{
			return ConfigSpringFestivalRewardById.GetConfig(configId, true);
		}

		// Token: 0x0603E531 RID: 255281 RVA: 0x00F0D256 File Offset: 0x00F0B456
		public IReadOnlyList<SpringFestivalReward> GetRewardTaskConfigByActivityId(int activityId)
		{
			return ConfigSpringFestivalRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0603E532 RID: 255282 RVA: 0x00F0D25F File Offset: 0x00F0B45F
		public SpringFestivalRewardTab? GetRewardTabConfigById(int configId)
		{
			return ConfigSpringFestivalRewardTabById.GetConfig(configId, true);
		}

		// Token: 0x0603E533 RID: 255283 RVA: 0x00F0D268 File Offset: 0x00F0B468
		public IReadOnlyList<SpringFestivalRewardTab> GetRewardTabConfigByActivityId(int activityId)
		{
			return ConfigSpringFestivalRewardTabByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0603E534 RID: 255284 RVA: 0x00F0D271 File Offset: 0x00F0B471
		public SpringFestivalScoreReward? GetScoreRewardConfigById(int configId)
		{
			return ConfigSpringFestivalScoreRewardById.GetConfig(configId, true);
		}

		// Token: 0x0603E535 RID: 255285 RVA: 0x00F0D27A File Offset: 0x00F0B47A
		public IReadOnlyList<SpringFestivalScoreReward> GetScoreRewardConfigListByActivityId(int activityId)
		{
			return ConfigSpringFestivalScoreRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0603E536 RID: 255286 RVA: 0x00F0D284 File Offset: 0x00F0B484
		public int GetMapIdByActivityId(int activityId)
		{
			SpringFestival? activityConfigByActivityId = this.GetActivityConfigByActivityId(activityId);
			if (activityConfigByActivityId == null)
			{
				return 0;
			}
			int instanceId = activityConfigByActivityId.Value.InstanceId;
			if (instanceId == 0)
			{
				return 0;
			}
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			return ((instance != null) ? instance.GetInstanceMapConfigId(instanceId) : null).GetValueOrDefault();
		}

		// Token: 0x0603E537 RID: 255287 RVA: 0x00F0D2DC File Offset: 0x00F0B4DC
		[NullableContext(1)]
		public IReadOnlyList<ExhibitPhantom> GetPhantomExtraConfigByBodySize(int size)
		{
			IReadOnlyList<ExhibitPhantom> configList = ConfigExhibitPhantomByBodyType.GetConfigList(size, true);
			if (configList == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Phantom;
				ELogAuthor author = ELogAuthor.BB;
				string message = "PhantomExtraConfig Invalid size";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("size", size);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new List<ExhibitPhantom>();
			}
			return configList;
		}

		// Token: 0x0603E538 RID: 255288 RVA: 0x00F0D327 File Offset: 0x00F0B527
		public SpringFestivalUnlock? GetFunctionConfigById(int id)
		{
			return ConfigSpringFestivalUnlockById.GetConfig(id, true);
		}

		// Token: 0x0603E539 RID: 255289 RVA: 0x00F0D330 File Offset: 0x00F0B530
		public Brochure? GetSpringManorBrochureByActivityAndType(int activityId, EBrochureType type)
		{
			return ConfigBrochureByActivityIdAndType.GetConfig(activityId, (int)type, true);
		}

		// Token: 0x0603E53A RID: 255290 RVA: 0x00F0D33A File Offset: 0x00F0B53A
		public BookItem? GetSpringManorBookItemById(int id)
		{
			return ConfigBookItemById.GetConfig(id, true);
		}

		// Token: 0x0603E53B RID: 255291 RVA: 0x00F0D343 File Offset: 0x00F0B543
		public Brochure? GetSpringManorBrochureById(int id)
		{
			return ConfigBrochureById.GetConfig(id, true);
		}

		// Token: 0x0603E53C RID: 255292 RVA: 0x00F0D34C File Offset: 0x00F0B54C
		public List<TItem> GetRewardItem(int dropId)
		{
			List<TItem> list = new List<TItem>();
			if (dropId == 0)
			{
				return list;
			}
			DropPackage? dropPackage;
			Dictionary<int, int> dictionary = (CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(dropId) != null) ? dropPackage.GetValueOrDefault().DropPreview() : null;
			if (dictionary == null)
			{
				return list;
			}
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0603E53D RID: 255293 RVA: 0x00F0D3FC File Offset: 0x00F0B5FC
		public int GetConditionGroupQuestId(int conditionGroupId)
		{
			Condition? config = ConfigConditionById.GetConfig(conditionGroupId, true);
			if (config != null)
			{
				string value;
				config.Value.LimitParams().TryGetValue("NewQuestId", out value);
				return (int)Convert.ToDouble(value);
			}
			return 0;
		}

		// Token: 0x0603E53E RID: 255294 RVA: 0x00F0D440 File Offset: 0x00F0B640
		public int GetConditionGroupLevelPlayId(int conditionGroupId)
		{
			Condition? config = ConfigConditionById.GetConfig(conditionGroupId, true);
			if (config != null)
			{
				string value;
				config.Value.LimitParams().TryGetValue("LevelPlayId", out value);
				return (int)Convert.ToDouble(value);
			}
			return 0;
		}

		// Token: 0x1700906C RID: 36972
		// (get) Token: 0x0603E53F RID: 255295 RVA: 0x00F0D483 File Offset: 0x00F0B683
		[Nullable(1)]
		public static SpringManorConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return SpringManorConfig._Instance;
			}
		}

		// Token: 0x0603E540 RID: 255296 RVA: 0x00F0D48A File Offset: 0x00F0B68A
		[NullableContext(1)]
		public static SpringManorConfig GetOrCreateInstance()
		{
			if (SpringManorConfig._Instance == null)
			{
				SpringManorConfig.CreateInstance();
			}
			return SpringManorConfig._Instance;
		}

		// Token: 0x0603E541 RID: 255297 RVA: 0x00F0D49E File Offset: 0x00F0B69E
		public static bool CreateInstance()
		{
			if (SpringManorConfig._Instance != null)
			{
				return true;
			}
			SpringManorConfig._Instance = new SpringManorConfig();
			return true;
		}

		// Token: 0x0603E542 RID: 255298 RVA: 0x00F0D4B4 File Offset: 0x00F0B6B4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E543 RID: 255299 RVA: 0x00F0D4B6 File Offset: 0x00F0B6B6
		public static void ResetStaticDefaultValue()
		{
			SpringManorConfig._Instance = null;
		}

		// Token: 0x0603E544 RID: 255300 RVA: 0x00F0D4BE File Offset: 0x00F0B6BE
		static SpringManorConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorConfig.CreateStaticDefaultValue), new Action(SpringManorConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402090B RID: 133387
		private static SpringManorConfig _Instance;
	}
}
