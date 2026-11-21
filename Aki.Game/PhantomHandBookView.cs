using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001302 RID: 4866
[NullableContext(1)]
[Nullable(0)]
public class PhantomHandBookView : HandBookBaseView
{
	// Token: 0x0600BF87 RID: 49031 RVA: 0x0038935C File Offset: 0x0038755C
	public PhantomHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.PhantomHandBookPageList = new List<PhantomHandBookPage>();
		this.HandBookFetterItemList = new List<HandBookFetterItem>();
		this.HandBookPhantomItemList = new List<HandBookPhantomItem>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x0600BF88 RID: 49032 RVA: 0x00389391 File Offset: 0x00387591
	protected override void OnStart()
	{
		base.SetDefaultState();
		this.Refresh();
	}

	// Token: 0x0600BF89 RID: 49033 RVA: 0x0038939F File Offset: 0x0038759F
	protected override void OnAfterShow()
	{
		this.UiCameraHandleData = UiCameraModel.Instance.PushCameraHandleByHandleName("1062", false, false, "1001", false, null);
	}

	// Token: 0x0600BF8A RID: 49034 RVA: 0x003893BF File Offset: 0x003875BF
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BF8B RID: 49035 RVA: 0x003893C7 File Offset: 0x003875C7
	protected void Refresh()
	{
		this.RefreshTabComponent();
		this.RefreshPhantomTitle();
		this.RefreshPhantom();
		this.RefreshCollectText();
		this.RefreshLockText();
	}

	// Token: 0x0600BF8C RID: 49036 RVA: 0x003893E8 File Offset: 0x003875E8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF8D RID: 49037 RVA: 0x0038944C File Offset: 0x0038764C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF8E RID: 49038 RVA: 0x003894B0 File Offset: 0x003876B0
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

	// Token: 0x0600BF8F RID: 49039 RVA: 0x00389530 File Offset: 0x00387730
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

