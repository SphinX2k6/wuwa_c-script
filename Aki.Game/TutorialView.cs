using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002C30 RID: 11312
[NullableContext(1)]
[Nullable(0)]
public class TutorialView : UiViewBase
{
	// Token: 0x06017910 RID: 96528 RVA: 0x005FDE5F File Offset: 0x005FC05F
	public TutorialView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017911 RID: 96529 RVA: 0x005FDE7C File Offset: 0x005FC07C
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

	// Token: 0x06017912 RID: 96530 RVA: 0x005FE038 File Offset: 0x005FC238
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RedDotNewTutorial, new Action<int>(this.OnTutortialRedUpdate));
		EventSystem.Instance.Add(EEventName.OnTutorialUpdate, new Action(this.OnTutorialUpdate));
	}

	// Token: 0x06017913 RID: 96531 RVA: 0x005FE072 File Offset: 0x005FC272
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RedDotNewTutorial, new Action<int>(this.OnTutortialRedUpdate));
		EventSystem.Instance.Remove(EEventName.OnTutorialUpdate, new Action(this.OnTutorialUpdate));
	}

	// Token: 0x06017914 RID: 96532 RVA: 0x005FE0AC File Offset: 0x005FC2AC
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

	// Token: 0x06017915 RID: 96533 RVA: 0x005FE137 File Offset: 0x005FC337
	private void ResetSearch()
	{
		this.OnTypeToggleSelected((int)this.CurrentSelectType.Value);
		base.GetItem(4).SetUIActive(true);
	}

	// Token: 0x06017916 RID: 96534 RVA: 0x005FE158 File Offset: 0x005FC358
	protected override UniTask OnBeforeStartAsync()
	{
		TutorialView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TutorialView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017917 RID: 96535 RVA: 0x005FE19C File Offset: 0x005FC39C
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

	// Token: 0x06017918 RID: 96536 RVA: 0x005FE334 File Offset: 0x005FC534
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

	// Token: 0x06017919 RID: 96537 RVA: 0x005FE36F File Offset: 0x005FC56F
	private CommonTabItem ProxyCreate([Nullable(2)] UUIItem UUIItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0601791A RID: 96538 RVA: 0x005FE378 File Offset: 0x005FC578
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

	// Token: 0x0601791B RID: 96539 RVA: 0x005FE4F4 File Offset: 0x005FC6F4
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

	// Token: 0x0601791C RID: 96540 RVA: 0x005FE53F File Offset: 0x005FC73F
	private void HideDetaildView()
	{
		base.GetItem(4).SetUIActive(false);
		this.ItemData = null;
	}

	// Token: 0x0601791D RID: 96541 RVA: 0x005FE558 File Offset: 0x005FC758
	private CommonTabData GetCommonData(int index)
	{
		string tutorialTypeIconPath = TutorialUtils.GetTutorialTypeIconPath((ETutorialType)this.TypeList[index]);
		string tutorialTypeTxt = TutorialUtils.GetTutorialTypeTxt((ETutorialType)this.TypeList[index]);
		return new CommonTabData(tutorialTypeIconPath, new CommonTabTitleData(tutorialTypeTxt, Array.Empty<object>()), null);
	}

	// Token: 0x0601791E RID: 96542 RVA: 0x005FE59C File Offset: 0x005FC79C
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

	// Token: 0x0601791F RID: 96543 RVA: 0x005FE61C File Offset: 0x005FC81C
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

	// Token: 0x06017920 RID: 96544 RVA: 0x005FE6D4 File Offset: 0x005FC8D4
	protected override void OnAfterHide()
	{
		this.ItemScrollView.ClearChildren();
		this.HideDetaildView();
		this.NowSelectedToggle = null;
	}

	// Token: 0x06017921 RID: 96545 RVA: 0x005FE6F0 File Offset: 0x005FC8F0
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

	// Token: 0x06017922 RID: 96546 RVA: 0x005FE7BB File Offset: 0x005FC9BB
	private TutorialDataItem OnCreateTutorialItemView(TutorialItemData data, UUIItem UUIItem, int index)
	{
		TutorialDataItem tutorialDataItem = new TutorialDataItem();
		tutorialDataItem.InitData(data);
		tutorialDataItem.SetOnToggleSelected(new Action<TutorialItemData, UUIExtendToggle>(this.OnItemToggleSelected));
		return tutorialDataItem;
	}

	// Token: 0x06017923 RID: 96547 RVA: 0x005FE7DC File Offset: 0x005FC9DC
	private void OnTutorialUpdate()
	{
		List<TutorialItemData> unlockedTutorialDataByType = TutorialModel.Instance.GetUnlockedTutorialDataByType(this.CurrentSelectType.Value, this.ExclusiveType);
		for (int i = 0; i < unlockedTutorialDataByType.Count; i++)
		{
			unlockedTutorialDataByType[i].Selected = new bool?(i == 0);
		}
		this.ItemScrollView.RefreshByData(unlockedTutorialDataByType.ToArray(), false, false);
	}

	// Token: 0x06017924 RID: 96548 RVA: 0x005FE840 File Offset: 0x005FCA40
	private void OnTutortialRedUpdate(int i)
	{
		TutorialDataItem[] scrollItemItems = this.ItemScrollView.GetScrollItemItems();
		for (int j = 0; j < scrollItemItems.Length; j++)
		{
			scrollItemItems[j].RefreshRed();
		}
	}

	// Token: 0x06017925 RID: 96549 RVA: 0x005FE86F File Offset: 0x005FCA6F
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

	// Token: 0x06017926 RID: 96550 RVA: 0x005FE8AC File Offset: 0x005FCAAC
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
		this.PageIds = guideTutorialPageIds.ToList<int>();
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

	// Token: 0x06017927 RID: 96551 RVA: 0x005FEA2C File Offset: 0x005FCC2C
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

	// Token: 0x06017928 RID: 96552 RVA: 0x005FEBC8 File Offset: 0x005FCDC8
	private void OnClickBtnLast()
	{
		if (this.CurrDisplayIndex > 0)
		{
			this.UiViewSequence.PlaySequence("SwitchLeft", false, null);
			this.RefreshPageView(this.CurrDisplayIndex - 1);
		}
	}

	// Token: 0x06017929 RID: 96553 RVA: 0x005FEC08 File Offset: 0x005FCE08
	private void OnClickBtnNext()
	{
		if (this.CurrDisplayIndex < this.PageIds.Count - 1)
		{
			this.UiViewSequence.PlaySequence("SwitchRight", false, null);
			this.RefreshPageView(this.CurrDisplayIndex + 1);
		}
	}

	// Token: 0x0601792A RID: 96554 RVA: 0x005FEC52 File Offset: 0x005FCE52
	private void OnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AFCB RID: 45003
	public bool IsOpenedByGuide;

	// Token: 0x0400AFCC RID: 45004
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x0400AFCD RID: 45005
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<TutorialDataItem, TutorialDynItem, TutorialItemData> ItemScrollView;

	// Token: 0x0400AFCE RID: 45006
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<TutorialPageItem> PageDotLayout;

	// Token: 0x0400AFCF RID: 45007
	[Nullable(2)]
	private CommonSearchComponent SearchComponent;

	// Token: 0x0400AFD0 RID: 45008
	private ETutorialType? CurrentSelectType;

	// Token: 0x0400AFD1 RID: 45009
	[Nullable(2)]
	private UUIExtendToggle NowSelectedToggle;

	// Token: 0x0400AFD2 RID: 45010
	private List<int> TypeList = new List<int>();

	// Token: 0x0400AFD3 RID: 45011
	private int CurrDisplayIndex;

	// Token: 0x0400AFD4 RID: 45012
	[Nullable(2)]
	private TutorialItemData ItemData;

	// Token: 0x0400AFD5 RID: 45013
	[Nullable(2)]
	private List<int> PageIds;

	// Token: 0x0400AFD6 RID: 45014
	private EExclusiveTutorialType ExclusiveType;

	// Token: 0x0400AFD7 RID: 45015
	private int RefreshTargetTutorialId = -1;

	// Token: 0x0200921F RID: 37407
	[NullableContext(0)]
	public enum ETutorialsComponents
	{
		// Token: 0x0402F431 RID: 193585
		UUIItemCaptionList,
		// Token: 0x0402F432 RID: 193586
		UUIItemInputBox,
		// Token: 0x0402F433 RID: 193587
		DynScrollView,
		// Token: 0x0402F434 RID: 193588
		PnlList,
		// Token: 0x0402F435 RID: 193589
		PnlRight,
		// Token: 0x0402F436 RID: 193590
		UUIItemEmpty,
		// Token: 0x0402F437 RID: 193591
		TexPicture,
		// Token: 0x0402F438 RID: 193592
		TxtArea,
		// Token: 0x0402F439 RID: 193593
		PnlOffset,
		// Token: 0x0402F43A RID: 193594
		TxtSubTitle,
		// Token: 0x0402F43B RID: 193595
		TxtTutorials,
		// Token: 0x0402F43C RID: 193596
		PnlBottom,
		// Token: 0x0402F43D RID: 193597
		PnlPages,
		// Token: 0x0402F43E RID: 193598
		UUIItemPagesDot,
		// Token: 0x0402F43F RID: 193599
		BtnArrowL,
		// Token: 0x0402F440 RID: 193600
		BtnArrowR
	}
}
