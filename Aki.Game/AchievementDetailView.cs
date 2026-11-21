using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020003D5 RID: 981
[NullableContext(1)]
[Nullable(0)]
public class AchievementDetailView : UiViewBase
{
	// Token: 0x0600359A RID: 13722 RVA: 0x0013AC50 File Offset: 0x00138E50
	public AchievementDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600359B RID: 13723 RVA: 0x0013AC64 File Offset: 0x00138E64
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
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
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600359C RID: 13724 RVA: 0x0013ADFC File Offset: 0x00138FFC
	protected override UniTask OnBeforeStartAsync()
	{
		AchievementDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AchievementDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600359D RID: 13725 RVA: 0x0013AE40 File Offset: 0x00139040
	private UniTask RefreshTabRedPoint()
	{
		AchievementDetailView.<RefreshTabRedPoint>d__12 <RefreshTabRedPoint>d__;
		<RefreshTabRedPoint>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabRedPoint>d__.<>4__this = this;
		<RefreshTabRedPoint>d__.<>1__state = -1;
		<RefreshTabRedPoint>d__.<>t__builder.Start<AchievementDetailView.<RefreshTabRedPoint>d__12>(ref <RefreshTabRedPoint>d__);
		return <RefreshTabRedPoint>d__.<>t__builder.Task;
	}

	// Token: 0x0600359E RID: 13726 RVA: 0x0013AE84 File Offset: 0x00139084
	protected override void OnBeforeShow()
	{
		AchievementGroupData selectGroupData = AchievementModel.Instance.CurrentSelectGroup;
		int index = AchievementModel.Instance.GetAchievementCategoryGroups(AchievementModel.Instance.CurrentSelectCategory.GetId(), true).FindIndex((AchievementGroupData groupData) => groupData == selectGroupData);
		this.ScrollToSelectGroup(index);
		AchievementCategoryData currentSelectCategory = AchievementModel.Instance.CurrentSelectCategory;
		if (currentSelectCategory == null)
		{
			return;
		}
		int achievementCategoryIndex = AchievementModel.Instance.GetAchievementCategoryIndex(currentSelectCategory);
		if (achievementCategoryIndex < 0)
		{
			return;
		}
		TabComponentWithCaptionItem<CommonTabItem> captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SelectToggleByIndex(achievementCategoryIndex, true);
	}

	// Token: 0x0600359F RID: 13727 RVA: 0x0013AF0C File Offset: 0x0013910C
	protected override void OnStart()
	{
		this.AchievementGroupTitleItem = new AchievementGroupTitleItem();
		this.AchievementGroupTitleItem.Initialize(base.GetItem(3));
		this.SearchComponent = new CommonSearchComponent(base.GetItem(7), new Action<string>(this.SearchResult), new Action(this.ResetSearch));
	}

	// Token: 0x060035A0 RID: 13728 RVA: 0x0013AF60 File Offset: 0x00139160
	private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x0013AF68 File Offset: 0x00139168
	private void ToggleCallBack(int index)
	{
		AchievementCategoryData achievementCategoryData = this.AchievementCategoryDataList[index];
		AchievementModel.Instance.CurrentSelectCategory = achievementCategoryData;
		AchievementModel.Instance.AchievementSearchState = false;
		List<AchievementGroupData> achievementCategoryGroups = AchievementModel.Instance.GetAchievementCategoryGroups(achievementCategoryData.GetId(), true);
		if (achievementCategoryGroups.Count <= 0)
		{
			return;
		}
		AchievementGroupData currentSelectGroup = AchievementModel.Instance.CurrentSelectGroup;
		int num = achievementCategoryGroups.IndexOf(currentSelectGroup);
		AchievementGroupData currentSelectGroup2 = (num >= 0) ? achievementCategoryGroups[num] : achievementCategoryGroups[0];
		AchievementModel.Instance.CurrentSelectGroup = currentSelectGroup2;
		base.GetText(10).SetText(achievementCategoryData.GetAchievementCategoryProgress(), true);
		this.ResetSearchComponent();
		this.RefreshViewTypeSearchType();
		this.RefreshGroupScroller();
		this.RefreshSearchingItem();
	}

	// Token: 0x060035A2 RID: 13730 RVA: 0x0013B015 File Offset: 0x00139215
	private void ScrollToSelectGroup(int index)
	{
		if (index < 0)
		{
			return;
		}
		this.AchievementGroupScroller.LateScrollTo(index);
	}

	// Token: 0x060035A3 RID: 13731 RVA: 0x0013B028 File Offset: 0x00139228
	private CommonTabData GetCommonData(int index)
	{
		AchievementCategoryData achievementCategoryData = this.AchievementCategoryDataList[index];
		return new CommonTabData(achievementCategoryData.GetSprite(), new CommonTabTitleData(achievementCategoryData.GetOrignalTitle(), Array.Empty<object>()), null);
	}

	// Token: 0x060035A4 RID: 13732 RVA: 0x0013B05E File Offset: 0x0013925E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x060035A5 RID: 13733 RVA: 0x0013B098 File Offset: 0x00139298
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x060035A6 RID: 13734 RVA: 0x0013B0D4 File Offset: 0x001392D4
	protected override void OnBeforeDestroy()
	{
		if (this.CaptionItem != null)
		{
			this.CaptionItem.Destroy(null);
			this.CaptionItem = null;
		}
		if (this.AchievementGroupTitleItem != null)
		{
			this.AchievementGroupTitleItem.Destroy(null);
			this.AchievementGroupTitleItem = null;
		}
		if (this.AchievementGroupDataItem != null)
		{
			this.AchievementGroupDataItem.Destroy(null);
			this.AchievementGroupDataItem = null;
		}
		if (this.AchievementSearchItem != null)
		{
			this.AchievementSearchItem.Destroy(null);
			this.AchievementSearchItem = null;
		}
		if (this.AchievementGroupScroller != null)
		{
			this.AchievementGroupScroller.ClearChildren();
		}
		if (this.AchievementGroupSmallDynItem != null)
		{
			this.AchievementGroupSmallDynItem.ClearItem();
			this.AchievementGroupSmallDynItem = null;
		}
		this.SearchComponent.Destroy(null);
	}

	// Token: 0x060035A7 RID: 13735 RVA: 0x0013B186 File Offset: 0x00139386
	private void OnAchievementGroupChange()
	{
		this.RefreshViewTypeSearchType();
	}

	// Token: 0x060035A8 RID: 13736 RVA: 0x0013B18E File Offset: 0x0013938E
	private void OnAchievementDataNotify()
	{
		AchievementModel.Instance.RefreshSearchResult();
		this.RefreshViewTypeSearchType();
	}

	// Token: 0x060035A9 RID: 13737 RVA: 0x0013B1A0 File Offset: 0x001393A0
	private void SearchResult(string content)
	{
		AchievementModel.Instance.CurrentSearchText = content;
		AchievementModel.Instance.RefreshSearchResult();
		AchievementModel.Instance.AchievementSearchState = !StringUtils.IsEmpty(content);
		this.RefreshViewTypeSearchType();
		this.RefreshSearchingItem();
		EventSystem.Instance.Emit(EEventName.OnGetAchievementSearchTextChange);
	}

	// Token: 0x060035AA RID: 13738 RVA: 0x0013B1F4 File Offset: 0x001393F4
	private void ResetSearch()
	{
		bool achievementSearchState = AchievementModel.Instance.AchievementSearchState;
		AchievementModel.Instance.AchievementSearchState = false;
		AchievementModel.Instance.CurrentSearchText = "";
		if (achievementSearchState != AchievementModel.Instance.AchievementSearchState)
		{
			this.RefreshViewTypeSearchType();
			this.RefreshGroupScroller();
		}
		this.RefreshSearchingItem();
		EventSystem.Instance.Emit(EEventName.OnGetAchievementSearchTextChange);
	}

	// Token: 0x060035AB RID: 13739 RVA: 0x0013B253 File Offset: 0x00139453
	private void ResetSearchComponent()
	{
		CommonSearchComponent searchComponent = this.SearchComponent;
		if (searchComponent == null)
		{
			return;
		}
		searchComponent.ResetSearch(true);
	}

	// Token: 0x060035AC RID: 13740 RVA: 0x0013B268 File Offset: 0x00139468
	private void RefreshGroupScroller()
	{
		AchievementModel instance = AchievementModel.Instance;
		List<AchievementGroupData> achievementCategoryGroups = instance.GetAchievementCategoryGroups(instance.CurrentSelectCategory.GetId(), true);
		this.AchievementGroupScroller.RefreshByData(achievementCategoryGroups.ToArray(), false, false);
	}

	// Token: 0x060035AD RID: 13741 RVA: 0x0013B2A0 File Offset: 0x001394A0
	private void RefreshSearchingItem()
	{
		bool achievementSearchState = AchievementModel.Instance.AchievementSearchState;
		bool searchResultIfNull = AchievementModel.Instance.GetSearchResultIfNull();
		base.GetItem(2).SetUIActive(achievementSearchState && !searchResultIfNull);
	}

	// Token: 0x060035AE RID: 13742 RVA: 0x0013B2DC File Offset: 0x001394DC
	private void RefreshViewTypeSearchType()
	{
		bool achievementSearchState = AchievementModel.Instance.AchievementSearchState;
		this.AchievementGroupTitleItem.SetActive(!achievementSearchState);
		this.AchievementGroupDataItem.SetActive(!achievementSearchState);
		this.AchievementSearchItem.SetActive(achievementSearchState);
		base.GetUIDynScrollViewComponent(1).GetRootComponent().SetUIActive(!achievementSearchState);
		if (achievementSearchState)
		{
			bool searchResultIfNull = AchievementModel.Instance.GetSearchResultIfNull();
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!searchResultIfNull);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(searchResultIfNull);
			}
			this.AchievementSearchItem.Update();
			return;
		}
		if (AchievementModel.Instance.CurrentSelectGroup != null)
		{
			this.AchievementGroupTitleItem.Update(AchievementModel.Instance.CurrentSelectGroup);
			this.AchievementGroupDataItem.Update(AchievementModel.Instance.CurrentSelectGroup);
		}
		else
		{
			this.AchievementGroupTitleItem.SetActive(false);
		}
		UUIItem item3 = base.GetItem(8);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(9);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(false);
	}

	// Token: 0x060035AF RID: 13743 RVA: 0x0013B3E1 File Offset: 0x001395E1
	private AchievementGroupSmallItem OnSmallItemCreate(AchievementGroupData data, UUIItem uiItem, int index)
	{
		return new AchievementGroupSmallItem();
	}

	// Token: 0x060035B0 RID: 13744 RVA: 0x0013B3E8 File Offset: 0x001395E8
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04002D1E RID: 11550
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> CaptionItem;

	// Token: 0x04002D1F RID: 11551
	[Nullable(2)]
	private AchievementSearchItem AchievementSearchItem;

	// Token: 0x04002D20 RID: 11552
	[Nullable(2)]
	private AchievementGroupDataItem AchievementGroupDataItem;

	// Token: 0x04002D21 RID: 11553
	[Nullable(2)]
	private AchievementGroupTitleItem AchievementGroupTitleItem;

	// Token: 0x04002D22 RID: 11554
	[Nullable(2)]
	private AchievementGroupSmallDynItem AchievementGroupSmallDynItem;

	// Token: 0x04002D23 RID: 11555
	[Nullable(2)]
	private CommonSearchComponent SearchComponent;

	// Token: 0x04002D24 RID: 11556
	private List<AchievementCategoryData> AchievementCategoryDataList = new List<AchievementCategoryData>();

	// Token: 0x04002D25 RID: 11557
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<AchievementGroupSmallItem, AchievementGroupSmallDynItem, AchievementGroupData> AchievementGroupScroller;

	// Token: 0x020066FA RID: 26362
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022059 RID: 139353
		CaptionItem,
		// Token: 0x0402205A RID: 139354
		AchievementGroupScroller,
		// Token: 0x0402205B RID: 139355
		SearchingItem,
		// Token: 0x0402205C RID: 139356
		GroupTitleItem,
		// Token: 0x0402205D RID: 139357
		GroupDataItem,
		// Token: 0x0402205E RID: 139358
		SearchItem,
		// Token: 0x0402205F RID: 139359
		AchievementGroupTemplate,
		// Token: 0x04022060 RID: 139360
		SearchInput,
		// Token: 0x04022061 RID: 139361
		LeftSearchTip,
		// Token: 0x04022062 RID: 139362
		RightSearchTip,
		// Token: 0x04022063 RID: 139363
		CategoryProgressText
	}
}
