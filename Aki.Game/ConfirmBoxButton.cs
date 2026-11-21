using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E9A RID: 3738
[NullableContext(1)]
[Nullable(0)]
public class ConfirmBoxButton : UiPanelBase
{
	// Token: 0x0600954C RID: 38220 RVA: 0x002C4888 File Offset: 0x002C2A88
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

	// Token: 0x0600954D RID: 38221 RVA: 0x002C492E File Offset: 0x002C2B2E
	private void ButtonClick()
	{
		this.CloseView();
	}

	// Token: 0x0600954E RID: 38222 RVA: 0x002C4936 File Offset: 0x002C2B36
	protected void CloseView()
	{
		if (this.ClickFunction != null)
		{
			this.ClickFunction();
		}
	}

	// Token: 0x0600954F RID: 38223 RVA: 0x002C494B File Offset: 0x002C2B4B
	public void SetTextById(string textId)
	{
		base.GetText(1).SetText(ConfirmBoxConfig.Instance.GetButtonText(textId), true);
	}

	// Token: 0x06009550 RID: 38224 RVA: 0x002C4965 File Offset: 0x002C2B65
	public void SetText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06009551 RID: 38225 RVA: 0x002C4978 File Offset: 0x002C2B78
	public void SetBtnCanClick(bool value)
	{
		UUIInteractionGroup uuiinteractionGroup = this.RootActor.GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup;
		if (uuiinteractionGroup != null)
		{
			uuiinteractionGroup.SetInteractable(value);
		}
	}

	// Token: 0x06009552 RID: 38226 RVA: 0x002C49AC File Offset: 0x002C2BAC
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

	// Token: 0x06009553 RID: 38227 RVA: 0x002C4A24 File Offset: 0x002C2C24
	private void SetTimerText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, new <>z__ReadOnlySingleElementList<object>((this.DelayTime > 0) ? this.DelayTime.ToString() : ""));
	}

	// Token: 0x06009554 RID: 38228 RVA: 0x002C4A58 File Offset: 0x002C2C58
	public void SetClickFunction(Action clickFunction)
	{
		this.ClickFunction = clickFunction;
	}

	// Token: 0x06009555 RID: 38229 RVA: 0x002C4A61 File Offset: 0x002C2C61
	protected override void OnBeforeDestroy()
	{
		if (this.Timer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x040059E6 RID: 23014
	[Nullable(2)]
	protected TimerHandle Timer;

	// Token: 0x040059E7 RID: 23015
	protected int DelayTime;

	// Token: 0x040059E8 RID: 23016
	[Nullable(2)]
	protected Action ClickFunction;

	// Token: 0x0200708A RID: 28810
	[NullableContext(0)]
	private class EConfirmBoxButtonDefine
	{
		// Token: 0x04024B01 RID: 150273
		public const int Button = 0;

		// Token: 0x04024B02 RID: 150274
		public const int ButtonText = 1;
	}
}
