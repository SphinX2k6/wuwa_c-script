using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AB4 RID: 10932
public abstract class TaskBase
{
	// Token: 0x0601BC2F RID: 113711 RVA: 0x0088B860 File Offset: 0x00889A60
	[NullableContext(2)]
	public TaskBase([Nullable(1)] string name, Func<bool> initHandle = null, Action<bool> finishedCallback = null, TaskInterruptOptions interruptOptions = null)
	{
		this.Name = name;
		this.InitHandle = initHandle;
		this.FinishedCallback = finishedCallback;
		this.InterruptOptions = (interruptOptions ?? new TaskInterruptOptions(ETaskPriority.Normal, false, null));
		this.TaskPromise = new UniTaskCompletionSource<bool>();
	}

	// Token: 0x17002D12 RID: 11538
	// (get) Token: 0x0601BC30 RID: 113712 RVA: 0x0088B8B2 File Offset: 0x00889AB2
	[Nullable(1)]
	public string Name { [NullableContext(1)] get; }

	// Token: 0x0601BC31 RID: 113713 RVA: 0x0088B8BA File Offset: 0x00889ABA
	[NullableContext(2)]
	public void SetLogPrefix(string logPrefix = null)
	{
		this.LogPrefix = logPrefix;
	}

	// Token: 0x17002D13 RID: 11539
	// (get) Token: 0x0601BC32 RID: 113714 RVA: 0x0088B8C3 File Offset: 0x00889AC3
	public ETaskPriority InterruptPriority
	{
		get
		{
			return this.InterruptOptions.Priority;
		}
	}

	// Token: 0x17002D14 RID: 11540
	// (get) Token: 0x0601BC33 RID: 113715 RVA: 0x0088B8D0 File Offset: 0x00889AD0
	public bool Interruptible
	{
		get
		{
			return this.InterruptOptions.Interruptible;
		}
	}

	// Token: 0x0601BC34 RID: 113716 RVA: 0x0088B8E0 File Offset: 0x00889AE0
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

	// Token: 0x0601BC35 RID: 113717 RVA: 0x0088B930 File Offset: 0x00889B30
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

	// Token: 0x0601BC36 RID: 113718 RVA: 0x0088B97E File Offset: 0x00889B7E
	public bool Init()
	{
		return (this.InitHandle == null || this.InitHandle()) && this.OnInit();
	}

	// Token: 0x17002D15 RID: 11541
	// (get) Token: 0x0601BC37 RID: 113719 RVA: 0x0088B99D File Offset: 0x00889B9D
	public UniTask<bool> Promise
	{
		get
		{
			return this.TaskPromise.Task;
		}
	}

	// Token: 0x0601BC38 RID: 113720 RVA: 0x0088B9AC File Offset: 0x00889BAC
	public UniTask<bool> Run()
	{
		TaskBase.<Run>d__20 <Run>d__;
		<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<Run>d__.<>4__this = this;
		<Run>d__.<>1__state = -1;
		<Run>d__.<>t__builder.Start<TaskBase.<Run>d__20>(ref <Run>d__);
		return <Run>d__.<>t__builder.Task;
	}

	// Token: 0x0601BC39 RID: 113721
	protected abstract UniTask<bool> OnRun();

	// Token: 0x0601BC3A RID: 113722 RVA: 0x0088B9EF File Offset: 0x00889BEF
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x0601BC3B RID: 113723 RVA: 0x0088B9F2 File Offset: 0x00889BF2
	protected virtual void OnExit()
	{
	}

	// Token: 0x0400EFEC RID: 61420
	[Nullable(1)]
	protected readonly TaskInterruptOptions InterruptOptions;

	// Token: 0x0400EFED RID: 61421
	public bool Interrupted;

	// Token: 0x0400EFEE RID: 61422
	[Nullable(2)]
	protected string LogPrefix = "";

	// Token: 0x0400EFEF RID: 61423
	[Nullable(2)]
	protected Func<bool> InitHandle;

	// Token: 0x0400EFF0 RID: 61424
	[Nullable(2)]
	protected Action<bool> FinishedCallback;

	// Token: 0x0400EFF1 RID: 61425
	[Nullable(1)]
	private readonly UniTaskCompletionSource<bool> TaskPromise;
}
