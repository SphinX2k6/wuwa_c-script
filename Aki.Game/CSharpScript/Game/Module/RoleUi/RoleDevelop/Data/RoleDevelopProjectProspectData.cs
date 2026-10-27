using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.View;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.Data
{
	// Token: 0x02004D5E RID: 19806
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectProspectData : RoleDevelopProjectBaseData
	{
		// Token: 0x06033301 RID: 209665 RVA: 0x00BF0B3A File Offset: 0x00BEED3A
		public RoleDevelopProjectProspectData(int id, RoleDevelopRoleBaseData developRoleData) : base(id, developRoleData)
		{
		}

		// Token: 0x06033302 RID: 209666 RVA: 0x00BF0B44 File Offset: 0x00BEED44
		public override ERoleDevelopRoleType GetRoleType()
		{
			return ERoleDevelopRoleType.Prospect;
		}

		// Token: 0x06033303 RID: 209667 RVA: 0x00BF0B47 File Offset: 0x00BEED47
		public IRoleDevProsProjectConfig GetProsProjectConfig()
		{
			return RoleDevConfig.Instance.GetRoleDevProsProjectConfig(this.Id);
		}

		// Token: 0x06033304 RID: 209668 RVA: 0x00BF0B59 File Offset: 0x00BEED59
		public override int GetRoleTargetLevel()
		{
			return this.GetProsProjectConfig().RoleGoalLevel;
		}

		// Token: 0x06033305 RID: 209669 RVA: 0x00BF0B66 File Offset: 0x00BEED66
		public override int GetRoleUpgradeExp()
		{
			return this.GetProsProjectConfig().RoleExperience;
		}

		// Token: 0x06033306 RID: 209670 RVA: 0x00BF0B74 File Offset: 0x00BEED74
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

		// Token: 0x06033307 RID: 209671 RVA: 0x00BF0C14 File Offset: 0x00BEEE14
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

		// Token: 0x06033308 RID: 209672 RVA: 0x00BF0D10 File Offset: 0x00BEEF10
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

		// Token: 0x06033309 RID: 209673 RVA: 0x00BF0E68 File Offset: 0x00BEF068
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

		// Token: 0x0603330A RID: 209674 RVA: 0x00BF0F00 File Offset: 0x00BEF100
		public override int GetWeaponType()
		{
			return this.GetProsProjectConfig().WeaponType;
		}

		// Token: 0x0603330B RID: 209675 RVA: 0x00BF0F0D File Offset: 0x00BEF10D
		public override int GetWeaponTargetLevel()
		{
			return this.GetProsProjectConfig().WeaponGoalLevel;
		}

		// Token: 0x0603330C RID: 209676 RVA: 0x00BF0F1A File Offset: 0x00BEF11A
		public override int GetWeaponUpgradeExp()
		{
			return this.GetProsProjectConfig().WeaponExperience;
		}

		// Token: 0x0603330D RID: 209677 RVA: 0x00BF0F28 File Offset: 0x00BEF128
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

		// Token: 0x0603330E RID: 209678 RVA: 0x00BF0FC8 File Offset: 0x00BEF1C8
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

		// Token: 0x0603330F RID: 209679 RVA: 0x00BF10D0 File Offset: 0x00BEF2D0
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

		// Token: 0x06033310 RID: 209680 RVA: 0x00BF1168 File Offset: 0x00BEF368
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

		// Token: 0x06033311 RID: 209681 RVA: 0x00BF11CB File Offset: 0x00BEF3CB
		public override bool IsSkillPlanFinished()
		{
			return false;
		}

		// Token: 0x06033312 RID: 209682 RVA: 0x00BF11D0 File Offset: 0x00BEF3D0
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

		// Token: 0x06033313 RID: 209683 RVA: 0x00BF12D8 File Offset: 0x00BEF4D8
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

		// Token: 0x06033314 RID: 209684 RVA: 0x00BF1358 File Offset: 0x00BEF558
		public override bool IsShowUpgradeHint(ERoleDevelopCategoryType categoryType)
		{
			return false;
		}

		// Token: 0x06033315 RID: 209685 RVA: 0x00BF135B File Offset: 0x00BEF55B
		public override bool IsShowFinishHint(ERoleDevelopCategoryType categoryType)
		{
			return false;
		}

		// Token: 0x06033316 RID: 209686 RVA: 0x00BF135E File Offset: 0x00BEF55E
		public override bool IsRoleDevelopFinished()
		{
			return false;
		}

		// Token: 0x06033317 RID: 209687 RVA: 0x00BF1361 File Offset: 0x00BEF561
		public override bool IsWeaponDevelopFinished()
		{
			return false;
		}

		// Token: 0x06033318 RID: 209688 RVA: 0x00BF1364 File Offset: 0x00BEF564
		public override bool IsRoleReachTargetLevel()
		{
			return false;
		}

		// Token: 0x06033319 RID: 209689 RVA: 0x00BF1367 File Offset: 0x00BEF567
		public override bool IsRoleReachBreachLevel()
		{
			return false;
		}

		// Token: 0x0603331A RID: 209690 RVA: 0x00BF136A File Offset: 0x00BEF56A
		public override bool IsWeaponReachTargetLevel()
		{
			return false;
		}

		// Token: 0x0603331B RID: 209691 RVA: 0x00BF136D File Offset: 0x00BEF56D
		public override bool IsWeaponReachBreachLevel()
		{
			return false;
		}
	}
}
