using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200113D RID: 4413
public class GachaDiscountTagItem : UiPanelBase
{
	// Token: 0x0600B00E RID: 45070 RVA: 0x0033EB74 File Offset: 0x0033CD74
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

	// Token: 0x0600B00F RID: 45071 RVA: 0x0033EBBC File Offset: 0x0033CDBC
	[NullableContext(1)]
	public void SetContent(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x0600B010 RID: 45072 RVA: 0x0033EBCC File Offset: 0x0033CDCC
	[NullableContext(1)]
	public void SetLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x020073CA RID: 29642
	private enum EComponent
	{
		// Token: 0x04025B1C RID: 154396
		TextContent
	}
}
