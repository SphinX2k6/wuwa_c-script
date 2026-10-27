using System;

// Token: 0x0200103C RID: 4156
public class GuessJokerTaskBase
{
	// Token: 0x17000897 RID: 2199
	// (get) Token: 0x06006AA2 RID: 27298 RVA: 0x00157807 File Offset: 0x00155A07
	public bool IsExecuting
	{
		get
		{
			return this.IsExecute;
		}
	}

	// Token: 0x17000898 RID: 2200
	// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x0015780F File Offset: 0x00155A0F
	public bool IsWaitingForPlayerInput
	{
		get
		{
			return this.TaskType == EGuessJokerTaskType.Interactive && this.IsExecuting;
		}
	}

	// Token: 0x06006AA4 RID: 27300 RVA: 0x00157822 File Offset: 0x00155A22
	public GuessJokerTaskBase()
	{
		this.TaskId = GuessJokerTaskBase.SelfIncrementId++;
	}

	// Token: 0x06006AA5 RID: 27301 RVA: 0x0015783D File Offset: 0x00155A3D
	public void Execute()
	{
		this.IsExecute = true;
		this.OnAddEventListener();
		this.OnExecute();
	}

	// Token: 0x06006AA6 RID: 27302 RVA: 0x00157854 File Offset: 0x00155A54
	public void Tick(float deltaTime)
	{
		if (!this.IsExecute)
		{
			return;
		}
		if (this.IsWaitingForPlayerInput && this.FinishTime == 0f)
		{
			return;
		}
		if (this.FinishTime > 0f)
		{
			this.CurTime += deltaTime;
			if (this.CurTime >= this.FinishTime)
			{
				this.Complete();
				return;
			}
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x06006AA7 RID: 27303 RVA: 0x001578B7 File Offset: 0x00155AB7
	private void Complete()
	{
		if (!this.IsExecute)
		{
			return;
		}
		this.OnRemoveEventListener();
		this.OnComplete();
		this.IsFinishedInternal = true;
	}

	// Token: 0x06006AA8 RID: 27304 RVA: 0x001578D5 File Offset: 0x00155AD5
	public void FinishTask()
	{
		this.Complete();
	}

	// Token: 0x06006AA9 RID: 27305 RVA: 0x001578DD File Offset: 0x00155ADD
	public bool IsFinished()
	{
		return this.IsFinishedInternal;
	}

	// Token: 0x06006AAA RID: 27306 RVA: 0x001578E5 File Offset: 0x00155AE5
	public bool CanSendRequest()
	{
		return this.TaskType == EGuessJokerTaskType.Interactive && !this.IsRequestFinished;
	}

	// Token: 0x06006AAB RID: 27307 RVA: 0x001578FB File Offset: 0x00155AFB
	public void SetRequestFinished(bool isFinished)
	{
		if (this.TaskType == EGuessJokerTaskType.Interactive)
		{
			this.IsRequestFinished = isFinished;
		}
	}

	// Token: 0x06006AAC RID: 27308 RVA: 0x0015790D File Offset: 0x00155B0D
	protected virtual void OnExecute()
	{
	}

	// Token: 0x06006AAD RID: 27309 RVA: 0x0015790F File Offset: 0x00155B0F
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06006AAE RID: 27310 RVA: 0x00157911 File Offset: 0x00155B11
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x06006AAF RID: 27311 RVA: 0x00157913 File Offset: 0x00155B13
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06006AB0 RID: 27312 RVA: 0x00157915 File Offset: 0x00155B15
	protected virtual void OnComplete()
	{
	}

	// Token: 0x04003126 RID: 12582
	public readonly int TaskId;

	// Token: 0x04003127 RID: 12583
	[StaticVariableRuleIgnore]
	private static int SelfIncrementId = 0;

	// Token: 0x04003128 RID: 12584
	private bool IsExecute;

	// Token: 0x04003129 RID: 12585
	private bool IsFinishedInternal;

	// Token: 0x0400312A RID: 12586
	protected float FinishTime;

	// Token: 0x0400312B RID: 12587
	private float CurTime;

	// Token: 0x0400312C RID: 12588
	protected EGuessJokerTaskType TaskType;

	// Token: 0x0400312D RID: 12589
	protected bool IsRequestFinished;
}
