using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BAE RID: 7086
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchUnlockSuccessPanel : UiPanelBase
{
	// Token: 0x17001168 RID: 4456
	// (get) Token: 0x0600D335 RID: 54069 RVA: 0x003090EC File Offset: 0x003072EC
	// (set) Token: 0x0600D336 RID: 54070 RVA: 0x003090F4 File Offset: 0x003072F4
	public UiBehaviorLevelSequence UiLevelSequence { get; set; }

	// Token: 0x0600D337 RID: 54071 RVA: 0x00309100 File Offset: 0x00307300
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D338 RID: 54072 RVA: 0x003091A6 File Offset: 0x003073A6
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600D339 RID: 54073 RVA: 0x003091C0 File Offset: 0x003073C0
	[NullableContext(1)]
	public void RefreshPanel(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		base.SetUiActive(true);
		UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
		if (uiLevelSequence == null)
		{
			return;
		}
		uiLevelSequence.PlaySequence("Start", false, null);
	}

	// Token: 0x0600D33A RID: 54074 RVA: 0x0030920C File Offset: 0x0030740C
	private void OnCloseBtnClick()
	{
		UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
		if (uiLevelSequence == null)
		{
			return;
		}
		uiLevelSequence.PlaySequence("Close", false, null);
	}

	// Token: 0x02008171 RID: 33137
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A3DD RID: 173021
		public const int BtnClose = 0;

		// Token: 0x0402A3DE RID: 173022
		public const int TextDes = 1;
	}
}
