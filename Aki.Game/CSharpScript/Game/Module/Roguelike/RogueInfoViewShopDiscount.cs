using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC7 RID: 15815
	public class RogueInfoViewShopDiscount : MediumItemGridComponent
	{
		// Token: 0x060286B9 RID: 165561 RVA: 0x00B532CA File Offset: 0x00B514CA
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscount";
		}

		// Token: 0x060286BA RID: 165562 RVA: 0x00B532D4 File Offset: 0x00B514D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060286BB RID: 165563 RVA: 0x00B53340 File Offset: 0x00B51540
		[NullableContext(2)]
		protected override void OnRefresh(object param = null)
		{
			RogueGainEntry rogueGainEntry = param as RogueGainEntry;
			if (rogueGainEntry == null)
			{
				return;
			}
			if (rogueGainEntry.IsDiscounted())
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueInfoViewShopPriceWithDiscount", new <>z__ReadOnlyArray<object>(new object[]
				{
					rogueGainEntry.CurrentPrice,
					rogueGainEntry.OriginalPrice
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueInfoViewShopPrice", new <>z__ReadOnlySingleElementList<object>(rogueGainEntry.OriginalPrice));
			}
			if (rogueGainEntry.ShopItemCoinId != 0)
			{
				RogueCurrency? rogueCurrencyConfig = RoguelikeConfig.Instance.GetRogueCurrencyConfig(rogueGainEntry.ShopItemCoinId);
				base.SetTextureByPath(((rogueCurrencyConfig != null) ? rogueCurrencyConfig.GetValueOrDefault().IconSmall : null) ?? "", base.GetTexture(0), null, null);
			}
		}

		// Token: 0x020099C0 RID: 39360
		private class ERogueInfoViewShopDiscountDefine
		{
			// Token: 0x0402FEFA RID: 196346
			public const int TexIcon = 0;

			// Token: 0x0402FEFB RID: 196347
			public const int TxtPrice = 1;
		}
	}
}
