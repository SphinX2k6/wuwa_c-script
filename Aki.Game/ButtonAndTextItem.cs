using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CA1 RID: 3233
[NullableContext(1)]
[Nullable(0)]
public class ButtonAndTextItem : UiPanelBase
{
	// Token: 0x060086EF RID: 34543 RVA: 0x00291DCD File Offset: 0x0028FFCD
	public ButtonAndTextItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060086F0 RID: 34544 RVA: 0x00291DE4 File Offset: 0x0028FFE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060086F1 RID: 34545 RVA: 0x00291E8A File Offset: 0x0029008A
	public void RefreshText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x060086F2 RID: 34546 RVA: 0x00291E9F File Offset: 0x0029009F
	public void RefreshTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x060086F3 RID: 34547 RVA: 0x00291EB4 File Offset: 0x002900B4
	public void SetText(string content)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(content, true);
	}

	// Token: 0x060086F4 RID: 34548 RVA: 0x00291EC9 File Offset: 0x002900C9
	public void SetTextColor(FColor newColor)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetColor(newColor);
	}

	// Token: 0x060086F5 RID: 34549 RVA: 0x00291EDD File Offset: 0x002900DD
	public void RefreshEnable(bool isEnable)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(isEnable);
	}

	// Token: 0x060086F6 RID: 34550 RVA: 0x00291EF1 File Offset: 0x002900F1
	public void BindCallback(Action onCallback)
	{
		if (this.OnCallback != null)
		{
			return;
		}
		this.OnCallback = onCallback;
	}

	// Token: 0x060086F7 RID: 34551 RVA: 0x00291F03 File Offset: 0x00290103
	private void OnClick()
	{
		if (this.OnCallback != null)
		{
			this.OnCallback();
		}
	}

	// Token: 0x040051C1 RID: 20929
	[Nullable(2)]
	private Action OnCallback;

	// Token: 0x02006F5B RID: 28507
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x04024639 RID: 149049
		public const int Button = 0;

		// Token: 0x0402463A RID: 149050
		public const int Text = 1;
	}
}
