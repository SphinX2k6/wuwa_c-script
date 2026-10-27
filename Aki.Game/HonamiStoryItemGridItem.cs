using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001EA8 RID: 7848
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryItemGridItem : UiPanelBase
{
	// Token: 0x0600F115 RID: 61717 RVA: 0x0039E807 File Offset: 0x0039CA07
	public HonamiStoryItemGridItem(HonamiStoryItemDataBase itemData)
	{
		this.ItemData = itemData;
	}

	// Token: 0x0600F116 RID: 61718 RVA: 0x0039E824 File Offset: 0x0039CA24
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

	// Token: 0x0600F117 RID: 61719 RVA: 0x0039E94E File Offset: 0x0039CB4E
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

	// Token: 0x0600F118 RID: 61720 RVA: 0x0039E978 File Offset: 0x0039CB78
	protected override void OnBeforeDestroy()
	{
		this.LockItem = null;
	}

	// Token: 0x0600F119 RID: 61721 RVA: 0x0039E984 File Offset: 0x0039CB84
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

	// Token: 0x0600F11A RID: 61722 RVA: 0x0039EADF File Offset: 0x0039CCDF
	[NullableContext(1)]
	public UUIItem GetPanelForHover()
	{
		return base.GetItem(5);
	}

	// Token: 0x0600F11B RID: 61723 RVA: 0x0039EAE8 File Offset: 0x0039CCE8
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

	// Token: 0x0600F11C RID: 61724 RVA: 0x0039EBA8 File Offset: 0x0039CDA8
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

	// Token: 0x0600F11D RID: 61725 RVA: 0x0039EC3C File Offset: 0x0039CE3C
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

	// Token: 0x0600F11E RID: 61726 RVA: 0x0039ECBD File Offset: 0x0039CEBD
	[NullableContext(1)]
	public UUIItem GetTipsRoot()
	{
		return base.GetItem(4);
	}

	// Token: 0x0600F11F RID: 61727 RVA: 0x0039ECC6 File Offset: 0x0039CEC6
	public HonamiStoryItemDataBase GetData()
	{
		return this.ItemData;
	}

	// Token: 0x0600F120 RID: 61728 RVA: 0x0039ECCE File Offset: 0x0039CECE
	public int GetIncId()
	{
		HonamiStoryItemDataBase itemData = this.ItemData;
		if (itemData == null)
		{
			return -1;
		}
		return itemData.GetIncId();
	}

	// Token: 0x0600F121 RID: 61729 RVA: 0x0039ECE1 File Offset: 0x0039CEE1
	public void SetBackpackType(EHonamiStoryBackpackType type)
	{
		this.BackpackType = type;
	}

	// Token: 0x0600F122 RID: 61730 RVA: 0x0039ECEA File Offset: 0x0039CEEA
	public EHonamiStoryBackpackType GetBackpackType()
	{
		return this.BackpackType;
	}

	// Token: 0x0600F123 RID: 61731 RVA: 0x0039ECF4 File Offset: 0x0039CEF4
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

	// Token: 0x0600F124 RID: 61732 RVA: 0x0039ED79 File Offset: 0x0039CF79
	public void SetCanOpenTips(bool value)
	{
		this.CanOpenTips = value;
	}

	// Token: 0x0600F125 RID: 61733 RVA: 0x0039ED84 File Offset: 0x0039CF84
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

	// Token: 0x0600F126 RID: 61734 RVA: 0x0039EE00 File Offset: 0x0039D000
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

	// Token: 0x0600F127 RID: 61735 RVA: 0x0039EE7C File Offset: 0x0039D07C
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

	// Token: 0x0600F128 RID: 61736 RVA: 0x0039EF28 File Offset: 0x0039D128
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

	// Token: 0x0600F129 RID: 61737 RVA: 0x0039EF8C File Offset: 0x0039D18C
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

	// Token: 0x0600F12A RID: 61738 RVA: 0x0039F030 File Offset: 0x0039D230
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

	// Token: 0x0600F12B RID: 61739 RVA: 0x0039F08B File Offset: 0x0039D28B
	public void CancelToggleSelect()
	{
		this.DraggableComponent.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F12C RID: 61740 RVA: 0x0039F0A0 File Offset: 0x0039D2A0
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

	// Token: 0x0600F12D RID: 61741 RVA: 0x0039F0DC File Offset: 0x0039D2DC
	protected void OnTipsCallback()
	{
		Action onClickedGridTipsCb = this.OnClickedGridTipsCb;
		if (onClickedGridTipsCb == null)
		{
			return;
		}
		onClickedGridTipsCb();
	}

	// Token: 0x0600F12E RID: 61742 RVA: 0x0039F0F0 File Offset: 0x0039D2F0
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

	// Token: 0x0600F12F RID: 61743 RVA: 0x0039F156 File Offset: 0x0039D356
	public void OnHideCallback()
	{
		this.CancelToggleSelect();
	}

	// Token: 0x0600F130 RID: 61744 RVA: 0x0039F15E File Offset: 0x0039D35E
	public void SetIsEnable(bool value)
	{
		UUIExtendToggle draggableComponent = this.DraggableComponent;
		if (draggableComponent == null)
		{
			return;
		}
		draggableComponent.SetSelfInteractive(value);
	}

	// Token: 0x04006F82 RID: 28546
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006F83 RID: 28547
	public Action OnClickedGridTipsCb;

	// Token: 0x04006F84 RID: 28548
	[Nullable(1)]
	public UUIExtendToggle DraggableComponent;

	// Token: 0x04006F85 RID: 28549
	protected EHonamiStoryBackpackType BackpackType = EHonamiStoryBackpackType.Backpack;

	// Token: 0x04006F86 RID: 28550
	protected HonamiStoryItemLockStateItem LockItem;

	// Token: 0x04006F87 RID: 28551
	protected HonamiStoryItemSellAllItem SellItem;

	// Token: 0x04006F88 RID: 28552
	protected HonamiStoryItemSellValueItem SellValueItem;

	// Token: 0x04006F89 RID: 28553
	protected UiPanelBase OverflowItem;

	// Token: 0x04006F8A RID: 28554
	protected HonamiStoryDragItemFrameItem DragGridFrame;

	// Token: 0x04006F8B RID: 28555
	private bool IsForDrag;

	// Token: 0x04006F8C RID: 28556
	private bool CanOpenTips = true;

	// Token: 0x04006F8D RID: 28557
	protected HonamiStoryItemDataBase ItemData;

	// Token: 0x02008477 RID: 33911
	[NullableContext(0)]
	private enum EItem
	{
		// Token: 0x0402B1C2 RID: 176578
		Toggle,
		// Token: 0x0402B1C3 RID: 176579
		TexIcon,
		// Token: 0x0402B1C4 RID: 176580
		PanelState,
		// Token: 0x0402B1C5 RID: 176581
		PanelGrid,
		// Token: 0x0402B1C6 RID: 176582
		PanelTips,
		// Token: 0x0402B1C7 RID: 176583
		PanelOffset
	}
}
