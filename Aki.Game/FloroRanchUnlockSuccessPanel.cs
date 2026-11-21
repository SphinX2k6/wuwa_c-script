using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200106D RID: 4205
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchUnlockSuccessPanel : UiPanelBase
{
	// Token: 0x1700118D RID: 4493
	// (get) Token: 0x0600A746 RID: 42822 RVA: 0x003141CC File Offset: 0x003123CC
	// (set) Token: 0x0600A747 RID: 42823 RVA: 0x003141D4 File Offset: 0x003123D4
	public UiBehaviorLevelSequence UiLevelSequence { get; set; }

	// Token: 0x0600A748 RID: 42824 RVA: 0x003141E0 File Offset: 0x003123E0
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

	// Token: 0x0600A749 RID: 42825 RVA: 0x00314286 File Offset: 0x00312486
	protected override void OnBeforeCreate()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x0600A74A RID: 42826 RVA: 0x003142A0 File Offset: 0x003124A0
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

	// Token: 0x0600A74B RID: 42827 RVA: 0x003142EC File Offset: 0x003124EC
	private void OnCloseBtnClick()
	{
		UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
		if (uiLevelSequence == null)
		{
			return;
		}
		uiLevelSequence.PlaySequence("Close", false, null);
	}

	// Token: 0x020072FF RID: 29439
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025711 RID: 153361
		public const int BtnClose = 0;

		// Token: 0x04025712 RID: 153362
		public const int TextDes = 1;
	}
}
