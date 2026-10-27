using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002A79 RID: 10873
public class SkipTask
{
	// Token: 0x06016A2F RID: 92719 RVA: 0x005BC719 File Offset: 0x005BA919
	public void Initialize()
	{
		this.OnAddEvents();
		this.OnInitialize();
	}

	// Token: 0x06016A30 RID: 92720 RVA: 0x005BC727 File Offset: 0x005BA927
	public void Destroy()
	{
		this.Deactivate();
		this.OnDestroyed();
		this.OnRemoveEvents();
	}

	// Token: 0x06016A31 RID: 92721 RVA: 0x005BC73C File Offset: 0x005BA93C
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

	// Token: 0x06016A32 RID: 92722 RVA: 0x005BC784 File Offset: 0x005BA984
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

	// Token: 0x06016A33 RID: 92723 RVA: 0x005BC7CF File Offset: 0x005BA9CF
	public bool GetIsRunning()
	{
		return this.IsRunning;
	}

	// Token: 0x06016A34 RID: 92724 RVA: 0x005BC7D8 File Offset: 0x005BA9D8
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

	// Token: 0x06016A35 RID: 92725 RVA: 0x005BC83C File Offset: 0x005BAA3C
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

	// Token: 0x06016A36 RID: 92726 RVA: 0x005BC89D File Offset: 0x005BAA9D
	private void Activate([Nullable(new byte[]
	{
		1,
		2
	})] params object[] data)
	{
		this.IsRunning = true;
		this.OnRun(data);
	}

	// Token: 0x06016A37 RID: 92727 RVA: 0x005BC8AD File Offset: 0x005BAAAD
	private void Deactivate()
	{
		this.IsRunning = false;
		this.CustomPromise = null;
	}

	// Token: 0x06016A38 RID: 92728 RVA: 0x005BC8BD File Offset: 0x005BAABD
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x06016A39 RID: 92729 RVA: 0x005BC8BF File Offset: 0x005BAABF
	protected virtual void OnRun([Nullable(new byte[]
	{
		1,
		2
	})] params object[] data)
	{
	}

	// Token: 0x06016A3A RID: 92730 RVA: 0x005BC8C1 File Offset: 0x005BAAC1
	protected virtual void OnFinished()
	{
	}

	// Token: 0x06016A3B RID: 92731 RVA: 0x005BC8C3 File Offset: 0x005BAAC3
	protected virtual void OnStopped()
	{
	}

	// Token: 0x06016A3C RID: 92732 RVA: 0x005BC8C5 File Offset: 0x005BAAC5
	protected virtual void OnDestroyed()
	{
	}

	// Token: 0x06016A3D RID: 92733 RVA: 0x005BC8C7 File Offset: 0x005BAAC7
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x06016A3E RID: 92734 RVA: 0x005BC8C9 File Offset: 0x005BAAC9
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0400A814 RID: 43028
	private bool IsRunning;

	// Token: 0x0400A815 RID: 43029
	[Nullable(2)]
	private CustomPromise<ESkipTaskFinishType> CustomPromise;
}
