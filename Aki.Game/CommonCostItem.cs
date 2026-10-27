using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001956 RID: 6486
public class CommonCostItem : UiPanelBase
{
	// Token: 0x0600BD62 RID: 48482 RVA: 0x002AD8F0 File Offset: 0x002ABAF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BD63 RID: 48483 RVA: 0x002AD97C File Offset: 0x002ABB7C
	public void UpdateItem(int id, int count)
	{
		this.ItemId = id;
		this.Count = count;
		base.SetItemIcon(base.GetTexture(2), id, null, null);
		base.GetText(1).SetText(count.ToString(), true);
	}

	// Token: 0x0600BD64 RID: 48484 RVA: 0x002AD9C4 File Offset: 0x002ABBC4
	public void RefreshCountEnableState()
	{
		UUIText text = base.GetText(1);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !this.IsEnough;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x17000FCD RID: 4045
	// (get) Token: 0x0600BD65 RID: 48485 RVA: 0x002AD9F6 File Offset: 0x002ABBF6
	public bool IsEnough
	{
		get
		{
			return this.ItemId != 0 && InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0) >= this.Count;
		}
	}

	// Token: 0x04005570 RID: 21872
	private int ItemId;

	// Token: 0x04005571 RID: 21873
	private int Count;

	// Token: 0x02007EB3 RID: 32435
	private enum ECommonCostItemDefine
	{
		// Token: 0x040296C2 RID: 169666
		Tips,
		// Token: 0x040296C3 RID: 169667
		CostText,
		// Token: 0x040296C4 RID: 169668
		Icon
	}
}
