using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;

// Token: 0x02000024 RID: 36
public class AkiUniTask
{
	// Token: 0x060000E3 RID: 227 RVA: 0x0000715C File Offset: 0x0000535C
	public UniTask GetTask()
	{
		UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
		this.Tasks.Add(uniTaskCompletionSource);
		return uniTaskCompletionSource.Task;
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00007184 File Offset: 0x00005384
	public void TrySetResult()
	{
		foreach (UniTaskCompletionSource uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetResult();
		}
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000071D8 File Offset: 0x000053D8
	public void TrySetCanceled()
	{
		foreach (UniTaskCompletionSource uniTaskCompletionSource in this.Tasks)
		{
			uniTaskCompletionSource.TrySetCanceled(default(CancellationToken));
		}
	}

	// Token: 0x040000C3 RID: 195
	[Nullable(1)]
	private readonly List<UniTaskCompletionSource> Tasks = new List<UniTaskCompletionSource>();
}
