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

// Token: 0x02000D26 RID: 3366
[NullableContext(1)]
[Nullable(0)]
public class PinballFilterGroup : UiPanelBase
{
	// Token: 0x06008B6B RID: 35691 RVA: 0x002A2AFC File Offset: 0x002A0CFC
	public PinballFilterGroup(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008B6C RID: 35692 RVA: 0x002A2B18 File Offset: 0x002A0D18
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008B6D RID: 35693 RVA: 0x002A2BA2 File Offset: 0x002A0DA2
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<PinballFilterItem>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PinballFilterItem>(this.InitFilterItem), base.GetItem(2));
	}

	// Token: 0x06008B6E RID: 35694 RVA: 0x002A2BCC File Offset: 0x002A0DCC
	private ILayoutItem<PinballFilterItem> InitFilterItem(object tempData, UUIItem uiItem, int index)
	{
		FilterItemData filterItemData = (FilterItemData)tempData;
		PinballFilterItem pinballFilterItem = new PinballFilterItem(uiItem);
		pinballFilterItem.SetToggleFunction(new TFilterItemToggleEvent(this.FilterItemToggleEvent));
		bool bSelected = this.TempFilterDataMap.ContainsKey(filterItemData.FilterId);
		pinballFilterItem.ShowTemp(filterItemData, bSelected);
		return new LayoutItem<PinballFilterItem>
		{
			Key = filterItemData,
			Value = pinballFilterItem
		};
	}

	// Token: 0x06008B6F RID: 35695 RVA: 0x002A2C26 File Offset: 0x002A0E26
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
		TFilterItemToggleEvent toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state, filterId, name);
	}

	// Token: 0x06008B70 RID: 35696 RVA: 0x002A2C5B File Offset: 0x002A0E5B
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06008B71 RID: 35697 RVA: 0x002A2C5D File Offset: 0x002A0E5D
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06008B72 RID: 35698 RVA: 0x002A2C68 File Offset: 0x002A0E68
	private void InitConfigId()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.UniqueId);
		this.ConfigId = filterResultData.ConfigId;
	}

	// Token: 0x06008B73 RID: 35699 RVA: 0x002A2C92 File Offset: 0x002A0E92
	private void InitCurrentFilterItemArray()
	{
		this.CurrentFilterItemArray = FilterModel.Instance.GetFilterItemDataList(this.RuleId, this.ConfigId);
	}

	// Token: 0x06008B74 RID: 35700 RVA: 0x002A2CB0 File Offset: 0x002A0EB0
	private void SetFilterType()
	{
		this.FilterType = (FilterDefine.EFilterType)FilterConfig.Instance.GetFilterRuleConfig(this.RuleId).Value.FilterType;
	}

	// Token: 0x06008B75 RID: 35701 RVA: 0x002A2CE4 File Offset: 0x002A0EE4
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

	// Token: 0x06008B76 RID: 35702 RVA: 0x002A2D70 File Offset: 0x002A0F70
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

	// Token: 0x06008B77 RID: 35703 RVA: 0x002A2DE8 File Offset: 0x002A0FE8
	private void SetTitle()
	{
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.RuleId);
		base.GetText(0).ShowTextNew(filterRuleConfig.Value.Title);
	}

	// Token: 0x06008B78 RID: 35704 RVA: 0x002A2E24 File Offset: 0x002A1024
	private void InitFilter()
	{
		this.Layout.RebuildLayoutByDataNew<FilterItemData>(this.CurrentFilterItemArray, null);
	}

	// Token: 0x06008B79 RID: 35705 RVA: 0x002A2E4B File Offset: 0x002A104B
	public void SetSelectedDataMap(Dictionary<int, string> data)
	{
		this.CurrentSelectedDataMap = data;
	}

	// Token: 0x06008B7A RID: 35706 RVA: 0x002A2E54 File Offset: 0x002A1054
	public void InitFilterSetData()
	{
		this.InitTempFilterIdSet();
		this.AddCurrentSelectedFilterData();
	}

	// Token: 0x06008B7B RID: 35707 RVA: 0x002A2E62 File Offset: 0x002A1062
	public void ShowTemp(int ruleId, int uniqueId)
	{
		this.RuleId = ruleId;
		this.UniqueId = uniqueId;
		this.InitConfigId();
		this.InitCurrentFilterItemArray();
		this.SetFilterType();
		this.InitFilterSetData();
		this.SetTitle();
		this.InitFilter();
	}

	// Token: 0x06008B7C RID: 35708 RVA: 0x002A2E98 File Offset: 0x002A1098
	public void RefreshGroupItem()
	{
		foreach (KeyValuePair<object, PinballFilterItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			FilterItemData filterItemData = keyValuePair.Key as FilterItemData;
			keyValuePair.Value.SetToggleState(this.TempFilterDataMap.ContainsKey(filterItemData.FilterId));
		}
	}

	// Token: 0x06008B7D RID: 35709 RVA: 0x002A2F14 File Offset: 0x002A1114
	public Dictionary<int, string> GetTempFilterDataMap()
	{
		return this.TempFilterDataMap;
	}

	// Token: 0x06008B7E RID: 35710 RVA: 0x002A2F1C File Offset: 0x002A111C
	public void ResetTempFilterDataMap()
	{
		this.TempFilterDataMap.Clear();
	}

	// Token: 0x06008B7F RID: 35711 RVA: 0x002A2F29 File Offset: 0x002A1129
	public FilterDefine.EFilterType GetFilterType()
	{
		return this.FilterType;
	}

	// Token: 0x04005373 RID: 21363
	private int RuleId;

	// Token: 0x04005374 RID: 21364
	private FilterDefine.EFilterType FilterType = FilterDefine.EFilterType.Weapon;

	// Token: 0x04005375 RID: 21365
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> TempFilterDataMap;

	// Token: 0x04005376 RID: 21366
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x04005377 RID: 21367
	private int ConfigId;

	// Token: 0x04005378 RID: 21368
	private int UniqueId;

	// Token: 0x04005379 RID: 21369
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<PinballFilterItem> Layout;

	// Token: 0x0400537A RID: 21370
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, string> CurrentSelectedDataMap;

	// Token: 0x0400537B RID: 21371
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FilterItemData> CurrentFilterItemArray;

	// Token: 0x02006FB9 RID: 28601
	[NullableContext(0)]
	private enum EPinballFilterGroupComponent
	{
		// Token: 0x04024801 RID: 149505
		Title,
		// Token: 0x04024802 RID: 149506
		Layout,
		// Token: 0x04024803 RID: 149507
		FilterItem
	}
}
