using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200239F RID: 9119
[Nullable(new byte[]
{
	0,
	1
})]
public class WeekCardCostGrid : GridProxyAbstract<IWeekCostData>
{
	// Token: 0x060123D6 RID: 74710 RVA: 0x0047E3E0 File Offset: 0x0047C5E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060123D7 RID: 74711 RVA: 0x0047E46C File Offset: 0x0047C66C
	[NullableContext(1)]
	public void Refresh(IWeekCostData costData)
	{
		UUIText text = base.GetText(0);
		text.SetUIActive(!string.IsNullOrEmpty(costData.Tips));
		if (!string.IsNullOrEmpty(costData.Tips))
		{
			LguiUtil.Instance.SetLocalTextNew(text, costData.Tips, Array.Empty<object>());
		}
		base.GetText(1).SetText(costData.Count.ToString(), true);
		base.SetItemIcon(base.GetTexture(2), costData.ItemId, null, null);
	}

	// Token: 0x060123D8 RID: 74712 RVA: 0x0047E4F0 File Offset: 0x0047C6F0
	[NullableContext(2)]
	public override void Refresh(IWeekCostData data, bool isSelected, int gridIndex)
	{
		if (data != null)
		{
			this.Refresh(data);
		}
	}

	// Token: 0x02008944 RID: 35140
	private class EComponent
	{
		// Token: 0x0402C9F8 RID: 182776
		public const int TipsText = 0;

		// Token: 0x0402C9F9 RID: 182777
		public const int CostText = 1;

		// Token: 0x0402C9FA RID: 182778
		public const int CostIcon = 2;
	}
}
