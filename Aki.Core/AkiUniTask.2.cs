using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;

// Token: 0x02000025 RID: 37
[NullableContext(1)]
[Nullable(0)]
public class AkiUniTask<[Nullable(2)] T>
{
	// Token: 0x060000E5 RID: 229 RVA: 0x000074D0 File Offset: 0x000056D0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<T> GetTask()
	{
		UniTaskCompletionSource<T> uniTaskCompletionSource = new UniTaskCompletionSource<T>();
		this.Tasks.Add(uniTaskCompletionSource);
		return uniTaskCompletionSource.Task;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x000074F8 File Offset: 0x000056F8
	public void TrySetResult(T result)
	{
		foreach (UniTaskCompletionSource<T> uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetResult(result);
		}
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000754C File Offset: 0x0000574C
	public void TrySetCanceled()
	{
		foreach (UniTaskCompletionSource<T> uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetCanceled(default(CancellationToken));
		}
	}

	// Token: 0x040000C3 RID: 195
	private readonly List<UniTaskCompletionSource<T>> Tasks = new List<UniTaskCompletionSource<T>>(1);
}
