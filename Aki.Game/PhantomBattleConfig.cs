using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

// Token: 0x020018E8 RID: 6376
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PhantomBattleConfig : ConfigBase
{
	// Token: 0x0600FBC7 RID: 64455 RVA: 0x00499F3B File Offset: 0x0049813B
	public PhantomBattleConfig()
	{
		this.TrialPhantomPropMap = new Dictionary<int, TrailPhantomProp>();
	}

	// Token: 0x0600FBC8 RID: 64456 RVA: 0x00499F50 File Offset: 0x00498150
	public IReadOnlyList<PhantomItem> GetPhantomItemList()
	{
		IReadOnlyList<PhantomItem> configList = ConfigPhantomItemAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "获取幻象道具配置列表失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x0600FBC9 RID: 64457 RVA: 0x00499F84 File Offset: 0x00498184
	public PhantomItem? GetPhantomItemById(int id)
	{
		PhantomItem? config = ConfigPhantomItemByItemId.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象道具配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return new PhantomItem?(config.Value);
	}

	// Token: 0x0600FBCA RID: 64458 RVA: 0x00499FDA File Offset: 0x004981DA
	[NullableContext(2)]
	public IReadOnlyList<PhantomItem> GetPhantomItemByMonsterId(int monsterId)
	{
		return ConfigPhantomItemByMonsterId.GetConfigList(monsterId, true);
	}

	// Token: 0x0600FBCB RID: 64459 RVA: 0x00499FE3 File Offset: 0x004981E3
	[NullableContext(2)]
	public IReadOnlyList<PhantomItem> GetPhantomItemByParentMonsterId(int parentMonsterId)
	{
		return ConfigPhantomItemByParentMonsterId.GetConfigList(parentMonsterId, true);
	}

	// Token: 0x0600FBCC RID: 64460 RVA: 0x00499FEC File Offset: 0x004981EC
	public IReadOnlyList<PhantomSkill> GetPhantomSkillList(int skillId)
	{
		IReadOnlyList<PhantomSkill> configList = ConfigPhantomSkillByPhantomSkillId.GetConfigList(skillId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象技能配置列表失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return configList;
	}

	// Token: 0x0600FBCD RID: 64461 RVA: 0x0049A030 File Offset: 0x00498230
	public string[] GetPhantomSkillDescExByPhantomSkillIdAndQuality(int phantomSkillId, int quality = 2)
	{
		PhantomSkill phantomSkill = ConfigPhantomSkillByPhantomSkillId.GetConfigList(phantomSkillId, true)[0];
		int levelDescStrArrayLength = phantomSkill.LevelDescStrArrayLength;
		int j;
		if (quality > levelDescStrArrayLength)
		{
			j = levelDescStrArrayLength - 1;
		}
		else
		{
			j = quality - 1;
		}
		StringArray? stringArray = phantomSkill.LevelDescStrArray(j);
		if (stringArray != null)
		{
			StringArray value = stringArray.Value;
			int arrayStringLength = value.ArrayStringLength;
			string[] array = new string[arrayStringLength];
			for (int i = 0; i < arrayStringLength; i++)
			{
				array[i] = value.ArrayString(i);
			}
			return array;
		}
		return new string[0];
	}

	// Token: 0x0600FBCE RID: 64462 RVA: 0x0049A0B8 File Offset: 0x004982B8
	public string[] GetPhantomSkillDescExBySkillIdAndQuality(int skillId, int quality = 2)
	{
		PhantomSkill value = ConfigPhantomSkillById.GetConfig(skillId, true).Value;
		int levelDescStrArrayLength = value.LevelDescStrArrayLength;
		int j;
		if (quality > levelDescStrArrayLength)
		{
			j = levelDescStrArrayLength - 1;
		}
		else
		{
			j = quality - 1;
		}
		StringArray? stringArray = value.LevelDescStrArray(j);
		if (stringArray != null)
		{
			StringArray value2 = stringArray.Value;
			int arrayStringLength = value2.ArrayStringLength;
			string[] array = new string[arrayStringLength];
			for (int i = 0; i < arrayStringLength; i++)
			{
				array[i] = value2.ArrayString(i);
			}
			return array;
		}
		return new string[0];
	}

	// Token: 0x0600FBCF RID: 64463 RVA: 0x0049A144 File Offset: 0x00498344
	public string GetPhantomSkillDescStringBySkillIdAndQuality(int skillId, int quality = 2)
	{
		string[] phantomSkillDescExBySkillIdAndQuality = this.GetPhantomSkillDescExBySkillIdAndQuality(skillId, quality);
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(ConfigPhantomSkillById.GetConfig(skillId, true).Value.DescriptionEx, null), phantomSkillDescExBySkillIdAndQuality);
	}

	// Token: 0x0600FBD0 RID: 64464 RVA: 0x0049A180 File Offset: 0x00498380
	public PhantomSkill? GetPhantomSkillBySkillId(int skillId)
	{
		IReadOnlyList<PhantomSkill> configList = ConfigPhantomSkillByPhantomSkillId.GetConfigList(skillId, true);
		if (configList == null || configList.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象技能配置失败, 请检查配置表, 也可能是探索技能";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SkillId", skillId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new PhantomSkill?(configList[0]);
	}

	// Token: 0x0600FBD1 RID: 64465 RVA: 0x0049A1E2 File Offset: 0x004983E2
	public PhantomRarity? GetPhantomRareConfig(int rareId)
	{
		return ConfigPhantomRarityByRare.GetConfig(rareId, true);
	}

	// Token: 0x0600FBD2 RID: 64466 RVA: 0x0049A1EC File Offset: 0x004983EC
	[NullableContext(2)]
	public IReadOnlyList<PhantomRarity> GetPhantomRareConfigAll()
	{
		IReadOnlyList<PhantomRarity> configList = ConfigPhantomRarityAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.WDX, "获取幻象洗炼材料配置失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x0600FBD3 RID: 64467 RVA: 0x0049A220 File Offset: 0x00498420
	[NullableContext(2)]
	public IReadOnlyList<PhantomVicePolishConfig> GetPhantomVicePolishConfigAll()
	{
		IReadOnlyList<PhantomVicePolishConfig> configList = ConfigPhantomVicePolishConfigAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.WDX, "获取幻象辅音洗炼材料配置失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x0600FBD4 RID: 64468 RVA: 0x0049A254 File Offset: 0x00498454
	public PhantomQuality? GetPhantomQualityByItemQuality(int itemQuality)
	{
		PhantomQuality? config = ConfigPhantomQualityByQuality.GetConfig(itemQuality, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象品质配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", itemQuality);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0600FBD5 RID: 64469 RVA: 0x0049A2A0 File Offset: 0x004984A0
	public PhantomMainProperty? GetPhantomMainPropertyById(int id)
	{
		PhantomMainProperty? config = ConfigPhantomMainPropertyById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象主属性配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0600FBD6 RID: 64470 RVA: 0x0049A2EC File Offset: 0x004984EC
	[NullableContext(2)]
	public IReadOnlyList<PhantomMainProperty> GetPhantomMainPropertyByRandGroupId(int randGroupId)
	{
		IReadOnlyList<PhantomMainProperty> configList = ConfigPhantomMainPropertyByRandGroupId.GetConfigList(randGroupId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "获取幻象主属性方案组失败, 请检查配表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", randGroupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return configList;
	}

	// Token: 0x0600FBD7 RID: 64471 RVA: 0x0049A334 File Offset: 0x00498534
	public PhantomMainPropItem GetPhantomMainPropertyItemId(int id)
	{
		PhantomMainPropItem? config = ConfigPhantomMainPropItemById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象主属性配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600FBD8 RID: 64472 RVA: 0x0049A388 File Offset: 0x00498588
	public PhantomSubProperty GetPhantomSubPropertyById(int id)
	{
		PhantomSubProperty? config = ConfigPhantomSubPropertyById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象属性配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600FBD9 RID: 64473 RVA: 0x0049A3DC File Offset: 0x004985DC
	public IReadOnlyList<PhantomFetter> GetPhantomFetterList()
	{
		IReadOnlyList<PhantomFetter> configList = ConfigPhantomFetterAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "获取幻象羁绊配置列表失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x0600FBDA RID: 64474 RVA: 0x0049A410 File Offset: 0x00498610
	public IReadOnlyList<PhantomFetterGroup> GetPhantomFetterGroupList()
	{
		IReadOnlyList<PhantomFetterGroup> configList = ConfigPhantomFetterGroupAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "获取幻象羁绊配置列表失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x0600FBDB RID: 64475 RVA: 0x0049A444 File Offset: 0x00498644
	public PhantomFetter GetPhantomFetterById(int id)
	{
		PhantomFetter? config = ConfigPhantomFetterById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象羁绊配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600FBDC RID: 64476 RVA: 0x0049A498 File Offset: 0x00498698
	public unsafe int GetPhantomLevelExpByGroupIdAndLevel(int groupId, int level)
	{
		PhantomLevel? config = ConfigPhantomLevelByGroupIdAndLevel.GetConfig(groupId, level, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象升级消耗配置失败, 请检查配置表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("groupId", groupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", level);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config.Value.Exp;
	}

	// Token: 0x0600FBDD RID: 64477 RVA: 0x0049A524 File Offset: 0x00498724
	public IReadOnlyList<PhantomLevel> GetPhantomLevelListByGroupId(int groupId)
	{
		IReadOnlyList<PhantomLevel> configList = ConfigPhantomLevelByGroupId.GetConfigList(groupId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象升级消耗配置列表失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("groupId", groupId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return configList;
	}

	// Token: 0x0600FBDE RID: 64478 RVA: 0x0049A568 File Offset: 0x00498768
	public ItemInfo GetItemInfoById(int itemId)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取道具配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600FBDF RID: 64479 RVA: 0x0049A5BC File Offset: 0x004987BC
	public PhantomExpItem GetPhantomExpItemById(int itemId)
	{
		PhantomExpItem? config = ConfigPhantomExpItemByItemId.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象经验道具配置失败, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600FBE0 RID: 64480 RVA: 0x0049A60D File Offset: 0x0049880D
	[NullableContext(2)]
	public IReadOnlyList<PhantomExpItem> GetPhantomExpItemList()
	{
		return ConfigPhantomExpItemAll.GetConfigList(true);
	}

	// Token: 0x0600FBE1 RID: 64481 RVA: 0x0049A615 File Offset: 0x00498815
	[NullableContext(2)]
	public IReadOnlyList<PhantomWildItem> GetPhantomWildItem()
	{
		return ConfigPhantomWildItemAll.GetConfigList(true);
	}

	// Token: 0x0600FBE2 RID: 64482 RVA: 0x0049A620 File Offset: 0x00498820
	public unsafe int GetPhantomGrowthValueByGrowthIdAndLevel(int growthId, int level)
	{
		PhantomGrowth? config = ConfigPhantomGrowthByGrowthIdAndLevel.GetConfig(growthId, level, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取幻象成长曲线值配置失败, 请检查配置表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("growthId", growthId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", level);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config.Value.Value;
	}

	// Token: 0x0600FBE3 RID: 64483 RVA: 0x0049A6AB File Offset: 0x004988AB
	[NullableContext(2)]
	public IReadOnlyList<PhantomSubProperty> GetPhantomSubPropertyByPropId(int propId)
	{
		return ConfigPhantomSubPropertyByPropId.GetConfigList(propId, true);
	}

	// Token: 0x0600FBE4 RID: 64484 RVA: 0x0049A6B4 File Offset: 0x004988B4
	public float GetPhantomLevelUpCostRatio()
	{
		return (float)ConfigCommonParamById.GetIntConfig("PhantomLevelUpCoinCost").Value / 1000f;
	}

	// Token: 0x0600FBE5 RID: 64485 RVA: 0x0049A6DC File Offset: 0x004988DC
	public ConfigPropValue GetTrailPhantomPropItemById(int id)
	{
		TrialPhantomPropItem? config = ConfigTrialPhantomPropItemById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "获取configTrialPhantomPropItemById, 请检查配置表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value.Prop.Value;
	}

	// Token: 0x0600FBE6 RID: 64486 RVA: 0x0049A740 File Offset: 0x00498940
	public int GetQualityIdentifyCost(int quality)
	{
		return this.GetPhantomQualityByItemQuality(quality).Value.IdentifyCoin;
	}

	// Token: 0x0600FBE7 RID: 64487 RVA: 0x0049A764 File Offset: 0x00498964
	public PhantomFetterGroup GetFetterGroupById(int groupId)
	{
		return ConfigPhantomFetterGroupById.GetConfig(groupId, true).Value;
	}

	// Token: 0x0600FBE8 RID: 64488 RVA: 0x0049A780 File Offset: 0x00498980
	public int GetFetterGroupMaxCountById(int groupId)
	{
		PhantomFetterGroup fetterGroupById = this.GetFetterGroupById(groupId);
		int fetterMapLength = fetterGroupById.FetterMapLength;
		int num = 0;
		for (int i = 0; i < fetterMapLength; i++)
		{
			int key = fetterGroupById.FetterMap(i).Value.Key;
			if (key > num)
			{
				num = key;
			}
		}
		return num;
	}

	// Token: 0x0600FBE9 RID: 64489 RVA: 0x0049A7D0 File Offset: 0x004989D0
	public Dictionary<int, int> GetFetterGroupFetterDataById(int groupId)
	{
		return ConfigPhantomFetterGroupById.GetConfig(groupId, true).Value.FetterMap();
	}

	// Token: 0x0600FBEA RID: 64490 RVA: 0x0049A7F4 File Offset: 0x004989F4
	[NullableContext(2)]
	public IReadOnlyList<PhantomFetterGroup> GetFetterGroupArray()
	{
		return ConfigPhantomFetterGroupAll.GetConfigList(true);
	}

	// Token: 0x0600FBEB RID: 64491 RVA: 0x0049A7FC File Offset: 0x004989FC
	public int[] GetFetterGroupSourceMonster(int groupId)
	{
		IEnumerable<PhantomItem> phantomItemList = this.GetPhantomItemList();
		List<int> list = new List<int>();
		foreach (PhantomItem phantomItem in phantomItemList)
		{
			if (phantomItem.PhantomType == 1 && phantomItem.ParentMonsterId == 0 && Array.IndexOf<int>(phantomItem.FetterGroup(), groupId) >= 0)
			{
				list.Add(phantomItem.MonsterId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FBEC RID: 64492 RVA: 0x0049A880 File Offset: 0x00498A80
	public Dictionary<int, Dictionary<int, int>> GetFetterMapResultBySuitMap(Dictionary<int, int> suitMap)
	{
		Dictionary<int, Dictionary<int, int>> dictionary = new Dictionary<int, Dictionary<int, int>>();
		foreach (KeyValuePair<int, int> keyValuePair in suitMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			PhantomFetterGroup? config = ConfigPhantomFetterGroupById.GetConfig(key, true);
			int fetterMapLength = config.Value.FetterMapLength;
			int num = 0;
			int value2 = 0;
			Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
			for (int i = 0; i < fetterMapLength; i++)
			{
				DicIntInt? dicIntInt = config.Value.FetterMap(i);
				int key2 = dicIntInt.Value.Key;
				int value3 = dicIntInt.Value.Value;
				if (value >= key2)
				{
					num = value3;
					value2 = key2;
				}
				if (num > 0)
				{
					dictionary2[num] = value2;
				}
			}
			if (dictionary2.Count > 0)
			{
				dictionary[key] = dictionary2;
			}
		}
		return dictionary;
	}

	// Token: 0x0600FBED RID: 64493 RVA: 0x0049A988 File Offset: 0x00498B88
	public List<int> GetFetterResultBySuitMap(Dictionary<int, int> suitMap)
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> keyValuePair in suitMap)
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			PhantomFetterGroup? config = ConfigPhantomFetterGroupById.GetConfig(key, true);
			int fetterMapLength = config.Value.FetterMapLength;
			int num = 0;
			for (int i = 0; i < fetterMapLength; i++)
			{
				DicIntInt? dicIntInt = config.Value.FetterMap(i);
				int key2 = dicIntInt.Value.Key;
				int value2 = dicIntInt.Value.Value;
				if (value >= key2)
				{
					num = value2;
				}
			}
			if (num > 0)
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0600FBEE RID: 64494 RVA: 0x0049AA68 File Offset: 0x00498C68
	public string GetPhantomQualityBgSprite(int quality)
	{
		if (quality == 0)
		{
			return ConfigCommonParamById.GetStringConfig("VisionQualityDefaultSprite");
		}
		return this.GetPhantomQualityByItemQuality(quality).Value.QualitySprite;
	}

	// Token: 0x0600FBEF RID: 64495 RVA: 0x0049AA9C File Offset: 0x00498C9C
	public int[] GetPhantomSlotUnlockLevel(int quality)
	{
		return this.GetPhantomQualityByItemQuality(quality).Value.GetSlotUnlockLevelBytes().ToArray();
	}

	// Token: 0x0600FBF0 RID: 64496 RVA: 0x0049AAC8 File Offset: 0x00498CC8
	public Dictionary<int, int> GetPhantomIdentifyCost(int quality)
	{
		return this.GetPhantomQualityByItemQuality(quality).Value.IdentifyCost();
	}

	// Token: 0x0600FBF1 RID: 64497 RVA: 0x0049AAEC File Offset: 0x00498CEC
	public string GetMonsterIdName(int monsterId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetPhantomItemByMonsterId(monsterId)[0].MonsterName, null);
	}

	// Token: 0x0600FBF2 RID: 64498 RVA: 0x0049AB14 File Offset: 0x00498D14
	public string GetFetterNameByFetterNameId(string fetterNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(fetterNameId, null);
	}

	// Token: 0x0600FBF3 RID: 64499 RVA: 0x0049AB1D File Offset: 0x00498D1D
	public IReadOnlyList<PhantomManagePlanV2> GetPhantomManagerPlanByFetterId(int fetterId)
	{
		return ConfigPhantomManagePlanV2ByFetterId.GetConfigList(fetterId, true) ?? Array.Empty<PhantomManagePlanV2>();
	}

	// Token: 0x0600FBF4 RID: 64500 RVA: 0x0049AB2F File Offset: 0x00498D2F
	public IReadOnlyList<PhantomManagePlanV2> GetPhantomManagerPlanAll()
	{
		return ConfigPhantomManagePlanV2All.GetConfigList(true) ?? Array.Empty<PhantomManagePlanV2>();
	}

	// Token: 0x0600FBF5 RID: 64501 RVA: 0x0049AB40 File Offset: 0x00498D40
	public int GetPhantomManagerShareCodeMax()
	{
		return ConfigCommonParamById.GetIntConfig("PhBaPlanCodeMaxCount").GetValueOrDefault(30);
	}

	// Token: 0x0600FBF6 RID: 64502 RVA: 0x0049AB64 File Offset: 0x00498D64
	public int GetPhantomManagerShareCodeMin()
	{
		return ConfigCommonParamById.GetIntConfig("PhBaPlanCodeMinCount").GetValueOrDefault(20);
	}

	// Token: 0x0600FBF7 RID: 64503 RVA: 0x0049AB85 File Offset: 0x00498D85
	public TrailPhantomProp? GetTrialPhantomPropConfig(int id)
	{
		return ConfigTrailPhantomPropById.GetConfig(id, true);
	}

	// Token: 0x0600FBF8 RID: 64504 RVA: 0x0049AB90 File Offset: 0x00498D90
	public int GetVisionLevelUpQualityLimit()
	{
		return ConfigCommonParamById.GetIntConfig("VisionHighQuality").Value;
	}

	// Token: 0x0600FBF9 RID: 64505 RVA: 0x0049ABB0 File Offset: 0x00498DB0
	public int GetVisionLevelUpRareLimit()
	{
		return ConfigCommonParamById.GetIntConfig("VisionHighRare").Value;
	}

	// Token: 0x0600FBFA RID: 64506 RVA: 0x0049ABD0 File Offset: 0x00498DD0
	public int GetVisionLevelUpLevelLimit()
	{
		return ConfigCommonParamById.GetIntConfig("VisionHighLevel").Value;
	}

	// Token: 0x0600FBFB RID: 64507 RVA: 0x0049ABF0 File Offset: 0x00498DF0
	public int GetVisionScrollerMoveDistance()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerMoveDistance").Value;
	}

	// Token: 0x0600FBFC RID: 64508 RVA: 0x0049AC10 File Offset: 0x00498E10
	public int GetVisionScrollerPressTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerLongPressTime").Value;
	}

	// Token: 0x0600FBFD RID: 64509 RVA: 0x0049AC30 File Offset: 0x00498E30
	public int GetVisionBeforeScrollerLongPressTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionBeforeScrollerLongPressTime").Value;
	}

	// Token: 0x0600FBFE RID: 64510 RVA: 0x0049AC50 File Offset: 0x00498E50
	public float GetVisionScrollerOffsetX()
	{
		if (!Info.Instance.IsInTouch())
		{
			return 0f;
		}
		return ConfigCommonParamById.GetFloatConfig("VisionScrollerOffsetX").Value;
	}

	// Token: 0x0600FBFF RID: 64511 RVA: 0x0049AC84 File Offset: 0x00498E84
	public float GetVisionScrollerOffsetY()
	{
		if (!Info.Instance.IsInTouch())
		{
			return 0f;
		}
		return ConfigCommonParamById.GetFloatConfig("VisionScrollerOffsetY").Value;
	}

	// Token: 0x0600FC00 RID: 64512 RVA: 0x0049ACB8 File Offset: 0x00498EB8
	public int GetVisionScrollerOffsetXDir()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerOffsetXDir").Value;
	}

	// Token: 0x0600FC01 RID: 64513 RVA: 0x0049ACD8 File Offset: 0x00498ED8
	public int GetVisionScrollerOffsetYDir()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerOffsetYDir").Value;
	}

	// Token: 0x0600FC02 RID: 64514 RVA: 0x0049ACF7 File Offset: 0x00498EF7
	public string GetVisionDragCurve()
	{
		return ConfigCommonParamById.GetStringConfig("VisionDragCurve");
	}

	// Token: 0x0600FC03 RID: 64515 RVA: 0x0049AD04 File Offset: 0x00498F04
	public int GetVisionDragCurveTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionDragAnimationTime").Value;
	}

	// Token: 0x0600FC04 RID: 64516 RVA: 0x0049AD23 File Offset: 0x00498F23
	public string GetFilterOwnTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteOwn");
	}

	// Token: 0x0600FC05 RID: 64517 RVA: 0x0049AD2F File Offset: 0x00498F2F
	public string GetFilterNotOwnTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteNotOwn");
	}

	// Token: 0x0600FC06 RID: 64518 RVA: 0x0049AD3B File Offset: 0x00498F3B
	public string GetFilterEquipTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteEquipped");
	}

	// Token: 0x0600FC07 RID: 64519 RVA: 0x0049AD47 File Offset: 0x00498F47
	public string GetFilterNoEquipTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteNotEquipped");
	}

	// Token: 0x0600FC08 RID: 64520 RVA: 0x0049AD53 File Offset: 0x00498F53
	public string GetVisionLevelUpTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionLevelUpUnlockTexture");
	}

	// Token: 0x0600FC09 RID: 64521 RVA: 0x0049AD5F File Offset: 0x00498F5F
	public string GetVisionHeadSprBgB()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadSprBgB");
	}

	// Token: 0x0600FC0A RID: 64522 RVA: 0x0049AD6B File Offset: 0x00498F6B
	public string GetVisionHeadSprBgA()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadSprBgA");
	}

	// Token: 0x0600FC0B RID: 64523 RVA: 0x0049AD77 File Offset: 0x00498F77
	public string GetVisionHeadLightBgA()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadLightBgA");
	}

	// Token: 0x0600FC0C RID: 64524 RVA: 0x0049AD83 File Offset: 0x00498F83
	public string GetVisionHeadLightBgB()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadLightBgB");
	}

	// Token: 0x0600FC0D RID: 64525 RVA: 0x0049AD8F File Offset: 0x00498F8F
	public string GetVisionMainRoleHeadSprBgA()
	{
		return ConfigCommonParamById.GetStringConfig("VisionMainRoleHeadSprBgA");
	}

	// Token: 0x0600FC0E RID: 64526 RVA: 0x0049AD9B File Offset: 0x00498F9B
	public string GetVisionMainRoleHeadSprBgB()
	{
		return ConfigCommonParamById.GetStringConfig("VisionMainRoleHeadSprBgB");
	}

	// Token: 0x0600FC0F RID: 64527 RVA: 0x0049ADA7 File Offset: 0x00498FA7
	public string GetVisionMainRoleHeadFrameBgA()
	{
		return ConfigCommonParamById.GetStringConfig("VisionMainRoleHeadFrameBgA");
	}

	// Token: 0x0600FC10 RID: 64528 RVA: 0x0049ADB3 File Offset: 0x00498FB3
	public string GetVisionMainRoleHeadFrameBgB()
	{
		return ConfigCommonParamById.GetStringConfig("VisionMainRoleHeadFrameBgB");
	}

	// Token: 0x0600FC11 RID: 64529 RVA: 0x0049ADC0 File Offset: 0x00498FC0
	public int GetVisionReachableCostMax()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomTotalCost").Value;
	}

	// Token: 0x0600FC12 RID: 64530 RVA: 0x0049ADDF File Offset: 0x00498FDF
	public string GetVisionFetterDefaultColor()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFetterDefaultColor");
	}

	// Token: 0x0600FC13 RID: 64531 RVA: 0x0049ADEB File Offset: 0x00498FEB
	public string GetVisionFetterDefaultTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFetterDefaultTexture");
	}

	// Token: 0x0600FC14 RID: 64532 RVA: 0x0049ADF8 File Offset: 0x00498FF8
	public int GetVisionLevelUpDelay()
	{
		return ConfigCommonParamById.GetIntConfig("VisionLevelUpDelay").Value;
	}

	// Token: 0x0600FC15 RID: 64533 RVA: 0x0049AE18 File Offset: 0x00499018
	public int GetVisionIdentifyDelay()
	{
		return ConfigCommonParamById.GetIntConfig("VisionIdentifyDelay").Value;
	}

	// Token: 0x0600FC16 RID: 64534 RVA: 0x0049AE37 File Offset: 0x00499037
	public string GetVisionCostColorBase()
	{
		return ConfigCommonParamById.GetStringConfig("VisionCostColorBase");
	}

	// Token: 0x0600FC17 RID: 64535 RVA: 0x0049AE43 File Offset: 0x00499043
	public string GetVisionCostColorFull()
	{
		return ConfigCommonParamById.GetStringConfig("VisionCostColorFull");
	}

	// Token: 0x0600FC18 RID: 64536 RVA: 0x0049AE4F File Offset: 0x0049904F
	public string GetVisionCostColorAlert()
	{
		return ConfigCommonParamById.GetStringConfig("VisionCostColorAlert");
	}

	// Token: 0x0600FC19 RID: 64537 RVA: 0x0049AE5C File Offset: 0x0049905C
	public int GetVisionIdentifyAnimationTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionIdentifyAnimationTime").Value;
	}

	// Token: 0x0600FC1A RID: 64538 RVA: 0x0049AE7C File Offset: 0x0049907C
	public int[] GetVisionMainAttributeSortArray()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainAttributeSortArray");
		int[] array = new int[intArrayConfig.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = intArrayConfig[i];
		}
		return array;
	}

	// Token: 0x0600FC1B RID: 64539 RVA: 0x0049AEBC File Offset: 0x004990BC
	public int[] GetVisionMainPercentageAttributeSortArray()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainPercentageAttributeSortArray");
		int[] array = new int[intArrayConfig.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = intArrayConfig[i];
		}
		return array;
	}

	// Token: 0x0600FC1C RID: 64540 RVA: 0x0049AEFC File Offset: 0x004990FC
	public int[] GetVisionSubAttributeSortArray()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionSubAttributeSortArray");
		int[] array = new int[intArrayConfig.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = intArrayConfig[i];
		}
		return array;
	}

	// Token: 0x0600FC1D RID: 64541 RVA: 0x0049AF3C File Offset: 0x0049913C
	public int[] GetVisionSubPercentageAttributeSortArray()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionSubPercentageAttributeSortArray");
		int[] array = new int[intArrayConfig.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = intArrayConfig[i];
		}
		return array;
	}

	// Token: 0x0600FC1E RID: 64542 RVA: 0x0049AF79 File Offset: 0x00499179
	public string GetVisionDestroyCostSpriteByCost(int cost)
	{
		if (cost == 1)
		{
			return this.GetVisionDestroyCost1();
		}
		if (cost == 3)
		{
			return this.GetVisionDestroyCost3();
		}
		return this.GetVisionDestroyCost4();
	}

	// Token: 0x0600FC1F RID: 64543 RVA: 0x0049AF97 File Offset: 0x00499197
	public string GetVisionDestroyCost1()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteCost1");
	}

	// Token: 0x0600FC20 RID: 64544 RVA: 0x0049AFA3 File Offset: 0x004991A3
	public string GetVisionDestroyCost3()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteCost3");
	}

	// Token: 0x0600FC21 RID: 64545 RVA: 0x0049AFAF File Offset: 0x004991AF
	public string GetVisionDestroyCost4()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteCost4");
	}

	// Token: 0x0600FC22 RID: 64546 RVA: 0x0049AFBB File Offset: 0x004991BB
	public string GetVisionRecoveryUnDesperateIcon()
	{
		return ConfigCommonParamById.GetStringConfig("VisionRecoveryUnDesperate");
	}

	// Token: 0x0600FC23 RID: 64547 RVA: 0x0049AFC7 File Offset: 0x004991C7
	public string GetVisionRecoveryDesperateIcon()
	{
		return ConfigCommonParamById.GetStringConfig("VisionRecoveryDesperate");
	}

	// Token: 0x0600FC24 RID: 64548 RVA: 0x0049AFD4 File Offset: 0x004991D4
	public int GetVisionRecommendRuleLevel()
	{
		return ConfigCommonParamById.GetIntConfig("VisionRecommendRuleLevel").Value;
	}

	// Token: 0x0600FC25 RID: 64549 RVA: 0x0049AFF4 File Offset: 0x004991F4
	public int GetPhantomEquipGroupCountMax()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomEquipGroupCount").Value;
	}

	// Token: 0x0600FC26 RID: 64550 RVA: 0x0049B014 File Offset: 0x00499214
	public int GetPhantomEquipHelpGroupId()
	{
		return ConfigCommonParamById.GetIntConfig("VisionEquipHelpGroupId").Value;
	}

	// Token: 0x0600FC27 RID: 64551 RVA: 0x0049B034 File Offset: 0x00499234
	public int GetPhantomRecommendHelpGroupId()
	{
		return ConfigCommonParamById.GetIntConfig("VisionRecommendHelpId").Value;
	}

	// Token: 0x0600FC28 RID: 64552 RVA: 0x0049B054 File Offset: 0x00499254
	public int[] GetVisionAttrSortArray()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("VisionMainViewExtraAttributeForPreset");
		int[] array = new int[intArrayConfig.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = intArrayConfig[i];
		}
		return array;
	}

	// Token: 0x0600FC29 RID: 64553 RVA: 0x0049B091 File Offset: 0x00499291
	public PhantomVicePolishConfig? GetPhantomVicePolishCostByLockCount(int count)
	{
		return ConfigPhantomVicePolishConfigByPropCount.GetConfig(count, true);
	}

	// Token: 0x0600FC2A RID: 64554 RVA: 0x0049B09C File Offset: 0x0049929C
	public int GetPhantomSharedCodeCd()
	{
		return ConfigCommonParamById.GetIntConfig("PhBaPlanCodeShareCheckCD").GetValueOrDefault(30);
	}

	// Token: 0x0600FC2B RID: 64555 RVA: 0x0049B0BD File Offset: 0x004992BD
	protected override bool OnClear()
	{
		this.TrialPhantomPropMap.Clear();
		return true;
	}

	// Token: 0x17001818 RID: 6168
	// (get) Token: 0x0600FC2C RID: 64556 RVA: 0x0049B0CB File Offset: 0x004992CB
	public static PhantomBattleConfig Instance
	{
		get
		{
			return PhantomBattleConfig._Instance;
		}
	}

	// Token: 0x0600FC2D RID: 64557 RVA: 0x0049B0D2 File Offset: 0x004992D2
	public static PhantomBattleConfig GetOrCreateInstance()
	{
		if (PhantomBattleConfig._Instance == null)
		{
			PhantomBattleConfig.CreateInstance();
		}
		return PhantomBattleConfig._Instance;
	}

	// Token: 0x0600FC2E RID: 64558 RVA: 0x0049B0E6 File Offset: 0x004992E6
	public static bool CreateInstance()
	{
		if (PhantomBattleConfig._Instance != null)
		{
			return true;
		}
		PhantomBattleConfig._Instance = new PhantomBattleConfig();
		return true;
	}

	// Token: 0x0600FC2F RID: 64559 RVA: 0x0049B0FC File Offset: 0x004992FC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FC30 RID: 64560 RVA: 0x0049B0FE File Offset: 0x004992FE
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleConfig._Instance = null;
	}

	// Token: 0x0600FC31 RID: 64561 RVA: 0x0049B106 File Offset: 0x00499306
	static PhantomBattleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleConfig.CreateStaticDefaultValue), new Action(PhantomBattleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008CAF RID: 36015
	private readonly Dictionary<int, TrailPhantomProp> TrialPhantomPropMap;

	// Token: 0x04008CB0 RID: 36016
	[Nullable(2)]
	private static PhantomBattleConfig _Instance;
}
