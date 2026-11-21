using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A09 RID: 2569
[NullableContext(2)]
[Nullable(0)]
public class FunctionalPanelConditionLock : UiPanelBase
{
	// Token: 0x17000D87 RID: 3463
	// (get) Token: 0x06007019 RID: 28697 RVA: 0x00226B4C File Offset: 0x00224D4C
	// (set) Token: 0x0600701A RID: 28698 RVA: 0x00226B54 File Offset: 0x00224D54
	public Action ButtonCallBack { get; set; }

	// Token: 0x0600701B RID: 28699 RVA: 0x00226B60 File Offset: 0x00224D60
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ButtonCallBackInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600701C RID: 28700 RVA: 0x00226C27 File Offset: 0x00224E27
	[NullableContext(1)]
	public void SetTextByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600701D RID: 28701 RVA: 0x00226C3C File Offset: 0x00224E3C
	[NullableContext(1)]
	public void SetTextByText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x0600701E RID: 28702 RVA: 0x00226C4C File Offset: 0x00224E4C
	[NullableContext(1)]
	public UUISprite GetIconSprite()
	{
		return base.GetSprite(0);
	}

	// Token: 0x0600701F RID: 28703 RVA: 0x00226C55 File Offset: 0x00224E55
	public void SetSpriteVisible(bool bVisible)
	{
		base.GetSprite(0).SetUIActive(bVisible);
	}

	// Token: 0x06007020 RID: 28704 RVA: 0x00226C64 File Offset: 0x00224E64
	public void SetButtonVisible(bool bVisible)
	{
		base.GetButton(2).RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x06007021 RID: 28705 RVA: 0x00226C8B File Offset: 0x00224E8B
	private void ButtonCallBackInternal()
	{
		Action buttonCallBack = this.ButtonCallBack;
		if (buttonCallBack == null)
		{
			return;
		}
		buttonCallBack();
	}

	// Token: 0x02006D1C RID: 27932
	[NullableContext(0)]
	private class ERedComponents
	{
		// Token: 0x04023D1C RID: 146716
		public const int Sprite = 0;

		// Token: 0x04023D1D RID: 146717
		public const int Txt = 1;

		// Token: 0x04023D1E RID: 146718
		public const int Button = 2;
	}
}
