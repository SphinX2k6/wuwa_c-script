using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001549 RID: 5449
public class ActivityDescriptionTypeA : UiPanelBase
{
	// Token: 0x06009BBD RID: 39869 RVA: 0x0021B87C File Offset: 0x00219A7C
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

	// Token: 0x06009BBE RID: 39870 RVA: 0x0021B8C4 File Offset: 0x00219AC4
	[NullableContext(1)]
	public void SetContentByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06009BBF RID: 39871 RVA: 0x0021B8D9 File Offset: 0x00219AD9
	[NullableContext(1)]
	public void SetContentByText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06009BC0 RID: 39872 RVA: 0x0021B8E9 File Offset: 0x00219AE9
	public void SetContentVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x02007B7E RID: 31614
	private class EComponents
	{
		// Token: 0x040289A3 RID: 166307
		public const int TextContent = 0;
	}
}
