using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200198D RID: 6541
public class SmallItemGridRightTopValueComponent : SmallItemGridComponent
{
	// Token: 0x0600BF24 RID: 48932 RVA: 0x002B34D4 File Offset: 0x002B16D4
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

	// Token: 0x0600BF25 RID: 48933 RVA: 0x002B351C File Offset: 0x002B171C
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnemyCount";
	}

	// Token: 0x0600BF26 RID: 48934 RVA: 0x002B3524 File Offset: 0x002B1724
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

	// Token: 0x0600BF27 RID: 48935 RVA: 0x002B3563 File Offset: 0x002B1763
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x02007ECB RID: 32459
	private class EChildType
	{
		// Token: 0x0402970D RID: 169741
		public const int TextContent = 0;
	}
}
