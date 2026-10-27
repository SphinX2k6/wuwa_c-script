using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200176A RID: 5994
public class VisionRefineCostItem : UiPanelBase
{
	// Token: 0x0600ADDE RID: 44510 RVA: 0x00272D48 File Offset: 0x00270F48
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600ADDF RID: 44511 RVA: 0x00272DA4 File Offset: 0x00270FA4
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

	// Token: 0x02007D61 RID: 32097
	private enum EComponent
	{
		// Token: 0x040290E8 RID: 168168
		TxtTips,
		// Token: 0x040290E9 RID: 168169
		TxtCost,
		// Token: 0x040290EA RID: 168170
		CostIcon
	}
}
