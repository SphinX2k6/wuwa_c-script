using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001349 RID: 4937
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryGamepadLogicController
{
	// Token: 0x0600C240 RID: 49728 RVA: 0x00398137 File Offset: 0x00396337
	public void InitInteract(UUIItem attachPanel)
	{
		if (this.InteractController == null)
		{
			this.InteractController = new HonamiStoryGamepadInteractController();
		}
	}

	// Token: 0x0600C241 RID: 49729 RVA: 0x0039814C File Offset: 0x0039634C
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.InteractController.RegisterPanel(panel);
	}

	// Token: 0x0600C242 RID: 49730 RVA: 0x0039815A File Offset: 0x0039635A
	public void RegisterBtnToGrid(UUIItem btnItem, HonamiStoryGridItemBase gridItem)
	{
		this.BtnMap[btnItem] = gridItem;
	}

	// Token: 0x0600C243 RID: 49731 RVA: 0x00398169 File Offset: 0x00396369
	public void RegisterItemToGrid(UUIItem realItem, HonamiStoryGridItemBase gridItem)
	{
		this.ItemToGridMap[realItem] = gridItem;
	}

	// Token: 0x0600C244 RID: 49732 RVA: 0x00398178 File Offset: 0x00396378
	[NullableContext(2)]
	public void SetCurItem(HonamiStoryItemGridItem item)
	{
		this.CurItem = item;
		int? num;
		if (item == null)
		{
			num = null;
		}
		else
		{
			HonamiStoryItemDataBase data = item.GetData();
			num = ((data != null) ? new int?(data.GetIncId()) : null);
		}
		int? num2 = num;
		this.CurItemDataId = num2.GetValueOrDefault(-1);
	}

	// Token: 0x0600C245 RID: 49733 RVA: 0x003981C8 File Offset: 0x003963C8
	public void SetScrollingPosition(int position)
	{
		this.CurScrollingPosition = position;
	}

	// Token: 0x0600C246 RID: 49734 RVA: 0x003981D1 File Offset: 0x003963D1
	[NullableContext(2)]
	public HonamiStoryItemGridItem GetCurItem()
	{
		return this.CurItem;
	}

	// Token: 0x0600C247 RID: 49735 RVA: 0x003981D9 File Offset: 0x003963D9
	[NullableContext(2)]
	public HonamiStoryItemGridItem GetSelectItem()
	{
		return null;
	}

	// Token: 0x0600C248 RID: 49736 RVA: 0x003981DC File Offset: 0x003963DC
	public int GetScrollingPosition()
	{
		return this.CurScrollingPosition;
	}

	// Token: 0x0600C249 RID: 49737 RVA: 0x003981E4 File Offset: 0x003963E4
	[return: Nullable(2)]
	public HonamiStoryGridItemBase GetGridItemByAnyItem(UUIItem anyItem)
	{
		HonamiStoryGridItemBase honamiStoryGridItemBase = null;
		this.BtnMap.TryGetValue(anyItem, out honamiStoryGridItemBase);
		if (honamiStoryGridItemBase == null)
		{
			this.ItemToGridMap.TryGetValue(anyItem, out honamiStoryGridItemBase);
		}
		return honamiStoryGridItemBase;
	}

	// Token: 0x0600C24A RID: 49738 RVA: 0x00398218 File Offset: 0x00396418
	[return: Nullable(2)]
	public HonamiStoryGridItemBase GetGridItemByBtnItem(UUIItem btnItem)
	{
		HonamiStoryGridItemBase result;
		if (this.BtnMap.TryGetValue(btnItem, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600C24B RID: 49739 RVA: 0x00398238 File Offset: 0x00396438
	public int GetCurPanelIndex()
	{
		return this.CurPanelIndex;
	}

	// Token: 0x0600C24C RID: 49740 RVA: 0x00398240 File Offset: 0x00396440
	public HonamiStoryGamepadInteractController GetInteractController()
	{
		return this.InteractController;
	}

	// Token: 0x0600C24D RID: 49741 RVA: 0x00398248 File Offset: 0x00396448
	public int GetBackpackTypeByPanelIndex(int index)
	{
		int result = -1;
		if (index == 1)
		{
			result = 3;
		}
		else if (index == 2)
		{
			result = ((this.IsInGame() > false) ? 1 : 0);
		}
		else if (index == 3)
		{
			result = 2;
		}
		return result;
	}

	// Token: 0x0600C24E RID: 49742 RVA: 0x00398276 File Offset: 0x00396476
	public bool IsInGame()
	{
		return HonamiStoryUtil.CheckInHonamiStoryDungeon();
	}

	// Token: 0x0600C24F RID: 49743 RVA: 0x00398280 File Offset: 0x00396480
	[NullableContext(0)]
	private ValueTuple<int, bool> GetMousePositionNearlyPanelData()
	{
		Vector2D mouseViewportPosition = UiNavigationNewController.Instance.GetMouseViewportPosition();
		if (mouseViewportPosition == null)
		{
			return new ValueTuple<int, bool>(-1, false);
		}
		int count = this.InteractController.PanelBaseList.Count;
		int item = -1;
		bool item2 = false;
		for (int i = 0; i < count; i++)
		{
			HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase = this.InteractController.PanelBaseList[i];
			this.TempPivot.Set(0.0, 0.0);
			UUIItem rootItem = honamiStoryBackpackPanelBase.GetRootItem();
			bool bIsScaledByDPI = true;
			FVector2D fvector2D = this.TempPivot.ToUeVector2D(false);
			FVector2D positionInViewportWithPivot = rootItem.GetPositionInViewportWithPivot(bIsScaledByDPI, fvector2D);
			this.TempPivot.Set(1.0, 1.0);
			UUIItem rootItem2 = honamiStoryBackpackPanelBase.GetRootItem();
			bool bIsScaledByDPI2 = true;
			fvector2D = this.TempPivot.ToUeVector2D(false);
			FVector2D positionInViewportWithPivot2 = rootItem2.GetPositionInViewportWithPivot(bIsScaledByDPI2, fvector2D);
			if (mouseViewportPosition.X < (double)positionInViewportWithPivot.X)
			{
				break;
			}
			item2 = (mouseViewportPosition.X <= (double)positionInViewportWithPivot2.X);
			item = i;
		}
		return new ValueTuple<int, bool>(item, item2);
	}

	// Token: 0x0600C250 RID: 49744 RVA: 0x00398384 File Offset: 0x00396584
	public void JumpToPrevPanelNew()
	{
		ValueTuple<int, bool> mousePositionNearlyPanelData = this.GetMousePositionNearlyPanelData();
		int item = mousePositionNearlyPanelData.Item1;
		int index;
		if (mousePositionNearlyPanelData.Item2)
		{
			index = ((item - 1 < 0) ? (this.InteractController.PanelBaseList.Count - 1) : (item - 1));
		}
		else
		{
			index = ((item < 0) ? (this.InteractController.PanelBaseList.Count - 1) : item);
		}
		HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase = this.InteractController.PanelBaseList[index];
		if (honamiStoryBackpackPanelBase != null)
		{
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(honamiStoryBackpackPanelBase.GetRootItem());
		}
	}

	// Token: 0x0600C251 RID: 49745 RVA: 0x00398408 File Offset: 0x00396608
	public void JumpToNextPanelNew()
	{
		int item = this.GetMousePositionNearlyPanelData().Item1;
		int index = (item + 1 > this.InteractController.PanelBaseList.Count - 1) ? 0 : (item + 1);
		HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase = this.InteractController.PanelBaseList[index];
		if (honamiStoryBackpackPanelBase != null)
		{
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(honamiStoryBackpackPanelBase.GetRootItem());
		}
	}

	// Token: 0x0600C252 RID: 49746 RVA: 0x00398464 File Offset: 0x00396664
	public void SetPanelIndexByGridItem(HonamiStoryGridItemBase gridItem)
	{
		this.CurPanelIndex = this.InteractController.GetPanelIndexByGridItem(gridItem);
		HonamiStoryItemDataBase data = gridItem.GetData();
		if (data != null)
		{
			this.CurPosition = data.GetPosition();
			return;
		}
		this.CurPosition = gridItem.GetEmptyPosition();
	}

	// Token: 0x0600C253 RID: 49747 RVA: 0x003984A8 File Offset: 0x003966A8
	public void SetFocusByGridItem(HonamiStoryGridItemBase gridItem)
	{
		if (gridItem.Data == null)
		{
			return;
		}
		if (gridItem.Data.GetIncId() != this.CurItemDataId)
		{
			return;
		}
		UUIItem btnItem = gridItem.GetBtnItem();
		if (btnItem != null)
		{
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(btnItem);
		}
	}

	// Token: 0x0600C254 RID: 49748 RVA: 0x003984E8 File Offset: 0x003966E8
	private HonamiStoryGridItemBase FindSuitableGridByItemList(List<HonamiStoryGridItemBase> list)
	{
		HonamiStoryGridItemBase result = list[0];
		foreach (HonamiStoryGridItemBase honamiStoryGridItemBase in list)
		{
			if (honamiStoryGridItemBase.GetItemGridItem() != null)
			{
				result = honamiStoryGridItemBase;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600C255 RID: 49749 RVA: 0x00398544 File Offset: 0x00396744
	public void SetFocusByCurPanelIndex()
	{
		int backpackTypeByPanelIndex = this.GetBackpackTypeByPanelIndex(this.CurPanelIndex);
		HonamiStoryGridItemBase focusByGridItem;
		if (this.JumpMap.TryGetValue(this.CurPanelIndex, out focusByGridItem))
		{
			this.SetFocusByGridItem(focusByGridItem);
			return;
		}
		List<HonamiStoryGridItemBase> gridItemListByBackpackType = this.InteractController.GetGridItemListByBackpackType(backpackTypeByPanelIndex);
		HonamiStoryGridItemBase honamiStoryGridItemBase = this.FindSuitableGridByItemList(gridItemListByBackpackType);
		if (honamiStoryGridItemBase != null)
		{
			this.SetFocusByGridItem(honamiStoryGridItemBase);
		}
	}

	// Token: 0x0600C256 RID: 49750 RVA: 0x0039859A File Offset: 0x0039679A
	public void PickUp(HonamiStoryGridItemBase targetItem)
	{
		this.CurSelectItem = targetItem.GetItemGridItem();
		this.InteractController.OnPickUp(targetItem);
	}

	// Token: 0x0600C257 RID: 49751 RVA: 0x003985B4 File Offset: 0x003967B4
	public void PutDown(HonamiStoryGridItemBase targetItem)
	{
		this.InteractController.OnPutDown(targetItem);
		this.CurSelectItem = null;
	}

	// Token: 0x0600C258 RID: 49752 RVA: 0x003985CC File Offset: 0x003967CC
	private void HideAllTips()
	{
		HonamiStoryBackpackView honamiStoryBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) as HonamiStoryBackpackView;
		if (honamiStoryBackpackView != null)
		{
			honamiStoryBackpackView.HideAllTips();
		}
		HonamiStoryPickUpBackpackView honamiStoryPickUpBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) as HonamiStoryPickUpBackpackView;
		if (honamiStoryPickUpBackpackView != null)
		{
			honamiStoryPickUpBackpackView.HideAllTips();
		}
	}

	// Token: 0x0600C259 RID: 49753 RVA: 0x00398615 File Offset: 0x00396815
	public void Reset()
	{
		this.Cancel();
	}

	// Token: 0x0600C25A RID: 49754 RVA: 0x0039861D File Offset: 0x0039681D
	public void SwitchToKeyboardState()
	{
		this.Cancel();
	}

	// Token: 0x0600C25B RID: 49755 RVA: 0x00398628 File Offset: 0x00396828
	public void SwitchToGamepadState(bool isPickUp = false)
	{
		bool lockUseDragState = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Sell;
		UiNavigationNewController.Instance.SetLockUseDragState(lockUseDragState);
		this.SetDefaultFocus(isPickUp);
	}

	// Token: 0x0600C25C RID: 49756 RVA: 0x00398658 File Offset: 0x00396858
	public void CancelOperationByGamepad()
	{
		if (this.CurSelectItem != null)
		{
			HonamiStoryGridItemBase gridItemByAnyItem = this.GetGridItemByAnyItem(this.CurSelectItem.GetRootItem());
			if (gridItemByAnyItem != null)
			{
				gridItemByAnyItem.MarkUseCancel();
			}
		}
		this.Cancel();
	}

	// Token: 0x0600C25D RID: 49757 RVA: 0x0039868E File Offset: 0x0039688E
	public void SetDefaultFocus(bool isPickUp = false)
	{
		this.CurPanelIndex = (isPickUp ? 3 : 2);
		this.SetFocusByCurPanelIndex();
	}

	// Token: 0x0600C25E RID: 49758 RVA: 0x003986A4 File Offset: 0x003968A4
	private bool IsGamepadInCurItem()
	{
		if (this.CurItem == null)
		{
			return false;
		}
		ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
		return pointerEventData != null && HonamiStoryUtil.CheckEventDataInItemViewport(pointerEventData, this.CurItem.GetRootItem(), true);
	}

	// Token: 0x0600C25F RID: 49759 RVA: 0x003986E4 File Offset: 0x003968E4
	public void Cancel()
	{
		if (this.CurSelectItem != null)
		{
			HonamiStoryGridItemBase gridItemByAnyItem = this.GetGridItemByAnyItem(this.CurSelectItem.GetRootItem());
			if (gridItemByAnyItem != null)
			{
				this.SetPanelIndexByGridItem(gridItemByAnyItem);
			}
		}
		this.HideAllTips();
		this.InteractController.Reset();
		if (this.IsGamepadInCurItem())
		{
			this.TriggerCurItemEnterGrid();
		}
		else
		{
			this.CurItem = null;
			this.CurItemDataId = -1;
		}
		this.CurSelectItem = null;
	}

	// Token: 0x0600C260 RID: 49760 RVA: 0x0039874C File Offset: 0x0039694C
	public void Discard()
	{
		if (this.CurItem == null)
		{
			return;
		}
		HonamiStoryItemDataBase data = this.CurItem.GetData();
		if (data == null)
		{
			return;
		}
		EHonamiStoryBackpack ehonamiStoryBackpack = (this.CurItem.GetBackpackType() == EHonamiStoryBackpackType.Backpack) ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Player;
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(3, false);
		if (backPackData == null)
		{
			return;
		}
		if (backPackData.GetCapacity() <= 0)
		{
			HonamiStoryController.Instance.RequestDiscardItem(data, ehonamiStoryBackpack);
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
			return;
		}
		if (HonamiStoryModel.Instance.SetItemIntoBag(data, ehonamiStoryBackpack, EHonamiStoryBackpack.PickUpBox))
		{
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		}
	}

	// Token: 0x0600C261 RID: 49761 RVA: 0x003987D4 File Offset: 0x003969D4
	public UniTask SellSingleOne()
	{
		HonamiStoryGamepadLogicController.<SellSingleOne>d__44 <SellSingleOne>d__;
		<SellSingleOne>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SellSingleOne>d__.<>4__this = this;
		<SellSingleOne>d__.<>1__state = -1;
		<SellSingleOne>d__.<>t__builder.Start<HonamiStoryGamepadLogicController.<SellSingleOne>d__44>(ref <SellSingleOne>d__);
		return <SellSingleOne>d__.<>t__builder.Task;
	}

	// Token: 0x0600C262 RID: 49762 RVA: 0x00398818 File Offset: 0x00396A18
	public void QuickEquipOn()
	{
		if (this.CurItem == null)
		{
			return;
		}
		HonamiStoryItemDataBase data = this.CurItem.GetData();
		if (data == null)
		{
			return;
		}
		EHonamiStoryBackpackType backpackType = this.CurItem.GetBackpackType();
		int position = data.GetPosition();
		if (backpackType == EHonamiStoryBackpackType.Backpack || backpackType == EHonamiStoryBackpackType.Inventory)
		{
			if (data.GetItemType() != EHonamiStoryItemType.Plugin)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_CantEquipNormalItem", Array.Empty<object>());
				return;
			}
			if (!HonamiStoryModel.Instance.QuickEquipFromBackpack(data, position))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_ShowTips_CantQuickEquip", Array.Empty<object>());
				return;
			}
		}
		else if (backpackType == EHonamiStoryBackpackType.PickUpBox)
		{
			HonamiStoryModel.Instance.QuickPickUpFromPickUpBox(data, position);
		}
	}

	// Token: 0x0600C263 RID: 49763 RVA: 0x003988AC File Offset: 0x00396AAC
	public void QuickEquipOff()
	{
		if (this.CurItem == null)
		{
			return;
		}
		HonamiStoryItemDataBase data = this.CurItem.GetData();
		if (data == null)
		{
			return;
		}
		EHonamiStoryBackpack toBackpack = this.IsInGame() ? EHonamiStoryBackpack.Backpack : EHonamiStoryBackpack.Inventory;
		if (!HonamiStoryModel.Instance.SetItemIntoBag(data, EHonamiStoryBackpack.Player, toBackpack))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoEnoughSpace", Array.Empty<object>());
		}
	}

	// Token: 0x0600C264 RID: 49764 RVA: 0x00398904 File Offset: 0x00396B04
	public UniTask SetLockStatus()
	{
		HonamiStoryGamepadLogicController.<SetLockStatus>d__47 <SetLockStatus>d__;
		<SetLockStatus>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetLockStatus>d__.<>4__this = this;
		<SetLockStatus>d__.<>1__state = -1;
		<SetLockStatus>d__.<>t__builder.Start<HonamiStoryGamepadLogicController.<SetLockStatus>d__47>(ref <SetLockStatus>d__);
		return <SetLockStatus>d__.<>t__builder.Task;
	}

	// Token: 0x0600C265 RID: 49765 RVA: 0x00398948 File Offset: 0x00396B48
	public void Collect()
	{
		if (this.CurItem == null)
		{
			return;
		}
		HonamiStoryItemDataBase data = this.CurItem.GetData();
		if (data == null)
		{
			return;
		}
		int position = data.GetPosition();
		HonamiStoryModel.Instance.QuickPickUpFromPickUpBox(data, position);
	}

	// Token: 0x0600C266 RID: 49766 RVA: 0x00398984 File Offset: 0x00396B84
	public void TriggerCurItemEnterGrid()
	{
		if (this.CurItem != null)
		{
			HonamiStoryGridItemBase gridItemByAnyItem = this.GetGridItemByAnyItem(this.CurItem.GetRootItem());
			if (gridItemByAnyItem != null)
			{
				gridItemByAnyItem.TriggerOnEnterGridCb();
			}
		}
	}

	// Token: 0x04006F64 RID: 28516
	[Nullable(2)]
	private HonamiStoryItemGridItem CurItem;

	// Token: 0x04006F65 RID: 28517
	[Nullable(2)]
	private HonamiStoryItemGridItem CurSelectItem;

	// Token: 0x04006F66 RID: 28518
	private int CurItemDataId = -1;

	// Token: 0x04006F67 RID: 28519
	private HonamiStoryGamepadInteractController InteractController;

	// Token: 0x04006F68 RID: 28520
	private int CurPanelIndex = 1;

	// Token: 0x04006F69 RID: 28521
	private int CurPosition = -1;

	// Token: 0x04006F6A RID: 28522
	private int CurScrollingPosition = -1;

	// Token: 0x04006F6B RID: 28523
	private readonly Dictionary<int, HonamiStoryGridItemBase> JumpMap = new Dictionary<int, HonamiStoryGridItemBase>();

	// Token: 0x04006F6C RID: 28524
	private readonly Dictionary<UUIItem, HonamiStoryGridItemBase> BtnMap = new Dictionary<UUIItem, HonamiStoryGridItemBase>();

	// Token: 0x04006F6D RID: 28525
	private readonly Dictionary<UUIItem, HonamiStoryGridItemBase> ItemToGridMap = new Dictionary<UUIItem, HonamiStoryGridItemBase>();

	// Token: 0x04006F6E RID: 28526
	private readonly Vector2D TempPivot = Vector2D.Create();
}
