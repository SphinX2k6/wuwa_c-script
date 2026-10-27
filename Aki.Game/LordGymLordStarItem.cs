using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020021AE RID: 8622
public class LordGymLordStarItem : GridProxyAbstract<bool>
{
	// Token: 0x06010C62 RID: 68706 RVA: 0x00413058 File Offset: 0x00411258
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

	// Token: 0x06010C63 RID: 68707 RVA: 0x004130A0 File Offset: 0x004112A0
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data);
	}

	// Token: 0x020086E4 RID: 34532
	private class EComponent
	{
		// Token: 0x0402BE3D RID: 179773
		public const int ActiveStarItem = 0;
	}
}
