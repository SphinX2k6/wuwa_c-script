using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200238A RID: 9098
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopOrnamentItem : GridProxyAbstract<PayShopGoods>, IGiftDisplayItem
{
	// Token: 0x06012302 RID: 74498 RVA: 0x0047A1EC File Offset: 0x004783EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06012303 RID: 74499 RVA: 0x0047A360 File Offset: 0x00478560
	[NullableContext(2)]
	public override void Refresh(PayShopGoods data, bool isSelected, int gridIndex)
	{
		ShopRoleOrnamentData shopRoleOrnamentData = ShopRoleOrnamentData.Create(data);
		RoleOrnamentData roleOrnamentData = RoleOrnamentModel.Instance.GetRoleOrnamentData(shopRoleOrnamentData.GetItemId());
		base.SetTextureByPath(roleOrnamentData.GetPreviewTextureInPop(), base.GetTexture(0), null, null);
		bool ifDirect = shopRoleOrnamentData.GetIfDirect();
		base.GetTexture(1).SetUIActive(!ifDirect);
		if (ifDirect)
		{
			string directPriceText = shopRoleOrnamentData.GetDirectPriceText();
			base.GetText(2).SetText(directPriceText, true);
			base.GetText(3).SetText("", true);
		}
		else
		{
			IPriceData priceData = shopRoleOrnamentData.GetPriceData();
			base.SetItemIcon(base.GetTexture(1), priceData.CurrencyId, null, null);
			int nowPrice = priceData.NowPrice;
			base.GetText(2).SetText(nowPrice.ToString(), true);
			int? originalPrice = priceData.OriginalPrice;
			if (originalPrice == null)
			{
				base.GetText(3).SetUIActive(false);
			}
			else
			{
				base.GetText(3).SetUIActive(true);
				base.GetText(3).SetText("<s>" + originalPrice.ToString() + "</s>", true);
			}
		}
		UUISprite sprite = base.GetSprite(8);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		base.GetItem(6).SetUIActive(false);
		base.GetItem(7).SetUIActive(false);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_ShopSkinBg");
		base.SetTextureByPath(resourcePath, base.GetTexture(5), null, null);
	}

	// Token: 0x0200892C RID: 35116
	private class EComponent
	{
		// Token: 0x0402C972 RID: 182642
		public const int OrnamentTexture = 0;

		// Token: 0x0402C973 RID: 182643
		public const int BuyItemIcon = 1;

		// Token: 0x0402C974 RID: 182644
		public const int NowPrice = 2;

		// Token: 0x0402C975 RID: 182645
		public const int BeforePrice = 3;

		// Token: 0x0402C976 RID: 182646
		public const int SuitWeaponTexture = 4;

		// Token: 0x0402C977 RID: 182647
		public const int TextureBg = 5;

		// Token: 0x0402C978 RID: 182648
		public const int EffectAItem = 6;

		// Token: 0x0402C979 RID: 182649
		public const int EffectBItem = 7;

		// Token: 0x0402C97A RID: 182650
		public const int SpriteMask = 8;

		// Token: 0x0402C97B RID: 182651
		public const int ItemWeaponPanel = 9;
	}
}
