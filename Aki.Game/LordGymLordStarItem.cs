using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001692 RID: 5778
public class LordGymLordStarItem : GridProxyAbstract<bool>
{
	// Token: 0x0600E0F3 RID: 57587 RVA: 0x0041F940 File Offset: 0x0041DB40
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

	// Token: 0x0600E0F4 RID: 57588 RVA: 0x0041F988 File Offset: 0x0041DB88
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data);
	}

	// Token: 0x0200786F RID: 30831
	private class EComponent
	{
		// Token: 0x0402715E RID: 160094
		public const int ActiveStarItem = 0;
	}
}
