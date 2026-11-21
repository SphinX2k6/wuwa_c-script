using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200136A RID: 4970
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryItemGridItem : UiPanelBase
{
	// Token: 0x0600C534 RID: 50484 RVA: 0x003AA3C3 File Offset: 0x003A85C3
	public HonamiStoryItemGridItem(HonamiStoryItemDataBase itemData)
	{
		this.ItemData = itemData;
	}

	// Token: 0x0600C535 RID: 50485 RVA: 0x003AA3E0 File Offset: 0x003A85E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C536 RID: 50486 RVA: 0x003AA50A File Offset: 0x003A870A
	protected override void OnStart()
	{
		if (!this.IsForDrag)
		{
			this.DraggableComponent = base.GetExtendToggle(0);
			return;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetEnable(false);
	}

	// Token: 0x0600C537 RID: 50487 RVA: 0x003AA534 File Offset: 0x003A8734
	protected override void OnBeforeDestroy()
	{
		this.LockItem = null;
	}

	// Token: 0x0600C538 RID: 50488 RVA: 0x003AA540 File Offset: 0x003A8740
	[NullableContext(1)]
	public void Refresh(HonamiStoryItemDataBase data, bool needCheckOverflow)
	{
		this.ItemData = data;
		HonamiStoryModel instance = HonamiStoryModel.Instance;
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		bool flag = this.IsForDrag ? data.GetIsDragCross() : data.GetIsCross();
		int baseGridWidth = data.GetBaseGridWidth(flag);
		int baseGridHeight = data.GetBaseGridHeight(flag);
		int num;
		int num2;
		if (this.BackpackType != EHonamiStoryBackpackType.Player)
		{
			EHonamiStoryBackpack backpackId = HonamiStoryDefine.Instance.HonamiBackpackTypeMap[this.BackpackType];
			HonamiStoryBackpackData backPackData = instance.GetBackPackData((int)backpackId, false);
			num = backPackData.GetCellWidth() * baseGridWidth + (baseGridWidth - 1) * backPackData.GetCellHorizontalInterval();
			num2 = backPackData.GetCellHeight() * baseGridHeight + (baseGridHeight - 1) * backPackData.GetCellVerticalInterval();
		}
		else
		{
			HonamiStoryPlayerBackpackData playerBackpackData = instance.GetPlayerBackpackData();
			num = playerBackpackData.GetCellWidth() * baseGridWidth + (baseGridWidth - 1) * playerBackpackData.GetCellHorizontalInterval();
			num2 = playerBackpackData.GetCellHeight() * baseGridHeight + (baseGridHeight - 1) * playerBackpackData.GetCellVerticalInterval();
		}
		this.RootItem.SetWidth((float)num);
		this.RootItem.SetHeight((float)num2);
		texture.SetWidth((float)(flag ? num2 : num));
		texture.SetHeight((float)(flag ? num : num2));
		base.SetTextureShowUntilLoaded(data.GetIconBackpack(), texture, null);
		texture.SetUIActive(true);
		FRotator frotator = flag ? instance.TransRotation : instance.NormalRotation;
		texture.SetUIRelativeRotation(frotator);
		this.RefreshLogicData();
	}

	// Token: 0x0600C539 RID: 50489 RVA: 0x003AA69B File Offset: 0x003A889B
	[NullableContext(1)]
	public UUIItem GetPanelForHover()
	{
		return base.GetItem(5);
	}

	// Token: 0x0600C53A RID: 50490 RVA: 0x003AA6A4 File Offset: 0x003A88A4
	protected void SetLockItemEnable(bool isLock, bool needMask)
	{
		if (this.IsForDrag)
		{
			return;
		}
		HonamiStoryItemLockStateItem lockItem = this.LockItem;
		if (lockItem != null)
		{
			lockItem.SetUiActive(isLock);
		}
		if (this.ItemData != null)
		{
			HonamiStoryItemLockStateItem lockItem2 = this.LockItem;
			if (lockItem2 != null)
			{
				lockItem2.RefreshMask(needMask, this.ItemData, this.BackpackType);
			}
		}
		if (isLock && this.LockItem == null && this.ItemData != null)
		{
			this.LockItem = new HonamiStoryItemLockStateItem();
			this.LockItem.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemTagLock", this.RootItem, false).ContinueWith(delegate()
			{
				HonamiStoryItemLockStateItem lockItem3 = this.LockItem;
				if (lockItem3 != null)
				{
					lockItem3.SetUiActive(isLock);
				}
				HonamiStoryItemLockStateItem lockItem4 = this.LockItem;
				if (lockItem4 == null)
				{
					return;
				}
				lockItem4.RefreshMask(needMask, this.ItemData, this.BackpackType);
			});
		}
	}

	// Token: 0x0600C53B RID: 50491 RVA: 0x003AA764 File Offset: 0x003A8964
	protected void SetSellItemEnable(bool isSell)
	{
		HonamiStoryItemSellAllItem sellItem = this.SellItem;
		if (sellItem != null)
		{
			sellItem.SetUiActive(isSell);
		}
		if (this.ItemData != null)
		{
			HonamiStoryItemSellAllItem sellItem2 = this.SellItem;
			if (sellItem2 != null)
			{
				sellItem2.SetSelected(this.ItemData.GetIsSelected());
			}
		}
		this.SetSellItemValueEnable(isSell);
		if (isSell && this.SellItem == null && this.ItemData != null)
		{
			this.SellItem = new HonamiStoryItemSellAllItem();
			this.SellItem.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemTagSell", base.GetItem(2), false).ContinueWith(delegate()
			{
				bool flag = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Sell && !this.ItemData.IsLock();
				HonamiStoryItemSellAllItem sellItem3 = this.SellItem;
				if (sellItem3 != null)
				{
					sellItem3.SetUiActive(flag);
				}
				HonamiStoryItemSellAllItem sellItem4 = this.SellItem;
				if (sellItem4 == null)
				{
					return;
				}
				sellItem4.SetSelected(flag && this.ItemData.GetIsSelected());
			});
		}
	}

	// Token: 0x0600C53C RID: 50492 RVA: 0x003AA7F8 File Offset: 0x003A89F8
	protected void SetSellItemValueEnable(bool isSell)
	{
		HonamiStoryItemSellValueItem sellValueItem = this.SellValueItem;
		if (sellValueItem != null)
		{
			sellValueItem.SetUiActive(isSell);
		}
		if (isSell && this.ItemData != null)
		{
			HonamiStoryItemSellValueItem sellValueItem2 = this.SellValueItem;
			if (sellValueItem2 != null)
			{
				sellValueItem2.Refresh(this.ItemData);
			}
		}
		if (isSell && this.SellItem == null)
		{
			this.SellValueItem = new HonamiStoryItemSellValueItem();
			this.SellValueItem.CreateThenShowByResourceIdAsync("PnlItemCost", base.GetItem(2), false).ContinueWith(delegate()
			{
				bool flag = HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Sell && this.ItemData != null && !this.ItemData.IsLock();
				HonamiStoryItemSellValueItem sellValueItem3 = this.SellValueItem;
				if (sellValueItem3 != null)
				{
					sellValueItem3.SetUiActive(flag);
				}
				if (flag && this.ItemData != null)
				{
					this.SellValueItem.Refresh(this.ItemData);
				}
			});
		}
	}

	// Token: 0x0600C53D RID: 50493 RVA: 0x003AA879 File Offset: 0x003A8A79
	[NullableContext(1)]
	public UUIItem GetTipsRoot()
	{
		return base.GetItem(4);
	}

	// Token: 0x0600C53E RID: 50494 RVA: 0x003AA882 File Offset: 0x003A8A82
	public HonamiStoryItemDataBase GetData()
	{
		return this.ItemData;
	}

	// Token: 0x0600C53F RID: 50495 RVA: 0x003AA88A File Offset: 0x003A8A8A
	public int GetIncId()
	{
		HonamiStoryItemDataBase itemData = this.ItemData;
		if (itemData == null)
		{
			return -1;
		}
		return itemData.GetIncId();
	}

	// Token: 0x0600C540 RID: 50496 RVA: 0x003AA89D File Offset: 0x003A8A9D
	public void SetBackpackType(EHonamiStoryBackpackType type)
	{
		this.BackpackType = type;
	}

	// Token: 0x0600C541 RID: 50497 RVA: 0x003AA8A6 File Offset: 0x003A8AA6
	public EHonamiStoryBackpackType GetBackpackType()
	{
		return this.BackpackType;
	}

	// Token: 0x0600C542 RID: 50498 RVA: 0x003AA8B0 File Offset: 0x003A8AB0
	public void SetIsForDrag(bool value)
	{
		this.IsForDrag = value;
		if (value)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.BackpackType = (HonamiStoryUtil.CheckInHonamiStoryDungeon() ? EHonamiStoryBackpackType.Backpack : EHonamiStoryBackpackType.Inventory);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(false);
			}
			this.DragGridFrame = new HonamiStoryDragItemFrameItem();
			this.DragGridFrame.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemDrag", base.GetItem(2), false);
		}
	}

	// Token: 0x0600C543 RID: 50499 RVA: 0x003AA935 File Offset: 0x003A8B35
	public void SetCanOpenTips(bool value)
	{
		this.CanOpenTips = value;
	}

	// Token: 0x0600C544 RID: 50500 RVA: 0x003AA940 File Offset: 0x003A8B40
	public void SetOverFlowEnable(bool enable)
	{
		if (!enable)
		{
			UiPanelBase overflowItem = this.OverflowItem;
			if (overflowItem == null)
			{
				return;
			}
			overflowItem.SetUiActive(false);
			return;
		}
		else
		{
			if (this.OverflowItem == null)
			{
				this.OverflowItem = new UiPanelBase();
				this.OverflowItem.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemTagOverflow", base.GetItem(2), false).ContinueWith(delegate()
				{
					HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(1, false);
					int row = this.ItemData.GetRow();
					int heightCount = backPackData.GetHeightCount(false);
					bool uiActive = row + this.ItemData.GetGridHeight() > heightCount;
					UiPanelBase overflowItem2 = this.OverflowItem;
					if (overflowItem2 == null)
					{
						return;
					}
					overflowItem2.SetUiActive(uiActive);
				});
				return;
			}
			if (!this.OverflowItem.InAsyncLoading())
			{
				this.OverflowItem.SetUiActive(true);
			}
			return;
		}
	}

	// Token: 0x0600C545 RID: 50501 RVA: 0x003AA9BC File Offset: 0x003A8BBC
	protected virtual void RefreshLogicData()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (this.ItemData != null)
		{
			this.SetLockItemEnable(this.ItemData.IsLock(), backpackLogicState == EHonamiStoryBackpackLogicState.Sell);
		}
		if (backpackLogicState != EHonamiStoryBackpackLogicState.Normal)
		{
			if (backpackLogicState == EHonamiStoryBackpackLogicState.Sell)
			{
				if (this.ItemData != null && this.ItemData.IsLock())
				{
					this.SetSellItemEnable(false);
					return;
				}
				this.SetSellItemEnable(true);
			}
			return;
		}
		this.SetSellItemEnable(false);
		HonamiStoryItemSellAllItem sellItem = this.SellItem;
		if (sellItem == null)
		{
			return;
		}
		sellItem.SetUiActive(false);
	}

	// Token: 0x0600C546 RID: 50502 RVA: 0x003AAA38 File Offset: 0x003A8C38
	protected virtual void ExecuteDoubleClickLogic()
	{
		if (this.BackpackType == EHonamiStoryBackpackType.Inventory)
		{
			this.NormalBagDoubleClick();
			return;
		}
		if (this.BackpackType == EHonamiStoryBackpackType.Backpack)
		{
			if (UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) != null)
			{
				this.NormalBagDoubleClick();
				return;
			}
			if (this.ItemData != null && this.ItemData.IsLock())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_TryDiscardLockItem", Array.Empty<object>());
				return;
			}
			if (this.ItemData != null)
			{
				HonamiStoryModel.Instance.SetItemIntoBag(this.ItemData, EHonamiStoryBackpack.Backpack, EHonamiStoryBackpack.PickUpBox);
				return;
			}
		}
		else if (this.BackpackType == EHonamiStoryBackpackType.PickUpBox)
		{
			int position = this.ItemData.GetPosition();
			HonamiStoryModel.Instance.QuickPickUpFromPickUpBox(this.ItemData, position);
		}
	}

	// Token: 0x0600C547 RID: 50503 RVA: 0x003AAAE4 File Offset: 0x003A8CE4
	protected void NormalBagDoubleClick()
	{
		if (this.ItemData.GetItemType() == EHonamiStoryItemType.Plugin)
		{
			int position = this.ItemData.GetPosition();
			if (!HonamiStoryModel.Instance.QuickEquipFromBackpack(this.ItemData, position))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_ShowTips_CantQuickEquip", Array.Empty<object>());
				return;
			}
		}
		else
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_CantEquipNormalItem", Array.Empty<object>());
		}
	}

	// Token: 0x0600C548 RID: 50504 RVA: 0x003AAB48 File Offset: 0x003A8D48
	protected virtual void DoLogicStateFunc(EHonamiStoryBackpackLogicState state)
	{
		if (state == EHonamiStoryBackpackLogicState.Sell)
		{
			this.DoSellLogic();
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Tips || state == EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
			HonamiStoryItemTipsBase tipsItem = backpackLogic.TipsItem;
			HonamiStoryItemDataBase itemDataOut = tipsItem.GetItemDataOut();
			backpackLogic.CloseTips();
			if (this.ItemData == itemDataOut)
			{
				tipsItem.SetItemDataOut(itemDataOut);
			}
			this.OnClickedToggle(EToggleState.ETT_UnChecked);
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Instead)
		{
			UUIExtendToggle draggableComponent = this.DraggableComponent;
			if (draggableComponent != null)
			{
				draggableComponent.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
			if (HonamiStoryModel.Instance.GetBackpackLogic().OnClickGrid(this.ItemData, new Action(this.OnTipsCallback), this))
			{
				this.ExecuteDoubleClickLogic();
			}
		}
	}

	// Token: 0x0600C549 RID: 50505 RVA: 0x003AABEC File Offset: 0x003A8DEC
	public void DoSellLogic()
	{
		if (this.ItemData.IsLock())
		{
			this.DraggableComponent.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
		HonamiStoryModel.Instance.GetBackpackLogic().RegisterSingleSellItem(this.ItemData);
		this.RefreshLogicData();
		UUIExtendToggle draggableComponent = this.DraggableComponent;
		if (draggableComponent == null)
		{
			return;
		}
		draggableComponent.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C54A RID: 50506 RVA: 0x003AAC47 File Offset: 0x003A8E47
	public void CancelToggleSelect()
	{
		this.DraggableComponent.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C54B RID: 50507 RVA: 0x003AAC5C File Offset: 0x003A8E5C
	public void PlayMoveItemSeq()
	{
		if (!this.IsForDrag || !HonamiStoryUtil.IsMobileView())
		{
			return;
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayOrReplaySequenceByName("MoveUp", false, null);
	}

	// Token: 0x0600C54C RID: 50508 RVA: 0x003AAC98 File Offset: 0x003A8E98
	protected void OnTipsCallback()
	{
		Action onClickedGridTipsCb = this.OnClickedGridTipsCb;
		if (onClickedGridTipsCb == null)
		{
			return;
		}
		onClickedGridTipsCb();
	}

	// Token: 0x0600C54D RID: 50509 RVA: 0x003AACAC File Offset: 0x003A8EAC
	protected void OnClickedToggle(EToggleState _)
	{
		if (!this.CanOpenTips)
		{
			this.CancelToggleSelect();
			return;
		}
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		EHonamiStoryBackpackLogicState logicState = backpackLogic.GetLogicState();
		if (logicState == EHonamiStoryBackpackLogicState.Normal)
		{
			if (backpackLogic.OnClickGrid(this.ItemData, new Action(this.OnTipsCallback), this))
			{
				backpackLogic.TipsItem.SetItemDataOut(null);
				this.ExecuteDoubleClickLogic();
			}
			return;
		}
		this.DoLogicStateFunc(logicState);
	}

	// Token: 0x0600C54E RID: 50510 RVA: 0x003AAD12 File Offset: 0x003A8F12
	public void OnHideCallback()
	{
		this.CancelToggleSelect();
	}

	// Token: 0x0600C54F RID: 50511 RVA: 0x003AAD1A File Offset: 0x003A8F1A
	public void SetIsEnable(bool value)
	{
		UUIExtendToggle draggableComponent = this.DraggableComponent;
		if (draggableComponent == null)
		{
			return;
		}
		draggableComponent.SetSelfInteractive(value);
	}

	// Token: 0x04007063 RID: 28771
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007064 RID: 28772
	public Action OnClickedGridTipsCb;

	// Token: 0x04007065 RID: 28773
	[Nullable(1)]
	public UUIExtendToggle DraggableComponent;

	// Token: 0x04007066 RID: 28774
	protected EHonamiStoryBackpackType BackpackType = EHonamiStoryBackpackType.Backpack;

	// Token: 0x04007067 RID: 28775
	protected HonamiStoryItemLockStateItem LockItem;

	// Token: 0x04007068 RID: 28776
	protected HonamiStoryItemSellAllItem SellItem;

	// Token: 0x04007069 RID: 28777
	protected HonamiStoryItemSellValueItem SellValueItem;

	// Token: 0x0400706A RID: 28778
	protected UiPanelBase OverflowItem;

	// Token: 0x0400706B RID: 28779
	protected HonamiStoryDragItemFrameItem DragGridFrame;

	// Token: 0x0400706C RID: 28780
	private bool IsForDrag;

	// Token: 0x0400706D RID: 28781
	private bool CanOpenTips = true;

	// Token: 0x0400706E RID: 28782
	protected HonamiStoryItemDataBase ItemData;

	// Token: 0x020075FC RID: 30204
	[NullableContext(0)]
	private enum EItem
	{
		// Token: 0x040264E6 RID: 156902
		Toggle,
		// Token: 0x040264E7 RID: 156903
		TexIcon,
		// Token: 0x040264E8 RID: 156904
		PanelState,
		// Token: 0x040264E9 RID: 156905
		PanelGrid,
		// Token: 0x040264EA RID: 156906
		PanelTips,
		// Token: 0x040264EB RID: 156907
		PanelOffset
	}
}
