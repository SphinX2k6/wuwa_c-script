using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.InputView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using FilterDefine;
using UnrealEngine;

// Token: 0x02000D29 RID: 3369
[NullableContext(1)]
[Nullable(0)]
public class VisionFilterView : UiViewBase
{
	// Token: 0x06008B8C RID: 35724 RVA: 0x002A322E File Offset: 0x002A142E
	public VisionFilterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008B8D RID: 35725 RVA: 0x002A3244 File Offset: 0x002A1444
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

	// Token: 0x06008B8E RID: 35726 RVA: 0x002A3370 File Offset: 0x002A1570
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

	// Token: 0x06008B8F RID: 35727 RVA: 0x002A33F0 File Offset: 0x002A15F0
	private void OnClickSearchButton(string content)
	{
		this.CurrentSearchingText = content;
		this.TempFilterDataMap.Clear();
		this.RefreshView();
	}

	// Token: 0x06008B90 RID: 35728 RVA: 0x002A340C File Offset: 0x002A160C
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as FilterViewData);
		this.InitScroller();
		this.SearchComponent = new CommonSearchComponent(base.GetItem(4), new Action<string>(this.SearchResult), new Action(this.ResetSearch));
	}

	// Token: 0x06008B91 RID: 35729 RVA: 0x002A345A File Offset: 0x002A165A
	private void SearchResult(string content)
	{
		this.OnClickSearchButton(content);
	}

	// Token: 0x06008B92 RID: 35730 RVA: 0x002A3463 File Offset: 0x002A1663
	private void ResetSearch()
	{
		this.OnClickClearSearchButton();
	}

	// Token: 0x06008B93 RID: 35731 RVA: 0x002A346B File Offset: 0x002A166B
	private void InitScroller()
	{
		this.Scroll = new GenericScrollView<FilterGroup>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterGroup>(this.InitFilterGroup), null);
		this.SearchScroll = new GenericScrollView<FilterItem>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterItem>(this.InitFilterItem), null);
	}

	// Token: 0x06008B94 RID: 35732 RVA: 0x002A34AC File Offset: 0x002A16AC
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

	// Token: 0x06008B95 RID: 35733 RVA: 0x002A3506 File Offset: 0x002A1706
	private void FilterItemToggleEvent(EToggleState state, int filterId, string name)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.TempFilterDataMap[filterId] = name;
			return;
		}
		this.TempFilterDataMap.Remove(filterId);
	}

	// Token: 0x06008B96 RID: 35734 RVA: 0x002A3528 File Offset: 0x002A1728
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

	// Token: 0x06008B97 RID: 35735 RVA: 0x002A35A4 File Offset: 0x002A17A4
	private void RefreshScroll()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		this.Scroll.RefreshByData<int>(filterConfig.Value.RuleList(), null);
		this.ShowViewBySearchState(false);
	}

	// Token: 0x06008B98 RID: 35736 RVA: 0x002A3604 File Offset: 0x002A1804
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

	// Token: 0x06008B99 RID: 35737 RVA: 0x002A3784 File Offset: 0x002A1984
	private void ShowViewBySearchState(bool searchState)
	{
		base.GetScrollViewWithScrollbar(0).RootUIComp.Get().SetUIActive(!searchState);
		base.GetScrollViewWithScrollbar(3).RootUIComp.Get().SetUIActive(searchState);
		this.SearchingState = searchState;
	}

	// Token: 0x06008B9A RID: 35738 RVA: 0x002A37D0 File Offset: 0x002A19D0
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

	// Token: 0x06008B9B RID: 35739 RVA: 0x002A388C File Offset: 0x002A1A8C
	private void RefreshView()
	{
		if (StringUtils.IsEmpty(this.CurrentSearchingText))
		{
			this.RefreshScroll();
			return;
		}
		this.RefreshSearchScroller();
	}

	// Token: 0x06008B9C RID: 35740 RVA: 0x002A38A8 File Offset: 0x002A1AA8
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

	// Token: 0x06008B9D RID: 35741 RVA: 0x002A3968 File Offset: 0x002A1B68
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

	// Token: 0x06008B9E RID: 35742 RVA: 0x002A3B04 File Offset: 0x002A1D04
	protected override void OnBeforeDestroy()
	{
		this.SearchComponent.Destroy(null);
	}

	// Token: 0x0400537F RID: 21375
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<FilterGroup> Scroll;

	// Token: 0x04005380 RID: 21376
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<FilterItem> SearchScroll;

	// Token: 0x04005381 RID: 21377
	[Nullable(2)]
	private FilterViewData ViewData;

	// Token: 0x04005382 RID: 21378
	private string CurrentSearchingText = "";

	// Token: 0x04005383 RID: 21379
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> TempFilterDataMap;

	// Token: 0x04005384 RID: 21380
	[Nullable(2)]
	private Dictionary<int, int> FilterVisionDataMap;

	// Token: 0x04005385 RID: 21381
	[Nullable(2)]
	private CommonSearchComponent SearchComponent;

	// Token: 0x04005386 RID: 21382
	private bool SearchingState;

	// Token: 0x02006FBC RID: 28604
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402480C RID: 149516
		Scroll,
		// Token: 0x0402480D RID: 149517
		ClearButton,
		// Token: 0x0402480E RID: 149518
		ConfirmButton,
		// Token: 0x0402480F RID: 149519
		SearchScroller,
		// Token: 0x04024810 RID: 149520
		InputBox
	}
}
