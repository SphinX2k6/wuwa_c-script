using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D3D RID: 3389
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginItemSort : CommonSort<DangoAbyssPluginItemSort.EComposeExchangeSortWayType>
{
	// Token: 0x06008BD3 RID: 35795 RVA: 0x002A48A0 File Offset: 0x002A2AA0
	private int SortCurrentRoleFirst(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		int num = (param != null && param.Length != 0 && param[0] is int) ? ((int)param[0]) : 0;
		AbyssPluginItemInfo abyssPluginItemInfo = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo2 = b as AbyssPluginItemInfo;
		int num2 = (abyssPluginItemInfo.GetRoleId() == num) ? -1 : 1;
		int num3 = (abyssPluginItemInfo2.GetRoleId() == num) ? -1 : 1;
		return num2 - num3;
	}

	// Token: 0x06008BD4 RID: 35796 RVA: 0x002A48F8 File Offset: 0x002A2AF8
	private int SortOtherRoleLast(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		int num = (param != null && param.Length != 0 && param[0] is int) ? ((int)param[0]) : 0;
		AbyssPluginItemInfo abyssPluginItemInfo = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo2 = b as AbyssPluginItemInfo;
		int num2 = (abyssPluginItemInfo.GetRoleId() != num) ? 1 : -1;
		int num3 = (abyssPluginItemInfo2.GetRoleId() != num) ? 1 : -1;
		return num2 - num3;
	}

	// Token: 0x06008BD5 RID: 35797 RVA: 0x002A4950 File Offset: 0x002A2B50
	private int SortRoleId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AbyssPluginItemInfo abyssPluginItemInfo = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo2 = b as AbyssPluginItemInfo;
		int num = abyssPluginItemInfo.GetRoleId() - abyssPluginItemInfo2.GetRoleId();
		if (!isAscending)
		{
			return -num;
		}
		return num;
	}

	// Token: 0x06008BD6 RID: 35798 RVA: 0x002A4980 File Offset: 0x002A2B80
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo = b as AbyssPluginItemInfo;
		int num = itemDataBase.GetQuality() - abyssPluginItemInfo.GetQuality();
		if (!isAscending)
		{
			return -num;
		}
		return num;
	}

	// Token: 0x06008BD7 RID: 35799 RVA: 0x002A49B0 File Offset: 0x002A2BB0
	private int SortItemId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AbyssPluginItemInfo abyssPluginItemInfo = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo2 = b as AbyssPluginItemInfo;
		int num = abyssPluginItemInfo.GetItemId() - abyssPluginItemInfo2.GetItemId();
		if (!isAscending)
		{
			return -num;
		}
		return num;
	}

	// Token: 0x06008BD8 RID: 35800 RVA: 0x002A49E0 File Offset: 0x002A2BE0
	private int SortLockLast(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo = b as AbyssPluginItemInfo;
		int num = itemDataBase.GetIsLock() ? 1 : -1;
		int num2 = abyssPluginItemInfo.GetIsLock() ? 1 : -1;
		return num - num2;
	}

	// Token: 0x06008BD9 RID: 35801 RVA: 0x002A4A14 File Offset: 0x002A2C14
	private int SortDeprecateFirst(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo = b as AbyssPluginItemInfo;
		int num = itemDataBase.GetIsDeprecated() ? -1 : 1;
		int num2 = abyssPluginItemInfo.GetIsDeprecated() ? -1 : 1;
		return num - num2;
	}

	// Token: 0x06008BDA RID: 35802 RVA: 0x002A4A48 File Offset: 0x002A2C48
	private int SortValidFirst(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		int roleId = (param != null && param.Length != 0 && param[0] is int) ? ((int)param[0]) : 0;
		AbyssPluginItemInfo item = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo item2 = b as AbyssPluginItemInfo;
		int num = DangoAbyssModel.Instance.IsPluginHasValidTag(roleId, item) ? -1 : 1;
		int num2 = DangoAbyssModel.Instance.IsPluginHasValidTag(roleId, item2) ? -1 : 1;
		return num - num2;
	}

	// Token: 0x06008BDB RID: 35803 RVA: 0x002A4AAC File Offset: 0x002A2CAC
	private int SortEquipLast(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AbyssPluginItemInfo abyssPluginItemInfo = a as AbyssPluginItemInfo;
		AbyssPluginItemInfo abyssPluginItemInfo2 = b as AbyssPluginItemInfo;
		return abyssPluginItemInfo.GetRoleId() - abyssPluginItemInfo2.GetRoleId();
	}

	// Token: 0x06008BDC RID: 35804 RVA: 0x002A4AD4 File Offset: 0x002A2CD4
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.CurrentRoleFirst, new TSortResult(this.SortCurrentRoleFirst));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.OtherRoleLast, new TSortResult(this.SortOtherRoleLast));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.RoleId, new TSortResult(this.SortRoleId));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.ItemId, new TSortResult(this.SortItemId));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.LockLast, new TSortResult(this.SortLockLast));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.DeprecateFirst, new TSortResult(this.SortDeprecateFirst));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.ValidFirst, new TSortResult(this.SortValidFirst));
		this.SortMap.Add(DangoAbyssPluginItemSort.EComposeExchangeSortWayType.EquipLast, new TSortResult(this.SortEquipLast));
	}

	// Token: 0x02006FBD RID: 28605
	[NullableContext(0)]
	public enum EComposeExchangeSortWayType
	{
		// Token: 0x04024812 RID: 149522
		CurrentRoleFirst = 1,
		// Token: 0x04024813 RID: 149523
		OtherRoleLast,
		// Token: 0x04024814 RID: 149524
		RoleId,
		// Token: 0x04024815 RID: 149525
		Quality,
		// Token: 0x04024816 RID: 149526
		ItemId,
		// Token: 0x04024817 RID: 149527
		LockLast,
		// Token: 0x04024818 RID: 149528
		DeprecateFirst,
		// Token: 0x04024819 RID: 149529
		ValidFirst,
		// Token: 0x0402481A RID: 149530
		EquipLast
	}
}
