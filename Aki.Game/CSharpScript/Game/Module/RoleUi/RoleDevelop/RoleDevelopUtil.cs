using System;
using System.Collections.Generic;
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
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CF3 RID: 15603
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopUtil
	{
		// Token: 0x06027EDB RID: 163547 RVA: 0x00B2A448 File Offset: 0x00B28648
		public static bool IsHotRoleDevelopValid(int roleProspectId)
		{
			if (!RoleDevelopUtil.IsHotRole(roleProspectId))
			{
				return false;
			}
			int typeId = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleProspectId).TypeId;
			return (typeId != 1 || RoleDevelopUtil.IsRoleInProspectTime(roleProspectId)) && typeId != 0 && typeId != 4;
		}

		// Token: 0x06027EDC RID: 163548 RVA: 0x00B2A488 File Offset: 0x00B28688
		public static RoleDevCultivateProject? GetCultivateProject(int roleId)
		{
			int? cultivateProjectId = RoleDevelopUtil.GetCultivateProjectId(roleId);
			if (cultivateProjectId == null)
			{
				return null;
			}
			return RoleDevConfig.Instance.GetCultivateProjectConfig(cultivateProjectId.Value);
		}

		// Token: 0x06027EDD RID: 163549 RVA: 0x00B2A4C0 File Offset: 0x00B286C0
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

		// Token: 0x06027EDE RID: 163550 RVA: 0x00B2A508 File Offset: 0x00B28708
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

		// Token: 0x06027EDF RID: 163551 RVA: 0x00B2A5A4 File Offset: 0x00B287A4
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

		// Token: 0x06027EE0 RID: 163552 RVA: 0x00B2A61C File Offset: 0x00B2881C
		public static bool IsUnknownItem(int itemId)
		{
			return itemId == RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.UnknownItemId;
		}

		// Token: 0x06027EE1 RID: 163553 RVA: 0x00B2A648 File Offset: 0x00B28848
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

		// Token: 0x06027EE2 RID: 163554 RVA: 0x00B2A6B8 File Offset: 0x00B288B8
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

		// Token: 0x06027EE3 RID: 163555 RVA: 0x00B2A714 File Offset: 0x00B28914
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

		// Token: 0x06027EE4 RID: 163556 RVA: 0x00B2A73C File Offset: 0x00B2893C
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

		// Token: 0x06027EE5 RID: 163557 RVA: 0x00B2A8B0 File Offset: 0x00B28AB0
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

		// Token: 0x06027EE6 RID: 163558 RVA: 0x00B2AB94 File Offset: 0x00B28D94
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

		// Token: 0x06027EE7 RID: 163559 RVA: 0x00B2AC44 File Offset: 0x00B28E44
		public static bool IsHotRole(int roleId)
		{
			return RoleDevConfig.Instance.HasRoleDevProsListConfig(roleId);
		}

		// Token: 0x06027EE8 RID: 163560 RVA: 0x00B2AC54 File Offset: 0x00B28E54
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

		// Token: 0x06027EE9 RID: 163561 RVA: 0x00B2ACA9 File Offset: 0x00B28EA9
		public static bool IsProspectRole(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 1;
		}

		// Token: 0x06027EEA RID: 163562 RVA: 0x00B2ACC8 File Offset: 0x00B28EC8
		public static bool IsProspectRoleValid(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 1 && RoleDevelopUtil.IsRoleInProspectTime(roleId);
		}

		// Token: 0x06027EEB RID: 163563 RVA: 0x00B2ACF0 File Offset: 0x00B28EF0
		public static bool IsAnyProspectRole(int roleId)
		{
			if (!RoleDevelopUtil.IsHotRole(roleId))
			{
				return false;
			}
			int typeId = RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId;
			return typeId == 1 || (typeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(roleId));
		}

		// Token: 0x06027EEC RID: 163564 RVA: 0x00B2AD2A File Offset: 0x00B28F2A
		public static bool IsCurrentVersionProspectRole(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 2;
		}

		// Token: 0x06027EED RID: 163565 RVA: 0x00B2AD49 File Offset: 0x00B28F49
		public static bool IsCurrentVersionProspectRoleInProspect(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 2 && RoleDevelopUtil.IsRoleInProspectTime(roleId);
		}

		// Token: 0x06027EEE RID: 163566 RVA: 0x00B2AD70 File Offset: 0x00B28F70
		public static bool IsCurrentVersionProspectRoleGachaValid(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 2 && RoleDevelopUtil.GetHotRoleGachaId(roleId, true) != null;
		}

		// Token: 0x06027EEF RID: 163567 RVA: 0x00B2ADAB File Offset: 0x00B28FAB
		public static bool IsCurrentVersionProspectRoleValid(int roleId)
		{
			return RoleDevelopUtil.IsCurrentVersionProspectRoleInProspect(roleId) || RoleDevelopUtil.IsCurrentVersionProspectRoleGachaValid(roleId);
		}

		// Token: 0x06027EF0 RID: 163568 RVA: 0x00B2ADBD File Offset: 0x00B28FBD
		public static bool IsReturningRole(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 3;
		}

		// Token: 0x06027EF1 RID: 163569 RVA: 0x00B2ADDC File Offset: 0x00B28FDC
		public static bool IsReturningRoleInProspect(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 3 && RoleDevelopUtil.IsRoleInProspectTime(roleId);
		}

		// Token: 0x06027EF2 RID: 163570 RVA: 0x00B2AE04 File Offset: 0x00B29004
		public static bool IsReturningRoleGachaValid(int roleId)
		{
			return RoleDevelopUtil.IsHotRole(roleId) && RoleDevConfig.Instance.GetRoleDevProsListConfig(roleId).TypeId == 3 && RoleDevelopUtil.GetHotRoleGachaId(roleId, true) != null;
		}

		// Token: 0x06027EF3 RID: 163571 RVA: 0x00B2AE3F File Offset: 0x00B2903F
		public static bool IsReturningRoleValid(int roleId)
		{
			return RoleDevelopUtil.IsReturningRoleInProspect(roleId) || RoleDevelopUtil.IsReturningRoleGachaValid(roleId);
		}

		// Token: 0x06027EF4 RID: 163572 RVA: 0x00B2AE54 File Offset: 0x00B29054
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

		// Token: 0x06027EF5 RID: 163573 RVA: 0x00B2AEA0 File Offset: 0x00B290A0
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

		// Token: 0x06027EF6 RID: 163574 RVA: 0x00B2AF24 File Offset: 0x00B29124
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

		// Token: 0x06027EF7 RID: 163575 RVA: 0x00B2AF65 File Offset: 0x00B29165
		public static bool IsGachaValid(int gachaId)
		{
			return GachaModel.Instance.CheckGachaValidByGachaId(gachaId);
		}

		// Token: 0x06027EF8 RID: 163576 RVA: 0x00B2AF72 File Offset: 0x00B29172
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

		// Token: 0x06027EF9 RID: 163577 RVA: 0x00B2AFA4 File Offset: 0x00B291A4
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

		// Token: 0x06027EFA RID: 163578 RVA: 0x00B2B030 File Offset: 0x00B29230
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

		// Token: 0x06027EFB RID: 163579 RVA: 0x00B2B064 File Offset: 0x00B29264
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
			if (NoLinq.Contains<int>(RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.GetPhantomSpecialGroupListBytes(), recommendFetterGroupId))
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

		// Token: 0x06027EFC RID: 163580 RVA: 0x00B2B194 File Offset: 0x00B29394
		public static List<VisionFetterRecommendInfo> SortVisionFetterRecommendInfo(List<VisionFetterRecommendInfo> recommendInfo)
		{
			recommendInfo.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
			return recommendInfo;
		}

		// Token: 0x06027EFD RID: 163581 RVA: 0x00B2B1BC File Offset: 0x00B293BC
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
			if (NoLinq.Contains<int>(RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.GetPhantomSpecialGroupListBytes(), recommendFetterGroupId))
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

		// Token: 0x06027EFE RID: 163582 RVA: 0x00B2B3C8 File Offset: 0x00B295C8
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

		// Token: 0x06027EFF RID: 163583 RVA: 0x00B2B484 File Offset: 0x00B29684
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

		// Token: 0x06027F00 RID: 163584 RVA: 0x00B2B56C File Offset: 0x00B2976C
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

		// Token: 0x06027F01 RID: 163585 RVA: 0x00B2B644 File Offset: 0x00B29844
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

		// Token: 0x06027F02 RID: 163586 RVA: 0x00B2B6BC File Offset: 0x00B298BC
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

		// Token: 0x06027F03 RID: 163587 RVA: 0x00B2B83C File Offset: 0x00B29A3C
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

		// Token: 0x06027F04 RID: 163588 RVA: 0x00B2B8A0 File Offset: 0x00B29AA0
		public static bool CheckAccessPathUnlocked(int accessPathId)
		{
			SkipInterfaceConfig instance = SkipInterfaceConfig.Instance;
			AccessPath? accessPath = (instance != null) ? instance.GetAccessPathConfig(accessPathId) : null;
			return accessPath == null || accessPath.Value.SkipName != 2 || RoleDevelopUtil.CheckDungeonAccessUnlocked(accessPath.Value);
		}

		// Token: 0x06027F05 RID: 163589 RVA: 0x00B2B8F4 File Offset: 0x00B29AF4
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

		// Token: 0x06027F06 RID: 163590 RVA: 0x00B2BA00 File Offset: 0x00B29C00
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

		// Token: 0x06027F07 RID: 163591 RVA: 0x00B2BAB8 File Offset: 0x00B29CB8
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

		// Token: 0x06027F08 RID: 163592 RVA: 0x00B2BB70 File Offset: 0x00B29D70
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

		// Token: 0x06027F09 RID: 163593 RVA: 0x00B2BBD8 File Offset: 0x00B29DD8
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

		// Token: 0x06027F0A RID: 163594 RVA: 0x00B2BC18 File Offset: 0x00B29E18
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

		// Token: 0x06027F0B RID: 163595 RVA: 0x00B2BDA8 File Offset: 0x00B29FA8
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

		// Token: 0x06027F0C RID: 163596 RVA: 0x00B2BEC4 File Offset: 0x00B2A0C4
		public static bool IsDungeonShowDouble(EDungeonType dungeonType)
		{
			ActivityDoubleRewardData adventureUpActivity = ActivityDoubleRewardController.Instance.GetAdventureUpActivity(dungeonType);
			return (adventureUpActivity != null && adventureUpActivity.LeftUpCount > 0) || ActivityRegressModel.Instance.IsHasDoubleDrop(dungeonType);
		}

		// Token: 0x06027F0D RID: 163597 RVA: 0x00B2BEFC File Offset: 0x00B2A0FC
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
			return new List<EDungeonType>(hashSet);
		}

		// Token: 0x06027F0E RID: 163598 RVA: 0x00B2C050 File Offset: 0x00B2A250
		public static ERoleDevelopRoleState GetRoleState(int roleId)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId);
			if (roleDevelopData == null)
			{
				return ERoleDevelopRoleState.Complete;
			}
			RoleDevelopRoleBaseData developRoleData = roleDevelopData.GetDevelopRoleData();
			if (developRoleData.GetRoleLevel() < developRoleData.GetRoleTargetLevel())
			{
				return ERoleDevelopRoleState.LevelNotEnough;
			}
			return ERoleDevelopRoleState.Complete;
		}

		// Token: 0x06027F0F RID: 163599 RVA: 0x00B2C088 File Offset: 0x00B2A288
		public static ERoleDevelopWeaponState GetWeaponState(int roleId)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId);
			if (roleDevelopData == null)
			{
				return ERoleDevelopWeaponState.Complete;
			}
			RoleDevelopRoleBaseData developRoleData = roleDevelopData.GetDevelopRoleData();
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			if (weaponInstance == null)
			{
				return ERoleDevelopWeaponState.NotEquipped;
			}
			int weaponQualityThreshold = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.WeaponQualityThreshold;
			if (weaponInstance.GetItemConfig().QualityId < weaponQualityThreshold)
			{
				return ERoleDevelopWeaponState.QualityLow;
			}
			if (developRoleData.GetWeaponLevel() < developRoleData.GetWeaponTargetLevel())
			{
				return ERoleDevelopWeaponState.LevelNotEnough;
			}
			return ERoleDevelopWeaponState.Complete;
		}

		// Token: 0x06027F10 RID: 163600 RVA: 0x00B2C0FC File Offset: 0x00B2A2FC
		public static ERoleDevelopPhantomState GetPhantomState(int roleId)
		{
			RoleDevCulProjectConfig value = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value;
			int phantomNumThreshold = value.PhantomNumThreshold;
			int phantomQualityThreshold = value.PhantomQualityThreshold;
			int phantomLevelThreshold = value.PhantomLevelThreshold;
			List<int> incrIdList = PhantomBattleModel.Instance.GetBattleDataById(roleId).GetIncrIdList();
			List<PhantomBattleData> list = new List<PhantomBattleData>();
			foreach (int num in incrIdList)
			{
				if (num > 0)
				{
					PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(num);
					if (phantomBattleData != null)
					{
						list.Add(phantomBattleData);
					}
				}
			}
			int num2 = (phantomNumThreshold > 0) ? phantomNumThreshold : incrIdList.Count;
			if (list.Count < num2)
			{
				return ERoleDevelopPhantomState.CountNotEnough;
			}
			if (RoleDevelopUtil.GetFetterTriggerCount(list) < 5)
			{
				return ERoleDevelopPhantomState.FetterNotTriggered;
			}
			using (List<PhantomBattleData>.Enumerator enumerator2 = list.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current.GetQuality() < phantomQualityThreshold)
					{
						return ERoleDevelopPhantomState.QualityLow;
					}
				}
			}
			foreach (PhantomBattleData phantomBattleData2 in list)
			{
				int num3 = (phantomLevelThreshold > 0) ? phantomLevelThreshold : phantomBattleData2.GetLevelLimit();
				if (phantomBattleData2.GetPhantomLevel() < num3)
				{
					return ERoleDevelopPhantomState.LevelNotEnough;
				}
			}
			foreach (PhantomBattleData phantomBattleData3 in list)
			{
				if (phantomBattleData3.GetIfHaveUnIdentifySubProp() || phantomBattleData3.GetIfHaveLockSubProp())
				{
					return ERoleDevelopPhantomState.SubPropLocked;
				}
			}
			return ERoleDevelopPhantomState.Complete;
		}

		// Token: 0x06027F11 RID: 163601 RVA: 0x00B2C2C8 File Offset: 0x00B2A4C8
		public static ERoleDevelopSkillState GetSkillState(int roleId)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId);
			if (roleDevelopData == null)
			{
				return ERoleDevelopSkillState.Complete;
			}
			if (!roleDevelopData.GetProjectData().IsSkillPlanFinished())
			{
				return ERoleDevelopSkillState.PlanNotFinished;
			}
			return ERoleDevelopSkillState.Complete;
		}

		// Token: 0x06027F12 RID: 163602 RVA: 0x00B2C2F8 File Offset: 0x00B2A4F8
		public static ERoleDevelopCategoryHintType GetCategoryHintType(int roleId, ERoleDevelopCategoryType categoryType)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId);
			if (roleDevelopData == null)
			{
				return ERoleDevelopCategoryHintType.None;
			}
			return RoleDevelopUtil.GetCategoryHintType(roleDevelopData.GetProjectData(), categoryType);
		}

		// Token: 0x06027F13 RID: 163603 RVA: 0x00B2C322 File Offset: 0x00B2A522
		public static ERoleDevelopCategoryHintType GetCategoryHintType(RoleDevelopProjectBaseData projectData, ERoleDevelopCategoryType categoryType)
		{
			if (projectData.IsShowFinishHint(categoryType))
			{
				return ERoleDevelopCategoryHintType.Finish;
			}
			if (projectData.IsShowUpgradeHint(categoryType))
			{
				return ERoleDevelopCategoryHintType.Upgrade;
			}
			if (projectData.IsShowCanImproveHint(categoryType))
			{
				return ERoleDevelopCategoryHintType.CanImprove;
			}
			return ERoleDevelopCategoryHintType.None;
		}

		// Token: 0x06027F14 RID: 163604 RVA: 0x00B2C348 File Offset: 0x00B2A548
		public static bool IsKeyPropertyReached(int roleId)
		{
			bool roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId) != null;
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(roleId);
			if (!roleDevelopData || roleInstanceById == null)
			{
				return false;
			}
			RoleDevProject? roleDevProjectConfig = RoleDevConfig.Instance.GetRoleDevProjectConfig(roleId);
			if (roleDevProjectConfig == null)
			{
				return false;
			}
			int keyProperty = roleDevProjectConfig.Value.KeyProperty;
			return keyProperty != 0 && roleInstanceById.GetAttributeData().GetAttrValueById(keyProperty) >= roleDevProjectConfig.Value.PropertyValue(1);
		}

		// Token: 0x06027F15 RID: 163605 RVA: 0x00B2C3C0 File Offset: 0x00B2A5C0
		public static ERoleDevelopItemState GetItemState(int roleId)
		{
			RoleDevelopData roleDevelopData = RoleDevelopModel.Instance.GetRoleDevelopData(roleId);
			if (roleDevelopData == null)
			{
				return ERoleDevelopItemState.Enough;
			}
			List<RoleDevelopNeedItem> list = RoleDevelopUtil.GetAllDevelopNeedItems(roleDevelopData.GetProjectData());
			if (RoleDevelopUtil.IsAnyProspectRole(roleId))
			{
				int unknownItemId = RoleDevConfig.Instance.GetRoleDevStaticConfig().Value.UnknownItemId;
				list = list.FindAll((RoleDevelopNeedItem item) => item.ItemId != unknownItemId);
			}
			if (!RoleDevelopUtil.CheckIsAllNeedItemsEnough(list))
			{
				return ERoleDevelopItemState.NotEnough;
			}
			return ERoleDevelopItemState.Enough;
		}

		// Token: 0x06027F16 RID: 163606 RVA: 0x00B2C438 File Offset: 0x00B2A638
		public static List<RoleDevelopNeedItem> GetAllDevelopNeedItems(RoleDevelopProjectBaseData projectData)
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			list.AddRange(projectData.GetRoleUpgradeNeedItems());
			list.AddRange(projectData.GetRoleBreachNeedItems());
			list.AddRange(projectData.GetWeaponUpgradeNeedItems());
			list.AddRange(projectData.GetWeaponBreachNeedItems());
			list.AddRange(projectData.GetSkillPlanNeedItems());
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in list)
			{
				int num;
				dictionary.TryGetValue(roleDevelopNeedItem.ItemId, out num);
				dictionary[roleDevelopNeedItem.ItemId] = num + roleDevelopNeedItem.Count;
			}
			List<RoleDevelopNeedItem> list2 = new List<RoleDevelopNeedItem>();
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int itemId = num2;
				int count = num3;
				list2.Add(new RoleDevelopNeedItem
				{
					ItemId = itemId,
					Count = count
				});
			}
			return list2;
		}

		// Token: 0x06027F17 RID: 163607 RVA: 0x00B2C558 File Offset: 0x00B2A758
		private static int GetFetterTriggerCount(List<PhantomBattleData> phantomDataList)
		{
			Dictionary<int, int> dictionary = PhantomDataBase.CalculateFetterByPhantomBattleData(new List<PhantomDataBase>(phantomDataList));
			if (dictionary == null)
			{
				return 0;
			}
			int num = 0;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int groupId = num2;
				int num4 = num3;
				Dictionary<int, int> fetterGroupFetterDataById = PhantomBattleConfig.Instance.GetFetterGroupFetterDataById(groupId);
				if (fetterGroupFetterDataById != null)
				{
					int num5 = 0;
					foreach (int num6 in fetterGroupFetterDataById.Keys)
					{
						if (num6 <= num4 && num6 > num5)
						{
							num5 = num6;
						}
					}
					num += num5;
				}
			}
			return num;
		}
	}
}
