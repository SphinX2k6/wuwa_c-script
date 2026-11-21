using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C23 RID: 3107
public class VisionRefineCostItem : UiPanelBase
{
	// Token: 0x060081C5 RID: 33221 RVA: 0x0027D20C File Offset: 0x0027B40C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x060081C6 RID: 33222 RVA: 0x0027D268 File Offset: 0x0027B468
	public void SetCost(int itemId, int costCount)
	{
		base.SetItemIcon(base.GetTexture(2), itemId, null, null);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(costCount.ToString(), true);
	}

	// Token: 0x02006EE7 RID: 28391
	private enum EComponent
	{
		// Token: 0x04024413 RID: 148499
		TxtTips,
		// Token: 0x04024414 RID: 148500
		TxtCost,
		// Token: 0x04024415 RID: 148501
		CostIcon
	}
}
