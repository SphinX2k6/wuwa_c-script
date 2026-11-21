using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010D5 RID: 4309
public class MemoryPageDot : GridProxyAbstract<bool>
{
	// Token: 0x0600ABBE RID: 43966 RVA: 0x0032A2B8 File Offset: 0x003284B8
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

	// Token: 0x0600ABBF RID: 43967 RVA: 0x0032A300 File Offset: 0x00328500
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data);
	}

	// Token: 0x0200735E RID: 29534
	private class EDotItem
	{
		// Token: 0x04025929 RID: 153897
		public const int Dot = 0;
	}
}
