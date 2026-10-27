using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002391 RID: 9105
public class PayShopTagItem : UiPanelBase
{
	// Token: 0x0601234C RID: 74572 RVA: 0x0047B7B8 File Offset: 0x004799B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601234D RID: 74573 RVA: 0x0047B821 File Offset: 0x00479A21
	[NullableContext(1)]
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(0);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0601234E RID: 74574 RVA: 0x0047B836 File Offset: 0x00479A36
	[NullableContext(1)]
	public void SetTextByTextId(string textId, int param = 0)
	{
		this.TextParam = param;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, new <>z__ReadOnlySingleElementList<object>(param));
	}

	// Token: 0x0601234F RID: 74575 RVA: 0x0047B85C File Offset: 0x00479A5C
	public void SetMaskVisible(bool isVisible)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(isVisible);
	}

	// Token: 0x04008996 RID: 35222
	public int TextParam;

	// Token: 0x02008933 RID: 35123
	private class EComponents
	{
		// Token: 0x0402C99A RID: 182682
		public const int Text = 0;

		// Token: 0x0402C99B RID: 182683
		public const int TextureMask = 1;
	}
}
