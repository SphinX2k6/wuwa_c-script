using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x02000D24 RID: 3364
[NullableContext(1)]
[Nullable(0)]
public class PhantomMainPropertyPopupView : UiViewBase
{
	// Token: 0x06008B4B RID: 35659 RVA: 0x002A1C64 File Offset: 0x0029FE64
	public PhantomMainPropertyPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008B4C RID: 35660 RVA: 0x002A1CB8 File Offset: 0x0029FEB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleSelectAll));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickReset));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008B4D RID: 35661 RVA: 0x002A1EB0 File Offset: 0x002A00B0
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomMainPropertyPopupView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomMainPropertyPopupView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008B4E RID: 35662 RVA: 0x002A1EF4 File Offset: 0x002A00F4
	protected override void OnStart()
	{
		this.LoadAllCostPropertiesData();
		this.LoadSavedSelections();
		IMainPropertyFilterViewData viewData = this.ViewData;
		int cost = (viewData != null) ? viewData.DefaultSelectCostTab : 4;
		this.SwitchToCost(cost);
	}

	// Token: 0x06008B4F RID: 35663 RVA: 0x002A1F28 File Offset: 0x002A0128
	private void InitFetterConfigShow()
	{
		IMainPropertyFilterViewData viewData = this.ViewData;
		bool flag = viewData != null && viewData.CurrentFetterId != null;
		PhantomManagerConfigNewElementItem elementItem = this.ElementItem;
		if (elementItem != null)
		{
			elementItem.SetUiActive(flag);
		}
		if (flag)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(this.ViewData.CurrentFetterId.Value);
			PhantomManagerConfigNewElementItem elementItem2 = this.ElementItem;
			if (elementItem2 != null)
			{
				elementItem2.Refresh(fetterGroupById.FetterElementPath);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "PhantomFilterSonataTips_1", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "PhantomFilterSonataTips_2", Array.Empty<object>());
	}

	// Token: 0x06008B50 RID: 35664 RVA: 0x002A1FD4 File Offset: 0x002A01D4
	private UniTask InitCostTabLayoutAsync()
	{
		PhantomMainPropertyPopupView.<InitCostTabLayoutAsync>d__14 <InitCostTabLayoutAsync>d__;
		<InitCostTabLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostTabLayoutAsync>d__.<>4__this = this;
		<InitCostTabLayoutAsync>d__.<>1__state = -1;
		<InitCostTabLayoutAsync>d__.<>t__builder.Start<PhantomMainPropertyPopupView.<InitCostTabLayoutAsync>d__14>(ref <InitCostTabLayoutAsync>d__);
		return <InitCostTabLayoutAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008B51 RID: 35665 RVA: 0x002A2018 File Offset: 0x002A0218
	private void InitPropertyLayout()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		this.PropertyLayout = new GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData>(scrollViewWithScrollbar, new Func<PropertyToggleGridProxy>(this.CreatePropertyToggle), null, false, null);
	}

	// Token: 0x06008B52 RID: 35666 RVA: 0x002A204C File Offset: 0x002A024C
	private CostTabToggleGridProxy CreateCostTabToggle()
	{
		CostTabToggleGridProxy costTabToggleGridProxy = new CostTabToggleGridProxy();
		costTabToggleGridProxy.SetToggleFunction(new TCostTabToggleFunction(this.OnCostTabChanged));
		return costTabToggleGridProxy;
	}

	// Token: 0x06008B53 RID: 35667 RVA: 0x002A2065 File Offset: 0x002A0265
	private PropertyToggleGridProxy CreatePropertyToggle()
	{
		PropertyToggleGridProxy propertyToggleGridProxy = new PropertyToggleGridProxy();
		propertyToggleGridProxy.SetToggleFunction(new TPropertyToggleFunction(this.OnPropertyToggleChanged));
		return propertyToggleGridProxy;
	}

	// Token: 0x06008B54 RID: 35668 RVA: 0x002A207E File Offset: 0x002A027E
	private void OnCostTabChanged(int cost)
	{
		this.SwitchToCost(cost);
	}

	// Token: 0x06008B55 RID: 35669 RVA: 0x002A2087 File Offset: 0x002A0287
	private void SwitchToCost(int cost)
	{
		this.CurrentCost = cost;
		this.UpdateTabHighlight();
		this.LoadPropertiesForCurrentCost();
		this.UpdateSelectAllToggle();
		this.UpdateTabMarks();
	}

	// Token: 0x06008B56 RID: 35670 RVA: 0x002A20A8 File Offset: 0x002A02A8
	private void UpdateTabHighlight()
	{
		GenericLayout<CostTabToggleGridProxy, int> costTabLayout = this.CostTabLayout;
		List<CostTabToggleGridProxy> list = (costTabLayout != null) ? costTabLayout.GetLayoutItemList() : null;
		if (list != null)
		{
			foreach (CostTabToggleGridProxy costTabToggleGridProxy in list)
			{
				costTabToggleGridProxy.SetSelectedState(costTabToggleGridProxy.Cost == this.CurrentCost);
			}
		}
	}

	// Token: 0x06008B57 RID: 35671 RVA: 0x002A2118 File Offset: 0x002A0318
	private void LoadSavedSelections()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		if (filterResultData == null)
		{
			return;
		}
		Dictionary<int, string> selectRuleDataById = filterResultData.GetSelectRuleDataById(FilterDefine.EFilterType.VisionDestroyAttribute);
		if (selectRuleDataById == null)
		{
			return;
		}
		this.CostSelectionMap.Clear();
		foreach (KeyValuePair<int, string> keyValuePair in selectRuleDataById)
		{
			int key = keyValuePair.Key;
			string value = keyValuePair.Value;
			foreach (int key2 in FilterConfig.Instance.GetCostByMainMainProp(key))
			{
				if (!this.CostSelectionMap.ContainsKey(key2))
				{
					this.CostSelectionMap[key2] = new Dictionary<int, string>();
				}
				this.CostSelectionMap[key2][key] = value;
			}
		}
		this.UpdateTabMarks();
	}

	// Token: 0x06008B58 RID: 35672 RVA: 0x002A2228 File Offset: 0x002A0428
	private void UpdateTabMarks()
	{
		GenericLayout<CostTabToggleGridProxy, int> costTabLayout = this.CostTabLayout;
		List<CostTabToggleGridProxy> list = (costTabLayout != null) ? costTabLayout.GetLayoutItemList() : null;
		if (list != null)
		{
			foreach (CostTabToggleGridProxy costTabToggleGridProxy in list)
			{
				bool markVisible = this.CostSelectionMap.ContainsKey(costTabToggleGridProxy.Cost) && this.CostSelectionMap[costTabToggleGridProxy.Cost].Count > 0;
				costTabToggleGridProxy.SetMarkVisible(markVisible);
			}
		}
	}

	// Token: 0x06008B59 RID: 35673 RVA: 0x002A22BC File Offset: 0x002A04BC
	private void LoadAllCostPropertiesData()
	{
		foreach (int num in this.CostList)
		{
			if (!this.CostPropertyDataMap.ContainsKey(num))
			{
				IEnumerable<int> mainPropIdsByCost = FilterConfig.Instance.GetMainPropIdsByCost(num);
				List<FilterItemData> list = new List<FilterItemData>();
				foreach (int num2 in mainPropIdsByCost)
				{
					string sortRuleName = SortConfig.Instance.GetSortRuleName(num2, ESortDataType.Phantom);
					int sortRuleAttributeId = SortConfig.Instance.GetSortRuleAttributeId(num2, ESortDataType.Phantom);
					string propertyIndexIcon = PropertyIndexConfig.Instance.GetPropertyIndexIcon(sortRuleAttributeId);
					list.Add(new FilterItemData(num2, sortRuleName, propertyIndexIcon));
				}
				this.CostPropertyDataMap[num] = list;
			}
		}
	}

	// Token: 0x06008B5A RID: 35674 RVA: 0x002A23A8 File Offset: 0x002A05A8
	private void LoadPropertiesForCurrentCost()
	{
		List<FilterItemData> data;
		if (!this.CostPropertyDataMap.TryGetValue(this.CurrentCost, out data))
		{
			return;
		}
		GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData> propertyLayout = this.PropertyLayout;
		if (propertyLayout == null)
		{
			return;
		}
		propertyLayout.RefreshByData(data, new Action(this.RestoreCurrentCostSelection), false);
	}

	// Token: 0x06008B5B RID: 35675 RVA: 0x002A23EC File Offset: 0x002A05EC
	private void RestoreCurrentCostSelection()
	{
		Dictionary<int, string> dictionary;
		this.CostSelectionMap.TryGetValue(this.CurrentCost, out dictionary);
		GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData> propertyLayout = this.PropertyLayout;
		List<PropertyToggleGridProxy> list = (propertyLayout != null) ? propertyLayout.GetScrollItemList() : null;
		if (list != null)
		{
			foreach (PropertyToggleGridProxy propertyToggleGridProxy in list)
			{
				bool flag;
				if (dictionary != null)
				{
					Dictionary<int, string> dictionary2 = dictionary;
					FilterItemData data = propertyToggleGridProxy.Data;
					flag = dictionary2.ContainsKey((data != null) ? data.FilterId : 0);
				}
				else
				{
					flag = false;
				}
				bool selectedState = flag;
				propertyToggleGridProxy.SetSelectedState(selectedState);
			}
		}
	}

	// Token: 0x06008B5C RID: 35676 RVA: 0x002A2488 File Offset: 0x002A0688
	private void OnPropertyToggleChanged(bool isChecked, int filterId, string content)
	{
		this.SetCostSelection(filterId, isChecked, content);
		this.UpdateSelectAllToggle();
		this.UpdateTabMarks();
	}

	// Token: 0x06008B5D RID: 35677 RVA: 0x002A24A0 File Offset: 0x002A06A0
	private void OnToggleSelectAll(EToggleState state)
	{
		bool flag = state == EToggleState.ETT_Checked;
		GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData> propertyLayout = this.PropertyLayout;
		List<PropertyToggleGridProxy> list = (propertyLayout != null) ? propertyLayout.GetScrollItemList() : null;
		if (list == null)
		{
			return;
		}
		foreach (PropertyToggleGridProxy propertyToggleGridProxy in list)
		{
			this.SetCostSelection(propertyToggleGridProxy.Data.FilterId, flag, propertyToggleGridProxy.Data.Content ?? "");
			propertyToggleGridProxy.SetSelectedState(flag);
		}
		this.UpdateTabMarks();
	}

	// Token: 0x06008B5E RID: 35678 RVA: 0x002A2538 File Offset: 0x002A0738
	private void UpdateSelectAllToggle()
	{
		Dictionary<int, string> dictionary;
		this.CostSelectionMap.TryGetValue(this.CurrentCost, out dictionary);
		bool flag = true;
		List<FilterItemData> list;
		if (this.CostPropertyDataMap.TryGetValue(this.CurrentCost, out list))
		{
			foreach (FilterItemData filterItemData in list)
			{
				if (dictionary == null || !dictionary.ContainsKey(filterItemData.FilterId))
				{
					flag = false;
					break;
				}
			}
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x06008B5F RID: 35679 RVA: 0x002A25E0 File Offset: 0x002A07E0
	private void OnClickReset()
	{
		this.CostSelectionMap.Clear();
		GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData> propertyLayout = this.PropertyLayout;
		List<PropertyToggleGridProxy> list = (propertyLayout != null) ? propertyLayout.GetScrollItemList() : null;
		if (list != null)
		{
			foreach (PropertyToggleGridProxy propertyToggleGridProxy in list)
			{
				propertyToggleGridProxy.SetSelectedState(false);
			}
		}
		this.UpdateSelectAllToggle();
		this.UpdateTabMarks();
	}

	// Token: 0x06008B60 RID: 35680 RVA: 0x002A265C File Offset: 0x002A085C
	private void OnClickConfirm()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		foreach (Dictionary<int, string> dictionary2 in this.CostSelectionMap.Values)
		{
			foreach (KeyValuePair<int, string> keyValuePair in dictionary2)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		if (filterResultData != null)
		{
			filterResultData.SetSelectRuleData(FilterDefine.EFilterType.VisionDestroyAttribute, dictionary);
		}
		IMainPropertyFilterViewData viewData = this.ViewData;
		if (viewData != null)
		{
			Action confirmFunction = viewData.ConfirmFunction;
			if (confirmFunction != null)
			{
				confirmFunction();
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x06008B61 RID: 35681 RVA: 0x002A2750 File Offset: 0x002A0950
	private void SetCostSelection(int filterId, bool isSelected, string content)
	{
		foreach (int key in FilterConfig.Instance.GetCostByMainMainProp(filterId))
		{
			Dictionary<int, string> dictionary;
			if (!this.CostSelectionMap.TryGetValue(key, out dictionary))
			{
				dictionary = new Dictionary<int, string>();
				this.CostSelectionMap[key] = dictionary;
			}
			if (isSelected)
			{
				dictionary[filterId] = content;
			}
			else
			{
				dictionary.Remove(filterId);
			}
		}
	}

	// Token: 0x04005369 RID: 21353
	[Nullable(2)]
	private PhantomManagerConfigNewElementItem ElementItem;

	// Token: 0x0400536A RID: 21354
	[Nullable(2)]
	private IMainPropertyFilterViewData ViewData;

	// Token: 0x0400536B RID: 21355
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CostTabToggleGridProxy, int> CostTabLayout;

	// Token: 0x0400536C RID: 21356
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData> PropertyLayout;

	// Token: 0x0400536D RID: 21357
	private int CurrentCost = 4;

	// Token: 0x0400536E RID: 21358
	private readonly Dictionary<int, Dictionary<int, string>> CostSelectionMap = new Dictionary<int, Dictionary<int, string>>();

	// Token: 0x0400536F RID: 21359
	private readonly List<int> CostList = new List<int>
	{
		4,
		3,
		1
	};

	// Token: 0x04005370 RID: 21360
	private readonly Dictionary<int, List<FilterItemData>> CostPropertyDataMap = new Dictionary<int, List<FilterItemData>>();

	// Token: 0x02006FB5 RID: 28597
	[NullableContext(0)]
	private class EFilterPropertyPopupComponents
	{
		// Token: 0x040247E8 RID: 149480
		public const int PanelTabTogLayout = 0;

		// Token: 0x040247E9 RID: 149481
		public const int TogTopTabItemFilter = 1;

		// Token: 0x040247EA RID: 149482
		public const int UiItemFilterGridS2 = 2;

		// Token: 0x040247EB RID: 149483
		public const int TogSelectAll = 3;

		// Token: 0x040247EC RID: 149484
		public const int PropertyLayout = 4;

		// Token: 0x040247ED RID: 149485
		public const int TogItemProperty = 5;

		// Token: 0x040247EE RID: 149486
		public const int BtnReset = 6;

		// Token: 0x040247EF RID: 149487
		public const int BtnConfirm = 7;

		// Token: 0x040247F0 RID: 149488
		public const int PanelElementIcon = 8;

		// Token: 0x040247F1 RID: 149489
		public const int TxtAll = 9;
	}
}
