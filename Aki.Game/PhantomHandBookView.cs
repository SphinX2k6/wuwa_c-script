using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E40 RID: 7744
[NullableContext(1)]
[Nullable(0)]
public class PhantomHandBookView : HandBookBaseView
{
	// Token: 0x0600EB68 RID: 60264 RVA: 0x0037D6BC File Offset: 0x0037B8BC
	public PhantomHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.PhantomHandBookPageList = new List<PhantomHandBookPage>();
		this.HandBookFetterItemList = new List<HandBookFetterItem>();
		this.HandBookPhantomItemList = new List<HandBookPhantomItem>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x0600EB69 RID: 60265 RVA: 0x0037D6F1 File Offset: 0x0037B8F1
	protected override void OnStart()
	{
		base.SetDefaultState();
		this.Refresh();
	}

	// Token: 0x0600EB6A RID: 60266 RVA: 0x0037D700 File Offset: 0x0037B900
	protected override void OnAfterShow()
	{
		this.UiCameraHandleData = UiCameraAnimationManager.Instance.PushCameraHandleByHandleName("1062", false, false, "1001", false, null, null);
	}

	// Token: 0x0600EB6B RID: 60267 RVA: 0x0037D734 File Offset: 0x0037B934
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600EB6C RID: 60268 RVA: 0x0037D73C File Offset: 0x0037B93C
	protected void Refresh()
	{
		this.RefreshTabComponent();
		this.RefreshPhantomTitle();
		this.RefreshPhantom();
		this.RefreshCollectText();
		this.RefreshLockText();
	}

