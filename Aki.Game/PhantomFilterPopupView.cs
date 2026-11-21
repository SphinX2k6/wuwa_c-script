using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x02000D1D RID: 3357
[NullableContext(1)]
[Nullable(0)]
public class PhantomFilterPopupView : UiViewBase
{
	// Token: 0x06008AFB RID: 35579 RVA: 0x002A0620 File Offset: 0x0029E820
	public PhantomFilterPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008AFC RID: 35580 RVA: 0x002A0648 File Offset: 0x0029E848
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickAddMainProperty));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnReset));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008AFD RID: 35581 RVA: 0x002A0888 File Offset: 0x0029EA88
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomFilterPopupView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomFilterPopupView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008AFE RID: 35582 RVA: 0x002A08CC File Offset: 0x0029EACC
	protected override void OnStart()
	{
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		this.InitDropDown();
		this.LoadFilterData();
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = (filterResultData != null) ? filterResultData.GetSelectRuleDataById(FilterDefine.EFilterType.PhantomManageFirstMainProp) : null;
		if (dictionary != null && dictionary.Count > 0)
		{
			this.MainAttributeFilterType = FilterDefine.EFilterType.PhantomManageFirstMainProp;
		}
		this.LoadMainPropertiesData();
		this.UpdateQuickButtonState();
		this.UpdateFilterCount();
		this.InitState = true;
	}

	// Token: 0x06008AFF RID: 35583 RVA: 0x002A0952 File Offset: 0x0029EB52
	protected override void OnBeforeDestroy()
	{
		CommonDropDown<int, int> commonDropDown = this.CommonDropDown;
		if (commonDropDown != null)
		{
			commonDropDown.Destroy(null);
		}
		this.CommonDropDown = null;
	}

	// Token: 0x06008B00 RID: 35584 RVA: 0x002A096D File Offset: 0x0029EB6D
	protected override void OnBeforeShow()
	{
		this.UpdateFilterAnimation();
	}

	// Token: 0x06008B01 RID: 35585 RVA: 0x002A0976 File Offset: 0x0029EB76
	private void OnClickClose()
	{
		Action onFilterViewClose = this.ViewData.OnFilterViewClose;
		if (onFilterViewClose != null)
		{
			onFilterViewClose();
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x06008B02 RID: 35586 RVA: 0x002A09A4 File Offset: 0x0029EBA4
	private void OnFilterConfirm()
	{
		Action confirmFunction = this.ViewData.ConfirmFunction;
		if (confirmFunction != null)
		{
			confirmFunction();
		}
		this.UpdateQuickButtonState();
		if (!this.UpdateFilterAnimation())
		{
			this.UpdateFilterCount();
		}
	}

	// Token: 0x06008B03 RID: 35587 RVA: 0x002A09D0 File Offset: 0x0029EBD0
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName != "Sequence_Change_Number")
		{
			return;
		}
		this.UpdateFilterCount();
	}

	// Token: 0x06008B04 RID: 35588 RVA: 0x002A09E8 File Offset: 0x0029EBE8
	private void UpdateFilterCount()
	{
		List<IPhantomFilterData> filteredPhantomList = this.GetFilteredPhantomList();
		UUIText text = base.GetText(8);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "PhantomFilterCount", new <>z__ReadOnlySingleElementList<object>(filteredPhantomList.Count));
		}
	}

	// Token: 0x06008B05 RID: 35589 RVA: 0x002A0A28 File Offset: 0x0029EC28
	private bool CheckHasFilter()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		if (filterResultData == null)
		{
			return false;
		}
		using (Dictionary<FilterDefine.EFilterType, Dictionary<int, string>>.ValueCollection.Enumerator enumerator = filterResultData.GetSelectRuleData().Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Count > 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06008B06 RID: 35590 RVA: 0x002A0AA4 File Offset: 0x0029ECA4
	private bool UpdateFilterAnimation()
	{
		bool flag = this.CheckHasFilter();
		if (flag != this.LastHasFilter)
		{
			this.LastHasFilter = flag;
			if (!flag)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence("filtrate_Out", false, null);
				}
				return true;
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 != null)
			{
				uiViewSequence2.PlaySequence("filtrate_In", false, null);
			}
		}
		return false;
	}

	// Token: 0x06008B07 RID: 35591 RVA: 0x002A0B10 File Offset: 0x0029ED10
	private void OnClickBtnReset()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		if (filterResultData == null)
		{
			return;
		}
		filterResultData.ClearSelectRuleData();
		this.LoadFilterData();
		this.LoadMainPropertiesData();
		if (this.CurrentSelectSuitIndex != 0)
		{
			this.CurrentSelectSuitIndex = 0;
			CommonDropDown<int, int> commonDropDown = this.CommonDropDown;
			if (commonDropDown != null)
			{
				commonDropDown.SetSelectedIndex(0, true);
			}
		}
		else
		{
			Action confirmFunction = this.ViewData.ConfirmFunction;
			if (confirmFunction != null)
			{
				confirmFunction();
			}
		}
		this.UpdateQuickButtonState();
		this.UpdateFilterAnimation();
	}

	// Token: 0x06008B08 RID: 35592 RVA: 0x002A0B90 File Offset: 0x0029ED90
	private void InitQualityLayout()
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
		if (horizontalLayout == null)
		{
			return;
		}
		this.QualityLayout = new GenericLayout<QualityToggleGridProxy, FilterItemData>(horizontalLayout, new Func<QualityToggleGridProxy>(this.CreateQualityToggle), null, false, true);
	}

	// Token: 0x06008B09 RID: 35593 RVA: 0x002A0BC4 File Offset: 0x0029EDC4
	private void InitStateLayout()
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(1);
		if (horizontalLayout == null)
		{
			return;
		}
		this.StateLayout = new GenericLayout<StateToggleGridProxy, FilterItemData>(horizontalLayout, new Func<StateToggleGridProxy>(this.CreateStateToggle), null, false, true);
	}

	// Token: 0x06008B0A RID: 35594 RVA: 0x002A0BF8 File Offset: 0x0029EDF8
	private void InitMainPropertiesLayout()
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(6);
		if (verticalLayout == null)
		{
			return;
		}
		this.MainPropertiesLayout = new GenericLayout<MainPropertyItem, FilterItemData>(verticalLayout, new Func<MainPropertyItem>(this.CreateMainPropertyItem), null, false, true);
	}

	// Token: 0x06008B0B RID: 35595 RVA: 0x002A0C2C File Offset: 0x0029EE2C
	private QualityToggleGridProxy CreateQualityToggle()
	{
		QualityToggleGridProxy qualityToggleGridProxy = new QualityToggleGridProxy();
		qualityToggleGridProxy.SetToggleFunction(new TQualityToggleFunction(this.OnQualityToggleChanged));
		return qualityToggleGridProxy;
	}

	// Token: 0x06008B0C RID: 35596 RVA: 0x002A0C45 File Offset: 0x0029EE45
	private StateToggleGridProxy CreateStateToggle()
	{
		StateToggleGridProxy stateToggleGridProxy = new StateToggleGridProxy();
		stateToggleGridProxy.SetToggleFunction(new TQualityToggleFunction(this.OnStateToggleChanged));
		return stateToggleGridProxy;
	}

	// Token: 0x06008B0D RID: 35597 RVA: 0x002A0C5E File Offset: 0x0029EE5E
	private MainPropertyItem CreateMainPropertyItem()
	{
		MainPropertyItem mainPropertyItem = new MainPropertyItem();
		mainPropertyItem.SetDeleteCallback(new Action<int>(this.OnDeleteMainProperty));
		return mainPropertyItem;
	}

	// Token: 0x06008B0E RID: 35598 RVA: 0x002A0C78 File Offset: 0x0029EE78
	private void OnQualityToggleChanged(bool isChecked, int filterId, string content)
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = filterResultData.GetSelectRuleDataById(FilterDefine.EFilterType.VisionDestroyQuality) ?? new Dictionary<int, string>();
		if (isChecked)
		{
			dictionary[filterId] = content;
		}
		else
		{
			dictionary.Remove(filterId);
		}
		filterResultData.SetSelectRuleData(FilterDefine.EFilterType.VisionDestroyQuality, dictionary);
		this.OnFilterConfirm();
	}

	// Token: 0x06008B0F RID: 35599 RVA: 0x002A0CD0 File Offset: 0x0029EED0
	private void OnStateToggleChanged(bool isChecked, int filterId, string content)
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = ((filterResultData != null) ? filterResultData.GetSelectRuleDataById(FilterDefine.EFilterType.PhantomDeprecate) : null) ?? new Dictionary<int, string>();
		dictionary.Clear();
		if (isChecked)
		{
			dictionary[filterId] = content;
		}
		filterResultData.SetSelectRuleData(FilterDefine.EFilterType.PhantomDeprecate, dictionary);
		if (this.StateLayout != null)
		{
			foreach (StateToggleGridProxy stateToggleGridProxy in this.StateLayout.GetLayoutItemList())
			{
				FilterItemData data = stateToggleGridProxy.Data;
				if (data != null && data.FilterId == filterId && isChecked)
				{
					stateToggleGridProxy.SetSelectedState(true);
				}
				else
				{
					stateToggleGridProxy.SetSelectedState(false);
				}
			}
		}
		this.OnFilterConfirm();
	}

	// Token: 0x06008B10 RID: 35600 RVA: 0x002A0DA0 File Offset: 0x0029EFA0
	private void OnClickAddMainProperty()
	{
		int defaultSelectCostTab = 4;
		EFilterSortGroupId groupId = this.ViewData.GroupId;
		if (groupId != EFilterSortGroupId.VisionRefineMainCost3C)
		{
			if (groupId == EFilterSortGroupId.VisionRefineMainCost1C)
			{
				defaultSelectCostTab = 1;
			}
		}
		else
		{
			defaultSelectCostTab = 3;
		}
		int num = this.FetterSuitFilterArray[this.CurrentSelectSuitIndex];
		MainPropertyFilterViewData param = new MainPropertyFilterViewData
		{
			UniqueId = this.ViewData.UniqueId,
			DefaultSelectCostTab = defaultSelectCostTab,
			ConfirmFunction = delegate
			{
				this.LoadMainPropertiesData();
				this.OnFilterConfirm();
			},
			CurrentFetterId = ((num == 0) ? null : new int?(num))
		};
		UiManager.Instance.OpenView(EUiViewName.PhantomMainPropertyPopupView, param, null);
	}

	// Token: 0x06008B11 RID: 35601 RVA: 0x002A0E3C File Offset: 0x0029F03C
	private void OnDeleteMainProperty(int filterId)
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = ((filterResultData != null) ? filterResultData.GetSelectRuleDataById(this.MainAttributeFilterType) : null) ?? new Dictionary<int, string>();
		dictionary.Remove(filterId);
		filterResultData.SetSelectRuleData(this.MainAttributeFilterType, dictionary);
		this.LoadMainPropertiesData();
		this.OnFilterConfirm();
	}

	// Token: 0x06008B12 RID: 35602 RVA: 0x002A0E9C File Offset: 0x0029F09C
	private void LoadFilterData()
	{
		FilterResultData resultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		if (resultData == null)
		{
			return;
		}
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(resultData.ConfigId);
		if (filterConfig == null)
		{
			return;
		}
		int[] array = filterConfig.Value.RuleList();
		int? num = null;
		foreach (int num2 in array)
		{
			if (FilterConfig.Instance.GetFilterRuleConfig(num2).Value.FilterType == 24)
			{
				num = new int?(num2);
				break;
			}
		}
		if (num != null)
		{
			List<FilterItemData> filterItemDataList = FilterModel.Instance.GetFilterItemDataList(num.Value, resultData.ConfigId);
			if (filterItemDataList != null && filterItemDataList.Count > 0)
			{
				GenericLayout<QualityToggleGridProxy, FilterItemData> qualityLayout = this.QualityLayout;
				if (qualityLayout != null)
				{
					qualityLayout.RefreshByData(filterItemDataList, delegate
					{
						Dictionary<int, string> selectRuleDataById = resultData.GetSelectRuleDataById(FilterDefine.EFilterType.VisionDestroyQuality);
						GenericLayout<QualityToggleGridProxy, FilterItemData> qualityLayout2 = this.QualityLayout;
						List<QualityToggleGridProxy> list = (qualityLayout2 != null) ? qualityLayout2.GetLayoutItemList() : null;
						if (list != null)
						{
							foreach (QualityToggleGridProxy qualityToggleGridProxy in list)
							{
								if (selectRuleDataById != null)
								{
									Dictionary<int, string> dictionary = selectRuleDataById;
									FilterItemData data = qualityToggleGridProxy.Data;
									if (dictionary.ContainsKey((data != null) ? data.FilterId : 0))
									{
										qualityToggleGridProxy.SetSelectedState(true);
										continue;
									}
								}
								qualityToggleGridProxy.SetSelectedState(false);
							}
						}
					}, false);
				}
			}
		}
		int? num3 = null;
		foreach (int num4 in array)
		{
			if (FilterConfig.Instance.GetFilterRuleConfig(num4).Value.FilterType == 28)
			{
				num3 = new int?(num4);
				break;
			}
		}
		if (num3 != null)
		{
			List<FilterItemData> filterItemDataList2 = FilterModel.Instance.GetFilterItemDataList(num3.Value, resultData.ConfigId);
			if (filterItemDataList2 != null && filterItemDataList2.Count > 0)
			{
				GenericLayout<StateToggleGridProxy, FilterItemData> stateLayout = this.StateLayout;
				if (stateLayout == null)
				{
					return;
				}
				stateLayout.RefreshByData(filterItemDataList2, delegate
				{
					Dictionary<int, string> selectRuleDataById = resultData.GetSelectRuleDataById(FilterDefine.EFilterType.PhantomDeprecate);
					GenericLayout<StateToggleGridProxy, FilterItemData> stateLayout2 = this.StateLayout;
					List<StateToggleGridProxy> list = (stateLayout2 != null) ? stateLayout2.GetLayoutItemList() : null;
					if (list != null)
					{
						foreach (StateToggleGridProxy stateToggleGridProxy in list)
						{
							if (selectRuleDataById != null)
							{
								Dictionary<int, string> dictionary = selectRuleDataById;
								FilterItemData data = stateToggleGridProxy.Data;
								if (dictionary.ContainsKey((data != null) ? data.FilterId : 0))
								{
									stateToggleGridProxy.SetSelectedState(true);
									continue;
								}
							}
							stateToggleGridProxy.SetSelectedState(false);
						}
					}
				}, false);
			}
		}
	}

	// Token: 0x06008B13 RID: 35603 RVA: 0x002A1058 File Offset: 0x0029F258
	private void LoadMainPropertiesData()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		if (filterResultData == null)
		{
			return;
		}
		Dictionary<int, string> selectRuleDataById = filterResultData.GetSelectRuleDataById(this.MainAttributeFilterType);
		List<FilterItemData> list = new List<FilterItemData>();
		if (selectRuleDataById != null)
		{
			foreach (KeyValuePair<int, string> keyValuePair in selectRuleDataById)
			{
				list.Add(new FilterItemData(keyValuePair.Key, keyValuePair.Value, null));
			}
		}
		GenericLayout<MainPropertyItem, FilterItemData> mainPropertiesLayout = this.MainPropertiesLayout;
		if (mainPropertiesLayout == null)
		{
			return;
		}
		mainPropertiesLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06008B14 RID: 35604 RVA: 0x002A1100 File Offset: 0x0029F300
	private UniTask InitSuitFilter()
	{
		PhantomFilterPopupView.<InitSuitFilter>d__40 <InitSuitFilter>d__;
		<InitSuitFilter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSuitFilter>d__.<>4__this = this;
		<InitSuitFilter>d__.<>1__state = -1;
		<InitSuitFilter>d__.<>t__builder.Start<PhantomFilterPopupView.<InitSuitFilter>d__40>(ref <InitSuitFilter>d__);
		return <InitSuitFilter>d__.<>t__builder.Task;
	}

	// Token: 0x06008B15 RID: 35605 RVA: 0x002A1144 File Offset: 0x0029F344
	private void InitDropDown()
	{
		IEnumerable<PhantomFetterGroup> fetterGroupArray = PhantomBattleConfig.Instance.GetFetterGroupArray();
		this.FetterSortIdMap.Clear();
		this.FetterSuitFilterArray.Clear();
		foreach (PhantomFetterGroup phantomFetterGroup in fetterGroupArray)
		{
			this.FetterSuitFilterArray.Add(phantomFetterGroup.Id);
			this.FetterSortIdMap[phantomFetterGroup.Id] = phantomFetterGroup.SortId;
		}
		this.FetterSuitFilterArray.Sort((int a, int b) => this.FetterSortIdMap[b] - this.FetterSortIdMap[a]);
		this.FetterSuitFilterArray.Insert(0, 0);
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = (filterResultData != null) ? filterResultData.GetSelectRuleDataById(FilterDefine.EFilterType.VisionDestroyFetterGroup) : null;
		if (dictionary != null && dictionary.Count > 0)
		{
			int item = 0;
			using (Dictionary<int, string>.Enumerator enumerator2 = dictionary.GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					KeyValuePair<int, string> keyValuePair = enumerator2.Current;
					item = keyValuePair.Key;
				}
			}
			int num = this.FetterSuitFilterArray.IndexOf(item);
			if (num != -1)
			{
				this.CurrentSelectSuitIndex = num;
			}
		}
		else
		{
			this.CurrentSelectSuitIndex = 0;
		}
		this.CommonDropDown.SetOnSelectCall(new Action<int, int>(this.OnDropDownSelectCall));
		this.CommonDropDown.SetShowType(ECommonDropDownShowType.Down);
		this.CommonDropDown.InitScroll(this.FetterSuitFilterArray, new Func<int, int>(this.GetDropDownTextId), this.CurrentSelectSuitIndex, true);
	}

	// Token: 0x06008B16 RID: 35606 RVA: 0x002A12D4 File Offset: 0x0029F4D4
	private void OnDropDownSelectCall(int index, int data)
	{
		this.CurrentSelectSuitIndex = index;
		if (!this.InitState)
		{
			return;
		}
		this.UpdateSuitFilter();
		this.OnFilterConfirm();
	}

	// Token: 0x06008B17 RID: 35607 RVA: 0x002A12F2 File Offset: 0x0029F4F2
	private int GetDropDownTextId(int data)
	{
		return data;
	}

	// Token: 0x06008B18 RID: 35608 RVA: 0x002A12F5 File Offset: 0x0029F4F5
	private VisionEquipmentDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
	{
		return new VisionEquipmentDropDownItem(uiItem);
	}

	// Token: 0x06008B19 RID: 35609 RVA: 0x002A12FD File Offset: 0x0029F4FD
	private VisionEquipmentDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new VisionEquipmentDropDownTitleItem(uiItem);
	}

	// Token: 0x06008B1A RID: 35610 RVA: 0x002A1308 File Offset: 0x0029F508
	private void UpdateSuitFilter()
	{
		int num = this.FetterSuitFilterArray[this.CurrentSelectSuitIndex];
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = ((filterResultData != null) ? filterResultData.GetSelectRuleDataById(FilterDefine.EFilterType.VisionDestroyFetterGroup) : null) ?? new Dictionary<int, string>();
		dictionary.Clear();
		if (num > 0)
		{
			PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(num);
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(fetterGroupById.FetterGroupName, "");
			dictionary[num] = multiTextByKey;
		}
		filterResultData.SetSelectRuleData(FilterDefine.EFilterType.VisionDestroyFetterGroup, dictionary);
	}

	// Token: 0x06008B1B RID: 35611 RVA: 0x002A1394 File Offset: 0x0029F594
	private InventoryDefine.EItemDataFunctionValue? CheckSelectStateSame()
	{
		List<IPhantomFilterData> filteredPhantomList = this.GetFilteredPhantomList();
		if (filteredPhantomList.Count == 0)
		{
			InventoryDefine.EItemDataFunctionValue? result = null;
			return result;
		}
		InventoryDefine.EItemDataFunctionValue? eitemDataFunctionValue = null;
		foreach (IPhantomFilterData phantomFilterData in filteredPhantomList)
		{
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(phantomFilterData.GetUniqueId());
			if (phantomItemData != null)
			{
				InventoryDefine.EItemDataFunctionValue functionValueType = phantomItemData.GetFunctionValueType();
				if (eitemDataFunctionValue == null)
				{
					eitemDataFunctionValue = new InventoryDefine.EItemDataFunctionValue?(functionValueType);
				}
				else
				{
					InventoryDefine.EItemDataFunctionValue eitemDataFunctionValue2 = functionValueType;
					InventoryDefine.EItemDataFunctionValue? result = eitemDataFunctionValue;
					if (!(eitemDataFunctionValue2 == result.GetValueOrDefault() & result != null))
					{
						result = null;
						return result;
					}
				}
			}
		}
		return eitemDataFunctionValue;
	}

	// Token: 0x06008B1C RID: 35612 RVA: 0x002A1458 File Offset: 0x0029F658
	private void UpdateQuickButtonState()
	{
		InventoryDefine.EItemDataFunctionValue? eitemDataFunctionValue = this.CheckSelectStateSame();
		if (eitemDataFunctionValue.GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Deprecate)
		{
			ButtonItem btnDiscardItem = this.BtnDiscardItem;
			if (btnDiscardItem != null)
			{
				btnDiscardItem.SetShowText("PhantomFilterQuickCancelDiscard");
			}
		}
		else
		{
			ButtonItem btnDiscardItem2 = this.BtnDiscardItem;
			if (btnDiscardItem2 != null)
			{
				btnDiscardItem2.SetShowText("PhantomFilterQuickDiscard");
			}
		}
		if (eitemDataFunctionValue.GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Lock)
		{
			ButtonItem btnLockItem = this.BtnLockItem;
			if (btnLockItem == null)
			{
				return;
			}
			btnLockItem.SetShowText("PhantomFilterQuickCancelLock");
			return;
		}
		else
		{
			ButtonItem btnLockItem2 = this.BtnLockItem;
			if (btnLockItem2 == null)
			{
				return;
			}
			btnLockItem2.SetShowText("PhantomFilterQuickLock");
			return;
		}
	}

	// Token: 0x06008B1D RID: 35613 RVA: 0x002A14D9 File Offset: 0x0029F6D9
	private List<IPhantomFilterData> GetFilteredPhantomList()
	{
		PhantomFilterViewData<IPhantomFilterData> viewData = this.ViewData;
		if (((viewData != null) ? viewData.GetFilteredDataListFunc : null) == null)
		{
			return new List<IPhantomFilterData>();
		}
		return this.ViewData.GetFilteredDataListFunc();
	}

	// Token: 0x06008B1E RID: 35614 RVA: 0x002A1508 File Offset: 0x0029F708
	private void OnClickBtnDiscard(int state)
	{
		bool isCancel = this.CheckSelectStateSame().GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Deprecate;
		List<IPhantomFilterData> filteredPhantomList = this.GetFilteredPhantomList();
		if (filteredPhantomList.Count == 0)
		{
			return;
		}
		List<int> uniqueIdList = new List<int>();
		foreach (IPhantomFilterData phantomFilterData in filteredPhantomList)
		{
			uniqueIdList.Add(phantomFilterData.GetUniqueId());
		}
		PhantomConfirmPopupViewData phantomConfirmPopupViewData = new PhantomConfirmPopupViewData();
		phantomConfirmPopupViewData.Title = (isCancel ? "PhantomFilterCancelDiscardConfirmTitle" : "PhantomFilterDiscardConfirmTitle");
		phantomConfirmPopupViewData.SubTitle = (isCancel ? "PhantomFilterCancelDiscardDisplayTips" : "PhantomFilterDiscardDisplayTips");
		phantomConfirmPopupViewData.PhantomUniqueIdList = uniqueIdList;
		phantomConfirmPopupViewData.OnLeft = delegate()
		{
		};
		phantomConfirmPopupViewData.OnMiddle = delegate()
		{
			this.ExecuteBatchDeprecate(uniqueIdList, !isCancel).ContinueWith(new Action(this.OnFilterConfirm));
		};
		phantomConfirmPopupViewData.LeftTxtKey = "PhantomFilterButtonText_Cancel";
		phantomConfirmPopupViewData.MiddleTxtKey = "PhantomFilterButtonText_Confirm";
		PhantomConfirmPopupViewData param = phantomConfirmPopupViewData;
		UiManager.Instance.OpenView(EUiViewName.PhantomBatchConfirmPopupView, param, null);
	}

	// Token: 0x06008B1F RID: 35615 RVA: 0x002A1648 File Offset: 0x0029F848
	private void OnClickBtnLock(int state)
	{
		bool isCancel = this.CheckSelectStateSame().GetValueOrDefault() == InventoryDefine.EItemDataFunctionValue.Lock;
		List<IPhantomFilterData> filteredPhantomList = this.GetFilteredPhantomList();
		if (filteredPhantomList.Count == 0)
		{
			return;
		}
		List<int> uniqueIdList = new List<int>();
		foreach (IPhantomFilterData phantomFilterData in filteredPhantomList)
		{
			uniqueIdList.Add(phantomFilterData.GetUniqueId());
		}
		PhantomConfirmPopupViewData phantomConfirmPopupViewData = new PhantomConfirmPopupViewData();
		phantomConfirmPopupViewData.Title = (isCancel ? "PhantomFilterCancelLockConfirmTitle" : "PhantomFilterLockConfirmTitle");
		phantomConfirmPopupViewData.SubTitle = (isCancel ? "PhantomFilterCancelLockDisplayTips" : "PhantomFilterLockDisplayTips");
		phantomConfirmPopupViewData.PhantomUniqueIdList = uniqueIdList;
		phantomConfirmPopupViewData.OnLeft = delegate()
		{
		};
		phantomConfirmPopupViewData.OnMiddle = delegate()
		{
			this.ExecuteBatchLock(uniqueIdList, !isCancel).ContinueWith(new Action(this.OnFilterConfirm));
		};
		phantomConfirmPopupViewData.LeftTxtKey = "PhantomFilterButtonText_Cancel";
		phantomConfirmPopupViewData.MiddleTxtKey = "PhantomFilterButtonText_Confirm";
		PhantomConfirmPopupViewData param = phantomConfirmPopupViewData;
		UiManager.Instance.OpenView(EUiViewName.PhantomBatchConfirmPopupView, param, null);
	}

	// Token: 0x06008B20 RID: 35616 RVA: 0x002A1788 File Offset: 0x0029F988
	private UniTask ExecuteBatchDeprecate(List<int> uniqueIdList, bool isDeprecate)
	{
		PhantomFilterPopupView.<ExecuteBatchDeprecate>d__52 <ExecuteBatchDeprecate>d__;
		<ExecuteBatchDeprecate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteBatchDeprecate>d__.uniqueIdList = uniqueIdList;
		<ExecuteBatchDeprecate>d__.isDeprecate = isDeprecate;
		<ExecuteBatchDeprecate>d__.<>1__state = -1;
		<ExecuteBatchDeprecate>d__.<>t__builder.Start<PhantomFilterPopupView.<ExecuteBatchDeprecate>d__52>(ref <ExecuteBatchDeprecate>d__);
		return <ExecuteBatchDeprecate>d__.<>t__builder.Task;
	}

	// Token: 0x06008B21 RID: 35617 RVA: 0x002A17D4 File Offset: 0x0029F9D4
	private UniTask ExecuteBatchLock(List<int> uniqueIdList, bool isLock)
	{
		PhantomFilterPopupView.<ExecuteBatchLock>d__53 <ExecuteBatchLock>d__;
		<ExecuteBatchLock>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteBatchLock>d__.uniqueIdList = uniqueIdList;
		<ExecuteBatchLock>d__.isLock = isLock;
		<ExecuteBatchLock>d__.<>1__state = -1;
		<ExecuteBatchLock>d__.<>t__builder.Start<PhantomFilterPopupView.<ExecuteBatchLock>d__53>(ref <ExecuteBatchLock>d__);
		return <ExecuteBatchLock>d__.<>t__builder.Task;
	}

	// Token: 0x04005352 RID: 21330
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private PhantomFilterViewData<IPhantomFilterData> ViewData;

	// Token: 0x04005353 RID: 21331
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<QualityToggleGridProxy, FilterItemData> QualityLayout;

	// Token: 0x04005354 RID: 21332
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<StateToggleGridProxy, FilterItemData> StateLayout;

	// Token: 0x04005355 RID: 21333
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MainPropertyItem, FilterItemData> MainPropertiesLayout;

	// Token: 0x04005356 RID: 21334
	[Nullable(2)]
	private CommonDropDown<int, int> CommonDropDown;

	// Token: 0x04005357 RID: 21335
	private readonly List<int> FetterSuitFilterArray = new List<int>();

	// Token: 0x04005358 RID: 21336
	private readonly Dictionary<int, int> FetterSortIdMap = new Dictionary<int, int>();

	// Token: 0x04005359 RID: 21337
	private int CurrentSelectSuitIndex;

	// Token: 0x0400535A RID: 21338
	[Nullable(2)]
	private ButtonItem BtnDiscardItem;

	// Token: 0x0400535B RID: 21339
	[Nullable(2)]
	private ButtonItem BtnLockItem;

	// Token: 0x0400535C RID: 21340
	[Nullable(2)]
	public PopupCaptionItem CaptionItem;

	// Token: 0x0400535D RID: 21341
	private bool InitState;

	// Token: 0x0400535E RID: 21342
	private bool LastHasFilter;

	// Token: 0x0400535F RID: 21343
	private FilterDefine.EFilterType MainAttributeFilterType = FilterDefine.EFilterType.VisionDestroyAttribute;

	// Token: 0x02006FAA RID: 28586
	[NullableContext(0)]
	private class EPhantomFilterComp
	{
		// Token: 0x040247B7 RID: 149431
		public const int Caption = 0;

		// Token: 0x040247B8 RID: 149432
		public const int StateLayout = 1;

		// Token: 0x040247B9 RID: 149433
		public const int QualityLayout = 2;

		// Token: 0x040247BA RID: 149434
		public const int TogQualityItem = 3;

		// Token: 0x040247BB RID: 149435
		public const int SuitFilter = 4;

		// Token: 0x040247BC RID: 149436
		public const int BtnAddMainPro = 5;

		// Token: 0x040247BD RID: 149437
		public const int PanelMainPropertiesLayout = 6;

		// Token: 0x040247BE RID: 149438
		public const int PanelPropertyItem = 7;

		// Token: 0x040247BF RID: 149439
		public const int TxtFilterCount = 8;

		// Token: 0x040247C0 RID: 149440
		public const int BtnReset = 9;

		// Token: 0x040247C1 RID: 149441
		public const int BtnConfirmBaseDiscard = 10;

		// Token: 0x040247C2 RID: 149442
		public const int BtnConfirmBaseLock = 11;

		// Token: 0x040247C3 RID: 149443
		public const int BtnClose = 12;
	}
}
