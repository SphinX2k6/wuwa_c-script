using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F78 RID: 3960
[NullableContext(1)]
[Nullable(0)]
public class ExploreDetailView : UiViewBase
{
	// Token: 0x06009ECF RID: 40655 RVA: 0x002EDFC7 File Offset: 0x002EC1C7
	public ExploreDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009ED0 RID: 40656 RVA: 0x002EDFD8 File Offset: 0x002EC1D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickSkipButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009ED1 RID: 40657 RVA: 0x002EE124 File Offset: 0x002EC324
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009ED2 RID: 40658 RVA: 0x002EE168 File Offset: 0x002EC368
	protected override void OnStart()
	{
		this.PopupCaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.PopupCaptionItem.SetCloseCallBack(new Action(this.OnCloseButtonClicked));
		this.GenericScrollView = new GenericScrollView<ExploreProgressItem>(base.GetScrollViewWithScrollbar(4), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<ExploreProgressItem>(this.OnCreateExploreProgressItem), null);
		this.RefreshSelectedCountryIdAndAreaId(AreaModel.Instance.GetAreaCountryId().GetValueOrDefault());
		this.RefreshTabScrollView();
		if (this.SelectedAreaItem == null)
		{
			this.RefreshExploreProgressScrollView();
		}
	}

	// Token: 0x06009ED3 RID: 40659 RVA: 0x002EE1EC File Offset: 0x002EC3EC
	protected override void OnBeforeDestroy()
	{
		PopupCaptionItem popupCaptionItem = this.PopupCaptionItem;
		if (popupCaptionItem != null)
		{
			popupCaptionItem.Destroy(null);
		}
		this.PopupCaptionItem = null;
		DynamicScrollView<ExploreAreaParentItem, ExploreAreaDynamicItem, ExploreAreaViewData> tabLoopScroll = this.TabLoopScroll;
		if (tabLoopScroll != null)
		{
			tabLoopScroll.ClearChildren();
		}
		this.TabLoopScroll = null;
		GenericScrollView<ExploreProgressItem> genericScrollView = this.GenericScrollView;
		if (genericScrollView != null)
		{
			genericScrollView.ClearChildren();
		}
		this.GenericScrollView = null;
	}

	// Token: 0x06009ED4 RID: 40660 RVA: 0x002EE244 File Offset: 0x002EC444
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private ILayoutItem<ExploreProgressItem> OnCreateExploreProgressItem(object rawData, UUIItem uiItem, int index)
	{
		ExploreAreaItemData data = rawData as ExploreAreaItemData;
		ExploreProgressItem exploreProgressItem = new ExploreProgressItem();
		exploreProgressItem.CreateByActorAsync(uiItem.GetOwner(), null, false).ContinueWith(delegate()
		{
			exploreProgressItem.Refresh(data);
			exploreProgressItem.SetUiActive(true);
		});
		return new LayoutItem<ExploreProgressItem>
		{
			Key = index,
			Value = exploreProgressItem
		};
	}

	// Token: 0x06009ED5 RID: 40661 RVA: 0x002EE2B0 File Offset: 0x002EC4B0
	private void OnCloseButtonClicked()
	{
		UiManager.Instance.CloseView(EUiViewName.ExploreDetailView, null);
	}

	// Token: 0x06009ED6 RID: 40662 RVA: 0x002EE2C4 File Offset: 0x002EC4C4
	private void OnClickSkipButton()
	{
		if (FunctionModel.Instance.IsOpen(10057))
		{
			UiManager.Instance.CloseView(EUiViewName.ExploreDetailView, null);
			SkipTaskManager.Run(ESkipName.SkipToWorldMapView, new object[]
			{
				8,
				3
			});
			return;
		}
		GenericPromptController.Instance.ShowPromptByCode("ExploreProgressRewardNotOpen", Array.Empty<object>());
	}

