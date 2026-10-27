using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E87 RID: 7815
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryGamepadLogicController
{
	// Token: 0x0600EE21 RID: 60961 RVA: 0x0038C547 File Offset: 0x0038A747
	public void InitInteract(UUIItem attachPanel)
	{
		if (this.InteractController == null)
		{
			this.InteractController = new HonamiStoryGamepadInteractController();
		}
	}

	// Token: 0x0600EE22 RID: 60962 RVA: 0x0038C55C File Offset: 0x0038A75C
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.InteractController.RegisterPanel(panel);
	}

	// Token: 0x0600EE23 RID: 60963 RVA: 0x0038C56A File Offset: 0x0038A76A
	public void RegisterBtnToGrid(UUIItem btnItem, HonamiStoryGridItemBase gridItem)
	{
		this.BtnMap[btnItem] = gridItem;
	}

	// Token: 0x0600EE24 RID: 60964 RVA: 0x0038C579 File Offset: 0x0038A779
	public void RegisterItemToGrid(UUIItem realItem, HonamiStoryGridItemBase gridItem)
	{
		this.ItemToGridMap[realItem] = gridItem;
	}

	// Token: 0x0600EE25 RID: 60965 RVA: 0x0038C588 File Offset: 0x0038A788
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

	// Token: 0x0600EE26 RID: 60966 RVA: 0x0038C5D8 File Offset: 0x0038A7D8
	public void SetScrollingPosition(int position)
	{
		this.CurScrollingPosition = position;
	}

	// Token: 0x0600EE27 RID: 60967 RVA: 0x0038C5E1 File Offset: 0x0038A7E1
	[NullableContext(2)]
	public HonamiStoryItemGridItem GetCurItem()
	{
		return this.CurItem;
	}

	// Token: 0x0600EE28 RID: 60968 RVA: 0x0038C5E9 File Offset: 0x0038A7E9
	[NullableContext(2)]
	public HonamiStoryItemGridItem GetSelectItem()
	{
		return null;
	}

	// Token: 0x0600EE29 RID: 60969 RVA: 0x0038C5EC File Offset: 0x0038A7EC
	public int GetScrollingPosition()
	{
		return this.CurScrollingPosition;
	}

	// Token: 0x0600EE2A RID: 60970 RVA: 0x0038C5F4 File Offset: 0x0038A7F4
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

	// Token: 0x0600EE2B RID: 60971 RVA: 0x0038C628 File Offset: 0x0038A828
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

	// Token: 0x0600EE2C RID: 60972 RVA: 0x0038C648 File Offset: 0x0038A848
	public int GetCurPanelIndex()
	{
		return this.CurPanelIndex;
	}

	// Token: 0x0600EE2D RID: 60973 RVA: 0x0038C650 File Offset: 0x0038A850
	public HonamiStoryGamepadInteractController GetInteractController()
	{
		return this.InteractController;
	}

	// Token: 0x0600EE2E RID: 60974 RVA: 0x0038C658 File Offset: 0x0038A858
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

	// Token: 0x0600EE2F RID: 60975 RVA: 0x0038C686 File Offset: 0x0038A886
	public bool IsInGame()
	{
		return HonamiStoryUtil.CheckInHonamiStoryDungeon();
	}

	// Token: 0x0600EE30 RID: 60976 RVA: 0x0038C690 File Offset: 0x0038A890
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

	// Token: 0x0600EE31 RID: 60977 RVA: 0x0038C794 File Offset: 0x0038A994
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

	// Token: 0x0600EE32 RID: 60978 RVA: 0x0038C818 File Offset: 0x0038AA18
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

	// Token: 0x0600EE33 RID: 60979 RVA: 0x0038C874 File Offset: 0x0038AA74
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

	// Token: 0x0600EE34 RID: 60980 RVA: 0x0038C8B8 File Offset: 0x0038AAB8
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

	// Token: 0x0600EE35 RID: 60981 RVA: 0x0038C8F8 File Offset: 0x0038AAF8
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

	// Token: 0x0600EE36 RID: 60982 RVA: 0x0038C954 File Offset: 0x0038AB54
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

	// Token: 0x0600EE37 RID: 60983 RVA: 0x0038C9AA File Offset: 0x0038ABAA
	public void PickUp(HonamiStoryGridItemBase targetItem)
	{
		this.CurSelectItem = targetItem.GetItemGridItem();
		this.InteractController.OnPickUp(targetItem);
	}

	// Token: 0x0600EE38 RID: 60984 RVA: 0x0038C9C4 File Offset: 0x0038ABC4
	public void PutDown(HonamiStoryGridItemBase targetItem)
	{
		this.InteractController.OnPutDown(targetItem);
		this.CurSelectItem = null;
	}

	// Token: 0x0600EE39 RID: 60985 RVA: 0x0038C9DC File Offset: 0x0038ABDC
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

	// Token: 0x0600EE3A RID: 60986 RVA: 0x0038CA25 File Offset: 0x0038AC25
	public void Reset()
	{
		this.Cancel();
	}

	// Token: 0x0600EE3B RID: 60987 RVA: 0x0038CA2D File Offset: 0x0038AC2D
	public void SwitchToKeyboardState()
	{
		this.Cancel();
	}

	// Token: 0x0600EE3C RID: 60988 RVA: 0x0038CA38 File Offset: 0x0038AC38
	public void SwitchToGamepadState(bool isPickUp = false)
	{
		bool lockUseDragState = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Sell;
		UiNavigationNewController.Instance.SetLockUseDragState(lockUseDragState);
		this.SetDefaultFocus(isPickUp);
	}

	// Token: 0x0600EE3D RID: 60989 RVA: 0x0038CA68 File Offset: 0x0038AC68
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

	// Token: 0x0600EE3E RID: 60990 RVA: 0x0038CA9E File Offset: 0x0038AC9E
	public void SetDefaultFocus(bool isPickUp = false)
	{
		this.CurPanelIndex = (isPickUp ? 3 : 2);
		this.SetFocusByCurPanelIndex();
	}

	// Token: 0x0600EE3F RID: 60991 RVA: 0x0038CAB4 File Offset: 0x0038ACB4
	private bool IsGamepadInCurItem()
	{
		if (this.CurItem == null)
		{
			return false;
		}
		ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
		return pointerEventData != null && HonamiStoryUtil.CheckEventDataInItemViewport(pointerEventData, this.CurItem.GetRootItem(), true);
	}

	// Token: 0x0600EE40 RID: 60992 RVA: 0x0038CAF4 File Offset: 0x0038ACF4
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

	// Token: 0x0600EE41 RID: 60993 RVA: 0x0038CB5C File Offset: 0x0038AD5C
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

	// Token: 0x0600EE42 RID: 60994 RVA: 0x0038CBE4 File Offset: 0x0038ADE4
	public UniTask SellSingleOne()
	{
		HonamiStoryGamepadLogicController.<SellSingleOne>d__44 <SellSingleOne>d__;
		<SellSingleOne>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SellSingleOne>d__.<>4__this = this;
		<SellSingleOne>d__.<>1__state = -1;
		<SellSingleOne>d__.<>t__builder.Start<HonamiStoryGamepadLogicController.<SellSingleOne>d__44>(ref <SellSingleOne>d__);
		return <SellSingleOne>d__.<>t__builder.Task;
	}

	// Token: 0x0600EE43 RID: 60995 RVA: 0x0038CC28 File Offset: 0x0038AE28
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

	// Token: 0x0600EE44 RID: 60996 RVA: 0x0038CCBC File Offset: 0x0038AEBC
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

	// Token: 0x0600EE45 RID: 60997 RVA: 0x0038CD14 File Offset: 0x0038AF14
	public UniTask SetLockStatus()
	{
		HonamiStoryGamepadLogicController.<SetLockStatus>d__47 <SetLockStatus>d__;
		<SetLockStatus>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetLockStatus>d__.<>4__this = this;
		<SetLockStatus>d__.<>1__state = -1;
		<SetLockStatus>d__.<>t__builder.Start<HonamiStoryGamepadLogicController.<SetLockStatus>d__47>(ref <SetLockStatus>d__);
		return <SetLockStatus>d__.<>t__builder.Task;
	}

	// Token: 0x0600EE46 RID: 60998 RVA: 0x0038CD58 File Offset: 0x0038AF58
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

	// Token: 0x0600EE47 RID: 60999 RVA: 0x0038CD94 File Offset: 0x0038AF94
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

	// Token: 0x04006E83 RID: 28291
	[Nullable(2)]
	private HonamiStoryItemGridItem CurItem;

	// Token: 0x04006E84 RID: 28292
	[Nullable(2)]
	private HonamiStoryItemGridItem CurSelectItem;

	// Token: 0x04006E85 RID: 28293
	private int CurItemDataId = -1;

	// Token: 0x04006E86 RID: 28294
	private HonamiStoryGamepadInteractController InteractController;

	// Token: 0x04006E87 RID: 28295
	private int CurPanelIndex = 1;

	// Token: 0x04006E88 RID: 28296
	private int CurPosition = -1;

	// Token: 0x04006E89 RID: 28297
	private int CurScrollingPosition = -1;

	// Token: 0x04006E8A RID: 28298
	private readonly Dictionary<int, HonamiStoryGridItemBase> JumpMap = new Dictionary<int, HonamiStoryGridItemBase>();

	// Token: 0x04006E8B RID: 28299
	private readonly Dictionary<UUIItem, HonamiStoryGridItemBase> BtnMap = new Dictionary<UUIItem, HonamiStoryGridItemBase>();

	// Token: 0x04006E8C RID: 28300
	private readonly Dictionary<UUIItem, HonamiStoryGridItemBase> ItemToGridMap = new Dictionary<UUIItem, HonamiStoryGridItemBase>();

	// Token: 0x04006E8D RID: 28301
	private readonly Vector2D TempPivot = Vector2D.Create();
}
