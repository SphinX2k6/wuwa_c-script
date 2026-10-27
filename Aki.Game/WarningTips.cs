using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015ED RID: 5613
[NullableContext(1)]
[Nullable(0)]
internal class WarningTips : UiPanelBase
{
	// Token: 0x06009E83 RID: 40579 RVA: 0x00229CC0 File Offset: 0x00227EC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E84 RID: 40580 RVA: 0x00229D4A File Offset: 0x00227F4A
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x06009E85 RID: 40581 RVA: 0x00229D71 File Offset: 0x00227F71
	public void SetTextById(string textId)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(textId);
	}

	// Token: 0x06009E86 RID: 40582 RVA: 0x00229D85 File Offset: 0x00227F85
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}
}
