using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021AB RID: 8619
[NullableContext(1)]
[Nullable(0)]
public class TutorialView : UiViewBase
{
	// Token: 0x06015342 RID: 86850 RVA: 0x0062A8EB File Offset: 0x00628AEB
	public TutorialView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015343 RID: 86851 RVA: 0x0062A908 File Offset: 0x00628B08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickBtnLast)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnClickBtnNext))
		};
	}

	// Token: 0x06015344 RID: 86852 RVA: 0x0062AAC4 File Offset: 0x00628CC4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RedDotNewTutorial, new Action<int>(this.OnTutortialRedUpdate));
		EventSystem.Instance.Add(EEventName.OnTutorialUpdate, new Action(this.OnTutorialUpdate));
	}

	// Token: 0x06015345 RID: 86853 RVA: 0x0062AAFE File Offset: 0x00628CFE
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RedDotNewTutorial, new Action<int>(this.OnTutortialRedUpdate));
		EventSystem.Instance.Remove(EEventName.OnTutorialUpdate, new Action(this.OnTutorialUpdate));
	}

	// Token: 0x06015346 RID: 86854 RVA: 0x0062AB38 File Offset: 0x00628D38
	private void SearchResult(string content)
	{
		ValueTuple<List<TutorialItemData>, bool> valueTuple = TutorialModel.Instance.MakeSearchList(content, this.CurrentSelectType, this.ExclusiveType);
		List<TutorialItemData> item = valueTuple.Item1;
		base.GetItem(5).SetUIActive(item.Count == 0);
		if (item.Count == 0)
		{
			this.HideDetaildView();
		}
		if (!valueTuple.Item2)
		{
			ETutorialType? currentSelectType = this.CurrentSelectType;
			ETutorialType etutorialType = ETutorialType.All;
			if (!(currentSelectType.GetValueOrDefault() == etutorialType & currentSelectType != null))
			{
				this.HideDetaildView();
			}
		}
		this.ItemScrollView.RefreshByData(item.ToArray(), false, false);
	}

	// Token: 0x06015347 RID: 86855 RVA: 0x0062ABC3 File Offset: 0x00628DC3
	private void ResetSearch()
	{
		this.OnTypeToggleSelected((int)this.CurrentSelectType.Value);
		base.GetItem(4).SetUIActive(true);
	}

	// Token: 0x06015348 RID: 86856 RVA: 0x0062ABE4 File Offset: 0x00628DE4
	protected override UniTask OnBeforeStartAsync()
	{
		TutorialView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TutorialView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015349 RID: 86857 RVA: 0x0062AC28 File Offset: 0x00628E28
	protected override void OnStart()
	{
		ITutorialViewParam tutorialViewParam = this.OpenParam as ITutorialViewParam;
		this.ExclusiveType = ((tutorialViewParam != null) ? tutorialViewParam.ExclusiveType : null).GetValueOrDefault();
		TutorialModel.Instance.CurrentExclusiveType = this.ExclusiveType;
		base.GetItem(3).SetUIActive(false);
		foreach (object obj in Enum.GetValues(typeof(ETutorialType)))
		{
			int num = (int)obj;
			if (!double.IsNaN((double)num) && num != 6)
			{
				this.TypeList.Add(num);
			}
		}
		if (this.ExclusiveType != EExclusiveTutorialType.None)
		{
			this.TypeList.Clear();
			this.TypeList.Add(0);
			EventSystem.Instance.Emit<ETutorialType>(EEventName.RedDotNewTutorialType, ETutorialType.All);
		}
		this.SearchComponent = new CommonSearchComponent(base.GetItem(1), new Action<string>(this.SearchResult), new Action(this.ResetSearch));
		CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.ProxyCreate), new Action<int>(this.OnTypeToggleSelected), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<CommonTabItem>(base.GetItem(0), data, new Action(this.OnCloseClick), false);
		this.PageDotLayout = new GenericLayoutNew<TutorialPageItem>(base.GetHorizontalLayout(12), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TutorialPageItem>(this.InitDetail), base.GetItem(13));
		this.HideDetaildView();
	}

	// Token: 0x0601534A RID: 86858 RVA: 0x0062ADC0 File Offset: 0x00628FC0
	private ILayoutItem<TutorialPageItem> InitDetail(object data, UUIItem UUIItem, int index)
	{
		TutorialPageItem tutorialPageItem = new TutorialPageItem(UUIItem);
		tutorialPageItem.Init();
		tutorialPageItem.UpdateShow(false);
		return new LayoutItem<TutorialPageItem>
		{
			Key = index,
			Value = tutorialPageItem
		};
	}

	// Token: 0x0601534B RID: 86859 RVA: 0x0062ADFB File Offset: 0x00628FFB
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem UUIItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0601534C RID: 86860 RVA: 0x0062AE04 File Offset: 0x00629004
	private void OnTypeToggleSelected(int index)
	{
		int num = this.TypeList[index];
		this.CurrentSelectType = new ETutorialType?((ETutorialType)num);
		this.SearchComponent.ResetSearch(true);
		List<TutorialItemData> unlockedTutorialDataByType = TutorialModel.Instance.GetUnlockedTutorialDataByType((ETutorialType)num, this.ExclusiveType);
		int selectItemIndex = -1;
		if (this.RefreshTargetTutorialId > -1)
		{
			selectItemIndex = unlockedTutorialDataByType.FindIndex(delegate(TutorialItemData x)
			{
				TutorialSaveData savedData = x.SavedData;
				int? num2 = (savedData != null) ? new int?(savedData.TutorialId) : null;
				int refreshTargetTutorialId = this.RefreshTargetTutorialId;
				return num2.GetValueOrDefault() == refreshTargetTutorialId & num2 != null;
			});
			this.RefreshTargetTutorialId = -1;
			if (selectItemIndex > -1)
			{
				unlockedTutorialDataByType[selectItemIndex].Selected = new bool?(true);
			}
			else
			{
				unlockedTutorialDataByType[0].Selected = new bool?(true);
			}
		}
		else if (unlockedTutorialDataByType.Count > 0)
		{
			unlockedTutorialDataByType[0].Selected = new bool?(true);
		}
		this.ItemScrollView.RefreshByData(unlockedTutorialDataByType.ToArray(), false, false);
		if (unlockedTutorialDataByType.Count == 0)
		{
			this.HideDetaildView();
		}
		else if (selectItemIndex > -1)
		{
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				DynamicScrollView<TutorialDataItem, TutorialDynItem, TutorialItemData> itemScrollView = this.ItemScrollView;
				if (itemScrollView == null)
				{
					return;
				}
				itemScrollView.ScrollToItemIndex(selectItemIndex, true, false);
			}, null, null);
		}
		base.GetItem(5).SetUIActive(unlockedTutorialDataByType.Count == 0);
		this.SearchComponent.SetActive(unlockedTutorialDataByType.Count > 0);
		this.UiViewSequence.PlaySequence("Switch", false, null);
		base.GetUIDynScrollViewComponent(2).RootUIComp.Get().SetUIActive(unlockedTutorialDataByType.Count > 0);
	}

	// Token: 0x0601534D RID: 86861 RVA: 0x0062AF80 File Offset: 0x00629180
	public UniTask RefreshItemDetailWhenNeed(int selectItemIndex)
	{
		TutorialView.<RefreshItemDetailWhenNeed>d__24 <RefreshItemDetailWhenNeed>d__;
		<RefreshItemDetailWhenNeed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItemDetailWhenNeed>d__.<>4__this = this;
		<RefreshItemDetailWhenNeed>d__.selectItemIndex = selectItemIndex;
		<RefreshItemDetailWhenNeed>d__.<>1__state = -1;
		<RefreshItemDetailWhenNeed>d__.<>t__builder.Start<TutorialView.<RefreshItemDetailWhenNeed>d__24>(ref <RefreshItemDetailWhenNeed>d__);
		return <RefreshItemDetailWhenNeed>d__.<>t__builder.Task;
	}

	// Token: 0x0601534E RID: 86862 RVA: 0x0062AFCB File Offset: 0x006291CB
	private void HideDetaildView()
	{
		base.GetItem(4).SetUIActive(false);
		this.ItemData = null;
	}

	// Token: 0x0601534F RID: 86863 RVA: 0x0062AFE4 File Offset: 0x006291E4
	private CommonTabData GetCommonData(int index)
	{
		string tutorialTypeIconPath = TutorialUtils.GetTutorialTypeIconPath((ETutorialType)this.TypeList[index]);
		string tutorialTypeTxt = TutorialUtils.GetTutorialTypeTxt((ETutorialType)this.TypeList[index]);
		return new CommonTabData(tutorialTypeIconPath, new CommonTabTitleData(tutorialTypeTxt, Array.Empty<object>()), null);
	}

	// Token: 0x06015350 RID: 86864 RVA: 0x0062B028 File Offset: 0x00629228
	protected override void OnBeforeShow()
	{
		int count = this.TypeList.Count;
		List<CommonTabItemData> list = this.TabComponent.CreateTabItemDataByLength(count);
		for (int i = 0; i < count; i++)
		{
			int num = this.TypeList[i];
			if (num == 0)
			{
				list[i].RedDotName = new ERedDotName?(ERedDotName.TutorialTypeNew);
				list[i].RedDotUid = new int?(num);
			}
		}
		this.TabComponent.RefreshTabItem(list, new Action(this.AfterRefreshTabItem));
	}

	// Token: 0x06015351 RID: 86865 RVA: 0x0062B0A8 File Offset: 0x006292A8
	private void AfterRefreshTabItem()
	{
		if (this.OpenParam == null)
		{
			this.TabComponent.SelectToggleByIndex(0, false);
			return;
		}
		ITutorialViewParam tutorialViewParam = this.OpenParam as ITutorialViewParam;
		int valueOrDefault = ((tutorialViewParam != null) ? tutorialViewParam.TutorialId : null).GetValueOrDefault();
		TutorialSaveData savedDataById = TutorialModel.Instance.GetSavedDataById(valueOrDefault);
		if (savedDataById != null && savedDataById.TutorialData != null && !savedDataById.IsExcludedFromWiki)
		{
			int tutorialType = savedDataById.TutorialData.Value.TutorialType;
			this.RefreshTargetTutorialId = valueOrDefault;
			this.TabComponent.SelectToggleByIndex(tutorialType, false);
			this.RefreshTargetTutorialId = -1;
			return;
		}
		this.TabComponent.SelectToggleByIndex(0, false);
	}

	// Token: 0x06015352 RID: 86866 RVA: 0x0062B160 File Offset: 0x00629360
	protected override void OnAfterHide()
	{
		this.ItemScrollView.ClearChildren();
		this.HideDetaildView();
		this.NowSelectedToggle = null;
	}

	// Token: 0x06015353 RID: 86867 RVA: 0x0062B17C File Offset: 0x0062937C
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.PageDotLayout != null)
		{
			this.PageDotLayout.ClearChildren();
			this.PageDotLayout = null;
		}
		CommonSearchComponent searchComponent = this.SearchComponent;
		if (searchComponent != null)
		{
			searchComponent.Destroy(null);
		}
		DynamicScrollView<TutorialDataItem, TutorialDynItem, TutorialItemData> itemScrollView = this.ItemScrollView;
		if (itemScrollView != null)
		{
			itemScrollView.ClearChildren();
		}
		this.ItemScrollView = null;
		this.TypeList.Clear();
		if (this.IsOpenedByGuide)
		{
			GuideModel instance = GuideModel.Instance;
			if (instance != null)
			{
				instance.ClipTipState();
			}
			GuideModel instance2 = GuideModel.Instance;
			if (instance2 != null)
			{
				instance2.RemoveCurrentTutorialInfo();
			}
			GuideModel instance3 = GuideModel.Instance;
			if (instance3 != null)
			{
				instance3.TryShowTutorial();
			}
			this.IsOpenedByGuide = false;
		}
		TutorialController.Instance.TryOpenAwardUiViewPending();
		TutorialModel.Instance.CurrentExclusiveType = EExclusiveTutorialType.None;
	}

	// Token: 0x06015354 RID: 86868 RVA: 0x0062B247 File Offset: 0x00629447
	private TutorialDataItem OnCreateTutorialItemView(TutorialItemData data, UUIItem UUIItem, int index)
	{
		TutorialDataItem tutorialDataItem = new TutorialDataItem();
		tutorialDataItem.InitData(data);
		tutorialDataItem.SetOnToggleSelected(new Action<TutorialItemData, UUIExtendToggle>(this.OnItemToggleSelected));
		return tutorialDataItem;
	}

	// Token: 0x06015355 RID: 86869 RVA: 0x0062B268 File Offset: 0x00629468
	private void OnTutorialUpdate()
	{
		List<TutorialItemData> unlockedTutorialDataByType = TutorialModel.Instance.GetUnlockedTutorialDataByType(this.CurrentSelectType.Value, this.ExclusiveType);
		for (int i = 0; i < unlockedTutorialDataByType.Count; i++)
		{
			unlockedTutorialDataByType[i].Selected = new bool?(i == 0);
		}
		this.ItemScrollView.RefreshByData(unlockedTutorialDataByType.ToArray(), false, false);
	}

	// Token: 0x06015356 RID: 86870 RVA: 0x0062B2CC File Offset: 0x006294CC
	private void OnTutortialRedUpdate(int i)
	{
		TutorialDataItem[] scrollItemItems = this.ItemScrollView.GetScrollItemItems();
		for (int j = 0; j < scrollItemItems.Length; j++)
		{
			scrollItemItems[j].RefreshRed();
		}
	}

	// Token: 0x06015357 RID: 86871 RVA: 0x0062B2FB File Offset: 0x006294FB
	private void OnItemToggleSelected(TutorialItemData itemData, UUIExtendToggle toggle)
	{
		if (this.NowSelectedToggle != toggle)
		{
			UUIExtendToggle nowSelectedToggle = this.NowSelectedToggle;
			if (nowSelectedToggle != null)
			{
				nowSelectedToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.NowSelectedToggle = toggle;
		}
		base.GetItem(5).SetUIActive(false);
		this.UpdateView(itemData);
	}

	// Token: 0x06015358 RID: 86872 RVA: 0x0062B338 File Offset: 0x00629538
	private void UpdateView(TutorialItemData itemData)
	{
		base.GetItem(4).SetUIActive(true);
		if (this.ItemData != itemData)
		{
			this.UiViewSequence.PlaySequence("SwitchPage", false, null);
		}
		if (this.ItemData != null)
		{
			this.ItemData.Selected = new bool?(false);
		}
		this.ItemData = itemData;
		this.ItemData.Selected = new bool?(true);
		this.CurrDisplayIndex = 0;
		if (this.ItemData.SavedData.HasRedDot)
		{
			TutorialController.Instance.RemoveRedDotTutorialId(this.ItemData.SavedData.TutorialId);
		}
		int[] guideTutorialPageIds = GuideConfig.Instance.GetGuideTutorialPageIds(this.ItemData.SavedData.TutorialId);
		this.PageIds = new List<int>(guideTutorialPageIds);
		if (guideTutorialPageIds.Length <= 1)
		{
			base.GetButton(14).RootUIComp.Get().SetUIActive(false);
			base.GetButton(15).RootUIComp.Get().SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
		}
		else
		{
			base.GetButton(14).RootUIComp.Get().SetUIActive(true);
			base.GetButton(15).RootUIComp.Get().SetUIActive(true);
			base.GetItem(11).SetUIActive(true);
			this.PageDotLayout.RebuildLayoutByDataNew<int>(this.PageIds, null);
		}
		this.RefreshPageView(this.CurrDisplayIndex);
	}

	// Token: 0x06015359 RID: 86873 RVA: 0x0062B4B8 File Offset: 0x006296B8
	private void RefreshPageView(int index)
	{
		if (this.PageIds.Count > 1)
		{
			this.PageDotLayout.GetLayoutItemByIndex(this.CurrDisplayIndex).UpdateShow(false);
			this.PageDotLayout.GetLayoutItemByIndex(index).UpdateShow(true);
		}
		this.CurrDisplayIndex = index;
		GuideTutorialPage? guideTutorialPage = GuideConfig.Instance.GetGuideTutorialPage(this.PageIds[index]);
		if (!string.IsNullOrEmpty(guideTutorialPage.Value.Pic))
		{
			UUITexture texture = base.GetTexture(6);
			base.SetTextureByPath(guideTutorialPage.Value.Pic, texture, null, null);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), guideTutorialPage.Value.Title, Array.Empty<object>());
		if (StringUtils.IsEmpty(guideTutorialPage.Value.SubTitle))
		{
			base.GetItem(8).SetUIActive(false);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), guideTutorialPage.Value.SubTitle, Array.Empty<object>());
			base.GetItem(8).SetUIActive(true);
		}
		if (this.PageIds.Count > 1)
		{
			base.GetButton(14).SetSelfInteractive(this.CurrDisplayIndex > 0);
			base.GetButton(15).SetSelfInteractive(this.CurrDisplayIndex < this.PageIds.Count - 1);
		}
		string text = ConfigMultiTextLang.GetLocalTextNew(guideTutorialPage.Value.Content, null);
		text = text.Replace("/n", "");
		base.GetText(10).SetText(text, true);
	}

	// Token: 0x0601535A RID: 86874 RVA: 0x0062B654 File Offset: 0x00629854
	private void OnClickBtnLast()
	{
		if (this.CurrDisplayIndex > 0)
		{
			this.UiViewSequence.PlaySequence("SwitchLeft", false, null);
			this.RefreshPageView(this.CurrDisplayIndex - 1);
		}
	}

	// Token: 0x0601535B RID: 86875 RVA: 0x0062B694 File Offset: 0x00629894
	private void OnClickBtnNext()
	{
		if (this.CurrDisplayIndex < this.PageIds.Count - 1)
		{
			this.UiViewSequence.PlaySequence("SwitchRight", false, null);
			this.RefreshPageView(this.CurrDisplayIndex + 1);
		}
	}

	// Token: 0x0601535C RID: 86876 RVA: 0x0062B6DE File Offset: 0x006298DE
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400B3D0 RID: 46032
	public bool IsOpenedByGuide;

	// Token: 0x0400B3D1 RID: 46033
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x0400B3D2 RID: 46034
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<TutorialDataItem, TutorialDynItem, TutorialItemData> ItemScrollView;

	// Token: 0x0400B3D3 RID: 46035
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TutorialPageItem> PageDotLayout;

	// Token: 0x0400B3D4 RID: 46036
	[Nullable(2)]
	private CommonSearchComponent SearchComponent;

	// Token: 0x0400B3D5 RID: 46037
	private ETutorialType? CurrentSelectType;

	// Token: 0x0400B3D6 RID: 46038
	[Nullable(2)]
	private UUIExtendToggle NowSelectedToggle;

	// Token: 0x0400B3D7 RID: 46039
	private List<int> TypeList = new List<int>();

	// Token: 0x0400B3D8 RID: 46040
	private int CurrDisplayIndex;

	// Token: 0x0400B3D9 RID: 46041
	[Nullable(2)]
	private TutorialItemData ItemData;

	// Token: 0x0400B3DA RID: 46042
	[Nullable(2)]
	private List<int> PageIds;

	// Token: 0x0400B3DB RID: 46043
	private EExclusiveTutorialType ExclusiveType;

	// Token: 0x0400B3DC RID: 46044
	private int RefreshTargetTutorialId = -1;

	// Token: 0x02008461 RID: 33889
	[NullableContext(0)]
	public enum ETutorialsComponents
	{
		// Token: 0x0402AB31 RID: 174897
		UUIItemCaptionList,
		// Token: 0x0402AB32 RID: 174898
		UUIItemInputBox,
		// Token: 0x0402AB33 RID: 174899
		DynScrollView,
		// Token: 0x0402AB34 RID: 174900
		PnlList,
		// Token: 0x0402AB35 RID: 174901
		PnlRight,
		// Token: 0x0402AB36 RID: 174902
		UUIItemEmpty,
		// Token: 0x0402AB37 RID: 174903
		TexPicture,
		// Token: 0x0402AB38 RID: 174904
		TxtArea,
		// Token: 0x0402AB39 RID: 174905
		PnlOffset,
		// Token: 0x0402AB3A RID: 174906
		TxtSubTitle,
		// Token: 0x0402AB3B RID: 174907
		TxtTutorials,
		// Token: 0x0402AB3C RID: 174908
		PnlBottom,
		// Token: 0x0402AB3D RID: 174909
		PnlPages,
		// Token: 0x0402AB3E RID: 174910
		UUIItemPagesDot,
		// Token: 0x0402AB3F RID: 174911
		BtnArrowL,
		// Token: 0x0402AB40 RID: 174912
		BtnArrowR
	}
}
