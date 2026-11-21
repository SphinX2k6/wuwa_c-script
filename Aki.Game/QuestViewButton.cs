using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B51 RID: 6993
public class QuestViewButton : UiPanelBase
{
	// Token: 0x060116E6 RID: 71398 RVA: 0x00524844 File Offset: 0x00522A44
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

	// Token: 0x060116E7 RID: 71399 RVA: 0x005248EA File Offset: 0x00522AEA
	protected override void OnStart()
	{
		this.ButtonClickFunction = (this.OpenParam as Action);
	}

	// Token: 0x060116E8 RID: 71400 RVA: 0x00524900 File Offset: 0x00522B00
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

	// Token: 0x060116E9 RID: 71401 RVA: 0x00524948 File Offset: 0x00522B48
	private void OnButtonClick()
	{
		Action buttonClickFunction = this.ButtonClickFunction;
		if (buttonClickFunction == null)
		{
			return;
		}
		buttonClickFunction();
	}

	// Token: 0x04009905 RID: 39173
	[Nullable(2)]
	private Action ButtonClickFunction;

	// Token: 0x02007E33 RID: 32307
	private class EChildComponent
	{
		// Token: 0x04028D9A RID: 167322
		public const int Button = 0;

		// Token: 0x04028D9B RID: 167323
		public const int ButtonText = 1;
	}
}
