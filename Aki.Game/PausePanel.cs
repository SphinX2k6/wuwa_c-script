using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A0F RID: 10767
public class PausePanel : UiComponentAction
{
	// Token: 0x06016572 RID: 91506 RVA: 0x005A7434 File Offset: 0x005A5634
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

	// Token: 0x06016573 RID: 91507 RVA: 0x005A74E1 File Offset: 0x005A56E1
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.SignalDecodeView, null);
	}

	// Token: 0x06016574 RID: 91508 RVA: 0x005A74F3 File Offset: 0x005A56F3
	private void OnStartAgainBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.OnSignalCatchStartAgain);
	}

	// Token: 0x06016575 RID: 91509 RVA: 0x005A7505 File Offset: 0x005A5705
	private void OnContinueBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.OnSignalCatchContinue);
	}

	// Token: 0x0200904A RID: 36938
	private static class EChildComponent
	{
		// Token: 0x0402EB87 RID: 191367
		public const int LeaveBtn = 0;

		// Token: 0x0402EB88 RID: 191368
		public const int StartAgainBtn = 1;

		// Token: 0x0402EB89 RID: 191369
		public const int ContinueBtn = 2;
	}
}
