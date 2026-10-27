using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DFD RID: 19965
	public class RogueInfoViewShopDiscountTag : MediumItemGridComponent
	{
		// Token: 0x0603384A RID: 211018 RVA: 0x00C09D24 File Offset: 0x00C07F24
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemDiscountTag";
		}

		// Token: 0x0603384B RID: 211019 RVA: 0x00C09D2C File Offset: 0x00C07F2C
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

		// Token: 0x0603384C RID: 211020 RVA: 0x00C09D74 File Offset: 0x00C07F74
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

		// Token: 0x0200AF8A RID: 44938
		private class ERogueInfoViewShopDiscountTagDefine
		{
			// Token: 0x040354C6 RID: 218310
			public const int TxtDiscount = 0;
		}
	}
}
