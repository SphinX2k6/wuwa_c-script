using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8A RID: 8074
public class PausePanel : UiComponentAction
{
	// Token: 0x06013F79 RID: 81785 RVA: 0x005D240C File Offset: 0x005D060C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnStartAgainBtnClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnContinueBtnClick))
		};
	}

	// Token: 0x06013F7A RID: 81786 RVA: 0x005D24B9 File Offset: 0x005D06B9
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.SignalDecodeView, null);
	}

	// Token: 0x06013F7B RID: 81787 RVA: 0x005D24CB File Offset: 0x005D06CB
	private void OnStartAgainBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.OnSignalCatchStartAgain);
	}

	// Token: 0x06013F7C RID: 81788 RVA: 0x005D24DD File Offset: 0x005D06DD
	private void OnContinueBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.OnSignalCatchContinue);
	}

	// Token: 0x02008291 RID: 33425
	private static class EChildComponent
	{
		// Token: 0x0402A27F RID: 172671
		public const int LeaveBtn = 0;

		// Token: 0x0402A280 RID: 172672
		public const int StartAgainBtn = 1;

		// Token: 0x0402A281 RID: 172673
		public const int ContinueBtn = 2;
	}
}
