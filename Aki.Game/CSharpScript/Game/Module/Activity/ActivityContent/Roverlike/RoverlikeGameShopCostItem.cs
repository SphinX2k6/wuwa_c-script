using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050CE RID: 20686
	public class RoverlikeGameShopCostItem : UiPanelBase
	{
		// Token: 0x06033C54 RID: 212052 RVA: 0x00E7DE58 File Offset: 0x00E7C058
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033C55 RID: 212053 RVA: 0x00E7DEE4 File Offset: 0x00E7C0E4
		[NullableContext(1)]
		public void Refresh(IRoverlikeGameShopGridData data, int insideCurrencyItemId, int currencyCount)
		{
			bool flag = currencyCount < data.FinalPrice;
			bool flag2 = data.OriginalPrice != data.FinalPrice;
			UUIText text = base.GetText(1);
			if (flag2)
			{
				string textStringId = flag ? "RoverRogue_ShopPriceWithDiscount_NE" : "RoverRogue_ShopPriceWithDiscount";
				LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlyArray<object>(new object[]
				{
					data.FinalPrice,
					data.OriginalPrice
				}));
			}
			else
			{
				string textStringId2 = flag ? "RoverRogue_ShopPrice_NE" : "RoverRogue_ShopPrice";
				LguiUtil.Instance.SetLocalTextNew(text, textStringId2, new <>z__ReadOnlySingleElementList<object>(data.FinalPrice));
			}
			base.GetText(2).SetUIActive(false);
			UUITexture texture = base.GetTexture(0);
			base.SetItemIcon(texture, insideCurrencyItemId, null, null);
		}

		// Token: 0x0200AD9A RID: 44442
		private class EComponents
		{
			// Token: 0x04035A43 RID: 219715
			public const int TextureCostIcon = 0;

			// Token: 0x04035A44 RID: 219716
			public const int TxtCost = 1;

			// Token: 0x04035A45 RID: 219717
			public const int TxtPlace = 2;
		}
	}
}
