using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002043 RID: 8259
public class SurvivorsRogueCardCostItem : SurvivorsRogueCardComponent
{
	// Token: 0x060146DE RID: 83678 RVA: 0x005F6629 File Offset: 0x005F4829
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x060146DF RID: 83679 RVA: 0x005F6662 File Offset: 0x005F4862
	[NullableContext(2)]
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardCost";
	}

	// Token: 0x060146E0 RID: 83680 RVA: 0x005F6669 File Offset: 0x005F4869
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Bottom;
	}

	// Token: 0x060146E1 RID: 83681 RVA: 0x005F666C File Offset: 0x005F486C
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

	// Token: 0x060146E2 RID: 83682 RVA: 0x005F66F4 File Offset: 0x005F48F4
	public void SetCostItem(int costItemId)
	{
		base.SetItemIcon(base.GetTexture(0), costItemId, null, null);
	}

	// Token: 0x060146E3 RID: 83683 RVA: 0x005F671C File Offset: 0x005F491C
	public void SetCost(int cost, bool useChangeColor)
	{
		UUIText text = base.GetText(1);
		text.SetText(cost.ToString(), true);
		UUIItem uuiitem = text;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(useChangeColor, fcolor);
	}
}
