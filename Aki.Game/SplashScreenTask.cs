using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200200B RID: 8203
[NullableContext(1)]
[Nullable(0)]
public class SplashScreenTask
{
	// Token: 0x17001E8E RID: 7822
	// (get) Token: 0x06014507 RID: 83207 RVA: 0x005EAA6F File Offset: 0x005E8C6F
	public ESplashScreenTaskStatus Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x06014508 RID: 83208 RVA: 0x005EAA78 File Offset: 0x005E8C78
	public SplashScreenTask(ESplashScreenSourceModuleType sourceModule, ESplashScreenType type, Action runHandle)
	{
		this.SourceModule = sourceModule;
		this.Type = type;
		this.RunHandle = runHandle;
		if (this.Type == ESplashScreenType.Config)
		{
			SplashScreen value = ConfigSplashScreenById.GetConfig((int)this.SourceModule, true).Value;
			this.SplashScreenTimeType = (ESplashScreenTimeType)value.Type;
			this.NeedInLongQueue = (this.SplashScreenTimeType == ESplashScreenTimeType.Long && value.InLongTaskQueue);
		}
	}

	// Token: 0x06014509 RID: 83209 RVA: 0x005EAAE4 File Offset: 0x005E8CE4
	public unsafe void Run()
	{
		if (this.StatusInternal != ESplashScreenTaskStatus.Pending)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SplashScreenTask;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "[SplashScreenTask] 任务被重复执行";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TaskSourceModule", this.SourceModule);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Status", this.Status);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		try
		{
			this.StatusInternal = ESplashScreenTaskStatus.Running;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SplashScreenTask;
			ELogAuthor author2 = ELogAuthor.CXJ;
			string message2 = "[SplashScreenTask] 任务开始执行";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskSourceModule", this.SourceModule);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			SplashScreenLogEvent splashScreenLogEvent = new SplashScreenLogEvent();
			splashScreenLogEvent.i_id = (int)this.SourceModule;
			LogReportController.Instance.LogReport(splashScreenLogEvent);
			this.RunHandle();
		}
		catch (Exception ex)
		{
			this.StatusInternal = ESplashScreenTaskStatus.Failed;
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SplashScreenTask;
			ELogAuthor author3 = ELogAuthor.CXJ;
			string message3 = "[SplashScreenTask] 任务执行异常";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TaskSourceModule", this.SourceModule);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", ex.Message);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
	}

	// Token: 0x0601450A RID: 83210 RVA: 0x005EAC4C File Offset: 0x005E8E4C
	public void FinishTask()
	{
		this.StatusInternal = ESplashScreenTaskStatus.Completed;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SplashScreenTask;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "[SplashScreenTask] 任务完成";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskSourceModule", this.SourceModule);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601450B RID: 83211 RVA: 0x005EAC94 File Offset: 0x005E8E94
	public void CancelTask()
	{
		this.StatusInternal = ESplashScreenTaskStatus.Canceled;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SplashScreenTask;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "[SplashScreenTask] 任务取消";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskSourceModule", this.SourceModule);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601450C RID: 83212 RVA: 0x005EACDC File Offset: 0x005E8EDC
	public void FailTask()
	{
		this.StatusInternal = ESplashScreenTaskStatus.Failed;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SplashScreenTask;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "[SplashScreenTask] 任务失败";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TaskSourceModule", this.SourceModule);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0400AC54 RID: 44116
	private ESplashScreenTaskStatus StatusInternal;

	// Token: 0x0400AC55 RID: 44117
	public ESplashScreenTimeType SplashScreenTimeType;

	// Token: 0x0400AC56 RID: 44118
	public bool NeedInLongQueue;

	// Token: 0x0400AC57 RID: 44119
	private readonly Action RunHandle;

	// Token: 0x0400AC58 RID: 44120
	public readonly ESplashScreenSourceModuleType SourceModule;

	// Token: 0x0400AC59 RID: 44121
	public readonly ESplashScreenType Type;
}
