using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002A8D RID: 10893
[NullableContext(1)]
[Nullable(0)]
public class SplashScreenQueue
{
	// Token: 0x06016ADA RID: 92890 RVA: 0x005BE2AC File Offset: 0x005BC4AC
	public unsafe void EnQueue(SplashScreenTask task)
	{
		if (this.CurrentRunningTask != null && this.CurrentRunningTask.SourceModule == task.SourceModule)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SplashScreenTask;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "[SplashScreenTask] 任务重复添加";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskSourceModule", task.SourceModule);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Status", task.Status);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		if (this.IsTaskInQueue(task))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SplashScreenTask;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "[SplashScreenTask] 任务重复添加";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TaskSourceModule", task.SourceModule);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Status", task.Status);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return;
		}
		this.TaskQueue.Add(task);
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.SplashScreenTask;
		ELogAuthor author3 = ELogAuthor.CXJ;
		string message3 = "[SplashScreenTask] 添加任务";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("TaskSourceModule", task.SourceModule);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Status", task.Status);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
	}

	// Token: 0x06016ADB RID: 92891 RVA: 0x005BE42C File Offset: 0x005BC62C
	public unsafe void ProcessQueueSingle()
	{
		if (this.IsSplashScreenTaskRunning())
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "有其他开屏任务正在进行中", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.TaskQueue == null || this.TaskQueue.Count == 0)
		{
			Log.Instance.Info(ELogModule.SplashScreenTask, ELogAuthor.CXJ, "开屏任务队列为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.LongTaskMaxNum == null)
		{
			this.LongTaskMaxNum = new int?(ConfigCommonParamById.GetIntConfig("LongTaskMaxNum").GetValueOrDefault(1));
		}
		this.CurrentRunningTask = this.TaskQueue[0];
		this.TaskQueue.RemoveAt(0);
		SplashScreenTask currentRunningTask = this.CurrentRunningTask;
		if (currentRunningTask != null && currentRunningTask.SplashScreenTimeType == ESplashScreenTimeType.Long)
		{
			bool needInLongQueue = this.CurrentRunningTask.NeedInLongQueue;
			if (needInLongQueue)
			{
				int finishedInQueueLongTaskNum = this.FinishedInQueueLongTaskNum;
				int? longTaskMaxNum = this.LongTaskMaxNum;
				if (finishedInQueueLongTaskNum >= longTaskMaxNum.GetValueOrDefault() & longTaskMaxNum != null)
				{
					goto IL_108;
				}
			}
			if (needInLongQueue || !this.IsShowLongTask)
			{
				if (needInLongQueue)
				{
					this.FinishedInQueueLongTaskNum++;
				}
				this.IsShowLongTask = true;
				goto IL_1A3;
			}
			IL_108:
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SplashScreenTask;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "[SplashScreenTask] 长任务已达上限，跳过执行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskSourceModule", this.CurrentRunningTask.SourceModule);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Status", this.CurrentRunningTask.Status);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.CurrentRunningTask = null;
			this.ProcessQueueSingle();
			return;
		}
		IL_1A3:
		if (this.CurrentRunningTask != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SplashScreenTask;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "[SplashScreenTask] 任务开始执行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TaskSourceModule", this.CurrentRunningTask.SourceModule);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Status", this.CurrentRunningTask.Status);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.CurrentRunningTask.Run();
		}
	}

	// Token: 0x06016ADC RID: 92892 RVA: 0x005BE664 File Offset: 0x005BC864
	public unsafe bool FinishTask(ESplashScreenSourceModuleType taskSourceModule = ESplashScreenSourceModuleType.None)
	{
		if (this.CurrentRunningTask == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SplashScreenTask;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "[SplashScreenTask] 当前没有正在执行的任务";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("finishTaskSourceModule", taskSourceModule);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (taskSourceModule != ESplashScreenSourceModuleType.None && taskSourceModule != this.CurrentRunningTask.SourceModule)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SplashScreenTask;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "[SplashScreenTask] 当前执行任务名称与参数名称不一致，结束任务失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("finishTaskSourceModule", taskSourceModule);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "curTaskSourceModule";
			SplashScreenTask currentRunningTask = this.CurrentRunningTask;
			ptr = new ValueTuple<string, object>(item, (currentRunningTask != null) ? new ESplashScreenSourceModuleType?(currentRunningTask.SourceModule) : null);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		if (this.CurrentRunningTask != null)
		{
			this.CurrentRunningTask.FinishTask();
			this.CurrentRunningTask = null;
		}
		return true;
	}

	// Token: 0x06016ADD RID: 92893 RVA: 0x005BE75C File Offset: 0x005BC95C
	public void ProcessQueue()
	{
		this.TaskQueue.Sort(delegate(SplashScreenTask taskA, SplashScreenTask taskB)
		{
			if (taskA.Type == ESplashScreenType.Other || taskB.Type == ESplashScreenType.Other)
			{
				if (taskA.Type != ESplashScreenType.Other)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				SplashScreen value = ConfigSplashScreenById.GetConfig((int)taskA.SourceModule, true).Value;
				SplashScreen value2 = ConfigSplashScreenById.GetConfig((int)taskB.SourceModule, true).Value;
				if (value.Type != value2.Type)
				{
					if (value.Type != 1)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					if (value.InLongTaskQueue == value2.InLongTaskQueue)
					{
						return value2.Priority - value.Priority;
					}
					if (!value2.InLongTaskQueue)
					{
						return -1;
					}
					return 1;
				}
			}
		});
		this.ProcessQueueSingle();
	}

	// Token: 0x06016ADE RID: 92894 RVA: 0x005BE78E File Offset: 0x005BC98E
	public bool IsSplashScreenTaskRunning()
	{
		return this.CurrentRunningTask != null;
	}

	// Token: 0x06016ADF RID: 92895 RVA: 0x005BE79C File Offset: 0x005BC99C
	public bool IsTaskInQueue(SplashScreenTask task)
	{
		using (List<SplashScreenTask>.Enumerator enumerator = this.TaskQueue.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.SourceModule == task.SourceModule)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06016AE0 RID: 92896 RVA: 0x005BE7FC File Offset: 0x005BC9FC
	public void ClearAllTask()
	{
		if (this.CurrentRunningTask != null)
		{
			this.CurrentRunningTask.FailTask();
			this.CurrentRunningTask = null;
		}
		foreach (SplashScreenTask splashScreenTask in this.TaskQueue)
		{
			splashScreenTask.CancelTask();
		}
		this.TaskQueue = new List<SplashScreenTask>();
	}

	// Token: 0x0400A844 RID: 43076
	public List<SplashScreenTask> TaskQueue = new List<SplashScreenTask>();

	// Token: 0x0400A845 RID: 43077
	[Nullable(2)]
	private SplashScreenTask CurrentRunningTask;

	// Token: 0x0400A846 RID: 43078
	private bool IsShowLongTask;

	// Token: 0x0400A847 RID: 43079
	private int? LongTaskMaxNum;

	// Token: 0x0400A848 RID: 43080
	private int FinishedInQueueLongTaskNum;
}
