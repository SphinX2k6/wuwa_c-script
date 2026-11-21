using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;

// Token: 0x02001291 RID: 4753
[NullableContext(1)]
[Nullable(0)]
public class AnimalHandBookView : HandBookBaseView
{
	// Token: 0x0600BC6D RID: 48237 RVA: 0x0037B45A File Offset: 0x0037965A
	public AnimalHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.ConfigList = new List<AnimalHandBook>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x0600BC6E RID: 48238 RVA: 0x0037B479 File Offset: 0x00379679
	protected override void OnStart()
	{
		base.SetDefaultState();
		this.Refresh();
		this.RefreshLockText();
	}

	// Token: 0x0600BC6F RID: 48239 RVA: 0x0037B48D File Offset: 0x0037968D
	protected override void OnAfterShow()
	{
		this.UiCameraHandleData = UiCameraModel.Instance.PushCameraHandleByHandleName("1062", true, true, "1001", false, null);
	}

	// Token: 0x0600BC70 RID: 48240 RVA: 0x0037B4B0 File Offset: 0x003796B0
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Add<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BC71 RID: 48241 RVA: 0x0037B514 File Offset: 0x00379714
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookDataInit, new Action(this.Refresh));
		EventSystem.Instance.Remove(EEventName.OnHandBookDataUpdate, new Action<EHandBookTabType, int>(this.OnHandBookDataUpdate));
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BC72 RID: 48242 RVA: 0x0037B578 File Offset: 0x00379778
	protected override HandBookCommonItem InitHandBookCommonItem()
	{
		HandBookCommonItem handBookCommonItem = new HandBookCommonItem();
		handBookCommonItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnToggleClick));
		this.HandBookCommonItemList.Add(handBookCommonItem);
		return handBookCommonItem;
	}

	// Token: 0x0600BC73 RID: 48243 RVA: 0x0037B5AC File Offset: 0x003797AC
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

	// Token: 0x0600BC74 RID: 48244 RVA: 0x0037B600 File Offset: 0x00379800
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

	// Token: 0x0600BC75 RID: 48245 RVA: 0x0037B728 File Offset: 0x00379928
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Animal);
		base.SetCollectText(collectProgress[0], collectProgress[1]);
	}

	// Token: 0x0600BC76 RID: 48246 RVA: 0x0037B750 File Offset: 0x00379950
	protected void RefreshLockText()
	{
		string textById = TextConfig.Instance.GetTextById("AnimalHandBookLock");
		base.SetLockText(textById);
	}

	// Token: 0x0600BC77 RID: 48247 RVA: 0x0037B774 File Offset: 0x00379974
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

	// Token: 0x0600BC78 RID: 48248 RVA: 0x0037B7BC File Offset: 0x003799BC
	protected void RefreshInfoItemLayout(AnimalHandBook handBookConfig)
	{
		List<string> list = new List<string>();
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(handBookConfig.TypeDescrtption, null);
		list.Add(localTextNew);
		base.InitInfoItemLayout(list);
	}

	// Token: 0x0600BC79 RID: 48249 RVA: 0x0037B7EB File Offset: 0x003799EB
	private void OnHandBookDataUpdate(EHandBookTabType eHandBookTabType, int i)
	{
		this.Refresh();
	}

	// Token: 0x0600BC7A RID: 48250 RVA: 0x0037B7F4 File Offset: 0x003799F4
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

	// Token: 0x0600BC7B RID: 48251 RVA: 0x0037B8F8 File Offset: 0x00379AF8
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

	// Token: 0x0600BC7C RID: 48252 RVA: 0x0037B957 File Offset: 0x00379B57
	protected override void OnBeforePlayCloseSequence()
	{
		UiCameraModel.Instance.PopCameraHandle(this.UiCameraHandleData, null);
	}

	// Token: 0x0600BC7D RID: 48253 RVA: 0x0037B96B File Offset: 0x00379B6B
	protected override void OnBeforeCreate()
	{
		UiSceneManager.Instance.InitHandBookObserver();
		this.SkeletalObserverHandle = UiSceneManager.Instance.GetHandBookObserver();
	}

	// Token: 0x0600BC7E RID: 48254 RVA: 0x0037B987 File Offset: 0x00379B87
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyHandBookObserver();
		this.SkeletalObserverHandle = null;
		HandBookController.Instance.ClearEffect();
		this.ConfigList = new List<AnimalHandBook>();
		this.HandBookCommonItemList = new List<HandBookCommonItem>();
	}

	// Token: 0x04006C56 RID: 27734
	private IReadOnlyList<AnimalHandBook> ConfigList;

	// Token: 0x04006C57 RID: 27735
	private List<HandBookCommonItem> HandBookCommonItemList;

	// Token: 0x04006C58 RID: 27736
	[Nullable(2)]
	private UiCameraHandleData UiCameraHandleData;

	// Token: 0x04006C59 RID: 27737
	[Nullable(2)]
	private SkeletalObserverHandle SkeletalObserverHandle;
}
