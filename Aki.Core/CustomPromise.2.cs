using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02000027 RID: 39
[NullableContext(1)]
[Nullable(0)]
public class CustomPromise<[Nullable(2)] T>
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000EE RID: 238 RVA: 0x00007624 File Offset: 0x00005824
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<T> Promise
	{
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		get
		{
			if (this.HasResult)
			{
				return UniTask.FromResult<T>(this.Result);
			}
			return this.Tcs.GetTask();
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00007645 File Offset: 0x00005845
	public void SetResult(T value)
	{
		if (this.State != EPromiseState.Pending)
		{
			return;
		}
		this.HasResult = true;
		this.Result = value;
		this.State = EPromiseState.Fulfilled;
		this.Tcs.TrySetResult(value);
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000F0 RID: 240 RVA: 0x00007671 File Offset: 0x00005871
	public bool IsFulfilled
	{
		get
		{
			return this.State == EPromiseState.Fulfilled;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000767C File Offset: 0x0000587C
	public bool IsPending
	{
		get
		{
			return this.State == EPromiseState.Pending;
		}
	}

	// Token: 0x040000C7 RID: 199
	private readonly AkiUniTask<T> Tcs = new AkiUniTask<T>();

	// Token: 0x040000C8 RID: 200
	private EPromiseState State;

	// Token: 0x040000C9 RID: 201
	private bool HasResult;

	// Token: 0x040000CA RID: 202
	private T Result;
}
