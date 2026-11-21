using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02001181 RID: 4481
public class KurotatoTipsPanelBase : UiPanelBase
{
	// Token: 0x0600B2B7 RID: 45751 RVA: 0x0034D10A File Offset: 0x0034B30A
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

	// Token: 0x0600B2B8 RID: 45752 RVA: 0x0034D135 File Offset: 0x0034B335
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B2B9 RID: 45753 RVA: 0x0034D16E File Offset: 0x0034B36E
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B2BA RID: 45754 RVA: 0x0034D1A7 File Offset: 0x0034B3A7
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600B2BB RID: 45755 RVA: 0x0034D1A9 File Offset: 0x0034B3A9
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600B2BC RID: 45756 RVA: 0x0034D1AB File Offset: 0x0034B3AB
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
	}

	// Token: 0x0600B2BD RID: 45757 RVA: 0x0034D1AD File Offset: 0x0034B3AD
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
	}

	// Token: 0x0600B2BE RID: 45758 RVA: 0x0034D1B0 File Offset: 0x0034B3B0
	public virtual void ShowTips()
	{
		base.Show(null);
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600B2BF RID: 45759 RVA: 0x0034D1EC File Offset: 0x0034B3EC
	public void HideTips()
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		this.SequencePlayer.StopPlayingSequence(false, true);
		this.SequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0400671A RID: 26394
	[Nullable(1)]
	protected LevelSequencePlayer SequencePlayer;
}
