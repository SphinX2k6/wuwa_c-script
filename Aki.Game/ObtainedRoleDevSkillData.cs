using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200281E RID: 10270
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevSkillData : RoleDevSkillViewItemDataBase
{
	// Token: 0x060151E2 RID: 86498 RVA: 0x00558303 File Offset: 0x00556503
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitSkillData(roleId);
	}

	// Token: 0x060151E3 RID: 86499 RVA: 0x00558314 File Offset: 0x00556514
	private void InitSkillData(int roleId)
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(roleId);
		if (cultivateProject == null)
		{
			return;
		}
		int[] normalSkillLevelArray = cultivateProject.Value.GetNormalSkillLevelArray();
		List<int> list = ((normalSkillLevelArray != null) ? normalSkillLevelArray.ToList<int>() : null) ?? new List<int>();
		int[] prefectSkillLevelArray = cultivateProject.Value.GetPrefectSkillLevelArray();
		List<int> list2 = ((prefectSkillLevelArray != null) ? prefectSkillLevelArray.ToList<int>() : null) ?? new List<int>();
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
		List<int> list8 = (skillTreeConfigArrayArray != null) ? skillTreeConfigArrayArray.ToList<int>() : null;
		if (list8 != null && list8.Count > 0)
		{
			foreach (int nodeIndex2 in list8)
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
		List<ISkillSlotExtendData> list9 = new List<ISkillSlotExtendData>();
		for (int j = 0; j < list7.Count; j++)
		{
			SkillSlotExtendData item = new SkillSlotExtendData
			{
				RoleId = roleId,
				SkillNodeId = list7[j],
				IconId = list7[j],
				CurrentLevel = list3[j],
				NormalTargetLevel = list4[j],
				PerfectTargetLevel = list5[j],
				SkillType = j + ESkillType.Skill1,
				NodeIndex = j
			};
			list9.Add(item);
		}
		List<IRoleDevDetailItemData> detailItemsInternal = this.CreateSkillDetailItemsData(list6.ToArray(), list3.ToArray(), list4.ToArray(), roleId);
		List<IRoleDevDetailItemData> perfectDetailItemsInternal = this.CreateSkillDetailItemsData(list6.ToArray(), list3.ToArray(), list5.ToArray(), roleId);
		this.SkillSlotsInternal = list9;
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

	// Token: 0x060151E4 RID: 86500 RVA: 0x0055868C File Offset: 0x0055688C
	protected override bool GetIsRoleOwned()
	{
		return true;
	}

	// Token: 0x060151E5 RID: 86501 RVA: 0x0055868F File Offset: 0x0055688F
	protected override bool GetIsPerfectPlan()
	{
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		return roleDevViewModelInternal != null && roleDevViewModelInternal.GetRoleSkillPlanState(base.RoleId);
	}

	// Token: 0x060151E6 RID: 86502 RVA: 0x005586A8 File Offset: 0x005568A8
	protected override bool GetIsNormalPlanFinished()
	{
		return this.CheckPlanFinished((from skillNodeId in this.AllSkillNodeIdListInternal
		select RoleModel.Instance.GetRoleSkillTreeNodeLevel(base.RoleId, skillNodeId)).ToList<int>(), this.NormalTargetSkillLevelInternal);
	}

	// Token: 0x060151E7 RID: 86503 RVA: 0x005586D2 File Offset: 0x005568D2
	protected override bool GetIsPerfectPlanFinished()
	{
		return this.CheckPlanFinished((from skillNodeId in this.AllSkillNodeIdListInternal
		select RoleModel.Instance.GetRoleSkillTreeNodeLevel(base.RoleId, skillNodeId)).ToList<int>(), this.PerfectTargetSkillLevelInternal);
	}

	// Token: 0x060151E8 RID: 86504 RVA: 0x005586FC File Offset: 0x005568FC
	protected override List<ISkillSlotExtendData> GetSkillSlots()
	{
		return this.SkillSlotsInternal;
	}

	// Token: 0x060151E9 RID: 86505 RVA: 0x00558704 File Offset: 0x00556904
	protected override List<int> GetSkillGoalUpgradeLevel()
	{
		return this.NormalTargetSkillLevelInternal;
	}

	// Token: 0x060151EA RID: 86506 RVA: 0x0055870C File Offset: 0x0055690C
	protected override List<IRoleDevDetailItemData> GetNormalDetailItems()
	{
		return this.DetailItemsInternal;
	}

	// Token: 0x060151EB RID: 86507 RVA: 0x00558714 File Offset: 0x00556914
	protected override bool GetIsNormalAllMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.DetailItemsInternal);
	}

	// Token: 0x060151EC RID: 86508 RVA: 0x00558724 File Offset: 0x00556924
	protected override bool GetIsUnlockedPerfect()
	{
		int? playerLevel = FunctionModel.Instance.GetPlayerLevel();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(base.RoleId);
		int? num = (roleConfig != null) ? new int?(roleConfig.GetValueOrDefault().MaxLevel) : null;
		return this.PerfectTargetSkillLevelInternal.Count > 0 && playerLevel != null && num != null && playerLevel.Value >= num.Value;
	}

	// Token: 0x060151ED RID: 86509 RVA: 0x005587AC File Offset: 0x005569AC
	protected override List<int> GetPerfectGoalUpgradeLevel()
	{
		return this.PerfectTargetSkillLevelInternal;
	}

	// Token: 0x060151EE RID: 86510 RVA: 0x005587B4 File Offset: 0x005569B4
	protected override List<IRoleDevDetailItemData> GetPerfectDetailItems()
	{
		return this.PerfectDetailItemsInternal;
	}

	// Token: 0x060151EF RID: 86511 RVA: 0x005587BC File Offset: 0x005569BC
	protected override bool GetIsPerfectMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.PerfectDetailItemsInternal);
	}

	// Token: 0x060151F0 RID: 86512 RVA: 0x005587CC File Offset: 0x005569CC
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

	// Token: 0x060151F1 RID: 86513 RVA: 0x00558838 File Offset: 0x00556A38
	protected override bool GetIsHideMaterialList()
	{
		return false;
	}

	// Token: 0x060151F2 RID: 86514 RVA: 0x0055883B File Offset: 0x00556A3B
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x060151F3 RID: 86515 RVA: 0x0055883E File Offset: 0x00556A3E
	protected override bool GetShouldForcePerfectPlan()
	{
		return false;
	}

	// Token: 0x060151F4 RID: 86516 RVA: 0x00558844 File Offset: 0x00556A44
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

	// Token: 0x060151F5 RID: 86517 RVA: 0x0055887C File Offset: 0x00556A7C
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

	// Token: 0x060151F6 RID: 86518 RVA: 0x005588FC File Offset: 0x00556AFC
	private bool CheckPlanFinished(List<int> currentLevels, List<int> targetLevels)
	{
		if (targetLevels.Count == 0 || currentLevels.Count != targetLevels.Count)
		{
			return false;
		}
		for (int i = 0; i < currentLevels.Count; i++)
		{
			if (currentLevels[i] < targetLevels[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060151F7 RID: 86519 RVA: 0x00558945 File Offset: 0x00556B45
	private List<IRoleDevDetailItemData> CreateSkillDetailItemsData(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, int roleId)
	{
		return RoleDevUtils.CreateSkillDetailItemsData(skillNodeIdList, currentLevels, targetLevels, roleId);
	}

	// Token: 0x04009E50 RID: 40528
	private List<ISkillSlotExtendData> SkillSlotsInternal = new List<ISkillSlotExtendData>();

	// Token: 0x04009E51 RID: 40529
	private List<int> AllSkillNodeIdListInternal = new List<int>();

	// Token: 0x04009E52 RID: 40530
	private List<int> NormalTargetSkillLevelInternal = new List<int>();

	// Token: 0x04009E53 RID: 40531
	private List<IRoleDevDetailItemData> DetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x04009E54 RID: 40532
	private List<int> PerfectTargetSkillLevelInternal = new List<int>();

	// Token: 0x04009E55 RID: 40533
	private List<IRoleDevDetailItemData> PerfectDetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x04009E56 RID: 40534
	[Nullable(2)]
	private RoleDevViewModel RoleDevViewModelInternal;
}
