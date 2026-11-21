using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CE9 RID: 3305
[NullableContext(1)]
[Nullable(0)]
public class FilterSortEntrance<[Nullable(2)] T> : UiPanelBase
{
	// Token: 0x06008972 RID: 35186 RVA: 0x0029A407 File Offset: 0x00298607
	public FilterSortEntrance(UUIItem uiItem, TUpdateDataListFunction<T> updateList)
	{
		this.UpdateList = updateList;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008973 RID: 35187 RVA: 0x0029A424 File Offset: 0x00298624
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008974 RID: 35188 RVA: 0x0029A48D File Offset: 0x0029868D
	protected override void OnStart()
	{
		this.FilterEntrance = new FilterEntrance<T>(base.GetItem(0), this.UpdateList);
		this.SortEntrance = new SortEntrance<T>(base.GetItem(1), this.UpdateList);
	}

	// Token: 0x06008975 RID: 35189 RVA: 0x0029A4C0 File Offset: 0x002986C0
	public void UpdateData(EFilterSortGroupId groupId, List<T> dataList, params object[] parameters)
	{
		this.FilterEntrance.UpdateData(groupId, dataList, parameters);
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(groupId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(groupId, dataList, parameters);
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(groupId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x06008976 RID: 35190 RVA: 0x0029A51C File Offset: 0x0029871C
	public void UpdateDataWithConfig(EFilterSortGroupId groupId, EFilterSortConfigId saveConfigId, List<T> dataList)
	{
		this.FilterEntrance.UpdateDataWithConfig(groupId, saveConfigId, dataList, "", Array.Empty<object>());
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(groupId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateDataWithConfig(groupId, saveConfigId, dataList, "", Array.Empty<object>());
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(groupId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x06008977 RID: 35191 RVA: 0x0029A58C File Offset: 0x0029878C
	public void ClearData(EFilterSortGroupId groupId)
	{
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(groupId);
		FilterModel.Instance.ClearData(uniqueIdByGroupId);
		this.SortEntrance.DeleteUniqueIdByGroupId(groupId);
	}

	// Token: 0x06008978 RID: 35192 RVA: 0x0029A5BD File Offset: 0x002987BD
	[NullableContext(2)]
	public UUIItem GetFilterToggleItem()
	{
		FilterEntrance<T> filterEntrance = this.FilterEntrance;
		if (filterEntrance == null)
		{
			return null;
		}
		return filterEntrance.GetFilterToggleItem();
	}

	// Token: 0x06008979 RID: 35193 RVA: 0x0029A5D0 File Offset: 0x002987D0
	protected override void OnBeforeDestroy()
	{
		SortEntrance<T> sortEntrance = this.SortEntrance;
		if (sortEntrance != null)
		{
			sortEntrance.Destroy(null);
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x040052FC RID: 21244
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<T> FilterEntrance;

	// Token: 0x040052FD RID: 21245
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<T> SortEntrance;

	// Token: 0x040052FE RID: 21246
	protected TUpdateDataListFunction<T> UpdateList;

	// Token: 0x02006F99 RID: 28569
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402474F RID: 149327
		FilterItem,
		// Token: 0x04024750 RID: 149328
		SortItem
	}
}
