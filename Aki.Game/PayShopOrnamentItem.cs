using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200186F RID: 6255
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopOrnamentItem : GridProxyAbstract<PayShopGoods>, IGiftDisplayItem
{
	// Token: 0x0600F7B4 RID: 63412 RVA: 0x0048753C File Offset: 0x0048573C
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

	// Token: 0x0600F7B5 RID: 63413 RVA: 0x004876B0 File Offset: 0x004858B0
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

	// Token: 0x02007AB7 RID: 31415
	private class EComponent
	{
		// Token: 0x04027C90 RID: 162960
		public const int OrnamentTexture = 0;

		// Token: 0x04027C91 RID: 162961
		public const int BuyItemIcon = 1;

		// Token: 0x04027C92 RID: 162962
		public const int NowPrice = 2;

		// Token: 0x04027C93 RID: 162963
		public const int BeforePrice = 3;

		// Token: 0x04027C94 RID: 162964
		public const int SuitWeaponTexture = 4;

		// Token: 0x04027C95 RID: 162965
		public const int TextureBg = 5;

		// Token: 0x04027C96 RID: 162966
		public const int EffectAItem = 6;

		// Token: 0x04027C97 RID: 162967
		public const int EffectBItem = 7;

		// Token: 0x04027C98 RID: 162968
		public const int SpriteMask = 8;

		// Token: 0x04027C99 RID: 162969
		public const int ItemWeaponPanel = 9;
	}
}
