using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200182E RID: 6190
public class GameplayShopBaseItem : UiPanelBase
{
	// Token: 0x0600F442 RID: 62530 RVA: 0x004751F4 File Offset: 0x004733F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnTipsButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F443 RID: 62531 RVA: 0x0047542C File Offset: 0x0047362C
	[NullableContext(1)]
	public void RefreshByData(IGameplayShopItemBaseProxy data)
	{
		this.BaseItemProxy = data;
		this.RefreshQualitySprite();
		this.RefreshBottomBgSprite();
		this.RefreshItemTexture();
		this.RefreshTipsButton();
		this.RefreshBuyLimitCountTextText();
		this.RefreshNameText();
		this.RefreshPriceItem();
		this.RefreshPriceTipsText();
		this.RefreshRedDot();
		this.RefreshBigItemIconTexture();
		this.RefreshNormalItemBg();
		this.RefreshRaycastTarget();
	}

	// Token: 0x0600F444 RID: 62532 RVA: 0x00475488 File Offset: 0x00473688
	public void RefreshQualitySprite()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		this.SetSpriteByPath(this.BaseItemProxy.QualitySpritePath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x0600F445 RID: 62533 RVA: 0x004754C1 File Offset: 0x004736C1
	public void RefreshBottomBgSprite()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetSprite(1).SetUIActive(this.BaseItemProxy.BottomBgVisible);
	}

	// Token: 0x0600F446 RID: 62534 RVA: 0x004754E4 File Offset: 0x004736E4
	public void RefreshItemTexture()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		UUITexture texture = base.GetTexture(2);
		texture.SetUIActive(this.BaseItemProxy.ItemTextureVisible);
		if (this.BaseItemProxy.ItemTextureVisible)
		{
			if (this.BaseItemProxy.ItemId > 0)
			{
				base.SetItemIcon(texture, this.BaseItemProxy.ItemId, null, null);
				return;
			}
			base.SetTextureByPath(this.BaseItemProxy.ItemTexturePath, texture, null, null);
		}
	}

	// Token: 0x0600F447 RID: 62535 RVA: 0x00475568 File Offset: 0x00473768
	public void RefreshTipsButton()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.BaseItemProxy.TipsButtonVisible);
	}

	// Token: 0x0600F448 RID: 62536 RVA: 0x004755A4 File Offset: 0x004737A4
	public void RefreshBuyLimitCountTextText()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		UUIText text = base.GetText(4);
		text.SetUIActive(this.BaseItemProxy.BuyLimitCountTextVisible);
		if (this.BaseItemProxy.BuyLimitCountTextVisible)
		{
			GameplayShopUtil.SetText(text, this.BaseItemProxy.BuyLimitCountTextData);
		}
	}

	// Token: 0x0600F449 RID: 62537 RVA: 0x004755F1 File Offset: 0x004737F1
	public void RefreshNameText()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		GameplayShopUtil.SetText(base.GetText(5), this.BaseItemProxy.ItemNameTextData);
	}

	// Token: 0x0600F44A RID: 62538 RVA: 0x00475614 File Offset: 0x00473814
	public void RefreshPriceItem()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetItem(6).SetUIActive(this.BaseItemProxy.PriceItemVisible);
		if (this.BaseItemProxy.PriceItemVisible)
		{
			UUITexture texture = base.GetTexture(7);
			texture.SetUIActive(this.BaseItemProxy.CurrencyIconVisible);
			if (this.BaseItemProxy.CurrencyIconVisible)
			{
				base.SetItemIcon(texture, this.BaseItemProxy.CurrencyId, null, null);
			}
			UUIText text = base.GetText(8);
			GameplayShopUtil.SetText(text, this.BaseItemProxy.NowPriceTextData);
			text.SetColor(FColor.FromHex(this.BaseItemProxy.NowPriceTextColor));
			UUIText text2 = base.GetText(9);
			text2.SetUIActive(this.BaseItemProxy.OriginalPriceVisible);
			if (this.BaseItemProxy.OriginalPriceVisible)
			{
				GameplayShopUtil.SetText(text2, this.BaseItemProxy.OriginalPriceTextData);
			}
		}
	}

	// Token: 0x0600F44B RID: 62539 RVA: 0x004756F8 File Offset: 0x004738F8
	public void RefreshPriceTipsText()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		UUIText text = base.GetText(10);
		text.SetUIActive(this.BaseItemProxy.PriceTipsTextVisible);
		if (this.BaseItemProxy.PriceTipsTextVisible)
		{
			GameplayShopUtil.SetText(text, this.BaseItemProxy.PriceTipsTextData);
		}
	}

	// Token: 0x0600F44C RID: 62540 RVA: 0x00475746 File Offset: 0x00473946
	public void RefreshRedDot()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetItem(11).SetUIActive(this.BaseItemProxy.RedDotVisible);
	}

	// Token: 0x0600F44D RID: 62541 RVA: 0x0047576C File Offset: 0x0047396C
	public void RefreshBigItemIconTexture()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		UUITexture texture = base.GetTexture(12);
		texture.SetUIActive(this.BaseItemProxy.BigItemIconVisible);
		if (this.BaseItemProxy.BigItemIconVisible)
		{
			base.SetTextureByPath(this.BaseItemProxy.BigItemIconTexturePath, texture, null, null);
		}
	}

	// Token: 0x0600F44E RID: 62542 RVA: 0x004757C5 File Offset: 0x004739C5
	public void RefreshNormalItemBg()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetItem(13).SetUIActive(this.BaseItemProxy.ItemBgItemVisible);
	}

	// Token: 0x0600F44F RID: 62543 RVA: 0x004757E8 File Offset: 0x004739E8
	public void RefreshRaycastTarget()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		this.RootItem.SetRaycastTarget(this.BaseItemProxy.RaycastTarget);
	}

	// Token: 0x0600F450 RID: 62544 RVA: 0x00475809 File Offset: 0x00473A09
	private void OnTipsButtonClick()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		this.BaseItemProxy.OnTipsButtonClick();
	}

	// Token: 0x04008921 RID: 35105
	[Nullable(2)]
	protected IGameplayShopItemBaseProxy BaseItemProxy;

	// Token: 0x02007A4F RID: 31311
	private enum EComponent
	{
		// Token: 0x04027A4D RID: 162381
		QualitySprite,
		// Token: 0x04027A4E RID: 162382
		BottomBgSprite,
		// Token: 0x04027A4F RID: 162383
		ItemTexture,
		// Token: 0x04027A50 RID: 162384
		TipsButton,
		// Token: 0x04027A51 RID: 162385
		BuyLimitCountText,
		// Token: 0x04027A52 RID: 162386
		NameText,
		// Token: 0x04027A53 RID: 162387
		PriceItem,
		// Token: 0x04027A54 RID: 162388
		CurrencyIcon,
		// Token: 0x04027A55 RID: 162389
		NowPriceText,
		// Token: 0x04027A56 RID: 162390
		OriginalPriceText,
		// Token: 0x04027A57 RID: 162391
		PriceTipsText,
		// Token: 0x04027A58 RID: 162392
		RedDot,
		// Token: 0x04027A59 RID: 162393
		BigItemIconTexture,
		// Token: 0x04027A5A RID: 162394
		NormalItemBg
	}
}
