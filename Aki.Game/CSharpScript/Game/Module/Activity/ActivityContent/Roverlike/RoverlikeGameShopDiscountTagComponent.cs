using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006156 RID: 24918
	public class RoverlikeGameShopDiscountTagComponent : MediumItemGridComponent
	{
		// Token: 0x0603EFC1 RID: 257985 RVA: 0x00F3719F File Offset: 0x00F3539F
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscountTag";
		}

		// Token: 0x0603EFC2 RID: 257986 RVA: 0x00F371A8 File Offset: 0x00F353A8
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

		// Token: 0x0603EFC3 RID: 257987 RVA: 0x00F371F0 File Offset: 0x00F353F0
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

		// Token: 0x0200C3B4 RID: 50100
		private class EComponents
		{
			// Token: 0x0403B0E5 RID: 241893
			public const int TxtDiscount = 0;
		}
	}
}
