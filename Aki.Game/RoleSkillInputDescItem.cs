using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001E30 RID: 7728
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSkillInputDescItem : GridProxyAbstract<string>
{
	// Token: 0x060131E4 RID: 78308 RVA: 0x00596738 File Offset: 0x00594938
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

	// Token: 0x060131E5 RID: 78309 RVA: 0x00596780 File Offset: 0x00594980
	[NullableContext(1)]
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		base.GetText(0).ShowTextNew(data);
	}

	// Token: 0x020080FD RID: 33021
	private enum EComponent
	{
		// Token: 0x04029B6B RID: 170859
		Desc
	}
}
