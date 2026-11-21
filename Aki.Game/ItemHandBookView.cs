using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012EF RID: 4847
[NullableContext(1)]
[Nullable(0)]
public class ItemHandBookView : HandBookBaseView
{
	// Token: 0x0600BEFA RID: 48890 RVA: 0x00386020 File Offset: 0x00384220
	public ItemHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BEFB RID: 48891 RVA: 0x00386070 File Offset: 0x00384270
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

	// Token: 0x0600BEFC RID: 48892 RVA: 0x003860B8 File Offset: 0x003842B8
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BEFD RID: 48893 RVA: 0x003860C0 File Offset: 0x003842C0
	protected void Refresh()
	{
		int? firstPageType = this.GetFirstPageType();
		if (firstPageType != null)
		{
			this.RefreshScrollView(firstPageType.Value);
		}
	}

	// Token: 0x0600BEFE RID: 48894 RVA: 0x003860EC File Offset: 0x003842EC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BEFF RID: 48895 RVA: 0x00386150 File Offset: 0x00384350
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BF00 RID: 48896 RVA: 0x003861B4 File Offset: 0x003843B4
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

	// Token: 0x0600BF01 RID: 48897 RVA: 0x00386214 File Offset: 0x00384414
	protected void TabToggleCallBack(int index)
	{
		int id = this.ItemHandBookTypeList[index].Id;
		this.RefreshScrollView(id);
	}

	// Token: 0x0600BF02 RID: 48898 RVA: 0x00386240 File Offset: 0x00384440
	protected override HandBookCommonItem InitHandBookCommonItem()
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		this.HandBookCommonItemList.Add(handBookCommonItem);
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		return handBookCommonItem;
	}

	// Token: 0x0600BF03 RID: 48899 RVA: 0x00386274 File Offset: 0x00384474
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

	// Token: 0x0600BF04 RID: 48900 RVA: 0x003862FA File Offset: 0x003844FA
	protected void SetItemLockState(bool state)
	{
		base.SetLockState(state);
		base.GetTexture(25).SetUIActive(!state);
	}

	// Token: 0x0600BF05 RID: 48901 RVA: 0x00386314 File Offset: 0x00384514
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

	// Token: 0x0600BF06 RID: 48902 RVA: 0x003863F4 File Offset: 0x003845F4
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Item);
		base.SetCollectText(collectProgress[0], collectProgress[1]);
	}

	// Token: 0x0600BF07 RID: 48903 RVA: 0x0038641C File Offset: 0x0038461C
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("ItemHandBookLock");
		base.SetLockText(textById);
	}

	// Token: 0x0600BF08 RID: 48904 RVA: 0x00386440 File Offset: 0x00384640
	protected void RefreshOwnText(int itemId)
	{
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Item, itemId);
		base.SetOwnText(handBookInfo.Num);
	}

	// Token: 0x0600BF09 RID: 48905 RVA: 0x00386468 File Offset: 0x00384668
	protected int GetFirstTypeId()
	{
		return HandBookConfig.Instance.GetItemHandBookTypeConfigList()[0].Id;
	}

	// Token: 0x0600BF0A RID: 48906 RVA: 0x00386490 File Offset: 0x00384690
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

	// Token: 0x0600BF0B RID: 48907 RVA: 0x00386580 File Offset: 0x00384780
	protected int? GetFirstPageType()
	{
		if (this.ItemHandBookTypeList.Count == 0)
		{
			return null;
		}
		return new int?(this.ItemHandBookTypeList[0].Id);
	}

	// Token: 0x0600BF0C RID: 48908 RVA: 0x003865C0 File Offset: 0x003847C0
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

	// Token: 0x0600BF0D RID: 48909 RVA: 0x0038664C File Offset: 0x0038484C
	protected void RefreshItemTitle()
	{
		HandBookEntrance value = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Item).Value;
		base.InitCommonTabTitle(value.TitleIcon, new CommonTabTitleData(value.Name, Array.Empty<object>()));
	}

	// Token: 0x0600BF0E RID: 48910 RVA: 0x0038668C File Offset: 0x0038488C
	protected void RefreshTitleText(int id)
	{
		ItemHandBook value = HandBookConfig.Instance.GetItemHandBookConfigById(id).Value;
		base.UpdateTitle(new CommonTabTitleData(HandBookConfig.Instance.GetItemHandBookTypeConfig(value.Type).Value.Descrtption, Array.Empty<object>()));
	}

	// Token: 0x0600BF0F RID: 48911 RVA: 0x003866DE File Offset: 0x003848DE
	protected override CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600BF10 RID: 48912 RVA: 0x003866E8 File Offset: 0x003848E8
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

	// Token: 0x0600BF11 RID: 48913 RVA: 0x00386762 File Offset: 0x00384962
	protected override void OnBeforeDestroy()
	{
		this.ItemHandBookTypeList = new List<ItemHandBookType>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x04006DDE RID: 28126
	private List<ItemHandBookType> ItemHandBookTypeList = new List<ItemHandBookType>();

	// Token: 0x04006DDF RID: 28127
	private List<HandBookCommonItem> HandBookCommonItemList = new List<HandBookCommonItem>();

	// Token: 0x04006DE0 RID: 28128
	private readonly Comparison<ItemHandBookType> SortIndex = (ItemHandBookType a, ItemHandBookType b) => a.Id - b.Id;
}
