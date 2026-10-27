using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002C09 RID: 11273
public class TowerStarsSimpleItem : GridProxyAbstract<bool>
{
	// Token: 0x0601768E RID: 95886 RVA: 0x005F5FF8 File Offset: 0x005F41F8
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

	// Token: 0x0601768F RID: 95887 RVA: 0x005F6040 File Offset: 0x005F4240
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		base.GetItem(0).SetUIActive(data);
	}

	// Token: 0x020091D4 RID: 37332
	private enum EChildType
	{
		// Token: 0x0402F2E4 RID: 193252
		StarItem
	}
}
