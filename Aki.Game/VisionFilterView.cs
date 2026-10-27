using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.InputView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001870 RID: 6256
[NullableContext(1)]
[Nullable(0)]
public class VisionFilterView : UiViewBase
{
	// Token: 0x0600B7A3 RID: 47011 RVA: 0x00298B12 File Offset: 0x00296D12
	public VisionFilterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B7A4 RID: 47012 RVA: 0x00298B28 File Offset: 0x00296D28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ResetView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.SaveDataAndCloseView));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B7A5 RID: 47013 RVA: 0x00298C54 File Offset: 0x00296E54
	private void OnClickClearSearchButton()
	{
		this.CurrentSearchingText = "";
		this.ShowViewBySearchState(false);
		foreach (FilterGroup filterGroup in this.Scroll.GetScrollItemList())
		{
			filterGroup.SetSelectedDataMap(this.TempFilterDataMap);
			filterGroup.InitFilterSetData();
			filterGroup.RefreshGroupItem();
			filterGroup.RefreshSelectAllToggleState();
		}
	}

	// Token: 0x0600B7A6 RID: 47014 RVA: 0x00298CD4 File Offset: 0x00296ED4
	private void OnClickSearchButton(string content)
	{
		this.CurrentSearchingText = content;
		this.TempFilterDataMap.Clear();
		this.RefreshView();
	}

	// Token: 0x0600B7A7 RID: 47015 RVA: 0x00298CF0 File Offset: 0x00296EF0
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as FilterViewData);
		this.InitScroller();
		this.SearchComponent = new CommonSearchComponent(base.GetItem(4), new Action<string>(this.SearchResult), new Action(this.ResetSearch));
	}

	// Token: 0x0600B7A8 RID: 47016 RVA: 0x00298D3E File Offset: 0x00296F3E
	private void SearchResult(string content)
	{
		this.OnClickSearchButton(content);
	}

	// Token: 0x0600B7A9 RID: 47017 RVA: 0x00298D47 File Offset: 0x00296F47
	private void ResetSearch()
	{
		this.OnClickClearSearchButton();
	}

	// Token: 0x0600B7AA RID: 47018 RVA: 0x00298D4F File Offset: 0x00296F4F
	private void InitScroller()
	{
		this.Scroll = new GenericScrollView<FilterGroup>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterGroup>(this.InitFilterGroup), null);
		this.SearchScroll = new GenericScrollView<FilterItem>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterItem>(this.InitFilterItem), null);
	}

	// Token: 0x0600B7AB RID: 47019 RVA: 0x00298D90 File Offset: 0x00296F90
	private ILayoutItem<FilterItem> InitFilterItem(object tempData, UUIItem uiItem, int index)
	{
		FilterItemData filterItemData = (FilterItemData)tempData;
		FilterItem filterItem = new FilterItem(uiItem);
		filterItem.SetToggleFunction(new TFilterItemToggleEvent(this.FilterItemToggleEvent));
		bool bSelected = this.TempFilterDataMap.ContainsKey(filterItemData.FilterId);
		filterItem.ShowTemp(filterItemData, bSelected);
		return new LayoutItem<FilterItem>
		{
			Key = filterItemData,
			Value = filterItem
		};
	}

	// Token: 0x0600B7AC RID: 47020 RVA: 0x00298DEA File Offset: 0x00296FEA
	private void FilterItemToggleEvent(EToggleState state, int filterId, string name)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.TempFilterDataMap[filterId] = name;
			return;
		}
		this.TempFilterDataMap.Remove(filterId);
	}

	// Token: 0x0600B7AD RID: 47021 RVA: 0x00298E0C File Offset: 0x0029700C
	private ILayoutItem<FilterGroup> InitFilterGroup(object tempData, UUIItem uiItem, int index)
	{
		int ruleId = (int)tempData;
		FilterGroup filterGroup = new FilterGroup(uiItem);
		filterGroup.SetSelectedDataMap(this.TempFilterDataMap);
		filterGroup.SetToggleFunction(new TFilterItemToggleEvent(this.FilterItemToggleEvent));
		filterGroup.SetOnSelectAllFunction(new TOnSelectAllEvent(this.FilterItemToggleEvent));
		filterGroup.ShowTemp(ruleId, this.ViewData.UniqueId);
		FilterDefine.EFilterType filterType = filterGroup.GetFilterType();
		return new LayoutItem<FilterGroup>
		{
			Key = filterType,
			Value = filterGroup
		};
	}

	// Token: 0x0600B7AE RID: 47022 RVA: 0x00298E88 File Offset: 0x00297088
	private void RefreshScroll()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		this.Scroll.RefreshByData<int>(filterConfig.Value.RuleList().ToList<int>(), null);
		this.ShowViewBySearchState(false);
	}

	// Token: 0x0600B7AF RID: 47023 RVA: 0x00298EEC File Offset: 0x002970EC
	private void RefreshSearchScroller()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		List<FilterItemData> list = new List<FilterItemData>();
		foreach (int ruleId in filterConfig.Value.RuleList())
		{
			foreach (FilterItemData filterItemData in FilterModel.Instance.GetFilterItemDataList(ruleId, filterResultData.ConfigId))
			{
				if (filterItemData.Content.Contains(this.CurrentSearchingText))
				{
					list.Add(filterItemData);
				}
			}
		}
		foreach (FilterGroup filterGroup in this.Scroll.GetScrollItemList())
		{
			foreach (KeyValuePair<int, string> keyValuePair in filterGroup.GetTempFilterDataMap())
			{
				this.TempFilterDataMap[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		this.SearchScroll.RefreshByData<FilterItemData>(list, null);
		this.ShowViewBySearchState(true);
	}

	// Token: 0x0600B7B0 RID: 47024 RVA: 0x0029906C File Offset: 0x0029726C
	private void ShowViewBySearchState(bool searchState)
	{
		base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(!searchState);
		base.GetScrollViewWithScrollbar(3).RootUIComp.Get().SetUIActive(searchState);
		this.SearchingState = searchState;
	}

	// Token: 0x0600B7B1 RID: 47025 RVA: 0x002990B8 File Offset: 0x002972B8
	private void ResetView()
	{
		this.TempFilterDataMap.Clear();
		if (!this.SearchingState)
		{
			using (List<FilterGroup>.Enumerator enumerator = this.Scroll.GetScrollItemList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FilterGroup filterGroup = enumerator.Current;
					filterGroup.ResetTempFilterDataMap();
					filterGroup.RefreshGroupItem();
					filterGroup.RefreshSelectAllToggleState();
				}
				return;
			}
		}
		foreach (FilterItem filterItem in this.SearchScroll.GetScrollItemList())
		{
			filterItem.SetToggleState(false);
		}
	}

	// Token: 0x0600B7B2 RID: 47026 RVA: 0x00299174 File Offset: 0x00297374
	private void RefreshView()
	{
		if (StringUtils.IsEmpty(this.CurrentSearchingText))
		{
			this.RefreshScroll();
			return;
		}
		this.RefreshSearchScroller();
	}

	// Token: 0x0600B7B3 RID: 47027 RVA: 0x00299190 File Offset: 0x00297390
	private void SaveDataAndCloseView()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		filterResultData.ClearSelectRuleData();
		foreach (KeyValuePair<int, string> keyValuePair in this.TempFilterDataMap)
		{
			int filterType;
			if (this.FilterVisionDataMap.TryGetValue(keyValuePair.Key, out filterType))
			{
				filterResultData.AddSingleRuleData((FilterDefine.EFilterType)filterType, keyValuePair.Key, keyValuePair.Value);
			}
		}
		Action confirmFunction = this.ViewData.ConfirmFunction;
		if (confirmFunction != null)
		{
			confirmFunction();
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600B7B4 RID: 47028 RVA: 0x00299250 File Offset: 0x00297450
	protected override void OnBeforeShow()
	{
		this.FilterVisionDataMap = new Dictionary<int, int>();
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		foreach (int num in FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId).Value.RuleList())
		{
			FilterDefine.EFilterType filterType = (FilterDefine.EFilterType)FilterConfig.Instance.GetFilterRuleConfig(num).Value.FilterType;
			foreach (FilterItemData filterItemData in FilterModel.Instance.GetFilterItemDataList(num, filterResultData.ConfigId))
			{
				this.FilterVisionDataMap[filterItemData.FilterId] = (int)filterType;
			}
		}
		this.TempFilterDataMap = new Dictionary<int, string>();
		Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> dictionary = (filterResultData != null) ? filterResultData.GetSelectRuleData() : null;
		if (dictionary != null)
		{
			foreach (KeyValuePair<FilterDefine.EFilterType, Dictionary<int, string>> keyValuePair in dictionary)
			{
				foreach (KeyValuePair<int, string> keyValuePair2 in keyValuePair.Value)
				{
					this.TempFilterDataMap[keyValuePair2.Key] = keyValuePair2.Value;
				}
			}
		}
		this.RefreshView();
	}

	// Token: 0x0600B7B5 RID: 47029 RVA: 0x002993EC File Offset: 0x002975EC
	protected override void OnBeforeDestroy()
	{
		this.SearchComponent.Destroy(null);
	}

	// Token: 0x040052D4 RID: 21204
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<FilterGroup> Scroll;

	// Token: 0x040052D5 RID: 21205
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<FilterItem> SearchScroll;

	// Token: 0x040052D6 RID: 21206
	[Nullable(2)]
	private FilterViewData ViewData;

	// Token: 0x040052D7 RID: 21207
	private string CurrentSearchingText = "";

	// Token: 0x040052D8 RID: 21208
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> TempFilterDataMap;

	// Token: 0x040052D9 RID: 21209
	[Nullable(2)]
	private Dictionary<int, int> FilterVisionDataMap;

	// Token: 0x040052DA RID: 21210
	[Nullable(2)]
	private CommonSearchComponent SearchComponent;

	// Token: 0x040052DB RID: 21211
	private bool SearchingState;

	// Token: 0x02007E35 RID: 32309
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x040294DF RID: 169183
		Scroll,
		// Token: 0x040294E0 RID: 169184
		ClearButton,
		// Token: 0x040294E1 RID: 169185
		ConfirmButton,
		// Token: 0x040294E2 RID: 169186
		SearchScroller,
		// Token: 0x040294E3 RID: 169187
		InputBox
	}
}
