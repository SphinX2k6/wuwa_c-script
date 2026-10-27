using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using FilterDefine;
using UnrealEngine;

// Token: 0x0200185A RID: 6234
[NullableContext(1)]
[Nullable(0)]
public class FilterGroup : UiPanelBase
{
	// Token: 0x0600B6A4 RID: 46756 RVA: 0x00294836 File Offset: 0x00292A36
	public FilterGroup(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B6A5 RID: 46757 RVA: 0x00294854 File Offset: 0x00292A54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.SelectAllEvent));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B6A6 RID: 46758 RVA: 0x00294960 File Offset: 0x00292B60
	private void SelectAllEvent(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			using (Dictionary<object, FilterItem>.Enumerator enumerator = this.Layout.GetLayoutItemMap().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<object, FilterItem> keyValuePair = enumerator.Current;
					FilterItemData filterItemData = keyValuePair.Key as FilterItemData;
					this.TempFilterDataMap[filterItemData.FilterId] = filterItemData.Content;
					TOnSelectAllEvent onSelectAllEvent = this.OnSelectAllEvent;
					if (onSelectAllEvent != null)
					{
						onSelectAllEvent(state, filterItemData.FilterId, filterItemData.Content);
					}
				}
				goto IL_D3;
			}
		}
		if (state == EToggleState.ETT_UnChecked)
		{
			foreach (KeyValuePair<int, string> keyValuePair2 in this.TempFilterDataMap)
			{
				TOnSelectAllEvent onSelectAllEvent2 = this.OnSelectAllEvent;
				if (onSelectAllEvent2 != null)
				{
					onSelectAllEvent2(state, keyValuePair2.Key, keyValuePair2.Value);
				}
			}
			this.ResetTempFilterDataMap();
		}
		IL_D3:
		this.RefreshGroupItem();
	}

	// Token: 0x0600B6A7 RID: 46759 RVA: 0x00294A64 File Offset: 0x00292C64
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<FilterItem>(base.GetLayoutBase(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterItem>(this.InitFilterItem), base.GetItem(4));
	}

	// Token: 0x0600B6A8 RID: 46760 RVA: 0x00294A8C File Offset: 0x00292C8C
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

	// Token: 0x0600B6A9 RID: 46761 RVA: 0x00294AE6 File Offset: 0x00292CE6
	private void FilterItemToggleEvent(EToggleState state, int filterId, string name)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.TempFilterDataMap[filterId] = name;
		}
		else
		{
			this.TempFilterDataMap.Remove(filterId);
		}
		this.RefreshSelectAllToggleState();
		TFilterItemToggleEvent toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state, filterId, name);
	}

	// Token: 0x0600B6AA RID: 46762 RVA: 0x00294B21 File Offset: 0x00292D21
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600B6AB RID: 46763 RVA: 0x00294B23 File Offset: 0x00292D23
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600B6AC RID: 46764 RVA: 0x00294B2C File Offset: 0x00292D2C
	public void SetOnSelectAllFunction(TOnSelectAllEvent toggleFunction)
	{
		this.OnSelectAllEvent = toggleFunction;
	}

	// Token: 0x0600B6AD RID: 46765 RVA: 0x00294B38 File Offset: 0x00292D38
	private void InitConfigId()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.UniqueId);
		this.ConfigId = filterResultData.ConfigId;
	}

	// Token: 0x0600B6AE RID: 46766 RVA: 0x00294B62 File Offset: 0x00292D62
	private void InitCurrentFilterItemArray()
	{
		this.CurrentFilterItemArray = FilterModel.Instance.GetFilterItemDataList(this.RuleId, this.ConfigId);
	}

	// Token: 0x0600B6AF RID: 46767 RVA: 0x00294B80 File Offset: 0x00292D80
	private void SetFilterType()
	{
		this.FilterType = (FilterDefine.EFilterType)FilterConfig.Instance.GetFilterRuleConfig(this.RuleId).Value.FilterType;
	}

	// Token: 0x0600B6B0 RID: 46768 RVA: 0x00294BB4 File Offset: 0x00292DB4
	private void InitTempFilterIdSet()
	{
		this.TempFilterDataMap = new Dictionary<int, string>();
		Dictionary<int, string> selectRuleDataById = FilterModel.Instance.GetFilterResultData(this.UniqueId).GetSelectRuleDataById(this.FilterType);
		if (selectRuleDataById == null)
		{
			return;
		}
		foreach (KeyValuePair<int, string> keyValuePair in selectRuleDataById)
		{
			this.TempFilterDataMap[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x0600B6B1 RID: 46769 RVA: 0x00294C40 File Offset: 0x00292E40
	public void AddCurrentSelectedFilterData()
	{
		foreach (FilterItemData filterItemData in this.CurrentFilterItemArray)
		{
			int filterId = filterItemData.FilterId;
			string value;
			if (this.CurrentSelectedDataMap != null && this.CurrentSelectedDataMap.TryGetValue(filterId, out value))
			{
				this.TempFilterDataMap[filterId] = value;
			}
		}
	}

	// Token: 0x0600B6B2 RID: 46770 RVA: 0x00294CB8 File Offset: 0x00292EB8
	private void SetTitle()
	{
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.RuleId);
		base.GetText(0).ShowTextNew(filterRuleConfig.Value.Title);
	}

	// Token: 0x0600B6B3 RID: 46771 RVA: 0x00294CF4 File Offset: 0x00292EF4
	private void InitFilter()
	{
		this.Layout.RebuildLayoutByDataNew<FilterItemData>(this.CurrentFilterItemArray, null);
	}

	// Token: 0x0600B6B4 RID: 46772 RVA: 0x00294D1C File Offset: 0x00292F1C
	private void SetSelectAll()
	{
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(this.ConfigId);
		base.GetItem(1).SetUIActive(filterConfig.Value.IsSupportSelectAll);
	}

	// Token: 0x0600B6B5 RID: 46773 RVA: 0x00294D58 File Offset: 0x00292F58
	public void RefreshSelectAllToggleState()
	{
		if (!FilterConfig.Instance.GetFilterConfig(this.ConfigId).Value.IsSupportSelectAll)
		{
			return;
		}
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.RuleId);
		EToggleState state = (this.TempFilterDataMap.Count == filterRuleConfig.Value.IdList().Length) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600B6B6 RID: 46774 RVA: 0x00294DD0 File Offset: 0x00292FD0
	public void SetSelectedDataMap(Dictionary<int, string> data)
	{
		this.CurrentSelectedDataMap = data;
	}

	// Token: 0x0600B6B7 RID: 46775 RVA: 0x00294DD9 File Offset: 0x00292FD9
	public void InitFilterSetData()
	{
		this.InitTempFilterIdSet();
		this.AddCurrentSelectedFilterData();
	}

	// Token: 0x0600B6B8 RID: 46776 RVA: 0x00294DE7 File Offset: 0x00292FE7
	public void ShowTemp(int ruleId, int uniqueId)
	{
		this.RuleId = ruleId;
		this.UniqueId = uniqueId;
		this.InitConfigId();
		this.InitCurrentFilterItemArray();
		this.SetFilterType();
		this.InitFilterSetData();
		this.SetTitle();
		this.SetSelectAll();
		this.RefreshSelectAllToggleState();
		this.InitFilter();
	}

	// Token: 0x0600B6B9 RID: 46777 RVA: 0x00294E28 File Offset: 0x00293028
	public void RefreshGroupItem()
	{
		foreach (KeyValuePair<object, FilterItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			FilterItemData filterItemData = keyValuePair.Key as FilterItemData;
			keyValuePair.Value.SetToggleState(this.TempFilterDataMap.ContainsKey(filterItemData.FilterId));
		}
	}

	// Token: 0x0600B6BA RID: 46778 RVA: 0x00294EA4 File Offset: 0x002930A4
	public Dictionary<int, string> GetTempFilterDataMap()
	{
		return this.TempFilterDataMap;
	}

	// Token: 0x0600B6BB RID: 46779 RVA: 0x00294EAC File Offset: 0x002930AC
	public void ResetTempFilterDataMap()
	{
		this.TempFilterDataMap.Clear();
	}

	// Token: 0x0600B6BC RID: 46780 RVA: 0x00294EB9 File Offset: 0x002930B9
	public FilterDefine.EFilterType GetFilterType()
	{
		return this.FilterType;
	}

	// Token: 0x04005285 RID: 21125
	private int RuleId;

	// Token: 0x04005286 RID: 21126
	private FilterDefine.EFilterType FilterType = FilterDefine.EFilterType.Weapon;

	// Token: 0x04005287 RID: 21127
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> TempFilterDataMap;

	// Token: 0x04005288 RID: 21128
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x04005289 RID: 21129
	[Nullable(2)]
	private TOnSelectAllEvent OnSelectAllEvent;

	// Token: 0x0400528A RID: 21130
	private int ConfigId;

	// Token: 0x0400528B RID: 21131
	private int UniqueId;

	// Token: 0x0400528C RID: 21132
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<FilterItem> Layout;

	// Token: 0x0400528D RID: 21133
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, string> CurrentSelectedDataMap;

	// Token: 0x0400528E RID: 21134
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FilterItemData> CurrentFilterItemArray;

	// Token: 0x02007E1B RID: 32283
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04029467 RID: 169063
		Title,
		// Token: 0x04029468 RID: 169064
		SelectAllToggleRootItem,
		// Token: 0x04029469 RID: 169065
		SelectAllToggle,
		// Token: 0x0402946A RID: 169066
		Layout,
		// Token: 0x0402946B RID: 169067
		FilterItem
	}
}
