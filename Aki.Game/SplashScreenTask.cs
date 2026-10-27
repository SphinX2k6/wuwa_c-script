using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002A8F RID: 10895
[NullableContext(1)]
[Nullable(0)]
public class SplashScreenTask
{
	// Token: 0x17001E36 RID: 7734
	// (get) Token: 0x06016AE2 RID: 92898 RVA: 0x005BE887 File Offset: 0x005BCA87
	public ESplashScreenTaskStatus Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x06016AE3 RID: 92899 RVA: 0x005BE890 File Offset: 0x005BCA90
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

	// Token: 0x06016AE4 RID: 92900 RVA: 0x005BE8FC File Offset: 0x005BCAFC
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

	// Token: 0x06016AE5 RID: 92901 RVA: 0x005BEA64 File Offset: 0x005BCC64
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

	// Token: 0x06016AE6 RID: 92902 RVA: 0x005BEAAC File Offset: 0x005BCCAC
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

	// Token: 0x06016AE7 RID: 92903 RVA: 0x005BEAF4 File Offset: 0x005BCCF4
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

	// Token: 0x0400A84F RID: 43087
	private ESplashScreenTaskStatus StatusInternal;

	// Token: 0x0400A850 RID: 43088
	public ESplashScreenTimeType SplashScreenTimeType;

	// Token: 0x0400A851 RID: 43089
	public bool NeedInLongQueue;

	// Token: 0x0400A852 RID: 43090
	private readonly Action RunHandle;

	// Token: 0x0400A853 RID: 43091
	public readonly ESplashScreenSourceModuleType SourceModule;

	// Token: 0x0400A854 RID: 43092
	public readonly ESplashScreenType Type;
}
