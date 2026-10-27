using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002666 RID: 9830
public class QuestViewButton : UiPanelBase
{
	// Token: 0x06014204 RID: 82436 RVA: 0x00515B8C File Offset: 0x00513D8C
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014205 RID: 82437 RVA: 0x00515C32 File Offset: 0x00513E32
	protected override void OnStart()
	{
		this.ButtonClickFunction = (this.OpenParam as Action);
	}

	// Token: 0x06014206 RID: 82438 RVA: 0x00515C48 File Offset: 0x00513E48
	[NullableContext(1)]
	public void SetButtonText(string textTableId, bool bCommonTextTable)
	{
		if (bCommonTextTable)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), textTableId, Array.Empty<object>());
			return;
		}
		string newText = ConfigMultiTextLang.GetLocalTextNew(textTableId, null) ?? textTableId;
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(newText, true);
	}

	// Token: 0x06014207 RID: 82439 RVA: 0x00515C90 File Offset: 0x00513E90
	private void OnButtonClick()
	{
		Action buttonClickFunction = this.ButtonClickFunction;
		if (buttonClickFunction == null)
		{
			return;
		}
		buttonClickFunction();
	}

	// Token: 0x040097AD RID: 38829
	[Nullable(2)]
	private Action ButtonClickFunction;

	// Token: 0x02008CAA RID: 36010
	private class EChildComponent
	{
		// Token: 0x0402DA83 RID: 187011
		public const int Button = 0;

		// Token: 0x0402DA84 RID: 187012
		public const int ButtonText = 1;
	}
}
