using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;

// Token: 0x02001DCF RID: 7631
[NullableContext(1)]
[Nullable(0)]
public class AnimalHandBookView : HandBookBaseView
{
	// Token: 0x0600E84E RID: 59470 RVA: 0x0036F75A File Offset: 0x0036D95A
	public AnimalHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.ConfigList = new List<AnimalHandBook>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x0600E84F RID: 59471 RVA: 0x0036F779 File Offset: 0x0036D979
	protected override void OnStart()
	{
		base.SetDefaultState();
		this.Refresh();
		this.RefreshLockText();
	}

	// Token: 0x0600E850 RID: 59472 RVA: 0x0036F790 File Offset: 0x0036D990
	protected override void OnAfterShow()
	{
		this.UiCameraHandleData = UiCameraAnimationManager.Instance.PushCameraHandleByHandleName("1062", true, true, "1001", false, null, null);
	}

	// Token: 0x0600E851 RID: 59473 RVA: 0x0036F7C4 File Offset: 0x0036D9C4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600E852 RID: 59474 RVA: 0x0036F828 File Offset: 0x0036DA28
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600E853 RID: 59475 RVA: 0x0036F88C File Offset: 0x0036DA8C
	protected override HandBookCommonItem InitHandBookCommonItem()
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		this.HandBookCommonItemList.Add(handBookCommonItem);
		return handBookCommonItem;
	}

	// Token: 0x0600E854 RID: 59476 RVA: 0x0036F8C0 File Offset: 0x0036DAC0
	public override List<CommonTabItemData> GetTabItemData(List<CommonTabData> tabData)
	{
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		int count = this.TabList.Count;
		for (int i = 0; i < count; i++)
		{
			list.Add(new CommonTabItemData
			{
				Index = i,
				Data = this.TabList[i]
			});
		}
		return list;
	}

	// Token: 0x0600E855 RID: 59477 RVA: 0x0036F914 File Offset: 0x0036DB14
	protected void OnToggleClick(MediumItemGridExtendCallback callbackParameter)
	{
		HandBookCommonItemData handBookCommonItemData = callbackParameter.Data as HandBookCommonItemData;
		int gridIndex = (callbackParameter.MediumItemGrid as HandBookCommonItem).GridIndex;
		this.ScrollViewCommon.DeselectCurrentGridProxy(false);
		this.ScrollViewCommon.SelectGridProxy(gridIndex, false);
		this.ScrollViewCommon.RefreshGridProxy(gridIndex);
		HandBookController.Instance.ClearEffect();
		if (handBookCommonItemData.IsLock)
		{
			base.SetLockState(true);
			return;
		}
		AnimalHandBook animalHandBook = (AnimalHandBook)handBookCommonItemData.Config;
		if (handBookCommonItemData.IsNew)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Animal, animalHandBook.Id);
		}
		base.SetLockState(false);
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Animal, animalHandBook.Id);
		if (handBookInfo != null)
		{
			base.SetDateText(handBookInfo.CreateTime);
		}
		if (handBookCommonItemData.IsNew)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Animal, animalHandBook.Id);
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(animalHandBook.Name, null);
		base.SetNameText(localTextNew);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(animalHandBook.Descrtption, null);
		base.SetTypeText(localTextNew2);
		this.RefreshInfoItemLayout(animalHandBook);
		this.RefreshDropItem(animalHandBook);
		HandBookController.Instance.SetAnimalMeshShow(animalHandBook.Id, this.SkeletalObserverHandle);
	}

	// Token: 0x0600E856 RID: 59478 RVA: 0x0036FA3C File Offset: 0x0036DC3C
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Animal);
		base.SetCollectText(collectProgress[0], collectProgress[1]);
	}

	// Token: 0x0600E857 RID: 59479 RVA: 0x0036FA64 File Offset: 0x0036DC64
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("AnimalHandBookLock");
		base.SetLockText(textById);
	}

	// Token: 0x0600E858 RID: 59480 RVA: 0x0036FA88 File Offset: 0x0036DC88
	protected void RefreshDropItem(AnimalHandBook animalHandBook)
	{
		List<TItem> list = new List<TItem>();
		int[] dropItemIdArray = animalHandBook.GetDropItemIdArray();
		int num = dropItemIdArray.Length;
		for (int i = 0; i < num; i++)
		{
			int itemId = dropItemIdArray[i];
			TItem item = new TItem(new InventoryDefine.GetItemData(itemId, 0), 0);
			list.Add(item);
		}
	}

	// Token: 0x0600E859 RID: 59481 RVA: 0x0036FAD0 File Offset: 0x0036DCD0
	protected void RefreshInfoItemLayout(AnimalHandBook handBookConfig)
	{
		List<string> list = new List<string>();
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(handBookConfig.TypeDescrtption, null);
		list.Add(localTextNew);
		base.InitInfoItemLayout(list);
	}

	// Token: 0x0600E85A RID: 59482 RVA: 0x0036FAFF File Offset: 0x0036DCFF
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600E85B RID: 59483 RVA: 0x0036FB08 File Offset: 0x0036DD08
	protected void Refresh()
	{
		this.ConfigList = HandBookConfig.Instance.GetAnimalHandBookConfigList();
		List<HandBookCommonItemData> list = new List<HandBookCommonItemData>();
		int count = this.ConfigList.Count;
		for (int i = 0; i < count; i++)
		{
			AnimalHandBook animalHandBook = this.ConfigList[i];
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Animal, animalHandBook.Id);
			bool isLock = handBookInfo == null;
			bool isNew = handBookInfo != null && !handBookInfo.IsRead;
			list.Add(new HandBookCommonItemData
			{
				Icon = animalHandBook.Icon,
				Config = animalHandBook,
				IsLock = isLock,
				IsNew = isNew
			});
		}
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
		base.InitScrollViewByCommonItem(list);
		HandBookEntrance value = HandBookConfig.Instance.GetHandBookEntranceConfig(EHandBookTabType.Animal).Value;
		base.InitCommonTabTitle(value.TitleIcon, new CommonTabTitleData(value.Name, Array.Empty<object>()));
		this.RefreshCollectText();
	}

	// Token: 0x0600E85C RID: 59484 RVA: 0x0036FC0C File Offset: 0x0036DE0C
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Animal)
		{
			return;
		}
		int count = this.HandBookCommonItemList.Count;
		for (int i = 0; i < count; i++)
		{
			HandBookCommonItem handBookCommonItem = this.HandBookCommonItemList[i];
			if (((AnimalHandBook)handBookCommonItem.GetData().Config).Id == id)
			{
				handBookCommonItem.SetNewFlagVisible(new bool?(false));
				return;
			}
		}
	}

	// Token: 0x0600E85D RID: 59485 RVA: 0x0036FC6B File Offset: 0x0036DE6B
	protected override void OnBeforePlayCloseSequence()
	{
		UiCameraAnimationManager.Instance.PopCameraHandle(this.UiCameraHandleData, null);
	}

	// Token: 0x0600E85E RID: 59486 RVA: 0x0036FC7E File Offset: 0x0036DE7E
	protected override void OnBeforeCreate()
	{
		UiSceneManager.Instance.InitHandBookObserver();
		this.SkeletalObserverHandle = UiSceneManager.Instance.GetHandBookObserver();
	}

	// Token: 0x0600E85F RID: 59487 RVA: 0x0036FC9A File Offset: 0x0036DE9A
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyHandBookObserver();
		this.SkeletalObserverHandle = null;
		HandBookController.Instance.ClearEffect();
		this.ConfigList = new List<AnimalHandBook>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x04006B75 RID: 27509
	private IReadOnlyList<AnimalHandBook> ConfigList;

	// Token: 0x04006B76 RID: 27510
	private List<HandBookCommonItem> HandBookCommonItemList;

	// Token: 0x04006B77 RID: 27511
	[Nullable(2)]
	private UiCameraHandleData UiCameraHandleData;

	// Token: 0x04006B78 RID: 27512
	[Nullable(2)]
	private SkeletalObserverHandle SkeletalObserverHandle;
}
