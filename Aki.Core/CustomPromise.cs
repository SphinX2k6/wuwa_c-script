using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02000026 RID: 38
public class CustomPromise
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000EB RID: 235 RVA: 0x00007334 File Offset: 0x00005534
	public UniTask Promise
	{
		get
		{
			if (this.HasResult)
			{
				return UniTask.CompletedTask;
			}
			return this.Tcs.GetTask();
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0000734F File Offset: 0x0000554F
	public void SetResult()
	{
		if (this.State != EPromiseState.Pending)
		{
			return;
		}
		this.HasResult = true;
		this.State = EPromiseState.Fulfilled;
		this.Tcs.TrySetResult();
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000ED RID: 237 RVA: 0x00007373 File Offset: 0x00005573
	public bool IsFulfilled
	{
		get
		{
			return this.State == EPromiseState.Fulfilled;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000EE RID: 238 RVA: 0x0000737E File Offset: 0x0000557E
	public bool IsPending
	{
		get
		{
			return this.State == EPromiseState.Pending;
		}
	}

	// Token: 0x040000C5 RID: 197
	[Nullable(1)]
	private readonly AkiUniTask Tcs = new AkiUniTask();

	// Token: 0x040000C6 RID: 198
	private EPromiseState State;

	// Token: 0x040000C7 RID: 199
	private bool HasResult;
}
