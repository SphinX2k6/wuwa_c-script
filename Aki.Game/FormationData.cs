using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020010B2 RID: 4274
[NullableContext(1)]
[Nullable(0)]
public class FormationData
{
	// Token: 0x0600A946 RID: 43334 RVA: 0x0031C90D File Offset: 0x0031AB0D
	public FormationData(int formationId)
	{
		this.FormationId = formationId;
	}

	// Token: 0x0600A947 RID: 43335 RVA: 0x0031C940 File Offset: 0x0031AB40
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

	// Token: 0x0600A948 RID: 43336 RVA: 0x0031C990 File Offset: 0x0031AB90
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

	// Token: 0x0600A949 RID: 43337 RVA: 0x0031C9F8 File Offset: 0x0031ABF8
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

	// Token: 0x170011BA RID: 4538
	// (get) Token: 0x0600A94A RID: 43338 RVA: 0x0031CA6C File Offset: 0x0031AC6C
	public List<int> RoleIdList
	{
		get
		{
			return this.RoleIds;
		}
	}

	// Token: 0x0600A94B RID: 43339 RVA: 0x0031CA74 File Offset: 0x0031AC74
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

	// Token: 0x0600A94C RID: 43340 RVA: 0x0031CAD8 File Offset: 0x0031ACD8
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

	// Token: 0x0600A94D RID: 43341 RVA: 0x0031CAF8 File Offset: 0x0031ACF8
	public Dictionary<int, FormationRoleData> GetRoleDataMap()
	{
		return this.RoleDataMap;
	}

	// Token: 0x0600A94E RID: 43342 RVA: 0x0031CB00 File Offset: 0x0031AD00
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

	// Token: 0x170011BB RID: 4539
	// (get) Token: 0x0600A94F RID: 43343 RVA: 0x0031CB84 File Offset: 0x0031AD84
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

	// Token: 0x170011BC RID: 4540
	// (get) Token: 0x0600A950 RID: 43344 RVA: 0x0031CBBC File Offset: 0x0031ADBC
	public int CurrentRolePosition
	{
		get
		{
			return this.CurrentPosition;
		}
	}

	// Token: 0x0400627D RID: 25213
	public int FormationId;

	// Token: 0x0400627E RID: 25214
	public string Name = string.Empty;

	// Token: 0x0400627F RID: 25215
	private readonly List<int> RoleIds = new List<int>();

	// Token: 0x04006280 RID: 25216
	private readonly Dictionary<int, FormationRoleData> RoleDataMap = new Dictionary<int, FormationRoleData>();

	// Token: 0x04006281 RID: 25217
	private int CurrentPosition;
}
