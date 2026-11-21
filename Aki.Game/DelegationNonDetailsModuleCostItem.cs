using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007C7 RID: 1991
public class DelegationNonDetailsModuleCostItem : UiPanelBase
{
	// Token: 0x06005B05 RID: 23301 RVA: 0x001D74DF File Offset: 0x001D56DF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06005B06 RID: 23302 RVA: 0x001D7518 File Offset: 0x001D5718
	public void UpdateItem(int id, int count)
	{
		this.ItemId = id;
		this.Count = count;
		base.SetItemIcon(base.GetTexture(1), id, null, null);
		base.GetText(0).SetText(count.ToString(), true);
		this.RefreshCountEnableState();
	}

	// Token: 0x06005B07 RID: 23303 RVA: 0x001D7568 File Offset: 0x001D5768
	public void RefreshCountEnableState()
	{
		UUIText text = base.GetText(0);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !this.IsEnough;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x17000BAA RID: 2986
	// (get) Token: 0x06005B08 RID: 23304 RVA: 0x001D759A File Offset: 0x001D579A
	public bool IsEnough
	{
		get
		{
			return this.ItemId != 0 && InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0) >= this.Count;
		}
	}

	// Token: 0x04003D04 RID: 15620
	private int ItemId;

	// Token: 0x04003D05 RID: 15621
	private int Count;

	// Token: 0x02006AE6 RID: 27366
	private static class ECostItemDefine
	{
		// Token: 0x040232B3 RID: 144051
		public const int CostText = 0;

		// Token: 0x040232B4 RID: 144052
		public const int Icon = 1;
	}
}
