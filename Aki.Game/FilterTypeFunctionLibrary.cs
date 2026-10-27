using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001832 RID: 6194
[NullableContext(1)]
[Nullable(0)]
public class FilterTypeFunctionLibrary
{
	// Token: 0x0600B597 RID: 46487 RVA: 0x00290C60 File Offset: 0x0028EE60
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

	// Token: 0x0600B598 RID: 46488 RVA: 0x00290CEC File Offset: 0x0028EEEC
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

	// Token: 0x0600B599 RID: 46489 RVA: 0x00290D80 File Offset: 0x0028EF80
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

	// Token: 0x0600B59A RID: 46490 RVA: 0x00290E20 File Offset: 0x0028F020
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

	// Token: 0x0600B59B RID: 46491 RVA: 0x00290E70 File Offset: 0x0028F070
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

	// Token: 0x0600B59C RID: 46492 RVA: 0x00290EC0 File Offset: 0x0028F0C0
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

	// Token: 0x0600B59D RID: 46493 RVA: 0x00290F2C File Offset: 0x0028F12C
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

	// Token: 0x0600B59E RID: 46494 RVA: 0x00290F7C File Offset: 0x0028F17C
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

	// Token: 0x0600B59F RID: 46495 RVA: 0x00290FE0 File Offset: 0x0028F1E0
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

	// Token: 0x0600B5A0 RID: 46496 RVA: 0x0029105C File Offset: 0x0028F25C
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

	// Token: 0x0600B5A1 RID: 46497 RVA: 0x002910D5 File Offset: 0x0028F2D5
	public static FilterItemData[] GetPhantomRarityZeroFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 0);
	}

	// Token: 0x0600B5A2 RID: 46498 RVA: 0x002910E0 File Offset: 0x0028F2E0
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

	// Token: 0x0600B5A3 RID: 46499 RVA: 0x002911CC File Offset: 0x0028F3CC
	public static FilterItemData[] GetPhantomRarityOneFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 1);
	}

	// Token: 0x0600B5A4 RID: 46500 RVA: 0x002911D5 File Offset: 0x0028F3D5
	public static FilterItemData[] GetPhantomRarityTwoFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 2);
	}

	// Token: 0x0600B5A5 RID: 46501 RVA: 0x002911DE File Offset: 0x0028F3DE
	public static FilterItemData[] GetPhantomRarityThreeFilterData(int[] idList)
	{
		return FilterTypeFunctionLibrary.GetPhantomRarityFilterDataByRare(idList, 3);
	}

	// Token: 0x0600B5A6 RID: 46502 RVA: 0x002911E8 File Offset: 0x0028F3E8
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

	// Token: 0x0600B5A7 RID: 46503 RVA: 0x00291264 File Offset: 0x0028F464
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

	// Token: 0x0600B5A8 RID: 46504 RVA: 0x002912FC File Offset: 0x0028F4FC
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

	// Token: 0x0600B5A9 RID: 46505 RVA: 0x00291378 File Offset: 0x0028F578
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

	// Token: 0x0600B5AA RID: 46506 RVA: 0x002913D8 File Offset: 0x0028F5D8
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

	// Token: 0x0600B5AB RID: 46507 RVA: 0x00291440 File Offset: 0x0028F640
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

	// Token: 0x0600B5AC RID: 46508 RVA: 0x002914B0 File Offset: 0x0028F6B0
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

	// Token: 0x0600B5AD RID: 46509 RVA: 0x0029154C File Offset: 0x0028F74C
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

	// Token: 0x0600B5AE RID: 46510 RVA: 0x002915E4 File Offset: 0x0028F7E4
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

	// Token: 0x0600B5AF RID: 46511 RVA: 0x00291640 File Offset: 0x0028F840
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

	// Token: 0x0600B5B0 RID: 46512 RVA: 0x00291694 File Offset: 0x0028F894
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

	// Token: 0x0600B5B1 RID: 46513 RVA: 0x002916F4 File Offset: 0x0028F8F4
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

	// Token: 0x0600B5B2 RID: 46514 RVA: 0x00291748 File Offset: 0x0028F948
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

	// Token: 0x0600B5B3 RID: 46515 RVA: 0x002917CC File Offset: 0x0028F9CC
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

	// Token: 0x0600B5B4 RID: 46516 RVA: 0x00291844 File Offset: 0x0028FA44
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

	// Token: 0x0600B5B5 RID: 46517 RVA: 0x002918BC File Offset: 0x0028FABC
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

	// Token: 0x0600B5B6 RID: 46518 RVA: 0x00291918 File Offset: 0x0028FB18
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

	// Token: 0x0600B5B7 RID: 46519 RVA: 0x00291980 File Offset: 0x0028FB80
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

	// Token: 0x0600B5B8 RID: 46520 RVA: 0x002919F8 File Offset: 0x0028FBF8
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

	// Token: 0x0600B5B9 RID: 46521 RVA: 0x00291A7C File Offset: 0x0028FC7C
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

	// Token: 0x0600B5BA RID: 46522 RVA: 0x00291B00 File Offset: 0x0028FD00
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

	// Token: 0x0600B5BB RID: 46523 RVA: 0x00291B84 File Offset: 0x0028FD84
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

	// Token: 0x0600B5BC RID: 46524 RVA: 0x00291C04 File Offset: 0x0028FE04
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
