using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200125C RID: 4700
[NullableContext(1)]
[Nullable(0)]
public class FailRangeTimer : LogicTreeTimerBase
{
	// Token: 0x0600BA2F RID: 47663 RVA: 0x0036F3C4 File Offset: 0x0036D5C4
	public FailRangeTimer(long treeIncId, string timerType, double intervalTime) : base(treeIncId, timerType, true, intervalTime)
	{
	}

	// Token: 0x0600BA30 RID: 47664 RVA: 0x0036F3DB File Offset: 0x0036D5DB
	public override void Destroy()
	{
		this.ProcessList.Clear();
		UiManager.Instance.CloseView(EUiViewName.QuestFailRangeTipsView, new Action<bool>(this.FinishCallbackForEnd));
		EventSystem.Instance.Emit(EEventName.FailRangeTimerEndShow);
		base.Destroy();
	}

	// Token: 0x0600BA31 RID: 47665 RVA: 0x0036F419 File Offset: 0x0036D619
	public override void StartShowTimer(double endTime, double pauseTime)
	{
		this.ProcessList.Add(new StartShowProcess(endTime));
	}

	// Token: 0x0600BA32 RID: 47666 RVA: 0x0036F42C File Offset: 0x0036D62C
	public override void EndShowTimer()
	{
		this.ProcessList.Add(new EndShowProcess());
	}

	// Token: 0x0600BA33 RID: 47667 RVA: 0x0036F440 File Offset: 0x0036D640
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

	// Token: 0x0600BA34 RID: 47668 RVA: 0x0036F4F8 File Offset: 0x0036D6F8
	private void FinishCallbackForStart(bool success, int viewId)
	{
		this.FinishCallbackImpl(success);
	}

	// Token: 0x0600BA35 RID: 47669 RVA: 0x0036F501 File Offset: 0x0036D701
	private void FinishCallbackForEnd(bool success)
	{
		this.FinishCallbackImpl(success);
	}

	// Token: 0x0600BA36 RID: 47670 RVA: 0x0036F50C File Offset: 0x0036D70C
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

	// Token: 0x04006B53 RID: 27475
	private readonly List<PendingProcess> ProcessList = new List<PendingProcess>();

	// Token: 0x04006B54 RID: 27476
	[Nullable(2)]
	private PendingProcess CurProcess;
}
