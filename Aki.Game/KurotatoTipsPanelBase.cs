using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001CBF RID: 7359
public class KurotatoTipsPanelBase : UiPanelBase
{
	// Token: 0x0600DE9A RID: 56986 RVA: 0x003416E2 File Offset: 0x0033F8E2
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

	// Token: 0x0600DE9B RID: 56987 RVA: 0x0034170D File Offset: 0x0033F90D
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600DE9C RID: 56988 RVA: 0x00341746 File Offset: 0x0033F946
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600DE9D RID: 56989 RVA: 0x0034177F File Offset: 0x0033F97F
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600DE9E RID: 56990 RVA: 0x00341781 File Offset: 0x0033F981
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600DE9F RID: 56991 RVA: 0x00341783 File Offset: 0x0033F983
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
	}

	// Token: 0x0600DEA0 RID: 56992 RVA: 0x00341785 File Offset: 0x0033F985
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
	}

	// Token: 0x0600DEA1 RID: 56993 RVA: 0x00341788 File Offset: 0x0033F988
	public virtual void ShowTips()
	{
		base.Show(null);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600DEA2 RID: 56994 RVA: 0x003417C4 File Offset: 0x0033F9C4
	public void HideTips()
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0400663B RID: 26171
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;
}