	// Token: 0x06009ED7 RID: 40663 RVA: 0x002EE328 File Offset: 0x002EC528
	private ExploreAreaParentItem OnCreateTabItem(ExploreAreaViewData data, UUIItem uiItem, int index)
	{
		ExploreAreaParentItem exploreAreaParentItem = new ExploreAreaParentItem();
		exploreAreaParentItem.BindOnCountrySelected(new Action<ExploreCountryItem, ExploreAreaViewData, EToggleState>(this.OnCountrySelected));
		exploreAreaParentItem.BindOnAreaSelected(new Action<ExploreAreaItem, ExploreAreaViewData, bool>(this.OnAreaSelected));
		if (index == this.SelectedAreaIndex)
		{
			this.SelectedAreaItem = exploreAreaParentItem.ExploreAreaItem;
			this.SelectedAreaIndex = -1;
		}
		return exploreAreaParentItem;
	}

	// Token: 0x06009ED8 RID: 40664 RVA: 0x002EE37C File Offset: 0x002EC57C
	private void OnCountrySelected(ExploreCountryItem exploreCountryItem, ExploreAreaViewData data, EToggleState state)
	{
		int countryId = data.CountryId;
		if (state == EToggleState.ETT_Checked)
		{
			this.RefreshSelectedCountryIdAndAreaId(countryId);
			this.RefreshTabScrollView();
			return;
		}
		ExploreProgressModel instance = ExploreProgressModel.Instance;
		instance.SelectedCountryId = 0;
		instance.SelectedAreaId = 0;
		this.RefreshTabScrollView();
	}

	// Token: 0x06009ED9 RID: 40665 RVA: 0x002EE3BA File Offset: 0x002EC5BA
	private void OnAreaSelected(ExploreAreaItem exploreAreaItem, ExploreAreaViewData data, bool bSelected)
	{
		if (!bSelected)
		{
			return;
		}
		this.SelectedArea(data.AreaId, exploreAreaItem);
		this.RefreshExploreProgressScrollView();
		base.PlaySequence("Switch", null, false);
	}

	// Token: 0x06009EDA RID: 40666 RVA: 0x002EE3E0 File Offset: 0x002EC5E0
	[NullableContext(2)]
	private void SelectedArea(int areaId, ExploreAreaItem exploreAreaItem = null)
	{
		if (exploreAreaItem == null)
		{
			return;
		}
		ExploreAreaItem selectedAreaItem = this.SelectedAreaItem;
		if (selectedAreaItem != null)
		{
			selectedAreaItem.SetSelected(false, false);
		}
		this.SelectedAreaItem = exploreAreaItem;
		exploreAreaItem.SetSelected(true, false);
		ExploreProgressModel.Instance.SelectedAreaId = areaId;
	}

	// Token: 0x06009EDB RID: 40667 RVA: 0x002EE414 File Offset: 0x002EC614
	private void RefreshSelectedCountryIdAndAreaId(int countryId)
	{
		ExploreProgressModel instance = ExploreProgressModel.Instance;
		if (countryId <= 0)
		{
			instance.SelectedCountryId = 1;
			ExploreAreaData exploreAreaData = instance.GetExploreCountryData(countryId).GetExploreAreaDataList()[0];
			instance.SelectedAreaId = exploreAreaData.AreaId;
		}
		instance.SelectedCountryId = countryId;
		instance.SelectedAreaId = MapUtil.GetWorldMapLevelOneAreaId();
	}

	// Token: 0x06009EDC RID: 40668 RVA: 0x002EE464 File Offset: 0x002EC664
	private void RefreshTabScrollView()
	{
		List<ExploreAreaViewData> list = new List<ExploreAreaViewData>();
		int exploreAreaViewDataList = this.GetExploreAreaViewDataList(list);
		if (((exploreAreaViewDataList >= 0 && exploreAreaViewDataList < list.Count) ? list[exploreAreaViewDataList] : null) == null)
		{
			this.SelectedAreaItem = null;
			return;
		}
		this.TabLoopScroll.RefreshByData(list.ToArray(), false, false);
		this.SelectedAreaIndex = exploreAreaViewDataList;
	}

