using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D99 RID: 7577
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevSkillData : RoleDevSkillViewItemDataBase
{
	// Token: 0x06012BE2 RID: 76770 RVA: 0x005830AB File Offset: 0x005812AB
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitSkillData(roleId);
	}

	// Token: 0x06012BE3 RID: 76771 RVA: 0x005830BC File Offset: 0x005812BC
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
				list3.Add(RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, id));
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
					list3.Add(RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, id2));
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
		this.NormalTargetSkillLevelInternal = list4;
		this.PerfectTargetSkillLevelInternal = list5;
		this.DetailItemsInternal = detailItemsInternal;
		this.PerfectDetailItemsInternal = perfectDetailItemsInternal;
		this.AllSkillNodeIdListInternal = list6;
		if (this.RoleDevViewModelInternal != null && !this.RoleDevViewModelInternal.CheckRoleIdIsCreated(roleId))
		{
			RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
			if (roleDevViewModelInternal == null)
			{
				return;
			}
			roleDevViewModelInternal.SetRoleSkillPlanState(roleId, base.IsNormalPlanFinished);
		}
	}

	// Token: 0x06012BE4 RID: 76772 RVA: 0x005833E2 File Offset: 0x005815E2
	protected override bool GetIsRoleOwned()
	{
		return true;
	}

	// Token: 0x06012BE5 RID: 76773 RVA: 0x005833E5 File Offset: 0x005815E5
	protected override bool GetIsPerfectPlan()
	{
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		return roleDevViewModelInternal != null && roleDevViewModelInternal.GetRoleSkillPlanState(base.RoleId);
	}

	// Token: 0x06012BE6 RID: 76774 RVA: 0x005833FE File Offset: 0x005815FE
	protected override bool GetIsNormalPlanFinished()
	{
		return ObtainedRoleDevSkillData.CheckPlanFinished(base.RoleId, this.AllSkillNodeIdListInternal, this.NormalTargetSkillLevelInternal);
	}

	// Token: 0x06012BE7 RID: 76775 RVA: 0x00583417 File Offset: 0x00581617
	protected override bool GetIsPerfectPlanFinished()
	{
		return ObtainedRoleDevSkillData.CheckPlanFinished(base.RoleId, this.AllSkillNodeIdListInternal, this.PerfectTargetSkillLevelInternal);
	}

	// Token: 0x06012BE8 RID: 76776 RVA: 0x00583430 File Offset: 0x00581630
	protected override List<ISkillSlotExtendData> GetSkillSlots()
	{
		return this.SkillSlotsInternal;
	}

	// Token: 0x06012BE9 RID: 76777 RVA: 0x00583438 File Offset: 0x00581638
	protected override List<int> GetSkillGoalUpgradeLevel()
	{
		return this.NormalTargetSkillLevelInternal;
	}

	// Token: 0x06012BEA RID: 76778 RVA: 0x00583440 File Offset: 0x00581640
	protected override List<IRoleDevDetailItemData> GetNormalDetailItems()
	{
		return this.DetailItemsInternal;
	}

	// Token: 0x06012BEB RID: 76779 RVA: 0x00583448 File Offset: 0x00581648
	protected override bool GetIsNormalAllMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.DetailItemsInternal);
	}

	// Token: 0x06012BEC RID: 76780 RVA: 0x00583458 File Offset: 0x00581658
	protected override bool GetIsUnlockedPerfect()
	{
		int? playerLevel = FunctionModel.Instance.GetPlayerLevel();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(base.RoleId);
		int? num = (roleConfig != null) ? new int?(roleConfig.GetValueOrDefault().MaxLevel) : null;
		return this.PerfectTargetSkillLevelInternal.Count > 0 && playerLevel != null && num != null && playerLevel.Value >= num.Value;
	}

	// Token: 0x06012BED RID: 76781 RVA: 0x005834E0 File Offset: 0x005816E0
	protected override List<int> GetPerfectGoalUpgradeLevel()
	{
		return this.PerfectTargetSkillLevelInternal;
	}

	// Token: 0x06012BEE RID: 76782 RVA: 0x005834E8 File Offset: 0x005816E8
	protected override List<IRoleDevDetailItemData> GetPerfectDetailItems()
	{
		return this.PerfectDetailItemsInternal;
	}

	// Token: 0x06012BEF RID: 76783 RVA: 0x005834F0 File Offset: 0x005816F0
	protected override bool GetIsPerfectMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.PerfectDetailItemsInternal);
	}

	// Token: 0x06012BF0 RID: 76784 RVA: 0x00583500 File Offset: 0x00581700
	protected override bool GetIsBreakthroughLevelLow()
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(base.RoleId, true);
		if (roleDataById == null)
		{
			return false;
		}
		int breachLevel = roleDataById.GetLevelData().GetBreachLevel();
		for (int i = 0; i < this.SkillSlotsInternal.Count; i++)
		{
			if (this.SkillSlotsInternal[i].CurrentLevel >= this.NormalTargetSkillLevelInternal[i] && breachLevel < 6)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06012BF1 RID: 76785 RVA: 0x0058356C File Offset: 0x0058176C
	protected override bool GetIsHideMaterialList()
	{
		return false;
	}

	// Token: 0x06012BF2 RID: 76786 RVA: 0x0058356F File Offset: 0x0058176F
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x06012BF3 RID: 76787 RVA: 0x00583572 File Offset: 0x00581772
	protected override bool GetShouldForcePerfectPlan()
	{
		return false;
	}

	// Token: 0x06012BF4 RID: 76788 RVA: 0x00583578 File Offset: 0x00581778
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

	// Token: 0x06012BF5 RID: 76789 RVA: 0x005835B0 File Offset: 0x005817B0
	private void UpdateSkillSlots()
	{
		foreach (ISkillSlotExtendData skillSlotExtendData in this.SkillSlotsInternal)
		{
			int normalTargetLevel = this.NormalTargetSkillLevelInternal[skillSlotExtendData.NodeIndex];
			int perfectTargetLevel = this.PerfectTargetSkillLevelInternal[skillSlotExtendData.NodeIndex];
			skillSlotExtendData.NormalTargetLevel = normalTargetLevel;
			skillSlotExtendData.PerfectTargetLevel = perfectTargetLevel;
		}
	}

	// Token: 0x06012BF6 RID: 76790 RVA: 0x00583630 File Offset: 0x00581830
	private static bool CheckPlanFinished(int roleId, List<int> skillNodeIdList, List<int> targetLevels)
	{
		if (targetLevels.Count == 0 || skillNodeIdList.Count != targetLevels.Count)
		{
			return false;
		}
		for (int i = 0; i < skillNodeIdList.Count; i++)
		{
			if (RoleModel.Instance.GetRoleSkillTreeNodeLevel(roleId, skillNodeIdList[i]) < targetLevels[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06012BF7 RID: 76791 RVA: 0x00583684 File Offset: 0x00581884
	private List<IRoleDevDetailItemData> CreateSkillDetailItemsData(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, int roleId)
	{
		return RoleDevUtils.CreateSkillDetailItemsData(skillNodeIdList, currentLevels, targetLevels, roleId);
	}

	// Token: 0x0400A239 RID: 41529
	private List<ISkillSlotExtendData> SkillSlotsInternal = new List<ISkillSlotExtendData>();

	// Token: 0x0400A23A RID: 41530
	private List<int> AllSkillNodeIdListInternal = new List<int>();

	// Token: 0x0400A23B RID: 41531
	private List<int> NormalTargetSkillLevelInternal = new List<int>();

	// Token: 0x0400A23C RID: 41532
	private List<IRoleDevDetailItemData> DetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x0400A23D RID: 41533
	private List<int> PerfectTargetSkillLevelInternal = new List<int>();

	// Token: 0x0400A23E RID: 41534
	private List<IRoleDevDetailItemData> PerfectDetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x0400A23F RID: 41535
	[Nullable(2)]
	private RoleDevViewModel RoleDevViewModelInternal;
}
