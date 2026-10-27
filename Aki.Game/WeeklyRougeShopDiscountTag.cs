using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02002D33 RID: 11571
public class WeeklyRougeShopDiscountTag : MediumItemGridComponent
{
	// Token: 0x06018547 RID: 99655 RVA: 0x00631473 File Offset: 0x0062F673
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemDiscountTag";
	}

	// Token: 0x06018548 RID: 99656 RVA: 0x0063147A File Offset: 0x0062F67A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06018549 RID: 99657 RVA: 0x006314A0 File Offset: 0x0062F6A0
	[NullableContext(1)]
	protected override void OnRefresh(object data)
	{
		RogueWeeklyGoods rogueWeeklyGoods = (RogueWeeklyGoods)data;
		double num = (1.0 - (double)rogueWeeklyGoods.CurPrice / (double)rogueWeeklyGoods.SourcePrice) * 100.0;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueInfoViewShopDiscount", new <>z__ReadOnlySingleElementList<object>(num));
	}

	// Token: 0x020092C3 RID: 37571
	private enum EWeeklyRogueShopDiscountTagDefine
	{
		// Token: 0x0402F706 RID: 194310
		TxtDiscount
	}
}
