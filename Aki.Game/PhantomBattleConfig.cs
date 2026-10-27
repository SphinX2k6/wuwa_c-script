using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

// Token: 0x02002403 RID: 9219
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PhantomBattleConfig : ConfigBase
{
	// Token: 0x06012715 RID: 75541 RVA: 0x0048CA2B File Offset: 0x0048AC2B
	public PhantomBattleConfig()
	{
		this.TrialPhantomPropMap = new Dictionary<int, TrailPhantomProp>();
	}

	// Token: 0x06012716 RID: 75542 RVA: 0x0048CA40 File Offset: 0x0048AC40
	public IReadOnlyList<PhantomItem> GetPhantomItemList()
	{
		IReadOnlyList<PhantomItem> configList = ConfigPhantomItemAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "获取幻象道具配置列表失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x06012717 RID: 75543 RVA: 0x0048CA74 File Offset: 0x0048AC74
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

	// Token: 0x06012718 RID: 75544 RVA: 0x0048CACA File Offset: 0x0048ACCA
	[NullableContext(2)]
	public IReadOnlyList<PhantomItem> GetPhantomItemByMonsterId(int monsterId)
	{
		return ConfigPhantomItemByMonsterId.GetConfigList(monsterId, true);
	}

	// Token: 0x06012719 RID: 75545 RVA: 0x0048CAD3 File Offset: 0x0048ACD3
	[NullableContext(2)]
	public IReadOnlyList<PhantomItem> GetPhantomItemByParentMonsterId(int parentMonsterId)
	{
		return ConfigPhantomItemByParentMonsterId.GetConfigList(parentMonsterId, true);
	}

	// Token: 0x0601271A RID: 75546 RVA: 0x0048CADC File Offset: 0x0048ACDC
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

	// Token: 0x0601271B RID: 75547 RVA: 0x0048CB20 File Offset: 0x0048AD20
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

	// Token: 0x0601271C RID: 75548 RVA: 0x0048CBA8 File Offset: 0x0048ADA8
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

	// Token: 0x0601271D RID: 75549 RVA: 0x0048CC34 File Offset: 0x0048AE34
	public string GetPhantomSkillDescStringBySkillIdAndQuality(int skillId, int quality = 2)
	{
		string[] phantomSkillDescExBySkillIdAndQuality = this.GetPhantomSkillDescExBySkillIdAndQuality(skillId, quality);
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(ConfigPhantomSkillById.GetConfig(skillId, true).Value.DescriptionEx, null), phantomSkillDescExBySkillIdAndQuality);
	}

	// Token: 0x0601271E RID: 75550 RVA: 0x0048CC70 File Offset: 0x0048AE70
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

	// Token: 0x0601271F RID: 75551 RVA: 0x0048CCD2 File Offset: 0x0048AED2
	public PhantomRarity? GetPhantomRareConfig(int rareId)
	{
		return ConfigPhantomRarityByRare.GetConfig(rareId, true);
	}

	// Token: 0x06012720 RID: 75552 RVA: 0x0048CCDC File Offset: 0x0048AEDC
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

	// Token: 0x06012721 RID: 75553 RVA: 0x0048CD10 File Offset: 0x0048AF10
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

	// Token: 0x06012722 RID: 75554 RVA: 0x0048CD44 File Offset: 0x0048AF44
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

	// Token: 0x06012723 RID: 75555 RVA: 0x0048CD90 File Offset: 0x0048AF90
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

	// Token: 0x06012724 RID: 75556 RVA: 0x0048CDDC File Offset: 0x0048AFDC
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

	// Token: 0x06012725 RID: 75557 RVA: 0x0048CE24 File Offset: 0x0048B024
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

	// Token: 0x06012726 RID: 75558 RVA: 0x0048CE78 File Offset: 0x0048B078
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

	// Token: 0x06012727 RID: 75559 RVA: 0x0048CECC File Offset: 0x0048B0CC
	public IReadOnlyList<PhantomFetter> GetPhantomFetterList()
	{
		IReadOnlyList<PhantomFetter> configList = ConfigPhantomFetterAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "获取幻象羁绊配置列表失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x06012728 RID: 75560 RVA: 0x0048CF00 File Offset: 0x0048B100
	public IReadOnlyList<PhantomFetterGroup> GetPhantomFetterGroupList()
	{
		IReadOnlyList<PhantomFetterGroup> configList = ConfigPhantomFetterGroupAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "获取幻象羁绊配置列表失败, 请检查配置表", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return configList;
	}

	// Token: 0x06012729 RID: 75561 RVA: 0x0048CF34 File Offset: 0x0048B134
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

	// Token: 0x0601272A RID: 75562 RVA: 0x0048CF88 File Offset: 0x0048B188
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

	// Token: 0x0601272B RID: 75563 RVA: 0x0048D014 File Offset: 0x0048B214
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

	// Token: 0x0601272C RID: 75564 RVA: 0x0048D058 File Offset: 0x0048B258
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

	// Token: 0x0601272D RID: 75565 RVA: 0x0048D0AC File Offset: 0x0048B2AC
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

	// Token: 0x0601272E RID: 75566 RVA: 0x0048D0FD File Offset: 0x0048B2FD
	[NullableContext(2)]
	public IReadOnlyList<PhantomExpItem> GetPhantomExpItemList()
	{
		return ConfigPhantomExpItemAll.GetConfigList(true);
	}

	// Token: 0x0601272F RID: 75567 RVA: 0x0048D105 File Offset: 0x0048B305
	[NullableContext(2)]
	public IReadOnlyList<PhantomWildItem> GetPhantomWildItem()
	{
		return ConfigPhantomWildItemAll.GetConfigList(true);
	}

	// Token: 0x06012730 RID: 75568 RVA: 0x0048D110 File Offset: 0x0048B310
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

	// Token: 0x06012731 RID: 75569 RVA: 0x0048D19B File Offset: 0x0048B39B
	[NullableContext(2)]
	public IReadOnlyList<PhantomSubProperty> GetPhantomSubPropertyByPropId(int propId)
	{
		return ConfigPhantomSubPropertyByPropId.GetConfigList(propId, true);
	}

	// Token: 0x06012732 RID: 75570 RVA: 0x0048D1A4 File Offset: 0x0048B3A4
	public float GetPhantomLevelUpCostRatio()
	{
		return (float)ConfigCommonParamById.GetIntConfig("PhantomLevelUpCoinCost").Value / 1000f;
	}

	// Token: 0x06012733 RID: 75571 RVA: 0x0048D1CC File Offset: 0x0048B3CC
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

	// Token: 0x06012734 RID: 75572 RVA: 0x0048D230 File Offset: 0x0048B430
	public int GetQualityIdentifyCost(int quality)
	{
		return this.GetPhantomQualityByItemQuality(quality).Value.IdentifyCoin;
	}

	// Token: 0x06012735 RID: 75573 RVA: 0x0048D254 File Offset: 0x0048B454
	public PhantomFetterGroup GetFetterGroupById(int groupId)
	{
		return ConfigPhantomFetterGroupById.GetConfig(groupId, true).Value;
	}

	// Token: 0x06012736 RID: 75574 RVA: 0x0048D270 File Offset: 0x0048B470
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

	// Token: 0x06012737 RID: 75575 RVA: 0x0048D2C0 File Offset: 0x0048B4C0
	public Dictionary<int, int> GetFetterGroupFetterDataById(int groupId)
	{
		return ConfigPhantomFetterGroupById.GetConfig(groupId, true).Value.FetterMap();
	}

	// Token: 0x06012738 RID: 75576 RVA: 0x0048D2E4 File Offset: 0x0048B4E4
	[NullableContext(2)]
	public IReadOnlyList<PhantomFetterGroup> GetFetterGroupArray()
	{
		return ConfigPhantomFetterGroupAll.GetConfigList(true);
	}

	// Token: 0x06012739 RID: 75577 RVA: 0x0048D2EC File Offset: 0x0048B4EC
	public int[] GetFetterGroupSourceMonster(int groupId)
	{
		IEnumerable<PhantomItem> phantomItemList = this.GetPhantomItemList();
		List<int> list = new List<int>();
		foreach (PhantomItem phantomItem in phantomItemList)
		{
			if (phantomItem.PhantomType == 1 && phantomItem.ParentMonsterId == 0 && phantomItem.FetterGroup().Contains(groupId))
			{
				list.Add(phantomItem.MonsterId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0601273A RID: 75578 RVA: 0x0048D370 File Offset: 0x0048B570
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

	// Token: 0x0601273B RID: 75579 RVA: 0x0048D478 File Offset: 0x0048B678
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

	// Token: 0x0601273C RID: 75580 RVA: 0x0048D558 File Offset: 0x0048B758
	public string GetPhantomQualityBgSprite(int quality)
	{
		if (quality == 0)
		{
			return ConfigCommonParamById.GetStringConfig("VisionQualityDefaultSprite");
		}
		return this.GetPhantomQualityByItemQuality(quality).Value.QualitySprite;
	}

	// Token: 0x0601273D RID: 75581 RVA: 0x0048D58C File Offset: 0x0048B78C
	public int[] GetPhantomSlotUnlockLevel(int quality)
	{
		return this.GetPhantomQualityByItemQuality(quality).Value.GetSlotUnlockLevelBytes().ToArray();
	}

	// Token: 0x0601273E RID: 75582 RVA: 0x0048D5B8 File Offset: 0x0048B7B8
	public Dictionary<int, int> GetPhantomIdentifyCost(int quality)
	{
		return this.GetPhantomQualityByItemQuality(quality).Value.IdentifyCost();
	}

	// Token: 0x0601273F RID: 75583 RVA: 0x0048D5DC File Offset: 0x0048B7DC
	public string GetMonsterIdName(int monsterId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetPhantomItemByMonsterId(monsterId)[0].MonsterName, null);
	}

	// Token: 0x06012740 RID: 75584 RVA: 0x0048D604 File Offset: 0x0048B804
	public string GetFetterNameByFetterNameId(string fetterNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(fetterNameId, null);
	}

	// Token: 0x06012741 RID: 75585 RVA: 0x0048D60D File Offset: 0x0048B80D
	public IReadOnlyList<PhantomManagePlanV2> GetPhantomManagerPlanByFetterId(int fetterId)
	{
		return ConfigPhantomManagePlanV2ByFetterId.GetConfigList(fetterId, true) ?? Array.Empty<PhantomManagePlanV2>();
	}

	// Token: 0x06012742 RID: 75586 RVA: 0x0048D61F File Offset: 0x0048B81F
	public IReadOnlyList<PhantomManagePlanV2> GetPhantomManagerPlanAll()
	{
		return ConfigPhantomManagePlanV2All.GetConfigList(true) ?? Array.Empty<PhantomManagePlanV2>();
	}

	// Token: 0x06012743 RID: 75587 RVA: 0x0048D630 File Offset: 0x0048B830
	public int GetPhantomManagerShareCodeMax()
	{
		return ConfigCommonParamById.GetIntConfig("PhBaPlanCodeMaxCount").GetValueOrDefault(30);
	}

	// Token: 0x06012744 RID: 75588 RVA: 0x0048D654 File Offset: 0x0048B854
	public int GetPhantomManagerShareCodeMin()
	{
		return ConfigCommonParamById.GetIntConfig("PhBaPlanCodeMinCount").GetValueOrDefault(20);
	}

	// Token: 0x06012745 RID: 75589 RVA: 0x0048D675 File Offset: 0x0048B875
	public TrailPhantomProp? GetTrialPhantomPropConfig(int id)
	{
		return ConfigTrailPhantomPropById.GetConfig(id, true);
	}

	// Token: 0x06012746 RID: 75590 RVA: 0x0048D680 File Offset: 0x0048B880
	public int GetVisionLevelUpQualityLimit()
	{
		return ConfigCommonParamById.GetIntConfig("VisionHighQuality").Value;
	}

	// Token: 0x06012747 RID: 75591 RVA: 0x0048D6A0 File Offset: 0x0048B8A0
	public int GetVisionLevelUpRareLimit()
	{
		return ConfigCommonParamById.GetIntConfig("VisionHighRare").Value;
	}

	// Token: 0x06012748 RID: 75592 RVA: 0x0048D6C0 File Offset: 0x0048B8C0
	public int GetVisionLevelUpLevelLimit()
	{
		return ConfigCommonParamById.GetIntConfig("VisionHighLevel").Value;
	}

	// Token: 0x06012749 RID: 75593 RVA: 0x0048D6E0 File Offset: 0x0048B8E0
	public int GetVisionScrollerMoveDistance()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerMoveDistance").Value;
	}

	// Token: 0x0601274A RID: 75594 RVA: 0x0048D700 File Offset: 0x0048B900
	public int GetVisionScrollerPressTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerLongPressTime").Value;
	}

	// Token: 0x0601274B RID: 75595 RVA: 0x0048D720 File Offset: 0x0048B920
	public int GetVisionBeforeScrollerLongPressTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionBeforeScrollerLongPressTime").Value;
	}

	// Token: 0x0601274C RID: 75596 RVA: 0x0048D740 File Offset: 0x0048B940
	public float GetVisionScrollerOffsetX()
	{
		if (!Info.Instance.IsInTouch())
		{
			return 0f;
		}
		return ConfigCommonParamById.GetFloatConfig("VisionScrollerOffsetX").Value;
	}

	// Token: 0x0601274D RID: 75597 RVA: 0x0048D774 File Offset: 0x0048B974
	public float GetVisionScrollerOffsetY()
	{
		if (!Info.Instance.IsInTouch())
		{
			return 0f;
		}
		return ConfigCommonParamById.GetFloatConfig("VisionScrollerOffsetY").Value;
	}

	// Token: 0x0601274E RID: 75598 RVA: 0x0048D7A8 File Offset: 0x0048B9A8
	public int GetVisionScrollerOffsetXDir()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerOffsetXDir").Value;
	}

	// Token: 0x0601274F RID: 75599 RVA: 0x0048D7C8 File Offset: 0x0048B9C8
	public int GetVisionScrollerOffsetYDir()
	{
		return ConfigCommonParamById.GetIntConfig("VisionScrollerOffsetYDir").Value;
	}

	// Token: 0x06012750 RID: 75600 RVA: 0x0048D7E7 File Offset: 0x0048B9E7
	public string GetVisionDragCurve()
	{
		return ConfigCommonParamById.GetStringConfig("VisionDragCurve");
	}

	// Token: 0x06012751 RID: 75601 RVA: 0x0048D7F4 File Offset: 0x0048B9F4
	public int GetVisionDragCurveTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionDragAnimationTime").Value;
	}

	// Token: 0x06012752 RID: 75602 RVA: 0x0048D813 File Offset: 0x0048BA13
	public string GetFilterOwnTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteOwn");
	}

	// Token: 0x06012753 RID: 75603 RVA: 0x0048D81F File Offset: 0x0048BA1F
	public string GetFilterNotOwnTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteNotOwn");
	}

	// Token: 0x06012754 RID: 75604 RVA: 0x0048D82B File Offset: 0x0048BA2B
	public string GetFilterEquipTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteEquipped");
	}

	// Token: 0x06012755 RID: 75605 RVA: 0x0048D837 File Offset: 0x0048BA37
	public string GetFilterNoEquipTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteNotEquipped");
	}

	// Token: 0x06012756 RID: 75606 RVA: 0x0048D843 File Offset: 0x0048BA43
	public string GetVisionLevelUpTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionLevelUpUnlockTexture");
	}

	// Token: 0x06012757 RID: 75607 RVA: 0x0048D84F File Offset: 0x0048BA4F
	public string GetVisionHeadSprBgB()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadSprBgB");
	}

	// Token: 0x06012758 RID: 75608 RVA: 0x0048D85B File Offset: 0x0048BA5B
	public string GetVisionHeadSprBgA()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadSprBgA");
	}

	// Token: 0x06012759 RID: 75609 RVA: 0x0048D867 File Offset: 0x0048BA67
	public string GetVisionHeadLightBgA()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadLightBgA");
	}

	// Token: 0x0601275A RID: 75610 RVA: 0x0048D873 File Offset: 0x0048BA73
	public string GetVisionHeadLightBgB()
	{
		return ConfigCommonParamById.GetStringConfig("VisionHeadLightBgB");
	}

	// Token: 0x0601275B RID: 75611 RVA: 0x0048D880 File Offset: 0x0048BA80
	public int GetVisionReachableCostMax()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomTotalCost").Value;
	}

	// Token: 0x0601275C RID: 75612 RVA: 0x0048D89F File Offset: 0x0048BA9F
	public string GetVisionFetterDefaultColor()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFetterDefaultColor");
	}

	// Token: 0x0601275D RID: 75613 RVA: 0x0048D8AB File Offset: 0x0048BAAB
	public string GetVisionFetterDefaultTexture()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFetterDefaultTexture");
	}

	// Token: 0x0601275E RID: 75614 RVA: 0x0048D8B8 File Offset: 0x0048BAB8
	public int GetVisionLevelUpDelay()
	{
		return ConfigCommonParamById.GetIntConfig("VisionLevelUpDelay").Value;
	}

	// Token: 0x0601275F RID: 75615 RVA: 0x0048D8D8 File Offset: 0x0048BAD8
	public int GetVisionIdentifyDelay()
	{
		return ConfigCommonParamById.GetIntConfig("VisionIdentifyDelay").Value;
	}

	// Token: 0x06012760 RID: 75616 RVA: 0x0048D8F7 File Offset: 0x0048BAF7
	public string GetVisionCostColorBase()
	{
		return ConfigCommonParamById.GetStringConfig("VisionCostColorBase");
	}

	// Token: 0x06012761 RID: 75617 RVA: 0x0048D903 File Offset: 0x0048BB03
	public string GetVisionCostColorFull()
	{
		return ConfigCommonParamById.GetStringConfig("VisionCostColorFull");
	}

	// Token: 0x06012762 RID: 75618 RVA: 0x0048D90F File Offset: 0x0048BB0F
	public string GetVisionCostColorAlert()
	{
		return ConfigCommonParamById.GetStringConfig("VisionCostColorAlert");
	}

	// Token: 0x06012763 RID: 75619 RVA: 0x0048D91C File Offset: 0x0048BB1C
	public int GetVisionIdentifyAnimationTime()
	{
		return ConfigCommonParamById.GetIntConfig("VisionIdentifyAnimationTime").Value;
	}

	// Token: 0x06012764 RID: 75620 RVA: 0x0048D93B File Offset: 0x0048BB3B
	public int[] GetVisionMainAttributeSortArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("VisionMainAttributeSortArray").ToArray<int>();
	}

	// Token: 0x06012765 RID: 75621 RVA: 0x0048D94C File Offset: 0x0048BB4C
	public int[] GetVisionMainPercentageAttributeSortArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("VisionMainPercentageAttributeSortArray").ToArray<int>();
	}

	// Token: 0x06012766 RID: 75622 RVA: 0x0048D95D File Offset: 0x0048BB5D
	public int[] GetVisionSubAttributeSortArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("VisionSubAttributeSortArray").ToArray<int>();
	}

	// Token: 0x06012767 RID: 75623 RVA: 0x0048D96E File Offset: 0x0048BB6E
	public int[] GetVisionSubPercentageAttributeSortArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("VisionSubPercentageAttributeSortArray").ToArray<int>();
	}

	// Token: 0x06012768 RID: 75624 RVA: 0x0048D97F File Offset: 0x0048BB7F
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

	// Token: 0x06012769 RID: 75625 RVA: 0x0048D99D File Offset: 0x0048BB9D
	public string GetVisionDestroyCost1()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteCost1");
	}

	// Token: 0x0601276A RID: 75626 RVA: 0x0048D9A9 File Offset: 0x0048BBA9
	public string GetVisionDestroyCost3()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteCost3");
	}

	// Token: 0x0601276B RID: 75627 RVA: 0x0048D9B5 File Offset: 0x0048BBB5
	public string GetVisionDestroyCost4()
	{
		return ConfigCommonParamById.GetStringConfig("VisionFilterSpriteCost4");
	}

	// Token: 0x0601276C RID: 75628 RVA: 0x0048D9C1 File Offset: 0x0048BBC1
	public string GetVisionRecoveryUnDesperateIcon()
	{
		return ConfigCommonParamById.GetStringConfig("VisionRecoveryUnDesperate");
	}

	// Token: 0x0601276D RID: 75629 RVA: 0x0048D9CD File Offset: 0x0048BBCD
	public string GetVisionRecoveryDesperateIcon()
	{
		return ConfigCommonParamById.GetStringConfig("VisionRecoveryDesperate");
	}

	// Token: 0x0601276E RID: 75630 RVA: 0x0048D9DC File Offset: 0x0048BBDC
	public int GetVisionRecommendRuleLevel()
	{
		return ConfigCommonParamById.GetIntConfig("VisionRecommendRuleLevel").Value;
	}

	// Token: 0x0601276F RID: 75631 RVA: 0x0048D9FC File Offset: 0x0048BBFC
	public int GetPhantomEquipGroupCountMax()
	{
		return ConfigCommonParamById.GetIntConfig("PhantomEquipGroupCount").Value;
	}

	// Token: 0x06012770 RID: 75632 RVA: 0x0048DA1C File Offset: 0x0048BC1C
	public int GetPhantomEquipHelpGroupId()
	{
		return ConfigCommonParamById.GetIntConfig("VisionEquipHelpGroupId").Value;
	}

	// Token: 0x06012771 RID: 75633 RVA: 0x0048DA3C File Offset: 0x0048BC3C
	public int GetPhantomRecommendHelpGroupId()
	{
		return ConfigCommonParamById.GetIntConfig("VisionRecommendHelpId").Value;
	}

	// Token: 0x06012772 RID: 75634 RVA: 0x0048DA5B File Offset: 0x0048BC5B
	public int[] GetVisionAttrSortArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("VisionMainViewExtraAttributeForPreset").ToArray<int>();
	}

	// Token: 0x06012773 RID: 75635 RVA: 0x0048DA6C File Offset: 0x0048BC6C
	public PhantomVicePolishConfig? GetPhantomVicePolishCostByLockCount(int count)
	{
		return ConfigPhantomVicePolishConfigByPropCount.GetConfig(count, true);
	}

	// Token: 0x06012774 RID: 75636 RVA: 0x0048DA78 File Offset: 0x0048BC78
	public int GetPhantomSharedCodeCd()
	{
		return ConfigCommonParamById.GetIntConfig("PhBaPlanCodeShareCheckCD").GetValueOrDefault(30);
	}

	// Token: 0x06012775 RID: 75637 RVA: 0x0048DA99 File Offset: 0x0048BC99
	protected override bool OnClear()
	{
		this.TrialPhantomPropMap.Clear();
		return true;
	}

	// Token: 0x170017DE RID: 6110
	// (get) Token: 0x06012776 RID: 75638 RVA: 0x0048DAA7 File Offset: 0x0048BCA7
	public static PhantomBattleConfig Instance
	{
		get
		{
			return PhantomBattleConfig._Instance;
		}
	}

	// Token: 0x06012777 RID: 75639 RVA: 0x0048DAAE File Offset: 0x0048BCAE
	public static PhantomBattleConfig GetOrCreateInstance()
	{
		if (PhantomBattleConfig._Instance == null)
		{
			PhantomBattleConfig.CreateInstance();
		}
		return PhantomBattleConfig._Instance;
	}

	// Token: 0x06012778 RID: 75640 RVA: 0x0048DAC2 File Offset: 0x0048BCC2
	public static bool CreateInstance()
	{
		if (PhantomBattleConfig._Instance != null)
		{
			return true;
		}
		PhantomBattleConfig._Instance = new PhantomBattleConfig();
		return true;
	}

	// Token: 0x06012779 RID: 75641 RVA: 0x0048DAD8 File Offset: 0x0048BCD8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601277A RID: 75642 RVA: 0x0048DADA File Offset: 0x0048BCDA
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleConfig._Instance = null;
	}

	// Token: 0x0601277B RID: 75643 RVA: 0x0048DAE2 File Offset: 0x0048BCE2
	static PhantomBattleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleConfig.CreateStaticDefaultValue), new Action(PhantomBattleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008B68 RID: 35688
	private readonly Dictionary<int, TrailPhantomProp> TrialPhantomPropMap;

	// Token: 0x04008B69 RID: 35689
	[Nullable(2)]
	private static PhantomBattleConfig _Instance;
}
