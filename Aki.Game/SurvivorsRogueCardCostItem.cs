using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002AC7 RID: 10951
public class SurvivorsRogueCardCostItem : SurvivorsRogueCardComponent
{
	// Token: 0x06016CAD RID: 93357 RVA: 0x005C9AD5 File Offset: 0x005C7CD5
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x06016CAE RID: 93358 RVA: 0x005C9B0E File Offset: 0x005C7D0E
	[NullableContext(2)]
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardCost";
	}

	// Token: 0x06016CAF RID: 93359 RVA: 0x005C9B15 File Offset: 0x005C7D15
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Bottom;
	}

	// Token: 0x06016CB0 RID: 93360 RVA: 0x005C9B18 File Offset: 0x005C7D18
	protected override void OnRefresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		int? num = (params_.Length != 0 && params_[0] != null) ? ((int?)params_[0]) : null;
		bool flag = params_.Length > 1 && params_[1] != null && (bool)params_[1];
		if (num == null)
		{
			this.SetActive(false);
			return;
		}
		int currencyCount = SurvivorsRogueModel.Instance.BattleData.GetCurrencyCount();
		this.SetCost(num.Value, flag && currencyCount < num.Value);
		this.SetActive(true);
	}

	// Token: 0x06016CB1 RID: 93361 RVA: 0x005C9BA0 File Offset: 0x005C7DA0
	public void SetCostItem(int costItemId)
	{
		base.SetItemIcon(base.GetTexture(0), costItemId, null, null);
	}

	// Token: 0x06016CB2 RID: 93362 RVA: 0x005C9BC8 File Offset: 0x005C7DC8
	public void SetCost(int cost, bool useChangeColor)
	{
		UUIText text = base.GetText(1);
		text.SetText(cost.ToString(), true);
		UUIItem uuiitem = text;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(useChangeColor, fcolor);
	}
}
