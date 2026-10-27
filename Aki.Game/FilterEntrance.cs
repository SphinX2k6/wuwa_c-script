using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001855 RID: 6229
[NullableContext(1)]
[Nullable(0)]
public class FilterEntrance<[Nullable(2)] T> : UiPanelBase
{
	// Token: 0x0600B66E RID: 46702 RVA: 0x00293AF4 File Offset: 0x00291CF4
	public FilterEntrance(UUIItem uiItem, TUpdateDataListFunction<T> updateDataListFunction)
	{
		this.UpdateDataListFunction = updateDataListFunction;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B66F RID: 46703 RVA: 0x00293B50 File Offset: 0x00291D50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OpenFilterView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnClearClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B670 RID: 46704 RVA: 0x00293C5C File Offset: 0x00291E5C
	private void OpenFilterView()
	{
		FilterViewData viewData = new FilterViewData(this.ResultData.UniqueId, new Action(this.ConfirmFunction));
		FilterSortController.Instance.OpenFilterView(viewData);
	}

	// Token: 0x0600B671 RID: 46705 RVA: 0x00293C94 File Offset: 0x00291E94
	private List<IPhantomFilterData> GetFilteredDataList()
	{
		Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> selectRuleData = this.ResultData.GetSelectRuleData();
		return FilterModel.Instance.GetFilterList<T>(this.DataList, this.ConfigId, selectRuleData).Cast<IPhantomFilterData>().ToList<IPhantomFilterData>();
	}

	// Token: 0x0600B672 RID: 46706 RVA: 0x00293CCE File Offset: 0x00291ECE
	private void OnFilterViewClose()
	{
		FilterToggleItem toggleItem = this.ToggleItem;
		if (toggleItem == null)
		{
			return;
		}
		toggleItem.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x0600B673 RID: 46707 RVA: 0x00293CE1 File Offset: 0x00291EE1
	private void ConfirmFunction()
	{
		this.SaveStorage();
		this.RefreshName();
		this.UpdateDataList(false);
	}

	// Token: 0x0600B674 RID: 46708 RVA: 0x00293CF6 File Offset: 0x00291EF6
	private void OnBtnClearClick()
	{
		Action onBtnClearClickCallback = this.OnBtnClearClickCallback;
		if (onBtnClearClickCallback != null)
		{
			onBtnClearClickCallback();
		}
		this.ClearData();
	}

	// Token: 0x0600B675 RID: 46709 RVA: 0x00293D0F File Offset: 0x00291F0F
	private void ClearData()
	{
		FilterModel.Instance.ClearData(this.ResultData.UniqueId);
		base.GetItem(1).SetUIActive(false);
		this.SaveStorage();
		this.UpdateDataList(false);
	}

	// Token: 0x0600B676 RID: 46710 RVA: 0x00293D40 File Offset: 0x00291F40
	private void OnToggleStateChange(EToggleState state)
	{
		if (!this.IsPhantomFilter())
		{
			return;
		}
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		PhantomFilterViewData<IPhantomFilterData> viewData = new PhantomFilterViewData<IPhantomFilterData>(this.ResultData.UniqueId, this.GroupId.GetValueOrDefault(), new Action(this.ConfirmFunction), new Func<List<IPhantomFilterData>>(this.GetFilteredDataList), new Action(this.OnFilterViewClose));
		FilterSortController.Instance.OpenPhantomFilterView(viewData);
	}

	// Token: 0x0600B677 RID: 46711 RVA: 0x00293DA6 File Offset: 0x00291FA6
	public bool TryClearData()
	{
		if (this.ConfigId <= 0)
		{
			return false;
		}
		if (StringUtils.IsBlank(this.ResultData.ShowAllFilterContent()))
		{
			return false;
		}
		this.ClearData();
		return true;
	}

	// Token: 0x0600B678 RID: 46712 RVA: 0x00293DCE File Offset: 0x00291FCE
	protected override void OnStart()
	{
		base.GetItem(1).SetUIActive(false);
		this.AddEventListener();
	}

	// Token: 0x0600B679 RID: 46713 RVA: 0x00293DE4 File Offset: 0x00291FE4
	protected override void OnBeforeDestroy()
	{
		foreach (int uniqueId in this.UniqueIdMap.Values)
		{
			FilterModel.Instance.DeleteFilterResultData(uniqueId);
		}
		this.UniqueIdMap.Clear();
		this.RemoveEventListener();
		FilterToggleItem toggleItem = this.ToggleItem;
		if (toggleItem != null)
		{
			toggleItem.Destroy(null);
		}
		this.ToggleItem = null;
	}

	// Token: 0x0600B67A RID: 46714 RVA: 0x00293E6C File Offset: 0x0029206C
	public void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFilterDataUpdate, new Action<int>(this.OnFilterDataUpdate));
	}

