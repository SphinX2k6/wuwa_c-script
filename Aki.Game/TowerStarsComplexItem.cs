using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002183 RID: 8579
public class TowerStarsComplexItem : GridProxyAbstract<ValueTuple<bool, TowerTarget>>
{
	// Token: 0x060150BC RID: 86204 RVA: 0x00622A6C File Offset: 0x00620C6C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060150BD RID: 86205 RVA: 0x00622AD5 File Offset: 0x00620CD5
	public override void Refresh(ValueTuple<bool, TowerTarget> data, bool isSelected, int gridIndex)
	{
		base.GetItem(0).SetUIActive(data.Item1);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Item2.DesText, data.Item2.Params());
	}

	// Token: 0x02008416 RID: 33814
	private enum EChildType
	{
		// Token: 0x0402A9E2 RID: 174562
		StarItem,
		// Token: 0x0402A9E3 RID: 174563
		DescriptionText
	}
}
