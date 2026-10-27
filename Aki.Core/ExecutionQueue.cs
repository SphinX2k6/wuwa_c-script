using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000022 RID: 34
[NullableContext(1)]
[Nullable(0)]
public class ExecutionQueue
{
	// Token: 0x060000DD RID: 221 RVA: 0x000072F8 File Offset: 0x000054F8
	public int Enqueue(Func<int, UniTask> task)
	{
		ExecutionQueue.<>c__DisplayClass5_0 CS$<>8__locals1 = new ExecutionQueue.<>c__DisplayClass5_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.task = task;
		ExecutionQueue.<>c__DisplayClass5_0 CS$<>8__locals2 = CS$<>8__locals1;
		int handle = this.Handle;
		this.Handle = handle + 1;
		CS$<>8__locals2.handle = handle;
		this.Pending.Add(CS$<>8__locals1.handle);
		this.TaskQueue.Add(delegate
		{
			ExecutionQueue.<>c__DisplayClass5_0.<<Enqueue>b__0>d <<Enqueue>b__0>d;
			<<Enqueue>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Enqueue>b__0>d.<>4__this = CS$<>8__locals1;
			<<Enqueue>b__0>d.<>1__state = -1;
			<<Enqueue>b__0>d.<>t__builder.Start<ExecutionQueue.<>c__DisplayClass5_0.<<Enqueue>b__0>d>(ref <<Enqueue>b__0>d);
			return <<Enqueue>b__0>d.<>t__builder.Task;
		});
		if (!this.Executing)
		{
			this.Execute().Forget();
		}
		return CS$<>8__locals1.handle;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00007372 File Offset: 0x00005572
	public bool Cancel(int handle)
	{
		return this.Pending.Remove(handle);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00007380 File Offset: 0x00005580
	private UniTask Execute()
	{
		ExecutionQueue.<Execute>d__7 <Execute>d__;
		<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Execute>d__.<>4__this = this;
		<Execute>d__.<>1__state = -1;
		<Execute>d__.<>t__builder.Start<ExecutionQueue.<Execute>d__7>(ref <Execute>d__);
		return <Execute>d__.<>t__builder.Task;
	}

	// Token: 0x040000BA RID: 186
	private const bool EXECUTION_QUEUE_ENABLE = true;

	// Token: 0x040000BB RID: 187
	private int Handle;

	// Token: 0x040000BC RID: 188
	private bool Executing;

	// Token: 0x040000BD RID: 189
	private HashSet<int> Pending = new HashSet<int>();

	// Token: 0x040000BE RID: 190
	private List<Func<UniTask>> TaskQueue = new List<Func<UniTask>>();
}
