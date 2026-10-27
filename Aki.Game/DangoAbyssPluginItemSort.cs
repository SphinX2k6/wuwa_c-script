using System;
using System.Runtime.CompilerServices;

// Token: 0x02001884 RID: 6276
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginItemSort : CommonSort<DangoAbyssPluginItemSort.EComposeExchangeSortWayType>
{
	// Token: 0x0600B7EA RID: 47082 RVA: 0x0029A188 File Offset: 0x00298388
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

	// Token: 0x0600B7EB RID: 47083 RVA: 0x0029A1E0 File Offset: 0x002983E0
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

	// Token: 0x0600B7EC RID: 47084 RVA: 0x0029A238 File Offset: 0x00298438
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

	// Token: 0x0600B7ED RID: 47085 RVA: 0x0029A268 File Offset: 0x00298468
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

	// Token: 0x0600B7EE RID: 47086 RVA: 0x0029A298 File Offset: 0x00298498
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

	// Token: 0x0600B7EF RID: 47087 RVA: 0x0029A2C8 File Offset: 0x002984C8
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

	// Token: 0x0600B7F0 RID: 47088 RVA: 0x0029A2FC File Offset: 0x002984FC
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

	// Token: 0x0600B7F1 RID: 47089 RVA: 0x0029A330 File Offset: 0x00298530
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

	// Token: 0x0600B7F2 RID: 47090 RVA: 0x0029A394 File Offset: 0x00298594
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

	// Token: 0x0600B7F3 RID: 47091 RVA: 0x0029A3BC File Offset: 0x002985BC
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

	// Token: 0x02007E36 RID: 32310
	[NullableContext(0)]
	public enum EComposeExchangeSortWayType
	{
		// Token: 0x040294E5 RID: 169189
		CurrentRoleFirst = 1,
		// Token: 0x040294E6 RID: 169190
		OtherRoleLast,
		// Token: 0x040294E7 RID: 169191
		RoleId,
		// Token: 0x040294E8 RID: 169192
		Quality,
		// Token: 0x040294E9 RID: 169193
		ItemId,
		// Token: 0x040294EA RID: 169194
		LockLast,
		// Token: 0x040294EB RID: 169195
		DeprecateFirst,
		// Token: 0x040294EC RID: 169196
		ValidFirst,
		// Token: 0x040294ED RID: 169197
		EquipLast
	}
}
