using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200154A RID: 5450
public class ActivityDescriptionTypeB : UiPanelBase
{
	// Token: 0x06009BC2 RID: 39874 RVA: 0x0021B900 File Offset: 0x00219B00
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

	// Token: 0x06009BC3 RID: 39875 RVA: 0x0021B948 File Offset: 0x00219B48
	[NullableContext(1)]
	public void SetContentByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06009BC4 RID: 39876 RVA: 0x0021B95D File Offset: 0x00219B5D
	[NullableContext(1)]
	public void SetContentByText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06009BC5 RID: 39877 RVA: 0x0021B96D File Offset: 0x00219B6D
	public void SetContentVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x02007B7F RID: 31615
	private class EComponents
	{
		// Token: 0x040289A4 RID: 166308
		public const int TextContent = 0;
	}
}
