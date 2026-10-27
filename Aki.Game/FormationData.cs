using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001BF3 RID: 7155
[NullableContext(1)]
[Nullable(0)]
public class FormationData
{
	// Token: 0x0600D533 RID: 54579 RVA: 0x003116C9 File Offset: 0x0030F8C9
	public FormationData(int formationId)
	{
		this.FormationId = formationId;
	}

	// Token: 0x0600D534 RID: 54580 RVA: 0x003116FC File Offset: 0x0030F8FC
	[NullableContext(2)]
	public void AddRoleData(int roleId, int skinId, int level, int playerId, bool isCurrent = false, int multiSkillBranchIndex = 0, FormationRoleEquip equip = null)
	{
		int num = this.RoleIds.Count + 1;
		this.RoleIds.Add(roleId);
		this.RoleDataMap[num] = new FormationRoleData(num, roleId, skinId, level, playerId, multiSkillBranchIndex, equip);
		if (isCurrent)
		{
			this.CurrentPosition = num;
		}
	}

	// Token: 0x0600D535 RID: 54581 RVA: 0x0031174C File Offset: 0x0030F94C
	public void SetCurrentRole(int roleId)
	{
		foreach (FormationRoleData formationRoleData in this.RoleDataMap.Values)
		{
			if (formationRoleData.ConfigId == roleId)
			{
				this.CurrentPosition = formationRoleData.Position;
				break;
			}
		}
	}

	// Token: 0x0600D536 RID: 54582 RVA: 0x003117B4 File Offset: 0x0030F9B4
	public List<int> GetRoleIdListWithTrial(bool includeTrial)
	{
		if (includeTrial)
		{
			return new List<int>(this.RoleIds);
		}
		List<int> list = new List<int>();
		foreach (int num in this.RoleIds)
		{
			if (!RoleUtils.IsTrialRole(num))
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x17001195 RID: 4501
	// (get) Token: 0x0600D537 RID: 54583 RVA: 0x00311828 File Offset: 0x0030FA28
	public List<int> RoleIdList
	{
		get
		{
			return this.RoleIds;
		}
	}

	// Token: 0x0600D538 RID: 54584 RVA: 0x00311830 File Offset: 0x0030FA30
	[NullableContext(2)]
	public FormationRoleData GetRoleDataById(int roleId)
	{
		foreach (FormationRoleData formationRoleData in this.RoleDataMap.Values)
		{
			if (formationRoleData.ConfigId == roleId)
			{
				return formationRoleData;
			}
		}
		return null;
	}

	// Token: 0x0600D539 RID: 54585 RVA: 0x00311894 File Offset: 0x0030FA94
	[NullableContext(2)]
	public FormationRoleData GetRoleDataByPosition(int position)
	{
		FormationRoleData result;
		if (this.RoleDataMap.TryGetValue(position, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600D53A RID: 54586 RVA: 0x003118B4 File Offset: 0x0030FAB4
	public Dictionary<int, FormationRoleData> GetRoleDataMap()
	{
		return this.RoleDataMap;
	}

	// Token: 0x0600D53B RID: 54587 RVA: 0x003118BC File Offset: 0x0030FABC
	public Dictionary<int, FormationRoleData> GetRoleDataMapWithTrial(bool includeTrial)
	{
		if (includeTrial)
		{
			return this.RoleDataMap;
		}
		Dictionary<int, FormationRoleData> dictionary = new Dictionary<int, FormationRoleData>();
		foreach (KeyValuePair<int, FormationRoleData> keyValuePair in this.RoleDataMap)
		{
			if (!RoleUtils.IsTrialRole(keyValuePair.Value.ConfigId))
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		return dictionary;
	}

	// Token: 0x17001196 RID: 4502
	// (get) Token: 0x0600D53C RID: 54588 RVA: 0x00311940 File Offset: 0x0030FB40
	public int? CurrentRoleConfigId
	{
		get
		{
			if (this.CurrentPosition <= 0)
			{
				return null;
			}
			return new int?(this.RoleIds[this.CurrentPosition - 1]);
		}
	}

	// Token: 0x17001197 RID: 4503
	// (get) Token: 0x0600D53D RID: 54589 RVA: 0x00311978 File Offset: 0x0030FB78
	public int CurrentRolePosition
	{
		get
		{
			return this.CurrentPosition;
		}
	}

	// Token: 0x040061AB RID: 25003
	public int FormationId;

	// Token: 0x040061AC RID: 25004
	public string Name = string.Empty;

	// Token: 0x040061AD RID: 25005
	private readonly List<int> RoleIds = new List<int>();

	// Token: 0x040061AE RID: 25006
	private readonly Dictionary<int, FormationRoleData> RoleDataMap = new Dictionary<int, FormationRoleData>();

	// Token: 0x040061AF RID: 25007
	private int CurrentPosition;
}
