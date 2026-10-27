using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A0E RID: 10766
public class FailedFinishPanel : UiPanelBase
{
	// Token: 0x0601656A RID: 91498 RVA: 0x005A7254 File Offset: 0x005A5454
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

	// Token: 0x0601656B RID: 91499 RVA: 0x005A7315 File Offset: 0x005A5515
	private void OnCloseBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.SignalDecodeView, null);
	}

	// Token: 0x0601656C RID: 91500 RVA: 0x005A7327 File Offset: 0x005A5527
	private void OnStartAgainBtnClick()
	{
		EventSystem.Instance.Emit(EEventName.OnSignalCatchStartAgain);
		this.Close();
	}

	// Token: 0x0601656D RID: 91501 RVA: 0x005A7340 File Offset: 0x005A5540
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

	// Token: 0x0601656E RID: 91502 RVA: 0x005A73BC File Offset: 0x005A55BC
	public void Open()
	{
		base.SetUiActive(true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0601656F RID: 91503 RVA: 0x005A73EC File Offset: 0x005A55EC
	public void Close()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06016570 RID: 91504 RVA: 0x005A7414 File Offset: 0x005A5614
	[NullableContext(1)]
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			base.SetUiActive(false);
		}
	}

	// Token: 0x0400A62E RID: 42542
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02009049 RID: 36937
	private static class EChildComponent
	{
		// Token: 0x0402EB82 RID: 191362
		public const int CloseBtn = 0;

		// Token: 0x0402EB83 RID: 191363
		public const int StartAgainBtn = 1;

		// Token: 0x0402EB84 RID: 191364
		public const int CloseBtnText = 2;

		// Token: 0x0402EB85 RID: 191365
		public const int TipsText = 3;

		// Token: 0x0402EB86 RID: 191366
		public const int DecodeFailedText = 4;
	}
}
