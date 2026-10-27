using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200238F RID: 9103
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopSkinItem : GridProxyAbstract<PayShopGoods>, IGiftDisplayItem
{
	// Token: 0x0601232F RID: 74543 RVA: 0x0047AEA4 File Offset: 0x004790A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06012330 RID: 74544 RVA: 0x0047AFD4 File Offset: 0x004791D4
	public override void Refresh(PayShopGoods data, bool isSelected, int gridIndex)
	{
		this.ShopSkinData = ShopSkinData.Create(data);
		this.RefreshRoleIcon(this.ShopSkinData);
		this.RefreshBuyItemIcon(this.ShopSkinData);
		this.RefreshNowPriceText(this.ShopSkinData);
		this.RefreshSourcePriceText(this.ShopSkinData);
		this.RefreshSuitWeaponIcon(this.ShopSkinData);
		this.RefreshTextureBg(this.ShopSkinData);
		this.RefreshEffectItem(this.ShopSkinData);
	}

	// Token: 0x06012331 RID: 74545 RVA: 0x0047B044 File Offset: 0x00479244
	[NullableContext(1)]
	private void RefreshEffectItem(ShopSkinData data)
	{
		bool uiactive = data.GetRoleSkinData().GetSuitWeaponSkinId() > 0;
		base.GetItem(6).SetUIActive(uiactive);
		base.GetItem(7).SetUIActive(uiactive);
	}

	// Token: 0x06012332 RID: 74546 RVA: 0x0047B07C File Offset: 0x0047927C
	private void RefreshRoleIcon(ShopSkinData data)
	{
		base.SetTextureByPath(data.GetPayShopPreviewBuyRoleTexturePath(), base.GetTexture(0), null, null);
	}

	// Token: 0x06012333 RID: 74547 RVA: 0x0047B0A8 File Offset: 0x004792A8
	private void RefreshSuitWeaponIcon(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(4).SetUIActive(false);
			return;
		}
		string payShopPreviewBuyRoleSuitWeaponTexturePath = data.GetPayShopPreviewBuyRoleSuitWeaponTexturePath();
		if (payShopPreviewBuyRoleSuitWeaponTexturePath == "" || payShopPreviewBuyRoleSuitWeaponTexturePath == null)
		{
			base.GetTexture(4).SetUIActive(false);
			return;
		}
		base.GetTexture(4).SetUIActive(true);
		base.SetTextureByPath(payShopPreviewBuyRoleSuitWeaponTexturePath, base.GetTexture(4), null, null);
	}

	// Token: 0x06012334 RID: 74548 RVA: 0x0047B110 File Offset: 0x00479310
	private void RefreshBuyItemIcon(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(1).SetUIActive(false);
			return;
		}
		bool ifDirect = data.GetIfDirect();
		base.GetTexture(1).SetUIActive(!ifDirect);
		if (!ifDirect)
		{
			IPriceData priceData = data.GetPriceData();
			base.SetItemIcon(base.GetTexture(1), priceData.CurrencyId, null, null);
		}
	}

	// Token: 0x06012335 RID: 74549 RVA: 0x0047B16C File Offset: 0x0047936C
	private void RefreshSourcePriceText(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetText(3).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			base.GetText(3).SetText("", true);
			return;
		}
		int? originalPrice = data.GetPriceData().OriginalPrice;
		if (originalPrice == null)
		{
			base.GetText(3).SetUIActive(false);
			return;
		}
		base.GetText(3).SetUIActive(true);
		base.GetText(3).SetText("<s>" + originalPrice.ToString() + "</s>", true);
	}

	// Token: 0x06012336 RID: 74550 RVA: 0x0047B204 File Offset: 0x00479404
	private void RefreshNowPriceText(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetText(2).SetText("", true);
			return;
		}
		if (data.GetIfDirect())
		{
			string directPriceText = data.GetDirectPriceText();
			base.GetText(2).SetText(directPriceText, true);
			return;
		}
		int nowPrice = data.GetPriceData().NowPrice;
		base.GetText(2).SetText(nowPrice.ToString(), true);
	}

	// Token: 0x06012337 RID: 74551 RVA: 0x0047B268 File Offset: 0x00479468
	private void RefreshTextureBg(ShopSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(5).SetUIActive(false);
			return;
		}
		string resourceId = (data.GetRoleSkinData().GetSuitWeaponSkinId() > 0) ? "T_ShopSkinBg1" : "T_ShopSkinBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(5), null, null);
	}

	// Token: 0x04008993 RID: 35219
	private ShopSkinData ShopSkinData;

	// Token: 0x02008931 RID: 35121
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402C98B RID: 182667
		public const int RoleTexture = 0;

		// Token: 0x0402C98C RID: 182668
		public const int BuyItemIcon = 1;

		// Token: 0x0402C98D RID: 182669
		public const int NowPrice = 2;

		// Token: 0x0402C98E RID: 182670
		public const int BeforePrice = 3;

		// Token: 0x0402C98F RID: 182671
		public const int SuitWeaponTexture = 4;

		// Token: 0x0402C990 RID: 182672
		public const int TextureBg = 5;

		// Token: 0x0402C991 RID: 182673
		public const int EffectAItem = 6;

		// Token: 0x0402C992 RID: 182674
		public const int EffectBItem = 7;
	}
}
