using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020014F0 RID: 5360
[Nullable(new byte[]
{
	0,
	1
})]
public class ScratchTicketConditionItem : GridProxyAbstract<ScratchTicketConditionData>
{
	// Token: 0x060098CA RID: 39114 RVA: 0x0021036C File Offset: 0x0020E56C
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

	// Token: 0x060098CB RID: 39115 RVA: 0x002103F6 File Offset: 0x0020E5F6
	[NullableContext(1)]
	public override void Refresh(ScratchTicketConditionData data, bool isSelected, int gridIndex)
	{
		base.GetItem(0).SetUIActive(data.IsFinish());
		base.GetText(1).SetText(data.GetConditionDesc(), true);
		base.GetText(2).SetText(data.GetConditionTypeName(), true);
	}

	// Token: 0x02007B24 RID: 31524
	private class EComponent
	{
		// Token: 0x040287FC RID: 165884
		public const int FinishItem = 0;

		// Token: 0x040287FD RID: 165885
		public const int ConditionDesc = 1;

		// Token: 0x040287FE RID: 165886
		public const int ConditionTypeName = 2;
	}
}
