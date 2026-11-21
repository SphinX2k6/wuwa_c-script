using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020011E5 RID: 4581
public class SurvivorsRogueTipsPanelBase : UiPanelBase
{
	// Token: 0x0600B5F6 RID: 46582 RVA: 0x0035C4A1 File Offset: 0x0035A6A1
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.Hide(null);
			}
		}, false);
	}

	// Token: 0x0600B5F7 RID: 46583 RVA: 0x0035C4CC File Offset: 0x0035A6CC
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B5F8 RID: 46584 RVA: 0x0035C505 File Offset: 0x0035A705
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B5F9 RID: 46585 RVA: 0x0035C53E File Offset: 0x0035A73E
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600B5FA RID: 46586 RVA: 0x0035C540 File Offset: 0x0035A740
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600B5FB RID: 46587 RVA: 0x0035C542 File Offset: 0x0035A742
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.PauseSequence();
		}
	}

	// Token: 0x0600B5FC RID: 46588 RVA: 0x0035C55C File Offset: 0x0035A75C
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.ResumeSequence();
		}
	}

	// Token: 0x0600B5FD RID: 46589 RVA: 0x0035C578 File Offset: 0x0035A778
	public virtual void ShowTips()
	{
		base.Show(null);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600B5FE RID: 46590 RVA: 0x0035C5B4 File Offset: 0x0035A7B4
	public void HideTips()
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x04006955 RID: 26965
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;
}
