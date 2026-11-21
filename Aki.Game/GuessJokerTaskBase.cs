using System;

// Token: 0x020004F0 RID: 1264
public class GuessJokerTaskBase
{
	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x06003E37 RID: 15927 RVA: 0x0016012F File Offset: 0x0015E32F
	public bool IsExecuting
	{
		get
		{
			return this.IsExecute;
		}
	}

	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x06003E38 RID: 15928 RVA: 0x00160137 File Offset: 0x0015E337
	public bool IsWaitingForPlayerInput
	{
		get
		{
			return this.TaskType == EGuessJokerTaskType.Interactive && this.IsExecuting;
		}
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x0016014A File Offset: 0x0015E34A
	public GuessJokerTaskBase()
	{
		this.TaskId = GuessJokerTaskBase.SelfIncrementId++;
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x00160165 File Offset: 0x0015E365
	public void Execute()
	{
		this.IsExecute = true;
		this.OnAddEventListener();
		this.OnExecute();
	}

	// Token: 0x06003E3B RID: 15931 RVA: 0x0016017C File Offset: 0x0015E37C
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

	// Token: 0x06003E3C RID: 15932 RVA: 0x001601DF File Offset: 0x0015E3DF
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

	// Token: 0x06003E3D RID: 15933 RVA: 0x001601FD File Offset: 0x0015E3FD
	public void FinishTask()
	{
		this.Complete();
	}

	// Token: 0x06003E3E RID: 15934 RVA: 0x00160205 File Offset: 0x0015E405
	public bool IsFinished()
	{
		return this.IsFinishedInternal;
	}

	// Token: 0x06003E3F RID: 15935 RVA: 0x0016020D File Offset: 0x0015E40D
	public bool CanSendRequest()
	{
		return this.TaskType == EGuessJokerTaskType.Interactive && !this.IsRequestFinished;
	}

	// Token: 0x06003E40 RID: 15936 RVA: 0x00160223 File Offset: 0x0015E423
	public void SetRequestFinished(bool isFinished)
	{
		if (this.TaskType == EGuessJokerTaskType.Interactive)
		{
			this.IsRequestFinished = isFinished;
		}
	}

	// Token: 0x06003E41 RID: 15937 RVA: 0x00160235 File Offset: 0x0015E435
	protected virtual void OnExecute()
	{
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x00160237 File Offset: 0x0015E437
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06003E43 RID: 15939 RVA: 0x00160239 File Offset: 0x0015E439
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x0016023B File Offset: 0x0015E43B
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x0016023D File Offset: 0x0015E43D
	protected virtual void OnComplete()
	{
	}

	// Token: 0x040031BF RID: 12735
	public readonly int TaskId;

	// Token: 0x040031C0 RID: 12736
	[StaticVariableRuleIgnore]
	private static int SelfIncrementId = 0;

	// Token: 0x040031C1 RID: 12737
	private bool IsExecute;

	// Token: 0x040031C2 RID: 12738
	private bool IsFinishedInternal;

	// Token: 0x040031C3 RID: 12739
	protected float FinishTime;

	// Token: 0x040031C4 RID: 12740
	private float CurTime;

	// Token: 0x040031C5 RID: 12741
	protected EGuessJokerTaskType TaskType;

	// Token: 0x040031C6 RID: 12742
	protected bool IsRequestFinished;
}
