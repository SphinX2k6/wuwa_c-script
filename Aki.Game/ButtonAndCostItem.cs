using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C9F RID: 3231
[NullableContext(1)]
[Nullable(0)]
public class ButtonAndCostItem : UiPanelBase
{
	// Token: 0x060086D3 RID: 34515 RVA: 0x002918E4 File Offset: 0x0028FAE4
	public UniTask Init(UUIItem uiItem)
	{
		ButtonAndCostItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.uiItem = uiItem;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ButtonAndCostItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060086D4 RID: 34516 RVA: 0x00291930 File Offset: 0x0028FB30
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060086D5 RID: 34517 RVA: 0x00291A39 File Offset: 0x0028FC39
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060086D6 RID: 34518 RVA: 0x00291A41 File Offset: 0x0028FC41
	private void ButtonClick()
	{
		Action<int> buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction(this.Data);
	}

	// Token: 0x060086D7 RID: 34519 RVA: 0x00291A5C File Offset: 0x0028FC5C
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent btn = this.GetBtn();
		if (btn != null)
		{
			btn.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x060086D8 RID: 34520 RVA: 0x00291A7A File Offset: 0x0028FC7A
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x060086D9 RID: 34521 RVA: 0x00291A8F File Offset: 0x0028FC8F
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x060086DA RID: 34522 RVA: 0x00291AA4 File Offset: 0x0028FCA4
	public void SetShowText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.ShowTextNew(text);
	}

	// Token: 0x060086DB RID: 34523 RVA: 0x00291AB8 File Offset: 0x0028FCB8
	public void SetData(int data)
	{
		this.Data = data;
	}

	// Token: 0x060086DC RID: 34524 RVA: 0x00291AC1 File Offset: 0x0028FCC1
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent btn = this.GetBtn();
		if (btn == null)
		{
			return;
		}
		btn.SetSelfInteractive(state);
	}

	// Token: 0x060086DD RID: 34525 RVA: 0x00291AD4 File Offset: 0x0028FCD4
	public void SetFunction(Action<int> buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x060086DE RID: 34526 RVA: 0x00291ADD File Offset: 0x0028FCDD
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x060086DF RID: 34527 RVA: 0x00291AEC File Offset: 0x0028FCEC
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x060086E0 RID: 34528 RVA: 0x00291B30 File Offset: 0x0028FD30
	public void BindGivenUid(ERedDotName redDotName, int uId)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x060086E1 RID: 34529 RVA: 0x00291B6C File Offset: 0x0028FD6C
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
		}
	}

	// Token: 0x060086E2 RID: 34530 RVA: 0x00291B98 File Offset: 0x0028FD98
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x060086E3 RID: 34531 RVA: 0x00291BC8 File Offset: 0x0028FDC8
	[NullableContext(2)]
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x060086E4 RID: 34532 RVA: 0x00291BD4 File Offset: 0x0028FDD4
	public void UpdateCostIcon(string path)
	{
		UUITexture texture = base.GetTexture(3);
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x060086E5 RID: 34533 RVA: 0x00291BFB File Offset: 0x0028FDFB
	public void UpdateCostNum(int num)
	{
		UUIText text = base.GetText(4);
		if (text == null)
		{
			return;
		}
		text.SetText(num.ToString(), true);
	}

	// Token: 0x060086E6 RID: 34534 RVA: 0x00291C18 File Offset: 0x0028FE18
	public void UpdateCostColor(bool useChangeColor)
	{
		UUIText text = base.GetText(4);
		if (text != null)
		{
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}
	}

	// Token: 0x040051BD RID: 20925
	private int Data;

	// Token: 0x040051BE RID: 20926
	private ERedDotName? RedDotName;

	// Token: 0x040051BF RID: 20927
	[Nullable(2)]
	private Action<int> ButtonFunction;

	// Token: 0x02006F58 RID: 28504
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x0402462C RID: 149036
		public const int Button = 0;

		// Token: 0x0402462D RID: 149037
		public const int ButtonText = 1;

		// Token: 0x0402462E RID: 149038
		public const int RedDot = 2;

		// Token: 0x0402462F RID: 149039
		public const int TextureCost = 3;

		// Token: 0x04024630 RID: 149040
		public const int TextCost = 4;
	}
}
