using System;
using System.Collections.Generic;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001313 RID: 4883
public class DelegationNonDetailsModuleCostItem : UiPanelBase
{
	// Token: 0x0600876A RID: 34666 RVA: 0x001CE673 File Offset: 0x001CC873
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600876B RID: 34667 RVA: 0x001CE6AC File Offset: 0x001CC8AC
	public void UpdateItem(int id, int count)
	{
		this.ItemId = id;
		this.Count = count;
		base.SetItemIcon(base.GetTexture(1), id, null, null);
		base.GetText(0).SetText(count.ToString(), true);
		this.RefreshCountEnableState();
	}

	// Token: 0x0600876C RID: 34668 RVA: 0x001CE6FC File Offset: 0x001CC8FC
	public void RefreshCountEnableState()
	{
		UUIText text = base.GetText(0);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !this.IsEnough;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x17000B8A RID: 2954
	// (get) Token: 0x0600876D RID: 34669 RVA: 0x001CE72E File Offset: 0x001CC92E
	public bool IsEnough
	{
		get
		{
			return this.ItemId != 0 && InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0) >= this.Count;
		}
	}

	// Token: 0x04003C6C RID: 15468
	private int ItemId;

	// Token: 0x04003C6D RID: 15469
	private int Count;

	// Token: 0x0200795C RID: 31068
	private static class ECostItemDefine
	{
		// Token: 0x04027F86 RID: 163718
		public const int CostText = 0;

		// Token: 0x04027F87 RID: 163719
		public const int Icon = 1;
	}
}
