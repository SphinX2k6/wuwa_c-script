using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleDev;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001D97 RID: 7575
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevSkillData : RoleDevSkillViewItemDataBase
{
	// Token: 0x06012BB8 RID: 76728 RVA: 0x005828F0 File Offset: 0x00580AF0
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitSkillData(roleId);
	}

	// Token: 0x06012BB9 RID: 76729 RVA: 0x00582900 File Offset: 0x00580B00
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

	// Token: 0x06012BBA RID: 76730 RVA: 0x00582B5C File Offset: 0x00580D5C
	protected override bool GetIsRoleOwned()
	{
		return false;
	}

	// Token: 0x06012BBB RID: 76731 RVA: 0x00582B5F File Offset: 0x00580D5F
	protected override bool GetIsPerfectPlan()
	{
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		return roleDevViewModelInternal == null || roleDevViewModelInternal.GetRoleSkillPlanState(base.RoleId);
	}

	// Token: 0x06012BBC RID: 76732 RVA: 0x00582B78 File Offset: 0x00580D78
	protected override bool GetIsNormalPlanFinished()
	{
		return false;
	}

	// Token: 0x06012BBD RID: 76733 RVA: 0x00582B7B File Offset: 0x00580D7B
	protected override bool GetIsPerfectPlanFinished()
	{
		return false;
	}

	// Token: 0x06012BBE RID: 76734 RVA: 0x00582B7E File Offset: 0x00580D7E
	protected override List<global::ISkillSlotExtendData> GetSkillSlots()
	{
		return this.SkillSlotsInternal;
	}

	// Token: 0x06012BBF RID: 76735 RVA: 0x00582B86 File Offset: 0x00580D86
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

	// Token: 0x06012BC0 RID: 76736 RVA: 0x00582BB5 File Offset: 0x00580DB5
	protected override List<global::IRoleDevDetailItemData> GetNormalDetailItems()
	{
		return this.DetailItemsInternal;
	}

	// Token: 0x06012BC1 RID: 76737 RVA: 0x00582BBD File Offset: 0x00580DBD
	protected override bool GetIsNormalAllMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.DetailItemsInternal);
	}

	// Token: 0x06012BC2 RID: 76738 RVA: 0x00582BCA File Offset: 0x00580DCA
	protected override bool GetIsUnlockedPerfect()
	{
		return true;
	}

	// Token: 0x06012BC3 RID: 76739 RVA: 0x00582BCD File Offset: 0x00580DCD
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

	// Token: 0x06012BC4 RID: 76740 RVA: 0x00582BFC File Offset: 0x00580DFC
	protected override List<global::IRoleDevDetailItemData> GetPerfectDetailItems()
	{
		return this.PerfectDetailItemsInternal;
	}

	// Token: 0x06012BC5 RID: 76741 RVA: 0x00582C04 File Offset: 0x00580E04
	protected override bool GetIsPerfectMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.PerfectDetailItemsInternal);
	}

	// Token: 0x06012BC6 RID: 76742 RVA: 0x00582C11 File Offset: 0x00580E11
	protected override bool GetIsBreakthroughLevelLow()
	{
		return false;
	}

	// Token: 0x06012BC7 RID: 76743 RVA: 0x00582C14 File Offset: 0x00580E14
	protected override bool GetIsHideMaterialList()
	{
		return false;
	}

	// Token: 0x06012BC8 RID: 76744 RVA: 0x00582C17 File Offset: 0x00580E17
	protected override bool GetIsForecast()
	{
		return true;
	}

	// Token: 0x06012BC9 RID: 76745 RVA: 0x00582C1A File Offset: 0x00580E1A
	protected override bool GetShouldForcePerfectPlan()
	{
		return true;
	}

	// Token: 0x06012BCA RID: 76746 RVA: 0x00582C1D File Offset: 0x00580E1D
	public override void SwitchPlan()
	{
	}

	// Token: 0x0400A22F RID: 41519
	private List<global::ISkillSlotExtendData> SkillSlotsInternal = new List<global::ISkillSlotExtendData>();

	// Token: 0x0400A230 RID: 41520
	private List<global::IRoleDevDetailItemData> DetailItemsInternal = new List<global::IRoleDevDetailItemData>();

	// Token: 0x0400A231 RID: 41521
	private List<global::IRoleDevDetailItemData> PerfectDetailItemsInternal = new List<global::IRoleDevDetailItemData>();

	// Token: 0x0400A232 RID: 41522
	[Nullable(2)]
	private RoleDevViewModel RoleDevViewModelInternal;
}
