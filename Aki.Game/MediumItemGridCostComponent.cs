using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DC4 RID: 3524
public class MediumItemGridCostComponent : MediumItemGridComponent
{
	// Token: 0x17000FCC RID: 4044
	// (get) Token: 0x06008FD2 RID: 36818 RVA: 0x002B3E4D File Offset: 0x002B204D
	private static FColor NotEnoughColor
	{
		get
		{
			return FColor.FromHex("E2524C");
		}
	}

	// Token: 0x06008FD3 RID: 36819 RVA: 0x002B3E59 File Offset: 0x002B2059
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemEnergy";
	}

	// Token: 0x06008FD4 RID: 36820 RVA: 0x002B3E60 File Offset: 0x002B2060
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06008FD5 RID: 36821 RVA: 0x002B3F2C File Offset: 0x002B212C
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		MediumItemGridCostComponentData mediumItemGridCostComponentData = data as MediumItemGridCostComponentData;
		if (mediumItemGridCostComponentData == null)
		{
			return;
		}
		UUIText text = base.GetText(0);
		if (mediumItemGridCostComponentData.Text != null)
		{
			text.SetText(mediumItemGridCostComponentData.Text, true);
		}
		else if (mediumItemGridCostComponentData.Cost < 0)
		{
			text.ShowTextNew("TowerCostNotEnough");
		}
		else
		{
			text.SetText(mediumItemGridCostComponentData.Cost.ToString(), true);
		}
		FColor color = (mediumItemGridCostComponentData.Cost < 0) ? MediumItemGridCostComponent.NotEnoughColor : mediumItemGridCostComponentData.Color;
		text.SetColor(color);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetColor(color);
		}
		UUIItem item2 = base.GetItem(2);
		bool flag = mediumItemGridCostComponentData.Text == null && mediumItemGridCostComponentData.Cost < 0;
		if (mediumItemGridCostComponentData.BeforeCost != null && !flag)
		{
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			FColor color2 = mediumItemGridCostComponentData.BeforeColor ?? mediumItemGridCostComponentData.Color;
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(mediumItemGridCostComponentData.BeforeCost.Value.ToString(), true);
			}
			if (text2 != null)
			{
				text2.SetColor(color2);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetColor(color2);
			}
		}
		else if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.SetActive(true);
	}

	// Token: 0x02007006 RID: 28678
	private class ECostItem
	{
		// Token: 0x0402496C RID: 149868
		public const int NumberText = 0;

		// Token: 0x0402496D RID: 149869
		public const int IconItem = 1;

		// Token: 0x0402496E RID: 149870
		public const int BeforeItem = 2;

		// Token: 0x0402496F RID: 149871
		public const int BeforeCostText = 3;

		// Token: 0x04024970 RID: 149872
		public const int BeforeCostIconItem = 4;
	}
}
