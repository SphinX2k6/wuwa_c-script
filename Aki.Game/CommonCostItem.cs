using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E13 RID: 3603
public class CommonCostItem : UiPanelBase
{
	// Token: 0x06009165 RID: 37221 RVA: 0x002B8734 File Offset: 0x002B6934
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

	// Token: 0x06009166 RID: 37222 RVA: 0x002B87C0 File Offset: 0x002B69C0
	public void UpdateItem(int id, int count)
	{
		this.ItemId = id;
		this.Count = count;
		base.SetItemIcon(base.GetTexture(2), id, null, null);
		base.GetText(1).SetText(count.ToString(), true);
	}

	// Token: 0x06009167 RID: 37223 RVA: 0x002B8808 File Offset: 0x002B6A08
	public void RefreshCountEnableState()
	{
		UUIText text = base.GetText(1);
		UUIItem uuiitem = text;
		bool bUseChangeColor = !this.IsEnough;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x17000FF1 RID: 4081
	// (get) Token: 0x06009168 RID: 37224 RVA: 0x002B883A File Offset: 0x002B6A3A
	public bool IsEnough
	{
		get
		{
			return this.ItemId != 0 && InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0) >= this.Count;
		}
	}

	// Token: 0x0400561D RID: 22045
	private int ItemId;

	// Token: 0x0400561E RID: 22046
	private int Count;

	// Token: 0x02007042 RID: 28738
	private enum ECommonCostItemDefine
	{
		// Token: 0x040249FF RID: 150015
		Tips,
		// Token: 0x04024A00 RID: 150016
		CostText,
		// Token: 0x04024A01 RID: 150017
		Icon
	}
}
