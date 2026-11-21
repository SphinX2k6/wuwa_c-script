using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D98 RID: 7576
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevSkillData : RoleDevSkillViewItemDataBase
{
	// Token: 0x06012BCC RID: 76748 RVA: 0x00582C48 File Offset: 0x00580E48
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitSkillData(roleId);
	}

	// Token: 0x06012BCD RID: 76749 RVA: 0x00582C58 File Offset: 0x00580E58
	private void InitSkillData(int roleId)
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return;
		}
		List<int> list = new List<int>(cultivateProject.Value.GetNormalSkillLevelArray());
		List<int> list2 = new List<int>(cultivateProject.Value.GetPrefectSkillLevelArray());
		int[] canLevelUpSkillNodeIndexList = RoleDevConfig.Instance.GetCanLevelUpSkillNodeIndexList();
		if (canLevelUpSkillNodeIndexList.Length != list.Count || canLevelUpSkillNodeIndexList.Length != list2.Count)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.LZK, "LevelUpSkillNodeIndexList长度与NormalSkillLevel或PrefectSkillLevel长度不一致", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		List<int> list3 = new List<int>();
		List<int> list4 = new List<int>();
		List<int> list5 = new List<int>();
		List<int> list6 = new List<int>();
		List<int> list7 = new List<int>();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		for (int i = 0; i < canLevelUpSkillNodeIndexList.Length; i++)
		{
			int nodeIndex = canLevelUpSkillNodeIndexList[i];
			SkillTree? skillTreeNodeByGroupIdAndIndex = RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(roleConfig.Value.SkillTreeGroupId, nodeIndex);
			if (skillTreeNodeByGroupIdAndIndex != null)
			{
				int id = skillTreeNodeByGroupIdAndIndex.Value.Id;
				list7.Add(id);
				list6.Add(id);
				list3.Add(1);
				list4.Add(list[i]);
				list5.Add(list2[i]);
			}
		}
		int[] skillTreeConfigArrayArray = cultivateProject.Value.GetSkillTreeConfigArrayArray();
		if (skillTreeConfigArrayArray != null && skillTreeConfigArrayArray.Length != 0)
		{
			foreach (int nodeIndex2 in skillTreeConfigArrayArray)
			{
				SkillTree? skillTreeNodeByGroupIdAndIndex2 = RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(roleConfig.Value.SkillTreeGroupId, nodeIndex2);
				if (skillTreeNodeByGroupIdAndIndex2 != null)
				{
					int id2 = skillTreeNodeByGroupIdAndIndex2.Value.Id;
					list6.Add(id2);
					list3.Add(0);
					list4.Add(1);
					list5.Add(1);
				}
			}
		}
		List<ISkillSlotExtendData> list8 = new List<ISkillSlotExtendData>();
		for (int k = 0; k < list7.Count; k++)
		{
			SkillSlotExtendData item = new SkillSlotExtendData
			{
				RoleId = roleId,
				SkillNodeId = list7[k],
				IconId = list7[k],
				CurrentLevel = list3[k],
				NormalTargetLevel = list4[k],
				PerfectTargetLevel = list5[k],
				SkillType = k + ESkillType.Skill1,
				NodeIndex = k
			};
			list8.Add(item);
		}
		List<IRoleDevDetailItemData> detailItemsInternal = this.CreateSkillDetailItemsData(list6.ToArray(), list3.ToArray(), list4.ToArray(), roleId);
		List<IRoleDevDetailItemData> perfectDetailItemsInternal = this.CreateSkillDetailItemsData(list6.ToArray(), list3.ToArray(), list5.ToArray(), roleId);
		this.SkillSlotsInternal = list8;
		this.SkillGoalUpgradeLevelInternal = list4;
		this.PerfectGoalUpgradeLevelInternal = list5;
		this.DetailItemsInternal = detailItemsInternal;
		this.PerfectDetailItemsInternal = perfectDetailItemsInternal;
	}

	// Token: 0x06012BCE RID: 76750 RVA: 0x00582F28 File Offset: 0x00581128
	protected override bool GetIsRoleOwned()
	{
		return false;
	}

	// Token: 0x06012BCF RID: 76751 RVA: 0x00582F2B File Offset: 0x0058112B
	protected override bool GetIsPerfectPlan()
	{
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		return roleDevViewModelInternal != null && roleDevViewModelInternal.GetRoleSkillPlanState(base.RoleId);
	}

	// Token: 0x06012BD0 RID: 76752 RVA: 0x00582F44 File Offset: 0x00581144
	protected override bool GetIsNormalPlanFinished()
	{
		return false;
	}

	// Token: 0x06012BD1 RID: 76753 RVA: 0x00582F47 File Offset: 0x00581147
	protected override bool GetIsPerfectPlanFinished()
	{
		return false;
	}

	// Token: 0x06012BD2 RID: 76754 RVA: 0x00582F4A File Offset: 0x0058114A
	protected override List<ISkillSlotExtendData> GetSkillSlots()
	{
		return this.SkillSlotsInternal;
	}

	// Token: 0x06012BD3 RID: 76755 RVA: 0x00582F52 File Offset: 0x00581152
	protected override List<int> GetSkillGoalUpgradeLevel()
	{
		return this.SkillGoalUpgradeLevelInternal;
	}

	// Token: 0x06012BD4 RID: 76756 RVA: 0x00582F5A File Offset: 0x0058115A
	protected override List<IRoleDevDetailItemData> GetNormalDetailItems()
	{
		return this.DetailItemsInternal;
	}

	// Token: 0x06012BD5 RID: 76757 RVA: 0x00582F62 File Offset: 0x00581162
	protected override bool GetIsNormalAllMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.DetailItemsInternal);
	}

	// Token: 0x06012BD6 RID: 76758 RVA: 0x00582F6F File Offset: 0x0058116F
	protected override bool GetIsUnlockedPerfect()
	{
		return this.PerfectGoalUpgradeLevelInternal.Count > 0;
	}

	// Token: 0x06012BD7 RID: 76759 RVA: 0x00582F7F File Offset: 0x0058117F
	protected override List<int> GetPerfectGoalUpgradeLevel()
	{
		return this.PerfectGoalUpgradeLevelInternal;
	}

	// Token: 0x06012BD8 RID: 76760 RVA: 0x00582F87 File Offset: 0x00581187
	protected override List<IRoleDevDetailItemData> GetPerfectDetailItems()
	{
		return this.PerfectDetailItemsInternal;
	}

	// Token: 0x06012BD9 RID: 76761 RVA: 0x00582F8F File Offset: 0x0058118F
	protected override bool GetIsPerfectMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.PerfectDetailItemsInternal);
	}

	// Token: 0x06012BDA RID: 76762 RVA: 0x00582F9C File Offset: 0x0058119C
	protected override bool GetIsBreakthroughLevelLow()
	{
		return false;
	}

	// Token: 0x06012BDB RID: 76763 RVA: 0x00582F9F File Offset: 0x0058119F
	protected override bool GetIsHideMaterialList()
	{
		return false;
	}

	// Token: 0x06012BDC RID: 76764 RVA: 0x00582FA2 File Offset: 0x005811A2
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x06012BDD RID: 76765 RVA: 0x00582FA5 File Offset: 0x005811A5
	protected override bool GetShouldForcePerfectPlan()
	{
		return false;
	}

	// Token: 0x06012BDE RID: 76766 RVA: 0x00582FA8 File Offset: 0x005811A8
	public override void SwitchPlan()
	{
		bool isPerfectPlan = !this.GetIsPerfectPlan();
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		if (roleDevViewModelInternal != null)
		{
			roleDevViewModelInternal.SetRoleSkillPlanState(base.RoleId, isPerfectPlan);
		}
		this.UpdateSkillSlots();
	}

	// Token: 0x06012BDF RID: 76767 RVA: 0x00582FE0 File Offset: 0x005811E0
	private void UpdateSkillSlots()
	{
		foreach (ISkillSlotExtendData skillSlotExtendData in this.SkillSlotsInternal)
		{
			int normalTargetLevel = this.SkillGoalUpgradeLevelInternal[skillSlotExtendData.NodeIndex];
			int perfectTargetLevel = this.PerfectGoalUpgradeLevelInternal[skillSlotExtendData.NodeIndex];
			skillSlotExtendData.NormalTargetLevel = normalTargetLevel;
			skillSlotExtendData.PerfectTargetLevel = perfectTargetLevel;
		}
	}

	// Token: 0x06012BE0 RID: 76768 RVA: 0x00583060 File Offset: 0x00581260
	private List<IRoleDevDetailItemData> CreateSkillDetailItemsData(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, int roleId)
	{
		return RoleDevUtils.CreateSkillDetailItemsData(skillNodeIdList, currentLevels, targetLevels, roleId);
	}

	// Token: 0x0400A233 RID: 41523
	private List<ISkillSlotExtendData> SkillSlotsInternal = new List<ISkillSlotExtendData>();

	// Token: 0x0400A234 RID: 41524
	private List<int> SkillGoalUpgradeLevelInternal = new List<int>();

	// Token: 0x0400A235 RID: 41525
	private List<IRoleDevDetailItemData> DetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x0400A236 RID: 41526
	private List<int> PerfectGoalUpgradeLevelInternal = new List<int>();

	// Token: 0x0400A237 RID: 41527
	private List<IRoleDevDetailItemData> PerfectDetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x0400A238 RID: 41528
	[Nullable(2)]
	private RoleDevViewModel RoleDevViewModelInternal;
}
