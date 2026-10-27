using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C7E RID: 7294
public class GachaDiscountTagItem : UiPanelBase
{
	// Token: 0x0600DBF8 RID: 56312 RVA: 0x00333714 File Offset: 0x00331914
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

	// Token: 0x0600DBF9 RID: 56313 RVA: 0x0033375C File Offset: 0x0033195C
	[NullableContext(1)]
	public void SetContent(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x0600DBFA RID: 56314 RVA: 0x0033376C File Offset: 0x0033196C
	[NullableContext(1)]
	public void SetLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x02008241 RID: 33345
	private enum EComponent
	{
		// Token: 0x0402A7F6 RID: 174070
		TextContent
	}
}
