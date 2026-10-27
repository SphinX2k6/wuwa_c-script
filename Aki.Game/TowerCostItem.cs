using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002BE2 RID: 11234
public class TowerCostItem : UiPanelBase
{
	// Token: 0x0601756B RID: 95595 RVA: 0x005EFA68 File Offset: 0x005EDC68
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

	// Token: 0x0601756C RID: 95596 RVA: 0x005EFAD4 File Offset: 0x005EDCD4
	public void Update(int cost)
	{
		UUIText text = base.GetText(0);
		text.SetText(cost.ToString(), true);
		FColor? fcolor = (cost >= 4) ? TowerData.highColor : ((cost == 0) ? TowerData.noneColor : TowerData.lowColor);
		text.SetColor(fcolor.Value);
		base.GetItem(1).SetColor(fcolor.Value);
	}

	// Token: 0x0200919D RID: 37277
	private enum EChildType
	{
		// Token: 0x0402F1E8 RID: 193000
		NumberText,
		// Token: 0x0402F1E9 RID: 193001
		IconItem
	}
}
