using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D9A RID: 7578
[NullableContext(1)]
[Nullable(0)]
public class FailRangeTimer : LogicTreeTimerBase
{
	// Token: 0x0600E611 RID: 58897 RVA: 0x00363764 File Offset: 0x00361964
	public FailRangeTimer(long treeIncId, string timerType, double intervalTime) : base(treeIncId, timerType, true, intervalTime)
	{
	}

	// Token: 0x0600E612 RID: 58898 RVA: 0x0036377B File Offset: 0x0036197B
	public override void Destroy()
	{
		this.ProcessList.Clear();
		UiManager.Instance.CloseView(EUiViewName.QuestFailRangeTipsView, new Action<bool>(this.FinishCallbackForEnd));
		EventSystem.Instance.Emit(EEventName.FailRangeTimerEndShow);
		base.Destroy();
	}

	// Token: 0x0600E613 RID: 58899 RVA: 0x003637B9 File Offset: 0x003619B9
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		this.ProcessList.Add(new StartShowProcess(endTime));
	}

	// Token: 0x0600E614 RID: 58900 RVA: 0x003637CC File Offset: 0x003619CC
	public override void EndShowTimer()
	{
		this.ProcessList.Add(new EndShowProcess());
	}

	// Token: 0x0600E615 RID: 58901 RVA: 0x003637E0 File Offset: 0x003619E0
	protected override void OnTick(float delta)
	{
		if (this.ProcessList.Count == 0)
		{
			return;
		}
		if (this.CurProcess != null)
		{
			return;
		}
		this.CurProcess = this.ProcessList[0];
		EProcessType processType = this.CurProcess.ProcessType;
		if (processType == EProcessType.StartShow)
		{
			EventSystem.Instance.Emit(EEventName.FailRangeTimerStartShow);
			StartShowProcess startShowProcess = (StartShowProcess)this.CurProcess;
			UiManager.Instance.OpenView(EUiViewName.QuestFailRangeTipsView, startShowProcess.EndTime, new TOpenViewCallBack(this.FinishCallbackForStart));
			return;
		}
		if (processType != EProcessType.EndShow)
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.QuestFailRangeTipsView, new Action<bool>(this.FinishCallbackForEnd));
		EventSystem.Instance.Emit(EEventName.FailRangeTimerEndShow);
	}

	// Token: 0x0600E616 RID: 58902 RVA: 0x00363898 File Offset: 0x00361A98
	private void FinishCallbackForStart(bool success, int viewId)
	{
		this.FinishCallbackImpl(success);
	}

	// Token: 0x0600E617 RID: 58903 RVA: 0x003638A1 File Offset: 0x00361AA1
	private void FinishCallbackForEnd(bool success)
	{
		this.FinishCallbackImpl(success);
	}

	// Token: 0x0600E618 RID: 58904 RVA: 0x003638AC File Offset: 0x00361AAC
	private void FinishCallbackImpl(bool success)
	{
		if (this.CurProcess != null)
		{
			this.CurProcess.Finished = true;
			this.CurProcess = null;
		}
		PendingProcess pendingProcess;
		this.ProcessList.TryShift(out pendingProcess);
	}

	// Token: 0x04006A72 RID: 27250
	private readonly List<PendingProcess> ProcessList = new List<PendingProcess>();

	// Token: 0x04006A73 RID: 27251
	[Nullable(2)]
	private PendingProcess CurProcess;
}
