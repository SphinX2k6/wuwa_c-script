using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AB9 RID: 10937
[NullableContext(1)]
[Nullable(0)]
public class TaskSystem : Singleton
{
	// Token: 0x17002D1B RID: 11547
	// (get) Token: 0x0601BC57 RID: 113751 RVA: 0x0088C6C0 File Offset: 0x0088A8C0
	[Nullable(0)]
	public UniTask<bool>? Promise
	{
		[NullableContext(0)]
		get
		{
			CustomPromise<bool> runPromise = this.RunPromise;
			if (runPromise == null)
			{
				return null;
			}
			return new UniTask<bool>?(runPromise.Promise);
		}
	}

	// Token: 0x0601BC58 RID: 113752 RVA: 0x0088C6EB File Offset: 0x0088A8EB
	public bool Initialize()
	{
		this.InitState = true;
		return true;
	}

	// Token: 0x0601BC59 RID: 113753 RVA: 0x0088C6F8 File Offset: 0x0088A8F8
	[NullableContext(0)]
	public UniTask<bool> Run()
	{
		TaskSystem.<Run>d__13 <Run>d__;
		<Run>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<Run>d__.<>4__this = this;
		<Run>d__.<>1__state = -1;
		<Run>d__.<>t__builder.Start<TaskSystem.<Run>d__13>(ref <Run>d__);
		return <Run>d__.<>t__builder.Task;
	}

	// Token: 0x0601BC5A RID: 113754 RVA: 0x0088C73C File Offset: 0x0088A93C
	public unsafe void AddTask(TaskBase task)
	{
		if (!this.InitState)
		{
			return;
		}
		if (!task.Init())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "TaskSystem:Task初始化失败,不入队";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", task.Name);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.IncomingQueue.Push(task);
		this.IncreaseQueuedCount(task.InterruptPriority);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.World;
		ELogAuthor author2 = ELogAuthor.LFJW;
		string message2 = "TaskSystem:入队Task";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", task.Name);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("InterruptPriority", task.InterruptPriority);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("剩余Task个数", this.QueuedSize);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601BC5B RID: 113755 RVA: 0x0088C824 File Offset: 0x0088AA24
	public void Clear()
	{
		Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "TaskSystem:Clear", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.InitState = false;
		this.ClearInternal();
	}

	// Token: 0x0601BC5C RID: 113756 RVA: 0x0088C85C File Offset: 0x0088AA5C
	private void ClearInternal()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "TaskSystem:清理内部状态";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("剩余Task个数", this.QueuedSize);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.IncomingQueue.Clear();
		this.DrainBuffer.Clear();
		this.QueuedTaskCountsByInterruptPriority.Clear();
		this.CurrentTask = null;
		this.SelfFeedStreak = 0;
		this.HasLoadingTask = false;
		this.Running = false;
	}

	// Token: 0x17002D1C RID: 11548
	// (get) Token: 0x0601BC5D RID: 113757 RVA: 0x0088C8D8 File Offset: 0x0088AAD8
	private int HighestQueuedInterruptPriority
	{
		get
		{
			for (ETaskPriority etaskPriority = ETaskPriority.High; etaskPriority >= ETaskPriority.Normal; etaskPriority--)
			{
				int num;
				if ((this.QueuedTaskCountsByInterruptPriority.TryGetValue(etaskPriority, out num) ? num : 0) > 0)
				{
					return (int)etaskPriority;
				}
			}
			return -1;
		}
	}

	// Token: 0x0601BC5E RID: 113758 RVA: 0x0088C90C File Offset: 0x0088AB0C
	private void IncreaseQueuedCount(ETaskPriority priority)
	{
		int num2;
		int num = this.QueuedTaskCountsByInterruptPriority.TryGetValue(priority, out num2) ? num2 : 0;
		this.QueuedTaskCountsByInterruptPriority[priority] = num + 1;
	}

	// Token: 0x0601BC5F RID: 113759 RVA: 0x0088C940 File Offset: 0x0088AB40
	private void DecreaseQueuedCount(ETaskPriority priority)
	{
		int num2;
		int num = (this.QueuedTaskCountsByInterruptPriority.TryGetValue(priority, out num2) ? num2 : 0) - 1;
		this.QueuedTaskCountsByInterruptPriority[priority] = ((num > 0) ? num : 0);
	}

