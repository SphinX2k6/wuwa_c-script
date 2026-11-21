using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A01 RID: 2561
public class ActivityDescriptionTypeA : UiPanelBase
{
	// Token: 0x06006F9B RID: 28571 RVA: 0x0022562C File Offset: 0x0022382C
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

	// Token: 0x06006F9C RID: 28572 RVA: 0x00225674 File Offset: 0x00223874
	[NullableContext(1)]
	public void SetContentByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06006F9D RID: 28573 RVA: 0x00225689 File Offset: 0x00223889
	[NullableContext(1)]
	public void SetContentByText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06006F9E RID: 28574 RVA: 0x00225699 File Offset: 0x00223899
	public void SetContentVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x02006D09 RID: 27913
	private class EComponents
	{
		// Token: 0x04023CDE RID: 146654
		public const int TextContent = 0;
	}
}
