using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001897 RID: 6295
[NullableContext(1)]
[Nullable(0)]
public class RoleSort : CommonSort<ERoleSortWayType>
{
	// Token: 0x0600B85B RID: 47195 RVA: 0x0029D0D8 File Offset: 0x0029B2D8
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

	// Token: 0x0600B85C RID: 47196 RVA: 0x0029D148 File Offset: 0x0029B348
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

	// Token: 0x0600B85D RID: 47197 RVA: 0x0029D190 File Offset: 0x0029B390
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

	// Token: 0x0600B85E RID: 47198 RVA: 0x0029D238 File Offset: 0x0029B438
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

	// Token: 0x0600B85F RID: 47199 RVA: 0x0029D298 File Offset: 0x0029B498
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

	// Token: 0x0600B860 RID: 47200 RVA: 0x0029D2DC File Offset: 0x0029B4DC
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

	// Token: 0x0600B861 RID: 47201 RVA: 0x0029D31E File Offset: 0x0029B51E
	private int SortInCollected(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		return 0;
	}

	// Token: 0x0600B862 RID: 47202 RVA: 0x0029D324 File Offset: 0x0029B524
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

	// Token: 0x0600B863 RID: 47203 RVA: 0x0029D39C File Offset: 0x0029B59C
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

	// Token: 0x0600B864 RID: 47204 RVA: 0x0029D3D4 File Offset: 0x0029B5D4
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

	// Token: 0x0600B865 RID: 47205 RVA: 0x0029D418 File Offset: 0x0029B618
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

	// Token: 0x0600B866 RID: 47206 RVA: 0x0029D45C File Offset: 0x0029B65C
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

	// Token: 0x0600B867 RID: 47207 RVA: 0x0029D4A8 File Offset: 0x0029B6A8
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

	// Token: 0x0600B868 RID: 47208 RVA: 0x0029D4F0 File Offset: 0x0029B6F0
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

	// Token: 0x0600B869 RID: 47209 RVA: 0x0029D550 File Offset: 0x0029B750
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

	// Token: 0x0600B86A RID: 47210 RVA: 0x0029D590 File Offset: 0x0029B790
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

	// Token: 0x0600B86B RID: 47211 RVA: 0x0029D68C File Offset: 0x0029B88C
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

	// Token: 0x0600B86C RID: 47212 RVA: 0x0029D7C0 File Offset: 0x0029B9C0
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

	// Token: 0x0600B86D RID: 47213 RVA: 0x0029D9A0 File Offset: 0x0029BBA0
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

	// Token: 0x0600B86E RID: 47214 RVA: 0x0029D9F4 File Offset: 0x0029BBF4
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
