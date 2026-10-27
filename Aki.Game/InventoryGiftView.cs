using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FC9 RID: 8137
[NullableContext(1)]
[Nullable(0)]
public class InventoryGiftView : UiViewBase
{
	// Token: 0x0600FE85 RID: 65157 RVA: 0x003DCAE9 File Offset: 0x003DACE9
	public InventoryGiftView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FE86 RID: 65158 RVA: 0x003DCB08 File Offset: 0x003DAD08
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

	// Token: 0x0600FE87 RID: 65159 RVA: 0x003DCCBA File Offset: 0x003DAEBA
	protected void ClickClose()
	{
		UiManager.Instance.CloseView(EUiViewName.InventoryGiftView, null);
	}

	// Token: 0x0600FE88 RID: 65160 RVA: 0x003DCCCC File Offset: 0x003DAECC
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

	// Token: 0x0600FE89 RID: 65161 RVA: 0x003DCD3C File Offset: 0x003DAF3C
	protected void OnClickErrorConfirm()
	{
		int availableNum = this.InventoryGiftData.GiftPackage.AvailableNum;
		ScrollingTipsController.Instance.ShowTipsById("SelectGiftItem", new object[]
		{
			availableNum
		});
	}

	// Token: 0x0600FE8A RID: 65162 RVA: 0x003DCD78 File Offset: 0x003DAF78
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

	// Token: 0x0600FE8B RID: 65163 RVA: 0x003DCFC8 File Offset: 0x003DB1C8
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

	// Token: 0x0600FE8C RID: 65164 RVA: 0x003DD002 File Offset: 0x003DB202
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ItemUseCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600FE8D RID: 65165 RVA: 0x003DD024 File Offset: 0x003DB224
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

	// Token: 0x0600FE8E RID: 65166 RVA: 0x003DD068 File Offset: 0x003DB268
	protected override void OnAfterHide()
	{
		UiBlurLogic.Instance.ResumeTopUiRenderAfterBlur();
	}

	// Token: 0x0600FE8F RID: 65167 RVA: 0x003DD074 File Offset: 0x003DB274
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

	// Token: 0x0600FE90 RID: 65168 RVA: 0x003DD0E4 File Offset: 0x003DB2E4
	private InventoryGiftItem InitItem()
	{
		InventoryGiftItem inventoryGiftItem = new InventoryGiftItem();
		inventoryGiftItem.Initialize(null);
		inventoryGiftItem.SetOnToggleStateChangeFunction(new Action<UUIExtendToggle, UUIButtonComponent, bool, GiftItemData>(this.OnToggleStateChangeFunction));
		inventoryGiftItem.SetOnReduceFunction(new Action<GiftItemData>(this.OnReduceFunction));
		inventoryGiftItem.SetIsSelectOn(new Func<GiftItemData, bool>(this.OnIsSelectOnFunction));
		return inventoryGiftItem;
	}

	// Token: 0x0600FE91 RID: 65169 RVA: 0x003DD133 File Offset: 0x003DB333
	private GiftItemData GetScrollViewData(int gridIndex)
	{
		return this.ItemList[gridIndex];
	}

	// Token: 0x0600FE92 RID: 65170 RVA: 0x003DD140 File Offset: 0x003DB340
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

	// Token: 0x0600FE93 RID: 65171 RVA: 0x003DD1E0 File Offset: 0x003DB3E0
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

	// Token: 0x0600FE94 RID: 65172 RVA: 0x003DD211 File Offset: 0x003DB411
	protected bool OnIsSelectOnFunction(GiftItemData itemData)
	{
		return this.SelectedItemList.Contains(itemData);
	}

	// Token: 0x0600FE95 RID: 65173 RVA: 0x003DD220 File Offset: 0x003DB420
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

	// Token: 0x0600FE96 RID: 65174 RVA: 0x003DD294 File Offset: 0x003DB494
	private void SetConfirmButtonState(bool isShow)
	{
		this.ConfirmButtonInteractionGroup.SetInteractable(isShow);
		this.ConfirmErrorButton.RootUIComp.Get().SetUIActive(!isShow);
	}

	// Token: 0x040075C6 RID: 30150
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<InventoryGiftItem, GiftItemData> LoopScrollView;

	// Token: 0x040075C7 RID: 30151
	private GiftItemData[] ItemList = Array.Empty<GiftItemData>();

	// Token: 0x040075C8 RID: 30152
	private List<GiftItemData> SelectedItemList = new List<GiftItemData>();

	// Token: 0x040075C9 RID: 30153
	[Nullable(2)]
	private InventoryGiftData InventoryGiftData;

	// Token: 0x040075CA RID: 30154
	[Nullable(2)]
	private UUIInteractionGroup ConfirmButtonInteractionGroup;

	// Token: 0x040075CB RID: 30155
	[Nullable(2)]
	private UUIButtonComponent ConfirmButton;

	// Token: 0x040075CC RID: 30156
	[Nullable(2)]
	private UUIButtonComponent ConfirmErrorButton;

	// Token: 0x040075CD RID: 30157
	[Nullable(2)]
	private UUIText DescText;

	// Token: 0x040075CE RID: 30158
	[Nullable(2)]
	private UUIText TitleText;

	// Token: 0x040075CF RID: 30159
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x020085DA RID: 34266
	[NullableContext(0)]
	private enum EInventoryGiftViewDefine
	{
		// Token: 0x0402B923 RID: 178467
		TitleText,
		// Token: 0x0402B924 RID: 178468
		ConfirmButton,
		// Token: 0x0402B925 RID: 178469
		ConfirmErrorButton,
		// Token: 0x0402B926 RID: 178470
		LoopScrollView,
		// Token: 0x0402B927 RID: 178471
		LoopScrollItem,
		// Token: 0x0402B928 RID: 178472
		DescText,
		// Token: 0x0402B929 RID: 178473
		CancelButton,
		// Token: 0x0402B92A RID: 178474
		NumberSelect
	}
}
