using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200353F RID: 13631
public abstract class TaskBase
{
	// Token: 0x0601DF07 RID: 122631 RVA: 0x00863C28 File Offset: 0x00861E28
	[NullableContext(2)]
	public TaskBase([Nullable(1)] string name, Func<bool> initHandle = null, Action<bool> finishedCallback = null, TaskInterruptOptions interruptOptions = null)
	{
		this.Name = name;
		this.InitHandle = initHandle;
		this.FinishedCallback = finishedCallback;
		this.InterruptOptions = (interruptOptions ?? new TaskInterruptOptions(ETaskPriority.Normal, false, null));
		this.TaskPromise = new UniTaskCompletionSource<bool>();
	}

	// Token: 0x17002979 RID: 10617
	// (get) Token: 0x0601DF08 RID: 122632 RVA: 0x00863C7A File Offset: 0x00861E7A
	[Nullable(1)]
	public string Name { [NullableContext(1)] get; }

	// Token: 0x0601DF09 RID: 122633 RVA: 0x00863C82 File Offset: 0x00861E82
	[NullableContext(2)]
	public void SetLogPrefix(string logPrefix = null)
	{
		this.LogPrefix = logPrefix;
	}

	// Token: 0x1700297A RID: 10618
	// (get) Token: 0x0601DF0A RID: 122634 RVA: 0x00863C8B File Offset: 0x00861E8B
	public ETaskPriority InterruptPriority
	{
		get
		{
			return this.InterruptOptions.Priority;
		}
	}

	// Token: 0x1700297B RID: 10619
	// (get) Token: 0x0601DF0B RID: 122635 RVA: 0x00863C98 File Offset: 0x00861E98
	public bool Interruptible
	{
		get
		{
			return this.InterruptOptions.Interruptible;
		}
	}

	// Token: 0x0601DF0C RID: 122636 RVA: 0x00863CA8 File Offset: 0x00861EA8
	public void RequestInterrupt()
	{
		if (this.Interrupted)
		{
			return;
		}
		this.Interrupted = true;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "TaskBase:请求打断";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.OnInterrupt();
	}

	// Token: 0x0601DF0D RID: 122637 RVA: 0x00863CF8 File Offset: 0x00861EF8
	protected virtual void OnInterrupt()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "TaskBase:执行打断收尾";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", this.Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		Action onInterrupt = this.InterruptOptions.OnInterrupt;
		if (onInterrupt == null)
		{
			return;
		}
		onInterrupt();
	}

	// Token: 0x0601DF0E RID: 122638 RVA: 0x00863D46 File Offset: 0x00861F46
	public bool Init()
	{
		return (this.InitHandle == null || this.InitHandle()) && this.OnInit();
	}

	// Token: 0x1700297C RID: 10620
	// (get) Token: 0x0601DF0F RID: 122639 RVA: 0x00863D65 File Offset: 0x00861F65
	public UniTask<bool> Promise
	{
		get
		{
			return this.TaskPromise.Task;
		}
	}

	// Token: 0x0601DF10 RID: 122640 RVA: 0x00863D74 File Offset: 0x00861F74
	public UniTask<bool> Run()
	{
		TaskBase.<Run>d__20 <Run>d__;
		<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<Run>d__.<>4__this = this;
		<Run>d__.<>1__state = -1;
		<Run>d__.<>t__builder.Start<TaskBase.<Run>d__20>(ref <Run>d__);
		return <Run>d__.<>t__builder.Task;
	}

	// Token: 0x0601DF11 RID: 122641
	protected abstract UniTask<bool> OnRun();

	// Token: 0x0601DF12 RID: 122642 RVA: 0x00863DB7 File Offset: 0x00861FB7
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x0601DF13 RID: 122643 RVA: 0x00863DBA File Offset: 0x00861FBA
	protected virtual void OnExit()
	{
	}

	// Token: 0x0400EB2F RID: 60207
	[Nullable(1)]
	protected readonly TaskInterruptOptions InterruptOptions;

	// Token: 0x0400EB30 RID: 60208
	public bool Interrupted;

	// Token: 0x0400EB31 RID: 60209
	[Nullable(2)]
	protected string LogPrefix = "";

	// Token: 0x0400EB32 RID: 60210
	[Nullable(2)]
	protected Func<bool> InitHandle;

	// Token: 0x0400EB33 RID: 60211
	[Nullable(2)]
	protected Action<bool> FinishedCallback;

	// Token: 0x0400EB34 RID: 60212
	[Nullable(1)]
	private readonly UniTaskCompletionSource<bool> TaskPromise;
}
