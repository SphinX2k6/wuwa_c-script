using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002284 RID: 8836
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyChallengeTagItem : GridProxyAbstract<string>
{
	// Token: 0x06015D81 RID: 89473 RVA: 0x0065625C File Offset: 0x0065445C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06015D82 RID: 89474 RVA: 0x006562A4 File Offset: 0x006544A4
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(0).ShowTextNew(data);
	}

	// Token: 0x020084E2 RID: 34018
	private enum EComponents
	{
		// Token: 0x0402AD70 RID: 175472
		TagText
	}
}
