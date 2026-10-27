using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001AB9 RID: 6841
[NullableContext(1)]
[Nullable(0)]
public class ExploreDetailView : UiViewBase
{
	// Token: 0x0600CABE RID: 51902 RVA: 0x002E2E77 File Offset: 0x002E1077
	public ExploreDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CABF RID: 51903 RVA: 0x002E2E88 File Offset: 0x002E1088
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

	// Token: 0x0600CAC0 RID: 51904 RVA: 0x002E2FD4 File Offset: 0x002E11D4
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreDetailView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreDetailView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CAC1 RID: 51905 RVA: 0x002E3018 File Offset: 0x002E1218
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

	// Token: 0x0600CAC2 RID: 51906 RVA: 0x002E309C File Offset: 0x002E129C
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

	// Token: 0x0600CAC3 RID: 51907 RVA: 0x002E30F4 File Offset: 0x002E12F4
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

	// Token: 0x0600CAC4 RID: 51908 RVA: 0x002E3160 File Offset: 0x002E1360
	private void OnCloseButtonClicked()
	{
		UiManager.Instance.CloseView(EUiViewName.ExploreDetailView, null);
	}

	// Token: 0x0600CAC5 RID: 51909 RVA: 0x002E3174 File Offset: 0x002E1374
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

	// Token: 0x0600CAC6 RID: 51910 RVA: 0x002E31D8 File Offset: 0x002E13D8
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

	// Token: 0x0600CAC7 RID: 51911 RVA: 0x002E322C File Offset: 0x002E142C
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

	// Token: 0x0600CAC8 RID: 51912 RVA: 0x002E326A File Offset: 0x002E146A
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

	// Token: 0x0600CAC9 RID: 51913 RVA: 0x002E3290 File Offset: 0x002E1490
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

	// Token: 0x0600CACA RID: 51914 RVA: 0x002E32C4 File Offset: 0x002E14C4
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

	// Token: 0x0600CACB RID: 51915 RVA: 0x002E3314 File Offset: 0x002E1514
	private void RefreshTabScrollView()
	{
		List<ExploreAreaViewData> list = new List<ExploreAreaViewData>();
		int exploreAreaViewDataList = this.GetExploreAreaViewDataList(list);
		if (list.ElementAtOrDefault(exploreAreaViewDataList) == null)
		{
			this.SelectedAreaItem = null;
			return;
		}
		this.TabLoopScroll.RefreshByData(list.ToArray(), false, false);
		this.SelectedAreaIndex = exploreAreaViewDataList;
	}

	// Token: 0x0600CACC RID: 51916 RVA: 0x002E335C File Offset: 0x002E155C
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

	// Token: 0x0600CACD RID: 51917 RVA: 0x002E34C8 File Offset: 0x002E16C8
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

	// Token: 0x04005D55 RID: 23893
	[Nullable(2)]
	private PopupCaptionItem PopupCaptionItem;

	// Token: 0x04005D56 RID: 23894
	[Nullable(2)]
	private ExploreAreaItem SelectedAreaItem;

	// Token: 0x04005D57 RID: 23895
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<ExploreAreaParentItem, ExploreAreaDynamicItem, ExploreAreaViewData> TabLoopScroll;

	// Token: 0x04005D58 RID: 23896
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<ExploreProgressItem> GenericScrollView;

	// Token: 0x04005D59 RID: 23897
	private int SelectedAreaIndex = -1;

	// Token: 0x0200800D RID: 32781
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029CDB RID: 171227
		PopupCaptionItem,
		// Token: 0x04029CDC RID: 171228
		TagDynamicScrollViewItem,
		// Token: 0x04029CDD RID: 171229
		TabSourceItem,
		// Token: 0x04029CDE RID: 171230
		AreaContentItem,
		// Token: 0x04029CDF RID: 171231
		ExploreProgressScrollView,
		// Token: 0x04029CE0 RID: 171232
		ExploreProgressContentItem,
		// Token: 0x04029CE1 RID: 171233
		SkipButton
	}
}
