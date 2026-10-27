using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002381 RID: 9089
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopFlySkinItem : GridProxyAbstract<PayShopGoods>, IGiftDisplayItem
{
	// Token: 0x0601229B RID: 74395 RVA: 0x00477698 File Offset: 0x00475898
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

	// Token: 0x0601229C RID: 74396 RVA: 0x0047780C File Offset: 0x00475A0C
	[NullableContext(2)]
	public override void Refresh(PayShopGoods data, bool isSelected, int gridIndex)
	{
		ShopFlySkinData shopFlySkinData = ShopFlySkinData.Create(data);
		base.SetTextureByPath(shopFlySkinData.GetPreviewTextureInPop(), base.GetTexture(0), null, null);
		bool ifDirect = shopFlySkinData.GetIfDirect();
		base.GetTexture(1).SetUIActive(!ifDirect);
		if (ifDirect)
		{
			string directPriceText = shopFlySkinData.GetDirectPriceText();
			base.GetText(2).SetText(directPriceText, true);
			base.GetText(3).SetText("", true);
		}
		else
		{
			IPriceData priceData = shopFlySkinData.GetPriceData();
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
		bool flag = shopFlySkinData.GetFlySkinData().GetSkinGrade() == 1;
		base.GetItem(6).SetUIActive(flag);
		base.GetItem(7).SetUIActive(flag);
		string resourceId = flag ? "T_ShopSkinBg1" : "T_ShopSkinBg";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(5), null, null);
	}

	// Token: 0x02008923 RID: 35107
	private class EComponent
	{
		// Token: 0x0402C92F RID: 182575
		public const int FlySkinTexture = 0;

		// Token: 0x0402C930 RID: 182576
		public const int BuyItemIcon = 1;

		// Token: 0x0402C931 RID: 182577
		public const int NowPrice = 2;

		// Token: 0x0402C932 RID: 182578
		public const int BeforePrice = 3;

		// Token: 0x0402C933 RID: 182579
		public const int SuitWeaponTexture = 4;

		// Token: 0x0402C934 RID: 182580
		public const int TextureBg = 5;

		// Token: 0x0402C935 RID: 182581
		public const int EffectAItem = 6;

		// Token: 0x0402C936 RID: 182582
		public const int EffectBItem = 7;

		// Token: 0x0402C937 RID: 182583
		public const int SpriteMask = 8;

		// Token: 0x0402C938 RID: 182584
		public const int ItemWeaponPanel = 9;
	}
}
