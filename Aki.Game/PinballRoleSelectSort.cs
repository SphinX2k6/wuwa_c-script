using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D4A RID: 3402
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectSort : CommonSort<EPinballRoleSelectSortWayType>
{
	// Token: 0x06008C34 RID: 35892 RVA: 0x002A7340 File Offset: 0x002A5540
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

	// Token: 0x06008C35 RID: 35893 RVA: 0x002A7384 File Offset: 0x002A5584
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

	// Token: 0x06008C36 RID: 35894 RVA: 0x002A73C8 File Offset: 0x002A55C8
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

	// Token: 0x06008C37 RID: 35895 RVA: 0x002A7408 File Offset: 0x002A5608
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

	// Token: 0x06008C38 RID: 35896 RVA: 0x002A745C File Offset: 0x002A565C
	protected override void OnInitSortMap()
	{
		this.SortMap[EPinballRoleSelectSortWayType.Id] = new TSortResult(this.SortId);
		this.SortMap[EPinballRoleSelectSortWayType.Level] = new TSortResult(this.SortLevel);
		this.SortMap[EPinballRoleSelectSortWayType.LockState] = new TSortResult(this.SortLockState);
		this.SortMap[EPinballRoleSelectSortWayType.FormationFirst] = new TSortResult(this.SortFormationFirst);
	}
}
