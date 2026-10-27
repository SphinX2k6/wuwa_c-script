using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001D23 RID: 7459
public class SurvivorsRogueTipsPanelBase : UiPanelBase
{
	// Token: 0x0600E1D9 RID: 57817 RVA: 0x00350A71 File Offset: 0x0034EC71
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

	// Token: 0x0600E1DA RID: 57818 RVA: 0x00350A9C File Offset: 0x0034EC9C
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E1DB RID: 57819 RVA: 0x00350AD5 File Offset: 0x0034ECD5
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E1DC RID: 57820 RVA: 0x00350B0E File Offset: 0x0034ED0E
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600E1DD RID: 57821 RVA: 0x00350B10 File Offset: 0x0034ED10
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600E1DE RID: 57822 RVA: 0x00350B12 File Offset: 0x0034ED12
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.PauseSequence();
		}
	}

	// Token: 0x0600E1DF RID: 57823 RVA: 0x00350B2C File Offset: 0x0034ED2C
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.SurvivorsRogueExitView)
		{
			this.SequencePlayer.ResumeSequence();
		}
	}

	// Token: 0x0600E1E0 RID: 57824 RVA: 0x00350B48 File Offset: 0x0034ED48
	public virtual void ShowTips()
	{
		base.Show(null);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600E1E1 RID: 57825 RVA: 0x00350B84 File Offset: 0x0034ED84
	public void HideTips()
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x04006876 RID: 26742
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;
}