	// Token: 0x0600BF90 RID: 49040 RVA: 0x00389590 File Offset: 0x00387790
	protected override HandBookCommonItem InitHandBookCommonItem()
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		this.HandBookCommonItemList.Add(handBookCommonItem);
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		return handBookCommonItem;
	}

	// Token: 0x0600BF91 RID: 49041 RVA: 0x003895C4 File Offset: 0x003877C4
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

	// Token: 0x0600BF92 RID: 49042 RVA: 0x00389634 File Offset: 0x00387834
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

	// Token: 0x0600BF93 RID: 49043 RVA: 0x00389804 File Offset: 0x00387A04
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

	// Token: 0x0600BF94 RID: 49044 RVA: 0x00389922 File Offset: 0x00387B22
	protected override CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600BF95 RID: 49045 RVA: 0x0038992C File Offset: 0x00387B2C
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

	// Token: 0x0600BF96 RID: 49046 RVA: 0x0038998C File Offset: 0x00387B8C
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Phantom);
		base.SetCollectText(collectProgress[0], collectProgress[1]);
	}

	// Token: 0x0600BF97 RID: 49047 RVA: 0x003899B4 File Offset: 0x00387BB4
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("PhantomHandBookLock");
		if (textById != null)
		{
			base.SetLockText(textById);
		}
	}

	// Token: 0x0600BF98 RID: 49048 RVA: 0x003899DC File Offset: 0x00387BDC
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

	// Token: 0x0600BF99 RID: 49049 RVA: 0x00389A70 File Offset: 0x00387C70
	protected void RefreshPhantomTitle()
	{
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Phantom);
		base.InitCommonTabTitle(handBookEntranceConfig.Value.TitleIcon, new CommonTabTitleData(handBookEntranceConfig.Value.Name, Array.Empty<object>()));
	}

	// Token: 0x0600BF9A RID: 49050 RVA: 0x00389AB8 File Offset: 0x00387CB8
	protected void RefreshPhantomFetterTitle()
	{
		string textContentIdById = TextConfig.Instance.GetTextContentIdById("Fetter");
		HandBookEntrance? handBookEntranceConfig = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Phantom);
		if (textContentIdById != null)
		{
			base.InitCommonTabTitle(handBookEntranceConfig.Value.TitleIcon, new CommonTabTitleData(textContentIdById, Array.Empty<object>()));
		}
	}

	// Token: 0x0600BF9B RID: 49051 RVA: 0x00389B04 File Offset: 0x00387D04
	private int SortIndex(PhantomHandBookPage a, PhantomHandBookPage b)
	{
		return a.Id - b.Id;
	}

	// Token: 0x0600BF9C RID: 49052 RVA: 0x00389B18 File Offset: 0x00387D18
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

	// Token: 0x0600BF9D RID: 49053 RVA: 0x00389BB8 File Offset: 0x00387DB8
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

	// Token: 0x0600BF9E RID: 49054 RVA: 0x00389C08 File Offset: 0x00387E08
	protected void RefreshHandBookPhantomLayout(PhantomFetter phantomFetter)
	{
		List<HandBookCommonItemData> handBookCommonItemData = new List<HandBookCommonItemData>();
		base.InitHandBookPhantomLayout(handBookCommonItemData);
		this.RefreshHandBookPhantomItemToggleState();
	}

	// Token: 0x0600BF9F RID: 49055 RVA: 0x00389C28 File Offset: 0x00387E28
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

	// Token: 0x0600BFA0 RID: 49056 RVA: 0x00389C7C File Offset: 0x00387E7C
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

	// Token: 0x0600BFA1 RID: 49057 RVA: 0x00389CD4 File Offset: 0x00387ED4
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

	// Token: 0x0600BFA2 RID: 49058 RVA: 0x00389DC8 File Offset: 0x00387FC8
	protected override HandBookFetterItem InitHandBookFetterItem()
	{
		HandBookFetterItem handBookFetterItem = new HandBookFetterItem();
		handBookFetterItem.BindFetterToggleCallback(new TFetterToggleFunction(this.OnFetterToggleClicked));
		this.HandBookFetterItemList.Add(handBookFetterItem);
		return handBookFetterItem;
	}

	// Token: 0x0600BFA3 RID: 49059 RVA: 0x00389DFC File Offset: 0x00387FFC
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

	// Token: 0x0600BFA4 RID: 49060 RVA: 0x00389E78 File Offset: 0x00388078
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

	// Token: 0x0600BFA5 RID: 49061 RVA: 0x00389EF7 File Offset: 0x003880F7
	protected override void OnBeforePlayCloseSequence()
	{
		if (this.UiCameraHandleData != null)
		{
			UiCameraModel.Instance.PopCameraHandle(this.UiCameraHandleData, null);
		}
	}

	// Token: 0x0600BFA6 RID: 49062 RVA: 0x00389F13 File Offset: 0x00388113
	protected override void OnBeforeCreateImplementImplement()
	{
		UiSceneManager.Instance.InitPhantomObserver();
		this.SkeletalObserverHandle = UiSceneManager.Instance.GetPhantomObserver();
	}

	// Token: 0x0600BFA7 RID: 49063 RVA: 0x00389F2F File Offset: 0x0038812F
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyPhantomObserver();
		this.SkeletalObserverHandle = null;
		this.PhantomHandBookPageList = new List<PhantomHandBookPage>();
		this.HandBookFetterItemList = new List<HandBookFetterItem>();
		this.HandBookPhantomItemList = new List<HandBookPhantomItem>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x04006E21 RID: 28193
	private List<PhantomHandBookPage> PhantomHandBookPageList;

	// Token: 0x04006E22 RID: 28194
	private List<HandBookFetterItem> HandBookFetterItemList;

	// Token: 0x04006E23 RID: 28195
	private List<HandBookPhantomItem> HandBookPhantomItemList;

	// Token: 0x04006E24 RID: 28196
	private List<HandBookCommonItem> HandBookCommonItemList;

	// Token: 0x04006E25 RID: 28197
	private EPhantomHandBookPageType? PageType;

	// Token: 0x04006E26 RID: 28198
	[Nullable(2)]
	private UiCameraHandleData UiCameraHandleData;

	// Token: 0x04006E27 RID: 28199
	[Nullable(2)]
	private SkeletalObserverHandle SkeletalObserverHandle;
}
