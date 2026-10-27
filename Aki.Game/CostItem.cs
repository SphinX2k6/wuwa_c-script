using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001819 RID: 6169
public class CostItem : UiPanelBase
{
	// Token: 0x0600B4EF RID: 46319 RVA: 0x0028D7DC File Offset: 0x0028B9DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600B4F0 RID: 46320 RVA: 0x0028D838 File Offset: 0x0028BA38
	[NullableContext(1)]
	public void Refresh(ICostData costData)
	{
		UUIText text = base.GetText(1);
		text.SetText(costData.Cost.ToString(), true);
		base.SetItemIcon(base.GetTexture(2), costData.ItemId, null, null);
		UUIItem uuiitem = text;
		bool bUseChangeColor = costData.Cost > costData.Count;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0600B4F1 RID: 46321 RVA: 0x0028D8A4 File Offset: 0x0028BAA4
	[NullableContext(1)]
	public void RefreshCost(List<ICostData> costData)
	{
		base.SetUiActive(false);
		if (costData.Count > 0)
		{
			base.SetUiActive(true);
			ICostData costData2 = costData[0];
			this.Refresh(costData2);
		}
	}

	// Token: 0x02007E07 RID: 32263
	private enum EComponent
	{
		// Token: 0x040293EF RID: 168943
		TipsText,
		// Token: 0x040293F0 RID: 168944
		CostText,
		// Token: 0x040293F1 RID: 168945
		CostIcon
	}
}
