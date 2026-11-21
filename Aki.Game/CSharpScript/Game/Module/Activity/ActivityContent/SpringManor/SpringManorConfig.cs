using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FB3 RID: 20403
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class SpringManorConfig : ConfigBase
	{
		// Token: 0x060331EA RID: 209386 RVA: 0x00E53F46 File Offset: 0x00E52146
		public SpringFestival? GetActivityConfigByActivityId(int activityId)
		{
			return ConfigSpringFestivalByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x060331EB RID: 209387 RVA: 0x00E53F50 File Offset: 0x00E52150
		public int GetWorldTeleportId()
		{
			return ConfigCommonParamById.GetIntConfig("Spring26WorldTeleportId").Value;
		}

		// Token: 0x060331EC RID: 209388 RVA: 0x00E53F6F File Offset: 0x00E5216F
		public SpringFestivalMainTask? GetMainTaskConfigById(int id)
		{
			return ConfigSpringFestivalMainTaskById.GetConfig(id, true);
		}

		// Token: 0x060331ED RID: 209389 RVA: 0x00E53F78 File Offset: 0x00E52178
		public SpringFestivalMainTask? GetMainTaskConfigByQuestId(int questId)
		{
			return ConfigSpringFestivalMainTaskByQuestId.GetConfig(questId, true);
		}

		// Token: 0x060331EE RID: 209390 RVA: 0x00E53F81 File Offset: 0x00E52181
		public IReadOnlyList<SpringFestivalMainTask> GetAllMainTaskConfig()
		{
			return ConfigSpringFestivalMainTaskAll.GetConfigList(true);
		}

		// Token: 0x060331EF RID: 209391 RVA: 0x00E53F89 File Offset: 0x00E52189
		public SpringFestivalSubTask? GetSubTaskConfigByQuestId(int questId)
		{
			return ConfigSpringFestivalSubTaskByQuestId.GetConfig(questId, true);
		}

		// Token: 0x060331F0 RID: 209392 RVA: 0x00E53F92 File Offset: 0x00E52192
		public IReadOnlyList<SpringFestivalSubTask> GetAllSubTaskConfig()
		{
			return ConfigSpringFestivalSubTaskAll.GetConfigList(true);
		}

		// Token: 0x060331F1 RID: 209393 RVA: 0x00E53F9A File Offset: 0x00E5219A
		public AtmosphereLevel? GetLevelConfigById(int id)
		{
			return ConfigAtmosphereLevelById.GetConfig(id, true);
		}

		// Token: 0x060331F2 RID: 209394 RVA: 0x00E53FA4 File Offset: 0x00E521A4
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

		// Token: 0x060331F3 RID: 209395 RVA: 0x00E54008 File Offset: 0x00E52208
		public SpringFestivalSkipEntry? GetSkipEntryConfigById(int id)
		{
			return ConfigSpringFestivalSkipEntryById.GetConfig(id, true);
		}

		// Token: 0x060331F4 RID: 209396 RVA: 0x00E54011 File Offset: 0x00E52211
		public SpringFestivalReward? GetRewardTaskConfigById(int configId)
		{
			return ConfigSpringFestivalRewardById.GetConfig(configId, true);
		}

		// Token: 0x060331F5 RID: 209397 RVA: 0x00E5401A File Offset: 0x00E5221A
		public IReadOnlyList<SpringFestivalReward> GetRewardTaskConfigByActivityId(int activityId)
		{
			return ConfigSpringFestivalRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060331F6 RID: 209398 RVA: 0x00E54023 File Offset: 0x00E52223
		public SpringFestivalRewardTab? GetRewardTabConfigById(int configId)
		{
			return ConfigSpringFestivalRewardTabById.GetConfig(configId, true);
		}

		// Token: 0x060331F7 RID: 209399 RVA: 0x00E5402C File Offset: 0x00E5222C
		public IReadOnlyList<SpringFestivalRewardTab> GetRewardTabConfigByActivityId(int activityId)
		{
			return ConfigSpringFestivalRewardTabByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060331F8 RID: 209400 RVA: 0x00E54035 File Offset: 0x00E52235
		public SpringFestivalScoreReward? GetScoreRewardConfigById(int configId)
		{
			return ConfigSpringFestivalScoreRewardById.GetConfig(configId, true);
		}

		// Token: 0x060331F9 RID: 209401 RVA: 0x00E5403E File Offset: 0x00E5223E
		public IReadOnlyList<SpringFestivalScoreReward> GetScoreRewardConfigListByActivityId(int activityId)
		{
			return ConfigSpringFestivalScoreRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060331FA RID: 209402 RVA: 0x00E54048 File Offset: 0x00E52248
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

		// Token: 0x060331FB RID: 209403 RVA: 0x00E540A0 File Offset: 0x00E522A0
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

		// Token: 0x060331FC RID: 209404 RVA: 0x00E540EB File Offset: 0x00E522EB
		public SpringFestivalUnlock? GetFunctionConfigById(int id)
		{
			return ConfigSpringFestivalUnlockById.GetConfig(id, true);
		}

		// Token: 0x060331FD RID: 209405 RVA: 0x00E540F4 File Offset: 0x00E522F4
		public Brochure? GetSpringManorBrochureByActivityAndType(int activityId, EBrochureType type)
		{
			return ConfigBrochureByActivityIdAndType.GetConfig(activityId, (int)type, true);
		}

		// Token: 0x060331FE RID: 209406 RVA: 0x00E540FE File Offset: 0x00E522FE
		public BookItem? GetSpringManorBookItemById(int id)
		{
			return ConfigBookItemById.GetConfig(id, true);
		}

		// Token: 0x060331FF RID: 209407 RVA: 0x00E54107 File Offset: 0x00E52307
		public Brochure? GetSpringManorBrochureById(int id)
		{
			return ConfigBrochureById.GetConfig(id, true);
		}

		// Token: 0x06033200 RID: 209408 RVA: 0x00E54110 File Offset: 0x00E52310
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

		// Token: 0x06033201 RID: 209409 RVA: 0x00E541C0 File Offset: 0x00E523C0
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

		// Token: 0x06033202 RID: 209410 RVA: 0x00E54204 File Offset: 0x00E52404
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

		// Token: 0x170063CE RID: 25550
		// (get) Token: 0x06033203 RID: 209411 RVA: 0x00E54247 File Offset: 0x00E52447
		[Nullable(1)]
		public static SpringManorConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return SpringManorConfig._Instance;
			}
		}

		// Token: 0x06033204 RID: 209412 RVA: 0x00E5424E File Offset: 0x00E5244E
		[NullableContext(1)]
		public static SpringManorConfig GetOrCreateInstance()
		{
			if (SpringManorConfig._Instance == null)
			{
				SpringManorConfig.CreateInstance();
			}
			return SpringManorConfig._Instance;
		}

		// Token: 0x06033205 RID: 209413 RVA: 0x00E54262 File Offset: 0x00E52462
		public static bool CreateInstance()
		{
			if (SpringManorConfig._Instance != null)
			{
				return true;
			}
			SpringManorConfig._Instance = new SpringManorConfig();
			return true;
		}

		// Token: 0x06033206 RID: 209414 RVA: 0x00E54278 File Offset: 0x00E52478
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033207 RID: 209415 RVA: 0x00E5427A File Offset: 0x00E5247A
		public static void ResetStaticDefaultValue()
		{
			SpringManorConfig._Instance = null;
		}

		// Token: 0x06033208 RID: 209416 RVA: 0x00E54282 File Offset: 0x00E52482
		static SpringManorConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpringManorConfig.CreateStaticDefaultValue), new Action(SpringManorConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B238 RID: 111160
		private static SpringManorConfig _Instance;
	}
}
