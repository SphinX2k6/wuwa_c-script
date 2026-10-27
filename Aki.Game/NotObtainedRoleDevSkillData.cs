using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200281D RID: 10269
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevSkillData : RoleDevSkillViewItemDataBase
{
	// Token: 0x060151CC RID: 86476 RVA: 0x00557E48 File Offset: 0x00556048
	protected override void InitByRoleType(int roleId, RoleDevViewModel roleDevViewModel)
	{
		this.RoleDevViewModelInternal = roleDevViewModel;
		this.InitSkillData(roleId);
	}

	// Token: 0x060151CD RID: 86477 RVA: 0x00557E58 File Offset: 0x00556058
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
				list3.Add(1);
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
					list3.Add(0);
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
		this.SkillGoalUpgradeLevelInternal = list4;
		this.PerfectGoalUpgradeLevelInternal = list5;
		this.DetailItemsInternal = detailItemsInternal;
		this.PerfectDetailItemsInternal = perfectDetailItemsInternal;
	}

	// Token: 0x060151CE RID: 86478 RVA: 0x00558180 File Offset: 0x00556380
	protected override bool GetIsRoleOwned()
	{
		return false;
	}

	// Token: 0x060151CF RID: 86479 RVA: 0x00558183 File Offset: 0x00556383
	protected override bool GetIsPerfectPlan()
	{
		RoleDevViewModel roleDevViewModelInternal = this.RoleDevViewModelInternal;
		return roleDevViewModelInternal != null && roleDevViewModelInternal.GetRoleSkillPlanState(base.RoleId);
	}

	// Token: 0x060151D0 RID: 86480 RVA: 0x0055819C File Offset: 0x0055639C
	protected override bool GetIsNormalPlanFinished()
	{
		return false;
	}

	// Token: 0x060151D1 RID: 86481 RVA: 0x0055819F File Offset: 0x0055639F
	protected override bool GetIsPerfectPlanFinished()
	{
		return false;
	}

	// Token: 0x060151D2 RID: 86482 RVA: 0x005581A2 File Offset: 0x005563A2
	protected override List<ISkillSlotExtendData> GetSkillSlots()
	{
		return this.SkillSlotsInternal;
	}

	// Token: 0x060151D3 RID: 86483 RVA: 0x005581AA File Offset: 0x005563AA
	protected override List<int> GetSkillGoalUpgradeLevel()
	{
		return this.SkillGoalUpgradeLevelInternal;
	}

	// Token: 0x060151D4 RID: 86484 RVA: 0x005581B2 File Offset: 0x005563B2
	protected override List<IRoleDevDetailItemData> GetNormalDetailItems()
	{
		return this.DetailItemsInternal;
	}

	// Token: 0x060151D5 RID: 86485 RVA: 0x005581BA File Offset: 0x005563BA
	protected override bool GetIsNormalAllMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.DetailItemsInternal);
	}

	// Token: 0x060151D6 RID: 86486 RVA: 0x005581C7 File Offset: 0x005563C7
	protected override bool GetIsUnlockedPerfect()
	{
		return this.PerfectGoalUpgradeLevelInternal.Count > 0;
	}

	// Token: 0x060151D7 RID: 86487 RVA: 0x005581D7 File Offset: 0x005563D7
	protected override List<int> GetPerfectGoalUpgradeLevel()
	{
		return this.PerfectGoalUpgradeLevelInternal;
	}

	// Token: 0x060151D8 RID: 86488 RVA: 0x005581DF File Offset: 0x005563DF
	protected override List<IRoleDevDetailItemData> GetPerfectDetailItems()
	{
		return this.PerfectDetailItemsInternal;
	}

	// Token: 0x060151D9 RID: 86489 RVA: 0x005581E7 File Offset: 0x005563E7
	protected override bool GetIsPerfectMaterialEnough()
	{
		return RoleDevUtils.CheckAllItemsUp(this.PerfectDetailItemsInternal);
	}

	// Token: 0x060151DA RID: 86490 RVA: 0x005581F4 File Offset: 0x005563F4
	protected override bool GetIsBreakthroughLevelLow()
	{
		return false;
	}

	// Token: 0x060151DB RID: 86491 RVA: 0x005581F7 File Offset: 0x005563F7
	protected override bool GetIsHideMaterialList()
	{
		return false;
	}

	// Token: 0x060151DC RID: 86492 RVA: 0x005581FA File Offset: 0x005563FA
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x060151DD RID: 86493 RVA: 0x005581FD File Offset: 0x005563FD
	protected override bool GetShouldForcePerfectPlan()
	{
		return false;
	}

	// Token: 0x060151DE RID: 86494 RVA: 0x00558200 File Offset: 0x00556400
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

	// Token: 0x060151DF RID: 86495 RVA: 0x00558238 File Offset: 0x00556438
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

	// Token: 0x060151E0 RID: 86496 RVA: 0x005582B8 File Offset: 0x005564B8
	private List<IRoleDevDetailItemData> CreateSkillDetailItemsData(int[] skillNodeIdList, int[] currentLevels, int[] targetLevels, int roleId)
	{
		return RoleDevUtils.CreateSkillDetailItemsData(skillNodeIdList, currentLevels, targetLevels, roleId);
	}

	// Token: 0x04009E4A RID: 40522
	private List<ISkillSlotExtendData> SkillSlotsInternal = new List<ISkillSlotExtendData>();

	// Token: 0x04009E4B RID: 40523
	private List<int> SkillGoalUpgradeLevelInternal = new List<int>();

	// Token: 0x04009E4C RID: 40524
	private List<IRoleDevDetailItemData> DetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x04009E4D RID: 40525
	private List<int> PerfectGoalUpgradeLevelInternal = new List<int>();

	// Token: 0x04009E4E RID: 40526
	private List<IRoleDevDetailItemData> PerfectDetailItemsInternal = new List<IRoleDevDetailItemData>();

	// Token: 0x04009E4F RID: 40527
	[Nullable(2)]
	private RoleDevViewModel RoleDevViewModelInternal;
}
