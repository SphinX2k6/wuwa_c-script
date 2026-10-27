using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02003544 RID: 13636
[NullableContext(1)]
[Nullable(0)]
public class TaskSystem : Singleton
{
	// Token: 0x17002982 RID: 10626
	// (get) Token: 0x0601DF2F RID: 122671 RVA: 0x00864A88 File Offset: 0x00862C88
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

	// Token: 0x0601DF30 RID: 122672 RVA: 0x00864AB3 File Offset: 0x00862CB3
	public bool Initialize()
	{
		this.InitState = true;
		return true;
	}

	// Token: 0x0601DF31 RID: 122673 RVA: 0x00864AC0 File Offset: 0x00862CC0
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

	// Token: 0x0601DF32 RID: 122674 RVA: 0x00864B04 File Offset: 0x00862D04
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

	// Token: 0x0601DF33 RID: 122675 RVA: 0x00864BEC File Offset: 0x00862DEC
	public void Clear()
	{
		Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "TaskSystem:Clear", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.InitState = false;
		this.ClearInternal();
	}

	// Token: 0x0601DF34 RID: 122676 RVA: 0x00864C24 File Offset: 0x00862E24
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

	// Token: 0x17002983 RID: 10627
	// (get) Token: 0x0601DF35 RID: 122677 RVA: 0x00864CA0 File Offset: 0x00862EA0
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

	// Token: 0x0601DF36 RID: 122678 RVA: 0x00864CD4 File Offset: 0x00862ED4
	private void IncreaseQueuedCount(ETaskPriority priority)
	{
		int num2;
		int num = this.QueuedTaskCountsByInterruptPriority.TryGetValue(priority, out num2) ? num2 : 0;
		this.QueuedTaskCountsByInterruptPriority[priority] = num + 1;
	}

	// Token: 0x0601DF37 RID: 122679 RVA: 0x00864D08 File Offset: 0x00862F08
	private void DecreaseQueuedCount(ETaskPriority priority)
	{
		int num2;
		int num = (this.QueuedTaskCountsByInterruptPriority.TryGetValue(priority, out num2) ? num2 : 0) - 1;
		this.QueuedTaskCountsByInterruptPriority[priority] = ((num > 0) ? num : 0);
	}

	// Token: 0x0601DF38 RID: 122680 RVA: 0x00864D40 File Offset: 0x00862F40
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

	// Token: 0x0601DF39 RID: 122681 RVA: 0x00864E00 File Offset: 0x00863000
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

	// Token: 0x17002984 RID: 10628
	// (get) Token: 0x0601DF3A RID: 122682 RVA: 0x00864E5D File Offset: 0x0086305D
	private int QueuedSize
	{
		get
		{
			return this.IncomingQueue.Size + this.DrainBuffer.Size;
		}
	}

	// Token: 0x0601DF3B RID: 122683 RVA: 0x00864E78 File Offset: 0x00863078
	private UniTask YieldFrame()
	{
		TaskSystem.<YieldFrame>d__25 <YieldFrame>d__;
		<YieldFrame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<YieldFrame>d__.<>1__state = -1;
		<YieldFrame>d__.<>t__builder.Start<TaskSystem.<YieldFrame>d__25>(ref <YieldFrame>d__);
		return <YieldFrame>d__.<>t__builder.Task;
	}

	// Token: 0x0601DF3C RID: 122684 RVA: 0x00864EB4 File Offset: 0x008630B4
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

	// Token: 0x17002985 RID: 10629
	// (get) Token: 0x0601DF3D RID: 122685 RVA: 0x00864EF7 File Offset: 0x008630F7
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

	// Token: 0x0601DF3E RID: 122686 RVA: 0x00864F1A File Offset: 0x0086311A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DF3F RID: 122687 RVA: 0x00864F1C File Offset: 0x0086311C
	public static void ResetStaticDefaultValue()
	{
		TaskSystem instance = TaskSystem._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TaskSystem._instance = null;
	}

	// Token: 0x0601DF40 RID: 122688 RVA: 0x00864F35 File Offset: 0x00863135
	static TaskSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskSystem.CreateStaticDefaultValue), new Action(TaskSystem.ResetStaticDefaultValue));
	}

	// Token: 0x0400EB41 RID: 60225
	private const int SELF_FEED_STREAK_THRESHOLD = 100;

	// Token: 0x0400EB42 RID: 60226
	private Queue<TaskBase> IncomingQueue = new Queue<TaskBase>(4);

	// Token: 0x0400EB43 RID: 60227
	private Queue<TaskBase> DrainBuffer = new Queue<TaskBase>(4);

	// Token: 0x0400EB44 RID: 60228
	[Nullable(2)]
	private TaskBase CurrentTask;

	// Token: 0x0400EB45 RID: 60229
	private readonly Dictionary<ETaskPriority, int> QueuedTaskCountsByInterruptPriority = new Dictionary<ETaskPriority, int>();

	// Token: 0x0400EB46 RID: 60230
	private int SelfFeedStreak;

	// Token: 0x0400EB47 RID: 60231
	public bool HasLoadingTask;

	// Token: 0x0400EB48 RID: 60232
	public bool Running;

	// Token: 0x0400EB49 RID: 60233
	[Nullable(2)]
	private CustomPromise<bool> RunPromise;

	// Token: 0x0400EB4A RID: 60234
	private bool InitState;

	// Token: 0x0400EB4B RID: 60235
	[Nullable(2)]
	private static TaskSystem _instance;
}
