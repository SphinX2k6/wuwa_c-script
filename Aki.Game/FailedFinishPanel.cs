using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F89 RID: 8073
public class FailedFinishPanel : UiPanelBase
{
	// Token: 0x06013F71 RID: 81777 RVA: 0x005D222C File Offset: 0x005D042C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnStartAgainBtnClick))
		};
	}

	// Token: 0x06013F72 RID: 81778 RVA: 0x005D22ED File Offset: 0x005D04ED
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.SignalDecodeView, null);
	}

	// Token: 0x06013F73 RID: 81779 RVA: 0x005D22FF File Offset: 0x005D04FF
	private void OnStartAgainBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.OnSignalCatchStartAgain);
		this.Close();
	}

	// Token: 0x06013F74 RID: 81780 RVA: 0x005D2318 File Offset: 0x005D0518
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(3), "SignalMusicFailTips2", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(4), "SignalMusicFailTips", Array.Empty<object>());
		}
	}

	// Token: 0x06013F75 RID: 81781 RVA: 0x005D2394 File Offset: 0x005D0594
	public void Open()
	{
		base.SetUiActive(true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x06013F76 RID: 81782 RVA: 0x005D23C4 File Offset: 0x005D05C4
	public void Close()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06013F77 RID: 81783 RVA: 0x005D23EC File Offset: 0x005D05EC
	[NullableContext(1)]
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			base.SetUiActive(false);
		}
	}

	// Token: 0x0400AA18 RID: 43544
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008290 RID: 33424
	private static class EChildComponent
	{
		// Token: 0x0402A27A RID: 172666
		public const int CloseBtn = 0;

		// Token: 0x0402A27B RID: 172667
		public const int StartAgainBtn = 1;

		// Token: 0x0402A27C RID: 172668
		public const int CloseBtnText = 2;

		// Token: 0x0402A27D RID: 172669
		public const int TipsText = 3;

		// Token: 0x0402A27E RID: 172670
		public const int DecodeFailedText = 4;
	}
}
