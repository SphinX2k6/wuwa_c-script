using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x0200228D RID: 8845
public class WeeklyRougeShopDiscountTag : MediumItemGridComponent
{
	// Token: 0x06015DE9 RID: 89577 RVA: 0x00657487 File Offset: 0x00655687
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemDiscountTag";
	}

	// Token: 0x06015DEA RID: 89578 RVA: 0x0065748E File Offset: 0x0065568E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06015DEB RID: 89579 RVA: 0x006574B4 File Offset: 0x006556B4
	[NullableContext(1)]
	protected override void OnRefresh(object data)
	{
		RogueWeeklyGoods rogueWeeklyGoods = (RogueWeeklyGoods)data;
		double num = (1.0 - (double)rogueWeeklyGoods.CurPrice / (double)rogueWeeklyGoods.SourcePrice) * 100.0;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RogueInfoViewShopDiscount", new <>z__ReadOnlySingleElementList<object>(num));
	}

	// Token: 0x020084EA RID: 34026
	private enum EWeeklyRogueShopDiscountTagDefine
	{
		// Token: 0x0402AD8E RID: 175502
		TxtDiscount
	}
}
