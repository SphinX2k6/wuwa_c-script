using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F90 RID: 8080
public class SuccessFinishPanel : UiPanelBase
{
	// Token: 0x06013FD9 RID: 81881 RVA: 0x005D424C File Offset: 0x005D244C
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

	// Token: 0x06013FDA RID: 81882 RVA: 0x005D42B4 File Offset: 0x005D24B4
	private void OnCloseBtnClick()
	{
		string currentGameplayId = SignalDecodeModel.Instance.CurrentGameplayId;
		GeneralLogicTreeController.Instance.RequestFinishUiGameplay(UiGamePlayType.MorseCode, currentGameplayId.ToString());
		UiManager.Instance.CloseView(EUiViewName.SignalDecodeView, null);
	}

	// Token: 0x06013FDB RID: 81883 RVA: 0x005D42ED File Offset: 0x005D24ED
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013FDC RID: 81884 RVA: 0x005D4300 File Offset: 0x005D2500
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

	// Token: 0x06013FDD RID: 81885 RVA: 0x005D4378 File Offset: 0x005D2578
	public void Close()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0400AA60 RID: 43616
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0200829C RID: 33436
	private static class EChildComponent
	{
		// Token: 0x0402A2BC RID: 172732
		public const int LeaveBtn = 0;

		// Token: 0x0402A2BD RID: 172733
		public const int Text = 1;
	}
}
