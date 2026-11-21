using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x02000D0E RID: 3342
[NullableContext(1)]
[Nullable(0)]
public class FilterEntrance<[Nullable(2)] T> : UiPanelBase
{
	// Token: 0x06008A57 RID: 35415 RVA: 0x0029E204 File Offset: 0x0029C404
	public FilterEntrance(UUIItem uiItem, TUpdateDataListFunction<T> updateDataListFunction)
	{
		this.UpdateDataListFunction = updateDataListFunction;
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008A58 RID: 35416 RVA: 0x0029E260 File Offset: 0x0029C460
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

	// Token: 0x06008A59 RID: 35417 RVA: 0x0029E36C File Offset: 0x0029C56C
	private void OpenFilterView()
	{
		FilterViewData viewData = new FilterViewData(this.ResultData.UniqueId, new Action(this.ConfirmFunction));
		FilterSortController.Instance.OpenFilterView(viewData);
	}

	// Token: 0x06008A5A RID: 35418 RVA: 0x0029E3A4 File Offset: 0x0029C5A4
	private List<IPhantomFilterData> GetFilteredDataList()
	{
		Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> selectRuleData = this.ResultData.GetSelectRuleData();
		return FilterModel.Instance.GetFilterList<T>(this.DataList, this.ConfigId, selectRuleData).ConvertAll<IPhantomFilterData>((T item) => (IPhantomFilterData)((object)item));
	}

	// Token: 0x06008A5B RID: 35419 RVA: 0x0029E3F8 File Offset: 0x0029C5F8
	private void OnFilterViewClose()
	{
		FilterToggleItem toggleItem = this.ToggleItem;
		if (toggleItem == null)
		{
			return;
		}
		toggleItem.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x06008A5C RID: 35420 RVA: 0x0029E40B File Offset: 0x0029C60B
	private void ConfirmFunction()
	{
		this.SaveStorage();
		this.RefreshName();
		this.UpdateDataList(false);
	}

	// Token: 0x06008A5D RID: 35421 RVA: 0x0029E420 File Offset: 0x0029C620
	private void OnBtnClearClick()
	{
		Action onBtnClearClickCallback = this.OnBtnClearClickCallback;
		if (onBtnClearClickCallback != null)
		{
			onBtnClearClickCallback();
		}
		this.ClearData();
	}

	// Token: 0x06008A5E RID: 35422 RVA: 0x0029E439 File Offset: 0x0029C639
	private void ClearData()
	{
		FilterModel.Instance.ClearData(this.ResultData.UniqueId);
		base.GetItem(1).SetUIActive(false);
		this.SaveStorage();
		this.UpdateDataList(false);
	}

	// Token: 0x06008A5F RID: 35423 RVA: 0x0029E46C File Offset: 0x0029C66C
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

	// Token: 0x06008A60 RID: 35424 RVA: 0x0029E4D2 File Offset: 0x0029C6D2
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

	// Token: 0x06008A61 RID: 35425 RVA: 0x0029E4FA File Offset: 0x0029C6FA
	protected override void OnStart()
	{
		base.GetItem(1).SetUIActive(false);
		this.AddEventListener();
	}

	// Token: 0x06008A62 RID: 35426 RVA: 0x0029E510 File Offset: 0x0029C710
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

	// Token: 0x06008A63 RID: 35427 RVA: 0x0029E598 File Offset: 0x0029C798
	public void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFilterDataUpdate, new Action<int>(this.OnFilterDataUpdate));
	}

