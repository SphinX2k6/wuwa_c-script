using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001830 RID: 6192
[NullableContext(1)]
[Nullable(0)]
public class FilterSortEntrance<[Nullable(2)] T> : UiPanelBase
{
	// Token: 0x0600B587 RID: 46471 RVA: 0x0028FCE7 File Offset: 0x0028DEE7
	public FilterSortEntrance(UUIItem uiItem, TUpdateDataListFunction<T> updateList)
	{
		this.UpdateList = updateList;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B588 RID: 46472 RVA: 0x0028FD04 File Offset: 0x0028DF04
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

	// Token: 0x0600B589 RID: 46473 RVA: 0x0028FD6D File Offset: 0x0028DF6D
	protected override void OnStart()
	{
		this.FilterEntrance = new FilterEntrance<T>(base.GetItem(0), this.UpdateList);
		this.SortEntrance = new SortEntrance<T>(base.GetItem(1), this.UpdateList);
	}

	// Token: 0x0600B58A RID: 46474 RVA: 0x0028FDA0 File Offset: 0x0028DFA0
	public void UpdateData(EFilterSortGroupId groupId, List<T> dataList, params object[] parameters)
	{
		this.FilterEntrance.UpdateData(groupId, dataList, parameters);
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(groupId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(groupId, dataList, parameters);
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(groupId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x0600B58B RID: 46475 RVA: 0x0028FDFC File Offset: 0x0028DFFC
	public void UpdateDataWithConfig(EFilterSortGroupId groupId, EFilterSortConfigId saveConfigId, List<T> dataList)
	{
		this.FilterEntrance.UpdateDataWithConfig(groupId, saveConfigId, dataList, "", Array.Empty<object>());
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(groupId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateDataWithConfig(groupId, saveConfigId, dataList, "", Array.Empty<object>());
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(groupId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x0600B58C RID: 46476 RVA: 0x0028FE6C File Offset: 0x0028E06C
	public void ClearData(EFilterSortGroupId groupId)
	{
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(groupId);
		FilterModel.Instance.ClearData(uniqueIdByGroupId);
		this.SortEntrance.DeleteUniqueIdByGroupId(groupId);
	}

	// Token: 0x0600B58D RID: 46477 RVA: 0x0028FE9D File Offset: 0x0028E09D
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

	// Token: 0x0600B58E RID: 46478 RVA: 0x0028FEB0 File Offset: 0x0028E0B0
	protected override void OnBeforeDestroy()
	{
		SortEntrance<T> sortEntrance = this.SortEntrance;
		if (sortEntrance != null)
		{
			sortEntrance.Destroy(null);
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x04005251 RID: 21073
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<T> FilterEntrance;

	// Token: 0x04005252 RID: 21074
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<T> SortEntrance;

	// Token: 0x04005253 RID: 21075
	protected TUpdateDataListFunction<T> UpdateList;

	// Token: 0x02007E13 RID: 32275
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04029424 RID: 168996
		FilterItem,
		// Token: 0x04029425 RID: 168997
		SortItem
	}
}
