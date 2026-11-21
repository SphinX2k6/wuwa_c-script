using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001FF4 RID: 8180
public class SkipTask
{
	// Token: 0x06014450 RID: 83024 RVA: 0x005E88A1 File Offset: 0x005E6AA1
	public void Initialize()
	{
		this.OnAddEvents();
		this.OnInitialize();
	}

	// Token: 0x06014451 RID: 83025 RVA: 0x005E88AF File Offset: 0x005E6AAF
	public void Destroy()
	{
		this.Deactivate();
		this.OnDestroyed();
		this.OnRemoveEvents();
	}

	// Token: 0x06014452 RID: 83026 RVA: 0x005E88C4 File Offset: 0x005E6AC4
	public void Run([Nullable(new byte[]
	{
		1,
		2
	})] params object[] data)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SkipInterface;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "开始跳转任务";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.Activate(data);
	}

	// Token: 0x06014453 RID: 83027 RVA: 0x005E890C File Offset: 0x005E6B0C
	public UniTask<ESkipTaskFinishType> AsyncRun([Nullable(new byte[]
	{
		1,
		2
	})] params object[] data)
	{
		SkipTask.<AsyncRun>d__5 <AsyncRun>d__;
		<AsyncRun>d__.<>t__builder = AsyncUniTaskMethodBuilder<ESkipTaskFinishType>.Create();
		<AsyncRun>d__.<>4__this = this;
		<AsyncRun>d__.data = data;
		<AsyncRun>d__.<>1__state = -1;
		<AsyncRun>d__.<>t__builder.Start<SkipTask.<AsyncRun>d__5>(ref <AsyncRun>d__);
		return <AsyncRun>d__.<>t__builder.Task;
	}

	// Token: 0x06014454 RID: 83028 RVA: 0x005E8957 File Offset: 0x005E6B57
	public bool GetIsRunning()
	{
		return this.IsRunning;
	}

	// Token: 0x06014455 RID: 83029 RVA: 0x005E8960 File Offset: 0x005E6B60
	protected void Finish()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SkipInterface;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "结束跳转任务";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.CustomPromise != null)
		{
			this.CustomPromise.SetResult(ESkipTaskFinishType.Finish);
		}
		this.OnFinished();
		this.Deactivate();
	}

	// Token: 0x06014456 RID: 83030 RVA: 0x005E89C4 File Offset: 0x005E6BC4
	public void Stop()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SkipInterface;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "停止跳转任务";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.CustomPromise != null)
		{
			this.CustomPromise.SetResult(ESkipTaskFinishType.Stop);
		}
		this.OnStopped();
		this.Deactivate();
	}

	// Token: 0x06014457 RID: 83031 RVA: 0x005E8A25 File Offset: 0x005E6C25
	private void Activate([Nullable(new byte[]
	{
		1,
		2
	})] params object[] data)
	{
		this.IsRunning = true;
		this.OnRun(data);
	}

	// Token: 0x06014458 RID: 83032 RVA: 0x005E8A35 File Offset: 0x005E6C35
	private void Deactivate()
	{
		this.IsRunning = false;
		this.CustomPromise = null;
	}

	// Token: 0x06014459 RID: 83033 RVA: 0x005E8A45 File Offset: 0x005E6C45
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x0601445A RID: 83034 RVA: 0x005E8A47 File Offset: 0x005E6C47
	protected virtual void OnRun([Nullable(new byte[]
	{
		1,
		2
	})] params object[] data)
	{
	}

	// Token: 0x0601445B RID: 83035 RVA: 0x005E8A49 File Offset: 0x005E6C49
	protected virtual void OnFinished()
	{
	}

	// Token: 0x0601445C RID: 83036 RVA: 0x005E8A4B File Offset: 0x005E6C4B
	protected virtual void OnStopped()
	{
	}

	// Token: 0x0601445D RID: 83037 RVA: 0x005E8A4D File Offset: 0x005E6C4D
	protected virtual void OnDestroyed()
	{
	}

	// Token: 0x0601445E RID: 83038 RVA: 0x005E8A4F File Offset: 0x005E6C4F
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x0601445F RID: 83039 RVA: 0x005E8A51 File Offset: 0x005E6C51
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0400AC18 RID: 44056
	private bool IsRunning;

	// Token: 0x0400AC19 RID: 44057
	[Nullable(2)]
	private CustomPromise<ESkipTaskFinishType> CustomPromise;
}
