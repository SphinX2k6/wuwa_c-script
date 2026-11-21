using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000E0E RID: 3598
[Nullable(new byte[]
{
	0,
	1
})]
public class PageDot<[Nullable(2)] TData> : GridProxyAbstract<TData>
{
	// Token: 0x06009141 RID: 37185 RVA: 0x002B795C File Offset: 0x002B5B5C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009142 RID: 37186 RVA: 0x002B79A4 File Offset: 0x002B5BA4
	protected override void OnStart()
	{
		this.UpdateShow(false);
	}

	// Token: 0x06009143 RID: 37187 RVA: 0x002B79AD File Offset: 0x002B5BAD
	[NullableContext(1)]
	public override void Refresh(TData data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x06009144 RID: 37188 RVA: 0x002B79AF File Offset: 0x002B5BAF
	public void UpdateShow(bool show)
	{
		base.GetItem(0).SetUIActive(show);
	}

	// Token: 0x0200703A RID: 28730
	private class EComponent
	{
		// Token: 0x040249E1 RID: 149985
		public const int DotPic = 0;
	}
}
