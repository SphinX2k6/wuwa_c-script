using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DFE RID: 19966
	public class RogueInfoViewShopDiscount : MediumItemGridComponent
	{
		// Token: 0x0603384E RID: 211022 RVA: 0x00C09DBA File Offset: 0x00C07FBA
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscount";
		}

		// Token: 0x0603384F RID: 211023 RVA: 0x00C09DC4 File Offset: 0x00C07FC4
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

		// Token: 0x06033850 RID: 211024 RVA: 0x00C09E30 File Offset: 0x00C08030
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

		// Token: 0x0200AF8B RID: 44939
		private class ERogueInfoViewShopDiscountDefine
		{
			// Token: 0x040354C7 RID: 218311
			public const int TexIcon = 0;

			// Token: 0x040354C8 RID: 218312
			public const int TxtPrice = 1;
		}
	}
}
