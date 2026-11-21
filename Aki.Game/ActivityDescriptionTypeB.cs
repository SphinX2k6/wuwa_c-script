using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A02 RID: 2562
public class ActivityDescriptionTypeB : UiPanelBase
{
	// Token: 0x06006FA0 RID: 28576 RVA: 0x002256B0 File Offset: 0x002238B0
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

	// Token: 0x06006FA1 RID: 28577 RVA: 0x002256F8 File Offset: 0x002238F8
	[NullableContext(1)]
	public void SetContentByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06006FA2 RID: 28578 RVA: 0x0022570D File Offset: 0x0022390D
	[NullableContext(1)]
	public void SetContentByText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06006FA3 RID: 28579 RVA: 0x0022571D File Offset: 0x0022391D
	public void SetContentVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x02006D0A RID: 27914
	private class EComponents
	{
		// Token: 0x04023CDF RID: 146655
		public const int TextContent = 0;
	}
}
