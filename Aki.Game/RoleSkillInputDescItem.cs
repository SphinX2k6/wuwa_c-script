using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020028B5 RID: 10421
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSkillInputDescItem : GridProxyAbstract<string>
{
	// Token: 0x060157E4 RID: 88036 RVA: 0x0056B8F0 File Offset: 0x00569AF0
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

	// Token: 0x060157E5 RID: 88037 RVA: 0x0056B938 File Offset: 0x00569B38
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(0).ShowTextNew(data);
	}

	// Token: 0x02008EB6 RID: 36534
	private enum EComponent
	{
		// Token: 0x0402E46E RID: 189550
		Desc
	}
}
