using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020008FE RID: 2302
public class SignItem : UiPanelBase
{
	// Token: 0x06006649 RID: 26185 RVA: 0x002005E0 File Offset: 0x001FE7E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600664A RID: 26186 RVA: 0x00200734 File Offset: 0x001FE934
	public void RefreshSignItem(bool isHyper, bool haveRedDot)
	{
		base.GetItem(1).SetUIActive(!isHyper);
		base.GetItem(2).SetUIActive(!isHyper);
		base.GetItem(3).SetUIActive(!isHyper);
		base.GetItem(4).SetUIActive(isHyper);
		base.GetItem(5).SetUIActive(isHyper);
		base.GetItem(6).SetUIActive(isHyper);
		base.GetItem(7).SetUIActive(isHyper && haveRedDot);
	}

	// Token: 0x02006C06 RID: 27654
	private class ESignItem
	{
		// Token: 0x04023821 RID: 145441
		public const int Button = 0;

		// Token: 0x04023822 RID: 145442
		public const int NormalItem1 = 1;

		// Token: 0x04023823 RID: 145443
		public const int NormalItem2 = 2;

		// Token: 0x04023824 RID: 145444
		public const int NormalItem3 = 3;

		// Token: 0x04023825 RID: 145445
		public const int GoldenItem1 = 4;

		// Token: 0x04023826 RID: 145446
		public const int GoldenItem2 = 5;

		// Token: 0x04023827 RID: 145447
		public const int GoldenItem3 = 6;

		// Token: 0x04023828 RID: 145448
		public const int GoldenItem4 = 7;

		// Token: 0x04023829 RID: 145449
		public const int ItemTexture = 8;

		// Token: 0x0402382A RID: 145450
		public const int ItemText = 9;

		// Token: 0x0402382B RID: 145451
		public const int RedDotItem = 10;
	}
}
