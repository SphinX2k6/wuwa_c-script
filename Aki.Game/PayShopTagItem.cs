using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001876 RID: 6262
public class PayShopTagItem : UiPanelBase
{
	// Token: 0x0600F7FE RID: 63486 RVA: 0x00488B08 File Offset: 0x00486D08
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

	// Token: 0x0600F7FF RID: 63487 RVA: 0x00488B71 File Offset: 0x00486D71
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

	// Token: 0x0600F800 RID: 63488 RVA: 0x00488B86 File Offset: 0x00486D86
	[NullableContext(1)]
	public void SetTextByTextId(string textId, int param = 0)
	{
		this.TextParam = param;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, new <>z__ReadOnlySingleElementList<object>(param));
	}

	// Token: 0x0600F801 RID: 63489 RVA: 0x00488BAC File Offset: 0x00486DAC
	public void SetMaskVisible(bool isVisible)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(isVisible);
	}

	// Token: 0x04008ADD RID: 35549
	public int TextParam;

	// Token: 0x02007ABE RID: 31422
	private class EComponents
	{
		// Token: 0x04027CB8 RID: 163000
		public const int Text = 0;

		// Token: 0x04027CB9 RID: 163001
		public const int TextureMask = 1;
	}
}
