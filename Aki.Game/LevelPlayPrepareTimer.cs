using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

// Token: 0x0200125D RID: 4701
public class LevelPlayPrepareTimer : LogicTreeTimerBase
{
	// Token: 0x0600BA37 RID: 47671 RVA: 0x0036F542 File Offset: 0x0036D742
	[NullableContext(1)]
	public LevelPlayPrepareTimer(long treeIncId, string timerType, bool needTick = true, double intervalTime = 20.0) : base(treeIncId, timerType, needTick, intervalTime)
	{
	}

	// Token: 0x0600BA38 RID: 47672 RVA: 0x0036F550 File Offset: 0x0036D750
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		this.TimerEndTime = endTime;
		this.TimerPauseTime = pauseTime;
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.PrepareCountdownPrompt, null, null, null, null, null, null, null, null, false, null);
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600BA39 RID: 47673 RVA: 0x0036F5AC File Offset: 0x0036D7AC
	public override void EndShowTimer()
	{
		if (EventSystem.Instance.Has(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView)))
		{
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PrepareCountdownFloatTips);
		if (viewByName != null)
		{
			CustomPromise closePromise = viewByName.ClosePromise;
			if (closePromise == null || !closePromise.IsPending)
			{
				UiManager.Instance.CloseView(EUiViewName.PrepareCountdownFloatTips, null);
				return;
			}
		}
	}

	// Token: 0x0600BA3A RID: 47674 RVA: 0x0036F624 File Offset: 0x0036D824
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PrepareCountdownFloatTips)
		{
			return;
		}
		this.RequestTimerEnd();
	}

	// Token: 0x0600BA3B RID: 47675 RVA: 0x0036F63C File Offset: 0x0036D83C
	private void RequestTimerEnd()
	{
		if (this.RequestedEnd)
		{
			return;
		}
		this.RequestedEnd = true;
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		GeneralLogicTreeController.Instance.RequestTimerEnd(this.TreeId, base.TimerType);
	}

	// Token: 0x0600BA3C RID: 47676 RVA: 0x0036F688 File Offset: 0x0036D888
	public override double GetRemainTime()
	{
		double val = (this.TimerEndTime - TimeUtil.Instance.GetServerStopTimeStamp()) / 1000.0;
		double val2 = (this.TimerPauseTime != 0.0) ? ((this.TimerEndTime - this.TimerPauseTime) / 1000.0) : -1.0;
		return Math.Max(val, Math.Max(val2, 0.0));
	}

	// Token: 0x04006B55 RID: 27477
	private double TimerEndTime;

	// Token: 0x04006B56 RID: 27478
	private double TimerPauseTime;

	// Token: 0x04006B57 RID: 27479
	private bool RequestedEnd;
}
