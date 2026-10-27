using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200192C RID: 6444
public class MediumItemGridRightTopValueComponent : MediumItemGridComponent
{
	// Token: 0x0600BC9C RID: 48284 RVA: 0x002AAED8 File Offset: 0x002A90D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC9D RID: 48285 RVA: 0x002AAF20 File Offset: 0x002A9120
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnemyCount";
	}

	// Token: 0x0600BC9E RID: 48286 RVA: 0x002AAF28 File Offset: 0x002A9128
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		string text = data as string;
		if (text == null)
		{
			return;
		}
		bool flag = !string.IsNullOrEmpty(text);
		this.SetActive(flag);
		if (flag)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}
	}

	// Token: 0x0600BC9F RID: 48287 RVA: 0x002AAF67 File Offset: 0x002A9167
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007E92 RID: 32402
	private class EChildType
	{
		// Token: 0x0402966C RID: 169580
		public const int TextContent = 0;
	}
}
