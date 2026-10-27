using System;
using System.Runtime.CompilerServices;

// Token: 0x02001891 RID: 6289
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectSort : CommonSort<EPinballRoleSelectSortWayType>
{
	// Token: 0x0600B84B RID: 47179 RVA: 0x0029CC28 File Offset: 0x0029AE28
	private int SortId(object a, object b, bool isAscending, params object[] parameters)
	{
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData = (IPinballRoleSelectGridItemData)a;
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData2 = (IPinballRoleSelectGridItemData)b;
		int id = pinballRoleSelectGridItemData.RoleData.GetId();
		int id2 = pinballRoleSelectGridItemData2.RoleData.GetId();
		if (id != id2)
		{
			return (id - id2) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x0600B84C RID: 47180 RVA: 0x0029CC6C File Offset: 0x0029AE6C
	private int SortLevel(object a, object b, bool isAscending, params object[] parameters)
	{
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData = (IPinballRoleSelectGridItemData)a;
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData2 = (IPinballRoleSelectGridItemData)b;
		int level = pinballRoleSelectGridItemData.RoleData.GetLevel();
		int level2 = pinballRoleSelectGridItemData2.RoleData.GetLevel();
		if (level != level2)
		{
			return (level2 - level) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x0600B84D RID: 47181 RVA: 0x0029CCB0 File Offset: 0x0029AEB0
	private int SortLockState(object a, object b, bool isAscending, params object[] parameters)
	{
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData = (IPinballRoleSelectGridItemData)a;
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData2 = (IPinballRoleSelectGridItemData)b;
		bool flag = pinballRoleSelectGridItemData.RoleData.IsLocked();
		bool flag2 = pinballRoleSelectGridItemData2.RoleData.IsLocked();
		if (flag == flag2)
		{
			return 0;
		}
		if (!flag)
		{
			return -1;
		}
		return 1;
	}

	// Token: 0x0600B84E RID: 47182 RVA: 0x0029CCF0 File Offset: 0x0029AEF0
	private int SortFormationFirst(object a, object b, bool isAscending, params object[] parameters)
	{
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData = (IPinballRoleSelectGridItemData)a;
		IPinballRoleSelectGridItemData pinballRoleSelectGridItemData2 = (IPinballRoleSelectGridItemData)b;
		bool flag = pinballRoleSelectGridItemData.FormationIndex >= 0;
		bool flag2 = pinballRoleSelectGridItemData2.FormationIndex >= 0;
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
			if (flag && flag2)
			{
				return pinballRoleSelectGridItemData.FormationIndex - pinballRoleSelectGridItemData2.FormationIndex;
			}
			return 0;
		}
	}

	// Token: 0x0600B84F RID: 47183 RVA: 0x0029CD44 File Offset: 0x0029AF44
	protected override void OnInitSortMap()
	{
		this.SortMap[EPinballRoleSelectSortWayType.Id] = new TSortResult(this.SortId);
		this.SortMap[EPinballRoleSelectSortWayType.Level] = new TSortResult(this.SortLevel);
		this.SortMap[EPinballRoleSelectSortWayType.LockState] = new TSortResult(this.SortLockState);
		this.SortMap[EPinballRoleSelectSortWayType.FormationFirst] = new TSortResult(this.SortFormationFirst);
	}
}
