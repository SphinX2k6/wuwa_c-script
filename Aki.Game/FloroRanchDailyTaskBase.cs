using System;
using System.Runtime.CompilerServices;

// Token: 0x02001000 RID: 4096
public class FloroRanchDailyTaskBase : IStaticVariableResetter
{
	// Token: 0x0600A34F RID: 41807 RVA: 0x002FECFB File Offset: 0x002FCEFB
	static FloroRanchDailyTaskBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchDailyTaskBase.CreateStaticDefaultValue), new Action(FloroRanchDailyTaskBase.ResetStaticDefaultValue));
	}

	// Token: 0x17001171 RID: 4465
	// (get) Token: 0x0600A350 RID: 41808 RVA: 0x002FED1A File Offset: 0x002FCF1A
	public bool IsExecuting
	{
		get
		{
			return this.IsExecute;
		}
	}

	// Token: 0x17001172 RID: 4466
	// (get) Token: 0x0600A351 RID: 41809 RVA: 0x002FED22 File Offset: 0x002FCF22
	public bool IsPause
	{
		get
		{
			return this.IsPauseInternal;
		}
	}

	// Token: 0x0600A352 RID: 41810 RVA: 0x002FED2A File Offset: 0x002FCF2A
	public static void CreateStaticDefaultValue()
	{
		FloroRanchDailyTaskBase.SelfIncrementId = 0;
	}

	// Token: 0x0600A353 RID: 41811 RVA: 0x002FED32 File Offset: 0x002FCF32
	public static void ResetStaticDefaultValue()
	{
		FloroRanchDailyTaskBase.SelfIncrementId = 0;
	}

	// Token: 0x0600A354 RID: 41812 RVA: 0x002FED3A File Offset: 0x002FCF3A
	public FloroRanchDailyTaskBase()
	{
		this.TaskId = FloroRanchDailyTaskBase.SelfIncrementId++;
	}

	// Token: 0x0600A355 RID: 41813 RVA: 0x002FED55 File Offset: 0x002FCF55
	public void BindCompleteCallBack([Nullable(new byte[]
	{
		1,
		2
	})] Action<int, Action> completeCallBack)
	{
		this.CompleteCallBack = completeCallBack;
	}

	// Token: 0x0600A356 RID: 41814 RVA: 0x002FED5E File Offset: 0x002FCF5E
	public void Execute()
	{
		this.IsExecute = true;
		this.OnAddEventListener();
		this.OnExecute();
	}

	// Token: 0x0600A357 RID: 41815 RVA: 0x002FED73 File Offset: 0x002FCF73
	public void Tick(float deltaTime)
	{
		if (!this.IsExecute)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x0600A358 RID: 41816 RVA: 0x002FED85 File Offset: 0x002FCF85
	[NullableContext(2)]
	public void Complete(Action preExcuteNextCallback = null)
	{
		if (!this.IsExecute)
		{
			return;
		}
		this.IsExecute = false;
		this.OnRemoveEventListener();
		this.OnComplete();
		this.CompleteCallBack(this.TaskId, preExcuteNextCallback);
	}

	// Token: 0x0600A359 RID: 41817 RVA: 0x002FEDB5 File Offset: 0x002FCFB5
	[NullableContext(2)]
	public void AsyncComplete(Action preExcuteNextCallback = null)
	{
		this.IsDataCompleteInternal = true;
		if (this.IsExecute && !this.IsPauseInternal)
		{
			this.Complete(preExcuteNextCallback);
		}
	}

	// Token: 0x0600A35A RID: 41818 RVA: 0x002FEDD5 File Offset: 0x002FCFD5
	public void ForceFinish()
	{
		if (!this.IsExecute)
		{
			return;
		}
		this.IsExecute = false;
		this.OnRemoveEventListener();
	}

	// Token: 0x0600A35B RID: 41819 RVA: 0x002FEDED File Offset: 0x002FCFED
	private bool CanComplete()
	{
		return this.IsExecute && !this.IsPauseInternal && this.IsDataCompleteInternal;
	}

	// Token: 0x0600A35C RID: 41820 RVA: 0x002FEE08 File Offset: 0x002FD008
	public void Pause()
	{
		if (!this.IsExecute)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "Pause 任务未执行 只能暂停正在执行的任务！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", this.TaskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.IsExecute = false;
		this.IsPauseInternal = true;
	}

	// Token: 0x0600A35D RID: 41821 RVA: 0x002FEE60 File Offset: 0x002FD060
	public void Resume()
	{
		if (!this.IsPauseInternal)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "Resume 任务未暂停 不能恢复！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", this.TaskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.IsExecute = true;
		this.IsPauseInternal = false;
		if (this.CanComplete())
		{
			this.Complete(null);
		}
	}

	// Token: 0x0600A35E RID: 41822 RVA: 0x002FEEC7 File Offset: 0x002FD0C7
	protected virtual void OnExecute()
	{
	}

	// Token: 0x0600A35F RID: 41823 RVA: 0x002FEEC9 File Offset: 0x002FD0C9
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600A360 RID: 41824 RVA: 0x002FEECB File Offset: 0x002FD0CB
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x0600A361 RID: 41825 RVA: 0x002FEECD File Offset: 0x002FD0CD
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600A362 RID: 41826 RVA: 0x002FEECF File Offset: 0x002FD0CF
	protected virtual void OnComplete()
	{
	}

	// Token: 0x04006022 RID: 24610
	public readonly int TaskId;

	// Token: 0x04006023 RID: 24611
	private static int SelfIncrementId;

	// Token: 0x04006024 RID: 24612
	private bool IsExecute;

	// Token: 0x04006025 RID: 24613
	private bool IsPauseInternal;

	// Token: 0x04006026 RID: 24614
	private bool IsDataCompleteInternal;

	// Token: 0x04006027 RID: 24615
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private Action<int, Action> CompleteCallBack;
}
