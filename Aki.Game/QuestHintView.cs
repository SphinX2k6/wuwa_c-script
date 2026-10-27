using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200265E RID: 9822
public class QuestHintView : UiViewBase
{
	// Token: 0x0601418D RID: 82317 RVA: 0x005111DC File Offset: 0x0050F3DC
	[NullableContext(1)]
	public QuestHintView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601418E RID: 82318 RVA: 0x005111E8 File Offset: 0x0050F3E8
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

	// Token: 0x0601418F RID: 82319 RVA: 0x00511293 File Offset: 0x0050F493
	protected override void OnStart()
	{
		this.UiViewSequence.AddSequenceFinishEvent("PopUp", new Action<string>(this.FinishSequenceEvent), false);
	}

	// Token: 0x06014190 RID: 82320 RVA: 0x005112B2 File Offset: 0x0050F4B2
	[NullableContext(1)]
	private void FinishSequenceEvent(string _)
	{
		this.OnPopUpEnd();
	}

	// Token: 0x06014191 RID: 82321 RVA: 0x005112BC File Offset: 0x0050F4BC
	protected override void OnAfterShow()
	{
		this.InitComponent();
		this.UiViewSequence.PlaySequence("PopUp", false, null);
	}

	// Token: 0x06014192 RID: 82322 RVA: 0x005112E9 File Offset: 0x0050F4E9
	private void OnPopUpEnd()
	{
		UiManager.Instance.CloseView(EUiViewName.QuestHintView, null);
	}

	// Token: 0x06014193 RID: 82323 RVA: 0x005112FB File Offset: 0x0050F4FB
	private void InitComponent()
	{
		this.ToggleButton(false);
		this.RootItem.SetAnchorOffsetX(0f);
	}

	// Token: 0x06014194 RID: 82324 RVA: 0x00511314 File Offset: 0x0050F514
	private void ToggleButton(bool inEnable)
	{
		base.GetText(3).SetUIActive(inEnable);
		base.GetSprite(2).SetUIActive(inEnable);
	}

	// Token: 0x02008C99 RID: 35993
	private class EQuestHintChildCom
	{
		// Token: 0x0402DA20 RID: 186912
		public const int QuestDesc = 0;

		// Token: 0x0402DA21 RID: 186913
		public const int QuestHintType = 1;

		// Token: 0x0402DA22 RID: 186914
		public const int ButtonHint = 2;

		// Token: 0x0402DA23 RID: 186915
		public const int ButtonDesc = 3;
	}
}
