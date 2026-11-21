using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200215D RID: 8541
public class TowerCostItem : UiPanelBase
{
	// Token: 0x06014F9C RID: 85916 RVA: 0x0061C5E4 File Offset: 0x0061A7E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014F9D RID: 85917 RVA: 0x0061C650 File Offset: 0x0061A850
	public void Update(int cost)
	{
		UUIText text = base.GetText(0);
		text.SetText(cost.ToString(), true);
		FColor? fcolor = (cost >= 4) ? TowerData.highColor : ((cost == 0) ? TowerData.noneColor : TowerData.lowColor);
		text.SetColor(fcolor.Value);
		base.GetItem(1).SetColor(fcolor.Value);
	}

	// Token: 0x020083E0 RID: 33760
	private enum EChildType
	{
		// Token: 0x0402A8EA RID: 174314
		NumberText,
		// Token: 0x0402A8EB RID: 174315
		IconItem
	}
}
