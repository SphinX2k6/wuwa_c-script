using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027BA RID: 10170
[NullableContext(1)]
[Nullable(0)]
public class RoleRobotData : RoleDataBase
{
	// Token: 0x06014EC9 RID: 85705 RVA: 0x0055024C File Offset: 0x0054E44C
	public RoleRobotData(int id) : base(id)
	{
		this.SetDefaultData();
	}

	// Token: 0x06014ECA RID: 85706 RVA: 0x0055025B File Offset: 0x0054E45B
	protected void SetDefaultData()
	{
		this.SetLevelData();
		this.SetSkillData();
		this.SetResonanceData();
		this.SetWeaponData();
		this.SetPhantomData();
		this.SetSkinData();
	}

	// Token: 0x06014ECB RID: 85707 RVA: 0x00550284 File Offset: 0x0054E484
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

	// Token: 0x06014ECC RID: 85708 RVA: 0x00550348 File Offset: 0x0054E548
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

	// Token: 0x06014ECD RID: 85709 RVA: 0x005504CC File Offset: 0x0054E6CC
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

	// Token: 0x06014ECE RID: 85710 RVA: 0x00550558 File Offset: 0x0054E758
	private int GetTrialSkillLevel(int skillId)
	{
		IReadOnlyList<SkillLevel> skillLevelConfigList = RoleSkillConfig.Instance.GetSkillLevelConfigList(skillId);
		if (skillLevelConfigList == null || skillLevelConfigList.Count == 0)
		{
			return 0;
		}
		List<SkillLevel> list = (from aConfig in skillLevelConfigList
		orderby aConfig.Id
		select aConfig).ToList<SkillLevel>();
		return list[list.Count - 1].SkillId;
	}

	// Token: 0x06014ECF RID: 85711 RVA: 0x005505C0 File Offset: 0x0054E7C0
	private void SetResonanceData()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return;
		}
		base.GetResonanceData().SetResonantChainGroupIndex(trialRoleConfig.Value.ResonanceLevel);
	}

	// Token: 0x06014ED0 RID: 85712 RVA: 0x00550604 File Offset: 0x0054E804
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

	// Token: 0x06014ED1 RID: 85713 RVA: 0x00550664 File Offset: 0x0054E864
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

	// Token: 0x06014ED2 RID: 85714 RVA: 0x00550858 File Offset: 0x0054EA58
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

	// Token: 0x06014ED3 RID: 85715 RVA: 0x005508A8 File Offset: 0x0054EAA8
	public override int GetRoleId()
	{
		TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(this.Id);
		if (trialRoleConfig == null)
		{
			return 0;
		}
		return trialRoleConfig.Value.ParentId;
	}

	// Token: 0x06014ED4 RID: 85716 RVA: 0x005508E0 File Offset: 0x0054EAE0
	public override bool IsTrialRole()
	{
		return true;
	}

	// Token: 0x06014ED5 RID: 85717 RVA: 0x005508E4 File Offset: 0x0054EAE4
	public override string GetName(int? playerId = null)
	{
		return RoleConfig.Instance.GetRoleName(base.GetRoleConfig().Name);
	}

	// Token: 0x06014ED6 RID: 85718 RVA: 0x00550909 File Offset: 0x0054EB09
	public void SetName(string name)
	{
		this.Name = name;
	}

	// Token: 0x06014ED7 RID: 85719 RVA: 0x00550912 File Offset: 0x0054EB12
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x06014ED8 RID: 85720 RVA: 0x00550915 File Offset: 0x0054EB15
	[NullableContext(2)]
	public WeaponTrialData GetWeaponData()
	{
		return this.WeaponTrialData;
	}

	// Token: 0x06014ED9 RID: 85721 RVA: 0x0055091D File Offset: 0x0054EB1D
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x06014EDA RID: 85722 RVA: 0x00550920 File Offset: 0x0054EB20
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x06014EDB RID: 85723 RVA: 0x00550923 File Offset: 0x0054EB23
	public override bool GetIsNew()
	{
		return false;
	}

	// Token: 0x06014EDC RID: 85724 RVA: 0x00550926 File Offset: 0x0054EB26
	public virtual bool CanEditInFormation()
	{
		return false;
	}

	// Token: 0x06014EDD RID: 85725 RVA: 0x00550929 File Offset: 0x0054EB29
	public virtual bool IsVisibleInFormation()
	{
		return false;
	}

	// Token: 0x06014EDE RID: 85726 RVA: 0x0055092C File Offset: 0x0054EB2C
	public int GetTrialRoleId()
	{
		return this.Id;
	}

	// Token: 0x04009D1F RID: 40223
	[Nullable(2)]
	private WeaponTrialData WeaponTrialData;
}
