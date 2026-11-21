using System;
using System.Runtime.CompilerServices;

// Token: 0x0200252E RID: 9518
[NullableContext(1)]
[Nullable(0)]
public class PassiveSkillPlayerQueue
{
	// Token: 0x060178A8 RID: 96424 RVA: 0x006F3A3E File Offset: 0x006F1C3E
	public bool DoActionCheckCd(TPassiveSkillQueueCallback func)
	{
		if (this.NextActionTimer != null)
		{
			this.ActionQueue.Push(func);
			return false;
		}
		this.DoAction(func);
		return true;
	}

	// Token: 0x060178A9 RID: 96425 RVA: 0x006F3A5E File Offset: 0x006F1C5E
	private void ClearTimer()
	{
		if (this.NextActionTimer == null)
		{
			return;
		}
		if (TimerSystem.Instance.Has(this.NextActionTimer))
		{
			TimerSystem.Instance.Remove(this.NextActionTimer);
		}
		this.NextActionTimer = null;
	}

	// Token: 0x060178AA RID: 96426 RVA: 0x006F3A94 File Offset: 0x006F1C94
	private void DoNextAction(float _)
	{
		this.ClearTimer();
		if (this.ActionQueue.Size == 0)
		{
			return;
		}
		TPassiveSkillQueueCallback tpassiveSkillQueueCallback = this.ActionQueue.Pop();
		if (tpassiveSkillQueueCallback != null)
		{
			this.DoAction(tpassiveSkillQueueCallback);
		}
	}

	// Token: 0x060178AB RID: 96427 RVA: 0x006F3ACC File Offset: 0x006F1CCC
	private void DoAction(TPassiveSkillQueueCallback func)
	{
		this.ClearTimer();
		int num = func();
		if (num > 20)
		{
			this.NextActionTimer = TimerSystem.Instance.Delay(new TTimerAction(this.DoNextAction), (float)num, null, null, true, 1f);
			return;
		}
		this.NextActionTimer = TimerSystem.Instance.Next(new TTimerAction(this.DoNextAction), null, null);
	}

	// Token: 0x060178AC RID: 96428 RVA: 0x006F3B30 File Offset: 0x006F1D30
	public void Clear()
	{
		this.ClearTimer();
		this.ActionQueue.Clear();
	}

	// Token: 0x0400C862 RID: 51298
	private readonly Queue<TPassiveSkillQueueCallback> ActionQueue = new Queue<TPassiveSkillQueueCallback>(4);

	// Token: 0x0400C863 RID: 51299
	[Nullable(2)]
	private TimerHandle NextActionTimer;
}
