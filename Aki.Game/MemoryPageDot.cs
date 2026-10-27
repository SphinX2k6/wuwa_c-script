using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C16 RID: 7190
public class MemoryPageDot : GridProxyAbstract<bool>
{
	// Token: 0x0600D7AA RID: 55210 RVA: 0x0031EF68 File Offset: 0x0031D168
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

	// Token: 0x0600D7AB RID: 55211 RVA: 0x0031EFB0 File Offset: 0x0031D1B0
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data);
	}

	// Token: 0x020081D5 RID: 33237
	private class EDotItem
	{
		// Token: 0x0402A602 RID: 173570
		public const int Dot = 0;
	}
}
