using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200234B RID: 9035
public class GameplayShopItem : UiPanelBase
{
	// Token: 0x06011FAE RID: 73646 RVA: 0x004687B4 File Offset: 0x004669B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnBuyButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011FAF RID: 73647 RVA: 0x00468A74 File Offset: 0x00466C74
	protected override void OnStart()
	{
		this.BaseItem = new GameplayShopBaseItem();
		this.BaseItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
	}

	// Token: 0x06011FB0 RID: 73648 RVA: 0x00468A99 File Offset: 0x00466C99
	[NullableContext(1)]
	public void RefreshByData(IGameplayShopItemProxy data)
	{
		this.ItemProxy = data;
		this.RefreshBaseItem();
		this.RefreshDiscountItem();
		this.RefreshLabelItem();
		this.RefreshLeftTimeItem();
		this.RefreshReSellText();
		this.RefreshSoldOutItem();
		this.RefreshLockItem();
		this.RefreshNewFlagItem();
		this.RefreshRaycastTarget();
	}

	// Token: 0x06011FB1 RID: 73649 RVA: 0x00468AD8 File Offset: 0x00466CD8
	public void RefreshBaseItem()
	{
		if (this.ItemProxy == null || this.BaseItem == null)
		{
			return;
		}
		this.BaseItem.RefreshByData(this.ItemProxy);
	}

	// Token: 0x06011FB2 RID: 73650 RVA: 0x00468AFC File Offset: 0x00466CFC
	public void RefreshDiscountItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(1).SetUIActive(this.ItemProxy.DiscountItemVisible);
		if (this.ItemProxy.DiscountItemVisible)
		{
			GameplayShopUtil.SetText(base.GetText(2), this.ItemProxy.DiscountTextData);
		}
	}

	// Token: 0x06011FB3 RID: 73651 RVA: 0x00468B50 File Offset: 0x00466D50
	public void RefreshLabelItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(4).SetUIActive(this.ItemProxy.LabelVisible);
		if (this.ItemProxy.LabelVisible)
		{
			GameplayShopUtil.SetText(base.GetText(11), this.ItemProxy.LabelTextData);
		}
	}

	// Token: 0x06011FB4 RID: 73652 RVA: 0x00468BA4 File Offset: 0x00466DA4
	public void RefreshLeftTimeItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(5).SetUIActive(this.ItemProxy.LeftTimeItemVisible);
		if (this.ItemProxy.LeftTimeItemVisible)
		{
			GameplayShopUtil.SetText(base.GetText(6), this.ItemProxy.LeftTimeTextData);
		}
	}

	// Token: 0x06011FB5 RID: 73653 RVA: 0x00468BF8 File Offset: 0x00466DF8
	public void RefreshReSellText()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		UUIText text = base.GetText(7);
		text.SetUIActive(this.ItemProxy.ReSellItemVisible);
		if (this.ItemProxy.ReSellItemVisible)
		{
			GameplayShopUtil.SetText(text, this.ItemProxy.ReSellTextData);
		}
	}

	// Token: 0x06011FB6 RID: 73654 RVA: 0x00468C48 File Offset: 0x00466E48
	public void RefreshSoldOutItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(13).SetUIActive(this.ItemProxy.SoldOutItemVisible);
		if (this.ItemProxy.SoldOutItemVisible)
		{
			GameplayShopUtil.SetText(base.GetText(14), this.ItemProxy.SoldOutTextData);
		}
	}

	// Token: 0x06011FB7 RID: 73655 RVA: 0x00468C9C File Offset: 0x00466E9C
	public void RefreshLockItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(15).SetUIActive(this.ItemProxy.LockItemVisible);
		if (this.ItemProxy.LockItemVisible)
		{
			GameplayShopUtil.SetText(base.GetText(16), this.ItemProxy.LockTextData);
		}
	}

	// Token: 0x06011FB8 RID: 73656 RVA: 0x00468CEF File Offset: 0x00466EEF
	public void RefreshNewFlagItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(17).SetUIActive(this.ItemProxy.TagNewItemVisible);
	}

	// Token: 0x06011FB9 RID: 73657 RVA: 0x00468D12 File Offset: 0x00466F12
	public void RefreshRaycastTarget()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		this.RootItem.SetRaycastTarget(this.ItemProxy.RaycastTarget);
	}

	// Token: 0x06011FBA RID: 73658 RVA: 0x00468D33 File Offset: 0x00466F33
	private void OnBuyButtonClick()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		this.ItemProxy.OnBuyButtonClick();
	}

	// Token: 0x040087E2 RID: 34786
	[Nullable(2)]
	protected IGameplayShopItemProxy ItemProxy;

	// Token: 0x040087E3 RID: 34787
	[Nullable(2)]
	protected GameplayShopBaseItem BaseItem;

	// Token: 0x020088C7 RID: 35015
	private enum EComponent
	{
		// Token: 0x0402C748 RID: 182088
		BaseItem,
		// Token: 0x0402C749 RID: 182089
		DiscountItem,
		// Token: 0x0402C74A RID: 182090
		DiscountText,
		// Token: 0x0402C74B RID: 182091
		LabelSprite,
		// Token: 0x0402C74C RID: 182092
		LabelItem,
		// Token: 0x0402C74D RID: 182093
		LeftTimeItem,
		// Token: 0x0402C74E RID: 182094
		LeftTimeText,
		// Token: 0x0402C74F RID: 182095
		ReSellText,
		// Token: 0x0402C750 RID: 182096
		BuyButton,
		// Token: 0x0402C751 RID: 182097
		ReUpTimeItem,
		// Token: 0x0402C752 RID: 182098
		ReUpTimeText,
		// Token: 0x0402C753 RID: 182099
		LabelText,
		// Token: 0x0402C754 RID: 182100
		LeftTopItem,
		// Token: 0x0402C755 RID: 182101
		SoldOutItem,
		// Token: 0x0402C756 RID: 182102
		SoldOutText,
		// Token: 0x0402C757 RID: 182103
		LockItem,
		// Token: 0x0402C758 RID: 182104
		LockText,
		// Token: 0x0402C759 RID: 182105
		NewFlagItem
	}
}
