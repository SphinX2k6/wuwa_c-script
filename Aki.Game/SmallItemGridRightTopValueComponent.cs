using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E4A RID: 3658
public class SmallItemGridRightTopValueComponent : SmallItemGridComponent
{
	// Token: 0x0600932C RID: 37676 RVA: 0x002BE458 File Offset: 0x002BC658
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

	// Token: 0x0600932D RID: 37677 RVA: 0x002BE4A0 File Offset: 0x002BC6A0
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_EnemyCount";
	}

	// Token: 0x0600932E RID: 37678 RVA: 0x002BE4A8 File Offset: 0x002BC6A8
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

	// Token: 0x0600932F RID: 37679 RVA: 0x002BE4E7 File Offset: 0x002BC6E7
	public override EItemGridComponentLayoutLevel GetLayoutLevel()
	{
		return EItemGridComponentLayoutLevel.Bottom;
	}

	// Token: 0x0200705A RID: 28762
	private class EChildType
	{
		// Token: 0x04024A4A RID: 150090
		public const int TextContent = 0;
	}
}
