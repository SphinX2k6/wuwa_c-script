using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B2A RID: 6954
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FloroRanchConfig : ConfigBase
{
	// Token: 0x0600CE47 RID: 52807 RVA: 0x002EFDD8 File Offset: 0x002EDFD8
	public FloroRanchActivity? GetFloroRanchActivityConfig(int activityId)
	{
		FloroRanchActivity? config = ConfigFloroRanchActivityById.GetConfig(activityId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchActivity表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE48 RID: 52808 RVA: 0x002EFE30 File Offset: 0x002EE030
	public IReadOnlyList<FloroRanchIns> GetFloroRanchDungeonConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchIns> configList = ConfigFloroRanchInsByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchIns表 无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchIns>();
		}
		return configList;
	}

	// Token: 0x0600CE49 RID: 52809 RVA: 0x002EFE80 File Offset: 0x002EE080
	public FloroRanchSubIns? GetFloroRanchSubDungeonConfig(int id)
	{
		FloroRanchSubIns? config = ConfigFloroRanchSubInsById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchSubIns表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE4A RID: 52810 RVA: 0x002EFED8 File Offset: 0x002EE0D8
	public IReadOnlyList<FloroRanchRarity> GetFloroRanchRarityConfigList()
	{
		IReadOnlyList<FloroRanchRarity> configList = ConfigFloroRanchRarityAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchRarity表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchRarity>();
		}
		return configList;
	}

	// Token: 0x0600CE4B RID: 52811 RVA: 0x002EFF18 File Offset: 0x002EE118
	public FloroRanchRace? GetFloroRanchRaceConfig(int id)
	{
		FloroRanchRace? config = ConfigFloroRanchRaceById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchRace表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE4C RID: 52812 RVA: 0x002EFF70 File Offset: 0x002EE170
	public IReadOnlyList<FloroRanchRace> GetFloroRanchRaceConfigList()
	{
		IReadOnlyList<FloroRanchRace> configList = ConfigFloroRanchRaceAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchRace表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchRace>();
		}
		return configList;
	}

	// Token: 0x0600CE4D RID: 52813 RVA: 0x002EFFB0 File Offset: 0x002EE1B0
	public FloroRanchCard? GetFloroRanchCardConfig(int id)
	{
		FloroRanchCard? config = ConfigFloroRanchCardById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchCard表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE4E RID: 52814 RVA: 0x002F0008 File Offset: 0x002EE208
	public IReadOnlyList<FloroRanchCard> GetFloroRanchCardConfigList()
	{
		IReadOnlyList<FloroRanchCard> configList = ConfigFloroRanchCardAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchCard表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchCard>();
		}
		return configList;
	}

	// Token: 0x0600CE4F RID: 52815 RVA: 0x002F0048 File Offset: 0x002EE248
	public FloroRanchToy? GetFloroRanchToyConfig(int id)
	{
		FloroRanchToy? config = ConfigFloroRanchToyById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchToy表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE50 RID: 52816 RVA: 0x002F00A0 File Offset: 0x002EE2A0
	public IReadOnlyList<FloroRanchToy> GetFloroRanchToyConfigList()
	{
		IReadOnlyList<FloroRanchToy> configList = ConfigFloroRanchToyAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchToy表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchToy>();
		}
		return configList;
	}

	// Token: 0x0600CE51 RID: 52817 RVA: 0x002F00E0 File Offset: 0x002EE2E0
	public IReadOnlyList<FloroRanchTerrain> GetFloroRanchTerrainConfigList()
	{
		IReadOnlyList<FloroRanchTerrain> configList = ConfigFloroRanchTerrainAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchTerrain表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchTerrain>();
		}
		return configList;
	}

	// Token: 0x0600CE52 RID: 52818 RVA: 0x002F0120 File Offset: 0x002EE320
	public FloroRanchSkill? GetFloroRanchSkillConfig(int id)
	{
		FloroRanchSkill? config = ConfigFloroRanchSkillById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchSkill表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE53 RID: 52819 RVA: 0x002F0178 File Offset: 0x002EE378
	public IReadOnlyList<FloroRanchSkill> GetFloroRanchSkillConfigList()
	{
		IReadOnlyList<FloroRanchSkill> configList = ConfigFloroRanchSkillAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchSkill表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchSkill>();
		}
		return configList;
	}

	// Token: 0x0600CE54 RID: 52820 RVA: 0x002F01B8 File Offset: 0x002EE3B8
	public IReadOnlyList<FloroRanchTech> GetFloroRanchTechnologyConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchTech> configList = ConfigFloroRanchTechByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTech表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchTech>();
		}
		return configList;
	}

	// Token: 0x0600CE55 RID: 52821 RVA: 0x002F0208 File Offset: 0x002EE408
	public IReadOnlyList<FloroRanchTask> GetFloroRanchTaskConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchTask> configList = ConfigFloroRanchTaskByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTask表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchTask>();
		}
		return configList;
	}

	// Token: 0x0600CE56 RID: 52822 RVA: 0x002F0258 File Offset: 0x002EE458
	public IReadOnlyList<FloroRanchReward> GetFloroRanchRewardConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchReward> configList = ConfigFloroRanchRewardByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchReward表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchReward>();
		}
		return configList;
	}

	// Token: 0x0600CE57 RID: 52823 RVA: 0x002F02A8 File Offset: 0x002EE4A8
	public IReadOnlyList<FloroRanchFilterType> GetFloroRanchFilterTypeConfigList()
	{
		IReadOnlyList<FloroRanchFilterType> configList = ConfigFloroRanchFilterTypeAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.LRC, "FloroRanchFilterType表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchFilterType>();
		}
		return configList;
	}

	// Token: 0x0600CE58 RID: 52824 RVA: 0x002F02E8 File Offset: 0x002EE4E8
	public IReadOnlyList<FloroRanchCardGroup> GetFloroRanchCardGroupConfigList()
	{
		IReadOnlyList<FloroRanchCardGroup> configList = ConfigFloroRanchCardGroupAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchCardGroup表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchCardGroup>();
		}
		return configList;
	}

	// Token: 0x0600CE59 RID: 52825 RVA: 0x002F0328 File Offset: 0x002EE528
	public IReadOnlyList<FloroRanchCurrency> GetFloroRanchCurrencyConfigList()
	{
		IReadOnlyList<FloroRanchCurrency> configList = ConfigFloroRanchCurrencyAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.LRC, "FloroRanchCurrency表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchCurrency>();
		}
		return configList;
	}

	// Token: 0x0600CE5A RID: 52826 RVA: 0x002F0368 File Offset: 0x002EE568
	public FloroRanchBuff? GetFloroRanchBuffById(int id)
	{
		FloroRanchBuff? config = ConfigFloroRanchBuffById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchBuff表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE5B RID: 52827 RVA: 0x002F03C0 File Offset: 0x002EE5C0
	public FloroRanchWeeklyEvent? GetFloroRanchWeeklyEventById(int id)
	{
		FloroRanchWeeklyEvent? config = ConfigFloroRanchWeeklyEventById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchWeeklyEvent表获取失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE5C RID: 52828 RVA: 0x002F0418 File Offset: 0x002EE618
	public FloroRanchWeeklyChoice? GetFloroRanchWeeklyChoiceById(int id)
	{
		FloroRanchWeeklyChoice? config = ConfigFloroRanchWeeklyChoiceById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchWeeklyChoice表获取失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE5D RID: 52829 RVA: 0x002F0470 File Offset: 0x002EE670
	public IReadOnlyList<FloroRanchAudio> GetFloroRanchAudioConfigList()
	{
		IReadOnlyList<FloroRanchAudio> configList = ConfigFloroRanchAudioAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchAudio表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchAudio>();
		}
		return configList;
	}

	// Token: 0x0600CE5E RID: 52830 RVA: 0x002F04B0 File Offset: 0x002EE6B0
	public IReadOnlyList<FloroRanchTaskTab> GetFloroRanchTaskTabConfigList()
	{
		IReadOnlyList<FloroRanchTaskTab> configList = ConfigFloroRanchTaskTabAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.CXJ, "FloroRanchTaskTab表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchTaskTab>();
		}
		return configList;
	}

	// Token: 0x0600CE5F RID: 52831 RVA: 0x002F04F0 File Offset: 0x002EE6F0
	public FloroRanchTag? GetFloroRanchTagConfig(int tagId)
	{
		FloroRanchTag? config = ConfigFloroRanchTagById.GetConfig(tagId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTag表无效tagId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", tagId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600CE60 RID: 52832 RVA: 0x002F0548 File Offset: 0x002EE748
	public FloroRanchAction? GetFloroRanchActionConfig(int actionId)
	{
		FloroRanchAction? config = ConfigFloroRanchActionById.GetConfig(actionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchAction表无效actionId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", actionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x17001137 RID: 4407
	// (get) Token: 0x0600CE61 RID: 52833 RVA: 0x002F05A0 File Offset: 0x002EE7A0
	public static FloroRanchConfig Instance
	{
		get
		{
			return FloroRanchConfig._Instance;
		}
	}

	// Token: 0x0600CE62 RID: 52834 RVA: 0x002F05A7 File Offset: 0x002EE7A7
	public static FloroRanchConfig GetOrCreateInstance()
	{
		if (FloroRanchConfig._Instance == null)
		{
			FloroRanchConfig.CreateInstance();
		}
		return FloroRanchConfig._Instance;
	}

	// Token: 0x0600CE63 RID: 52835 RVA: 0x002F05BB File Offset: 0x002EE7BB
	public static bool CreateInstance()
	{
		if (FloroRanchConfig._Instance != null)
		{
			return true;
		}
		FloroRanchConfig._Instance = new FloroRanchConfig();
		return true;
	}

	// Token: 0x0600CE64 RID: 52836 RVA: 0x002F05D1 File Offset: 0x002EE7D1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CE65 RID: 52837 RVA: 0x002F05D3 File Offset: 0x002EE7D3
	public static void ResetStaticDefaultValue()
	{
		FloroRanchConfig._Instance = null;
	}

	// Token: 0x0600CE66 RID: 52838 RVA: 0x002F05DB File Offset: 0x002EE7DB
	static FloroRanchConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchConfig.CreateStaticDefaultValue), new Action(FloroRanchConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005E91 RID: 24209
	[Nullable(2)]
	private static FloroRanchConfig _Instance;
}
