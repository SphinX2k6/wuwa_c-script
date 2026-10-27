using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D34 RID: 19764
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopUtil
	{
		// Token: 0x060330EA RID: 209130 RVA: 0x00BE4850 File Offset: 0x00BE2A50
		public static bool IsHotRoleDevelopValid(int roleProspectId)
		{
			if (!RoleDevelopUtil.IsHotRole(roleProspectId))
			{
				return false;
			}
			int typeId = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleProspectId).TypeId;
			return (typeId != 1 || RoleDevelopUtil.IsRoleInProspectTime(roleProspectId)) && typeId != 0 && typeId != 4;
		}

		// Token: 0x060330EB RID: 209131 RVA: 0x00BE4890 File Offset: 0x00BE2A90
		public static RoleDevCultivateProject? GetCultivateProject(int roleId)
		{
			int? cultivateProjectId = RoleDevelopUtil.GetCultivateProjectId(roleId);
			if (cultivateProjectId == null)
			{
				return null;
			}
			return RoleDevConfig.Instance.GetCultivateProjectConfig(cultivateProjectId.Value);
		}

		// Token: 0x060330EC RID: 209132 RVA: 0x00BE48C8 File Offset: 0x00BE2AC8
		public static int? GetCultivateProjectId(int roleId)
		{
			RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId);
			int currentProjectNum = RoleDevelopUtil.GetCurrentProjectNum();
			int[] projectGroupArray = roleDevProjectConfig.Value.GetProjectGroupArray();
			if (projectGroupArray.Length <= currentProjectNum)
			{
				return null;
			}
			return new int?(projectGroupArray[currentProjectNum]);
		}

		// Token: 0x060330ED RID: 209133 RVA: 0x00BE4910 File Offset: 0x00BE2B10
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

		// Token: 0x060330EE RID: 209134 RVA: 0x00BE49AC File Offset: 0x00BE2BAC
		public static bool CheckIsAllNeedItemsEnough(List<RoleDevelopNeedItem> needItems)
		{
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in needItems)
			{
				if (RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
				{
					return false;
				}
				if (InventoryModel.Instance.GetItemCountByConfigId(roleDevelopNeedItem.ItemId, 0) < roleDevelopNeedItem.Count)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060330EF RID: 209135 RVA: 0x00BE4A24 File Offset: 0x00BE2C24
		public static bool IsUnknownItem(int itemId)
		{
			return itemId == RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.UnknownItemId;
		}

		// Token: 0x060330F0 RID: 209136 RVA: 0x00BE4A50 File Offset: 0x00BE2C50
		public static bool CheckIsAllNeedItemsEnoughOrCanBeFilled(List<RoleDevelopNeedItem> needItems)
		{
			if (RoleDevelopUtil.CheckIsItemsHaveUnknownMaterial(needItems))
			{
				return false;
			}
			foreach (RoleDevelopItemGroup itemGroup in RoleDevelopUtil.BuildGroupItemDataByNeedItems(needItems, false, true, false))
			{
				if (RoleDevelopModel.Instance.GetItemGroupRequirementState(itemGroup, null) == EItemRequirementState.NotSatisfied)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060330F1 RID: 209137 RVA: 0x00BE4AC0 File Offset: 0x00BE2CC0
		public static bool CheckIsItemsHaveUnknownMaterial(List<RoleDevelopNeedItem> items)
		{
			using (List<RoleDevelopNeedItem>.Enumerator enumerator = items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleDevelopUtil.IsUnknownItem(enumerator.Current.ItemId))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060330F2 RID: 209138 RVA: 0x00BE4B1C File Offset: 0x00BE2D1C
		public static List<RoleDevelopNeedItem> SortItemsByQuality(List<RoleDevelopNeedItem> items)
		{
			items.Sort(delegate(RoleDevelopNeedItem a, RoleDevelopNeedItem b)
			{
				bool flag = RoleDevelopUtil.IsUnknownItem(a.ItemId);
				bool flag2 = RoleDevelopUtil.IsUnknownItem(b.ItemId);
				if (flag == flag2)
				{
					ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ItemId);
					ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.ItemId);
					int num = (itemConfigData != null) ? itemConfigData.QualityId : 0;
					int num2 = (itemConfigData2 != null) ? itemConfigData2.QualityId : 0;
					return num - num2;
				}
				if (!flag)
				{
					return 1;
				}
				return -1;
			});
			return items;
		}

		// Token: 0x060330F3 RID: 209139 RVA: 0x00BE4B44 File Offset: 0x00BE2D44
		public static List<RoleDevelopNeedItem> CalcUpgradeNeedItems(int totalExp, List<RoleDevelopNeedItem> sortedExpItems, Func<int, int> getItemExp)
		{
			if (totalExp <= 0 || sortedExpItems.Count == 0)
			{
				return new List<RoleDevelopNeedItem>();
			}
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			int num = totalExp;
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in sortedExpItems)
			{
				int num2 = getItemExp(roleDevelopNeedItem.ItemId);
				int num3 = Math.Min((int)Math.Ceiling((double)num / (double)num2), roleDevelopNeedItem.Count);
				if (num3 > 0)
				{
					list.Add(new RoleDevelopNeedItem
					{
						ItemId = roleDevelopNeedItem.ItemId,
						Count = num3
					});
				}
				num -= num3 * num2;
			}
			if (num > 0)
			{
				RoleDevelopNeedItem roleDevelopNeedItem2 = sortedExpItems[sortedExpItems.Count - 1];
				int num4 = getItemExp(roleDevelopNeedItem2.ItemId);
				int num5 = (int)Math.Ceiling((double)num / (double)num4);
				if (num5 > 0)
				{
					RoleDevelopNeedItem roleDevelopNeedItem3 = null;
					foreach (RoleDevelopNeedItem roleDevelopNeedItem4 in list)
					{
						if (roleDevelopNeedItem4.ItemId == roleDevelopNeedItem2.ItemId)
						{
							roleDevelopNeedItem3 = roleDevelopNeedItem4;
							break;
						}
					}
					if (roleDevelopNeedItem3 != null)
					{
						roleDevelopNeedItem3.Count += num5;
					}
					else
					{
						list.Add(new RoleDevelopNeedItem
						{
							ItemId = roleDevelopNeedItem2.ItemId,
							Count = num5
						});
					}
				}
			}
			return list;
		}

		// Token: 0x060330F4 RID: 209140 RVA: 0x00BE4CB8 File Offset: 0x00BE2EB8
		public static List<RoleDevelopItemGroup> BuildGroupItemDataByNeedItems(List<RoleDevelopNeedItem> needItems, bool useSubGroup = false, bool sortByType = true, bool excludeSatisfied = false)
		{
			Dictionary<string, RoleDevelopItemGroup> dictionary = new Dictionary<string, RoleDevelopItemGroup>();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in needItems)
			{
				if (RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
				{
					if (roleDevelopNeedItem.Type != null)
					{
						EItemMaterialType value = roleDevelopNeedItem.Type.Value;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
						defaultInterpolatedStringHandler.AppendFormatted<int>((int)value);
						string groupKey = defaultInterpolatedStringHandler.ToStringAndClear();
						RoleDevelopUtil.AddItemToGroup(dictionary, groupKey, value, roleDevelopNeedItem);
					}
				}
				else
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
					if (itemJumpGroupConfig != null)
					{
						int num = (int)((roleDevelopNeedItem.Type != null) ? roleDevelopNeedItem.Type.Value : ((EItemMaterialType)itemJumpGroupConfig.Value.ItemType));
						string text;
						if (!useSubGroup)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
							defaultInterpolatedStringHandler.AppendFormatted<int>(num);
							text = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
							defaultInterpolatedStringHandler.AppendFormatted<int>(num);
							defaultInterpolatedStringHandler.AppendLiteral("_");
							defaultInterpolatedStringHandler.AppendFormatted<int>(itemJumpGroupConfig.Value.SubGroup);
							text = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						string groupKey2 = text;
						RoleDevelopUtil.AddItemToGroup(dictionary, groupKey2, (EItemMaterialType)num, roleDevelopNeedItem);
					}
				}
			}
			if (excludeSatisfied)
			{
				InventoryModel instance = InventoryModel.Instance;
				List<string> list = new List<string>();
				foreach (KeyValuePair<string, RoleDevelopItemGroup> keyValuePair in dictionary)
				{
					RoleDevelopItemGroup value2 = keyValuePair.Value;
					bool flag = false;
					foreach (RoleDevelopNeedItem roleDevelopNeedItem2 in value2.Items)
					{
						if (RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem2.ItemId) || instance.GetItemCountByConfigId(roleDevelopNeedItem2.ItemId, 0) < roleDevelopNeedItem2.Count)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						list.Add(keyValuePair.Key);
					}
				}
				foreach (string key in list)
				{
					dictionary.Remove(key);
				}
			}
			List<RoleDevelopItemGroup> list2 = new List<RoleDevelopItemGroup>(dictionary.Values);
			if (sortByType)
			{
				list2.Sort((RoleDevelopItemGroup a, RoleDevelopItemGroup b) => a.Type - b.Type);
			}
			return list2;
		}

		// Token: 0x060330F5 RID: 209141 RVA: 0x00BE4F9C File Offset: 0x00BE319C
		private static void AddItemToGroup(Dictionary<string, RoleDevelopItemGroup> groupMap, string groupKey, EItemMaterialType itemType, RoleDevelopNeedItem item)
		{
			RoleDevelopItemGroup roleDevelopItemGroup;
			if (!groupMap.TryGetValue(groupKey, out roleDevelopItemGroup))
			{
				roleDevelopItemGroup = new RoleDevelopItemGroup
				{
					Type = itemType,
					Items = new List<RoleDevelopNeedItem>()
				};
				groupMap[groupKey] = roleDevelopItemGroup;
			}
			RoleDevelopNeedItem roleDevelopNeedItem = null;
			foreach (RoleDevelopNeedItem roleDevelopNeedItem2 in roleDevelopItemGroup.Items)
			{
				if (roleDevelopNeedItem2.ItemId == item.ItemId)
				{
					roleDevelopNeedItem = roleDevelopNeedItem2;
					break;
				}
			}
			if (roleDevelopNeedItem != null)
			{
				roleDevelopNeedItem.Count += item.Count;
				return;
			}
			roleDevelopItemGroup.Items.Add(item);
		}

		// Token: 0x060330F6 RID: 209142 RVA: 0x00BE504C File Offset: 0x00BE324C
		public static bool IsHotRole(int roleId)
		{
			return RoleDevConfig.Instance.HasRoleDevProsListConfig(roleId);
		}

		// Token: 0x060330F7 RID: 209143 RVA: 0x00BE505C File Offset: 0x00BE325C
		public static bool IsRoleInProspectTime(int roleId)
		{
			if (!RoleDevelopUtil.IsHotRole(roleId))
			{
				return false;
			}
			IRoleDevProsConfig roleDevProsListConfig = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId);
			long prospectBeginTime = roleDevProsListConfig.ProspectBeginTime;
			long prospectEndTime = roleDevProsListConfig.ProspectEndTime;
			if (prospectBeginTime == 0L || prospectEndTime == 0L || prospectEndTime < prospectBeginTime)
			{
				return false;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return serverTime >= (double)prospectBeginTime && serverTime <= (double)prospectEndTime;
		}

		// Token: 0x060330F8 RID: 209144 RVA: 0x00BE50B1 File Offset: 0x00BE32B1
		public static bool IsProspectRole(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 1;
		}

		// Token: 0x060330F9 RID: 209145 RVA: 0x00BE50D0 File Offset: 0x00BE32D0
		public static bool IsProspectRoleValid(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 1 && RoleDevelopUtil.IsRoleInProspectTime(roleId);
		}

		// Token: 0x060330FA RID: 209146 RVA: 0x00BE50F8 File Offset: 0x00BE32F8
		public static bool IsAnyProspectRole(int roleId)
		{
			if (!RoleDevelopUtil.IsHotRole(roleId))
			{
				return false;
			}
			int typeId = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId;
			return typeId == 1 || (typeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(roleId));
		}

		// Token: 0x060330FB RID: 209147 RVA: 0x00BE5132 File Offset: 0x00BE3332
		public static bool IsCurrentVersionProspectRole(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 2;
		}

		// Token: 0x060330FC RID: 209148 RVA: 0x00BE5151 File Offset: 0x00BE3351
		public static bool IsCurrentVersionProspectRoleInProspect(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(roleId);
		}

		// Token: 0x060330FD RID: 209149 RVA: 0x00BE5178 File Offset: 0x00BE3378
		public static bool IsCurrentVersionProspectRoleGachaValid(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 2 && RoleDevelopUtil.GetHotRoleGachaId(roleId, true) != null;
		}

		// Token: 0x060330FE RID: 209150 RVA: 0x00BE51B3 File Offset: 0x00BE33B3
		public static bool IsCurrentVersionProspectRoleValid(int roleId)
		{
			return RoleDevelopUtil.IsCurrentVersionProspectRoleInProspect(roleId) || RoleDevelopUtil.IsCurrentVersionProspectRoleGachaValid(roleId);
		}

		// Token: 0x060330FF RID: 209151 RVA: 0x00BE51C5 File Offset: 0x00BE33C5
		public static bool IsReturningRole(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 3;
		}

		// Token: 0x06033100 RID: 209152 RVA: 0x00BE51E4 File Offset: 0x00BE33E4
		public static bool IsReturningRoleInProspect(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 3 && RoleDevelopUtil.IsRoleInProspectTime(roleId);
		}

		// Token: 0x06033101 RID: 209153 RVA: 0x00BE520C File Offset: 0x00BE340C
		public static bool IsReturningRoleGachaValid(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 3 && RoleDevelopUtil.GetHotRoleGachaId(roleId, true) != null;
		}

		// Token: 0x06033102 RID: 209154 RVA: 0x00BE5247 File Offset: 0x00BE3447
		public static bool IsReturningRoleValid(int roleId)
		{
			return RoleDevelopUtil.IsReturningRoleInProspect(roleId) || RoleDevelopUtil.IsReturningRoleGachaValid(roleId);
		}

		// Token: 0x06033103 RID: 209155 RVA: 0x00BE525C File Offset: 0x00BE345C
		public static int? GetHotRoleGachaId(int id, bool checkValid = false)
		{
			if (!RoleDevelopUtil.IsHotRole(id))
			{
				return null;
			}
			int gachaId = RoleDevConfig.Instance.GetRoleDevProsListConfig(id).GachaId;
			if (checkValid && !RoleDevelopUtil.IsGachaValid(gachaId))
			{
				return null;
			}
			return new int?(gachaId);
		}

		// Token: 0x06033104 RID: 209156 RVA: 0x00BE52A8 File Offset: 0x00BE34A8
		public static List<int> GetHotRoleSpecialGachaIds(int id, bool checkValid = false)
		{
			List<int> list = new List<int>();
			if (!RoleDevelopUtil.IsHotRole(id))
			{
				return list;
			}
			foreach (IRoleDevProsSpecialGachaConfig roleDevProsSpecialGachaConfig in RoleDevConfig.Instance.GetRoleDevProsListConfig(id).SpecialGachaId)
			{
				if (!checkValid || RoleDevelopUtil.IsGachaValid(roleDevProsSpecialGachaConfig.GachaId))
				{
					list.Add(roleDevProsSpecialGachaConfig.GachaId);
				}
			}
			return list;
		}

		// Token: 0x06033105 RID: 209157 RVA: 0x00BE532C File Offset: 0x00BE352C
		public static List<int> GetHotRoleGachaIds(int id, bool checkValid = false)
		{
			List<int> list = new List<int>();
			int? hotRoleGachaId = RoleDevelopUtil.GetHotRoleGachaId(id, checkValid);
			if (hotRoleGachaId != null)
			{
				list.Add(hotRoleGachaId.Value);
			}
			List<int> hotRoleSpecialGachaIds = RoleDevelopUtil.GetHotRoleSpecialGachaIds(id, checkValid);
			list.AddRange(hotRoleSpecialGachaIds);
			return list;
		}

		// Token: 0x06033106 RID: 209158 RVA: 0x00BE536D File Offset: 0x00BE356D
		public static bool IsGachaValid(int gachaId)
		{
			return GachaModel.Instance.CheckGachaValidByGachaId(gachaId);
		}

		// Token: 0x06033107 RID: 209159 RVA: 0x00BE537A File Offset: 0x00BE357A
		public static List<int> GetHotWeaponGachaIds(int id, bool checkValid = false)
		{
			if (!RoleDevelopUtil.IsHotRole(id))
			{
				return new List<int>();
			}
			if (RoleDevConfig.Instance.GetRoleDevProsListConfig(id).TypeId != 4)
			{
				return new List<int>();
			}
			return RoleDevelopUtil.GetHotRoleGachaIds(id, checkValid);
		}

		// Token: 0x06033108 RID: 209160 RVA: 0x00BE53AC File Offset: 0x00BE35AC
		public static void OpenWeaponReplaceView(int roleId, int weaponIncId)
		{
			RoleViewViewModel roleViewViewModel = new RoleViewViewModel(roleId, !UiSceneManager.Instance.HasRoleSystemRoleActor(), ERoleViewSource.Normal);
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

		// Token: 0x06033109 RID: 209161 RVA: 0x00BE5438 File Offset: 0x00BE3638
		public static int GetDefaultRecommendPlanId(int roleId)
		{
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(roleId);
			if (roleFetterRecommendInfo == null)
			{
				return 0;
			}
			RoleDevelopUtil.SortVisionFetterRecommendInfo(roleFetterRecommendInfo);
			return roleFetterRecommendInfo[0].GetPlanId();
		}

		// Token: 0x0603310A RID: 209162 RVA: 0x00BE546C File Offset: 0x00BE366C
		public static List<int> GetDefaultRecommendFetterGroupIdList(int roleId)
		{
			List<int> list = new List<int>();
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(roleId);
			if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
			{
				return list;
			}
			RoleDevelopUtil.SortVisionFetterRecommendInfo(roleFetterRecommendInfo);
			VisionFetterRecommendInfo visionFetterRecommendInfo = roleFetterRecommendInfo[0];
			int recommendFetterGroupId = visionFetterRecommendInfo.GetRecommendFetterGroupId();
			EFetterGroupType fetterType = visionFetterRecommendInfo.GetFetterType();
			if (RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.GetPhantomSpecialGroupListArray().Contains(recommendFetterGroupId))
			{
				foreach (IVisionFetterCount visionFetterCount in visionFetterRecommendInfo.GetFetterCountList())
				{
					list.Add(visionFetterCount.GroupId);
				}
				return list;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup = (instance != null) ? instance.GetPhantomJumpGroupConfig(recommendFetterGroupId) : null;
			if (roleDevPhantomJumpGroup == null)
			{
				return list;
			}
			list.Add(recommendFetterGroupId);
			if (fetterType == EFetterGroupType.Special)
			{
				int specialFetterSubGroupId = visionFetterRecommendInfo.GetSpecialFetterSubGroupId();
				if (specialFetterSubGroupId > 0)
				{
					RoleDevConfig instance2 = RoleDevConfig.Instance;
					RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup2 = (instance2 != null) ? instance2.GetPhantomJumpGroupConfig(specialFetterSubGroupId) : null;
					if (roleDevPhantomJumpGroup2 != null)
					{
						list.Add(specialFetterSubGroupId);
					}
				}
			}
			return list;
		}

		// Token: 0x0603310B RID: 209163 RVA: 0x00BE559C File Offset: 0x00BE379C
		public static List<VisionFetterRecommendInfo> SortVisionFetterRecommendInfo(List<VisionFetterRecommendInfo> recommendInfo)
		{
			recommendInfo.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
			return recommendInfo;
		}

		// Token: 0x0603310C RID: 209164 RVA: 0x00BE55C4 File Offset: 0x00BE37C4
		public static List<RoleDevelopPhantomSuitData> CreatePhantomSuitDataList(int id, List<VisionFetterRecommendInfo> recommendInfo, int recommendPlanId, int? recommendFirstVisionMonsterId = null)
		{
			List<RoleDevelopPhantomSuitData> list = new List<RoleDevelopPhantomSuitData>();
			if (recommendInfo == null || recommendInfo.Count == 0)
			{
				return list;
			}
			VisionFetterRecommendInfo visionFetterRecommendInfo = null;
			foreach (VisionFetterRecommendInfo visionFetterRecommendInfo2 in recommendInfo)
			{
				if (visionFetterRecommendInfo2.GetPlanId() == recommendPlanId)
				{
					visionFetterRecommendInfo = visionFetterRecommendInfo2;
					break;
				}
			}
			if (visionFetterRecommendInfo == null)
			{
				foreach (VisionFetterRecommendInfo visionFetterRecommendInfo3 in recommendInfo)
				{
					if (visionFetterRecommendInfo3.GetRecommendFetterGroupId() == recommendPlanId)
					{
						visionFetterRecommendInfo = visionFetterRecommendInfo3;
						break;
					}
				}
			}
			if (visionFetterRecommendInfo == null)
			{
				return list;
			}
			int recommendFetterGroupId = visionFetterRecommendInfo.GetRecommendFetterGroupId();
			EFetterGroupType fetterType = visionFetterRecommendInfo.GetFetterType();
			if (RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.GetPhantomSpecialGroupListArray().Contains(recommendFetterGroupId))
			{
				foreach (IVisionFetterCount visionFetterCount in visionFetterRecommendInfo.GetFetterCountList())
				{
					list.Add(new RoleDevelopPhantomSuitData
					{
						DevelopRoleId = id,
						FetterGroupId = visionFetterCount.GroupId,
						VisionFetterRecommendInfo = visionFetterRecommendInfo,
						FirstVisionMonsterId = recommendFirstVisionMonsterId
					});
				}
				return list;
			}
			RoleDevConfig instance = RoleDevConfig.Instance;
			RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup = (instance != null) ? instance.GetPhantomJumpGroupConfig(recommendFetterGroupId) : null;
			if (roleDevPhantomJumpGroup == null)
			{
				return list;
			}
			list.Add(new RoleDevelopPhantomSuitData
			{
				DevelopRoleId = id,
				FetterGroupId = recommendFetterGroupId,
				VisionFetterRecommendInfo = visionFetterRecommendInfo,
				FirstVisionMonsterId = recommendFirstVisionMonsterId
			});
			if (fetterType == EFetterGroupType.Special)
			{
				int specialFetterSubGroupId = visionFetterRecommendInfo.GetSpecialFetterSubGroupId();
				if (specialFetterSubGroupId > 0)
				{
					RoleDevConfig instance2 = RoleDevConfig.Instance;
					RoleDevPhantomJumpGroup? roleDevPhantomJumpGroup2 = (instance2 != null) ? instance2.GetPhantomJumpGroupConfig(specialFetterSubGroupId) : null;
					if (roleDevPhantomJumpGroup2 != null)
					{
						list.Add(new RoleDevelopPhantomSuitData
						{
							DevelopRoleId = id,
							FetterGroupId = specialFetterSubGroupId,
							VisionFetterRecommendInfo = visionFetterRecommendInfo,
							FirstVisionMonsterId = recommendFirstVisionMonsterId
						});
					}
				}
			}
			return list;
		}

		// Token: 0x0603310D RID: 209165 RVA: 0x00BE57D0 File Offset: 0x00BE39D0
		public static RoleDevelopPhantomVisionSuitItemData CreateFetterGroupVisionSuitItem(int fetterGroupId, int roleId, int firstVisionMonsterId)
		{
			Aki.Config.PhantomItem phantomItem = PhantomBattleConfig.Instance.GetPhantomItemByMonsterId(firstVisionMonsterId)[0];
			return new RoleDevelopPhantomVisionSuitItemData
			{
				Name = phantomItem.MonsterName,
				ButtonName = "RoleProject_Button02",
				ItemType = EPhantomSuitItemType.Phantom,
				TypeIcon = "",
				MonsterDataList = new List<PhantomMonsterItemData>
				{
					new PhantomMonsterItemData
					{
						MonsterId = phantomItem.MonsterId,
						QualityId = 0,
						RoleId = roleId
					}
				},
				DungeonId = 0,
				FetterGroupId = fetterGroupId,
				RoleId = roleId,
				LogRoleId = new int?(roleId),
				LogMainPage = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Phantom),
				LogSubPage = new ERoleDevelopLogSubPage?(ERoleDevelopLogSubPage.PhantomDevelopFirstVision)
			};
		}

		// Token: 0x0603310E RID: 209166 RVA: 0x00BE588C File Offset: 0x00BE3A8C
		public static RoleDevelopPhantomVisionSuitItemData CreateDungeonVisionSuitItem(int dungeonId, int roleId)
		{
			if (dungeonId == 0)
			{
				return null;
			}
			AdventureGuideModel instance = AdventureGuideModel.Instance;
			SilentAreaDetectionRecord silentAreaDetectionRecord = (instance != null) ? instance.GetSilentAreaDetectData(dungeonId) : null;
			if (silentAreaDetectionRecord == null || silentAreaDetectionRecord.IsLock)
			{
				return null;
			}
			SilentAreaDetection conf = silentAreaDetectionRecord.Conf;
			bool flag = conf.Secondary == 63 || conf.Secondary == 64;
			return new RoleDevelopPhantomVisionSuitItemData
			{
				Name = (conf.Name ?? ""),
				ButtonName = "RoleProject_Button03",
				ItemType = EPhantomSuitItemType.Dungeon,
				TypeIcon = conf.BigIcon,
				MonsterDataList = new List<PhantomMonsterItemData>(),
				RewardDataList = RoleDevelopUtil.GetDungeonDropRewards(conf),
				DungeonId = dungeonId,
				FetterGroupId = 0,
				RoleId = 0,
				LogRoleId = new int?(roleId),
				LogMainPage = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Phantom),
				LogSubPage = new ERoleDevelopLogSubPage?(flag ? ERoleDevelopLogSubPage.PhantomDevelopNightMare : ERoleDevelopLogSubPage.PhantomDevelopVision)
			};
		}

		// Token: 0x0603310F RID: 209167 RVA: 0x00BE5974 File Offset: 0x00BE3B74
		private static List<DropRewardItemData> GetDungeonDropRewards(SilentAreaDetection conf)
		{
			List<DropRewardItemData> list = new List<DropRewardItemData>();
			if (conf.ShowRewardMapLength != 0)
			{
				Dictionary<int, int> dictionary = (conf.Secondary == 63 || conf.Secondary == 64) ? AdventureGuideConfig.Instance.GetNightMareShowReward(conf.ShowRewardMapCalabash()) : AdventureGuideConfig.Instance.GetShowReward(conf.ShowRewardMap(), null);
				if (dictionary != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair in dictionary)
					{
						int key = keyValuePair.Key;
						int value = keyValuePair.Value;
						list.Add(new DropRewardItemData
						{
							ItemId = key,
							Count = value,
							HaveFinish = false
						});
					}
				}
			}
			return list;
		}

		// Token: 0x06033110 RID: 209168 RVA: 0x00BE5A4C File Offset: 0x00BE3C4C
		public static Dictionary<EItemMaterialType, int> ConvertSkillItemJumpTypes(List<IntArray> skillItemJumpTypes)
		{
			Dictionary<EItemMaterialType, int> dictionary = new Dictionary<EItemMaterialType, int>();
			foreach (IntArray intArray in skillItemJumpTypes)
			{
				if (intArray.ArrayIntLength >= 2)
				{
					EItemMaterialType key = (EItemMaterialType)intArray.GetArrayIntArray()[0];
					int value = intArray.GetArrayIntArray()[1];
					dictionary[key] = value;
				}
			}
			return dictionary;
		}

		// Token: 0x06033111 RID: 209169 RVA: 0x00BE5AC4 File Offset: 0x00BE3CC4
		public static bool HandleItemJump(int roleId, RoleDevelopItemGroup groupItem)
		{
			Dictionary<EItemMaterialType, int> dictionary;
			if (RoleDevelopUtil.IsProspectRole(roleId))
			{
				dictionary = new Dictionary<EItemMaterialType, int>();
			}
			else
			{
				dictionary = RoleDevelopUtil.ConvertSkillItemJumpTypes(new List<IntArray>(RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId).Value.SkillItemJumpType()));
			}
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in groupItem.Items)
			{
				if (!RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
					if (itemJumpGroupConfig != null)
					{
						EItemMaterialType itemType = (EItemMaterialType)itemJumpGroupConfig.Value.ItemType;
						int detectionType = itemJumpGroupConfig.Value.DetectionType;
						EItemMaterialType key = itemType;
						int priorityIndex = dictionary.ContainsKey(key) ? dictionary[key] : 0;
						bool flag;
						if (detectionType == 1)
						{
							flag = RoleDevelopUtil.HandleDungeonDetectionJump(new List<int>(itemJumpGroupConfig.Value.DetectionID()), priorityIndex);
						}
						else if (detectionType == 2)
						{
							flag = RoleDevelopUtil.HandleSilentDetectionJump(new List<int>(itemJumpGroupConfig.Value.DetectionID()), priorityIndex);
						}
						else
						{
							flag = RoleDevelopUtil.HandlePathJump(new List<int>(itemJumpGroupConfig.Value.JumpGroup()), roleDevelopNeedItem.ItemId);
						}
						if (flag)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06033112 RID: 209170 RVA: 0x00BE5C44 File Offset: 0x00BE3E44
		public static bool HandlePathJump(List<int> ids, int itemId)
		{
			foreach (int num in ids)
			{
				if (RoleDevelopUtil.CheckAccessPathUnlocked(num))
				{
					SkipTaskManager.RunByConfigId(num, itemId);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06033113 RID: 209171 RVA: 0x00BE5CA8 File Offset: 0x00BE3EA8
		public static bool CheckAccessPathUnlocked(int accessPathId)
		{
			SkipInterfaceConfig instance = SkipInterfaceConfig.Instance;
			AccessPath? accessPath = (instance != null) ? instance.GetAccessPathConfig(accessPathId) : null;
			return accessPath == null || accessPath.Value.SkipName != 2 || RoleDevelopUtil.CheckDungeonAccessUnlocked(accessPath.Value);
		}

		// Token: 0x06033114 RID: 209172 RVA: 0x00BE5CFC File Offset: 0x00BE3EFC
		public static bool CheckDungeonAccessUnlocked(AccessPath config)
		{
			int id = int.Parse(config.Val1);
			InstanceDungeonEntrance? config2 = InstanceDungeonEntranceConfig.Instance.GetConfig(id);
			bool flag = false;
			foreach (int instanceId in config2.Value.GetInstanceDungeonListArray())
			{
				InstanceDungeonEntranceModel instance = InstanceDungeonEntranceModel.Instance;
				if (instance != null && instance.CheckInstanceUnlock(instanceId))
				{
					flag = true;
					break;
				}
			}
			int markId = int.Parse(config.Val3);
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			int areaId = MapConfig.Instance.GetEntityConfigByMapIdAndEntityId(configMark.Value.MapId, configMark.Value.EntityConfigId).Value.AreaId;
			Aki.Config.Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			int areaId2 = (areaInfo != null) ? AreaModel.Instance.GetAreaId(areaInfo.Value, new EAreaLevel?(EAreaLevel.FirstLevel)) : 0;
			bool flag2 = MapModel.Instance.CheckAreasUnlocked(areaId2, true);
			return flag && flag2;
		}

		// Token: 0x06033115 RID: 209173 RVA: 0x00BE5E08 File Offset: 0x00BE4008
		public static bool HandleSilentDetectionJump(List<int> ids, int priorityIndex)
		{
			if (ids == null || ids.Count == 0)
			{
				return false;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return false;
			}
			if (priorityIndex > 0 && priorityIndex <= ids.Count && RoleDevelopUtil.TryJumpSingleSilentAreaDetection(ids[priorityIndex - 1], false))
			{
				return true;
			}
			using (List<int>.Enumerator enumerator = ids.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleDevelopUtil.TryJumpSingleSilentAreaDetection(enumerator.Current, false))
					{
						return true;
					}
				}
			}
			return RoleDevelopUtil.TryJumpSingleSilentAreaDetection(ids[ids.Count - 1], true);
		}

		// Token: 0x06033116 RID: 209174 RVA: 0x00BE5EC0 File Offset: 0x00BE40C0
		public static bool HandleDungeonDetectionJump(List<int> ids, int priorityIndex)
		{
			if (ids == null || ids.Count == 0)
			{
				return false;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return false;
			}
			if (priorityIndex > 0 && priorityIndex <= ids.Count && RoleDevelopUtil.TryJumpSingleDungeonDetection(ids[priorityIndex - 1], false))
			{
				return true;
			}
			using (List<int>.Enumerator enumerator = ids.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (RoleDevelopUtil.TryJumpSingleDungeonDetection(enumerator.Current, false))
					{
						return true;
					}
				}
			}
			return RoleDevelopUtil.TryJumpSingleDungeonDetection(ids[ids.Count - 1], true);
		}

		// Token: 0x06033117 RID: 209175 RVA: 0x00BE5F78 File Offset: 0x00BE4178
		private static bool TryPreOpenDetectionJump(int detectionId, ESoundAreaDataType soundAreaType, int preOpenId)
		{
			if (OnlineModel.Instance.GetIsTeamModel())
			{
				return false;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreOpenSpoilConfirmBoxFromRoleDev);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				AdventureGuideController.Instance.HandlePreOpenDetection(detectionId, soundAreaType, preOpenId);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}

		// Token: 0x06033118 RID: 209176 RVA: 0x00BE5FE0 File Offset: 0x00BE41E0
		private static bool FocalDetectionMark(int markId)
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markId);
			if (configMark == null)
			{
				return false;
			}
			WorldMapController.Instance.FocalMarkItem((EMarkType)configMark.Value.ObjectType, markId);
			return true;
		}

		// Token: 0x06033119 RID: 209177 RVA: 0x00BE6020 File Offset: 0x00BE4220
		private static bool TryJumpSingleDungeonDetection(int detectionConfId, bool skipUnlockCheck = false)
		{
			if (detectionConfId == 0)
			{
				return false;
			}
			DungeonDetectionRecord soundAreaDetectData = AdventureGuideModel.Instance.GetSoundAreaDetectData(detectionConfId);
			if (soundAreaDetectData == null)
			{
				return false;
			}
			bool isDetectionPreOpenByRecord = AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(soundAreaDetectData);
			if (soundAreaDetectData.IsLock)
			{
				if (isDetectionPreOpenByRecord)
				{
					return RoleDevelopUtil.TryPreOpenDetectionJump(soundAreaDetectData.Conf.Id, ESoundAreaDataType.Dungeon, soundAreaDetectData.Conf.PreOpenId);
				}
				if (skipUnlockCheck)
				{
					InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(soundAreaDetectData.Conf.DungeonId);
					if (config != null)
					{
						return RoleDevelopUtil.FocalDetectionMark(config.Value.MarkId);
					}
				}
				return false;
			}
			else
			{
				if (isDetectionPreOpenByRecord)
				{
					return RoleDevelopUtil.TryPreOpenDetectionJump(soundAreaDetectData.Conf.Id, ESoundAreaDataType.Dungeon, soundAreaDetectData.Conf.PreOpenId);
				}
				InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(soundAreaDetectData.Conf.DungeonId);
				if (config == null)
				{
					return false;
				}
				if (AdventureGuideModel.Instance.TryAdventureJumpByDungeon(soundAreaDetectData))
				{
					return true;
				}
				if (!skipUnlockCheck)
				{
					if (!AdventureGuideController.Instance.IsMarkUnlock(config.Value.MarkId))
					{
						return false;
					}
					if (!MapModel.Instance.CheckTeleportUnlocked(config.Value.MarkId))
					{
						return false;
					}
				}
				DetectionType type = (soundAreaDetectData.Conf.Secondary != 2) ? DetectionType.Dungeon : DetectionType.SilentArea;
				AdventureGuideModel.Instance.SetFromManualDetect(true);
				AdventureGuideController.Instance.RequestForDetection(type, new int[]
				{
					soundAreaDetectData.Conf.DungeonId
				}, soundAreaDetectData.Conf.Id);
				return true;
			}
		}

		// Token: 0x0603311A RID: 209178 RVA: 0x00BE61B0 File Offset: 0x00BE43B0
		private static bool TryJumpSingleSilentAreaDetection(int detectionConfId, bool skipUnlockCheck = false)
		{
			if (detectionConfId == 0)
			{
				return false;
			}
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(detectionConfId);
			if (silentAreaDetectData == null)
			{
				return false;
			}
			bool isDetectionPreOpenByRecord = AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(silentAreaDetectData);
			if (silentAreaDetectData.IsLock)
			{
				if (isDetectionPreOpenByRecord)
				{
					return RoleDevelopUtil.TryPreOpenDetectionJump(silentAreaDetectData.Conf.Id, ESoundAreaDataType.SilentArea, silentAreaDetectData.Conf.PreOpenId);
				}
				return skipUnlockCheck && RoleDevelopUtil.FocalDetectionMark(silentAreaDetectData.Conf.MarkId);
			}
			else
			{
				if (isDetectionPreOpenByRecord)
				{
					return RoleDevelopUtil.TryPreOpenDetectionJump(silentAreaDetectData.Conf.Id, ESoundAreaDataType.SilentArea, silentAreaDetectData.Conf.PreOpenId);
				}
				if (AdventureGuideModel.Instance.TryAdventureJumpBySilent(silentAreaDetectData))
				{
					return true;
				}
				if (!skipUnlockCheck)
				{
					if (!AdventureGuideController.Instance.IsMarkUnlock(silentAreaDetectData.Conf.MarkId))
					{
						return false;
					}
					if (!MapModel.Instance.CheckTeleportUnlocked(silentAreaDetectData.Conf.MarkId))
					{
						return false;
					}
				}
				AdventureGuideModel.Instance.SetFromManualDetect(true);
				AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.GetLevelPlayListArray(), silentAreaDetectData.Conf.Id);
				return true;
			}
		}

		// Token: 0x0603311B RID: 209179 RVA: 0x00BE62CC File Offset: 0x00BE44CC
		public static bool IsDungeonShowDouble(EDungeonType dungeonType)
		{
			ActivityDoubleRewardData adventureUpActivity = ActivityDoubleRewardController.Instance.GetAdventureUpActivity(dungeonType);
			return (adventureUpActivity != null && adventureUpActivity.LeftUpCount > 0) || ActivityRegressModel.Instance.IsHasDoubleDrop(dungeonType);
		}

		// Token: 0x0603311C RID: 209180 RVA: 0x00BE6304 File Offset: 0x00BE4504
		public static List<EDungeonType> GetDungeonTypesByItemDetection(List<RoleDevelopNeedItem> items)
		{
			HashSet<EDungeonType> hashSet = new HashSet<EDungeonType>();
			AdventureGuideModel instance = AdventureGuideModel.Instance;
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in items)
			{
				if (!RoleDevelopUtil.IsUnknownItem(roleDevelopNeedItem.ItemId))
				{
					RoleDevItemJumpGroup? itemJumpGroupConfig = RoleDevConfig.Instance.GetItemJumpGroupConfig(roleDevelopNeedItem.ItemId);
					if (itemJumpGroupConfig != null)
					{
						int detectionType = itemJumpGroupConfig.Value.DetectionType;
						foreach (int id in itemJumpGroupConfig.Value.DetectionID())
						{
							EDungeonType? edungeonType = null;
							if (detectionType == 1)
							{
								DungeonDetectionRecord soundAreaDetectData = instance.GetSoundAreaDetectData(id);
								if (soundAreaDetectData != null)
								{
									edungeonType = new EDungeonType?((EDungeonType)soundAreaDetectData.Conf.Secondary);
								}
							}
							else if (detectionType == 2)
							{
								SilentAreaDetectionRecord silentAreaDetectData = instance.GetSilentAreaDetectData(id);
								if (silentAreaDetectData != null)
								{
									edungeonType = new EDungeonType?((EDungeonType)silentAreaDetectData.Conf.Secondary);
								}
							}
							if (edungeonType != null)
							{
								hashSet.Add(edungeonType.Value);
							}
						}
					}
				}
			}
			return hashSet.ToList<EDungeonType>();
		}
	}
}
