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

// Token: 0x02002811 RID: 10257
[NullableContext(1)]
[Nullable(0)]
public class RoleDevUtils
{
	// Token: 0x060150F2 RID: 86258 RVA: 0x00554EA3 File Offset: 0x005530A3
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

	// Token: 0x060150F3 RID: 86259 RVA: 0x00554EC0 File Offset: 0x005530C0
	public static RoleDevCultivateProject? GetCultivateProject(int roleId)
	{
		int? cultivateProjectId = RoleDevUtils.GetCultivateProjectId(roleId);
		if (cultivateProjectId == null)
		{
			return null;
		}
		return RoleDevConfig.Instance.GetCultivateProjectConfig(cultivateProjectId.Value);
	}

	// Token: 0x060150F4 RID: 86260 RVA: 0x00554EF8 File Offset: 0x005530F8
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

	// Token: 0x060150F5 RID: 86261 RVA: 0x00554F40 File Offset: 0x00553140
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

	// Token: 0x060150F6 RID: 86262 RVA: 0x00554FFC File Offset: 0x005531FC
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

	// Token: 0x060150F7 RID: 86263 RVA: 0x00555030 File Offset: 0x00553230
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

	// Token: 0x060150F8 RID: 86264 RVA: 0x00555064 File Offset: 0x00553264
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

	// Token: 0x060150F9 RID: 86265 RVA: 0x005550C4 File Offset: 0x005532C4
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

	// Token: 0x060150FA RID: 86266 RVA: 0x005551E0 File Offset: 0x005533E0
	public static bool IsGachaValid(int gachaId)
	{
		return GachaModel.Instance.CheckGachaValidByGachaId(gachaId);
	}

	// Token: 0x060150FB RID: 86267 RVA: 0x005551F0 File Offset: 0x005533F0
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

	// Token: 0x060150FC RID: 86268 RVA: 0x0055528C File Offset: 0x0055348C
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

	// Token: 0x060150FD RID: 86269 RVA: 0x0055547C File Offset: 0x0055367C
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

	// Token: 0x060150FE RID: 86270 RVA: 0x005554CC File Offset: 0x005536CC
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

	// Token: 0x060150FF RID: 86271 RVA: 0x00555530 File Offset: 0x00553730
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

	// Token: 0x06015100 RID: 86272 RVA: 0x0055557C File Offset: 0x0055377C
	public static bool CheckAccessPathUnlocked(int accessPathId)
	{
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(accessPathId);
		if (accessPathConfig != null && accessPathConfig.Value.SkipName == 2)
		{
			return RoleDevUtils.CheckDungeonAccessUnlocked(accessPathConfig.Value);
		}
		return MapModel.Instance.CheckTeleportUnlocked(accessPathId);
	}

	// Token: 0x06015101 RID: 86273 RVA: 0x005555C8 File Offset: 0x005537C8
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

	// Token: 0x06015102 RID: 86274 RVA: 0x005556F4 File Offset: 0x005538F4
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

	// Token: 0x06015103 RID: 86275 RVA: 0x00555894 File Offset: 0x00553A94
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

	// Token: 0x06015104 RID: 86276 RVA: 0x005558F9 File Offset: 0x00553AF9
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

	// Token: 0x06015105 RID: 86277 RVA: 0x00555924 File Offset: 0x00553B24
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

	// Token: 0x06015106 RID: 86278 RVA: 0x005559D8 File Offset: 0x00553BD8
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

	// Token: 0x06015107 RID: 86279 RVA: 0x00555A3C File Offset: 0x00553C3C
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

	// Token: 0x06015108 RID: 86280 RVA: 0x00555A54 File Offset: 0x00553C54
	public static List<global::IRoleDevDetailItemData> CreateSkillDetailItemsData(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, int roleId)
	{
		List<global::IItemMaterial> totalMaterials = new List<global::IItemMaterial>();
		RoleDevUtils.ProcessUpgradedSkillLevelConsume(skillNodeIdList, currentLevels, targetLevels, totalMaterials);
		List<global::IMaterialGroup> materialGroups = RoleDevUtils.GroupMaterialsByType(totalMaterials);
		return RoleDevUtils.BuildDetailItemData(roleId, materialGroups, ERoleDevMainPage.Skill);
	}

	// Token: 0x06015109 RID: 86281 RVA: 0x00555A80 File Offset: 0x00553C80
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

	// Token: 0x0601510A RID: 86282 RVA: 0x00555B38 File Offset: 0x00553D38
	private static bool ShouldSkipItem(int itemId)
	{
		return itemId == 1 || itemId == 2;
	}

	// Token: 0x0601510B RID: 86283 RVA: 0x00555B44 File Offset: 0x00553D44
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

	// Token: 0x0601510C RID: 86284 RVA: 0x00555BC8 File Offset: 0x00553DC8
	public static bool GetDefaultSkillPlanByRoleId(int roleId)
	{
		return RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == global::ERoleTypeTag.Forecast;
	}

	// Token: 0x0601510D RID: 86285 RVA: 0x00555BD8 File Offset: 0x00553DD8
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
