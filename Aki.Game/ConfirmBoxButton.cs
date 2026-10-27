using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019DB RID: 6619
[NullableContext(1)]
[Nullable(0)]
public class ConfirmBoxButton : UiPanelBase
{
	// Token: 0x0600C13F RID: 49471 RVA: 0x002B98B0 File Offset: 0x002B7AB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C140 RID: 49472 RVA: 0x002B9956 File Offset: 0x002B7B56
	private void ButtonClick()
	{
		this.CloseView();
	}

	// Token: 0x0600C141 RID: 49473 RVA: 0x002B995E File Offset: 0x002B7B5E
	protected void CloseView()
	{
		if (this.ClickFunction != null)
		{
			this.ClickFunction();
		}
	}

	// Token: 0x0600C142 RID: 49474 RVA: 0x002B9973 File Offset: 0x002B7B73
	public void SetTextById(string textId)
	{
		base.GetText(1).SetText(ConfirmBoxConfig.Instance.GetButtonText(textId), true);
	}

	// Token: 0x0600C143 RID: 49475 RVA: 0x002B998D File Offset: 0x002B7B8D
	public void SetText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x0600C144 RID: 49476 RVA: 0x002B99A0 File Offset: 0x002B7BA0
	public void SetBtnCanClick(bool value)
	{
		UUIInteractionGroup uuiinteractionGroup = this.RootActor.GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
		if (uuiinteractionGroup != null)
		{
			uuiinteractionGroup.SetInteractable(value);
		}
	}

	// Token: 0x0600C145 RID: 49477 RVA: 0x002B99D4 File Offset: 0x002B7BD4
	public void SetTimer(string textId, int delayTime, bool canClickDuringTimer)
	{
		if (!canClickDuringTimer)
		{
			this.SetBtnCanClick(canClickDuringTimer);
		}
		this.DelayTime = delayTime;
		this.SetTimerText(textId);
		this.Timer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.DelayTime--;
			this.SetTimerText(textId);
			if (this.DelayTime <= 0)
			{
				if (canClickDuringTimer)
				{
					this.CloseView();
					return;
				}
				this.SetBtnCanClick(true);
			}
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600C146 RID: 49478 RVA: 0x002B9A4C File Offset: 0x002B7C4C
	private void SetTimerText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, new <>z__ReadOnlySingleElementList<object>((this.DelayTime > 0) ? this.DelayTime.ToString() : ""));
	}

	// Token: 0x0600C147 RID: 49479 RVA: 0x002B9A80 File Offset: 0x002B7C80
	public void SetClickFunction(Action clickFunction)
	{
		this.ClickFunction = clickFunction;
	}

	// Token: 0x0600C148 RID: 49480 RVA: 0x002B9A89 File Offset: 0x002B7C89
	protected override void OnBeforeDestroy()
	{
		if (this.Timer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x04005917 RID: 22807
	[Nullable(2)]
	protected TimerHandle Timer;

	// Token: 0x04005918 RID: 22808
	protected int DelayTime;

	// Token: 0x04005919 RID: 22809
	[Nullable(2)]
	protected Action ClickFunction;

	// Token: 0x02007EFB RID: 32507
	[NullableContext(0)]
	private class EConfirmBoxButtonDefine
	{
		// Token: 0x040297C4 RID: 169924
		public const int Button = 0;

		// Token: 0x040297C5 RID: 169925
		public const int ButtonText = 1;
	}
}
