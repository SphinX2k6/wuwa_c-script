using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B49 RID: 6985
public class QuestHintView : UiViewBase
{
	// Token: 0x0601166F RID: 71279 RVA: 0x0051FE94 File Offset: 0x0051E094
	[NullableContext(1)]
	public QuestHintView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011670 RID: 71280 RVA: 0x0051FEA0 File Offset: 0x0051E0A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011671 RID: 71281 RVA: 0x0051FF4B File Offset: 0x0051E14B
	protected override void OnStart()
	{
		this.UiViewSequence.AddSequenceFinishEvent("PopUp", new Action<string>(this.FinishSequenceEvent), false);
	}

	// Token: 0x06011672 RID: 71282 RVA: 0x0051FF6A File Offset: 0x0051E16A
	[NullableContext(1)]
	private void FinishSequenceEvent(string _)
	{
		this.OnPopUpEnd();
	}

	// Token: 0x06011673 RID: 71283 RVA: 0x0051FF74 File Offset: 0x0051E174
	protected override void OnAfterShow()
	{
		this.InitComponent();
		this.UiViewSequence.PlaySequence("PopUp", false, null);
	}

	// Token: 0x06011674 RID: 71284 RVA: 0x0051FFA1 File Offset: 0x0051E1A1
	private void OnPopUpEnd()
	{
		UiManager.Instance.CloseView(EUiViewName.QuestHintView, null);
	}

	// Token: 0x06011675 RID: 71285 RVA: 0x0051FFB3 File Offset: 0x0051E1B3
	private void InitComponent()
	{
		this.ToggleButton(false);
		this.RootItem.SetAnchorOffsetX(0f);
	}

	// Token: 0x06011676 RID: 71286 RVA: 0x0051FFCC File Offset: 0x0051E1CC
	private void ToggleButton(bool inEnable)
	{
		base.GetText(3).SetUIActive(inEnable);
		base.GetSprite(2).SetUIActive(inEnable);
	}

	// Token: 0x02007E22 RID: 32290
	private class EQuestHintChildCom
	{
		// Token: 0x04028D37 RID: 167223
		public const int QuestDesc = 0;

		// Token: 0x04028D38 RID: 167224
		public const int QuestHintType = 1;

		// Token: 0x04028D39 RID: 167225
		public const int ButtonHint = 2;

		// Token: 0x04028D3A RID: 167226
		public const int ButtonDesc = 3;
	}
}
