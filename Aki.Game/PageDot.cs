using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001951 RID: 6481
[Nullable(new byte[]
{
	0,
	1
})]
public class PageDot<[Nullable(2)] TData> : GridProxyAbstract<TData>
{
	// Token: 0x0600BD3E RID: 48446 RVA: 0x002ACB18 File Offset: 0x002AAD18
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

	// Token: 0x0600BD3F RID: 48447 RVA: 0x002ACB60 File Offset: 0x002AAD60
	protected override void OnStart()
	{
		this.UpdateShow(false);
	}

	// Token: 0x0600BD40 RID: 48448 RVA: 0x002ACB69 File Offset: 0x002AAD69
	[NullableContext(1)]
	public override void Refresh(TData data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x0600BD41 RID: 48449 RVA: 0x002ACB6B File Offset: 0x002AAD6B
	public void UpdateShow(bool show)
	{
		base.GetItem(0).SetUIActive(show);
	}

	// Token: 0x02007EAB RID: 32427
	private class EComponent
	{
		// Token: 0x040296A4 RID: 169636
		public const int DotPic = 0;
	}
}
