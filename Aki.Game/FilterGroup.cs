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

// Token: 0x02000D13 RID: 3347
[NullableContext(1)]
[Nullable(0)]
public class FilterGroup : UiPanelBase
{
	// Token: 0x06008A8D RID: 35469 RVA: 0x0029EF62 File Offset: 0x0029D162
	public FilterGroup(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008A8E RID: 35470 RVA: 0x0029EF80 File Offset: 0x0029D180
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

	// Token: 0x06008A8F RID: 35471 RVA: 0x0029F08C File Offset: 0x0029D28C
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

	// Token: 0x06008A90 RID: 35472 RVA: 0x0029F190 File Offset: 0x0029D390
	protected override void OnStart()
	{
		this.Layout = new GenericLayoutNew<FilterItem>(base.GetLayoutBase(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterItem>(this.InitFilterItem), base.GetItem(4));
	}

	// Token: 0x06008A91 RID: 35473 RVA: 0x0029F1B8 File Offset: 0x0029D3B8
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

	// Token: 0x06008A92 RID: 35474 RVA: 0x0029F212 File Offset: 0x0029D412
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

	// Token: 0x06008A93 RID: 35475 RVA: 0x0029F24D File Offset: 0x0029D44D
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06008A94 RID: 35476 RVA: 0x0029F24F File Offset: 0x0029D44F
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06008A95 RID: 35477 RVA: 0x0029F258 File Offset: 0x0029D458
	public void SetOnSelectAllFunction(TOnSelectAllEvent toggleFunction)
	{
		this.OnSelectAllEvent = toggleFunction;
	}

	// Token: 0x06008A96 RID: 35478 RVA: 0x0029F264 File Offset: 0x0029D464
	private void InitConfigId()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.UniqueId);
		this.ConfigId = filterResultData.ConfigId;
	}

	// Token: 0x06008A97 RID: 35479 RVA: 0x0029F28E File Offset: 0x0029D48E
	private void InitCurrentFilterItemArray()
	{
		this.CurrentFilterItemArray = FilterModel.Instance.GetFilterItemDataList(this.RuleId, this.ConfigId);
	}

	// Token: 0x06008A98 RID: 35480 RVA: 0x0029F2AC File Offset: 0x0029D4AC
	private void SetFilterType()
	{
		this.FilterType = (FilterDefine.EFilterType)FilterConfig.Instance.GetFilterRuleConfig(this.RuleId).Value.FilterType;
	}

	// Token: 0x06008A99 RID: 35481 RVA: 0x0029F2E0 File Offset: 0x0029D4E0
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

	// Token: 0x06008A9A RID: 35482 RVA: 0x0029F36C File Offset: 0x0029D56C
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

	// Token: 0x06008A9B RID: 35483 RVA: 0x0029F3E4 File Offset: 0x0029D5E4
	private void SetTitle()
	{
		FilterRule? filterRuleConfig = FilterConfig.Instance.GetFilterRuleConfig(this.RuleId);
		base.GetText(0).ShowTextNew(filterRuleConfig.Value.Title);
	}

	// Token: 0x06008A9C RID: 35484 RVA: 0x0029F420 File Offset: 0x0029D620
	private void InitFilter()
	{
		this.Layout.RebuildLayoutByDataNew<FilterItemData>(this.CurrentFilterItemArray, null);
	}

	// Token: 0x06008A9D RID: 35485 RVA: 0x0029F448 File Offset: 0x0029D648
	private void SetSelectAll()
	{
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(this.ConfigId);
		base.GetItem(1).SetUIActive(filterConfig.Value.IsSupportSelectAll);
	}

	// Token: 0x06008A9E RID: 35486 RVA: 0x0029F484 File Offset: 0x0029D684
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

	// Token: 0x06008A9F RID: 35487 RVA: 0x0029F4FC File Offset: 0x0029D6FC
	public void SetSelectedDataMap(Dictionary<int, string> data)
	{
		this.CurrentSelectedDataMap = data;
	}

	// Token: 0x06008AA0 RID: 35488 RVA: 0x0029F505 File Offset: 0x0029D705
	public void InitFilterSetData()
	{
		this.InitTempFilterIdSet();
		this.AddCurrentSelectedFilterData();
	}

	// Token: 0x06008AA1 RID: 35489 RVA: 0x0029F513 File Offset: 0x0029D713
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

	// Token: 0x06008AA2 RID: 35490 RVA: 0x0029F554 File Offset: 0x0029D754
	public void RefreshGroupItem()
	{
		foreach (KeyValuePair<object, FilterItem> keyValuePair in this.Layout.GetLayoutItemMap())
		{
			FilterItemData filterItemData = keyValuePair.Key as FilterItemData;
			keyValuePair.Value.SetToggleState(this.TempFilterDataMap.ContainsKey(filterItemData.FilterId));
		}
	}

	// Token: 0x06008AA3 RID: 35491 RVA: 0x0029F5D0 File Offset: 0x0029D7D0
	public Dictionary<int, string> GetTempFilterDataMap()
	{
		return this.TempFilterDataMap;
	}

	// Token: 0x06008AA4 RID: 35492 RVA: 0x0029F5D8 File Offset: 0x0029D7D8
	public void ResetTempFilterDataMap()
	{
		this.TempFilterDataMap.Clear();
	}

	// Token: 0x06008AA5 RID: 35493 RVA: 0x0029F5E5 File Offset: 0x0029D7E5
	public FilterDefine.EFilterType GetFilterType()
	{
		return this.FilterType;
	}

	// Token: 0x04005330 RID: 21296
	private int RuleId;

	// Token: 0x04005331 RID: 21297
	private FilterDefine.EFilterType FilterType = FilterDefine.EFilterType.Weapon;

	// Token: 0x04005332 RID: 21298
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> TempFilterDataMap;

	// Token: 0x04005333 RID: 21299
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x04005334 RID: 21300
	[Nullable(2)]
	private TOnSelectAllEvent OnSelectAllEvent;

	// Token: 0x04005335 RID: 21301
	private int ConfigId;

	// Token: 0x04005336 RID: 21302
	private int UniqueId;

	// Token: 0x04005337 RID: 21303
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<FilterItem> Layout;

	// Token: 0x04005338 RID: 21304
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, string> CurrentSelectedDataMap;

	// Token: 0x04005339 RID: 21305
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FilterItemData> CurrentFilterItemArray;

	// Token: 0x02006FA2 RID: 28578
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04024794 RID: 149396
		Title,
		// Token: 0x04024795 RID: 149397
		SelectAllToggleRootItem,
		// Token: 0x04024796 RID: 149398
		SelectAllToggle,
		// Token: 0x04024797 RID: 149399
		Layout,
		// Token: 0x04024798 RID: 149400
		FilterItem
	}
}
