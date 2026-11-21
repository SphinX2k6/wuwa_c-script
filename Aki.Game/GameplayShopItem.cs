using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001830 RID: 6192
public class GameplayShopItem : UiPanelBase
{
	// Token: 0x0600F45E RID: 62558 RVA: 0x0047587C File Offset: 0x00473A7C
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

	// Token: 0x0600F45F RID: 62559 RVA: 0x00475B3C File Offset: 0x00473D3C
	protected override void OnStart()
	{
		this.BaseItem = new GameplayShopBaseItem();
		this.BaseItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
	}

	// Token: 0x0600F460 RID: 62560 RVA: 0x00475B61 File Offset: 0x00473D61
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

	// Token: 0x0600F461 RID: 62561 RVA: 0x00475BA0 File Offset: 0x00473DA0
	public void RefreshBaseItem()
	{
		if (this.ItemProxy == null || this.BaseItem == null)
		{
			return;
		}
		this.BaseItem.RefreshByData(this.ItemProxy);
	}

	// Token: 0x0600F462 RID: 62562 RVA: 0x00475BC4 File Offset: 0x00473DC4
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

	// Token: 0x0600F463 RID: 62563 RVA: 0x00475C18 File Offset: 0x00473E18
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

	// Token: 0x0600F464 RID: 62564 RVA: 0x00475C6C File Offset: 0x00473E6C
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

	// Token: 0x0600F465 RID: 62565 RVA: 0x00475CC0 File Offset: 0x00473EC0
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

	// Token: 0x0600F466 RID: 62566 RVA: 0x00475D10 File Offset: 0x00473F10
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

	// Token: 0x0600F467 RID: 62567 RVA: 0x00475D64 File Offset: 0x00473F64
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

	// Token: 0x0600F468 RID: 62568 RVA: 0x00475DB7 File Offset: 0x00473FB7
	public void RefreshNewFlagItem()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		base.GetItem(17).SetUIActive(this.ItemProxy.TagNewItemVisible);
	}

	// Token: 0x0600F469 RID: 62569 RVA: 0x00475DDA File Offset: 0x00473FDA
	public void RefreshRaycastTarget()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		this.RootItem.SetRaycastTarget(this.ItemProxy.RaycastTarget);
	}

	// Token: 0x0600F46A RID: 62570 RVA: 0x00475DFB File Offset: 0x00473FFB
	private void OnBuyButtonClick()
	{
		if (this.ItemProxy == null)
		{
			return;
		}
		this.ItemProxy.OnBuyButtonClick();
	}

	// Token: 0x04008925 RID: 35109
	[Nullable(2)]
	protected IGameplayShopItemProxy ItemProxy;

	// Token: 0x04008926 RID: 35110
	[Nullable(2)]
	protected GameplayShopBaseItem BaseItem;

	// Token: 0x02007A50 RID: 31312
	private enum EComponent
	{
		// Token: 0x04027A5C RID: 162396
		BaseItem,
		// Token: 0x04027A5D RID: 162397
		DiscountItem,
		// Token: 0x04027A5E RID: 162398
		DiscountText,
		// Token: 0x04027A5F RID: 162399
		LabelSprite,
		// Token: 0x04027A60 RID: 162400
		LabelItem,
		// Token: 0x04027A61 RID: 162401
		LeftTimeItem,
		// Token: 0x04027A62 RID: 162402
		LeftTimeText,
		// Token: 0x04027A63 RID: 162403
		ReSellText,
		// Token: 0x04027A64 RID: 162404
		BuyButton,
		// Token: 0x04027A65 RID: 162405
		ReUpTimeItem,
		// Token: 0x04027A66 RID: 162406
		ReUpTimeText,
		// Token: 0x04027A67 RID: 162407
		LabelText,
		// Token: 0x04027A68 RID: 162408
		LeftTopItem,
		// Token: 0x04027A69 RID: 162409
		SoldOutItem,
		// Token: 0x04027A6A RID: 162410
		SoldOutText,
		// Token: 0x04027A6B RID: 162411
		LockItem,
		// Token: 0x04027A6C RID: 162412
		LockText,
		// Token: 0x04027A6D RID: 162413
		NewFlagItem
	}
}
