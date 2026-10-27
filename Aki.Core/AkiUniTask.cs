using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;

// Token: 0x02000024 RID: 36
public class AkiUniTask
{
	// Token: 0x060000E1 RID: 225 RVA: 0x000073E4 File Offset: 0x000055E4
	public UniTask GetTask()
	{
		UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
		this.Tasks.Add(uniTaskCompletionSource);
		return uniTaskCompletionSource.Task;
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0000740C File Offset: 0x0000560C
	public void TrySetResult()
	{
		foreach (UniTaskCompletionSource uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetResult();
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00007460 File Offset: 0x00005660
	public void TrySetCanceled()
	{
		foreach (UniTaskCompletionSource uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetCanceled(default(CancellationToken));
		}
	}

	// Token: 0x040000C2 RID: 194
	[Nullable(1)]
	private readonly List<UniTaskCompletionSource> Tasks = new List<UniTaskCompletionSource>();
}
