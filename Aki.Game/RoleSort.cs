using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02000D50 RID: 3408
[NullableContext(1)]
[Nullable(0)]
public class RoleSort : CommonSort<ERoleSortWayType>
{
	// Token: 0x06008C44 RID: 35908 RVA: 0x002A77F0 File Offset: 0x002A59F0
	private int SortLevel(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		RoleLevelData levelData = roleDataBase.GetLevelData();
		RoleLevelData levelData2 = roleDataBase2.GetLevelData();
		if (levelData.GetLevel() != levelData2.GetLevel())
		{
			return (levelData2.GetLevel() - levelData.GetLevel()) * (isAscending ? -1 : 1);
		}
		if (levelData.GetBreachLevel() != levelData2.GetBreachLevel())
		{
			return (levelData2.GetBreachLevel() - levelData.GetBreachLevel()) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C45 RID: 35909 RVA: 0x002A7860 File Offset: 0x002A5A60
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int qualityId = roleDataBase.GetRoleConfig().QualityId;
		int qualityId2 = roleDataBase2.GetRoleConfig().QualityId;
		if (qualityId != qualityId2)
		{
			return (qualityId2 - qualityId) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C46 RID: 35910 RVA: 0x002A78A8 File Offset: 0x002A5AA8
	private int SortFormation(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int num = -1;
		int num2 = -1;
		List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
		for (int i = 0; i < teamItems.Count; i++)
		{
			SceneTeamItem sceneTeamItem = teamItems[i];
			if (roleDataBase.GetDataId() == sceneTeamItem.GetConfigId)
			{
				num = i;
			}
			if (roleDataBase2.GetDataId() == sceneTeamItem.GetConfigId)
			{
				num2 = i;
			}
		}
		bool flag = num >= 0;
		bool flag2 = num2 >= 0;
		if (!flag && !flag2)
		{
			return 0;
		}
		if (flag != flag2)
		{
			int num3 = (flag > false) ? 1 : 0;
			return ((flag2 > false) ? 1 : 0) - num3;
		}
		return num - num2;
	}

	// Token: 0x06008C47 RID: 35911 RVA: 0x002A7950 File Offset: 0x002A5B50
	private int SortPriority(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		if (roleDataBase.GetRoleConfig().Priority != roleDataBase2.GetRoleConfig().Priority)
		{
			return (roleDataBase2.GetRoleConfig().Priority - roleDataBase.GetRoleConfig().Priority) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C48 RID: 35912 RVA: 0x002A79B0 File Offset: 0x002A5BB0
	private int SortResonance(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int resonantChainGroupIndex = roleDataBase.GetResonanceData().GetResonantChainGroupIndex();
		int resonantChainGroupIndex2 = roleDataBase2.GetResonanceData().GetResonantChainGroupIndex();
		if (resonantChainGroupIndex != resonantChainGroupIndex2)
		{
			return (resonantChainGroupIndex2 - resonantChainGroupIndex) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C49 RID: 35913 RVA: 0x002A79F4 File Offset: 0x002A5BF4
	private int SortResonanceIncreased(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int resonanceIncreaseLevel = roleDataBase.GetResonanceData().GetResonanceIncreaseLevel();
		int resonanceIncreaseLevel2 = roleDataBase2.GetResonanceData().GetResonanceIncreaseLevel();
		if (resonanceIncreaseLevel != resonanceIncreaseLevel2)
		{
			return (resonanceIncreaseLevel2 - resonanceIncreaseLevel) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C4A RID: 35914 RVA: 0x002A7A36 File Offset: 0x002A5C36
	private int SortInCollected(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return 0;
	}

	// Token: 0x06008C4B RID: 35915 RVA: 0x002A7A3C File Offset: 0x002A5C3C
	private int SortFriendly(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		RoleFavorData favorData = roleDataBase.GetFavorData();
		RoleFavorData favorData2 = roleDataBase2.GetFavorData();
		if (favorData == null || favorData2 == null)
		{
			return 0;
		}
		int favorLevel = favorData.GetFavorLevel();
		int favorLevel2 = favorData2.GetFavorLevel();
		if (favorLevel != favorLevel2)
		{
			return (favorLevel2 - favorLevel) * (isAscending ? -1 : 1);
		}
		int favorExp = favorData.GetFavorExp();
		int favorExp2 = favorData2.GetFavorExp();
		if (favorExp != favorExp2)
		{
			return (favorExp2 - favorExp) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C4C RID: 35916 RVA: 0x002A7AB4 File Offset: 0x002A5CB4
	private int SortCreateTime(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int roleCreateTime = roleDataBase.GetRoleCreateTime();
		int roleCreateTime2 = roleDataBase2.GetRoleCreateTime();
		if (roleCreateTime != roleCreateTime2)
		{
			return (roleCreateTime2 - roleCreateTime) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C4D RID: 35917 RVA: 0x002A7AEC File Offset: 0x002A5CEC
	private int SortLifeLimit(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int attrValueById = roleDataBase.GetAttributeData().GetAttrValueById(2);
		int attrValueById2 = roleDataBase2.GetAttributeData().GetAttrValueById(2);
		if (attrValueById != attrValueById2)
		{
			return (attrValueById2 - attrValueById) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C4E RID: 35918 RVA: 0x002A7B30 File Offset: 0x002A5D30
	private int SortAttack(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int attrValueById = roleDataBase.GetAttributeData().GetAttrValueById(7);
		int attrValueById2 = roleDataBase2.GetAttributeData().GetAttrValueById(7);
		if (attrValueById != attrValueById2)
		{
			return (attrValueById2 - attrValueById) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C4F RID: 35919 RVA: 0x002A7B74 File Offset: 0x002A5D74
	private int SortWeeklyRogueRecommend(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		bool flag = WeeklyRogueModel.Instance.CheckIsRecommendRole(roleDataBase.GetRoleId());
		bool flag2 = WeeklyRogueModel.Instance.CheckIsRecommendRole(roleDataBase2.GetRoleId());
		if (flag == flag2)
		{
			return 0;
		}
		if (!flag)
		{
			return 1;
		}
		return -1;
	}

	// Token: 0x06008C50 RID: 35920 RVA: 0x002A7BC0 File Offset: 0x002A5DC0
	private int SortDefense(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int attrValueById = roleDataBase.GetAttributeData().GetAttrValueById(10);
		int attrValueById2 = roleDataBase2.GetAttributeData().GetAttrValueById(10);
		if (attrValueById != attrValueById2)
		{
			return (attrValueById2 - attrValueById) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C51 RID: 35921 RVA: 0x002A7C08 File Offset: 0x002A5E08
	private int SortRoleSelectPosition(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleSelectModel instance = RoleSelectModel.Instance;
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int dataId = roleDataBase.GetDataId();
		int dataId2 = roleDataBase2.GetDataId();
		int roleIndex = instance.GetRoleIndex(dataId);
		int roleIndex2 = instance.GetRoleIndex(dataId2);
		if (roleIndex <= 0 || roleIndex2 <= 0)
		{
			int num = (roleIndex > 0) ? 1 : 0;
			return ((roleIndex2 > 0) ? 1 : 0) - num;
		}
		if (roleIndex != roleIndex2)
		{
			return roleIndex - roleIndex2;
		}
		return 0;
	}

	// Token: 0x06008C52 RID: 35922 RVA: 0x002A7C68 File Offset: 0x002A5E68
	private int SortTrialRole(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		bool flag = roleDataBase.IsTrialRole();
		bool flag2 = roleDataBase2.IsTrialRole();
		if (flag != flag2)
		{
			int num = (flag > false) ? 1 : 0;
			return (((flag2 > false) ? 1 : 0) - num) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C53 RID: 35923 RVA: 0x002A7CA8 File Offset: 0x002A5EA8
	private int SortRecommendRole(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		if (InstanceDungeonEntranceModel.Instance.SelectInstanceId != 0)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(InstanceDungeonEntranceModel.Instance.SelectInstanceId);
			int[] array = config.Value.RecommendRoleBottom();
			int[] array2 = config.Value.RecommendRole();
			int[] array3 = new int[array.Length + array2.Length];
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				array3[num++] = array[i];
			}
			for (int j = 0; j < array2.Length; j++)
			{
				array3[num++] = array2[j];
			}
			int roleId = roleDataBase.GetRoleId();
			int roleId2 = roleDataBase2.GetRoleId();
			int num2 = (this.Contains(array3, roleId) > false) ? 1 : 0;
			int num3 = (this.Contains(array3, roleId2) > false) ? 1 : 0;
			if (num2 != num3)
			{
				return (num3 - num2) * (isAscending ? -1 : 1);
			}
		}
		return 0;
	}

	// Token: 0x06008C54 RID: 35924 RVA: 0x002A7DA4 File Offset: 0x002A5FA4
	private int SortRoguelikeDefault(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleInstance roleInstance = a as RoleInstance;
		RoleInstance roleInstance2 = b as RoleInstance;
		bool flag = RoguelikeModel.Instance.SelectRoleViewShowRoleList.Contains(roleInstance.GetRoleId()) && roleInstance.GetLevelData().GetLevel() != 0;
		bool flag2 = RoguelikeModel.Instance.SelectRoleViewShowRoleList.Contains(roleInstance2.GetRoleId()) && roleInstance2.GetLevelData().GetLevel() != 0;
		if (flag != flag2)
		{
			if (!flag)
			{
				return 1;
			}
			return -1;
		}
		else
		{
			bool flag3 = RoguelikeModel.Instance.SelectRoleViewRecommendRoleList.Contains(roleInstance.GetRoleId());
			bool flag4 = RoguelikeModel.Instance.SelectRoleViewRecommendRoleList.Contains(roleInstance2.GetRoleId());
			if (flag3 != flag4)
			{
				if (!flag3)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				int level = roleInstance.GetLevelData().GetLevel();
				int level2 = roleInstance2.GetLevelData().GetLevel();
				if (level != level2)
				{
					if (level <= level2)
					{
						return 1;
					}
					return -1;
				}
				else
				{
					int qualityId = roleInstance.GetRoleConfig().QualityId;
					int qualityId2 = roleInstance2.GetRoleConfig().QualityId;
					if (qualityId != qualityId2)
					{
						if (qualityId <= qualityId2)
						{
							return 1;
						}
						return -1;
					}
					else
					{
						int roleId = roleInstance.GetRoleId();
						int roleId2 = roleInstance2.GetRoleId();
						if (roleId > roleId2)
						{
							return -1;
						}
						if (roleId < roleId2)
						{
							return 1;
						}
						return 0;
					}
				}
			}
		}
	}

	// Token: 0x06008C55 RID: 35925 RVA: 0x002A7ED8 File Offset: 0x002A60D8
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(ERoleSortWayType.Level, new TSortResult(this.SortLevel));
		this.SortMap.Add(ERoleSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(ERoleSortWayType.Formation, new TSortResult(this.SortFormation));
		this.SortMap.Add(ERoleSortWayType.Priority, new TSortResult(this.SortPriority));
		this.SortMap.Add(ERoleSortWayType.Resonance, new TSortResult(this.SortResonance));
		this.SortMap.Add(ERoleSortWayType.ResonanceIncreased, new TSortResult(this.SortResonanceIncreased));
		this.SortMap.Add(ERoleSortWayType.InCollected, new TSortResult(this.SortInCollected));
		this.SortMap.Add(ERoleSortWayType.Friendly, new TSortResult(this.SortFriendly));
		this.SortMap.Add(ERoleSortWayType.CreateTime, new TSortResult(this.SortCreateTime));
		this.SortMap.Add(ERoleSortWayType.LifeLimit, new TSortResult(this.SortLifeLimit));
		this.SortMap.Add(ERoleSortWayType.Attack, new TSortResult(this.SortAttack));
		this.SortMap.Add(ERoleSortWayType.Defense, new TSortResult(this.SortDefense));
		this.SortMap.Add(ERoleSortWayType.EditBattleTeamPosition, new TSortResult(this.SortRoleSelectPosition));
		this.SortMap.Add(ERoleSortWayType.EditFormationPosition, new TSortResult(this.SortRoleSelectPosition));
		this.SortMap.Add(ERoleSortWayType.IsTrailRole, new TSortResult(this.SortTrialRole));
		this.SortMap.Add(ERoleSortWayType.TowerCost, new TSortResult(this.SortTowerCost));
		this.SortMap.Add(ERoleSortWayType.RoguelikeDefault, new TSortResult(this.SortRoguelikeDefault));
		this.SortMap.Add(ERoleSortWayType.WeeklyRogueRecommend, new TSortResult(this.SortWeeklyRogueRecommend));
		this.SortMap.Add(ERoleSortWayType.IsRecommend, new TSortResult(this.SortRecommendRole));
	}

	// Token: 0x06008C56 RID: 35926 RVA: 0x002A80B8 File Offset: 0x002A62B8
	private int SortTowerCost(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		RoleDataBase roleDataBase = a as RoleDataBase;
		RoleDataBase roleDataBase2 = b as RoleDataBase;
		int currentSelectDifficulties = TowerModel.Instance.CurrentSelectDifficulties;
		int roleRemainCost = TowerModel.Instance.GetRoleRemainCost(roleDataBase.GetRoleId(), currentSelectDifficulties);
		int roleRemainCost2 = TowerModel.Instance.GetRoleRemainCost(roleDataBase2.GetRoleId(), currentSelectDifficulties);
		return (roleRemainCost - roleRemainCost2) * (isAscending ? -1 : 1);
	}

	// Token: 0x06008C57 RID: 35927 RVA: 0x002A810C File Offset: 0x002A630C
	private bool Contains(int[] array, int value)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == value)
			{
				return true;
			}
		}
		return false;
	}
}
