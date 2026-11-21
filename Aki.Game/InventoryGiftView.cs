using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200149C RID: 5276
[NullableContext(1)]
[Nullable(0)]
public class InventoryGiftView : UiViewBase
{
	// Token: 0x0600D2ED RID: 53997 RVA: 0x003E90C5 File Offset: 0x003E72C5
	public InventoryGiftView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D2EE RID: 53998 RVA: 0x003E90E4 File Offset: 0x003E72E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickErrorConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.ClickClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D2EF RID: 53999 RVA: 0x003E9296 File Offset: 0x003E7496
	protected void ClickClose()
	{
		UiManager.Instance.CloseView(EUiViewName.InventoryGiftView, null);
	}

	// Token: 0x0600D2F0 RID: 54000 RVA: 0x003E92A8 File Offset: 0x003E74A8
	protected void OnClickConfirm()
	{
		List<int> list = new List<int>();
		int count = this.SelectedItemList.Count;
		for (int i = 0; i < count; i++)
		{
			list.Add(this.SelectedItemList[i].ItemId);
		}
		InventoryGiftController instance = InventoryGiftController.Instance;
		int configId = this.InventoryGiftData.ConfigId;
		NumberSelectComponent numberSelect = this.NumberSelect;
		instance.SendItemGiftUseRequest(configId, (numberSelect != null) ? numberSelect.GetSelectNumber() : 1, list.ToArray());
	}

	// Token: 0x0600D2F1 RID: 54001 RVA: 0x003E9318 File Offset: 0x003E7518
	protected void OnClickErrorConfirm()
	{
		int availableNum = this.InventoryGiftData.GiftPackage.AvailableNum;
		ScrollingTipsController.Instance.ShowTipsById("SelectGiftItem", new object[]
		{
			availableNum
		});
	}

