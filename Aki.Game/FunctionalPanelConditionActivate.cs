using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001552 RID: 5458
[NullableContext(1)]
[Nullable(0)]
public class FunctionalPanelConditionActivate : UiPanelBase
{
	// Token: 0x06009C45 RID: 40005 RVA: 0x0021CEF8 File Offset: 0x0021B0F8
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

	// Token: 0x06009C46 RID: 40006 RVA: 0x0021CF61 File Offset: 0x0021B161
	public void SetTextByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06009C47 RID: 40007 RVA: 0x0021CF76 File Offset: 0x0021B176
	public void SetTextByText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06009C48 RID: 40008 RVA: 0x0021CF86 File Offset: 0x0021B186
	public UUISprite GetIconSprite()
	{
		return base.GetSprite(0);
	}

	// Token: 0x06009C49 RID: 40009 RVA: 0x0021CF8F File Offset: 0x0021B18F
	public void SetSpriteVisible(bool bVisible)
	{
		base.GetSprite(0).SetUIActive(bVisible);
	}

	// Token: 0x02007B92 RID: 31634
	[NullableContext(0)]
	private class ERedComponents
	{
		// Token: 0x040289E4 RID: 166372
		public const int Sprite = 0;

		// Token: 0x040289E5 RID: 166373
		public const int Txt = 1;
	}
}
