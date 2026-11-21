using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001866 RID: 6246
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopFlySkinItem : GridProxyAbstract<PayShopGoods>, IGiftDisplayItem
{
	// Token: 0x0600F74B RID: 63307 RVA: 0x00484818 File Offset: 0x00482A18
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

	// Token: 0x0600F74C RID: 63308 RVA: 0x0048498C File Offset: 0x00482B8C
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

	// Token: 0x02007AAD RID: 31405
	private class EComponent
	{
		// Token: 0x04027C47 RID: 162887
		public const int FlySkinTexture = 0;

		// Token: 0x04027C48 RID: 162888
		public const int BuyItemIcon = 1;

		// Token: 0x04027C49 RID: 162889
		public const int NowPrice = 2;

		// Token: 0x04027C4A RID: 162890
		public const int BeforePrice = 3;

		// Token: 0x04027C4B RID: 162891
		public const int SuitWeaponTexture = 4;

		// Token: 0x04027C4C RID: 162892
		public const int TextureBg = 5;

		// Token: 0x04027C4D RID: 162893
		public const int EffectAItem = 6;

		// Token: 0x04027C4E RID: 162894
		public const int EffectBItem = 7;

		// Token: 0x04027C4F RID: 162895
		public const int SpriteMask = 8;

		// Token: 0x04027C50 RID: 162896
		public const int ItemWeaponPanel = 9;
	}
}
