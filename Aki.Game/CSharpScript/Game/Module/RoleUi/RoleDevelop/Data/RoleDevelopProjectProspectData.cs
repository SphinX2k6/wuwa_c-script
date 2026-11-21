using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02003D27 RID: 15655
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectProspectData : RoleDevelopProjectBaseData
	{
		// Token: 0x0602816D RID: 164205 RVA: 0x00B39CF0 File Offset: 0x00B37EF0
		public RoleDevelopProjectProspectData(int id, RoleDevelopRoleBaseData developRoleData) : base(id, developRoleData)
		{
		}

		// Token: 0x0602816E RID: 164206 RVA: 0x00B39CFA File Offset: 0x00B37EFA
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Prospect;
		}

		// Token: 0x0602816F RID: 164207 RVA: 0x00B39CFD File Offset: 0x00B37EFD
		public IRoleDevProsProjectConfig GetProsProjectConfig()
		{
			return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id);
		}

		// Token: 0x06028170 RID: 164208 RVA: 0x00B39D0F File Offset: 0x00B37F0F
		public override int GetRoleTargetLevel()
		{
			return this.GetProsProjectConfig().RoleGoalLevel;
		}

		// Token: 0x06028171 RID: 164209 RVA: 0x00B39D1C File Offset: 0x00B37F1C
		public override int GetRoleUpgradeExp()
		{
			return this.GetProsProjectConfig().RoleExperience;
		}

		// Token: 0x06028172 RID: 164210 RVA: 0x00B39D2C File Offset: 0x00B37F2C
		public override List<RoleDevelopNeedItem> GetRoleUpgradeNeedItems()
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (ISelectedData selectedData in base.GetSortedRoleExpItemList())
			{
				list.Add(new RoleDevelopNeedItem
				{
					ItemId = selectedData.ItemId,
					Count = selectedData.Count
				});
			}
			return RoleDevelopUtil.CalcUpgradeNeedItems(this.GetRoleUpgradeExp(), list, (int itemId) => RoleModel.Instance.GetRoleExpItemExp(itemId).GetValueOrDefault(0));
		}

		// Token: 0x06028173 RID: 164211 RVA: 0x00B39DCC File Offset: 0x00B37FCC
		public override List<RoleDevelopNeedItem> GetRoleBreachNeedItems()
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (int itemGroupId in this.GetProsProjectConfig().RoleItemGroup)
			{
				RoleDevProsRoleItem? roleDevProsRoleItemConfig = RoleDevConfig.Instance.GetRoleDevProsRoleItemConfig(itemGroupId);
				EItemMaterialType itemTypeId = (EItemMaterialType)roleDevProsRoleItemConfig.Value.ItemTypeId;
				foreach (IntPair intPair in roleDevProsRoleItemConfig.Value.ItemGroupIter())
				{
					int item = intPair.Item1;
					int item2 = intPair.Item2;
					list.Add(new RoleDevelopNeedItem
					{
						ItemId = item,
						Count = item2,
						Type = new EItemMaterialType?(itemTypeId)
					});
				}
			}
			return list;
		}

		// Token: 0x06028174 RID: 164212 RVA: 0x00B39EC8 File Offset: 0x00B380C8
		public override List<RoleDevelopNeedItem> GetRoleDevelopNeedItems()
		{
			Dictionary<int, RoleDevelopNeedItem> dictionary = new Dictionary<int, RoleDevelopNeedItem>();
			List<RoleDevelopNeedItem> roleUpgradeNeedItems = this.GetRoleUpgradeNeedItems();
			List<RoleDevelopNeedItem> roleBreachNeedItems = this.GetRoleBreachNeedItems();
			foreach (RoleDevelopNeedItem roleDevelopNeedItem in roleUpgradeNeedItems)
			{
				RoleDevelopNeedItem roleDevelopNeedItem2;
				if (dictionary.TryGetValue(roleDevelopNeedItem.ItemId, out roleDevelopNeedItem2))
				{
					roleDevelopNeedItem2.Count += roleDevelopNeedItem.Count;
				}
				else
				{
					dictionary[roleDevelopNeedItem.ItemId] = new RoleDevelopNeedItem
					{
						ItemId = roleDevelopNeedItem.ItemId,
						Count = roleDevelopNeedItem.Count,
						Type = roleDevelopNeedItem.Type
					};
				}
			}
			foreach (RoleDevelopNeedItem roleDevelopNeedItem3 in roleBreachNeedItems)
			{
				RoleDevelopNeedItem roleDevelopNeedItem4;
				if (dictionary.TryGetValue(roleDevelopNeedItem3.ItemId, out roleDevelopNeedItem4))
				{
					roleDevelopNeedItem4.Count += roleDevelopNeedItem3.Count;
				}
				else
				{
					dictionary[roleDevelopNeedItem3.ItemId] = new RoleDevelopNeedItem
					{
						ItemId = roleDevelopNeedItem3.ItemId,
						Count = roleDevelopNeedItem3.Count,
						Type = roleDevelopNeedItem3.Type
					};
				}
			}
			return new List<RoleDevelopNeedItem>(dictionary.Values);
		}

		// Token: 0x06028175 RID: 164213 RVA: 0x00B3A020 File Offset: 0x00B38220
		public override List<RoleDevelopProjectMaterialItemData> GetRoleDevelopProjectViewItems()
		{
			List<RoleDevelopProjectMaterialItemData> list = new List<RoleDevelopProjectMaterialItemData>();
			List<RoleDevelopNeedItem> list2 = new List<RoleDevelopNeedItem>();
			list2.AddRange(this.GetRoleUpgradeNeedItems());
			list2.AddRange(this.GetRoleBreachNeedItems());
			foreach (RoleDevelopItemGroup groupItem in RoleDevelopUtil.BuildGroupItemDataByNeedItems(list2, false, true, false))
			{
				list.Add(new RoleDevelopProjectMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(base.HandleItemJumpCallback)
				});
			}
			return list;
		}

		// Token: 0x06028176 RID: 164214 RVA: 0x00B3A0B8 File Offset: 0x00B382B8
		public override int GetWeaponType()
		{
			return this.GetProsProjectConfig().WeaponType;
		}

		// Token: 0x06028177 RID: 164215 RVA: 0x00B3A0C5 File Offset: 0x00B382C5
		public override int GetWeaponTargetLevel()
		{
			return this.GetProsProjectConfig().WeaponGoalLevel;
		}

		// Token: 0x06028178 RID: 164216 RVA: 0x00B3A0D2 File Offset: 0x00B382D2
		public override int GetWeaponUpgradeExp()
		{
			return this.GetProsProjectConfig().WeaponExperience;
		}

		// Token: 0x06028179 RID: 164217 RVA: 0x00B3A0E0 File Offset: 0x00B382E0
		public override List<RoleDevelopNeedItem> GetWeaponUpgradeNeedItems()
		{
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (ISelectedData selectedData in base.GetSortedWeaponExpItemList())
			{
				list.Add(new RoleDevelopNeedItem
				{
					ItemId = selectedData.ItemId,
					Count = selectedData.Count
				});
			}
			return RoleDevelopUtil.CalcUpgradeNeedItems(this.GetWeaponUpgradeExp(), list, (int itemId) => WeaponModel.Instance.GetWeaponItemExp(0, itemId));
		}

		// Token: 0x0602817A RID: 164218 RVA: 0x00B3A180 File Offset: 0x00B38380
		public override List<RoleDevelopNeedItem> GetWeaponBreachNeedItems()
		{
			IRoleDevProsProjectConfig prosProjectConfig = this.GetProsProjectConfig();
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (int itemGroupId in prosProjectConfig.WeaponBreachItemGroup)
			{
				RoleDevProsRoleItem? roleDevProsRoleItemConfig = RoleDevConfig.Instance.GetRoleDevProsRoleItemConfig(itemGroupId);
				if (roleDevProsRoleItemConfig != null)
				{
					EItemMaterialType itemTypeId = (EItemMaterialType)roleDevProsRoleItemConfig.Value.ItemTypeId;
					foreach (IntPair intPair in roleDevProsRoleItemConfig.Value.ItemGroupIter())
					{
						int item = intPair.Item1;
						int item2 = intPair.Item2;
						list.Add(new RoleDevelopNeedItem
						{
							ItemId = item,
							Count = item2,
							Type = new EItemMaterialType?(itemTypeId)
						});
					}
				}
			}
			return list;
		}

		// Token: 0x0602817B RID: 164219 RVA: 0x00B3A288 File Offset: 0x00B38488
		public override List<RoleDevelopProjectMaterialItemData> GetWeaponDevelopProjectViewItems()
		{
			List<RoleDevelopProjectMaterialItemData> list = new List<RoleDevelopProjectMaterialItemData>();
			List<RoleDevelopNeedItem> list2 = new List<RoleDevelopNeedItem>();
			list2.AddRange(this.GetWeaponUpgradeNeedItems());
			list2.AddRange(this.GetWeaponBreachNeedItems());
			foreach (RoleDevelopItemGroup groupItem in RoleDevelopUtil.BuildGroupItemDataByNeedItems(list2, false, true, false))
			{
				list.Add(new RoleDevelopProjectMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(base.HandleItemJumpCallback)
				});
			}
			return list;
		}

		// Token: 0x0602817C RID: 164220 RVA: 0x00B3A320 File Offset: 0x00B38520
		public override List<RoleDevelopSkillData> GetSkillDevelopData()
		{
			int[] canLevelUpSkillNodeIndexList = RoleDevConfig.Instance.GetCanLevelUpSkillNodeIndexList();
			List<RoleDevelopSkillData> list = new List<RoleDevelopSkillData>();
			for (int i = 0; i < canLevelUpSkillNodeIndexList.Length; i++)
			{
				RoleDevelopSkillData item = new RoleDevelopSkillData
				{
					RoleId = this.Id,
					SkillNodeId = 0,
					CurrentLevel = 1,
					TargetLevel = 10,
					Index = i
				};
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0602817D RID: 164221 RVA: 0x00B3A383 File Offset: 0x00B38583
		public override bool IsSkillPlanFinished()
		{
			return false;
		}

		// Token: 0x0602817E RID: 164222 RVA: 0x00B3A388 File Offset: 0x00B38588
		public override List<RoleDevelopNeedItem> GetSkillPlanNeedItems()
		{
			IRoleDevProsProjectConfig prosProjectConfig = this.GetProsProjectConfig();
			List<RoleDevelopNeedItem> list = new List<RoleDevelopNeedItem>();
			foreach (int itemGroupId in prosProjectConfig.SkillItemGroup)
			{
				RoleDevProsRoleItem? roleDevProsRoleItemConfig = RoleDevConfig.Instance.GetRoleDevProsRoleItemConfig(itemGroupId);
				if (roleDevProsRoleItemConfig != null)
				{
					EItemMaterialType itemTypeId = (EItemMaterialType)roleDevProsRoleItemConfig.Value.ItemTypeId;
					foreach (IntPair intPair in roleDevProsRoleItemConfig.Value.ItemGroupIter())
					{
						int item = intPair.Item1;
						int item2 = intPair.Item2;
						list.Add(new RoleDevelopNeedItem
						{
							ItemId = item,
							Count = item2,
							Type = new EItemMaterialType?(itemTypeId)
						});
					}
				}
			}
			return list;
		}

		// Token: 0x0602817F RID: 164223 RVA: 0x00B3A490 File Offset: 0x00B38690
		public override List<RoleDevelopProjectMaterialItemData> GetSkillDevelopProjectViewItems()
		{
			List<RoleDevelopProjectMaterialItemData> list = new List<RoleDevelopProjectMaterialItemData>();
			foreach (RoleDevelopItemGroup groupItem in RoleDevelopUtil.BuildGroupItemDataByNeedItems(this.GetSkillPlanNeedItems(), false, true, false))
			{
				list.Add(new RoleDevelopProjectMaterialItemData
				{
					GroupItem = groupItem,
					JumpCallback = new Action<RoleDevelopItemGroup>(base.HandleItemJumpCallback)
				});
			}
			return list;
		}

		// Token: 0x06028180 RID: 164224 RVA: 0x00B3A510 File Offset: 0x00B38710
		public override bool IsShowUpgradeHint(ERoleDevelopCategoryType categoryType)
		{
			return false;
		}

		// Token: 0x06028181 RID: 164225 RVA: 0x00B3A513 File Offset: 0x00B38713
		public override bool IsShowFinishHint(ERoleDevelopCategoryType categoryType)
		{
			return false;
		}

		// Token: 0x06028182 RID: 164226 RVA: 0x00B3A516 File Offset: 0x00B38716
		public override bool IsShowCanImproveHint(ERoleDevelopCategoryType categoryType)
		{
			return false;
		}

		// Token: 0x06028183 RID: 164227 RVA: 0x00B3A519 File Offset: 0x00B38719
		public override bool IsRoleDevelopFinished()
		{
			return false;
		}

		// Token: 0x06028184 RID: 164228 RVA: 0x00B3A51C File Offset: 0x00B3871C
		public override bool IsWeaponDevelopFinished()
		{
			return false;
		}

		// Token: 0x06028185 RID: 164229 RVA: 0x00B3A51F File Offset: 0x00B3871F
		public override bool IsRoleReachTargetLevel()
		{
			return false;
		}

		// Token: 0x06028186 RID: 164230 RVA: 0x00B3A522 File Offset: 0x00B38722
		public override bool IsRoleReachBreachLevel()
		{
			return false;
		}

		// Token: 0x06028187 RID: 164231 RVA: 0x00B3A525 File Offset: 0x00B38725
		public override bool IsWeaponReachTargetLevel()
		{
			return false;
		}

		// Token: 0x06028188 RID: 164232 RVA: 0x00B3A528 File Offset: 0x00B38728
		public override bool IsWeaponReachBreachLevel()
		{
			return false;
		}
	}
}
