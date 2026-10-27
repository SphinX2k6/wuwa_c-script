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

// Token: 0x02000F20 RID: 3872
[NullableContext(1)]
[Nullable(0)]
public class AchievementDetailView : UiViewBase
{
	// Token: 0x06006202 RID: 25090 RVA: 0x0013232C File Offset: 0x0013052C
	public AchievementDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006203 RID: 25091 RVA: 0x00132340 File Offset: 0x00130540
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

	// Token: 0x06006204 RID: 25092 RVA: 0x001324D8 File Offset: 0x001306D8
	protected override UniTask OnBeforeStartAsync()
	{
		AchievementDetailView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AchievementDetailView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x0013251C File Offset: 0x0013071C
	private UniTask RefreshTabRedPoint()
	{
		AchievementDetailView.<RefreshTabRedPoint>d__12 <RefreshTabRedPoint>d__;
		<RefreshTabRedPoint>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabRedPoint>d__.<>4__this = this;
		<RefreshTabRedPoint>d__.<>1__state = -1;
		<RefreshTabRedPoint>d__.<>t__builder.Start<AchievementDetailView.<RefreshTabRedPoint>d__12>(ref <RefreshTabRedPoint>d__);
		return <RefreshTabRedPoint>d__.<>t__builder.Task;
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x00132560 File Offset: 0x00130760
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

	// Token: 0x06006207 RID: 25095 RVA: 0x001325E8 File Offset: 0x001307E8
	protected override void OnStart()
	{
		this.AchievementGroupTitleItem = new AchievementGroupTitleItem();
		this.AchievementGroupTitleItem.Initialize(base.GetItem(3));
		this.SearchComponent = new CommonSearchComponent(base.GetItem(7), new Action<string>(this.SearchResult), new Action(this.ResetSearch));
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x0013263C File Offset: 0x0013083C
	private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x00132644 File Offset: 0x00130844
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

	// Token: 0x0600620A RID: 25098 RVA: 0x001326F1 File Offset: 0x001308F1
	private void ScrollToSelectGroup(int index)
	{
		if (index < 0)
		{
			return;
		}
		this.AchievementGroupScroller.LateScrollTo(index);
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x00132704 File Offset: 0x00130904
	private CommonTabData GetCommonData(int index)
	{
		AchievementCategoryData achievementCategoryData = this.AchievementCategoryDataList[index];
		return new CommonTabData(achievementCategoryData.GetSprite(), new CommonTabTitleData(achievementCategoryData.GetOrignalTitle(), Array.Empty<object>()), null);
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x0013273A File Offset: 0x0013093A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Add(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x00132774 File Offset: 0x00130974
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAchievementGroupChange, new Action(this.OnAchievementGroupChange));
		EventSystem.Instance.Remove(EEventName.OnAchievementDataNotify, new Action(this.OnAchievementDataNotify));
	}

	// Token: 0x0600620E RID: 25102 RVA: 0x001327B0 File Offset: 0x001309B0
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

	// Token: 0x0600620F RID: 25103 RVA: 0x00132862 File Offset: 0x00130A62
	private void OnAchievementGroupChange()
	{
		this.RefreshViewTypeSearchType();
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x0013286A File Offset: 0x00130A6A
	private void OnAchievementDataNotify()
	{
		AchievementModel.Instance.RefreshSearchResult();
		this.RefreshViewTypeSearchType();
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x0013287C File Offset: 0x00130A7C
	private void SearchResult(string content)
	{
		AchievementModel.Instance.CurrentSearchText = content;
		AchievementModel.Instance.RefreshSearchResult();
		AchievementModel.Instance.AchievementSearchState = !StringUtils.IsEmpty(content);
		this.RefreshViewTypeSearchType();
		this.RefreshSearchingItem();
		EventSystem.Instance.Emit(EEventName.OnGetAchievementSearchTextChange);
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x001328D0 File Offset: 0x00130AD0
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

	// Token: 0x06006213 RID: 25107 RVA: 0x0013292F File Offset: 0x00130B2F
	private void ResetSearchComponent()
	{
		CommonSearchComponent searchComponent = this.SearchComponent;
		if (searchComponent == null)
		{
			return;
		}
		searchComponent.ResetSearch(true);
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x00132944 File Offset: 0x00130B44
	private void RefreshGroupScroller()
	{
		AchievementModel instance = AchievementModel.Instance;
		List<AchievementGroupData> achievementCategoryGroups = instance.GetAchievementCategoryGroups(instance.CurrentSelectCategory.GetId(), true);
		this.AchievementGroupScroller.RefreshByData(achievementCategoryGroups.ToArray(), false, false);
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x0013297C File Offset: 0x00130B7C
	private void RefreshSearchingItem()
	{
		bool achievementSearchState = AchievementModel.Instance.AchievementSearchState;
		bool searchResultIfNull = AchievementModel.Instance.GetSearchResultIfNull();
		base.GetItem(2).SetUIActive(achievementSearchState && !searchResultIfNull);
	}

	// Token: 0x06006216 RID: 25110 RVA: 0x001329B8 File Offset: 0x00130BB8
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

	// Token: 0x06006217 RID: 25111 RVA: 0x00132ABD File Offset: 0x00130CBD
	private AchievementGroupSmallItem OnSmallItemCreate(AchievementGroupData data, UUIItem uiItem, int index)
	{
		return new AchievementGroupSmallItem();
	}

	// Token: 0x06006218 RID: 25112 RVA: 0x00132AC4 File Offset: 0x00130CC4
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x04002C85 RID: 11397
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> CaptionItem;

	// Token: 0x04002C86 RID: 11398
	[Nullable(2)]
	private AchievementSearchItem AchievementSearchItem;

	// Token: 0x04002C87 RID: 11399
	[Nullable(2)]
	private AchievementGroupDataItem AchievementGroupDataItem;

	// Token: 0x04002C88 RID: 11400
	[Nullable(2)]
	private AchievementGroupTitleItem AchievementGroupTitleItem;

	// Token: 0x04002C89 RID: 11401
	[Nullable(2)]
	private AchievementGroupSmallDynItem AchievementGroupSmallDynItem;

	// Token: 0x04002C8A RID: 11402
	[Nullable(2)]
	private CommonSearchComponent SearchComponent;

	// Token: 0x04002C8B RID: 11403
	private List<AchievementCategoryData> AchievementCategoryDataList = new List<AchievementCategoryData>();

	// Token: 0x04002C8C RID: 11404
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<AchievementGroupSmallItem, AchievementGroupSmallDynItem, AchievementGroupData> AchievementGroupScroller;

	// Token: 0x02007566 RID: 30054
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04026D0E RID: 158990
		CaptionItem,
		// Token: 0x04026D0F RID: 158991
		AchievementGroupScroller,
		// Token: 0x04026D10 RID: 158992
		SearchingItem,
		// Token: 0x04026D11 RID: 158993
		GroupTitleItem,
		// Token: 0x04026D12 RID: 158994
		GroupDataItem,
		// Token: 0x04026D13 RID: 158995
		SearchItem,
		// Token: 0x04026D14 RID: 158996
		AchievementGroupTemplate,
		// Token: 0x04026D15 RID: 158997
		SearchInput,
		// Token: 0x04026D16 RID: 158998
		LeftSearchTip,
		// Token: 0x04026D17 RID: 158999
		RightSearchTip,
		// Token: 0x04026D18 RID: 159000
		CategoryProgressText
	}
}
