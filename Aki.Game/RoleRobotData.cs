using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D35 RID: 7477
[NullableContext(1)]
[Nullable(0)]
public class RoleRobotData : RoleDataBase
{
	// Token: 0x060128C8 RID: 75976 RVA: 0x0057AF70 File Offset: 0x00579170
	public RoleRobotData(int id) : base(id)
	{
		this.SetDefaultData();
	}

	// Token: 0x060128C9 RID: 75977 RVA: 0x0057AF7F File Offset: 0x0057917F
	protected void SetDefaultData()
	{
		this.SetLevelData();
		this.SetSkillData();
		this.SetResonanceData();
		this.SetWeaponData();
		this.SetPhantomData();
		this.SetSkinData();
	}

	// Token: 0x060128CA RID: 75978 RVA: 0x0057AFA8 File Offset: 0x005791A8
	private void SetLevelData()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		RoleLevelData levelData = base.GetLevelData();
		levelData.SetLevel(trialRoleConfig.Value.Level);
		RoleInfo roleConfig = base.GetRoleConfig();
		IReadOnlyList<RoleBreach> roleBreachList = RoleConfig.Instance.GetRoleBreachList(roleConfig.BreachId);
		if (roleBreachList == null)
		{
			return;
		}
		foreach (RoleBreach roleBreach in roleBreachList)
		{
			if (trialRoleConfig.Value.Level <= roleBreach.MaxLevel)
			{
				levelData.SetBreachLevel(roleBreach.BreachLevel);
				break;
			}
		}
	}

	// Token: 0x060128CB RID: 75979 RVA: 0x0057B06C File Offset: 0x0057926C
	private void SetSkillData()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		RoleSkillData skillData = base.GetSkillData();
		int skillId = base.GetRoleConfig().SkillId;
		int roleId = this.GetRoleId();
		bool flag = RoleModel.Instance.ClientCheckRoleIsUpgradeLightMainRole(roleId);
		foreach (Aki.Config.Skill skill in skillData.GetSkillList())
		{
			int trialSkillLevel = this.GetTrialSkillLevel(skill.Id);
			int level = (trialSkillLevel < trialRoleConfig.Value.UnlockSkillLevel) ? trialSkillLevel : trialRoleConfig.Value.UnlockSkillLevel;
			SkillTree? skillTreeNodeByGroupIdAndSkillId = RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndSkillId(skillId, skill.Id);
			if (skillTreeNodeByGroupIdAndSkillId != null || flag)
			{
				if (skillTreeNodeByGroupIdAndSkillId != null && skillTreeNodeByGroupIdAndSkillId.Value.NodeType == 3)
				{
					skillData.SetSkillLevel(skill.Id, 0);
				}
				else
				{
					skillData.SetSkillLevel(skill.Id, level);
				}
				skillData.SetSkillReferenceMapBySkillId(skill.Id);
			}
		}
		new List<SkillNodeDataInfo>();
		Dictionary<int, SkillNodeDataInfo> dictionary = new Dictionary<int, SkillNodeDataInfo>();
		foreach (int nodeIndex in trialRoleConfig.Value.UnlockSkillNodeList())
		{
			this.AddSkillNodeData(skillId, nodeIndex, dictionary);
		}
		this.AddSkillNodeData(skillId, 8, dictionary);
		this.AddSkillNodeData(skillId, 17, dictionary);
		skillData.SetSkillNodeStateData(dictionary);
	}

	// Token: 0x060128CC RID: 75980 RVA: 0x0057B1F0 File Offset: 0x005793F0
	private void AddSkillNodeData(int skillGroupId, int nodeIndex, Dictionary<int, SkillNodeDataInfo> skillNodeDataMap)
	{
		SkillTree? skillTreeNodeByGroupIdAndIndex = RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(skillGroupId, nodeIndex);
		int? num = (skillTreeNodeByGroupIdAndIndex != null) ? new int?(skillTreeNodeByGroupIdAndIndex.GetValueOrDefault().NodeType) : null;
		if (num.GetValueOrDefault() == 4 || num.GetValueOrDefault() == 3)
		{
			int id = skillTreeNodeByGroupIdAndIndex.Value.Id;
			SkillNodeDataInfo value = new SkillNodeDataInfo(id, true, skillTreeNodeByGroupIdAndIndex.Value.SkillId);
			skillNodeDataMap[id] = value;
		}
	}

	// Token: 0x060128CD RID: 75981 RVA: 0x0057B27C File Offset: 0x0057947C
	private int GetTrialSkillLevel(int skillId)
	{
		IReadOnlyList<SkillLevel> skillLevelConfigList = RoleSkillConfig.Instance.GetSkillLevelConfigList(skillId);
		if (skillLevelConfigList == null || skillLevelConfigList.Count == 0)
		{
			return 0;
		}
		SkillLevel skillLevel = skillLevelConfigList[0];
		for (int i = 1; i < skillLevelConfigList.Count; i++)
		{
			if (skillLevelConfigList[i].Id >= skillLevel.Id)
			{
				skillLevel = skillLevelConfigList[i];
			}
		}
		return skillLevel.SkillId;
	}

	// Token: 0x060128CE RID: 75982 RVA: 0x0057B2E4 File Offset: 0x005794E4
	private void SetResonanceData()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		base.GetResonanceData().SetResonantChainGroupIndex(trialRoleConfig.Value.ResonanceLevel);
	}

	// Token: 0x060128CF RID: 75983 RVA: 0x0057B328 File Offset: 0x00579528
	private void SetWeaponData()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		this.WeaponTrialData = new WeaponTrialData();
		this.WeaponTrialData.SetTrialId(trialRoleConfig.Value.TrailWeapon, true);
		this.WeaponTrialData.SetRoleId(this.Id);
	}

	// Token: 0x060128D0 RID: 75984 RVA: 0x0057B388 File Offset: 0x00579588
	private void SetPhantomData()
	{
		RolePhantomData phantomData = base.GetPhantomData();
		phantomData.SetIsTrial(true);
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		int i = 0;
		int num = trialRoleConfig.Value.PhantomEquipList().Length;
		while (i < num)
		{
			IntPair intPair = trialRoleConfig.Value.PhantomEquipList()[i];
			TrailPhantomProp? trialPhantomPropConfig = PhantomBattleConfig.Instance.GetTrialPhantomPropConfig(intPair.Item2);
			if (trialPhantomPropConfig != null)
			{
				PhantomTrialBattleData phantomTrialBattleData = new PhantomTrialBattleData();
				phantomTrialBattleData.SetIncId(PhantomDataBase.GenerateLocalUniqueId(this.GetRoleId(), i));
				phantomTrialBattleData.SetConfigId(intPair.Item1);
				phantomTrialBattleData.SetPhantomLevel(trialPhantomPropConfig.Value.Level);
				phantomTrialBattleData.SetSlotIndex(i);
				phantomTrialBattleData.SetFetterGroupId(trialPhantomPropConfig.Value.FetterGroupId);
				foreach (int id in trialPhantomPropConfig.Value.MainProps())
				{
					ConfigPropValue trailPhantomPropItemById = PhantomBattleConfig.Instance.GetTrailPhantomPropItemById(id);
					int phantomGrowthValueByGrowthIdAndLevel = PhantomBattleConfig.Instance.GetPhantomGrowthValueByGrowthIdAndLevel(trialPhantomPropConfig.Value.MainPropGrowth, trialPhantomPropConfig.Value.Level);
					double attributeValue = TipsDataTool.GetAttributeValue((double)trailPhantomPropItemById.Value, (double)phantomGrowthValueByGrowthIdAndLevel, false);
					phantomTrialBattleData.SetMainPropValue(trailPhantomPropItemById.Id, attributeValue, trailPhantomPropItemById.IsRatio);
				}
				foreach (int id2 in trialPhantomPropConfig.Value.SubPropList())
				{
					ConfigPropValue trailPhantomPropItemById2 = PhantomBattleConfig.Instance.GetTrailPhantomPropItemById(id2);
					phantomTrialBattleData.SetSubPropValue(trailPhantomPropItemById2.Id, (double)trailPhantomPropItemById2.Value, trailPhantomPropItemById2.IsRatio);
				}
				phantomData.SetDataMap(i, phantomTrialBattleData);
				PhantomBattleModel.Instance.SetRobotPhantomData(phantomTrialBattleData.GetIncrId(), phantomTrialBattleData);
			}
			i++;
		}
	}

	// Token: 0x060128D1 RID: 75985 RVA: 0x0057B57C File Offset: 0x0057977C
	private void SetSkinData()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		if (trialRoleConfig.Value.RoleSkin > 0)
		{
			base.SetRoleSkinId(trialRoleConfig.Value.RoleSkin);
		}
	}

	// Token: 0x060128D2 RID: 75986 RVA: 0x0057B5CC File Offset: 0x005797CC
	public override int GetRoleId()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return 0;
		}
		return trialRoleConfig.Value.ParentId;
	}

	// Token: 0x060128D3 RID: 75987 RVA: 0x0057B604 File Offset: 0x00579804
	public override bool IsTrialRole()
	{
		return true;
	}

	// Token: 0x060128D4 RID: 75988 RVA: 0x0057B608 File Offset: 0x00579808
	public override string GetName(int? playerId = null)
	{
		return RoleConfig.Instance.GetRoleName(base.GetRoleConfig().Name);
	}

	// Token: 0x060128D5 RID: 75989 RVA: 0x0057B62D File Offset: 0x0057982D
	public void SetName(string name)
	{
		this.Name = name;
	}

	// Token: 0x060128D6 RID: 75990 RVA: 0x0057B636 File Offset: 0x00579836
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x060128D7 RID: 75991 RVA: 0x0057B639 File Offset: 0x00579839
	[NullableContext(2)]
	public WeaponTrialData GetWeaponData()
	{
		return this.WeaponTrialData;
	}

	// Token: 0x060128D8 RID: 75992 RVA: 0x0057B641 File Offset: 0x00579841
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x060128D9 RID: 75993 RVA: 0x0057B644 File Offset: 0x00579844
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x060128DA RID: 75994 RVA: 0x0057B647 File Offset: 0x00579847
	public override bool GetIsNew()
	{
		return false;
	}

	// Token: 0x060128DB RID: 75995 RVA: 0x0057B64A File Offset: 0x0057984A
	public virtual bool CanEditInFormation()
	{
		return false;
	}

	// Token: 0x060128DC RID: 75996 RVA: 0x0057B64D File Offset: 0x0057984D
	public virtual bool IsVisibleInFormation()
	{
		return false;
	}

	// Token: 0x060128DD RID: 75997 RVA: 0x0057B650 File Offset: 0x00579850
	public int GetTrialRoleId()
	{
		return this.Id;
	}

	// Token: 0x0400A102 RID: 41218
	[Nullable(2)]
	private WeaponTrialData WeaponTrialData;
}
