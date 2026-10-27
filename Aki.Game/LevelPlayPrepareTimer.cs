using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;

// Token: 0x02001D9B RID: 7579
public class LevelPlayPrepareTimer : LogicTreeTimerBase
{
	// Token: 0x0600E619 RID: 58905 RVA: 0x003638E2 File Offset: 0x00361AE2
	[NullableContext(1)]
	public LevelPlayPrepareTimer(long treeIncId, string timerType, bool needTick = true, double intervalTime = 20.0) : base(treeIncId, timerType, needTick, intervalTime)
	{
	}

	// Token: 0x0600E61A RID: 58906 RVA: 0x003638F0 File Offset: 0x00361AF0
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		this.TimerEndTime = endTime;
		this.TimerPauseTime = pauseTime;
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.PrepareCountdownPrompt, null, null, null, null, null, null, null, null, false, null);
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E61B RID: 58907 RVA: 0x0036394C File Offset: 0x00361B4C
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

	// Token: 0x0600E61C RID: 58908 RVA: 0x003639C4 File Offset: 0x00361BC4
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.PrepareCountdownFloatTips)
		{
			return;
		}
		this.RequestTimerEnd();
	}

	// Token: 0x0600E61D RID: 58909 RVA: 0x003639DC File Offset: 0x00361BDC
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

	// Token: 0x0600E61E RID: 58910 RVA: 0x00363A28 File Offset: 0x00361C28
	public override double GetRemainTime()
	{
		double val = (this.TimerEndTime - TimeUtil.Instance.GetServerStopTimeStamp()) / 1000.0;
		double val2 = (this.TimerPauseTime != 0.0) ? ((this.TimerEndTime - this.TimerPauseTime) / 1000.0) : -1.0;
		return Math.Max(val, Math.Max(val2, 0.0));
	}

	// Token: 0x04006A74 RID: 27252
	private double TimerEndTime;

	// Token: 0x04006A75 RID: 27253
	private double TimerPauseTime;

	// Token: 0x04006A76 RID: 27254
	private bool RequestedEnd;
}
