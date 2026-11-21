using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020009A8 RID: 2472
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketConditionItem : GridProxyAbstract<ScratchTicketConditionData>
{
	// Token: 0x06006CA4 RID: 27812 RVA: 0x0021A058 File Offset: 0x00218258
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006CA5 RID: 27813 RVA: 0x0021A0E2 File Offset: 0x002182E2
	[NullableContext(1)]
	public override void Refresh(ScratchTicketConditionData data, bool isSelected, int gridIndex)
	{
		base.GetItem(0).SetUIActive(data.IsFinish());
		base.GetText(1).SetText(data.GetConditionDesc(), true);
		base.GetText(2).SetText(data.GetConditionTypeName(), true);
	}

	// Token: 0x02006CB0 RID: 27824
	private class EComponent
	{
		// Token: 0x04023B3A RID: 146234
		public const int FinishItem = 0;

		// Token: 0x04023B3B RID: 146235
		public const int ConditionDesc = 1;

		// Token: 0x04023B3C RID: 146236
		public const int ConditionTypeName = 2;
	}
}
