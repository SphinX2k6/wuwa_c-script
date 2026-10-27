using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B41 RID: 6977
public class FloroRanchDailyTaskBase : IStaticVariableResetter
{
	// Token: 0x0600CF3E RID: 53054 RVA: 0x002F3C23 File Offset: 0x002F1E23
	static FloroRanchDailyTaskBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchDailyTaskBase.CreateStaticDefaultValue), new Action(FloroRanchDailyTaskBase.ResetStaticDefaultValue));
	}

	// Token: 0x1700114C RID: 4428
	// (get) Token: 0x0600CF3F RID: 53055 RVA: 0x002F3C42 File Offset: 0x002F1E42
	public bool IsExecuting
	{
		get
		{
			return this.IsExecute;
		}
	}

	// Token: 0x1700114D RID: 4429
	// (get) Token: 0x0600CF40 RID: 53056 RVA: 0x002F3C4A File Offset: 0x002F1E4A
	public bool IsPause
	{
		get
		{
			return this.IsPauseInternal;
		}
	}

	// Token: 0x0600CF41 RID: 53057 RVA: 0x002F3C52 File Offset: 0x002F1E52
	public static void CreateStaticDefaultValue()
	{
		FloroRanchDailyTaskBase.SelfIncrementId = 0;
	}

	// Token: 0x0600CF42 RID: 53058 RVA: 0x002F3C5A File Offset: 0x002F1E5A
	public static void ResetStaticDefaultValue()
	{
		FloroRanchDailyTaskBase.SelfIncrementId = 0;
	}

	// Token: 0x0600CF43 RID: 53059 RVA: 0x002F3C62 File Offset: 0x002F1E62
	public FloroRanchDailyTaskBase()
	{
		this.TaskId = FloroRanchDailyTaskBase.SelfIncrementId++;
	}

	// Token: 0x0600CF44 RID: 53060 RVA: 0x002F3C7D File Offset: 0x002F1E7D
	public void BindCompleteCallBack([Nullable(new byte[]
	{
		1,
		2
	})] Action<int, Action> completeCallBack)
	{
		this.CompleteCallBack = completeCallBack;
	}

	// Token: 0x0600CF45 RID: 53061 RVA: 0x002F3C86 File Offset: 0x002F1E86
	public void Execute()
	{
		this.IsExecute = true;
		this.OnAddEventListener();
		this.OnExecute();
	}

	// Token: 0x0600CF46 RID: 53062 RVA: 0x002F3C9B File Offset: 0x002F1E9B
	public void Tick(float deltaTime)
	{
		if (!this.IsExecute)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x0600CF47 RID: 53063 RVA: 0x002F3CAD File Offset: 0x002F1EAD
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

	// Token: 0x0600CF48 RID: 53064 RVA: 0x002F3CDD File Offset: 0x002F1EDD
	[NullableContext(2)]
	public void AsyncComplete(Action preExcuteNextCallback = null)
	{
		this.IsDataCompleteInternal = true;
		if (this.IsExecute && !this.IsPauseInternal)
		{
			this.Complete(preExcuteNextCallback);
		}
	}

	// Token: 0x0600CF49 RID: 53065 RVA: 0x002F3CFD File Offset: 0x002F1EFD
	public void ForceFinish()
	{
		if (!this.IsExecute)
		{
			return;
		}
		this.IsExecute = false;
		this.OnRemoveEventListener();
	}

	// Token: 0x0600CF4A RID: 53066 RVA: 0x002F3D15 File Offset: 0x002F1F15
	private bool CanComplete()
	{
		return this.IsExecute && !this.IsPauseInternal && this.IsDataCompleteInternal;
	}

	// Token: 0x0600CF4B RID: 53067 RVA: 0x002F3D30 File Offset: 0x002F1F30
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

	// Token: 0x0600CF4C RID: 53068 RVA: 0x002F3D88 File Offset: 0x002F1F88
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

	// Token: 0x0600CF4D RID: 53069 RVA: 0x002F3DEF File Offset: 0x002F1FEF
	protected virtual void OnExecute()
	{
	}

	// Token: 0x0600CF4E RID: 53070 RVA: 0x002F3DF1 File Offset: 0x002F1FF1
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600CF4F RID: 53071 RVA: 0x002F3DF3 File Offset: 0x002F1FF3
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x0600CF50 RID: 53072 RVA: 0x002F3DF5 File Offset: 0x002F1FF5
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600CF51 RID: 53073 RVA: 0x002F3DF7 File Offset: 0x002F1FF7
	protected virtual void OnComplete()
	{
	}

	// Token: 0x04005F53 RID: 24403
	public readonly int TaskId;

	// Token: 0x04005F54 RID: 24404
	private static int SelfIncrementId;

	// Token: 0x04005F55 RID: 24405
	private bool IsExecute;

	// Token: 0x04005F56 RID: 24406
	private bool IsPauseInternal;

	// Token: 0x04005F57 RID: 24407
	private bool IsDataCompleteInternal;

	// Token: 0x04005F58 RID: 24408
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private Action<int, Action> CompleteCallBack;
}
