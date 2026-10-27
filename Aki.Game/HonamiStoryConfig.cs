using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001E89 RID: 7817
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class HonamiStoryConfig : ConfigBase
{
	// Token: 0x0600EE4C RID: 61004 RVA: 0x0038CF04 File Offset: 0x0038B104
	public HonamiStoryBackPack? GetHonamiStoryBackPack(int id)
	{
		HonamiStoryBackPack? config = ConfigHonamiStoryBackPackById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryBackPack表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryBackPack?(config.Value);
	}

	// Token: 0x0600EE4D RID: 61005 RVA: 0x0038CF68 File Offset: 0x0038B168
	public HonamiStoryItem? GetHonamiStoryItem(int itemId)
	{
		HonamiStoryItem? config = ConfigHonamiStoryItemById.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryItem表无效itemId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryItem?(config.Value);
	}

	// Token: 0x0600EE4E RID: 61006 RVA: 0x0038CFCC File Offset: 0x0038B1CC
	public HonamiStoryEquip? GetHonamiStoryEquip(int itemId)
	{
		HonamiStoryEquip? config = ConfigHonamiStoryEquipById.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryEquip表无效itemId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryEquip?(config.Value);
	}

	// Token: 0x0600EE4F RID: 61007 RVA: 0x0038D030 File Offset: 0x0038B230
	public int[] GetHonamiStoryPropLibrary(int id)
	{
		HonamiStoryPropLibrary? config = ConfigHonamiStoryPropLibraryById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryPropLibrary表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new int[0];
		}
		int honamiStoryPropIdLength = config.Value.HonamiStoryPropIdLength;
		int[] array = new int[honamiStoryPropIdLength];
		for (int i = 0; i < honamiStoryPropIdLength; i++)
		{
			array[i] = config.Value.HonamiStoryPropId(i);
		}
		return array;
	}

	// Token: 0x0600EE50 RID: 61008 RVA: 0x0038D0C4 File Offset: 0x0038B2C4
	public HonamiStoryProp? GetHonamiStoryProp(int id)
	{
		HonamiStoryProp? config = ConfigHonamiStoryPropById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryProp表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryProp?(config.Value);
	}

	// Token: 0x0600EE51 RID: 61009 RVA: 0x0038D128 File Offset: 0x0038B328
	public int? GetHonamiStoryBuffTempLibrary(int id)
	{
		HonamiStoryBuffTempLibrary? config = ConfigHonamiStoryBuffTempLibraryById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryBuffTempLibrary表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new int?(config.Value.BuffTermpId);
	}

	// Token: 0x0600EE52 RID: 61010 RVA: 0x0038D194 File Offset: 0x0038B394
	[NullableContext(2)]
	public string GetHonamiStoryBuffTempDescFromLibrary(int libraryId)
	{
		int? honamiStoryBuffTempLibrary = this.GetHonamiStoryBuffTempLibrary(libraryId);
		if (honamiStoryBuffTempLibrary == null)
		{
			return null;
		}
		HonamiStoryBuffTemp? config = ConfigHonamiStoryBuffTempById.GetConfig(honamiStoryBuffTempLibrary.Value, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryBuffTemp表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", honamiStoryBuffTempLibrary);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config.Value.Desc;
	}

	// Token: 0x0600EE53 RID: 61011 RVA: 0x0038D20C File Offset: 0x0038B40C
	public HonamiStoryBuffTemp? GetHonamiStoryBuffTemp(int id)
	{
		HonamiStoryBuffTemp? config = ConfigHonamiStoryBuffTempById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryBuffTemp表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryBuffTemp?(config.Value);
	}

	// Token: 0x0600EE54 RID: 61012 RVA: 0x0038D270 File Offset: 0x0038B470
	public HonamiStoryItemQuality? GetHonamiStoryQuality(int quality)
	{
		HonamiStoryItemQuality? config = ConfigHonamiStoryItemQualityById.GetConfig(quality, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryItemQuality表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", quality);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryItemQuality?(config.Value);
	}

	// Token: 0x0600EE55 RID: 61013 RVA: 0x0038D2D4 File Offset: 0x0038B4D4
	public HonamiStoryActivity? GetHonamiStoryActivityConfig(int activityId)
	{
		HonamiStoryActivity? config = ConfigHonamiStoryActivityByActivityId.GetConfig(activityId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryActivity表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryActivity?(config.Value);
	}

	// Token: 0x0600EE56 RID: 61014 RVA: 0x0038D338 File Offset: 0x0038B538
	public IReadOnlyList<HonamiStoryActivity> GetAllActivityConfig()
	{
		IReadOnlyList<HonamiStoryActivity> configList = ConfigHonamiStoryActivityAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.WHJ, "HonamiStoryActivity表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return Array.Empty<HonamiStoryActivity>();
		}
		return configList;
	}

	// Token: 0x0600EE57 RID: 61015 RVA: 0x0038D378 File Offset: 0x0038B578
	public HonamiStoryMascot? GetHonamiStoryMascotConfig(int id)
	{
		HonamiStoryMascot? config = ConfigHonamiStoryMascotById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryMascot表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryMascot?(config.Value);
	}

	// Token: 0x0600EE58 RID: 61016 RVA: 0x0038D3DC File Offset: 0x0038B5DC
	public IReadOnlyList<HonamiStoryMascot> GetHonamiStoryMascotConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryMascot> configList = ConfigHonamiStoryMascotByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryMascot表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryMascot>();
		}
		return configList;
	}

	// Token: 0x0600EE59 RID: 61017 RVA: 0x0038D42C File Offset: 0x0038B62C
	public HonamiStoryArea? GetHonamiStoryAreaConfig(int areaId)
	{
		if (areaId == 0)
		{
			return null;
		}
		HonamiStoryArea? config = ConfigHonamiStoryAreaById.GetConfig(areaId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryArea表无效areaId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("areaId", areaId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryArea?(config.Value);
	}

	// Token: 0x0600EE5A RID: 61018 RVA: 0x0038D49C File Offset: 0x0038B69C
	public IReadOnlyList<HonamiStoryArea> GetHonamiStoryAreaConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryArea> configList = ConfigHonamiStoryAreaByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryArea表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryArea>();
		}
		return configList;
	}

	// Token: 0x0600EE5B RID: 61019 RVA: 0x0038D4EC File Offset: 0x0038B6EC
	public IReadOnlyList<HonamiStoryLimitTask> GetHonamiStoryLimitTaskConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryLimitTask> configList = ConfigHonamiStoryLimitTaskByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLimitTask表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryLimitTask>();
		}
		return configList;
	}

	// Token: 0x0600EE5C RID: 61020 RVA: 0x0038D53C File Offset: 0x0038B73C
	public IReadOnlyList<HonamiStoryResidentTask> GetHonamiStoryPermanentTaskConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryResidentTask> configList = ConfigHonamiStoryResidentTaskByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryResidentTask表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryResidentTask>();
		}
		return configList;
	}

	// Token: 0x0600EE5D RID: 61021 RVA: 0x0038D58C File Offset: 0x0038B78C
	public IReadOnlyList<HonamiStoryScoreReward> GetHonamiStoryScoreRewardConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryScoreReward> configList = ConfigHonamiStoryScoreRewardByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryScoreReward表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryScoreReward>();
		}
		return configList;
	}

	// Token: 0x0600EE5E RID: 61022 RVA: 0x0038D5DC File Offset: 0x0038B7DC
	public IReadOnlyList<HonamiStoryTalent> GetHonamiStoryTalentConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryTalent> configList = ConfigHonamiStoryTalentByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryTalent表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryTalent>();
		}
		return configList;
	}

	// Token: 0x0600EE5F RID: 61023 RVA: 0x0038D62C File Offset: 0x0038B82C
	public IReadOnlyList<HonamiStoryItemCollection> GetHonamiStoryItemCollectionConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryItemCollection> configList = ConfigHonamiStoryItemCollectionByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryItemCollection表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryItemCollection>();
		}
		return configList;
	}

	// Token: 0x0600EE60 RID: 61024 RVA: 0x0038D67C File Offset: 0x0038B87C
	public HonamiStoryAreaTask? GetHonamiStoryAreaTaskById(int id)
	{
		HonamiStoryAreaTask? config = ConfigHonamiStoryAreaTaskById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryAreaTask表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryAreaTask?(config.Value);
	}

	// Token: 0x0600EE61 RID: 61025 RVA: 0x0038D6E0 File Offset: 0x0038B8E0
	public HonamiStoryLimitTask? GetHonamiStoryLimitTaskConfig(int configId)
	{
		HonamiStoryLimitTask? config = ConfigHonamiStoryLimitTaskById.GetConfig(configId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLimitTask表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryLimitTask?(config.Value);
	}

	// Token: 0x0600EE62 RID: 61026 RVA: 0x0038D744 File Offset: 0x0038B944
	public HonamiStoryResidentTask? GetHonamiStoryPermanentTaskConfig(int configId)
	{
		HonamiStoryResidentTask? config = ConfigHonamiStoryResidentTaskById.GetConfig(configId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryResidentTask表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryResidentTask?(config.Value);
	}

	// Token: 0x0600EE63 RID: 61027 RVA: 0x0038D7A8 File Offset: 0x0038B9A8
	public HonamiStoryScoreReward? GetHonamiStoryScoreRewardConfig(int configId)
	{
		HonamiStoryScoreReward? config = ConfigHonamiStoryScoreRewardById.GetConfig(configId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryScoreReward表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryScoreReward?(config.Value);
	}

	// Token: 0x0600EE64 RID: 61028 RVA: 0x0038D80C File Offset: 0x0038BA0C
	public HonamiStoryWeaponSuit? GetWeaponSuit(int id)
	{
		HonamiStoryWeaponSuit? config = ConfigHonamiStoryWeaponSuitById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryWeaponSuit表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryWeaponSuit?(config.Value);
	}

	// Token: 0x0600EE65 RID: 61029 RVA: 0x0038D870 File Offset: 0x0038BA70
	public HonamiStoryPluginSubType? GetPluginSubType(int id)
	{
		HonamiStoryPluginSubType? config = ConfigHonamiStoryPluginSubTypeById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryPluginSubType表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryPluginSubType?(config.Value);
	}

	// Token: 0x0600EE66 RID: 61030 RVA: 0x0038D8D4 File Offset: 0x0038BAD4
	public HonamiStoryPluginTag? GetPluginTag(int id)
	{
		HonamiStoryPluginTag? config = ConfigHonamiStoryPluginTagById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryPluginTag表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryPluginTag?(config.Value);
	}

	// Token: 0x0600EE67 RID: 61031 RVA: 0x0038D938 File Offset: 0x0038BB38
	public HonamiStoryLifeSupport? GetLifeSupport(int id)
	{
		HonamiStoryLifeSupport? config = ConfigHonamiStoryLifeSupportById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLifeSupport表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryLifeSupport?(config.Value);
	}

	// Token: 0x0600EE68 RID: 61032 RVA: 0x0038D99C File Offset: 0x0038BB9C
	public IReadOnlyList<HonamiStoryLifeSupport> GetLifeSupportList(int activityId)
	{
		IReadOnlyList<HonamiStoryLifeSupport> configList = ConfigHonamiStoryLifeSupportByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLifeSupport表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryLifeSupport>();
		}
		return configList;
	}

	// Token: 0x0600EE69 RID: 61033 RVA: 0x0038D9EC File Offset: 0x0038BBEC
	public HonamiStoryWeapon? GetWeaponConfig(int id)
	{
		if (id == 0)
		{
			return null;
		}
		HonamiStoryWeapon? config = ConfigHonamiStoryWeaponById.GetConfig(id, true);
		if (id > 0 && config == null)
		{
			return null;
		}
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryWeapon?(config.Value);
	}

	// Token: 0x0600EE6A RID: 61034 RVA: 0x0038DA44 File Offset: 0x0038BC44
	public IReadOnlyList<HonamiStoryWeapon> GetHonamiStoryWeaponConfigList(int activityId)
	{
		IReadOnlyList<HonamiStoryWeapon> configList = ConfigHonamiStoryWeaponByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryWeapon表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryWeapon>();
		}
		return configList;
	}

	// Token: 0x0600EE6B RID: 61035 RVA: 0x0038DA94 File Offset: 0x0038BC94
	public IReadOnlyList<HonamiStoryOutDialog> GetHonamiStoryOutDialogList(int activityId)
	{
		IReadOnlyList<HonamiStoryOutDialog> configList = ConfigHonamiStoryOutDialogByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryOutDialog表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryOutDialog>();
		}
		return configList;
	}

	// Token: 0x0600EE6C RID: 61036 RVA: 0x0038DAE4 File Offset: 0x0038BCE4
	public HonamiStoryEffect? GetEffectConfig(int id)
	{
		HonamiStoryEffect? config = ConfigHonamiStoryEffectById.GetConfig(id, true);
		if (id > 0 && config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryEffect表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryEffect?(config.Value);
	}

	// Token: 0x0600EE6D RID: 61037 RVA: 0x0038DB60 File Offset: 0x0038BD60
	public int GetDoubleClickDelay()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryBackpackClickInterval").GetValueOrDefault(300);
	}

	// Token: 0x0600EE6E RID: 61038 RVA: 0x0038DB84 File Offset: 0x0038BD84
	public HonamiStoryPluginSlot? GetSlotUnlockConfig(int id)
	{
		HonamiStoryPluginSlot? config = ConfigHonamiStoryPluginSlotById.GetConfig(id, true);
		if (id > 0 && config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryPluginSlot表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryPluginSlot?(config.Value);
	}

	// Token: 0x0600EE6F RID: 61039 RVA: 0x0038DC00 File Offset: 0x0038BE00
	public HonamiStoryDangerLevel? GetDangerLevelConfig(int id)
	{
		HonamiStoryDangerLevel? config = ConfigHonamiStoryDangerLevelById.GetConfig(id, true);
		if (id > 0 && config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryEffect表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryDangerLevel?(config.Value);
	}

	// Token: 0x0600EE70 RID: 61040 RVA: 0x0038DC7C File Offset: 0x0038BE7C
	public HonamiStoryLoadingPerform? GetLoadingPerformConfigById(int id)
	{
		HonamiStoryLoadingPerform? config = ConfigHonamiStoryLoadingPerformById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLoadingPerform表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryLoadingPerform?(config.Value);
	}

	// Token: 0x0600EE71 RID: 61041 RVA: 0x0038DCE0 File Offset: 0x0038BEE0
	public unsafe HonamiStoryLoadingPerform? GetLoadingPerformConfigByBtAndTime(int mainBtId, int timing)
	{
		HonamiStoryLoadingPerform? config = ConfigHonamiStoryLoadingPerformByBTIdAndTiming.GetConfig(mainBtId, timing, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLoadingPerform表无效BtId/timing";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BtId", mainBtId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Timing", timing);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new HonamiStoryLoadingPerform?(config.Value);
	}

	// Token: 0x0600EE72 RID: 61042 RVA: 0x0038DD78 File Offset: 0x0038BF78
	public IReadOnlyList<HonamiStoryLoadingPerform> GetLoadingPerformConfigListByTiming(int timing)
	{
		IReadOnlyList<HonamiStoryLoadingPerform> configList = ConfigHonamiStoryLoadingPerformByTiming.GetConfigList(timing, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "HonamiStoryLoadingPerform表无效timing";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("timing", timing);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryLoadingPerform>();
		}
		return configList;
	}

	// Token: 0x0600EE73 RID: 61043 RVA: 0x0038DDC8 File Offset: 0x0038BFC8
	public IReadOnlyList<HonamiStoryMapMark> GetHonamiMapMarkList()
	{
		IReadOnlyList<HonamiStoryMapMark> configList = ConfigHonamiStoryMapMarkAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LYX, "HonamiStoryMapMark表无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<HonamiStoryMapMark>();
		}
		return configList;
	}

	// Token: 0x0600EE74 RID: 61044 RVA: 0x0038DE08 File Offset: 0x0038C008
	public HonamiStoryMapMark? GetHonamiMapMarkById(int id)
	{
		HonamiStoryMapMark? config = ConfigHonamiStoryMapMarkById.GetConfig(id, true);
		if (id > 0 && config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "HonamiStoryMapMark表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryMapMark?(config.Value);
	}

	// Token: 0x0600EE75 RID: 61045 RVA: 0x0038DE84 File Offset: 0x0038C084
	public HonamiStoryMarkWhiteList? GetHonamiScanItemWhiteListConfigByEntityConfigId(int entityConfigId)
	{
		HonamiStoryMarkWhiteList? config = ConfigHonamiStoryMarkWhiteListById.GetConfig(entityConfigId, true);
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryMarkWhiteList?(config.Value);
	}

	// Token: 0x0600EE76 RID: 61046 RVA: 0x0038DEB8 File Offset: 0x0038C0B8
	public IReadOnlyList<int> GetHonamiScanItemWhileListIds()
	{
		IReadOnlyList<HonamiStoryMarkWhiteList> configList = ConfigHonamiStoryMarkWhiteListAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		foreach (HonamiStoryMarkWhiteList honamiStoryMarkWhiteList in configList)
		{
			list.Add(honamiStoryMarkWhiteList.Id);
		}
		return list;
	}

	// Token: 0x0600EE77 RID: 61047 RVA: 0x0038DF20 File Offset: 0x0038C120
	public HonamiStoryPluginBoxItem? GetHonamiStoryPluginBoxItemById(int id)
	{
		HonamiStoryPluginBoxItem? config = ConfigHonamiStoryPluginBoxItemById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryPluginBoxItem表无效Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryPluginBoxItem?(config.Value);
	}

	// Token: 0x0600EE78 RID: 61048 RVA: 0x0038DF84 File Offset: 0x0038C184
	public IReadOnlyList<HonamiStoryPluginBoxItem> GetHonamiStoryPluginBoxItemList(int activityId)
	{
		IReadOnlyList<HonamiStoryPluginBoxItem> configList = ConfigHonamiStoryPluginBoxItemByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.BB;
			string message = "HonamiStoryPluginBoxItem表无效ActivityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<HonamiStoryPluginBoxItem>();
		}
		return configList;
	}

	// Token: 0x0600EE79 RID: 61049 RVA: 0x0038DFD4 File Offset: 0x0038C1D4
	public int GetScrollingSpeed()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryScrollMoveSpeed").GetValueOrDefault(10);
	}

	// Token: 0x0600EE7A RID: 61050 RVA: 0x0038DFF8 File Offset: 0x0038C1F8
	public int GetDragThresholdSpeed()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryDragBeginDistanceThreshold").GetValueOrDefault(9);
	}

	// Token: 0x0600EE7B RID: 61051 RVA: 0x0038E01C File Offset: 0x0038C21C
	[NullableContext(0)]
	public ValueTuple<int, int> GetDragOffset()
	{
		if (!HonamiStoryUtil.IsMobileView())
		{
			return new ValueTuple<int, int>(0, 0);
		}
		int valueOrDefault = ConfigCommonParamById.GetIntConfig("HonamiStoryMobileDragOffsetX").GetValueOrDefault();
		int valueOrDefault2 = ConfigCommonParamById.GetIntConfig("HonamiStoryMobileDragOffsetY").GetValueOrDefault(140);
		return new ValueTuple<int, int>(valueOrDefault, valueOrDefault2);
	}

	// Token: 0x0600EE7C RID: 61052 RVA: 0x0038E068 File Offset: 0x0038C268
	public int GetPickUpRange()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryMobilePickUpRange").GetValueOrDefault(1000);
	}

	// Token: 0x0600EE7D RID: 61053 RVA: 0x0038E08C File Offset: 0x0038C28C
	public HonamiStoryScanMachine? GetScanMachineById(int id)
	{
		HonamiStoryScanMachine? config = ConfigHonamiStoryScanMachineById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HonamiStory;
			ELogAuthor author = ELogAuthor.LYX;
			string message = "HonamiStoryScanMachine表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new HonamiStoryScanMachine?(config.Value);
	}

	// Token: 0x170012D2 RID: 4818
	// (get) Token: 0x0600EE7E RID: 61054 RVA: 0x0038E0EF File Offset: 0x0038C2EF
	public static HonamiStoryConfig Instance
	{
		get
		{
			return HonamiStoryConfig._Instance;
		}
	}

	// Token: 0x0600EE7F RID: 61055 RVA: 0x0038E0F6 File Offset: 0x0038C2F6
	public static HonamiStoryConfig GetOrCreateInstance()
	{
		if (HonamiStoryConfig._Instance == null)
		{
			HonamiStoryConfig.CreateInstance();
		}
		return HonamiStoryConfig._Instance;
	}

	// Token: 0x0600EE80 RID: 61056 RVA: 0x0038E10A File Offset: 0x0038C30A
	public static bool CreateInstance()
	{
		if (HonamiStoryConfig._Instance != null)
		{
			return true;
		}
		HonamiStoryConfig._Instance = new HonamiStoryConfig();
		return true;
	}

	// Token: 0x0600EE81 RID: 61057 RVA: 0x0038E120 File Offset: 0x0038C320
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EE82 RID: 61058 RVA: 0x0038E122 File Offset: 0x0038C322
	public static void ResetStaticDefaultValue()
	{
		HonamiStoryConfig._Instance = null;
	}

	// Token: 0x0600EE83 RID: 61059 RVA: 0x0038E12A File Offset: 0x0038C32A
	static HonamiStoryConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryConfig.CreateStaticDefaultValue), new Action(HonamiStoryConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006E8E RID: 28302
	[Nullable(2)]
	private static HonamiStoryConfig _Instance;
}
