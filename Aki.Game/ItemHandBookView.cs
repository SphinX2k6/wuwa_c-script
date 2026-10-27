using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E2D RID: 7725
[NullableContext(1)]
[Nullable(0)]
public class ItemHandBookView : HandBookBaseView
{
	// Token: 0x0600EADB RID: 60123 RVA: 0x0037A394 File Offset: 0x00378594
	public ItemHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EADC RID: 60124 RVA: 0x0037A3E4 File Offset: 0x003785E4
	protected override void OnStart()
	{
		base.SetDefaultState();
		this.RefreshTabComponent();
		this.RefreshItemTitle();
		this.RefreshCollectText();
		this.RefreshLockText();
		int? firstPageType = this.GetFirstPageType();
		if (firstPageType != null)
		{
			this.RefreshScrollView(firstPageType.Value);
		}
	}

	// Token: 0x0600EADD RID: 60125 RVA: 0x0037A42C File Offset: 0x0037862C
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600EADE RID: 60126 RVA: 0x0037A434 File Offset: 0x00378634
	protected void Refresh()
	{
		int? firstPageType = this.GetFirstPageType();
		if (firstPageType != null)
		{
			this.RefreshScrollView(firstPageType.Value);
		}
	}

	// Token: 0x0600EADF RID: 60127 RVA: 0x0037A460 File Offset: 0x00378660
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EAE0 RID: 60128 RVA: 0x0037A4C4 File Offset: 0x003786C4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EAE1 RID: 60129 RVA: 0x0037A528 File Offset: 0x00378728
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Item)
		{
			return;
		}
		int count = this.HandBookCommonItemList.Count;
		for (int i = 0; i < count; i++)
		{
			HandBookCommonItem handBookCommonItem = this.HandBookCommonItemList[i];
			if (((ItemHandBook)handBookCommonItem.GetData().Config).Id == id)
			{
				handBookCommonItem.SetNewFlagVisible(new bool?(false));
				return;
			}
		}
	}

	// Token: 0x0600EAE2 RID: 60130 RVA: 0x0037A588 File Offset: 0x00378788
	protected void TabToggleCallBack(int index)
	{
		int id = this.ItemHandBookTypeList[index].Id;
		this.RefreshScrollView(id);
	}

	// Token: 0x0600EAE3 RID: 60131 RVA: 0x0037A5B4 File Offset: 0x003787B4
	protected override HandBookCommonItem InitHandBookCommonItem()
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		this.HandBookCommonItemList.Add(handBookCommonItem);
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		return handBookCommonItem;
	}

	// Token: 0x0600EAE4 RID: 60132 RVA: 0x0037A5E8 File Offset: 0x003787E8
	protected void OnToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		HandBookCommonItemData handBookCommonItemData = callbackParameter.Data as HandBookCommonItemData;
		int gridIndex = (callbackParameter.MediumItemGrid as HandBookCommonItem).GridIndex;
		this.ScrollViewCommon.DeselectCurrentGridProxy(false);
		this.ScrollViewCommon.SelectGridProxy(gridIndex, false);
		this.ScrollViewCommon.RefreshGridProxy(gridIndex);
		this.RefreshTitleText(((ItemHandBook)handBookCommonItemData.Config).Id);
		if (handBookCommonItemData.IsLock)
		{
			this.SetItemLockState(true);
			return;
		}
		this.SetItemLockState(false);
		this.RefreshItemContent(handBookCommonItemData);
	}

	// Token: 0x0600EAE5 RID: 60133 RVA: 0x0037A66E File Offset: 0x0037886E
	protected void SetItemLockState(bool state)
	{
		base.SetLockState(state);
		base.GetTexture(25).SetUIActive(!state);
	}

	// Token: 0x0600EAE6 RID: 60134 RVA: 0x0037A688 File Offset: 0x00378888
	protected void RefreshItemContent(HandBookCommonItemData handBookCommonItemData)
	{
		ItemHandBook itemHandBook = (ItemHandBook)handBookCommonItemData.Config;
		if (handBookCommonItemData.IsNew)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Item, itemHandBook.Id);
		}
		ItemInfo value = InventoryConfig.Instance.GetItemConfig(itemHandBook.Id).Value;
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(value.Name, null);
		base.SetNameText(localTextNew);
		base.SetItemTexture(value.IconMiddle);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(itemHandBook.Title, null);
		List<string> list = new List<string>();
		if (localTextNew2 != null)
		{
			list.Add(localTextNew2);
		}
		base.InitInfoItemLayout(list);
		List<HandBookContentItemData> list2 = new List<HandBookContentItemData>();
		string desc = ConfigMultiTextLang.GetLocalTextNew(value.BgDescription, null) ?? "";
		list2.Add(new HandBookContentItemData("", desc));
		base.InitContentItemLayout(list2);
		this.RefreshOwnText(value.Id);
	}

	// Token: 0x0600EAE7 RID: 60135 RVA: 0x0037A768 File Offset: 0x00378968
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Item);
		base.SetCollectText(collectProgress[0], collectProgress[1]);
	}

	// Token: 0x0600EAE8 RID: 60136 RVA: 0x0037A790 File Offset: 0x00378990
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("ItemHandBookLock");
		base.SetLockText(textById);
	}

	// Token: 0x0600EAE9 RID: 60137 RVA: 0x0037A7B4 File Offset: 0x003789B4
	protected void RefreshOwnText(int itemId)
	{
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Item, itemId);
		base.SetOwnText(handBookInfo.Num);
	}

	// Token: 0x0600EAEA RID: 60138 RVA: 0x0037A7DC File Offset: 0x003789DC
	protected int GetFirstTypeId()
	{
		return HandBookConfig.Instance.GetItemHandBookTypeConfigList()[0].Id;
	}

	// Token: 0x0600EAEB RID: 60139 RVA: 0x0037A804 File Offset: 0x00378A04
	protected void RefreshScrollView(int type)
	{
		if (type == 0)
		{
			return;
		}
		IReadOnlyList<ItemHandBook> itemHandBookConfigByType = HandBookConfig.Instance.GetItemHandBookConfigByType(type);
		List<HandBookCommonItemData> list = new List<HandBookCommonItemData>();
		int count = itemHandBookConfigByType.Count;
		for (int i = 0; i < count; i++)
		{
			ItemHandBook itemHandBook = itemHandBookConfigByType[i];
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Item, itemHandBook.Id);
			bool isLock = handBookInfo == null;
			bool isNew = handBookInfo != null && !handBookInfo.IsRead;
			HandBookCommonItemData handBookCommonItemData = new HandBookCommonItemData();
			ItemInfo value = InventoryConfig.Instance.GetItemConfig(itemHandBook.Id).Value;
			handBookCommonItemData.Icon = value.IconSmall;
			handBookCommonItemData.QualityId = value.QualityId;
			handBookCommonItemData.ConfigId = value.Id;
			handBookCommonItemData.IsLock = isLock;
			handBookCommonItemData.IsNew = isNew;
			handBookCommonItemData.Config = itemHandBook;
			list.Add(handBookCommonItemData);
		}
		base.InitScrollViewByCommonItem(list);
	}

	// Token: 0x0600EAEC RID: 60140 RVA: 0x0037A8F4 File Offset: 0x00378AF4
	protected int? GetFirstPageType()
	{
		if (this.ItemHandBookTypeList.Count == 0)
		{
			return null;
		}
		return new int?(this.ItemHandBookTypeList[0].Id);
	}

	// Token: 0x0600EAED RID: 60141 RVA: 0x0037A934 File Offset: 0x00378B34
	protected void RefreshTabComponent()
	{
		this.ItemHandBookTypeList = ConfigCommon.ToList<ItemHandBookType>(HandBookConfig.Instance.GetItemHandBookTypeConfigList());
		this.ItemHandBookTypeList.Sort(this.SortIndex);
		int count = this.ItemHandBookTypeList.Count;
		List<CommonTabData> list = new List<CommonTabData>();
		for (int i = 0; i < count; i++)
		{
			list.Add(new CommonTabData(this.ItemHandBookTypeList[i].Icon, null, null));
		}
		base.InitTabComponent(list);
		base.SetTabToggleCallBack(new Action<int>(this.TabToggleCallBack));
	}

	// Token: 0x0600EAEE RID: 60142 RVA: 0x0037A9C0 File Offset: 0x00378BC0
	protected void RefreshItemTitle()
	{
		HandBookEntrance value = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Item).Value;
		base.InitCommonTabTitle(value.TitleIcon, new CommonTabTitleData(value.Name, Array.Empty<object>()));
	}

	// Token: 0x0600EAEF RID: 60143 RVA: 0x0037AA00 File Offset: 0x00378C00
	protected void RefreshTitleText(int id)
	{
		ItemHandBook value = HandBookConfig.Instance.GetItemHandBookConfigById(id).Value;
		base.UpdateTitle(new CommonTabTitleData(HandBookConfig.Instance.GetItemHandBookTypeConfig(value.Type).Value.Descrtption, Array.Empty<object>()));
	}

	// Token: 0x0600EAF0 RID: 60144 RVA: 0x0037AA52 File Offset: 0x00378C52
	protected override CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600EAF1 RID: 60145 RVA: 0x0037AA5C File Offset: 0x00378C5C
	public override List<CommonTabItemData> GetTabItemData(List<CommonTabData> tabData)
	{
		int count = tabData.Count;
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		for (int i = 0; i < count; i++)
		{
			list.Add(new CommonTabItemData
			{
				Index = i,
				RedDotName = new ERedDotName?(ERedDotName.ItemHandBook),
				RedDotUid = new int?(this.ItemHandBookTypeList[i].Id),
				Data = this.TabList[i]
			});
		}
		return list;
	}

	// Token: 0x0600EAF2 RID: 60146 RVA: 0x0037AAD6 File Offset: 0x00378CD6
	protected override void OnBeforeDestroy()
	{
		this.ItemHandBookTypeList = new List<ItemHandBookType>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x04006CFD RID: 27901
	private List<ItemHandBookType> ItemHandBookTypeList = new List<ItemHandBookType>();

	// Token: 0x04006CFE RID: 27902
	private List<HandBookCommonItem> HandBookCommonItemList = new List<HandBookCommonItem>();

	// Token: 0x04006CFF RID: 27903
	private readonly Comparison<ItemHandBookType> SortIndex = (ItemHandBookType a, ItemHandBookType b) => a.Id - b.Id;
}
