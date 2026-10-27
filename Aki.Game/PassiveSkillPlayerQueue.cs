using System;
using System.Runtime.CompilerServices;

// Token: 0x02002FD9 RID: 12249
[NullableContext(1)]
[Nullable(0)]
public class PassiveSkillPlayerQueue
{
	// Token: 0x06019F75 RID: 106357 RVA: 0x006CBBFE File Offset: 0x006C9DFE
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

	// Token: 0x06019F76 RID: 106358 RVA: 0x006CBC1E File Offset: 0x006C9E1E
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

	// Token: 0x06019F77 RID: 106359 RVA: 0x006CBC54 File Offset: 0x006C9E54
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

	// Token: 0x06019F78 RID: 106360 RVA: 0x006CBC8C File Offset: 0x006C9E8C
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

	// Token: 0x06019F79 RID: 106361 RVA: 0x006CBCF0 File Offset: 0x006C9EF0
	public void Clear()
	{
		this.ClearTimer();
		this.ActionQueue.Clear();
	}

	// Token: 0x0400C49A RID: 50330
	private readonly Queue<TPassiveSkillQueueCallback> ActionQueue = new Queue<TPassiveSkillQueueCallback>(4);

	// Token: 0x0400C49B RID: 50331
	[Nullable(2)]
	private TimerHandle NextActionTimer;
}
