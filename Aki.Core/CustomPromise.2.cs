using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02000027 RID: 39
[NullableContext(1)]
[Nullable(0)]
public class CustomPromise<[Nullable(2)] T>
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000739C File Offset: 0x0000559C
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

	// Token: 0x060000F1 RID: 241 RVA: 0x000073BD File Offset: 0x000055BD
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
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x000073E9 File Offset: 0x000055E9
	public bool IsFulfilled
	{
		get
		{
			return this.State == EPromiseState.Fulfilled;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x000073F4 File Offset: 0x000055F4
	public bool IsPending
	{
		get
		{
			return this.State == EPromiseState.Pending;
		}
	}

	// Token: 0x040000C8 RID: 200
	private readonly AkiUniTask<T> Tcs = new AkiUniTask<T>();

	// Token: 0x040000C9 RID: 201
	private EPromiseState State;

	// Token: 0x040000CA RID: 202
	private bool HasResult;

	// Token: 0x040000CB RID: 203
	private T Result;
}
