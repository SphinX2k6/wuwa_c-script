using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200154D RID: 5453
[NullableContext(1)]
[Nullable(0)]
public class ActivityButtonItem : UiPanelBase
{
	// Token: 0x06009BDA RID: 39898 RVA: 0x0021BC14 File Offset: 0x00219E14
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

	// Token: 0x06009BDB RID: 39899 RVA: 0x0021BCDB File Offset: 0x00219EDB
	protected override void OnBeforeDestroy()
	{
		this.ButtonFunction = null;
		this.ExtraButtonFunctionSet.Clear();
		this.UnBindGivenUid(this.RedDotUid);
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x0021BCFC File Offset: 0x00219EFC
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

	// Token: 0x06009BDD RID: 39901 RVA: 0x0021BD78 File Offset: 0x00219F78
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

	// Token: 0x06009BDE RID: 39902 RVA: 0x0021BDDC File Offset: 0x00219FDC
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		base.GetButton(0).AllowEventBubbleUp = value;
	}

	// Token: 0x06009BDF RID: 39903 RVA: 0x0021BDEC File Offset: 0x00219FEC
	public void SetText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(text, true);
		}
	}

	// Token: 0x06009BE0 RID: 39904 RVA: 0x0021BE0C File Offset: 0x0021A00C
	public void SetLocalTextNew(string textId, params object[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06009BE1 RID: 39905 RVA: 0x0021BE21 File Offset: 0x0021A021
	public void SetShowText(string text)
	{
		base.GetText(1).ShowTextNew(text);
	}

	// Token: 0x06009BE2 RID: 39906 RVA: 0x0021BE30 File Offset: 0x0021A030
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x06009BE3 RID: 39907 RVA: 0x0021BE44 File Offset: 0x0021A044
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x0021BE4D File Offset: 0x0021A04D
	public void SetExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Add(buttonFunction);
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x0021BE5C File Offset: 0x0021A05C
	public void DeleteExtraFunction(Action buttonFunction)
	{
		this.ExtraButtonFunctionSet.Remove(buttonFunction);
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x0021BE6B File Offset: 0x0021A06B
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(2).SetUIActive(bVisible);
	}

	// Token: 0x06009BE7 RID: 39911 RVA: 0x0021BE7C File Offset: 0x0021A07C
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

	// Token: 0x06009BE8 RID: 39912 RVA: 0x0021BEC3 File Offset: 0x0021A0C3
	public void UnBindGivenUid(int uId)
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), uId);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x06009BE9 RID: 39913 RVA: 0x0021BF02 File Offset: 0x0021A102
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x0400446C RID: 17516
	private ERedDotName? RedDotName;

	// Token: 0x0400446D RID: 17517
	private int RedDotUid;

	// Token: 0x0400446E RID: 17518
	private readonly HashSet<Action> ExtraButtonFunctionSet = new HashSet<Action>();

	// Token: 0x0400446F RID: 17519
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02007B82 RID: 31618
	[NullableContext(0)]
	private class EButtonItemDefine
	{
		// Token: 0x040289AD RID: 166317
		public const int Button = 0;

		// Token: 0x040289AE RID: 166318
		public const int ButtonText = 1;

		// Token: 0x040289AF RID: 166319
		public const int RedDot = 2;
	}
}
