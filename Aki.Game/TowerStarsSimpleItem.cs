using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002184 RID: 8580
public class TowerStarsSimpleItem : GridProxyAbstract<bool>
{
	// Token: 0x060150BF RID: 86207 RVA: 0x00622B1C File Offset: 0x00620D1C
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

	// Token: 0x060150C0 RID: 86208 RVA: 0x00622B64 File Offset: 0x00620D64
	public override void Refresh(bool data, bool isSelected, int gridIndex)
	{
		base.GetItem(0).SetUIActive(data);
	}

	// Token: 0x02008417 RID: 33815
	private enum EChildType
	{
		// Token: 0x0402A9E5 RID: 174565
		StarItem
	}
}
