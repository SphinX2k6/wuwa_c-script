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

// Token: 0x02001864 RID: 6244
[NullableContext(1)]
[Nullable(0)]
public class PhantomFilterPopupView : UiViewBase
{
	// Token: 0x0600B712 RID: 46866 RVA: 0x00295EFC File Offset: 0x002940FC
	public PhantomFilterPopupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B713 RID: 46867 RVA: 0x00295F24 File Offset: 0x00294124
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

	// Token: 0x0600B714 RID: 46868 RVA: 0x00296164 File Offset: 0x00294364
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomFilterPopupView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomFilterPopupView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B715 RID: 46869 RVA: 0x002961A8 File Offset: 0x002943A8
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

	// Token: 0x0600B716 RID: 46870 RVA: 0x0029622E File Offset: 0x0029442E
	protected override void OnBeforeDestroy()
	{
		CommonDropDown<int, int> commonDropDown = this.CommonDropDown;
		if (commonDropDown != null)
		{
			commonDropDown.Destroy(null);
		}
		this.CommonDropDown = null;
	}

	// Token: 0x0600B717 RID: 46871 RVA: 0x00296249 File Offset: 0x00294449
	protected override void OnBeforeShow()
	{
		this.UpdateFilterAnimation();
	}

	// Token: 0x0600B718 RID: 46872 RVA: 0x00296252 File Offset: 0x00294452
	private void OnClickClose()
	{
		Action onFilterViewClose = this.ViewData.OnFilterViewClose;
		if (onFilterViewClose != null)
		{
			onFilterViewClose();
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600B719 RID: 46873 RVA: 0x00296280 File Offset: 0x00294480
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

	// Token: 0x0600B71A RID: 46874 RVA: 0x002962AC File Offset: 0x002944AC
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName != "Sequence_Change_Number")
		{
			return;
		}
		this.UpdateFilterCount();
	}

