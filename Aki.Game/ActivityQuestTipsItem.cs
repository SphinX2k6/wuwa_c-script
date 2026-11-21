using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A0B RID: 2571
[NullableContext(1)]
[Nullable(0)]
public class ActivityQuestTipsItem : UiPanelBase
{
	// Token: 0x06007029 RID: 28713 RVA: 0x00226D58 File Offset: 0x00224F58
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

	// Token: 0x0600702A RID: 28714 RVA: 0x00226DFE File Offset: 0x00224FFE
	public void SetContentByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x0600702B RID: 28715 RVA: 0x00226E13 File Offset: 0x00225013
	public void SetContentByText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x0600702C RID: 28716 RVA: 0x00226E23 File Offset: 0x00225023
	public void SetContentVisible(bool bVisible)
	{
		base.GetText(0).SetUIActive(bVisible);
	}

	// Token: 0x0600702D RID: 28717 RVA: 0x00226E32 File Offset: 0x00225032
	private void ButtonClick()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction();
	}

	// Token: 0x0600702E RID: 28718 RVA: 0x00226E44 File Offset: 0x00225044
	public void SetRewardButtonVisible(bool state)
	{
		base.GetItem(1).SetUIActive(state);
	}

	// Token: 0x0600702F RID: 28719 RVA: 0x00226E53 File Offset: 0x00225053
	public void SetRewardButtonFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x04004522 RID: 17698
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02006D1E RID: 27934
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023D21 RID: 146721
		public const int TxtTips = 0;

		// Token: 0x04023D22 RID: 146722
		public const int ButtonGo = 1;
	}
}
