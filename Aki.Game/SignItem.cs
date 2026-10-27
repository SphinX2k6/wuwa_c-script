using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144A RID: 5194
public class SignItem : UiPanelBase
{
	// Token: 0x060092B4 RID: 37556 RVA: 0x001F7AA4 File Offset: 0x001F5CA4
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

	// Token: 0x060092B5 RID: 37557 RVA: 0x001F7BF8 File Offset: 0x001F5DF8
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

	// Token: 0x02007A82 RID: 31362
	private class ESignItem
	{
		// Token: 0x04028507 RID: 165127
		public const int Button = 0;

		// Token: 0x04028508 RID: 165128
		public const int NormalItem1 = 1;

		// Token: 0x04028509 RID: 165129
		public const int NormalItem2 = 2;

		// Token: 0x0402850A RID: 165130
		public const int NormalItem3 = 3;

		// Token: 0x0402850B RID: 165131
		public const int GoldenItem1 = 4;

		// Token: 0x0402850C RID: 165132
		public const int GoldenItem2 = 5;

		// Token: 0x0402850D RID: 165133
		public const int GoldenItem3 = 6;

		// Token: 0x0402850E RID: 165134
		public const int GoldenItem4 = 7;

		// Token: 0x0402850F RID: 165135
		public const int ItemTexture = 8;

		// Token: 0x04028510 RID: 165136
		public const int ItemText = 9;

		// Token: 0x04028511 RID: 165137
		public const int RedDotItem = 10;
	}
}
