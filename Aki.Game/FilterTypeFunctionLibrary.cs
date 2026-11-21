using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02000CEB RID: 3307
[NullableContext(1)]
[Nullable(0)]
public class FilterTypeFunctionLibrary
{
	// Token: 0x06008982 RID: 35202 RVA: 0x0029B380 File Offset: 0x00299580
	public static FilterItemData[] GetElementFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (ElementInfo elementInfo in ElementInfoConfig.Instance.GetConfigList(idList))
		{
			string elementInfoLocalName = ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo.Name);
			list.Add(new FilterItemData(elementInfo.Id, elementInfoLocalName, elementInfo.Icon4));
		}
		return list.ToArray();
	}

	// Token: 0x06008983 RID: 35203 RVA: 0x0029B40C File Offset: 0x0029960C
	public static FilterItemData[] GetWeaponFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (Mapping mapping in MappingConfig.Instance.GetWeaponConfList())
		{
			if (Array.IndexOf<int>(idList, mapping.Value) >= 0)
			{
				string weaponConfComment = MappingConfig.Instance.GetWeaponConfComment(mapping.Comment);
				list.Add(new FilterItemData(mapping.Value, weaponConfComment, mapping.Icon));
			}
		}
		return list.ToArray();
	}

	// Token: 0x06008984 RID: 35204 RVA: 0x0029B4A0 File Offset: 0x002996A0
	public static FilterItemData[] GetPhantomFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string monsterNameByMonsterId = CalabashConfig.Instance.GetMonsterNameByMonsterId(num);
			int skillId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(num)[0].SkillId;
			PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(skillId);
			string iconPath = ((phantomSkillBySkillId != null) ? phantomSkillBySkillId.GetValueOrDefault().BattleViewIcon : null) ?? string.Empty;
			FilterItemData item = new FilterItemData(num, monsterNameByMonsterId, iconPath);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008985 RID: 35205 RVA: 0x0029B540 File Offset: 0x00299740
	public static FilterItemData[] GetDetectFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string localFilterTextById = AdventureGuideConfig.Instance.GetLocalFilterTextById(num);
			FilterItemData item = new FilterItemData(num, localFilterTextById, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008986 RID: 35206 RVA: 0x0029B590 File Offset: 0x00299790
	public static FilterItemData[] GetCookMenuFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int filterId in idList)
		{
			string textById = TextConfig.Instance.GetTextById("Recipe");
			FilterItemData item = new FilterItemData(filterId, textById, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008987 RID: 35207 RVA: 0x0029B5E0 File Offset: 0x002997E0
	public static FilterItemData[] GetCookTypeFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string id = (num == 1) ? "Attack" : ((num == 2) ? "Defense" : "Explore");
			string textById = TextConfig.Instance.GetTextById(id);
			FilterItemData item = new FilterItemData(num, textById, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008988 RID: 35208 RVA: 0x0029B64C File Offset: 0x0029984C
	public static FilterItemData[] GetComposeFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int filterId in idList)
		{
			string textById = TextConfig.Instance.GetTextById("Formula");
			FilterItemData item = new FilterItemData(filterId, textById, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008989 RID: 35209 RVA: 0x0029B69C File Offset: 0x0029989C
	public static FilterItemData[] GetPhantomRarityFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int filterId in idList)
		{
			string id = "CalabashCatchGain_" + filterId.ToString();
			string textById = TextConfig.Instance.GetTextById(id);
			FilterItemData item = new FilterItemData(filterId, textById, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600898A RID: 35210 RVA: 0x0029B700 File Offset: 0x00299900
	public static FilterItemData[] GetPhantomFettersEquipFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string id = (num == 1) ? "PhantomFettersEquip" : "PhantomFettersUnEquip";
			string textById = TextConfig.Instance.GetTextById(id);
			string iconPath = (num == 1) ? PhantomBattleConfig.Instance.GetFilterEquipTexture() : PhantomBattleConfig.Instance.GetFilterNoEquipTexture();
			FilterItemData item = new FilterItemData(num, textById, iconPath);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600898B RID: 35211 RVA: 0x0029B77C File Offset: 0x0029997C
	public static FilterItemData[] GetPhantomFettersHasFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string id = (num == 1) ? "PhantomFettersHas" : "PhantomFettersUnHas";
			string textById = TextConfig.Instance.GetTextById(id);
			string iconPath = (num == 1) ? PhantomBattleConfig.Instance.GetFilterOwnTexture() : PhantomBattleConfig.Instance.GetFilterNotOwnTexture();
			FilterItemData item = new FilterItemData(num, textById, iconPath);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600898C RID: 35212 RVA: 0x0029B7F5 File Offset: 0x002999F5
	public static FilterItemData[] GetPhantomRarityZeroFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 0);
	}

	// Token: 0x0600898D RID: 35213 RVA: 0x0029B800 File Offset: 0x00299A00
	private static FilterItemData[] GetPhantomRarityFilterDataByRare(int[] idList, int rare)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			IReadOnlyList<PhantomItem> phantomItemByMonsterId = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(num);
			if (phantomItemByMonsterId != null && phantomItemByMonsterId.Count != 0 && PhantomBattleConfig.Instance.GetPhantomRareConfig(phantomItemByMonsterId[0].Rarity).Value.Rare == rare)
			{
				string monsterNameByMonsterId = CalabashConfig.Instance.GetMonsterNameByMonsterId(num);
				int skillId = phantomItemByMonsterId[0].SkillId;
				PhantomSkill? phantomSkillBySkillId = PhantomBattleConfig.Instance.GetPhantomSkillBySkillId(skillId);
				string iconPath = ((phantomSkillBySkillId != null) ? phantomSkillBySkillId.GetValueOrDefault().BattleViewIcon : null) ?? string.Empty;
				FilterItemData item = new FilterItemData(num, monsterNameByMonsterId, iconPath);
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600898E RID: 35214 RVA: 0x0029B8EC File Offset: 0x00299AEC
	public static FilterItemData[] GetPhantomRarityOneFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 1);
	}

	// Token: 0x0600898F RID: 35215 RVA: 0x0029B8F5 File Offset: 0x00299AF5
	public static FilterItemData[] GetPhantomRarityTwoFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 2);
	}

	// Token: 0x06008990 RID: 35216 RVA: 0x0029B8FE File Offset: 0x00299AFE
	public static FilterItemData[] GetPhantomRarityThreeFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 3);
	}

	// Token: 0x06008991 RID: 35217 RVA: 0x0029B908 File Offset: 0x00299B08
	public static FilterItemData[] GetItemQualityFilterData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(num);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(qualityConfig.Value.Name, null);
			list.Add(new FilterItemData(num, localTextNew, (qualityConfig != null) ? qualityConfig.GetValueOrDefault().FilterIconPath : null));
		}
		return list.ToArray();
	}

	// Token: 0x06008992 RID: 35218 RVA: 0x0029B984 File Offset: 0x00299B84
	public static FilterItemData[] GetVisionDestroyCostData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			int cost = PhantomBattleConfig.Instance.GetPhantomRareConfig(num).Value.Cost;
			string id = StringUtils.Format("Cost{0}", new string[]
			{
				cost.ToString()
			});
			string textById = TextConfig.Instance.GetTextById(id);
			string visionDestroyCostSpriteByCost = PhantomBattleConfig.Instance.GetVisionDestroyCostSpriteByCost(cost);
			FilterItemData item = new FilterItemData(num, textById, visionDestroyCostSpriteByCost);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008993 RID: 35219 RVA: 0x0029BA1C File Offset: 0x00299C1C
	public static FilterItemData[] GetVisionDestroyQualityData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(num);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(qualityConfig.Value.Name, null);
			list.Add(new FilterItemData(num, localTextNew, (qualityConfig != null) ? qualityConfig.GetValueOrDefault().FilterIconPath : null));
		}
		return list.ToArray();
	}

	// Token: 0x06008994 RID: 35220 RVA: 0x0029BA98 File Offset: 0x00299C98
	public static FilterItemData[] GetVisionDestroyFetterGroupData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(num);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(fetterGroupById.FetterGroupName, null);
			list.Add(new FilterItemData(num, localTextNew, fetterGroupById.FetterElementPath));
		}
		return list.ToArray();
	}

	// Token: 0x06008995 RID: 35221 RVA: 0x0029BAF8 File Offset: 0x00299CF8
	public static FilterItemData[] GetVisionDestroyAttribute(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			int sortRuleAttributeId = SortConfig.Instance.GetSortRuleAttributeId(num, ESortDataType.Phantom);
			string propertyIndexIcon = PropertyIndexConfig.Instance.GetPropertyIndexIcon(sortRuleAttributeId);
			string sortRuleName = SortConfig.Instance.GetSortRuleName(num, ESortDataType.Phantom);
			list.Add(new FilterItemData(num, sortRuleName, propertyIndexIcon));
		}
		return list.ToArray();
	}

	// Token: 0x06008996 RID: 35222 RVA: 0x0029BB60 File Offset: 0x00299D60
	public static FilterItemData[] GetRoleTagFilterList(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			RoleTag? roleTagConfig = RoleConfig.Instance.GetRoleTagConfig(num);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(roleTagConfig.Value.TagName, null);
			list.Add(new FilterItemData(num, localTextNew, roleTagConfig.Value.TagIcon));
		}
		return list.ToArray();
	}

	// Token: 0x06008997 RID: 35223 RVA: 0x0029BBD0 File Offset: 0x00299DD0
	public static FilterItemData[] GetItemDeprecateFilterList(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string id = "";
			switch (num)
			{
			case 0:
				id = "PhantomNotLabeled";
				break;
			case 1:
				id = "EchoAbandoned";
				break;
			case 2:
				id = "PhantomLocked";
				break;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(id, null);
			string iconPath = (num == 1) ? PhantomBattleConfig.Instance.GetVisionRecoveryDesperateIcon() : PhantomBattleConfig.Instance.GetVisionRecoveryUnDesperateIcon();
			FilterItemData item = new FilterItemData(num, localTextNew, iconPath);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008998 RID: 35224 RVA: 0x0029BC6C File Offset: 0x00299E6C
	public static FilterItemData[] GetVisionGroupAttributeFilterList(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int ruleId in idList)
		{
			int sortRuleAttributeId = SortConfig.Instance.GetSortRuleAttributeId(ruleId, ESortDataType.Attribute);
			int sortRuleAddType = SortConfig.Instance.GetSortRuleAddType(ruleId, ESortDataType.Attribute);
			string icon = PropertyIndexConfig.Instance.GetPropertyIndexInfo(sortRuleAttributeId).Value.Icon;
			string sortRuleName = SortConfig.Instance.GetSortRuleName(ruleId, ESortDataType.Attribute);
			FilterItemData item = new FilterItemData(sortRuleAttributeId * 10 + sortRuleAddType, sortRuleName, icon);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x06008999 RID: 35225 RVA: 0x0029BD04 File Offset: 0x00299F04
	public static FilterItemData[] GetFishingTechData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int filterId in idList)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Fishing_TagName" + filterId.ToString(), null);
			FilterItemData item = new FilterItemData(filterId, localTextNew, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600899A RID: 35226 RVA: 0x0029BD60 File Offset: 0x00299F60
	public static FilterItemData[] GetFishingTimeData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(FishingDefine.fishingItemTimeText[num], null);
			FilterItemData item = new FilterItemData(num, localTextNew, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600899B RID: 35227 RVA: 0x0029BDB4 File Offset: 0x00299FB4
	public static FilterItemData[] GetFishingAreaData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int filterId in idList)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Area_" + filterId.ToString() + "_Title", null);
			FilterItemData item = new FilterItemData(filterId, localTextNew, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600899C RID: 35228 RVA: 0x0029BE14 File Offset: 0x0029A014
	public static FilterItemData[] GetFishingTypeData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(FishingDefine.fishingItemTypeText[num], null);
			FilterItemData item = new FilterItemData(num, localTextNew, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600899D RID: 35229 RVA: 0x0029BE68 File Offset: 0x0029A068
	public static FilterItemData[] GetDangoAbyssPluginQualityData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			AbyssQuality? abyssQualityById = DangoAbyssConfig.Instance.GetAbyssQualityById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(abyssQualityById.Value.Name);
			FilterItemData item = new FilterItemData(num, multiTextByKey, (abyssQualityById != null) ? abyssQualityById.GetValueOrDefault().FilterIconPath : null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600899E RID: 35230 RVA: 0x0029BEEC File Offset: 0x0029A0EC
	public static FilterItemData[] GetDangoAbyssPluginPropData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(propertyIndexInfo.Value.Name);
			FilterItemData item = new FilterItemData(num, multiTextByKey, propertyIndexInfo.Value.Icon);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0600899F RID: 35231 RVA: 0x0029BF64 File Offset: 0x0029A164
	public static FilterItemData[] GetDangoAbyssPluginTagData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			AbyssPluginPropDesc? dangoPluginPropDescById = DangoAbyssConfig.Instance.GetDangoPluginPropDescById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(dangoPluginPropDescById.Value.Name);
			FilterItemData item = new FilterItemData(num, multiTextByKey, dangoPluginPropDescById.Value.Icon);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089A0 RID: 35232 RVA: 0x0029BFDC File Offset: 0x0029A1DC
	public static FilterItemData[] GetDangoAbyssPluginLockStateData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			string key = (num == 1) ? "AbyssItem_Lock1" : "AbyssItem_UnLock1";
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(key);
			FilterItemData item = new FilterItemData(num, multiTextByKey, null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089A1 RID: 35233 RVA: 0x0029C038 File Offset: 0x0029A238
	public static FilterItemData[] GetPhantomManageFirstMainPropData(int[] sortRuleIdList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in sortRuleIdList)
		{
			int sortRuleAttributeId = SortConfig.Instance.GetSortRuleAttributeId(num, ESortDataType.Phantom);
			string propertyIndexIcon = PropertyIndexConfig.Instance.GetPropertyIndexIcon(sortRuleAttributeId);
			string sortRuleName = SortConfig.Instance.GetSortRuleName(num, ESortDataType.Phantom);
			list.Add(new FilterItemData(num, sortRuleName, propertyIndexIcon));
		}
		return list.ToArray();
	}

	// Token: 0x060089A2 RID: 35234 RVA: 0x0029C0A0 File Offset: 0x0029A2A0
	public static FilterItemData[] GetPhantomManageCostData(int[] costList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in costList)
		{
			string id = StringUtils.Format("Cost{0}", new string[]
			{
				num.ToString()
			});
			string textById = TextConfig.Instance.GetTextById(id);
			string visionDestroyCostSpriteByCost = PhantomBattleConfig.Instance.GetVisionDestroyCostSpriteByCost(num);
			FilterItemData item = new FilterItemData(num, textById, visionDestroyCostSpriteByCost);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089A3 RID: 35235 RVA: 0x0029C118 File Offset: 0x0029A318
	public static FilterItemData[] GetPinballRoleBdData(int[] bdIdList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in bdIdList)
		{
			PinballBdConfig? pinballBdConfigById = PinballConfig.Instance.GetPinballBdConfigById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(pinballBdConfigById.Value.BdName);
			FilterItemData item = new FilterItemData(num, multiTextByKey, (pinballBdConfigById != null) ? pinballBdConfigById.GetValueOrDefault().Icon : null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089A4 RID: 35236 RVA: 0x0029C19C File Offset: 0x0029A39C
	public static FilterItemData[] GetPinballRoleClassData(int[] classIdList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in classIdList)
		{
			PinballClassConfig? pinballClassConfigById = PinballConfig.Instance.GetPinballClassConfigById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(pinballClassConfigById.Value.PinballClassName);
			FilterItemData item = new FilterItemData(num, multiTextByKey, (pinballClassConfigById != null) ? pinballClassConfigById.GetValueOrDefault().Icon : null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089A5 RID: 35237 RVA: 0x0029C220 File Offset: 0x0029A420
	public static FilterItemData[] GetPinballWeaponTypeData(int[] typeIdList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in typeIdList)
		{
			PinballWeaponType? pinballWeaponTypeConfigById = PinballConfig.Instance.GetPinballWeaponTypeConfigById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(pinballWeaponTypeConfigById.Value.Name);
			FilterItemData item = new FilterItemData(num, multiTextByKey, (pinballWeaponTypeConfigById != null) ? pinballWeaponTypeConfigById.GetValueOrDefault().Icon3 : null);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089A6 RID: 35238 RVA: 0x0029C2A4 File Offset: 0x0029A4A4
	public static FilterItemData[] GetPinballWeaponQualityData(int[] qualityIdList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in qualityIdList)
		{
			PinballWeaponQuality? pinballWeaponQualityConfigById = PinballConfig.Instance.GetPinballWeaponQualityConfigById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(pinballWeaponQualityConfigById.Value.Name);
			list.Add(new FilterItemData(num, multiTextByKey, null)
			{
				ChangeColor = pinballWeaponQualityConfigById.Value.Color
			});
		}
		return list.ToArray();
	}

	// Token: 0x060089A7 RID: 35239 RVA: 0x0029C324 File Offset: 0x0029A524
	public static FilterItemData[] GetRoleLangCustomData(int[] idList)
	{
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int num in idList)
		{
			RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(num);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(roleLangCustomConfigById.Value.Text);
			list.Add(new FilterItemData(num, configTextByKey, null));
		}
		return list.ToArray();
	}
}
