using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A15 RID: 10773
public class SuccessFinishPanel : UiPanelBase
{
	// Token: 0x060165D2 RID: 91602 RVA: 0x005A9274 File Offset: 0x005A7474
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
		};
	}

	// Token: 0x060165D3 RID: 91603 RVA: 0x005A92DC File Offset: 0x005A74DC
	private void OnCloseBtnClick()
	{
		string currentGameplayId = SignalDecodeModel.Instance.CurrentGameplayId;
		GeneralLogicTreeController.Instance.RequestFinishUiGameplay(UiGamePlayType.MorseCode, currentGameplayId.ToString());
		UiManager.Instance.CloseView(EUiViewName.SignalDecodeView, null);
	}

	// Token: 0x060165D4 RID: 91604 RVA: 0x005A9315 File Offset: 0x005A7515
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x060165D5 RID: 91605 RVA: 0x005A9328 File Offset: 0x005A7528
	public void Open()
	{
		string textTableId = (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.Send) ? "SignalSendSuccess" : "SignalReceiveSuccess";
		if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
		{
			textTableId = "SignalMusicSucceedTips";
		}
		LguiUtil.Instance.SetLocalText(base.GetText(1), textTableId, Array.Empty<object>());
		base.SetUiActive(true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x060165D6 RID: 91606 RVA: 0x005A93A0 File Offset: 0x005A75A0
	public void Close()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0400A676 RID: 42614
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02009055 RID: 36949
	private static class EChildComponent
	{
		// Token: 0x0402EBC4 RID: 191428
		public const int LeaveBtn = 0;

		// Token: 0x0402EBC5 RID: 191429
		public const int Text = 1;
	}
}
