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

// Token: 0x0200186D RID: 6253
[NullableContext(1)]
[Nullable(0)]
public class PinballFilterGroup : UiPanelBase
{
	// Token: 0x0600B782 RID: 46978 RVA: 0x002983DD File Offset: 0x002965DD
	public PinballFilterGroup(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B783 RID: 46979 RVA: 0x002983FC File Offset: 0x002965FC
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

	// Token: 0x0600B784 RID: 46980 RVA: 0x00298486 File Offset: 0x00296686
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<PinballFilterItem>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PinballFilterItem>(this.InitFilterItem), base.GetItem(2));
	}

	// Token: 0x0600B785 RID: 46981 RVA: 0x002984B0 File Offset: 0x002966B0
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

	// Token: 0x0600B786 RID: 46982 RVA: 0x0029850A File Offset: 0x0029670A
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

	// Token: 0x0600B787 RID: 46983 RVA: 0x0029853F File Offset: 0x0029673F
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600B788 RID: 46984 RVA: 0x00298541 File Offset: 0x00296741
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600B789 RID: 46985 RVA: 0x0029854C File Offset: 0x0029674C
	private void InitConfigId()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.UniqueId);
		this.ConfigId = filterResultData.ConfigId;
	}

	// Token: 0x0600B78A RID: 46986 RVA: 0x00298576 File Offset: 0x00296776
	private void InitCurrentFilterItemArray()
	{
		this.CurrentFilterItemArray = FilterModel.Instance.GetFilterItemDataList(this.RuleId, this.ConfigId);
	}

	// Token: 0x0600B78B RID: 46987 RVA: 0x00298594 File Offset: 0x00296794
	private void SetFilterType()
	{
		this.FilterType = (FilterDefine.EFilterType)FilterConfig.Instance.GetFilterRuleConfig(this.RuleId).Value.FilterType;
	}

	// Token: 0x0600B78C RID: 46988 RVA: 0x002985C8 File Offset: 0x002967C8
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

	// Token: 0x0600B78D RID: 46989 RVA: 0x00298654 File Offset: 0x00296854
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

	// Token: 0x0600B78E RID: 46990 RVA: 0x002986CC File Offset: 0x002968CC
	private void SetTitle()
	{
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.RuleId);
		base.GetText(0).ShowTextNew(filterRuleConfig.Value.Title);
	}

	// Token: 0x0600B78F RID: 46991 RVA: 0x00298708 File Offset: 0x00296908
	private void InitFilter()
	{
		this.Layout.RebuildLayoutByDataNew<FilterItemData>(this.CurrentFilterItemArray, null);
	}

	// Token: 0x0600B790 RID: 46992 RVA: 0x0029872F File Offset: 0x0029692F
	public void SetSelectedDataMap(Dictionary<int, string> data)
	{
		this.CurrentSelectedDataMap = data;
	}

	// Token: 0x0600B791 RID: 46993 RVA: 0x00298738 File Offset: 0x00296938
	public void InitFilterSetData()
	{
		this.InitTempFilterIdSet();
		this.AddCurrentSelectedFilterData();
	}

	// Token: 0x0600B792 RID: 46994 RVA: 0x00298746 File Offset: 0x00296946
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

	// Token: 0x0600B793 RID: 46995 RVA: 0x0029877C File Offset: 0x0029697C
	public void RefreshGroupItem()
	{
		foreach (KeyValuePair<object, PinballFilterItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			FilterItemData filterItemData = keyValuePair.Key as FilterItemData;
			keyValuePair.Value.SetToggleState(this.TempFilterDataMap.ContainsKey(filterItemData.FilterId));
		}
	}

	// Token: 0x0600B794 RID: 46996 RVA: 0x002987F8 File Offset: 0x002969F8
	public Dictionary<int, string> GetTempFilterDataMap()
	{
		return this.TempFilterDataMap;
	}

	// Token: 0x0600B795 RID: 46997 RVA: 0x00298800 File Offset: 0x00296A00
	public void ResetTempFilterDataMap()
	{
		this.TempFilterDataMap.Clear();
	}

	// Token: 0x0600B796 RID: 46998 RVA: 0x0029880D File Offset: 0x00296A0D
	public FilterDefine.EFilterType GetFilterType()
	{
		return this.FilterType;
	}

	// Token: 0x040052C8 RID: 21192
	private int RuleId;

	// Token: 0x040052C9 RID: 21193
	private FilterDefine.EFilterType FilterType = FilterDefine.EFilterType.Weapon;

	// Token: 0x040052CA RID: 21194
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> TempFilterDataMap;

	// Token: 0x040052CB RID: 21195
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x040052CC RID: 21196
	private int ConfigId;

	// Token: 0x040052CD RID: 21197
	private int UniqueId;

	// Token: 0x040052CE RID: 21198
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<PinballFilterItem> Layout;

	// Token: 0x040052CF RID: 21199
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, string> CurrentSelectedDataMap;

	// Token: 0x040052D0 RID: 21200
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FilterItemData> CurrentFilterItemArray;

	// Token: 0x02007E32 RID: 32306
	[NullableContext(0)]
	private enum EPinballFilterGroupComponent
	{
		// Token: 0x040294D4 RID: 169172
		Title,
		// Token: 0x040294D5 RID: 169173
		Layout,
		// Token: 0x040294D6 RID: 169174
		FilterItem
	}
}
