using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002C08 RID: 11272
public class TowerStarsComplexItem : GridProxyAbstract<ValueTuple<bool, TowerTarget>>
{
	// Token: 0x0601768B RID: 95883 RVA: 0x005F5F48 File Offset: 0x005F4148
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

	// Token: 0x0601768C RID: 95884 RVA: 0x005F5FB1 File Offset: 0x005F41B1
	public override void Refresh(ValueTuple<bool, TowerTarget> data, bool isSelected, int gridIndex)
	{
		base.GetItem(0).SetUIActive(data.Item1);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Item2.DesText, data.Item2.Params());
	}

	// Token: 0x020091D3 RID: 37331
	private enum EChildType
	{
		// Token: 0x0402F2E1 RID: 193249
		StarItem,
		// Token: 0x0402F2E2 RID: 193250
		DescriptionText
	}
}
