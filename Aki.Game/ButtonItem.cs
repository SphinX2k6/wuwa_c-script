using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CA2 RID: 3234
[NullableContext(1)]
[Nullable(0)]
public class ButtonItem : UiPanelBase
{
	// Token: 0x060086F8 RID: 34552 RVA: 0x00291F18 File Offset: 0x00290118
	[NullableContext(2)]
	public ButtonItem(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}
	}

	// Token: 0x060086F9 RID: 34553 RVA: 0x00291F30 File Offset: 0x00290130
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060086FA RID: 34554 RVA: 0x00291FF7 File Offset: 0x002901F7
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060086FB RID: 34555 RVA: 0x00291FFF File Offset: 0x002901FF
	private void ButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction(this.Data);
		}
	}

	// Token: 0x060086FC RID: 34556 RVA: 0x0029201C File Offset: 0x0029021C
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x060086FD RID: 34557 RVA: 0x0029203C File Offset: 0x0029023C
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(text, true);
		}
	}

	// Token: 0x060086FE RID: 34558 RVA: 0x0029205C File Offset: 0x0029025C
	public void SetLocalText(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
	}

	// Token: 0x060086FF RID: 34559 RVA: 0x00292071 File Offset: 0x00290271
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06008700 RID: 34560 RVA: 0x00292086 File Offset: 0x00290286
	public void TrySetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06008701 RID: 34561 RVA: 0x0029209B File Offset: 0x0029029B
	public void SetShowText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(text);
	}

	// Token: 0x06008702 RID: 34562 RVA: 0x002920AF File Offset: 0x002902AF
	public void SetTextShowState(bool state)
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(state);
	}

	// Token: 0x06008703 RID: 34563 RVA: 0x002920C3 File Offset: 0x002902C3
	public void SetData(int data)
	{
		this.Data = data;
	}

	// Token: 0x06008704 RID: 34564 RVA: 0x002920CC File Offset: 0x002902CC
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x06008705 RID: 34565 RVA: 0x002920E0 File Offset: 0x002902E0
	public void SetFunction(Action<int> buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06008706 RID: 34566 RVA: 0x002920E9 File Offset: 0x002902E9
	public void ExecuteButtonFunction()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction(this.Data);
		}
	}

	// Token: 0x06008707 RID: 34567 RVA: 0x00292104 File Offset: 0x00290304
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06008708 RID: 34568 RVA: 0x00292118 File Offset: 0x00290318
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06008709 RID: 34569 RVA: 0x00292160 File Offset: 0x00290360
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x0600870A RID: 34570 RVA: 0x002921A0 File Offset: 0x002903A0
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
		}
	}

	// Token: 0x0600870B RID: 34571 RVA: 0x002921CC File Offset: 0x002903CC
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600870C RID: 34572 RVA: 0x002921FC File Offset: 0x002903FC
	[NullableContext(2)]
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x040051C2 RID: 20930
	private int Data;

	// Token: 0x040051C3 RID: 20931
	private ERedDotName? RedDotName;

	// Token: 0x040051C4 RID: 20932
	[Nullable(2)]
	private Action<int> ButtonFunction;

	// Token: 0x02006F5C RID: 28508
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x0402463B RID: 149051
		public const int Button = 0;

		// Token: 0x0402463C RID: 149052
		public const int ButtonText = 1;

		// Token: 0x0402463D RID: 149053
		public const int RedDot = 2;
	}
}
