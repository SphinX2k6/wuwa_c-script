using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200190B RID: 6411
public class MediumItemGridCostComponent : MediumItemGridComponent
{
	// Token: 0x17000FA9 RID: 4009
	// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x002A96F1 File Offset: 0x002A78F1
	private static FColor NotEnoughColor
	{
		get
		{
			return FColor.FromHex("E2524C");
		}
	}

	// Token: 0x0600BBE9 RID: 48105 RVA: 0x002A96FD File Offset: 0x002A78FD
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemEnergy";
	}

	// Token: 0x0600BBEA RID: 48106 RVA: 0x002A9704 File Offset: 0x002A7904
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

	// Token: 0x0600BBEB RID: 48107 RVA: 0x002A97D0 File Offset: 0x002A79D0
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

	// Token: 0x02007E7F RID: 32383
	private class ECostItem
	{
		// Token: 0x04029640 RID: 169536
		public const int NumberText = 0;

		// Token: 0x04029641 RID: 169537
		public const int IconItem = 1;

		// Token: 0x04029642 RID: 169538
		public const int BeforeItem = 2;

		// Token: 0x04029643 RID: 169539
		public const int BeforeCostText = 3;

		// Token: 0x04029644 RID: 169540
		public const int BeforeCostIconItem = 4;
	}
}