	// Token: 0x0600EB6D RID: 60269 RVA: 0x0037D75C File Offset: 0x0037B95C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB6E RID: 60270 RVA: 0x0037D7C0 File Offset: 0x0037B9C0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EB6F RID: 60271 RVA: 0x0037D824 File Offset: 0x0037BA24
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Phantom)
		{
			return;
		}
		int count = this.HandBookCommonItemList.Count;
		for (int i = 0; i < count; i++)
		{
			HandBookCommonItem handBookCommonItem = this.HandBookCommonItemList[i];
			HandBookCommonItemData data = handBookCommonItem.GetData();
			PhantomHandBook? phantomHandBook = data.Config as PhantomHandBook?;
			if (phantomHandBook != null && phantomHandBook.Value.Id == id)
			{
				data.IsNew = false;
				handBookCommonItem.SetNewFlagVisible(new bool?(false));
				return;
			}
		}
	}

	// Token: 0x0600EB70 RID: 60272 RVA: 0x0037D8A4 File Offset: 0x0037BAA4
	protected void TabToggleCallBack(int index)
	{
		base.SetDefaultState();
		base.GetItem(0).SetUIActive(true);
		int id = this.PhantomHandBookPageList[index].Id;
		this.PageType = new EPhantomHandBookPageType?((EPhantomHandBookPageType)id);
		if (id == 0)
		{
			this.RefreshPhantomTitle();
			this.RefreshPhantom();
			return;
		}
		this.RefreshPhantomFetterTitle();
		this.RefreshPhantomFetter();
	}

	// Token: 0x0600EB71 RID: 60273 RVA: 0x0037D904 File Offset: 0x0037BB04
	protected override HandBookCommonItem InitHandBookCommonItem()
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		this.HandBookCommonItemList.Add(handBookCommonItem);
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		return handBookCommonItem;
	}

	// Token: 0x0600EB72 RID: 60274 RVA: 0x0037D938 File Offset: 0x0037BB38
	protected void OnToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		HandBookCommonItemData handBookCommonItemData = callbackParameter.Data as HandBookCommonItemData;
		int gridIndex = (callbackParameter.MediumItemGrid as HandBookCommonItem).GridIndex;
		this.ScrollViewCommon.DeselectCurrentGridProxy(false);
		this.ScrollViewCommon.SelectGridProxy(gridIndex, false);
		this.ScrollViewCommon.RefreshGridProxy(gridIndex);
		if (handBookCommonItemData.IsLock)
		{
			base.SetLockState(true);
			return;
		}
		base.SetLockState(false);
		this.RefreshPhantomContent(handBookCommonItemData);
	}

	// Token: 0x0600EB73 RID: 60275 RVA: 0x0037D9A8 File Offset: 0x0037BBA8
	protected void RefreshPhantomContent(HandBookCommonItemData handBookCommonItemData)
	{
		if (this.PageType.GetValueOrDefault() == EPhantomHandBookPageType.PhantomFetter)
		{
			return;
		}
		base.GetVerticalLayout(18).RootUIComp.Get().SetUIActive(false);
		PhantomHandBook? phantomHandBook = handBookCommonItemData.Config as PhantomHandBook?;
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, phantomHandBook.Value.Id);
		if (handBookInfo != null)
		{
			base.SetDateText(handBookInfo.CreateTime);
		}
		if (handBookCommonItemData.IsNew)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Phantom, phantomHandBook.Value.Id);
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.Name, null);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.TypeDescrtption, null);
		string localTextNew3 = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.Intensity, null);
		List<string> list = new List<string>();
		if (localTextNew3 != null)
		{
			list.Add(localTextNew3);
		}
		if (localTextNew2 != null)
		{
			list.Add(localTextNew2);
		}
		if (localTextNew != null)
		{
			base.SetNameText(localTextNew);
		}
		base.InitInfoItemLayout(list);
		HandBookController.Instance.SetPhantomMeshShow(phantomHandBook.Value.Id, this.SkeletalObserverHandle);
		List<HandBookContentItemData> list2 = new List<HandBookContentItemData>();
		string localTextNew4 = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.Title1, null);
		string localTextNew5 = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.Descrtption1, null);
		string localTextNew6 = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.Title2, null);
		string localTextNew7 = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.Value.Descrtption2, null);
		if (localTextNew4 != null && localTextNew5 != null)
		{
			list2.Add(new HandBookContentItemData(localTextNew4, localTextNew5));
		}
		if (localTextNew6 != null && localTextNew7 != null)
		{
			list2.Add(new HandBookContentItemData(localTextNew6, localTextNew7));
		}
		base.InitContentItemLayout(list2);
	}

	// Token: 0x0600EB74 RID: 60276 RVA: 0x0037DB78 File Offset: 0x0037BD78
	protected void RefreshPhantom()
	{
		this.RefreshCollectText();
		base.GetItem(26).SetUIActive(true);
		IReadOnlyList<PhantomHandBook> phantomHandBookConfig = HandBookConfig.Instance.GetPhantomHandBookConfig();
		List<HandBookCommonItemData> list = new List<HandBookCommonItemData>();
		int num = (phantomHandBookConfig != null) ? phantomHandBookConfig.Count : 0;
		for (int i = 0; i < num; i++)
		{
			PhantomHandBook phantomHandBook = phantomHandBookConfig[i];
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(phantomHandBook.TypeDescrtption, null);
			if (localTextNew != null)
			{
				handBookCommonItemData.Title = localTextNew;
			}
			IReadOnlyList<PhantomItem> phantomItemConfigListByMonsterId = InventoryConfig.Instance.GetPhantomItemConfigListByMonsterId(phantomHandBook.Id);
			if (phantomItemConfigListByMonsterId != null && phantomItemConfigListByMonsterId.Count > 0)
			{
				PhantomItem phantomItem = phantomItemConfigListByMonsterId[0];
				HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Phantom, phantomItem.MonsterId);
				bool isLock = handBookInfo == null;
				bool isNew = handBookInfo != null && !handBookInfo.IsRead;
				handBookCommonItemData.Icon = phantomItem.IconSmall;
				handBookCommonItemData.Config = phantomHandBook;
				handBookCommonItemData.IsLock = isLock;
				handBookCommonItemData.IsNew = isNew;
				list.Add(handBookCommonItemData);
			}
		}
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
		base.InitScrollViewByCommonItem(list);
	}

	// Token: 0x0600EB75 RID: 60277 RVA: 0x0037DC96 File Offset: 0x0037BE96
	protected override CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600EB76 RID: 60278 RVA: 0x0037DCA0 File Offset: 0x0037BEA0
	public override List<CommonTabItemData> GetTabItemData(List<CommonTabData> tabData)
	{
		int count = tabData.Count;
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		for (int i = 0; i < count; i++)
		{
			CommonTabItemData commonTabItemData = new CommonTabItemData();
			commonTabItemData.Index = i;
			if (i == 0)
			{
				commonTabItemData.RedDotName = new ERedDotName?(ERedDotName.PhantomHandBook);
			}
			commonTabItemData.Data = this.TabList[i];
			list.Add(commonTabItemData);
		}
		return list;
	}

	// Token: 0x0600EB77 RID: 60279 RVA: 0x0037DD00 File Offset: 0x0037BF00
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Phantom);
		base.SetCollectText(collectProgress[0], collectProgress[1]);
	}

	// Token: 0x0600EB78 RID: 60280 RVA: 0x0037DD28 File Offset: 0x0037BF28
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("PhantomHandBookLock");
		if (textById != null)
		{
			base.SetLockText(textById);
		}
	}

	// Token: 0x0600EB79 RID: 60281 RVA: 0x0037DD50 File Offset: 0x0037BF50
	protected void RefreshTabComponent()
	{
		this.PhantomHandBookPageList = ConfigCommon.ToList<PhantomHandBookPage>(HandBookConfig.Instance.GetPhantomHandBookPageConfig());
		this.PhantomHandBookPageList.Sort(new Comparison<PhantomHandBookPage>(this.SortIndex));
		int count = this.PhantomHandBookPageList.Count;
		List<CommonTabData> list = new List<CommonTabData>();
		for (int i = 0; i < count; i++)
		{
			list.Add(new CommonTabData(this.PhantomHandBookPageList[i].Icon, null, null));
		}
		base.InitTabComponent(list);
		base.SetTabToggleCallBack(new Action<int>(this.TabToggleCallBack));
	}

	// Token: 0x0600EB7A RID: 60282 RVA: 0x0037DDE4 File Offset: 0x0037BFE4
	protected void RefreshPhantomTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Phantom);
		base.InitCommonTabTitle(handBookEntranceConfig.Value.TitleIcon, new CommonTabTitleData(handBookEntranceConfig.Value.Name, Array.Empty<object>()));
	}

	// Token: 0x0600EB7B RID: 60283 RVA: 0x0037DE2C File Offset: 0x0037C02C
	protected void RefreshPhantomFetterTitle()
	{
		string textContentIdById = TextConfig.Instance.GetTextContentIdById("Fetter");
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Phantom);
		if (textContentIdById != null)
		{
			base.InitCommonTabTitle(handBookEntranceConfig.Value.TitleIcon, new CommonTabTitleData(textContentIdById, Array.Empty<object>()));
		}
	}

	// Token: 0x0600EB7C RID: 60284 RVA: 0x0037DE78 File Offset: 0x0037C078
	private int SortIndex(PhantomHandBookPage a, PhantomHandBookPage b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600EB7D RID: 60285 RVA: 0x0037DE8C File Offset: 0x0037C08C
	protected void RefreshPhantomFetter()
	{
		base.GetItem(26).SetUIActive(true);
		base.GetText(23).SetUIActive(false);
		IReadOnlyList<PhantomFetterHandBook> phantomFetterHandBookConfig = HandBookConfig.Instance.GetPhantomFetterHandBookConfig();
		List<PhantomFetter> list = new List<PhantomFetter>();
		int num = (phantomFetterHandBookConfig != null) ? phantomFetterHandBookConfig.Count : 0;
		for (int i = 0; i < num; i++)
		{
			PhantomFetterHandBook phantomFetterHandBook = phantomFetterHandBookConfig[i];
			PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(phantomFetterHandBook.Id);
			list.Add(phantomFetterById);
		}
		this.HandBookFetterItemList = new List<HandBookFetterItem>();
		base.InitScrollViewByFetterItem(list);
		this.InitToggleState();
		base.GetText(17).SetUIActive(false);
	}

	// Token: 0x0600EB7E RID: 60286 RVA: 0x0037DF2C File Offset: 0x0037C12C
	protected void InitToggleState()
	{
		int count = this.HandBookFetterItemList.Count;
		for (int i = 0; i < count; i++)
		{
			HandBookFetterItem handBookFetterItem = this.HandBookFetterItemList[i];
			if (i == 0)
			{
				handBookFetterItem.SetToggleStateForce(EToggleState.ETT_Checked, false);
				handBookFetterItem.OnSelected(true);
			}
			else
			{
				handBookFetterItem.SetToggleStateForce(EToggleState.ETT_UnChecked, false);
			}
		}
	}

	// Token: 0x0600EB7F RID: 60287 RVA: 0x0037DF7C File Offset: 0x0037C17C
	protected void RefreshHandBookPhantomLayout(PhantomFetter phantomFetter)
	{
		List<HandBookCommonItemData> handBookCommonItemData = new List<HandBookCommonItemData>();
		base.InitHandBookPhantomLayout(handBookCommonItemData);
		this.RefreshHandBookPhantomItemToggleState();
	}

	// Token: 0x0600EB80 RID: 60288 RVA: 0x0037DF9C File Offset: 0x0037C19C
	protected void RefreshHandBookPhantomItemToggleState()
	{
		int count = this.HandBookPhantomItemList.Count;
		if (count == 0)
		{
			return;
		}
		for (int i = 0; i < count; i++)
		{
			HandBookPhantomItem handBookPhantomItem = this.HandBookPhantomItemList[i];
			if (i == 0)
			{
				handBookPhantomItem.SetToggleStateForce(EToggleState.ETT_Checked, false);
				handBookPhantomItem.OnSelected(true);
			}
			else
			{
				handBookPhantomItem.SetToggleStateForce(EToggleState.ETT_UnChecked, false);
			}
		}
	}

	// Token: 0x0600EB81 RID: 60289 RVA: 0x0037DFF0 File Offset: 0x0037C1F0
	protected override ILayoutItem<HandBookPhantomItem> InitHandBookPhantom(object data, UUIItem uiItem, int index)
	{
		HandBookPhantomItem handBookPhantomItem = new HandBookPhantomItem();
		handBookPhantomItem.Initialize((HandBookCommonItemData)data, uiItem);
		handBookPhantomItem.BindToggleCallback(new THandBookPhantomItemToggleFunction(this.OnPhantomToggleClick));
		this.HandBookPhantomItemList.Add(handBookPhantomItem);
		return new LayoutItem<HandBookPhantomItem>
		{
			Key = index,
			Value = handBookPhantomItem
		};
	}

	// Token: 0x0600EB82 RID: 60290 RVA: 0x0037E048 File Offset: 0x0037C248
	protected override void OnPhantomToggleClick(HandBookCommonItemData handBookCommonItemData, int index)
	{
		EPhantomHandBookPageType? pageType = this.PageType;
		EPhantomHandBookPageType ephantomHandBookPageType = EPhantomHandBookPageType.Phantom;
		if (pageType.GetValueOrDefault() == ephantomHandBookPageType & pageType != null)
		{
			return;
		}
		PhantomItem? phantomItem = handBookCommonItemData.Config as PhantomItem?;
		base.SetLockState(false);
		if (handBookCommonItemData.IsNew)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Phantom, phantomItem.Value.ItemId);
		}
		PhantomHandBook? phantomHandBookConfigById = HandBookConfig.Instance.GetPhantomHandBookConfigById(phantomItem.Value.MonsterId);
		if (phantomHandBookConfigById == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.BB, "怪物id为:" + phantomItem.Value.MonsterId.ToString() + "对应声骸图鉴数据找不到！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!handBookCommonItemData.IsLock)
		{
			HandBookController.Instance.SetPhantomMeshShow(phantomHandBookConfigById.Value.Id, this.SkeletalObserverHandle);
		}
	}

	// Token: 0x0600EB83 RID: 60291 RVA: 0x0037E13C File Offset: 0x0037C33C
	protected override HandBookFetterItem InitHandBookFetterItem()
	{
		HandBookFetterItem handBookFetterItem = new HandBookFetterItem();
		handBookFetterItem.BindFetterToggleCallback(new TFetterToggleFunction(this.OnFetterToggleClicked));
		this.HandBookFetterItemList.Add(handBookFetterItem);
		return handBookFetterItem;
	}

	// Token: 0x0600EB84 RID: 60292 RVA: 0x0037E170 File Offset: 0x0037C370
	private void OnFetterToggleClicked(HandBookFetterItem handBookFetterItem)
	{
		int girdIndex = handBookFetterItem.GetGirdIndex();
		this.ScrollViewFetter.DeselectCurrentGridProxy(false);
		this.ScrollViewFetter.SelectGridProxy(girdIndex, false);
		this.ScrollViewFetter.RefreshGridProxy(girdIndex);
		PhantomFetter? phantomFetter = handBookFetterItem.GetPhantomFetter();
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(phantomFetter.Value.Name, null);
		if (localTextNew != null)
		{
			base.SetNameText(localTextNew);
		}
		this.RefreshPhantomFetterLayout(phantomFetter.Value);
		this.RefreshHandBookPhantomLayout(phantomFetter.Value);
	}

	// Token: 0x0600EB85 RID: 60293 RVA: 0x0037E1EC File Offset: 0x0037C3EC
	protected void RefreshPhantomFetterLayout(PhantomFetter phantomFetter)
	{
		List<HandBookContentItemData> list = new List<HandBookContentItemData>();
		string textById = TextConfig.Instance.GetTextById("FetterEffectDescription");
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(phantomFetter.EffectDescription, null);
		string textById2 = TextConfig.Instance.GetTextById("FetterEffectDefineDescription");
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(phantomFetter.EffectDefineDescription, null);
		if (textById != null && localTextNew != null)
		{
			list.Add(new HandBookContentItemData(textById, localTextNew));
		}
		if (textById2 != null && localTextNew2 != null)
		{
			list.Add(new HandBookContentItemData(textById2, localTextNew2));
		}
		base.InitContentItemLayout(list);
	}

	// Token: 0x0600EB86 RID: 60294 RVA: 0x0037E26B File Offset: 0x0037C46B
	protected override void OnBeforePlayCloseSequence()
	{
		if (this.UiCameraHandleData != null)
		{
			UiCameraAnimationManager.Instance.PopCameraHandle(this.UiCameraHandleData, null);
		}
	}

	// Token: 0x0600EB87 RID: 60295 RVA: 0x0037E286 File Offset: 0x0037C486
	protected override void OnBeforeCreateImplementImplement()
	{
		UiSceneManager.Instance.InitPhantomObserver();
		this.SkeletalObserverHandle = UiSceneManager.Instance.GetPhantomObserver();
	}

	// Token: 0x0600EB88 RID: 60296 RVA: 0x0037E2A2 File Offset: 0x0037C4A2
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyPhantomObserver();
		this.SkeletalObserverHandle = null;
		this.PhantomHandBookPageList = new List<PhantomHandBookPage>();
		this.HandBookFetterItemList = new List<HandBookFetterItem>();
		this.HandBookPhantomItemList = new List<HandBookPhantomItem>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x04006D40 RID: 27968
	private List<PhantomHandBookPage> PhantomHandBookPageList;

	// Token: 0x04006D41 RID: 27969
	private List<HandBookFetterItem> HandBookFetterItemList;

	// Token: 0x04006D42 RID: 27970
	private List<HandBookPhantomItem> HandBookPhantomItemList;

	// Token: 0x04006D43 RID: 27971
	private List<HandBookCommonItem> HandBookCommonItemList;

	// Token: 0x04006D44 RID: 27972
	private EPhantomHandBookPageType? PageType;

	// Token: 0x04006D45 RID: 27973
	[Nullable(2)]
	private UiCameraHandleData UiCameraHandleData;

	// Token: 0x04006D46 RID: 27974
	[Nullable(2)]
	private SkeletalObserverHandle SkeletalObserverHandle;
}
