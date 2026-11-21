using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02001D32 RID: 7474
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillData : RoleModuleDataBase
{
	// Token: 0x06012884 RID: 75908 RVA: 0x00579EBC File Offset: 0x005780BC
	public RoleSkillData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06012885 RID: 75909 RVA: 0x00579F14 File Offset: 0x00578114
	public int GetSkillNodeLevel(SkillTree config)
	{
		int result = 0;
		ESkillTreeNodeType nodeType = (ESkillTreeNodeType)config.NodeType;
		if (nodeType == ESkillTreeNodeType.InnerSkill || nodeType == ESkillTreeNodeType.InnerPassiveSkill)
		{
			int skillId = config.SkillId;
			result = this.GetSkillLevel(skillId);
		}
		else if (this.IsSkillTreeNodeActive(config.Id))
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06012886 RID: 75910 RVA: 0x00579F57 File Offset: 0x00578157
	public int GetSkillLevel(int skillId)
	{
		if (!this.RoleSkillMap.ContainsKey(skillId))
		{
			return 0;
		}
		return this.RoleSkillMap[skillId];
	}

	// Token: 0x06012887 RID: 75911 RVA: 0x00579F78 File Offset: 0x00578178
	public void SetSkillLevel(int key, int level)
	{
		this.RoleSkillMap[key] = level;
		if (level > 0)
		{
			int upgradeSkillId = RoleSkillConfig.Instance.GetSkillConfigById(key).Value.UpgradeSkillId;
			if (upgradeSkillId > 0)
			{
				this.RoleUpgradeSkillMap[upgradeSkillId] = key;
			}
		}
	}

	// Token: 0x06012888 RID: 75912 RVA: 0x00579FC4 File Offset: 0x005781C4
	public int[] GetAllSkillLevel()
	{
		int[] array = new int[this.RoleSkillMap.Values.Count];
		this.RoleSkillMap.Values.CopyTo(array, 0);
		return array;
	}

	// Token: 0x06012889 RID: 75913 RVA: 0x00579FFC File Offset: 0x005781FC
	public Aki.Config.Skill[] GetSkillList()
	{
		if (this.SkillConfigList.Count > 0)
		{
			return this.SkillConfigList.ToArray();
		}
		int skillId = base.GetRoleConfig().SkillId;
		List<Aki.Config.Skill> list = ConfigCommon.ToList<Aki.Config.Skill>(RoleSkillConfig.Instance.GetSkillList(skillId));
		list.Sort((Aki.Config.Skill aSkill, Aki.Config.Skill bSkill) => aSkill.SortIndex - bSkill.SortIndex);
		this.InitSkillConfigCache(list);
		return list.ToArray();
	}

	// Token: 0x0601288A RID: 75914 RVA: 0x0057A078 File Offset: 0x00578278
	private void InitSkillConfigCache(IReadOnlyList<Aki.Config.Skill> skillConfigs)
	{
		int count = skillConfigs.Count;
		for (int i = 0; i < count; i++)
		{
			Aki.Config.Skill skill = skillConfigs[i];
			this.SkillConfigList.Add(skill);
			this.SkillConfigMap[skill.Id] = skill;
		}
	}

	// Token: 0x0601288B RID: 75915 RVA: 0x0057A0C0 File Offset: 0x005782C0
	public Aki.Config.Skill? GetSkillConfigFromCache(int id)
	{
		if (this.SkillConfigMap.Count == 0)
		{
			this.GetSkillList();
		}
		if (!this.SkillConfigMap.ContainsKey(id))
		{
			return null;
		}
		return new Aki.Config.Skill?(this.SkillConfigMap[id]);
	}

	// Token: 0x0601288C RID: 75916 RVA: 0x0057A10A File Offset: 0x0057830A
	public bool IsHasSkill(int id)
	{
		return this.RoleSkillMap.ContainsKey(id);
	}

	// Token: 0x0601288D RID: 75917 RVA: 0x0057A118 File Offset: 0x00578318
	protected IList<long> GetReferenceList(int skillId, ERoleSkillReferenceType type)
	{
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		switch (type)
		{
		case ERoleSkillReferenceType.SkillInfo:
		{
			IList<long> list = new List<long>();
			foreach (int num in skillConfigById.Value.SkillInfoListIter())
			{
				list.Add((long)num);
			}
			return list;
		}
		case ERoleSkillReferenceType.Buff:
			return skillConfigById.Value.GetBuffListArray();
		case ERoleSkillReferenceType.Damage:
			return skillConfigById.Value.GetDamageListArray();
		default:
			return new List<long>();
		}
	}

	// Token: 0x0601288E RID: 75918 RVA: 0x0057A1C0 File Offset: 0x005783C0
	protected int GetDefaultSkillLevel(ERoleSkillReferenceType type)
	{
		switch (type)
		{
		case ERoleSkillReferenceType.SkillInfo:
			return 1;
		case ERoleSkillReferenceType.Buff:
			return -1;
		case ERoleSkillReferenceType.Damage:
			return -1;
		default:
			return -1;
		}
	}

	// Token: 0x0601288F RID: 75919 RVA: 0x0057A1E0 File Offset: 0x005783E0
	public void SetSkillReferenceMapBySkillId(int skillId)
	{
		foreach (ERoleSkillReferenceType eroleSkillReferenceType in Enum.GetValues<ERoleSkillReferenceType>())
		{
			if (!this.RoleSkillReferenceMap.ContainsKey(eroleSkillReferenceType))
			{
				this.RoleSkillReferenceMap[eroleSkillReferenceType] = new Dictionary<long, int>();
			}
			Dictionary<long, int> dictionary = this.RoleSkillReferenceMap[eroleSkillReferenceType];
			foreach (long num in this.GetReferenceList(skillId, eroleSkillReferenceType))
			{
				if (!dictionary.ContainsKey(num))
				{
					dictionary[num] = skillId;
				}
				else if (dictionary[num] != skillId)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Role;
					ELogAuthor author = ELogAuthor.LZK;
					string message = "技能表里的这个ID不能对应多个技能";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ID", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}
	}

	// Token: 0x06012890 RID: 75920 RVA: 0x0057A2C8 File Offset: 0x005784C8
	[NullableContext(2)]
	public int GetReferencedSkillLevel(long id, ERoleSkillReferenceType type, Entity entity = null)
	{
		if (!this.RoleSkillReferenceMap.ContainsKey(type) || !this.RoleSkillReferenceMap[type].ContainsKey(id))
		{
			return this.GetDefaultSkillLevel(type);
		}
		int num = this.RoleSkillReferenceMap[type][id];
		int skillLevel = this.GetSkillLevel(num);
		Aki.Config.Skill? skillConfigFromCache = this.GetSkillConfigFromCache(num);
		if (entity != null && skillConfigFromCache != null)
		{
			return AddSkillLevelEffect.ApplyEffects(entity, skillConfigFromCache.Value, skillLevel);
		}
		return skillLevel;
	}

	// Token: 0x06012891 RID: 75921 RVA: 0x0057A33E File Offset: 0x0057853E
	public void SetSkillNodeStateData(Dictionary<int, SkillNodeDataInfo> skillNodeState)
	{
		this.SkillNodeDataMap = skillNodeState;
		EventSystem.Instance.Emit(EEventName.SkillTreeRefresh);
	}

	// Token: 0x06012892 RID: 75922 RVA: 0x0057A357 File Offset: 0x00578557
	public Dictionary<int, SkillNodeDataInfo> GetSkillNodeStateData()
	{
		return this.SkillNodeDataMap;
	}

	// Token: 0x06012893 RID: 75923 RVA: 0x0057A35F File Offset: 0x0057855F
	public ESkillTreeNodeState GetSkillTreeNodeState(SkillTree skillTree, int roleId)
	{
		if (skillTree.SkillId > 0 && skillTree.NodeType != 3)
		{
			return this.GetSkillTreeSkillNodeState(skillTree, roleId);
		}
		return this.GetSkillTreeAttributeNodeState(skillTree, roleId);
	}

	// Token: 0x06012894 RID: 75924 RVA: 0x0057A388 File Offset: 0x00578588
	public ESkillTreeNodeState GetSkillTreeSkillNodeState(SkillTree skillTree, int roleId)
	{
		int skillId = skillTree.SkillId;
		Aki.Config.Skill value = RoleSkillConfig.Instance.GetSkillConfigById(skillId).Value;
		int skillLevel = this.GetSkillLevel(skillId);
		int maxSkillLevel = value.MaxSkillLevel;
		if (skillLevel == maxSkillLevel)
		{
			return ESkillTreeNodeState.Active;
		}
		if (this.GetSkillTreeUnsatisfiedCondition(skillTree) != null)
		{
			return ESkillTreeNodeState.Lock;
		}
		int roleSkillTreeNodeUnlockConditionId = this.GetRoleSkillTreeNodeUnlockConditionId(skillTree);
		if (!LevelGeneralController.Instance.CheckCondition(roleSkillTreeNodeUnlockConditionId.ToString(), null, true, new object[]
		{
			roleId
		}))
		{
			return ESkillTreeNodeState.Lock;
		}
		return ESkillTreeNodeState.Inactive;
	}

	// Token: 0x06012895 RID: 75925 RVA: 0x0057A40C File Offset: 0x0057860C
	public ESkillTreeNodeState GetSkillTreeAttributeNodeState(SkillTree skillTree, int roleId)
	{
		if (this.IsSkillTreeNodeActive(skillTree.Id))
		{
			return ESkillTreeNodeState.Active;
		}
		if (this.GetSkillTreeUnsatisfiedCondition(skillTree) != null)
		{
			return ESkillTreeNodeState.Lock;
		}
		int roleSkillTreeNodeUnlockConditionId = this.GetRoleSkillTreeNodeUnlockConditionId(skillTree);
		if (roleSkillTreeNodeUnlockConditionId > 0 && !LevelGeneralController.Instance.CheckCondition(roleSkillTreeNodeUnlockConditionId.ToString(), null, true, new object[]
		{
			roleId
		}))
		{
			return ESkillTreeNodeState.Lock;
		}
		return ESkillTreeNodeState.Inactive;
	}

	// Token: 0x06012896 RID: 75926 RVA: 0x0057A474 File Offset: 0x00578674
	[NullableContext(2)]
	public string GetUnlockConditionTextId(SkillTree skillTree)
	{
		SkillCondition? skillTreeUnsatisfiedCondition = this.GetSkillTreeUnsatisfiedCondition(skillTree);
		if (skillTreeUnsatisfiedCondition != null)
		{
			return skillTreeUnsatisfiedCondition.Value.Description;
		}
		int roleSkillTreeNodeUnlockConditionId = this.GetRoleSkillTreeNodeUnlockConditionId(skillTree);
		if (roleSkillTreeNodeUnlockConditionId > 0)
		{
			return LevelGeneralCommons.GetConditionGroupHintText(roleSkillTreeNodeUnlockConditionId);
		}
		return null;
	}

	// Token: 0x06012897 RID: 75927 RVA: 0x0057A4B8 File Offset: 0x005786B8
	public int GetRoleSkillTreeNodeUnlockConditionId(SkillTree skillTree)
	{
		int skillId = skillTree.SkillId;
		if (skillId > 0)
		{
			Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
			int skillLevel = this.GetSkillLevel(skillId);
			return RoleSkillConfig.Instance.GetSkillLevelConfigByGroupIdAndLevel(skillConfigById.Value.SkillLevelGroupId, skillLevel + 1).Value.Condition;
		}
		return skillTree.UnLockCondition;
	}

	// Token: 0x06012898 RID: 75928 RVA: 0x0057A51C File Offset: 0x0057871C
	public bool IsSkillTreeNodeActive(int id)
	{
		SkillNodeDataInfo valueOrDefault = this.GetSkillNodeStateData().GetValueOrDefault(id);
		return valueOrDefault != null && valueOrDefault.IsActive;
	}

	// Token: 0x06012899 RID: 75929 RVA: 0x0057A544 File Offset: 0x00578744
	public SkillCondition? GetSkillTreeUnsatisfiedCondition(SkillTree skillTree)
	{
		foreach (int skillConditionId in skillTree.ConditionIter())
		{
			SkillCondition? skillConditionById = RoleSkillConfig.Instance.GetSkillConditionById(skillConditionId);
			int nodeGroup = skillTree.NodeGroup;
			if (skillConditionById != null)
			{
				if (skillConditionById.Value.ConditionType == 1)
				{
					using (IEnumerator<DicIntInt> enumerator2 = skillConditionById.Value.ConditionParamIter().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							DicIntInt dicIntInt = enumerator2.Current;
							int key = dicIntInt.Key;
							int value = dicIntInt.Value;
							if (this.GetSkillNodeLevel(RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(nodeGroup, key).Value) < value)
							{
								return skillConditionById;
							}
						}
						continue;
					}
				}
				if (skillConditionById.Value.ConditionType == 2)
				{
					int parentNodesLength = skillTree.ParentNodesLength;
					for (int i = 0; i < parentNodesLength; i++)
					{
						int nodeIndex = skillTree.ParentNodes()[i];
						if (this.GetSkillNodeLevel(RoleSkillConfig.Instance.GetSkillTreeNodeByGroupIdAndIndex(nodeGroup, nodeIndex).Value) == 0)
						{
							return skillConditionById;
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0601289A RID: 75930 RVA: 0x0057A6C4 File Offset: 0x005788C4
	public bool IsSkillTreeNodeConsumeSatisfied(int nodeId)
	{
		int skillNodeLevel = this.GetSkillNodeLevel(RoleSkillConfig.Instance.GetSkillTreeNode(nodeId).Value);
		IEnumerable<DicIntInt?> roleSkillTreeConsume = RoleSkillConfig.Instance.GetRoleSkillTreeConsume(nodeId, skillNodeLevel + 1);
		if (roleSkillTreeConsume != null)
		{
			foreach (DicIntInt? dicIntInt in roleSkillTreeConsume)
			{
				int key = dicIntInt.Value.Key;
				int value = dicIntInt.Value.Value;
				if (InventoryModel.Instance.GetItemCountByConfigId(key, 0) < value)
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x0601289B RID: 75931 RVA: 0x0057A770 File Offset: 0x00578970
	public int GetSkillIdAfterUpgrade(int skillIdBeforeUpgrade)
	{
		if (!this.RoleUpgradeSkillMap.ContainsKey(skillIdBeforeUpgrade))
		{
			return 0;
		}
		return this.RoleUpgradeSkillMap[skillIdBeforeUpgrade];
	}

	// Token: 0x0601289C RID: 75932 RVA: 0x0057A78E File Offset: 0x0057898E
	public bool HasAnySkillUpgrade()
	{
		return this.RoleUpgradeSkillMap.Count > 0;
	}

	// Token: 0x0601289D RID: 75933 RVA: 0x0057A7A0 File Offset: 0x005789A0
	public ESkillShowTagType GetSkillShowTagType(int skillId)
	{
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		if (skillConfigById != null)
		{
			return (ESkillShowTagType)skillConfigById.Value.SkillShowTagType;
		}
		return ESkillShowTagType.None;
	}

	// Token: 0x0400A0F4 RID: 41204
	protected Dictionary<int, int> RoleSkillMap = new Dictionary<int, int>();

	// Token: 0x0400A0F5 RID: 41205
	protected Dictionary<int, int> RoleUpgradeSkillMap = new Dictionary<int, int>();

	// Token: 0x0400A0F6 RID: 41206
	protected Dictionary<ERoleSkillReferenceType, Dictionary<long, int>> RoleSkillReferenceMap = new Dictionary<ERoleSkillReferenceType, Dictionary<long, int>>();

	// Token: 0x0400A0F7 RID: 41207
	protected Dictionary<int, SkillNodeDataInfo> SkillNodeDataMap = new Dictionary<int, SkillNodeDataInfo>();

	// Token: 0x0400A0F8 RID: 41208
	private readonly Dictionary<int, Aki.Config.Skill> SkillConfigMap = new Dictionary<int, Aki.Config.Skill>();

	// Token: 0x0400A0F9 RID: 41209
	private readonly List<Aki.Config.Skill> SkillConfigList = new List<Aki.Config.Skill>();
}