	// Token: 0x06009EDD RID: 40669 RVA: 0x002EE4BC File Offset: 0x002EC6BC
	private int GetExploreAreaViewDataList(List<ExploreAreaViewData> exploreAreaViewDataList)
	{
		ExploreProgressModel instance = ExploreProgressModel.Instance;
		IReadOnlyDictionary<int, ExploreCountryData> exploreCountryDataMap = ExploreProgressModel.Instance.GetExploreCountryDataMap();
		int result = 0;
		foreach (ExploreCountryData exploreCountryData in exploreCountryDataMap.Values)
		{
			if (exploreCountryData.GetAreaSize() > 0)
			{
				int countryId = exploreCountryData.CountryId;
				ExploreAreaViewData exploreAreaViewData = new ExploreAreaViewData();
				exploreAreaViewData.RefreshCountry(countryId, exploreCountryData.GetNameId(), false);
				exploreAreaViewDataList.Add(exploreAreaViewData);
				if (countryId == instance.SelectedCountryId)
				{
					List<ExploreAreaData> exploreAreaDataList = exploreCountryData.GetExploreAreaDataList();
					exploreAreaDataList.Sort(delegate(ExploreAreaData a, ExploreAreaData b)
					{
						int sortIndex = a.GetSortIndex();
						int sortIndex2 = b.GetSortIndex();
						if (sortIndex == 0 || sortIndex2 == 0)
						{
							return a.AreaId.CompareTo(b.AreaId);
						}
						if (sortIndex != sortIndex2)
						{
							return sortIndex.CompareTo(sortIndex2);
						}
						return a.AreaId.CompareTo(b.AreaId);
					});
					foreach (ExploreAreaData exploreAreaData in exploreAreaDataList)
					{
						if (exploreAreaData.GetAllExploreAreaItemData().Count > 0)
						{
							int areaId = exploreAreaData.AreaId;
							ExploreAreaViewData exploreAreaViewData2 = new ExploreAreaViewData();
							exploreAreaViewData2.RefreshArea(areaId, exploreAreaData.GetNameId(), (float)exploreAreaData.GetProgress());
							exploreAreaViewDataList.Add(exploreAreaViewData2);
							if (instance.SelectedAreaId == areaId)
							{
								result = exploreAreaViewDataList.Count - 1;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06009EDE RID: 40670 RVA: 0x002EE628 File Offset: 0x002EC828
	private void RefreshExploreProgressScrollView()
	{
		ExploreProgressModel instance = ExploreProgressModel.Instance;
		int selectedAreaId = instance.SelectedAreaId;
		ExploreAreaData exploreAreaData = instance.GetExploreAreaData(selectedAreaId);
		if (exploreAreaData == null)
		{
			return;
		}
		this.GenericScrollView.RefreshByData<ExploreAreaItemData>(exploreAreaData.GetAllExploreAreaItemData(), null);
	}

	// Token: 0x04005E24 RID: 24100
	[Nullable(2)]
	private PopupCaptionItem PopupCaptionItem;

	// Token: 0x04005E25 RID: 24101
	[Nullable(2)]
	private ExploreAreaItem SelectedAreaItem;

	// Token: 0x04005E26 RID: 24102
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ExploreAreaParentItem, ExploreAreaDynamicItem, ExploreAreaViewData> TabLoopScroll;

	// Token: 0x04005E27 RID: 24103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<ExploreProgressItem> GenericScrollView;

	// Token: 0x04005E28 RID: 24104
	private int SelectedAreaIndex = -1;

	// Token: 0x0200719C RID: 29084
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04025015 RID: 151573
		PopupCaptionItem,
		// Token: 0x04025016 RID: 151574
		TagDynamicScrollViewItem,
		// Token: 0x04025017 RID: 151575
		TabSourceItem,
		// Token: 0x04025018 RID: 151576
		AreaContentItem,
		// Token: 0x04025019 RID: 151577
		ExploreProgressScrollView,
		// Token: 0x0402501A RID: 151578
		ExploreProgressContentItem,
		// Token: 0x0402501B RID: 151579
		SkipButton
	}
}
