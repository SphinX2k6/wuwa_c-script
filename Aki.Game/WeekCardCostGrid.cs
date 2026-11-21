using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001884 RID: 6276
[Nullable(new byte[]
{
	0,
	1
})]
public class WeekCardCostGrid : GridProxyAbstract<IWeekCostData>
{
	// Token: 0x0600F888 RID: 63624 RVA: 0x0048B878 File Offset: 0x00489A78
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

	// Token: 0x0600F889 RID: 63625 RVA: 0x0048B904 File Offset: 0x00489B04
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

	// Token: 0x0600F88A RID: 63626 RVA: 0x0048B988 File Offset: 0x00489B88
	[NullableContext(2)]
	public override void Refresh(IWeekCostData data, bool isSelected, int gridIndex)
	{
		if (data != null)
		{
			this.Refresh(data);
		}
	}

	// Token: 0x02007ACE RID: 31438
	private class EComponent
	{
		// Token: 0x04027D14 RID: 163092
		public const int TipsText = 0;

		// Token: 0x04027D15 RID: 163093
		public const int CostText = 1;

		// Token: 0x04027D16 RID: 163094
		public const int CostIcon = 2;
	}
}