	// Token: 0x0600B67B RID: 46715 RVA: 0x00293E8A File Offset: 0x0029208A
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFilterDataUpdate, new Action<int>(this.OnFilterDataUpdate));
	}

	// Token: 0x0600B67C RID: 46716 RVA: 0x00293EA8 File Offset: 0x002920A8
	private void OnFilterDataUpdate(int configId)
	{
		if (this.ConfigId == configId)
		{
			this.UpdateDataList(true);
			this.RefreshName();
		}
	}

	// Token: 0x0600B67D RID: 46717 RVA: 0x00293EC0 File Offset: 0x002920C0
	private void RefreshName()
	{
		string text = this.ResultData.ShowAllFilterContent();
		UUIItem item = base.GetItem(1);
		if (StringUtils.IsBlank(text))
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x0600B67E RID: 46718 RVA: 0x00293F08 File Offset: 0x00292108
	private void UpdateDataList(bool isOutSideChange)
	{
		Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> selectRuleData = this.ResultData.GetSelectRuleData();
		List<T> filterList = FilterModel.Instance.GetFilterList<T>(this.DataList, this.ConfigId, selectRuleData);
		SortResultData sortResultData = SortModel.Instance.GetSortResultData(this.SortUniqueId);
		if (sortResultData != null)
		{
			int sortId = SortConfig.Instance.GetSortId(this.GroupId.Value);
			SortModel.Instance.SortDataList<T>(filterList, sortId, sortResultData, this.ExtraParams.ToArray());
		}
		TUpdateDataListFunction<T> updateDataListFunction = this.UpdateDataListFunction;
		if (updateDataListFunction == null)
		{
			return;
		}
		updateDataListFunction(filterList, isOutSideChange, EFilterSortType.Filter);
	}

	// Token: 0x0600B67F RID: 46719 RVA: 0x00293F8E File Offset: 0x0029218E
	public Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> GetSelectRuleDataMap()
	{
		return this.ResultData.GetSelectRuleData();
	}

	// Token: 0x0600B680 RID: 46720 RVA: 0x00293F9B File Offset: 0x0029219B
	[NullableContext(2)]
	private void InitConfigId(EFilterSortGroupId groupId, EFilterSortConfigId? saveConfigId = null, string saveConfigExtraParam = null)
	{
		this.GroupId = new EFilterSortGroupId?(groupId);
		this.ConfigId = FilterConfig.Instance.GetFilterId(groupId);
		this.SaveConfigId = saveConfigId;
		this.SaveConfigExtraParam = (saveConfigExtraParam ?? "");
	}

	// Token: 0x0600B681 RID: 46721 RVA: 0x00293FD4 File Offset: 0x002921D4
	private void SaveStorage()
	{
		if (this.SaveConfigId != null)
		{
			EFilterSortGroupId? groupId = this.GroupId;
			EFilterSortGroupId efilterSortGroupId = EFilterSortGroupId.None;
			if (!(groupId.GetValueOrDefault() == efilterSortGroupId & groupId != null))
			{
				FilterStorageData data = this.ResultData.ConvertToStorageData();
				FilterModel.Instance.SetFilterConfigData(this.SaveConfigId.Value, (int)this.GroupId.Value, data, this.SaveConfigExtraParam);
			}
		}
	}

	// Token: 0x0600B682 RID: 46722 RVA: 0x00294040 File Offset: 0x00292240
	[NullableContext(2)]
	private void InitResultData(FilterStorageData storageData = null)
	{
		int uniqueIdByGroupId = this.GetUniqueIdByGroupId(this.GroupId.Value);
		this.ResultData = FilterModel.Instance.GetFilterResultData(uniqueIdByGroupId);
		if (this.ResultData == null)
		{
			this.ResultData = new FilterResultData();
			this.ResultData.SetConfigId(this.ConfigId);
			Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> dictionary = new Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>();
			if (storageData != null)
			{
				foreach (KeyValuePair<FilterDefine.EFilterType, List<int>> keyValuePair in storageData.SelectRuleMap)
				{
					FilterDefine.EFilterType key = keyValuePair.Key;
					List<int> value = keyValuePair.Value;
					Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
					foreach (FilterItemData filterItemData in FilterModel.Instance.GetFilterDataFuncByFilterType(key)(value.ToArray()))
					{
						dictionary2.Add(filterItemData.FilterId, filterItemData.Content);
					}
					dictionary.Add(key, dictionary2);
				}
			}
			this.ResultData.SetRuleData(dictionary);
			FilterModel.Instance.SetFilterResultData(this.ResultData);
			this.UniqueIdMap.Add((int)this.GroupId.Value, this.ResultData.UniqueId);
		}
	}

	// Token: 0x0600B683 RID: 46723 RVA: 0x0029418C File Offset: 0x0029238C
	private void HandleFilterActive()
	{
		this.SetActive(this.ConfigId > 0);
	}

	// Token: 0x0600B684 RID: 46724 RVA: 0x002941A0 File Offset: 0x002923A0
	private bool IsPhantomFilter()
	{
		return this.ConfigId != 0 && FilterConfig.Instance.GetFilterConfig(this.ConfigId).Value.PrefabType == 1;
	}

	// Token: 0x0600B685 RID: 46725 RVA: 0x002941DC File Offset: 0x002923DC
	private UniTask RefreshToggleButtonActive()
	{
		FilterEntrance<T>.<RefreshToggleButtonActive>d__36 <RefreshToggleButtonActive>d__;
		<RefreshToggleButtonActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshToggleButtonActive>d__.<>4__this = this;
		<RefreshToggleButtonActive>d__.<>1__state = -1;
		<RefreshToggleButtonActive>d__.<>t__builder.Start<FilterEntrance<T>.<RefreshToggleButtonActive>d__36>(ref <RefreshToggleButtonActive>d__);
		return <RefreshToggleButtonActive>d__.<>t__builder.Task;
	}

	// Token: 0x0600B686 RID: 46726 RVA: 0x00294220 File Offset: 0x00292420
	public void UpdateData(EFilterSortGroupId groupId, List<T> dataList, params object[] parameters)
	{
		this.InitConfigId(groupId, null, null);
		this.HandleFilterActive();
		if (this.ConfigId <= 0)
		{
			return;
		}
		this.DataList = dataList;
		this.ExtraParams = new List<object>(parameters);
		this.InitResultData(null);
		this.RefreshName();
		if (SortConfig.Instance.GetSortId(this.GroupId.Value) == 0)
		{
			this.UpdateDataList(true);
		}
		this.RefreshToggleButtonActive().Forget();
	}

	// Token: 0x0600B687 RID: 46727 RVA: 0x00294298 File Offset: 0x00292498
	public void UpdateDataWithConfig(EFilterSortGroupId groupId, EFilterSortConfigId saveConfigId, List<T> dataList, string saveConfigExtraParam = "", params object[] parameters)
	{
		FilterSortConfig sortFilterConfig = SortConfig.Instance.GetSortFilterConfig(saveConfigId);
		if (sortFilterConfig.SaveMode == 1 || sortFilterConfig.SaveMode == 3)
		{
			this.UpdateData(groupId, dataList, parameters);
			return;
		}
		this.SaveStorage();
		this.InitConfigId(groupId, new EFilterSortConfigId?(saveConfigId), saveConfigExtraParam);
		this.HandleFilterActive();
		if (this.ConfigId <= 0)
		{
			return;
		}
		this.DataList = dataList;
		this.ExtraParams = new List<object>(parameters);
		FilterStorageData filterConfigData = FilterModel.Instance.GetFilterConfigData(saveConfigId, (int)this.GroupId.Value, saveConfigExtraParam);
		this.InitResultData(filterConfigData);
		this.RefreshName();
		if (SortConfig.Instance.GetSortId(this.GroupId.Value) == 0)
		{
			this.UpdateDataList(true);
		}
		this.RefreshToggleButtonActive().Forget();
	}

	// Token: 0x0600B688 RID: 46728 RVA: 0x00294358 File Offset: 0x00292558
	public bool SelectSingleById(int id)
	{
		FilterResultData resultData = this.ResultData;
		if (resultData != null)
		{
			resultData.ClearSelectRuleData();
		}
		foreach (int num in FilterConfig.Instance.GetFilterConfig(this.ConfigId).Value.RuleList())
		{
			FilterDefine.EFilterType filterType = (FilterDefine.EFilterType)FilterConfig.Instance.GetFilterRuleConfig(num).Value.FilterType;
			List<FilterItemData> filterItemDataList = FilterModel.Instance.GetFilterItemDataList(num, this.ConfigId);
			FilterItemData filterItemData = null;
			foreach (FilterItemData filterItemData2 in filterItemDataList)
			{
				if (filterItemData2.FilterId == id)
				{
					filterItemData = filterItemData2;
					break;
				}
			}
			if (filterItemData != null)
			{
				this.ResultData.AddSingleRuleData(filterType, id, filterItemData.Content ?? "");
				this.ConfirmFunction();
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600B689 RID: 46729 RVA: 0x0029445C File Offset: 0x0029265C
	public int GetUniqueIdByGroupId(EFilterSortGroupId groupId)
	{
		int result;
		if (this.UniqueIdMap.TryGetValue((int)groupId, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x0600B68A RID: 46730 RVA: 0x0029447C File Offset: 0x0029267C
	public void SetSortUniqueId(int uniqueId)
	{
		this.SortUniqueId = uniqueId;
	}

	// Token: 0x0600B68B RID: 46731 RVA: 0x00294485 File Offset: 0x00292685
	[NullableContext(2)]
	public UUIItem GetFilterToggleItem()
	{
		FilterToggleItem toggleItem = this.ToggleItem;
		if (toggleItem == null)
		{
			return null;
		}
		return toggleItem.GetFilterToggleItem();
	}

	// Token: 0x04005275 RID: 21109
	private readonly Dictionary<int, int> UniqueIdMap = new Dictionary<int, int>();

	// Token: 0x04005276 RID: 21110
	private int SortUniqueId = -1;

	// Token: 0x04005277 RID: 21111
	[Nullable(2)]
	private FilterResultData ResultData;

	// Token: 0x04005278 RID: 21112
	private List<T> DataList = new List<T>();

	// Token: 0x04005279 RID: 21113
	private List<object> ExtraParams = new List<object>();

	// Token: 0x0400527A RID: 21114
	private EFilterSortGroupId? GroupId;

	// Token: 0x0400527B RID: 21115
	private int ConfigId;

	// Token: 0x0400527C RID: 21116
	private EFilterSortConfigId? SaveConfigId;

	// Token: 0x0400527D RID: 21117
	private string SaveConfigExtraParam = "";

	// Token: 0x0400527E RID: 21118
	[Nullable(2)]
	public Action OnBtnClearClickCallback;

	// Token: 0x0400527F RID: 21119
	[Nullable(2)]
	private FilterToggleItem ToggleItem;

	// Token: 0x04005280 RID: 21120
	protected TUpdateDataListFunction<T> UpdateDataListFunction;

	// Token: 0x02007E17 RID: 32279
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04029457 RID: 169047
		public const int Button = 0;

		// Token: 0x04029458 RID: 169048
		public const int FilterTipsItem = 1;

		// Token: 0x04029459 RID: 169049
		public const int FilterTips = 2;

		// Token: 0x0402945A RID: 169050
		public const int ClearButton = 3;
	}
}
