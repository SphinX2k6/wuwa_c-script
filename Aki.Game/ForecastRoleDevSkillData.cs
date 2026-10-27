using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x0200281C RID: 10268
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevSkillData : RoleDevSkillViewItemDataBase
{
	// Token: 0x060151B8 RID: 86456 RVA: 0x00557AF0 File Offset: 0x00555CF0
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitSkillData(roleId);
	}

	// Token: 0x060151B9 RID: 86457 RVA: 0x00557B00 File Offset: 0x00555D00
	private void InitSkillData(int roleId)
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(roleId);
		if (roleDevProsProjectConfig == null)
		{
			return;
		}
		List<global::ISkillSlotExtendData> list = new List<global::ISkillSlotExtendData>();
		for (int i = 0; i < 5; i++)
		{
			list.Add(new global::SkillSlotExtendData
			{
				RoleId = roleId,
				SkillNodeId = 0,
				IconId = 0,
				CurrentLevel = 1,
				NormalTargetLevel = 10,
				PerfectTargetLevel = 10,
				SkillType = i + global::ESkillType.Skill1,
				NodeIndex = i
			});
		}
		List<global::IRoleDevDetailItemData> list2 = new List<global::IRoleDevDetailItemData>();
		List<int> skillItemGroup = roleDevProsProjectConfig.SkillItemGroup;
		if (skillItemGroup != null && skillItemGroup.Count > 0)
		{
			foreach (int itemGroupId in skillItemGroup)
			{
				RoleDevProsRoleItem? roleDevProsRoleItemConfig = RoleDevConfig.Instance.GetRoleDevProsRoleItemConfig(itemGroupId);
				if (roleDevProsRoleItemConfig != null && roleDevProsRoleItemConfig.Value.ItemGroupLength > 0)
				{
					List<global::IItemMaterial> list3 = new List<global::IItemMaterial>();
					int itemGroupLength = roleDevProsRoleItemConfig.Value.ItemGroupLength;
					for (int j = 0; j < itemGroupLength; j++)
					{
						IntPair? intPair = roleDevProsRoleItemConfig.Value.ItemGroup(j);
						if (intPair != null)
						{
							int item = intPair.Value.Item1;
							int item2 = intPair.Value.Item2;
							list3.Add(new global::ItemMaterial
							{
								ItemId = item,
								RequiredCount = item2
							});
						}
					}
					if (list3.Count > 0)
					{
						List<global::IMaterialGroup> list4 = new List<global::IMaterialGroup>();
						List<global::IItemMaterial> list5 = new List<global::IItemMaterial>();
						foreach (global::IItemMaterial item3 in list3)
						{
							list5.Add(item3);
						}
						list4.Add(new global::MaterialGroup
						{
							Type = roleDevProsRoleItemConfig.Value.ItemTypeId,
							Materials = list5
						});
						List<global::IRoleDevDetailItemData> collection = RoleDevUtils.BuildDetailItemData(roleId, list4, ERoleDevMainPage.Skill);
						list2.AddRange(collection);
					}
				}
			}
		}
		this.SkillSlotsInternal = list;
		this.DetailItemsInternal = list2;
		this.PerfectDetailItemsInternal = list2;
	}

	// Token: 0x060151BA RID: 86458 RVA: 0x00557D5C File Offset: 0x00555F5C
	protected override bool GetIsRoleOwned()
	{
		return false;
	}

	// Token: 0x060151BB RID: 86459 RVA: 0x00557D5F File Offset: 0x00555F5F
	protected override bool GetIsPerfectPlan()
	{
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		return roleDevViewModelInternal == null || roleDevViewModelInternal.GetRoleSkillPlanState(base.RoleId);
	}

	// Token: 0x060151BC RID: 86460 RVA: 0x00557D78 File Offset: 0x00555F78
	protected override bool GetIsNormalPlanFinished()
	{
		return false;
	}

	// Token: 0x060151BD RID: 86461 RVA: 0x00557D7B File Offset: 0x00555F7B
	protected override bool GetIsPerfectPlanFinished()
	{
		return false;
	}

	// Token: 0x060151BE RID: 86462 RVA: 0x00557D7E File Offset: 0x00555F7E
	protected override List<global::ISkillSlotExtendData> GetSkillSlots()
	{
		return this.SkillSlotsInternal;
	}

	// Token: 0x060151BF RID: 86463 RVA: 0x00557D86 File Offset: 0x00555F86
	protected override List<int> GetSkillGoalUpgradeLevel()
	{
		return new List<int>
		{
			10,
			10,
			10,
			10,
			10
		};
	}

	// Token: 0x060151C0 RID: 86464 RVA: 0x00557DB5 File Offset: 0x00555FB5
	protected override List<global::IRoleDevDetailItemData> GetNormalDetailItems()
	{
		return this.DetailItemsInternal;
	}

	// Token: 0x060151C1 RID: 86465 RVA: 0x00557DBD File Offset: 0x00555FBD
	protected override bool GetIsNormalAllMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.DetailItemsInternal);
	}

	// Token: 0x060151C2 RID: 86466 RVA: 0x00557DCA File Offset: 0x00555FCA
	protected override bool GetIsUnlockedPerfect()
	{
		return true;
	}

	// Token: 0x060151C3 RID: 86467 RVA: 0x00557DCD File Offset: 0x00555FCD
	protected override List<int> GetPerfectGoalUpgradeLevel()
	{
		return new List<int>
		{
			10,
			10,
			10,
			10,
			10
		};
	}

	// Token: 0x060151C4 RID: 86468 RVA: 0x00557DFC File Offset: 0x00555FFC
	protected override List<global::IRoleDevDetailItemData> GetPerfectDetailItems()
	{
		return this.PerfectDetailItemsInternal;
	}

	// Token: 0x060151C5 RID: 86469 RVA: 0x00557E04 File Offset: 0x00556004
	protected override bool GetIsPerfectMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.PerfectDetailItemsInternal);
	}

	// Token: 0x060151C6 RID: 86470 RVA: 0x00557E11 File Offset: 0x00556011
	protected override bool GetIsBreakthroughLevelLow()
	{
		return false;
	}

	// Token: 0x060151C7 RID: 86471 RVA: 0x00557E14 File Offset: 0x00556014
	protected override bool GetIsHideMaterialList()
	{
		return false;
	}

	// Token: 0x060151C8 RID: 86472 RVA: 0x00557E17 File Offset: 0x00556017
	protected override bool GetIsForecast()
	{
		return true;
	}

	// Token: 0x060151C9 RID: 86473 RVA: 0x00557E1A File Offset: 0x0055601A
	protected override bool GetShouldForcePerfectPlan()
	{
		return true;
	}

	// Token: 0x060151CA RID: 86474 RVA: 0x00557E1D File Offset: 0x0055601D
	public override void SwitchPlan()
	{
	}

	// Token: 0x04009E46 RID: 40518
	private List<global::ISkillSlotExtendData> SkillSlotsInternal = new List<global::ISkillSlotExtendData>();

	// Token: 0x04009E47 RID: 40519
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();

	// Token: 0x04009E48 RID: 40520
	private List<global::IRoleDevDetailItemData> PerfectDetailItemsInternal = new List<global::IRoleDevDetailItemData>();

	// Token: 0x04009E49 RID: 40521
	[Nullable(2)]
	private RoleDevViewModel RoleDevViewModelInternal;
}