	// Token: 0x0601BC60 RID: 113760 RVA: 0x0088C978 File Offset: 0x0088AB78
	private unsafe void TryInterruptCurrent()
	{
		TaskBase currentTask = this.CurrentTask;
		if (currentTask != null && currentTask.Interruptible && this.HighestQueuedInterruptPriority > (int)currentTask.InterruptPriority)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "TaskSystem:打断Task";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", currentTask.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前优先级", currentTask.InterruptPriority);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("最高等待优先级", this.HighestQueuedInterruptPriority);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			currentTask.RequestInterrupt();
		}
	}

	// Token: 0x0601BC61 RID: 113761 RVA: 0x0088CA38 File Offset: 0x0088AC38
	private void SwapBuffers()
	{
		Queue<TaskBase> drainBuffer = this.DrainBuffer;
		this.DrainBuffer = this.IncomingQueue;
		this.IncomingQueue = drainBuffer;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.World;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "TaskSystem:交换缓冲区,开始本轮排空";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("本轮任务数", this.DrainBuffer.Size);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x17002D1D RID: 11549
	// (get) Token: 0x0601BC62 RID: 113762 RVA: 0x0088CA95 File Offset: 0x0088AC95
	private int QueuedSize
	{
		get
		{
			return this.IncomingQueue.Size + this.DrainBuffer.Size;
		}
	}

	// Token: 0x0601BC63 RID: 113763 RVA: 0x0088CAB0 File Offset: 0x0088ACB0
	private UniTask YieldFrame()
	{
		TaskSystem.<YieldFrame>d__25 <YieldFrame>d__;
		<YieldFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<YieldFrame>d__.<>1__state = -1;
		<YieldFrame>d__.<>t__builder.Start<TaskSystem.<YieldFrame>d__25>(ref <YieldFrame>d__);
		return <YieldFrame>d__.<>t__builder.Task;
	}

	// Token: 0x0601BC64 RID: 113764 RVA: 0x0088CAEC File Offset: 0x0088ACEC
	[NullableContext(0)]
	private UniTask<bool> RunInternal()
	{
		TaskSystem.<RunInternal>d__26 <RunInternal>d__;
		<RunInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RunInternal>d__.<>4__this = this;
		<RunInternal>d__.<>1__state = -1;
		<RunInternal>d__.<>t__builder.Start<TaskSystem.<RunInternal>d__26>(ref <RunInternal>d__);
		return <RunInternal>d__.<>t__builder.Task;
	}

	// Token: 0x17002D1E RID: 11550
	// (get) Token: 0x0601BC65 RID: 113765 RVA: 0x0088CB2F File Offset: 0x0088AD2F
	public static TaskSystem Instance
	{
		get
		{
			if (TaskSystem._instance == null)
			{
				TaskSystem._instance = new TaskSystem();
				TaskSystem._instance.OnInit();
			}
			return TaskSystem._instance;
		}
	}

	// Token: 0x0601BC66 RID: 113766 RVA: 0x0088CB52 File Offset: 0x0088AD52
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BC67 RID: 113767 RVA: 0x0088CB54 File Offset: 0x0088AD54
	public static void ResetStaticDefaultValue()
	{
		TaskSystem instance = TaskSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TaskSystem._instance = null;
	}

	// Token: 0x0601BC68 RID: 113768 RVA: 0x0088CB6D File Offset: 0x0088AD6D
	static TaskSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskSystem.CreateStaticDefaultValue), new Action(TaskSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400EFFE RID: 61438
	private const int SELF_FEED_STREAK_THRESHOLD = 100;

	// Token: 0x0400EFFF RID: 61439
	private Queue<TaskBase> IncomingQueue = new Queue<TaskBase>(4);

	// Token: 0x0400F000 RID: 61440
	private Queue<TaskBase> DrainBuffer = new Queue<TaskBase>(4);

	// Token: 0x0400F001 RID: 61441
	[Nullable(2)]
	private TaskBase CurrentTask;

	// Token: 0x0400F002 RID: 61442
	private readonly Dictionary<ETaskPriority, int> QueuedTaskCountsByInterruptPriority = new Dictionary<ETaskPriority, int>();

	// Token: 0x0400F003 RID: 61443
	private int SelfFeedStreak;

	// Token: 0x0400F004 RID: 61444
	public bool HasLoadingTask;

	// Token: 0x0400F005 RID: 61445
	public bool Running;

	// Token: 0x0400F006 RID: 61446
	[Nullable(2)]
	private CustomPromise<bool> RunPromise;

	// Token: 0x0400F007 RID: 61447
	private bool InitState;

	// Token: 0x0400F008 RID: 61448
	[Nullable(2)]
	private static TaskSystem _instance;
}
