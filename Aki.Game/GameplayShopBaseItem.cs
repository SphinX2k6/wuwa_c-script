using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002349 RID: 9033
public class GameplayShopBaseItem : UiPanelBase
{
	// Token: 0x06011F92 RID: 73618 RVA: 0x0046812C File Offset: 0x0046632C
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

	// Token: 0x06011F93 RID: 73619 RVA: 0x00468364 File Offset: 0x00466564
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

	// Token: 0x06011F94 RID: 73620 RVA: 0x004683C0 File Offset: 0x004665C0
	public void RefreshQualitySprite()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		this.SetSpriteByPath(this.BaseItemProxy.QualitySpritePath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x06011F95 RID: 73621 RVA: 0x004683F9 File Offset: 0x004665F9
	public void RefreshBottomBgSprite()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetSprite(1).SetUIActive(this.BaseItemProxy.BottomBgVisible);
	}

	// Token: 0x06011F96 RID: 73622 RVA: 0x0046841C File Offset: 0x0046661C
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

	// Token: 0x06011F97 RID: 73623 RVA: 0x004684A0 File Offset: 0x004666A0
	public void RefreshTipsButton()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.BaseItemProxy.TipsButtonVisible);
	}

	// Token: 0x06011F98 RID: 73624 RVA: 0x004684DC File Offset: 0x004666DC
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

	// Token: 0x06011F99 RID: 73625 RVA: 0x00468529 File Offset: 0x00466729
	public void RefreshNameText()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		GameplayShopUtil.SetText(base.GetText(5), this.BaseItemProxy.ItemNameTextData);
	}

	// Token: 0x06011F9A RID: 73626 RVA: 0x0046854C File Offset: 0x0046674C
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

	// Token: 0x06011F9B RID: 73627 RVA: 0x00468630 File Offset: 0x00466830
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

	// Token: 0x06011F9C RID: 73628 RVA: 0x0046867E File Offset: 0x0046687E
	public void RefreshRedDot()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetItem(11).SetUIActive(this.BaseItemProxy.RedDotVisible);
	}

	// Token: 0x06011F9D RID: 73629 RVA: 0x004686A4 File Offset: 0x004668A4
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

	// Token: 0x06011F9E RID: 73630 RVA: 0x004686FD File Offset: 0x004668FD
	public void RefreshNormalItemBg()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		base.GetItem(13).SetUIActive(this.BaseItemProxy.ItemBgItemVisible);
	}

	// Token: 0x06011F9F RID: 73631 RVA: 0x00468720 File Offset: 0x00466920
	public void RefreshRaycastTarget()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		this.RootItem.SetRaycastTarget(this.BaseItemProxy.RaycastTarget);
	}

	// Token: 0x06011FA0 RID: 73632 RVA: 0x00468741 File Offset: 0x00466941
	private void OnTipsButtonClick()
	{
		if (this.BaseItemProxy == null)
		{
			return;
		}
		this.BaseItemProxy.OnTipsButtonClick();
	}

	// Token: 0x040087DE RID: 34782
	[Nullable(2)]
	protected IGameplayShopItemBaseProxy BaseItemProxy;

	// Token: 0x020088C6 RID: 35014
	private enum EComponent
	{
		// Token: 0x0402C739 RID: 182073
		QualitySprite,
		// Token: 0x0402C73A RID: 182074
		BottomBgSprite,
		// Token: 0x0402C73B RID: 182075
		ItemTexture,
		// Token: 0x0402C73C RID: 182076
		TipsButton,
		// Token: 0x0402C73D RID: 182077
		BuyLimitCountText,
		// Token: 0x0402C73E RID: 182078
		NameText,
		// Token: 0x0402C73F RID: 182079
		PriceItem,
		// Token: 0x0402C740 RID: 182080
		CurrencyIcon,
		// Token: 0x0402C741 RID: 182081
		NowPriceText,
		// Token: 0x0402C742 RID: 182082
		OriginalPriceText,
		// Token: 0x0402C743 RID: 182083
		PriceTipsText,
		// Token: 0x0402C744 RID: 182084
		RedDot,
		// Token: 0x0402C745 RID: 182085
		BigItemIconTexture,
		// Token: 0x0402C746 RID: 182086
		NormalItemBg
	}
}