	// Token: 0x0600B71B RID: 46875 RVA: 0x002962C4 File Offset: 0x002944C4
	private void UpdateFilterCount()
	{
		List<IPhantomFilterData> filteredPhantomList = this.GetFilteredPhantomList();
		UUIText text = base.GetText(8);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "PhantomFilterCount", new <>z__ReadOnlySingleElementList<object>(filteredPhantomList.Count));
		}
	}

	// Token: 0x0600B71C RID: 46876 RVA: 0x00296304 File Offset: 0x00294504
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

	// Token: 0x0600B71D RID: 46877 RVA: 0x00296380 File Offset: 0x00294580
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

	// Token: 0x0600B71E RID: 46878 RVA: 0x002963EC File Offset: 0x002945EC
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

	// Token: 0x0600B71F RID: 46879 RVA: 0x0029646C File Offset: 0x0029466C
	private void InitQualityLayout()
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
		if (horizontalLayout == null)
		{
			return;
		}
		this.QualityLayout = new GenericLayout<QualityToggleGridProxy, FilterItemData>(horizontalLayout, new Func<QualityToggleGridProxy>(this.CreateQualityToggle), null, false, true);
	}

	// Token: 0x0600B720 RID: 46880 RVA: 0x002964A0 File Offset: 0x002946A0
	private void InitStateLayout()
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(1);
		if (horizontalLayout == null)
		{
			return;
		}
		this.StateLayout = new GenericLayout<StateToggleGridProxy, FilterItemData>(horizontalLayout, new Func<StateToggleGridProxy>(this.CreateStateToggle), null, false, true);
	}

	// Token: 0x0600B721 RID: 46881 RVA: 0x002964D4 File Offset: 0x002946D4
	private void InitMainPropertiesLayout()
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(6);
		if (verticalLayout == null)
		{
			return;
		}
		this.MainPropertiesLayout = new GenericLayout<MainPropertyItem, FilterItemData>(verticalLayout, new Func<MainPropertyItem>(this.CreateMainPropertyItem), null, false, true);
	}

	// Token: 0x0600B722 RID: 46882 RVA: 0x00296508 File Offset: 0x00294708
	private QualityToggleGridProxy CreateQualityToggle()
	{
		QualityToggleGridProxy qualityToggleGridProxy = new QualityToggleGridProxy();
		qualityToggleGridProxy.SetToggleFunction(new TQualityToggleFunction(this.OnQualityToggleChanged));
		return qualityToggleGridProxy;
	}

	// Token: 0x0600B723 RID: 46883 RVA: 0x00296521 File Offset: 0x00294721
	private StateToggleGridProxy CreateStateToggle()
	{
		StateToggleGridProxy stateToggleGridProxy = new StateToggleGridProxy();
		stateToggleGridProxy.SetToggleFunction(new TQualityToggleFunction(this.OnStateToggleChanged));
		return stateToggleGridProxy;
	}

	// Token: 0x0600B724 RID: 46884 RVA: 0x0029653A File Offset: 0x0029473A
	private MainPropertyItem CreateMainPropertyItem()
	{
		MainPropertyItem mainPropertyItem = new MainPropertyItem();
		mainPropertyItem.SetDeleteCallback(new Action<int>(this.OnDeleteMainProperty));
		return mainPropertyItem;
	}

	// Token: 0x0600B725 RID: 46885 RVA: 0x00296554 File Offset: 0x00294754
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

	// Token: 0x0600B726 RID: 46886 RVA: 0x002965AC File Offset: 0x002947AC
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

	// Token: 0x0600B727 RID: 46887 RVA: 0x0029667C File Offset: 0x0029487C
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

	// Token: 0x0600B728 RID: 46888 RVA: 0x00296718 File Offset: 0x00294918
	private void OnDeleteMainProperty(int filterId)
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Dictionary<int, string> dictionary = ((filterResultData != null) ? filterResultData.GetSelectRuleDataById(this.MainAttributeFilterType) : null) ?? new Dictionary<int, string>();
		dictionary.Remove(filterId);
		filterResultData.SetSelectRuleData(this.MainAttributeFilterType, dictionary);
		this.LoadMainPropertiesData();
		this.OnFilterConfirm();
	}

	// Token: 0x0600B729 RID: 46889 RVA: 0x00296778 File Offset: 0x00294978
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

	// Token: 0x0600B72A RID: 46890 RVA: 0x00296934 File Offset: 0x00294B34
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

	// Token: 0x0600B72B RID: 46891 RVA: 0x002969DC File Offset: 0x00294BDC
	private UniTask InitSuitFilter()
	{
		PhantomFilterPopupView.<InitSuitFilter>d__40 <InitSuitFilter>d__;
		<InitSuitFilter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSuitFilter>d__.<>4__this = this;
		<InitSuitFilter>d__.<>1__state = -1;
		<InitSuitFilter>d__.<>t__builder.Start<PhantomFilterPopupView.<InitSuitFilter>d__40>(ref <InitSuitFilter>d__);
		return <InitSuitFilter>d__.<>t__builder.Task;
	}

	// Token: 0x0600B72C RID: 46892 RVA: 0x00296A20 File Offset: 0x00294C20
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

	// Token: 0x0600B72D RID: 46893 RVA: 0x00296BB0 File Offset: 0x00294DB0
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

	// Token: 0x0600B72E RID: 46894 RVA: 0x00296BCE File Offset: 0x00294DCE
	private int GetDropDownTextId(int data)
	{
		return data;
	}

	// Token: 0x0600B72F RID: 46895 RVA: 0x00296BD1 File Offset: 0x00294DD1
	private VisionEquipmentDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
	{
		return new VisionEquipmentDropDownItem(uiItem);
	}

	// Token: 0x0600B730 RID: 46896 RVA: 0x00296BD9 File Offset: 0x00294DD9
	private VisionEquipmentDropDownTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new VisionEquipmentDropDownTitleItem(uiItem);
	}

	// Token: 0x0600B731 RID: 46897 RVA: 0x00296BE4 File Offset: 0x00294DE4
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

	// Token: 0x0600B732 RID: 46898 RVA: 0x00296C70 File Offset: 0x00294E70
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

	// Token: 0x0600B733 RID: 46899 RVA: 0x00296D34 File Offset: 0x00294F34
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

	// Token: 0x0600B734 RID: 46900 RVA: 0x00296DB5 File Offset: 0x00294FB5
	private List<IPhantomFilterData> GetFilteredPhantomList()
	{
		PhantomFilterViewData<IPhantomFilterData> viewData = this.ViewData;
		if (((viewData != null) ? viewData.GetFilteredDataListFunc : null) == null)
		{
			return new List<IPhantomFilterData>();
		}
		return this.ViewData.GetFilteredDataListFunc();
	}

	// Token: 0x0600B735 RID: 46901 RVA: 0x00296DE4 File Offset: 0x00294FE4
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

	// Token: 0x0600B736 RID: 46902 RVA: 0x00296F24 File Offset: 0x00295124
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

	// Token: 0x0600B737 RID: 46903 RVA: 0x00297064 File Offset: 0x00295264
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

	// Token: 0x0600B738 RID: 46904 RVA: 0x002970B0 File Offset: 0x002952B0
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

	// Token: 0x040052A7 RID: 21159
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private PhantomFilterViewData<IPhantomFilterData> ViewData;

	// Token: 0x040052A8 RID: 21160
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<QualityToggleGridProxy, FilterItemData> QualityLayout;

	// Token: 0x040052A9 RID: 21161
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<StateToggleGridProxy, FilterItemData> StateLayout;

	// Token: 0x040052AA RID: 21162
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MainPropertyItem, FilterItemData> MainPropertiesLayout;

	// Token: 0x040052AB RID: 21163
	[Nullable(2)]
	private CommonDropDown<int, int> CommonDropDown;

	// Token: 0x040052AC RID: 21164
	private readonly List<int> FetterSuitFilterArray = new List<int>();

	// Token: 0x040052AD RID: 21165
	private readonly Dictionary<int, int> FetterSortIdMap = new Dictionary<int, int>();

	// Token: 0x040052AE RID: 21166
	private int CurrentSelectSuitIndex;

	// Token: 0x040052AF RID: 21167
	[Nullable(2)]
	private ButtonItem BtnDiscardItem;

	// Token: 0x040052B0 RID: 21168
	[Nullable(2)]
	private ButtonItem BtnLockItem;

	// Token: 0x040052B1 RID: 21169
	[Nullable(2)]
	public PopupCaptionItem CaptionItem;

	// Token: 0x040052B2 RID: 21170
	private bool InitState;

	// Token: 0x040052B3 RID: 21171
	private bool LastHasFilter;

	// Token: 0x040052B4 RID: 21172
	private FilterDefine.EFilterType MainAttributeFilterType = FilterDefine.EFilterType.VisionDestroyAttribute;

	// Token: 0x02007E23 RID: 32291
	[NullableContext(0)]
	private class EPhantomFilterComp
	{
		// Token: 0x0402948A RID: 169098
		public const int Caption = 0;

		// Token: 0x0402948B RID: 169099
		public const int StateLayout = 1;

		// Token: 0x0402948C RID: 169100
		public const int QualityLayout = 2;

		// Token: 0x0402948D RID: 169101
		public const int TogQualityItem = 3;

		// Token: 0x0402948E RID: 169102
		public const int SuitFilter = 4;

		// Token: 0x0402948F RID: 169103
		public const int BtnAddMainPro = 5;

		// Token: 0x04029490 RID: 169104
		public const int PanelMainPropertiesLayout = 6;

		// Token: 0x04029491 RID: 169105
		public const int PanelPropertyItem = 7;

		// Token: 0x04029492 RID: 169106
		public const int TxtFilterCount = 8;

		// Token: 0x04029493 RID: 169107
		public const int BtnReset = 9;

		// Token: 0x04029494 RID: 169108
		public const int BtnConfirmBaseDiscard = 10;

		// Token: 0x04029495 RID: 169109
		public const int BtnConfirmBaseLock = 11;

		// Token: 0x04029496 RID: 169110
		public const int BtnClose = 12;
	}
}
