using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A0A RID: 2570
[NullableContext(1)]
[Nullable(0)]
public class FunctionalPanelConditionActivate : UiPanelBase
{
	// Token: 0x06007023 RID: 28707 RVA: 0x00226CA8 File Offset: 0x00224EA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007024 RID: 28708 RVA: 0x00226D11 File Offset: 0x00224F11
	public void SetTextByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06007025 RID: 28709 RVA: 0x00226D26 File Offset: 0x00224F26
	public void SetTextByText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06007026 RID: 28710 RVA: 0x00226D36 File Offset: 0x00224F36
	public UUISprite GetIconSprite()
	{
		return base.GetSprite(0);
	}

	// Token: 0x06007027 RID: 28711 RVA: 0x00226D3F File Offset: 0x00224F3F
	public void SetSpriteVisible(bool bVisible)
	{
		base.GetSprite(0).SetUIActive(bVisible);
	}

	// Token: 0x02006D1D RID: 27933
	[NullableContext(0)]
	private class ERedComponents
	{
		// Token: 0x04023D1F RID: 146719
		public const int Sprite = 0;

		// Token: 0x04023D20 RID: 146720
		public const int Txt = 1;
	}
}
