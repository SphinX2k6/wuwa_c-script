using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x020027B7 RID: 10167
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillData : RoleModuleDataBase
{
	// Token: 0x06014E85 RID: 85637 RVA: 0x0054F194 File Offset: 0x0054D394
	public RoleSkillData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06014E86 RID: 85638 RVA: 0x0054F1EC File Offset: 0x0054D3EC
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

	// Token: 0x06014E87 RID: 85639 RVA: 0x0054F22F File Offset: 0x0054D42F
	public int GetSkillLevel(int skillId)
	{
		if (!this.RoleSkillMap.ContainsKey(skillId))
		{
			return 0;
		}
		return this.RoleSkillMap[skillId];
	}

	// Token: 0x06014E88 RID: 85640 RVA: 0x0054F250 File Offset: 0x0054D450
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

	// Token: 0x06014E89 RID: 85641 RVA: 0x0054F29C File Offset: 0x0054D49C
	public int[] GetAllSkillLevel()
	{
		int[] array = new int[this.RoleSkillMap.Values.Count];
		this.RoleSkillMap.Values.CopyTo(array, 0);
		return array;
	}

	// Token: 0x06014E8A RID: 85642 RVA: 0x0054F2D4 File Offset: 0x0054D4D4
	public Aki.Config.Skill[] GetSkillList()
	{
		if (this.SkillConfigList.Count > 0)
		{
			return this.SkillConfigList.ToArray();
		}
		int skillId = base.GetRoleConfig().SkillId;
		List<Aki.Config.Skill> list = ConfigCommon.ToList<Aki.Config.Skill>(RoleSkillConfig.Instance.GetSkillList(skillId));
		list.Sort((Aki.Config.Skill aSkill, Aki.Config.Skill bSkill) => aSkill.SortIndex - bSkill.SortIndex);
		this.InitSkillConfigCache(list.ToList<Aki.Config.Skill>());
		return list.ToArray();
	}

	// Token: 0x06014E8B RID: 85643 RVA: 0x0054F354 File Offset: 0x0054D554
	private void InitSkillConfigCache(List<Aki.Config.Skill> skillConfigs)
	{
		int count = skillConfigs.Count;
		for (int i = 0; i < count; i++)
		{
			Aki.Config.Skill skill = skillConfigs[i];
			this.SkillConfigList.Add(skill);
			this.SkillConfigMap[skill.Id] = skill;
		}
	}

	// Token: 0x06014E8C RID: 85644 RVA: 0x0054F39C File Offset: 0x0054D59C
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

	// Token: 0x06014E8D RID: 85645 RVA: 0x0054F3E6 File Offset: 0x0054D5E6
	public bool IsHasSkill(int id)
	{
		return this.RoleSkillMap.ContainsKey(id);
	}

	// Token: 0x06014E8E RID: 85646 RVA: 0x0054F3F4 File Offset: 0x0054D5F4
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

	// Token: 0x06014E8F RID: 85647 RVA: 0x0054F49C File Offset: 0x0054D69C
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

	// Token: 0x06014E90 RID: 85648 RVA: 0x0054F4BC File Offset: 0x0054D6BC
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

	// Token: 0x06014E91 RID: 85649 RVA: 0x0054F5A4 File Offset: 0x0054D7A4
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

	// Token: 0x06014E92 RID: 85650 RVA: 0x0054F61A File Offset: 0x0054D81A
	public void SetSkillNodeStateData(Dictionary<int, SkillNodeDataInfo> skillNodeState)
	{
		this.SkillNodeDataMap = skillNodeState;
		EventSystem.Instance.Emit(EEventName.SkillTreeRefresh);
	}

	// Token: 0x06014E93 RID: 85651 RVA: 0x0054F633 File Offset: 0x0054D833
	public Dictionary<int, SkillNodeDataInfo> GetSkillNodeStateData()
	{
		return this.SkillNodeDataMap;
	}

	// Token: 0x06014E94 RID: 85652 RVA: 0x0054F63B File Offset: 0x0054D83B
	public ESkillTreeNodeState GetSkillTreeNodeState(SkillTree skillTree, int roleId)
	{
		if (skillTree.SkillId > 0 && skillTree.NodeType != 3)
		{
			return this.GetSkillTreeSkillNodeState(skillTree, roleId);
		}
		return this.GetSkillTreeAttributeNodeState(skillTree, roleId);
	}

	// Token: 0x06014E95 RID: 85653 RVA: 0x0054F664 File Offset: 0x0054D864
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

	// Token: 0x06014E96 RID: 85654 RVA: 0x0054F6E8 File Offset: 0x0054D8E8
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

	// Token: 0x06014E97 RID: 85655 RVA: 0x0054F750 File Offset: 0x0054D950
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

	// Token: 0x06014E98 RID: 85656 RVA: 0x0054F794 File Offset: 0x0054D994
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

	// Token: 0x06014E99 RID: 85657 RVA: 0x0054F7F8 File Offset: 0x0054D9F8
	public bool IsSkillTreeNodeActive(int id)
	{
		SkillNodeDataInfo valueOrDefault = this.GetSkillNodeStateData().GetValueOrDefault(id);
		return valueOrDefault != null && valueOrDefault.IsActive;
	}

	// Token: 0x06014E9A RID: 85658 RVA: 0x0054F820 File Offset: 0x0054DA20
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

	// Token: 0x06014E9B RID: 85659 RVA: 0x0054F9A0 File Offset: 0x0054DBA0
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

	// Token: 0x06014E9C RID: 85660 RVA: 0x0054FA4C File Offset: 0x0054DC4C
	public int GetSkillIdAfterUpgrade(int skillIdBeforeUpgrade)
	{
		if (!this.RoleUpgradeSkillMap.ContainsKey(skillIdBeforeUpgrade))
		{
			return 0;
		}
		return this.RoleUpgradeSkillMap[skillIdBeforeUpgrade];
	}

	// Token: 0x06014E9D RID: 85661 RVA: 0x0054FA6A File Offset: 0x0054DC6A
	public bool HasAnySkillUpgrade()
	{
		return this.RoleUpgradeSkillMap.Count > 0;
	}

	// Token: 0x06014E9E RID: 85662 RVA: 0x0054FA7C File Offset: 0x0054DC7C
	public ESkillShowTagType GetSkillShowTagType(int skillId)
	{
		Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillId);
		if (skillConfigById != null)
		{
			return (ESkillShowTagType)skillConfigById.Value.SkillShowTagType;
		}
		return ESkillShowTagType.None;
	}

	// Token: 0x04009D11 RID: 40209
	protected Dictionary<int, int> RoleSkillMap = new Dictionary<int, int>();

	// Token: 0x04009D12 RID: 40210
	protected Dictionary<int, int> RoleUpgradeSkillMap = new Dictionary<int, int>();

	// Token: 0x04009D13 RID: 40211
	protected Dictionary<ERoleSkillReferenceType, Dictionary<long, int>> RoleSkillReferenceMap = new Dictionary<ERoleSkillReferenceType, Dictionary<long, int>>();

	// Token: 0x04009D14 RID: 40212
	protected Dictionary<int, SkillNodeDataInfo> SkillNodeDataMap = new Dictionary<int, SkillNodeDataInfo>();

	// Token: 0x04009D15 RID: 40213
	private readonly Dictionary<int, Aki.Config.Skill> SkillConfigMap = new Dictionary<int, Aki.Config.Skill>();

	// Token: 0x04009D16 RID: 40214
	private readonly List<Aki.Config.Skill> SkillConfigList = new List<Aki.Config.Skill>();
}