	// Token: 0x0600D2F2 RID: 54002 RVA: 0x003E9354 File Offset: 0x003E7554
	protected override void OnStart()
	{
		this.InventoryGiftData = (this.OpenParam as InventoryGiftData);
		this.ItemList = this.InventoryGiftData.ItemList;
		this.LoopScrollView = new LoopScrollView<InventoryGiftItem, GiftItemData>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<InventoryGiftItem>(this.InitItem), false);
		this.LoopScrollView.ReloadProxyData(new Func<int, GiftItemData>(this.GetScrollViewData), this.ItemList.Length, false, false);
		this.ConfirmButton = base.GetButton(1);
		this.ConfirmErrorButton = base.GetButton(2);
		this.ConfirmButtonInteractionGroup = (this.ConfirmButton.GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
		this.DescText = base.GetText(5);
		this.TitleText = base.GetText(0);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.InventoryGiftData.ConfigId);
		LguiUtil.Instance.SetLocalTextNew(this.TitleText, itemConfigData.Name, Array.Empty<object>());
		this.NumberSelect = new NumberSelectComponent(base.GetItem(7));
		INumberSelectData numberSelectData = new INumberSelectData();
		numberSelectData.MaxNumber = InventoryModel.Instance.GetItemCountByConfigId(this.InventoryGiftData.ConfigId, 0);
		numberSelectData.GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText);
		numberSelectData.ValueChangeFunction = delegate(int _)
		{
		};
		INumberSelectData data = numberSelectData;
		if (this.CheckIfGiftItem())
		{
			this.NumberSelect.SetLimitMaxValue(CommonConfig.Instance.GetGiftMaxNineNineNine());
		}
		this.NumberSelect.Init(data);
		if (this.InventoryGiftData.InitializedSelectedId != null)
		{
			for (int i = 0; i < this.ItemList.Length; i++)
			{
				GiftItemData giftItemData = this.ItemList[i];
				int itemId = giftItemData.ItemId;
				int? initializedSelectedId = this.InventoryGiftData.InitializedSelectedId;
				if (itemId == initializedSelectedId.GetValueOrDefault() & initializedSelectedId != null)
				{
					this.SelectedItemList.Add(giftItemData);
					this.LoopScrollView.ScrollToGridIndex(i, false);
					this.LoopScrollView.SelectGridProxy(i, true);
					break;
				}
			}
		}
		if (this.InventoryGiftData.SelectedCount != null)
		{
			this.NumberSelect.ChangeValue(this.InventoryGiftData.SelectedCount.Value, true);
		}
		this.RefreshSelectCountInfo();
	}

	// Token: 0x0600D2F3 RID: 54003 RVA: 0x003E95A4 File Offset: 0x003E77A4
	private bool CheckIfGiftItem()
	{
		int configId = this.InventoryGiftData.ConfigId;
		if (configId == 0)
		{
			return false;
		}
		InventoryDefine.EItemType? itemType = InventoryConfig.Instance.GetItemConfigData(configId).ItemType;
		return itemType.GetValueOrDefault() == InventoryDefine.EItemType.Gift;
	}

	// Token: 0x0600D2F4 RID: 54004 RVA: 0x003E95DE File Offset: 0x003E77DE
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ItemUseCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600D2F5 RID: 54005 RVA: 0x003E9600 File Offset: 0x003E7800
	protected override void OnAfterShow()
	{
		if (this.InventoryGiftData == null)
		{
			this.SetConfirmButtonState(false);
			return;
		}
		int availableNum = this.InventoryGiftData.GiftPackage.AvailableNum;
		bool confirmButtonState = this.SelectedItemList.Count == availableNum;
		this.SetConfirmButtonState(confirmButtonState);
	}

	// Token: 0x0600D2F6 RID: 54006 RVA: 0x003E9644 File Offset: 0x003E7844
	protected override void OnAfterHide()
	{
		UiBlurLogic.Instance.ResumeTopUiRenderAfterBlur();
	}

	// Token: 0x0600D2F7 RID: 54007 RVA: 0x003E9650 File Offset: 0x003E7850
	protected override void OnBeforeDestroy()
	{
		this.LoopScrollView = null;
		this.ItemList = Array.Empty<GiftItemData>();
		this.SelectedItemList = new List<GiftItemData>();
		this.InventoryGiftData = null;
		this.ConfirmButtonInteractionGroup = null;
		this.ConfirmButton = null;
		this.ConfirmErrorButton = null;
		this.DescText = null;
		this.TitleText = null;
		NumberSelectComponent numberSelect = this.NumberSelect;
		if (numberSelect != null)
		{
			numberSelect.Destroy(null);
		}
		this.NumberSelect = null;
	}

	// Token: 0x0600D2F8 RID: 54008 RVA: 0x003E96C0 File Offset: 0x003E78C0
	private InventoryGiftItem InitItem()
	{
		InventoryGiftItem inventoryGiftItem = new InventoryGiftItem();
		inventoryGiftItem.Initialize(null);
		inventoryGiftItem.SetOnToggleStateChangeFunction(new Action<UUIExtendToggle, UUIButtonComponent, bool, GiftItemData>(this.OnToggleStateChangeFunction));
		inventoryGiftItem.SetOnReduceFunction(new Action<GiftItemData>(this.OnReduceFunction));
		inventoryGiftItem.SetIsSelectOn(new Func<GiftItemData, bool>(this.OnIsSelectOnFunction));
		return inventoryGiftItem;
	}

	// Token: 0x0600D2F9 RID: 54009 RVA: 0x003E970F File Offset: 0x003E790F
	private GiftItemData GetScrollViewData(int gridIndex)
	{
		return this.ItemList[gridIndex];
	}

	// Token: 0x0600D2FA RID: 54010 RVA: 0x003E971C File Offset: 0x003E791C
	protected void OnToggleStateChangeFunction(UUIExtendToggle toggle, UUIButtonComponent reduceButton, bool isSelected, GiftItemData itemData)
	{
		int availableNum = this.InventoryGiftData.GiftPackage.AvailableNum;
		if (isSelected)
		{
			if (this.SelectedItemList.Count == availableNum)
			{
				GiftItemData obj = this.SelectedItemList[0];
				this.SelectedItemList.RemoveAt(0);
				LoopScrollView<InventoryGiftItem, GiftItemData> loopScrollView = this.LoopScrollView;
				if (loopScrollView != null)
				{
					InventoryGiftItem inventoryGiftItem = loopScrollView.UnsafeGetGridProxy(this.ItemList.IndexOf(obj), false);
					if (inventoryGiftItem != null)
					{
						inventoryGiftItem.RefreshSelectState();
					}
				}
			}
			this.SelectedItemList.Add(itemData);
		}
		else
		{
			int index = this.SelectedItemList.IndexOf(itemData);
			this.SelectedItemList.RemoveAt(index);
		}
		this.RefreshSelectCountInfo();
	}

	// Token: 0x0600D2FB RID: 54011 RVA: 0x003E97BC File Offset: 0x003E79BC
	protected void OnReduceFunction(GiftItemData itemData)
	{
		int num = this.SelectedItemList.IndexOf(itemData);
		if (num == -1)
		{
			return;
		}
		this.SelectedItemList.RemoveAt(num);
		this.RefreshSelectCountInfo();
	}

	// Token: 0x0600D2FC RID: 54012 RVA: 0x003E97ED File Offset: 0x003E79ED
	protected bool OnIsSelectOnFunction(GiftItemData itemData)
	{
		return this.SelectedItemList.Contains(itemData);
	}

	// Token: 0x0600D2FD RID: 54013 RVA: 0x003E97FC File Offset: 0x003E79FC
	protected void RefreshSelectCountInfo()
	{
		int availableNum = this.InventoryGiftData.GiftPackage.AvailableNum;
		int count = this.SelectedItemList.Count;
		LguiUtil.Instance.SetLocalText(this.DescText, "SelectRewardFromPool", new <>z__ReadOnlyArray<object>(new object[]
		{
			availableNum,
			count,
			availableNum
		}));
		bool confirmButtonState = count == availableNum;
		this.SetConfirmButtonState(confirmButtonState);
	}

	// Token: 0x0600D2FE RID: 54014 RVA: 0x003E9870 File Offset: 0x003E7A70
	private void SetConfirmButtonState(bool isShow)
	{
		this.ConfirmButtonInteractionGroup.SetInteractable(isShow);
		this.ConfirmErrorButton.RootUIComp.Get().SetUIActive(!isShow);
	}

	// Token: 0x040076AF RID: 30383
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<InventoryGiftItem, GiftItemData> LoopScrollView;

	// Token: 0x040076B0 RID: 30384
	private GiftItemData[] ItemList = Array.Empty<GiftItemData>();

	// Token: 0x040076B1 RID: 30385
	private List<GiftItemData> SelectedItemList = new List<GiftItemData>();

	// Token: 0x040076B2 RID: 30386
	[Nullable(2)]
	private InventoryGiftData InventoryGiftData;

	// Token: 0x040076B3 RID: 30387
	[Nullable(2)]
	private UUIInteractionGroup ConfirmButtonInteractionGroup;

	// Token: 0x040076B4 RID: 30388
	[Nullable(2)]
	private UUIButtonComponent ConfirmButton;

	// Token: 0x040076B5 RID: 30389
	[Nullable(2)]
	private UUIButtonComponent ConfirmErrorButton;

	// Token: 0x040076B6 RID: 30390
	[Nullable(2)]
	private UUIText DescText;

	// Token: 0x040076B7 RID: 30391
	[Nullable(2)]
	private UUIText TitleText;

	// Token: 0x040076B8 RID: 30392
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x02007761 RID: 30561
	[NullableContext(0)]
	private enum EInventoryGiftViewDefine
	{
		// Token: 0x04026C32 RID: 158770
		TitleText,
		// Token: 0x04026C33 RID: 158771
		ConfirmButton,
		// Token: 0x04026C34 RID: 158772
		ConfirmErrorButton,
		// Token: 0x04026C35 RID: 158773
		LoopScrollView,
		// Token: 0x04026C36 RID: 158774
		LoopScrollItem,
		// Token: 0x04026C37 RID: 158775
		DescText,
		// Token: 0x04026C38 RID: 158776
		CancelButton,
		// Token: 0x04026C39 RID: 158777
		NumberSelect
	}
}
