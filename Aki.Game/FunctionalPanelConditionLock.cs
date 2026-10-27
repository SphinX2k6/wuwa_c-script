using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001551 RID: 5457
[NullableContext(2)]
[Nullable(0)]
public class FunctionalPanelConditionLock : UiPanelBase
{
	// Token: 0x17000D66 RID: 3430
	// (get) Token: 0x06009C3B RID: 39995 RVA: 0x0021CD9C File Offset: 0x0021AF9C
	// (set) Token: 0x06009C3C RID: 39996 RVA: 0x0021CDA4 File Offset: 0x0021AFA4
	public Action ButtonCallBack { get; set; }

	// Token: 0x06009C3D RID: 39997 RVA: 0x0021CDB0 File Offset: 0x0021AFB0
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

	// Token: 0x06009C3E RID: 39998 RVA: 0x0021CE77 File Offset: 0x0021B077
	[NullableContext(1)]
	public void SetTextByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06009C3F RID: 39999 RVA: 0x0021CE8C File Offset: 0x0021B08C
	[NullableContext(1)]
	public void SetTextByText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06009C40 RID: 40000 RVA: 0x0021CE9C File Offset: 0x0021B09C
	[NullableContext(1)]
	public UUISprite GetIconSprite()
	{
		return base.GetSprite(0);
	}

	// Token: 0x06009C41 RID: 40001 RVA: 0x0021CEA5 File Offset: 0x0021B0A5
	public void SetSpriteVisible(bool bVisible)
	{
		base.GetSprite(0).SetUIActive(bVisible);
	}

	// Token: 0x06009C42 RID: 40002 RVA: 0x0021CEB4 File Offset: 0x0021B0B4
	public void SetButtonVisible(bool bVisible)
	{
		base.GetButton(2).RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x06009C43 RID: 40003 RVA: 0x0021CEDB File Offset: 0x0021B0DB
	private void ButtonCallBackInternal()
	{
		Action buttonCallBack = this.ButtonCallBack;
		if (buttonCallBack == null)
		{
			return;
		}
		buttonCallBack();
	}

	// Token: 0x02007B91 RID: 31633
	[NullableContext(0)]
	private class ERedComponents
	{
		// Token: 0x040289E1 RID: 166369
		public const int Sprite = 0;

		// Token: 0x040289E2 RID: 166370
		public const int Txt = 1;

		// Token: 0x040289E3 RID: 166371
		public const int Button = 2;
	}
}
