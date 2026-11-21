using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC6 RID: 15814
	public class RogueInfoViewShopDiscountTag : MediumItemGridComponent
	{
		// Token: 0x060286B5 RID: 165557 RVA: 0x00B53234 File Offset: 0x00B51434
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscountTag";
		}

		// Token: 0x060286B6 RID: 165558 RVA: 0x00B5323C File Offset: 0x00B5143C
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

		// Token: 0x060286B7 RID: 165559 RVA: 0x00B53284 File Offset: 0x00B51484
		[NullableContext(2)]
		protected override void OnRefresh(object param = null)
		{
			RogueGainEntry rogueGainEntry = param as RogueGainEntry;
			if (rogueGainEntry == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueInfoViewShopDiscount", new <>z__ReadOnlySingleElementList<object>(rogueGainEntry.Discounted.ToString()));
		}

		// Token: 0x020099BF RID: 39359
		private class ERogueInfoViewShopDiscountTagDefine
		{
			// Token: 0x0402FEF9 RID: 196345
			public const int TxtDiscount = 0;
		}
	}
}