	// Token: 0x06008A64 RID: 35428 RVA: 0x0029E5B6 File Offset: 0x0029C7B6
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFilterDataUpdate, new Action<int>(this.OnFilterDataUpdate));
	}

	// Token: 0x06008A65 RID: 35429 RVA: 0x0029E5D4 File Offset: 0x0029C7D4
	private void OnFilterDataUpdate(int configId)
	{
		if (this.ConfigId == configId)
		{
			this.UpdateDataList(true);
			this.RefreshName();
		}
	}

	// Token: 0x06008A66 RID: 35430 RVA: 0x0029E5EC File Offset: 0x0029C7EC
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

	// Token: 0x06008A67 RID: 35431 RVA: 0x0029E634 File Offset: 0x0029C834
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

	// Token: 0x06008A68 RID: 35432 RVA: 0x0029E6BA File Offset: 0x0029C8BA
	public Dictionary<FilterDefine.EFilterType, Dictionary<int, string>> GetSelectRuleDataMap()
	{
		return this.ResultData.GetSelectRuleData();
	}

	// Token: 0x06008A69 RID: 35433 RVA: 0x0029E6C7 File Offset: 0x0029C8C7
	[NullableContext(2)]
	private void InitConfigId(EFilterSortGroupId groupId, EFilterSortConfigId? saveConfigId = null, string saveConfigExtraParam = null)
	{
		this.GroupId = new EFilterSortGroupId?(groupId);
		this.ConfigId = FilterConfig.Instance.GetFilterId(groupId);
		this.SaveConfigId = saveConfigId;
		this.SaveConfigExtraParam = (saveConfigExtraParam ?? "");
	}

	// Token: 0x06008A6A RID: 35434 RVA: 0x0029E700 File Offset: 0x0029C900
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

	// Token: 0x06008A6B RID: 35435 RVA: 0x0029E76C File Offset: 0x0029C96C
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

	// Token: 0x06008A6C RID: 35436 RVA: 0x0029E8B8 File Offset: 0x0029CAB8
	private void HandleFilterActive()
	{
		this.SetActive(this.ConfigId > 0);
	}

	// Token: 0x06008A6D RID: 35437 RVA: 0x0029E8CC File Offset: 0x0029CACC
	private bool IsPhantomFilter()
	{
		return this.ConfigId != 0 && FilterConfig.Instance.GetFilterConfig(this.ConfigId).Value.PrefabType == 1;
	}

	// Token: 0x06008A6E RID: 35438 RVA: 0x0029E908 File Offset: 0x0029CB08
	private UniTask RefreshToggleButtonActive()
	{
		FilterEntrance<T>.<RefreshToggleButtonActive>d__36 <RefreshToggleButtonActive>d__;
		<RefreshToggleButtonActive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshToggleButtonActive>d__.<>4__this = this;
		<RefreshToggleButtonActive>d__.<>1__state = -1;
		<RefreshToggleButtonActive>d__.<>t__builder.Start<FilterEntrance<T>.<RefreshToggleButtonActive>d__36>(ref <RefreshToggleButtonActive>d__);
		return <RefreshToggleButtonActive>d__.<>t__builder.Task;
	}

	// Token: 0x06008A6F RID: 35439 RVA: 0x0029E94C File Offset: 0x0029CB4C
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

	// Token: 0x06008A70 RID: 35440 RVA: 0x0029E9C4 File Offset: 0x0029CBC4
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

	// Token: 0x06008A71 RID: 35441 RVA: 0x0029EA84 File Offset: 0x0029CC84
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

	// Token: 0x06008A72 RID: 35442 RVA: 0x0029EB88 File Offset: 0x0029CD88
	public int GetUniqueIdByGroupId(EFilterSortGroupId groupId)
	{
		int result;
		if (this.UniqueIdMap.TryGetValue((int)groupId, out result))
		{
			return result;
		}
		return -1;
	}

	// Token: 0x06008A73 RID: 35443 RVA: 0x0029EBA8 File Offset: 0x0029CDA8
	public void SetSortUniqueId(int uniqueId)
	{
		this.SortUniqueId = uniqueId;
	}

	// Token: 0x06008A74 RID: 35444 RVA: 0x0029EBB1 File Offset: 0x0029CDB1
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

	// Token: 0x04005320 RID: 21280
	private readonly Dictionary<int, int> UniqueIdMap = new Dictionary<int, int>();

	// Token: 0x04005321 RID: 21281
	private int SortUniqueId = -1;

	// Token: 0x04005322 RID: 21282
	[Nullable(2)]
	private FilterResultData ResultData;

	// Token: 0x04005323 RID: 21283
	private List<T> DataList = new List<T>();

	// Token: 0x04005324 RID: 21284
	private List<object> ExtraParams = new List<object>();

	// Token: 0x04005325 RID: 21285
	private EFilterSortGroupId? GroupId;

	// Token: 0x04005326 RID: 21286
	private int ConfigId;

	// Token: 0x04005327 RID: 21287
	private EFilterSortConfigId? SaveConfigId;

	// Token: 0x04005328 RID: 21288
	private string SaveConfigExtraParam = "";

	// Token: 0x04005329 RID: 21289
	[Nullable(2)]
	public Action OnBtnClearClickCallback;

	// Token: 0x0400532A RID: 21290
	[Nullable(2)]
	private FilterToggleItem ToggleItem;

	// Token: 0x0400532B RID: 21291
	protected TUpdateDataListFunction<T> UpdateDataListFunction;

	// Token: 0x02006F9D RID: 28573
	[NullableContext(0)]
	private class ECompDefine
	{
		// Token: 0x04024782 RID: 149378
		public const int Button = 0;

		// Token: 0x04024783 RID: 149379
		public const int FilterTipsItem = 1;

		// Token: 0x04024784 RID: 149380
		public const int FilterTips = 2;

		// Token: 0x04024785 RID: 149381
		public const int ClearButton = 3;
	}
}
