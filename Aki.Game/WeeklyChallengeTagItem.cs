using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D2A RID: 11562
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyChallengeTagItem : GridProxyAbstract<string>
{
	// Token: 0x060184DF RID: 99551 RVA: 0x00630248 File Offset: 0x0062E448
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

	// Token: 0x060184E0 RID: 99552 RVA: 0x00630290 File Offset: 0x0062E490
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(0).ShowTextNew(data);
	}

	// Token: 0x020092BB RID: 37563
	private enum EComponents
	{
		// Token: 0x0402F6E8 RID: 194280
		TagText
	}
}
