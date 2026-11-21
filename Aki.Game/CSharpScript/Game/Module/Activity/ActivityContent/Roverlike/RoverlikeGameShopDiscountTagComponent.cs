using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D4 RID: 20692
	public class RoverlikeGameShopDiscountTagComponent : MediumItemGridComponent
	{
		// Token: 0x06033C81 RID: 212097 RVA: 0x00E7E073 File Offset: 0x00E7C273
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscountTag";
		}

		// Token: 0x06033C82 RID: 212098 RVA: 0x00E7E07C File Offset: 0x00E7C27C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033C83 RID: 212099 RVA: 0x00E7E0C4 File Offset: 0x00E7C2C4
		[NullableContext(2)]
		protected override void OnRefresh(object data)
		{
			IRoverlikeGameShopGridData roverlikeGameShopGridData = data as IRoverlikeGameShopGridData;
			if (roverlikeGameShopGridData == null)
			{
				return;
			}
			bool flag = roverlikeGameShopGridData.OriginalPrice > roverlikeGameShopGridData.FinalPrice;
			if (roverlikeGameShopGridData.IsBought || !flag)
			{
				this.SetActive(false);
				return;
			}
			int originalPrice = roverlikeGameShopGridData.OriginalPrice;
			int num = (int)Math.Floor((double)roverlikeGameShopGridData.FinalPrice / (double)originalPrice * 100.0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueInfoViewShopDiscount", new <>z__ReadOnlySingleElementList<object>((100 - num).ToString()));
			this.SetActive(true);
		}

		// Token: 0x0200AD9B RID: 44443
		private class EComponents
		{
			// Token: 0x04035A46 RID: 219718
			public const int TxtDiscount = 0;
		}
	}
}
