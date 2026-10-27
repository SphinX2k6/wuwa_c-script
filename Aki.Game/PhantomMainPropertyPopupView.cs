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

// Token: 0x0200186B RID: 6251
[NullableContext(1)]
[Nullable(0)]
public class PhantomMainPropertyPopupView : UiViewBase
{
	// Token: 0x0600B762 RID: 46946 RVA: 0x00297540 File Offset: 0x00295740
	public PhantomMainPropertyPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B763 RID: 46947 RVA: 0x00297594 File Offset: 0x00295794
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

	// Token: 0x0600B764 RID: 46948 RVA: 0x0029778C File Offset: 0x0029598C
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomMainPropertyPopupView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomMainPropertyPopupView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B765 RID: 46949 RVA: 0x002977D0 File Offset: 0x002959D0
	protected override void OnStart()
	{
		this.LoadAllCostPropertiesData();
		this.LoadSavedSelections();
		IMainPropertyFilterViewData viewData = this.ViewData;
		int cost = (viewData != null) ? viewData.DefaultSelectCostTab : 4;
		this.SwitchToCost(cost);
	}

	// Token: 0x0600B766 RID: 46950 RVA: 0x00297804 File Offset: 0x00295A04
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

	// Token: 0x0600B767 RID: 46951 RVA: 0x002978B0 File Offset: 0x00295AB0
	private UniTask InitCostTabLayoutAsync()
	{
		PhantomMainPropertyPopupView.<InitCostTabLayoutAsync>d__14 <InitCostTabLayoutAsync>d__;
		<InitCostTabLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCostTabLayoutAsync>d__.<>4__this = this;
		<InitCostTabLayoutAsync>d__.<>1__state = -1;
		<InitCostTabLayoutAsync>d__.<>t__builder.Start<PhantomMainPropertyPopupView.<InitCostTabLayoutAsync>d__14>(ref <InitCostTabLayoutAsync>d__);
		return <InitCostTabLayoutAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B768 RID: 46952 RVA: 0x002978F4 File Offset: 0x00295AF4
	private void InitPropertyLayout()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(4);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		this.PropertyLayout = new GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData>(scrollViewWithScrollbar, new Func<PropertyToggleGridProxy>(this.CreatePropertyToggle), null, false, null);
	}

	// Token: 0x0600B769 RID: 46953 RVA: 0x00297928 File Offset: 0x00295B28
	private CostTabToggleGridProxy CreateCostTabToggle()
	{
		CostTabToggleGridProxy costTabToggleGridProxy = new CostTabToggleGridProxy();
		costTabToggleGridProxy.SetToggleFunction(new TCostTabToggleFunction(this.OnCostTabChanged));
		return costTabToggleGridProxy;
	}

	// Token: 0x0600B76A RID: 46954 RVA: 0x00297941 File Offset: 0x00295B41
	private PropertyToggleGridProxy CreatePropertyToggle()
	{
		PropertyToggleGridProxy propertyToggleGridProxy = new PropertyToggleGridProxy();
		propertyToggleGridProxy.SetToggleFunction(new TPropertyToggleFunction(this.OnPropertyToggleChanged));
		return propertyToggleGridProxy;
	}

	// Token: 0x0600B76B RID: 46955 RVA: 0x0029795A File Offset: 0x00295B5A
	private void OnCostTabChanged(int cost)
	{
		this.SwitchToCost(cost);
	}

	// Token: 0x0600B76C RID: 46956 RVA: 0x00297963 File Offset: 0x00295B63
	private void SwitchToCost(int cost)
	{
		this.CurrentCost = cost;
		this.UpdateTabHighlight();
		this.LoadPropertiesForCurrentCost();
		this.UpdateSelectAllToggle();
		this.UpdateTabMarks();
	}

	// Token: 0x0600B76D RID: 46957 RVA: 0x00297984 File Offset: 0x00295B84
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

	// Token: 0x0600B76E RID: 46958 RVA: 0x002979F4 File Offset: 0x00295BF4
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

	// Token: 0x0600B76F RID: 46959 RVA: 0x00297B04 File Offset: 0x00295D04
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

	// Token: 0x0600B770 RID: 46960 RVA: 0x00297B98 File Offset: 0x00295D98
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

	// Token: 0x0600B771 RID: 46961 RVA: 0x00297C84 File Offset: 0x00295E84
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

	// Token: 0x0600B772 RID: 46962 RVA: 0x00297CC8 File Offset: 0x00295EC8
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

	// Token: 0x0600B773 RID: 46963 RVA: 0x00297D64 File Offset: 0x00295F64
	private void OnPropertyToggleChanged(bool isChecked, int filterId, string content)
	{
		this.SetCostSelection(filterId, isChecked, content);
		this.UpdateSelectAllToggle();
		this.UpdateTabMarks();
	}

	// Token: 0x0600B774 RID: 46964 RVA: 0x00297D7C File Offset: 0x00295F7C
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

	// Token: 0x0600B775 RID: 46965 RVA: 0x00297E14 File Offset: 0x00296014
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

	// Token: 0x0600B776 RID: 46966 RVA: 0x00297EBC File Offset: 0x002960BC
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

	// Token: 0x0600B777 RID: 46967 RVA: 0x00297F38 File Offset: 0x00296138
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

	// Token: 0x0600B778 RID: 46968 RVA: 0x0029802C File Offset: 0x0029622C
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

	// Token: 0x040052BE RID: 21182
	[Nullable(2)]
	private PhantomManagerConfigNewElementItem ElementItem;

	// Token: 0x040052BF RID: 21183
	[Nullable(2)]
	private IMainPropertyFilterViewData ViewData;

	// Token: 0x040052C0 RID: 21184
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CostTabToggleGridProxy, int> CostTabLayout;

	// Token: 0x040052C1 RID: 21185
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<PropertyToggleGridProxy, FilterItemData> PropertyLayout;

	// Token: 0x040052C2 RID: 21186
	private int CurrentCost = 4;

	// Token: 0x040052C3 RID: 21187
	private readonly Dictionary<int, Dictionary<int, string>> CostSelectionMap = new Dictionary<int, Dictionary<int, string>>();

	// Token: 0x040052C4 RID: 21188
	private readonly List<int> CostList = new List<int>
	{
		4,
		3,
		1
	};

	// Token: 0x040052C5 RID: 21189
	private readonly Dictionary<int, List<FilterItemData>> CostPropertyDataMap = new Dictionary<int, List<FilterItemData>>();

	// Token: 0x02007E2E RID: 32302
	[NullableContext(0)]
	private class EFilterPropertyPopupComponents
	{
		// Token: 0x040294BB RID: 169147
		public const int PanelTabTogLayout = 0;

		// Token: 0x040294BC RID: 169148
		public const int TogTopTabItemFilter = 1;

		// Token: 0x040294BD RID: 169149
		public const int UiItemFilterGridS2 = 2;

		// Token: 0x040294BE RID: 169150
		public const int TogSelectAll = 3;

		// Token: 0x040294BF RID: 169151
		public const int PropertyLayout = 4;

		// Token: 0x040294C0 RID: 169152
		public const int TogItemProperty = 5;

		// Token: 0x040294C1 RID: 169153
		public const int BtnReset = 6;

		// Token: 0x040294C2 RID: 169154
		public const int BtnConfirm = 7;

		// Token: 0x040294C3 RID: 169155
		public const int PanelElementIcon = 8;

		// Token: 0x040294C4 RID: 169156
		public const int TxtAll = 9;
	}
}
