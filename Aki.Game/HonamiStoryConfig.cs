using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200134B RID: 4939
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class HonamiStoryConfig : ConfigBase
{
	// Token: 0x0600C26B RID: 49771 RVA: 0x00398AF4 File Offset: 0x00396CF4
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

	// Token: 0x0600C26C RID: 49772 RVA: 0x00398B58 File Offset: 0x00396D58
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

	// Token: 0x0600C26D RID: 49773 RVA: 0x00398BBC File Offset: 0x00396DBC
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

	// Token: 0x0600C26E RID: 49774 RVA: 0x00398C20 File Offset: 0x00396E20
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

	// Token: 0x0600C26F RID: 49775 RVA: 0x00398CB4 File Offset: 0x00396EB4
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

	// Token: 0x0600C270 RID: 49776 RVA: 0x00398D18 File Offset: 0x00396F18
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

	// Token: 0x0600C271 RID: 49777 RVA: 0x00398D84 File Offset: 0x00396F84
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

	// Token: 0x0600C272 RID: 49778 RVA: 0x00398DFC File Offset: 0x00396FFC
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

	// Token: 0x0600C273 RID: 49779 RVA: 0x00398E60 File Offset: 0x00397060
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

	// Token: 0x0600C274 RID: 49780 RVA: 0x00398EC4 File Offset: 0x003970C4
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

	// Token: 0x0600C275 RID: 49781 RVA: 0x00398F28 File Offset: 0x00397128
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

	// Token: 0x0600C276 RID: 49782 RVA: 0x00398F68 File Offset: 0x00397168
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

	// Token: 0x0600C277 RID: 49783 RVA: 0x00398FCC File Offset: 0x003971CC
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

	// Token: 0x0600C278 RID: 49784 RVA: 0x0039901C File Offset: 0x0039721C
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

	// Token: 0x0600C279 RID: 49785 RVA: 0x0039908C File Offset: 0x0039728C
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

	// Token: 0x0600C27A RID: 49786 RVA: 0x003990DC File Offset: 0x003972DC
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

	// Token: 0x0600C27B RID: 49787 RVA: 0x0039912C File Offset: 0x0039732C
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

	// Token: 0x0600C27C RID: 49788 RVA: 0x0039917C File Offset: 0x0039737C
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

	// Token: 0x0600C27D RID: 49789 RVA: 0x003991CC File Offset: 0x003973CC
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

	// Token: 0x0600C27E RID: 49790 RVA: 0x0039921C File Offset: 0x0039741C
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

	// Token: 0x0600C27F RID: 49791 RVA: 0x0039926C File Offset: 0x0039746C
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

	// Token: 0x0600C280 RID: 49792 RVA: 0x003992D0 File Offset: 0x003974D0
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

	// Token: 0x0600C281 RID: 49793 RVA: 0x00399334 File Offset: 0x00397534
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

	// Token: 0x0600C282 RID: 49794 RVA: 0x00399398 File Offset: 0x00397598
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

	// Token: 0x0600C283 RID: 49795 RVA: 0x003993FC File Offset: 0x003975FC
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

	// Token: 0x0600C284 RID: 49796 RVA: 0x00399460 File Offset: 0x00397660
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

	// Token: 0x0600C285 RID: 49797 RVA: 0x003994C4 File Offset: 0x003976C4
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

	// Token: 0x0600C286 RID: 49798 RVA: 0x00399528 File Offset: 0x00397728
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

	// Token: 0x0600C287 RID: 49799 RVA: 0x0039958C File Offset: 0x0039778C
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

	// Token: 0x0600C288 RID: 49800 RVA: 0x003995DC File Offset: 0x003977DC
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

	// Token: 0x0600C289 RID: 49801 RVA: 0x00399634 File Offset: 0x00397834
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

	// Token: 0x0600C28A RID: 49802 RVA: 0x00399684 File Offset: 0x00397884
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

	// Token: 0x0600C28B RID: 49803 RVA: 0x003996D4 File Offset: 0x003978D4
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

	// Token: 0x0600C28C RID: 49804 RVA: 0x00399750 File Offset: 0x00397950
	public int GetDoubleClickDelay()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryBackpackClickInterval").GetValueOrDefault(300);
	}

	// Token: 0x0600C28D RID: 49805 RVA: 0x00399774 File Offset: 0x00397974
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

	// Token: 0x0600C28E RID: 49806 RVA: 0x003997F0 File Offset: 0x003979F0
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

	// Token: 0x0600C28F RID: 49807 RVA: 0x0039986C File Offset: 0x00397A6C
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

	// Token: 0x0600C290 RID: 49808 RVA: 0x003998D0 File Offset: 0x00397AD0
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

	// Token: 0x0600C291 RID: 49809 RVA: 0x00399968 File Offset: 0x00397B68
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

	// Token: 0x0600C292 RID: 49810 RVA: 0x003999B8 File Offset: 0x00397BB8
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

	// Token: 0x0600C293 RID: 49811 RVA: 0x003999F8 File Offset: 0x00397BF8
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

	// Token: 0x0600C294 RID: 49812 RVA: 0x00399A74 File Offset: 0x00397C74
	public HonamiStoryMarkWhiteList? GetHonamiScanItemWhiteListConfigByEntityConfigId(int entityConfigId)
	{
		HonamiStoryMarkWhiteList? config = ConfigHonamiStoryMarkWhiteListById.GetConfig(entityConfigId, true);
		if (config == null)
		{
			return null;
		}
		return new HonamiStoryMarkWhiteList?(config.Value);
	}

	// Token: 0x0600C295 RID: 49813 RVA: 0x00399AA8 File Offset: 0x00397CA8
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

	// Token: 0x0600C296 RID: 49814 RVA: 0x00399B10 File Offset: 0x00397D10
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

	// Token: 0x0600C297 RID: 49815 RVA: 0x00399B74 File Offset: 0x00397D74
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

	// Token: 0x0600C298 RID: 49816 RVA: 0x00399BC4 File Offset: 0x00397DC4
	public int GetScrollingSpeed()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryScrollMoveSpeed").GetValueOrDefault(10);
	}

	// Token: 0x0600C299 RID: 49817 RVA: 0x00399BE8 File Offset: 0x00397DE8
	public int GetDragThresholdSpeed()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryDragBeginDistanceThreshold").GetValueOrDefault(9);
	}

	// Token: 0x0600C29A RID: 49818 RVA: 0x00399C0C File Offset: 0x00397E0C
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

	// Token: 0x0600C29B RID: 49819 RVA: 0x00399C58 File Offset: 0x00397E58
	public int GetPickUpRange()
	{
		return ConfigCommonParamById.GetIntConfig("HonamiStoryMobilePickUpRange").GetValueOrDefault(1000);
	}

	// Token: 0x0600C29C RID: 49820 RVA: 0x00399C7C File Offset: 0x00397E7C
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

	// Token: 0x170012FC RID: 4860
	// (get) Token: 0x0600C29D RID: 49821 RVA: 0x00399CDF File Offset: 0x00397EDF
	public static HonamiStoryConfig Instance
	{
		get
		{
			return HonamiStoryConfig._Instance;
		}
	}

	// Token: 0x0600C29E RID: 49822 RVA: 0x00399CE6 File Offset: 0x00397EE6
	public static HonamiStoryConfig GetOrCreateInstance()
	{
		if (HonamiStoryConfig._Instance == null)
		{
			HonamiStoryConfig.CreateInstance();
		}
		return HonamiStoryConfig._Instance;
	}

	// Token: 0x0600C29F RID: 49823 RVA: 0x00399CFA File Offset: 0x00397EFA
	public static bool CreateInstance()
	{
		if (HonamiStoryConfig._Instance != null)
		{
			return true;
		}
		HonamiStoryConfig._Instance = new HonamiStoryConfig();
		return true;
	}

	// Token: 0x0600C2A0 RID: 49824 RVA: 0x00399D10 File Offset: 0x00397F10
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C2A1 RID: 49825 RVA: 0x00399D12 File Offset: 0x00397F12
	public static void ResetStaticDefaultValue()
	{
		HonamiStoryConfig._Instance = null;
	}

	// Token: 0x0600C2A2 RID: 49826 RVA: 0x00399D1A File Offset: 0x00397F1A
	static HonamiStoryConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HonamiStoryConfig.CreateStaticDefaultValue), new Action(HonamiStoryConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006F6F RID: 28527
	[Nullable(2)]
	private static HonamiStoryConfig _Instance;
}
