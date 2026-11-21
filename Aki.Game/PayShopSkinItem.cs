using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001874 RID: 6260
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopSkinItem : GridProxyAbstract<PayShopGoods>, IGiftDisplayItem
{
	// Token: 0x0600F7E1 RID: 63457 RVA: 0x004881F4 File Offset: 0x004863F4
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

	// Token: 0x0600F7E2 RID: 63458 RVA: 0x00488324 File Offset: 0x00486524
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

	// Token: 0x0600F7E3 RID: 63459 RVA: 0x00488394 File Offset: 0x00486594
	[NullableContext(1)]
	private void RefreshEffectItem(ShopSkinData data)
	{
		bool uiactive = data.GetRoleSkinData().GetSuitWeaponSkinId() > 0;
		base.GetItem(6).SetUIActive(uiactive);
		base.GetItem(7).SetUIActive(uiactive);
	}

	// Token: 0x0600F7E4 RID: 63460 RVA: 0x004883CC File Offset: 0x004865CC
	private void RefreshRoleIcon(ShopSkinData data)
	{
		base.SetTextureByPath(data.GetPayShopPreviewBuyRoleTexturePath(), base.GetTexture(0), null, null);
	}

	// Token: 0x0600F7E5 RID: 63461 RVA: 0x004883F8 File Offset: 0x004865F8
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

	// Token: 0x0600F7E6 RID: 63462 RVA: 0x00488460 File Offset: 0x00486660
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

	// Token: 0x0600F7E7 RID: 63463 RVA: 0x004884BC File Offset: 0x004866BC
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

	// Token: 0x0600F7E8 RID: 63464 RVA: 0x00488554 File Offset: 0x00486754
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

	// Token: 0x0600F7E9 RID: 63465 RVA: 0x004885B8 File Offset: 0x004867B8
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

	// Token: 0x04008ADA RID: 35546
	private ShopSkinData ShopSkinData;

	// Token: 0x02007ABC RID: 31420
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027CA9 RID: 162985
		public const int RoleTexture = 0;

		// Token: 0x04027CAA RID: 162986
		public const int BuyItemIcon = 1;

		// Token: 0x04027CAB RID: 162987
		public const int NowPrice = 2;

		// Token: 0x04027CAC RID: 162988
		public const int BeforePrice = 3;

		// Token: 0x04027CAD RID: 162989
		public const int SuitWeaponTexture = 4;

		// Token: 0x04027CAE RID: 162990
		public const int TextureBg = 5;

		// Token: 0x04027CAF RID: 162991
		public const int EffectAItem = 6;

		// Token: 0x04027CB0 RID: 162992
		public const int EffectBItem = 7;
	}
}
