using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001553 RID: 5459
[NullableContext(1)]
[Nullable(0)]
public class ActivityQuestTipsItem : UiPanelBase
{
	// Token: 0x06009C4B RID: 40011 RVA: 0x0021CFA8 File Offset: 0x0021B1A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009C4C RID: 40012 RVA: 0x0021D04E File Offset: 0x0021B24E
	public void SetContentByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06009C4D RID: 40013 RVA: 0x0021D063 File Offset: 0x0021B263
	public void SetContentByText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x06009C4E RID: 40014 RVA: 0x0021D073 File Offset: 0x0021B273
	public void SetContentVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x06009C4F RID: 40015 RVA: 0x0021D082 File Offset: 0x0021B282
	private void ButtonClick()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction();
	}

	// Token: 0x06009C50 RID: 40016 RVA: 0x0021D094 File Offset: 0x0021B294
	public void SetRewardButtonVisible(bool state)
	{
		base.GetItem(1).SetUIActive(state);
	}

	// Token: 0x06009C51 RID: 40017 RVA: 0x0021D0A3 File Offset: 0x0021B2A3
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x0400447C RID: 17532
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02007B93 RID: 31635
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040289E6 RID: 166374
		public const int TxtTips = 0;

		// Token: 0x040289E7 RID: 166375
		public const int ButtonGo = 1;
	}
}
