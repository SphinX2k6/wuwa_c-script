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
	// Token: 0x060000E7 RID: 231 RVA: 0x00007248 File Offset: 0x00005448
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

	// Token: 0x060000E8 RID: 232 RVA: 0x00007270 File Offset: 0x00005470
	public void TrySetResult(T result)
	{
		foreach (UniTaskCompletionSource<T> uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetResult(result);
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000072C4 File Offset: 0x000054C4
	public void TrySetCanceled()
	{
		foreach (UniTaskCompletionSource<T> uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetCanceled(default(CancellationToken));
		}
	}

	// Token: 0x040000C4 RID: 196
	private readonly List<UniTaskCompletionSource<T>> Tasks = new List<UniTaskCompletionSource<T>>(1);
}
