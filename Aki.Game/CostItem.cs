using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CD2 RID: 3282
public class CostItem : UiPanelBase
{
	// Token: 0x060088DA RID: 35034 RVA: 0x00297EFC File Offset: 0x002960FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x060088DB RID: 35035 RVA: 0x00297F58 File Offset: 0x00296158
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

	// Token: 0x060088DC RID: 35036 RVA: 0x00297FC4 File Offset: 0x002961C4
	[NullableContext(1)]
	public void RefreshCost(IReadOnlyList<ICostData> costData)
	{
		base.SetUiActive(false);
		if (costData.Count > 0)
		{
			base.SetUiActive(true);
			ICostData costData2 = costData[0];
			this.Refresh(costData2);
		}
	}

	// Token: 0x02006F8D RID: 28557
	private enum EComponent
	{
		// Token: 0x0402471A RID: 149274
		TipsText,
		// Token: 0x0402471B RID: 149275
		CostText,
		// Token: 0x0402471C RID: 149276
		CostIcon
	}
}
