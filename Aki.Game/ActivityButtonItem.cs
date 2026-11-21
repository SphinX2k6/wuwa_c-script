using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A05 RID: 2565
[NullableContext(1)]
[Nullable(0)]
public class ActivityButtonItem : UiPanelBase
{
	// Token: 0x06006FB8 RID: 28600 RVA: 0x002259C4 File Offset: 0x00223BC4
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

	// Token: 0x06006FB9 RID: 28601 RVA: 0x00225A8B File Offset: 0x00223C8B
	protected override void OnBeforeDestroy()
	{
		this.ButtonFunction = null;
		this.ExtraButtonFunctionSet.Clear();
		this.UnBindGivenUid(this.RedDotUid);
	}

	// Token: 0x06006FBA RID: 28602 RVA: 0x00225AAC File Offset: 0x00223CAC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIButtonComponent button = base.GetButton(0);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
		if (tweakObjectPtr == null)
		{
			return null;
		}
		UUIItem[] array = new UUIItem[2];
		int num = 0;
		TWeakObjectPtr<UUIItem>? tweakObjectPtr2 = tweakObjectPtr;
		array[num] = ((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null);
		int num2 = 1;
		tweakObjectPtr2 = tweakObjectPtr;
		array[num2] = ((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null);
		return array;
	}

	// Token: 0x06006FBB RID: 28603 RVA: 0x00225B28 File Offset: 0x00223D28
	private void ButtonClick()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction != null)
		{
			buttonFunction();
		}
		foreach (Action action in this.ExtraButtonFunctionSet)
		{
			action();
		}
	}

	// Token: 0x06006FBC RID: 28604 RVA: 0x00225B8C File Offset: 0x00223D8C
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		base.GetButton(0).AllowEventBubbleUp = value;
	}

	// Token: 0x06006FBD RID: 28605 RVA: 0x00225B9C File Offset: 0x00223D9C
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(text, true);
		}
	}

	// Token: 0x06006FBE RID: 28606 RVA: 0x00225BBC File Offset: 0x00223DBC
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06006FBF RID: 28607 RVA: 0x00225BD1 File Offset: 0x00223DD1
	public void SetShowText(string text)
	{
		base.GetText(1).ShowTextNew(text);
	}

	// Token: 0x06006FC0 RID: 28608 RVA: 0x00225BE0 File Offset: 0x00223DE0
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x06006FC1 RID: 28609 RVA: 0x00225BF4 File Offset: 0x00223DF4
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06006FC2 RID: 28610 RVA: 0x00225BFD File Offset: 0x00223DFD
	public void SetExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Add(buttonFunction);
	}

	// Token: 0x06006FC3 RID: 28611 RVA: 0x00225C0C File Offset: 0x00223E0C
	public void DeleteExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Remove(buttonFunction);
	}

	// Token: 0x06006FC4 RID: 28612 RVA: 0x00225C1B File Offset: 0x00223E1B
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06006FC5 RID: 28613 RVA: 0x00225C2C File Offset: 0x00223E2C
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.RedDotName = new ERedDotName?(redDotName);
		this.RedDotUid = uId;
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x06006FC6 RID: 28614 RVA: 0x00225C73 File Offset: 0x00223E73
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x06006FC7 RID: 28615 RVA: 0x00225CB2 File Offset: 0x00223EB2
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x04004512 RID: 17682
	private ERedDotName? RedDotName;

	// Token: 0x04004513 RID: 17683
	private int RedDotUid;

	// Token: 0x04004514 RID: 17684
	private readonly HashSet<Action> ExtraButtonFunctionSet = new HashSet<Action>();

	// Token: 0x04004515 RID: 17685
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02006D0D RID: 27917
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x04023CE8 RID: 146664
		public const int Button = 0;

		// Token: 0x04023CE9 RID: 146665
		public const int ButtonText = 1;

		// Token: 0x04023CEA RID: 146666
		public const int RedDot = 2;
	}
}
