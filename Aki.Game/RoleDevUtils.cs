using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001D8C RID: 7564
[NullableContext(1)]
[Nullable(0)]
public class RoleDevUtils
{
	// Token: 0x06012AF2 RID: 76530 RVA: 0x0057FCA3 File Offset: 0x0057DEA3
	public static ERoleDevDataType GetRoleDevDataTypeByRoleId(int roleId)
	{
		if (RoleModel.Instance.GetRoleDataById(roleId, true) != null)
		{
			return ERoleDevDataType.Obtained;
		}
		if (RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == global::ERoleTypeTag.Forecast)
		{
			return ERoleDevDataType.Forecast;
		}
		return ERoleDevDataType.NotObtained;
	}

	// Token: 0x06012AF3 RID: 76531 RVA: 0x0057FCC0 File Offset: 0x0057DEC0
	public static RoleDevCultivateProject? GetCultivateProject(int roleId)
	{
		int? cultivateProjectId = RoleDevUtils.GetCultivateProjectId(roleId);
		if (cultivateProjectId == null)
		{
			return null;
		}
		return RoleDevConfig.Instance.GetCultivateProjectConfig(cultivateProjectId.Value);
	}

	// Token: 0x06012AF4 RID: 76532 RVA: 0x0057FCF8 File Offset: 0x0057DEF8
	public static int? GetCultivateProjectId(int roleId)
	{
		RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId);
		int currentProjectNum = RoleDevUtils.GetCurrentProjectNum();
		int[] array = roleDevProjectConfig.Value.ProjectGroup();
		if (array.Length <= currentProjectNum)
		{
			return null;
		}
		return new int?(array[currentProjectNum]);
	}

	// Token: 0x06012AF5 RID: 76533 RVA: 0x0057FD40 File Offset: 0x0057DF40
	public static int[] GetRoleGachaIds(int hotRoleId)
	{
		List<int> list = new List<int>();
		if (!RoleDevUtils.IsHotRole(hotRoleId))
		{
			return list.ToArray();
		}
		IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(hotRoleId);
		if (roleDevProsListConfig == null)
		{
			return list.ToArray();
		}
		int gachaId = roleDevProsListConfig.GachaId;
		if (gachaId != 0 && GachaModel.Instance.CheckGachaValidByGachaId(gachaId))
		{
			list.Add(gachaId);
		}
		foreach (IRoleDevProsSpecialGachaConfig roleDevProsSpecialGachaConfig in roleDevProsListConfig.SpecialGachaId)
		{
			if (GachaModel.Instance.CheckGachaValidByGachaId(roleDevProsSpecialGachaConfig.GachaId))
			{
				list.Add(roleDevProsSpecialGachaConfig.GachaId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06012AF6 RID: 76534 RVA: 0x0057FDFC File Offset: 0x0057DFFC
	public static global::ERoleTypeTag GetRoleProspectType(int roleId)
	{
		IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId);
		if (RoleDevUtils.IsProspectTimeValid(roleId))
		{
			return global::ERoleTypeTag.Forecast;
		}
		if (RoleDevUtils.IsGachaValid(roleDevProsListConfig.GachaId))
		{
			return global::ERoleTypeTag.Summon;
		}
		return global::ERoleTypeTag.None;
	}

	// Token: 0x06012AF7 RID: 76535 RVA: 0x0057FE30 File Offset: 0x0057E030
	public static global::ERoleTypeTag GetRoleRerunType(int roleId)
	{
		IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId);
		if (RoleDevUtils.IsProspectTimeValid(roleId))
		{
			return global::ERoleTypeTag.Rerun;
		}
		if (RoleDevUtils.IsGachaValid(roleDevProsListConfig.GachaId))
		{
			return global::ERoleTypeTag.Summon;
		}
		return global::ERoleTypeTag.None;
	}

	// Token: 0x06012AF8 RID: 76536 RVA: 0x0057FE64 File Offset: 0x0057E064
	public static bool IsHotRole(int roleId)
	{
		IReadOnlyList<IRoleDevProsConfig> allRoleDevProsListConfig = RoleDevConfig.Instance.GetAllRoleDevProsListConfig();
		if (allRoleDevProsListConfig == null)
		{
			return false;
		}
		using (IEnumerator<IRoleDevProsConfig> enumerator = allRoleDevProsListConfig.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Id == roleId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06012AF9 RID: 76537 RVA: 0x0057FEC4 File Offset: 0x0057E0C4
	public static global::ERoleTypeTag GetRoleTypeTagByRoleId(int roleId)
	{
		IEnumerable<IRoleDevProsConfig> allRoleDevProsListConfig = RoleDevConfig.Instance.GetAllRoleDevProsListConfig();
		bool flag = false;
		using (IEnumerator<IRoleDevProsConfig> enumerator = allRoleDevProsListConfig.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Id == roleId)
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			return global::ERoleTypeTag.None;
		}
		IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId);
		if (roleDevProsListConfig == null)
		{
			return global::ERoleTypeTag.None;
		}
		bool flag2 = RoleDevUtils.IsProspectTimeValid(roleDevProsListConfig.Id);
		bool flag3 = RoleDevUtils.IsGachaValid(roleDevProsListConfig.GachaId);
		if (roleDevProsListConfig.TypeId == 1)
		{
			if (!flag2)
			{
				return global::ERoleTypeTag.None;
			}
			return global::ERoleTypeTag.Forecast;
		}
		else
		{
			if (roleDevProsListConfig.TypeId == 2)
			{
				return RoleDevUtils.GetRoleProspectType(roleId);
			}
			if (roleDevProsListConfig.TypeId == 3)
			{
				if (!flag2)
				{
					return global::ERoleTypeTag.None;
				}
				return global::ERoleTypeTag.Rerun;
			}
			else
			{
				if (roleDevProsListConfig.TypeId == 4)
				{
					return RoleDevUtils.GetRoleRerunType(roleId);
				}
				if (roleDevProsListConfig.TypeId != 5)
				{
					if (roleDevProsListConfig.TypeId == 6)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.RoleDev;
						ELogAuthor author = ELogAuthor.WMQ;
						string message = "武器类型调用GetRoleTypeTagByRoleId方法";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					int typeId = roleDevProsListConfig.TypeId;
					return global::ERoleTypeTag.None;
				}
				if (!flag3)
				{
					return global::ERoleTypeTag.None;
				}
				return global::ERoleTypeTag.Summon;
			}
		}
	}

	// Token: 0x06012AFA RID: 76538 RVA: 0x0057FFE0 File Offset: 0x0057E1E0
	public static bool IsGachaValid(int gachaId)
	{
		return GachaModel.Instance.CheckGachaValidByGachaId(gachaId);
	}

	// Token: 0x06012AFB RID: 76539 RVA: 0x0057FFF0 File Offset: 0x0057E1F0
	public static int GetCurrentProjectNum()
	{
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		if (originWorldLevel == 0)
		{
			return 0;
		}
		IReadOnlyList<RoleDevLevelLimit> levelLimitConfigList = RoleDevConfig.Instance.GetLevelLimitConfigList();
		if (levelLimitConfigList == null)
		{
			return 0;
		}
		foreach (RoleDevLevelLimit roleDevLevelLimit in levelLimitConfigList)
		{
			IntPair[] array = roleDevLevelLimit.PlayerLevel();
			if (originWorldLevel >= array[0].Item1 && originWorldLevel <= array[0].Item2)
			{
				return roleDevLevelLimit.ProjectNum;
			}
		}
		return 0;
	}

	// Token: 0x06012AFC RID: 76540 RVA: 0x0058008C File Offset: 0x0057E28C
	public static List<global::IMaterialGroup> GroupMaterialsByType(List<global::IItemMaterial> totalMaterials)
	{
		Dictionary<int, global::IItemMaterial> dictionary = new Dictionary<int, global::IItemMaterial>();
		foreach (global::IItemMaterial itemMaterial in totalMaterials)
		{
			global::IItemMaterial itemMaterial2;
			if (dictionary.TryGetValue(itemMaterial.ItemId, out itemMaterial2))
			{
				itemMaterial2.RequiredCount += itemMaterial.RequiredCount;
			}
			else
			{
				dictionary[itemMaterial.ItemId] = new global::ItemMaterial
				{
					ItemId = itemMaterial.ItemId,
					RequiredCount = itemMaterial.RequiredCount
				};
			}
		}
		List<global::IItemMaterial> list = new List<global::IItemMaterial>(dictionary.Values);
		List<global::IMaterialGroup> list2 = new List<global::IMaterialGroup>();
		foreach (global::IItemMaterial itemMaterial3 in list)
		{
			int itemId = itemMaterial3.ItemId;
			RoleDevItemJumpGroup? roleDevItemJumpGroup;
			int? num = (RoleDevConfig.Instance.GetItemJumpGroupConfig(itemId) != null) ? new int?(roleDevItemJumpGroup.GetValueOrDefault().ItemType) : null;
			if (num != null)
			{
				global::IMaterialGroup materialGroup = null;
				foreach (global::IMaterialGroup materialGroup2 in list2)
				{
					if (materialGroup2.Type == num.Value)
					{
						materialGroup = materialGroup2;
						break;
					}
				}
				if (materialGroup != null)
				{
					materialGroup.Materials.Add(itemMaterial3);
				}
				else
				{
					list2.Add(new global::MaterialGroup
					{
						Type = num.Value,
						Materials = new List<global::IItemMaterial>
						{
							itemMaterial3
						}
					});
				}
			}
		}
		list2.Sort((global::IMaterialGroup a, global::IMaterialGroup b) => a.Type - b.Type);
		return list2;
	}

	// Token: 0x06012AFD RID: 76541 RVA: 0x0058027C File Offset: 0x0057E47C
	public static int? GetFirstOpenDungeonIdByItemGroupId(int itemGroupId)
	{
		if (itemGroupId == 0)
		{
			return null;
		}
		RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(itemGroupId);
		if (itemJumpGroupConfig == null)
		{
			return null;
		}
		return RoleDevUtils.GetFirstOpenDungeonId(itemJumpGroupConfig.Value.JumpGroup());
	}

	// Token: 0x06012AFE RID: 76542 RVA: 0x005802CC File Offset: 0x0057E4CC
	public static int? GetFirstOpenDungeonId(int[] jumpIdList)
	{
		Dictionary<int, SilentAreaDetectionRecord> allDetectSilentAreas = AdventureGuideModel.Instance.GetAllDetectSilentAreas();
		if (allDetectSilentAreas == null)
		{
			return null;
		}
		foreach (int num in jumpIdList)
		{
			SilentAreaDetectionRecord silentAreaDetectionRecord;
			if (allDetectSilentAreas.TryGetValue(num, out silentAreaDetectionRecord) && silentAreaDetectionRecord != null && !silentAreaDetectionRecord.IsLock)
			{
				return new int?(num);
			}
		}
		return null;
	}

	// Token: 0x06012AFF RID: 76543 RVA: 0x00580330 File Offset: 0x0057E530
	public static int? GetFirstUnlockedTeleportId(int[] jumpIdList)
	{
		foreach (int num in jumpIdList)
		{
			if (RoleDevUtils.CheckAccessPathUnlocked(num))
			{
				return new int?(num);
			}
		}
		if (jumpIdList.Length == 0)
		{
			return null;
		}
		return new int?(jumpIdList[jumpIdList.Length - 1]);
	}

	// Token: 0x06012B00 RID: 76544 RVA: 0x0058037C File Offset: 0x0057E57C
	public static bool CheckAccessPathUnlocked(int accessPathId)
	{
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(accessPathId);
		if (accessPathConfig != null && accessPathConfig.Value.SkipName == 2)
		{
			return RoleDevUtils.CheckDungeonAccessUnlocked(accessPathConfig.Value);
		}
		return MapModel.Instance.CheckTeleportUnlocked(accessPathId);
	}

	// Token: 0x06012B01 RID: 76545 RVA: 0x005803C8 File Offset: 0x0057E5C8
	public static bool CheckDungeonAccessUnlocked(AccessPath config)
	{
		int id = int.Parse(config.Val1);
		InstanceDungeonEntrance? config2 = InstanceDungeonEntranceConfig.Instance.GetConfig(id);
		bool flag = false;
		if (config2 != null)
		{
			for (int i = 0; i < config2.Value.InstanceDungeonListLength; i++)
			{
				int instanceId = config2.Value.InstanceDungeonList(i);
				if (InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instanceId))
				{
					flag = true;
					break;
				}
			}
		}
		int markId = int.Parse(config.Val3);
		MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
		if (configMark == null)
		{
			return false;
		}
		LevelEntityConfig? entityConfigByMapIdAndEntityId = MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(configMark.Value.MapId, configMark.Value.EntityConfigId);
		if (entityConfigByMapIdAndEntityId == null)
		{
			return false;
		}
		int areaId = entityConfigByMapIdAndEntityId.Value.AreaId;
		Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
		int areaId2 = (areaInfo != null) ? AreaModel.Instance.GetAreaId(areaInfo.Value, new EAreaLevel?(EAreaLevel.FirstLevel)) : 0;
		bool flag2 = MapModel.Instance.CheckAreasUnlocked(areaId2, true);
		return flag && flag2;
	}

	// Token: 0x06012B02 RID: 76546 RVA: 0x005804F4 File Offset: 0x0057E6F4
	public static List<global::IRoleDevDetailItemData> BuildDetailItemData(int roleId, List<global::IMaterialGroup> materialGroups, ERoleDevMainPage sourcePageType)
	{
		List<global::IRoleDevDetailItemData> list = new List<global::IRoleDevDetailItemData>();
		List<int> list2 = new List<int>();
		foreach (global::IMaterialGroup materialGroup in materialGroups)
		{
			list2.Add(materialGroup.Type);
		}
		list2.Sort((int a, int b) => a - b);
		foreach (int num in list2)
		{
			RoleDevTypeManage? typeManageConfig = RoleDevConfig.Instance.GetTypeManageConfig(num);
			string title = ((typeManageConfig != null) ? typeManageConfig.GetValueOrDefault().TypeDescribe : null) ?? "";
			List<global::IItemMaterial> list3 = null;
			foreach (global::IMaterialGroup materialGroup2 in materialGroups)
			{
				if (materialGroup2.Type == num)
				{
					list3 = materialGroup2.Materials;
					break;
				}
			}
			if (list3 == null)
			{
				list3 = new List<global::IItemMaterial>();
			}
			List<global::IItemMaterial> itemGroup = RoleDevUtils.SortMaterialsByQuality(list3);
			ERoleDevSubPageButton buttonTypeByType = RoleDevUtils.GetButtonTypeByType(sourcePageType, (CSharpScript.Game.Module.RoleDev.EItemMaterialType)num);
			list.Add(new global::RoleDevDetailItemData
			{
				RoleId = roleId,
				MainPage = sourcePageType,
				ButtonType = buttonTypeByType,
				Title = title,
				ItemGroupId = 0,
				ItemGroup = itemGroup
			});
		}
		return list;
	}

	// Token: 0x06012B03 RID: 76547 RVA: 0x00580694 File Offset: 0x0057E894
	private static ERoleDevSubPageButton GetButtonTypeByType(ERoleDevMainPage sourcePageType, CSharpScript.Game.Module.RoleDev.EItemMaterialType type)
	{
		ERoleDevSubPageButton eroleDevSubPageButton = ERoleDevSubPageButton.None;
		switch (sourcePageType)
		{
		case ERoleDevMainPage.Role:
			if (RoleDevDefine.roleTabMaterialTypeToSubPageButtonMap.TryGetValue(type, out eroleDevSubPageButton))
			{
				return eroleDevSubPageButton;
			}
			goto IL_51;
		case ERoleDevMainPage.Weapon:
			if (RoleDevDefine.weaponTabMaterialTypeToSubPageButtonMap.TryGetValue(type, out eroleDevSubPageButton))
			{
				return eroleDevSubPageButton;
			}
			goto IL_51;
		case ERoleDevMainPage.Skill:
			if (RoleDevDefine.skillTabMaterialTypeToSubPageButtonMap.TryGetValue(type, out eroleDevSubPageButton))
			{
				return eroleDevSubPageButton;
			}
			goto IL_51;
		}
		eroleDevSubPageButton = ERoleDevSubPageButton.None;
		IL_51:
		if (eroleDevSubPageButton == ERoleDevSubPageButton.None)
		{
			return ERoleDevSubPageButton.None;
		}
		return eroleDevSubPageButton;
	}

	// Token: 0x06012B04 RID: 76548 RVA: 0x005806F9 File Offset: 0x0057E8F9
	private static List<global::IItemMaterial> SortMaterialsByQuality(List<global::IItemMaterial> materials)
	{
		materials.Sort(delegate(global::IItemMaterial a, global::IItemMaterial b)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemId);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.ItemId);
			int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
			int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
			return num - num2;
		});
		return materials;
	}

	// Token: 0x06012B05 RID: 76549 RVA: 0x00580724 File Offset: 0x0057E924
	public static bool CheckAllItemsUp(List<global::IRoleDevDetailItemData> detailItems)
	{
		if (detailItems == null || detailItems.Count == 0)
		{
			return false;
		}
		foreach (global::IRoleDevDetailItemData roleDevDetailItemData in detailItems)
		{
			foreach (global::IItemMaterial itemMaterial in roleDevDetailItemData.ItemGroup)
			{
				int requiredCount = itemMaterial.RequiredCount;
				if (InventoryModel.Instance.GetItemCountByConfigId(itemMaterial.ItemId, 0) < requiredCount)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06012B06 RID: 76550 RVA: 0x005807D8 File Offset: 0x0057E9D8
	public static bool IsProspectTimeValid(int roleId)
	{
		RoleDevModel instance = RoleDevModel.Instance;
		if (instance == null || !instance.IsConfigDataInitialized)
		{
			return false;
		}
		IRoleDevProsConfig roleDevPropsConfig = instance.GetRoleDevPropsConfig(roleId);
		if (roleDevPropsConfig == null)
		{
			return false;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		long prospectBeginTime = roleDevPropsConfig.ProspectBeginTime;
		long prospectEndTime = roleDevPropsConfig.ProspectEndTime;
		return prospectBeginTime != 0L && prospectEndTime != 0L && serverTime >= (double)prospectBeginTime && (prospectEndTime == 0L || serverTime <= (double)prospectEndTime);
	}

	// Token: 0x06012B07 RID: 76551 RVA: 0x0058083C File Offset: 0x0057EA3C
	public static ERoleDevWeaponTabType GetWeaponDefaultTabType(int roleId, bool isWeaponHighQuality)
	{
		if (RoleModel.Instance.GetRoleDataById(roleId, true) == null)
		{
			return ERoleDevWeaponTabType.WeaponDev;
		}
		if (isWeaponHighQuality)
		{
			return ERoleDevWeaponTabType.WeaponDev;
		}
		return ERoleDevWeaponTabType.WeaponRecommend;
	}

	// Token: 0x06012B08 RID: 76552 RVA: 0x00580854 File Offset: 0x0057EA54
	public static List<global::IRoleDevDetailItemData> CreateSkillDetailItemsData(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, int roleId)
	{
		List<global::IItemMaterial> totalMaterials = new List<global::IItemMaterial>();
		RoleDevUtils.ProcessUpgradedSkillLevelConsume(skillNodeIdList, currentLevels, targetLevels, totalMaterials);
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Skill);
	}

	// Token: 0x06012B09 RID: 76553 RVA: 0x00580880 File Offset: 0x0057EA80
	private static void ProcessUpgradedSkillLevelConsume(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, List<global::IItemMaterial> totalMaterials)
	{
		for (int i = 0; i < skillNodeIdList.Length; i++)
		{
			int num = currentLevels[i];
			int num2 = targetLevels[i];
			for (int j = num + 1; j <= num2; j++)
			{
				IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(skillNodeIdList[i], j);
				if (roleSkillTreeConsume != null)
				{
					foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
					{
						int key = dicIntInt.Value.Key;
						int value = dicIntInt.Value.Value;
						if (!RoleDevUtils.ShouldSkipItem(key))
						{
							RoleDevUtils.AddOrUpdateMaterial(totalMaterials, key, value);
						}
					}
				}
			}
		}
	}

	// Token: 0x06012B0A RID: 76554 RVA: 0x00580938 File Offset: 0x0057EB38
	private static bool ShouldSkipItem(int itemId)
	{
		return itemId == 1 || itemId == 2;
	}

	// Token: 0x06012B0B RID: 76555 RVA: 0x00580944 File Offset: 0x0057EB44
	private static void AddOrUpdateMaterial(List<global::IItemMaterial> totalMaterials, int itemId, int count)
	{
		global::IItemMaterial itemMaterial = null;
		foreach (global::IItemMaterial itemMaterial2 in totalMaterials)
		{
			if (itemMaterial2.ItemId == itemId)
			{
				itemMaterial = itemMaterial2;
				break;
			}
		}
		if (itemMaterial != null)
		{
			itemMaterial.RequiredCount += count;
			return;
		}
		totalMaterials.Add(new global::ItemMaterial
		{
			ItemId = itemId,
			RequiredCount = count
		});
	}

	// Token: 0x06012B0C RID: 76556 RVA: 0x005809C8 File Offset: 0x0057EBC8
	public static bool GetDefaultSkillPlanByRoleId(int roleId)
	{
		return RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == global::ERoleTypeTag.Forecast;
	}

	// Token: 0x06012B0D RID: 76557 RVA: 0x005809D8 File Offset: 0x0057EBD8
	public static void OpenWeaponReplaceView(int roleId, int weaponIncId)
	{
		RoleViewViewModel roleViewViewModel = new RoleViewViewModel(roleId, false, ERoleViewSource.Normal);
		roleViewViewModel.WeaponIncId = weaponIncId;
		roleViewViewModel.NeedShowOnViewPlayingStartSequence = true;
		roleViewViewModel.NeedHideOnViewPlayingCloseSequence = true;
		roleViewViewModel.FadeInCurveId = ERoleFadeCurveDefine.RoleFadeInCurve;
		roleViewViewModel.FadeOutCurveId = ERoleFadeCurveDefine.RoleFadeOutCurve;
		roleViewViewModel.RoleStatePlayContextOnShow = new RoleStatePlayContext
		{
			RoleState = EPerformanceRoleState.Weapon,
			ReLoop = true
		};
		roleViewViewModel.RoleStatePlayContextOnHide = new RoleStatePlayContext
		{
			RoleState = EPerformanceRoleState.Attribute
		};
		RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.WeaponReplaceView, roleViewViewModel);
	}
}
