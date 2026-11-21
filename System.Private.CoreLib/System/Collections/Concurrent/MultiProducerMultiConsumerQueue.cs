using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Concurrent
{
	// Token: 0x02000995 RID: 2453
	[DebuggerDisplay("Count = {Count}")]
	internal sealed class MultiProducerMultiConsumerQueue<T> : ConcurrentQueue<T>, IProducerConsumerQueue<T>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06009187 RID: 37255 RVA: 0x00167E3B File Offset: 0x0016603B
		void IProducerConsumerQueue<!0>.Enqueue(T item)
		{
			base.Enqueue(item);
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x00167012 File Offset: 0x00165212
		bool IProducerConsumerQueue<!0>.TryDequeue([MaybeNullWhen(false)] out T result)
		{
			return base.TryDequeue(out result);
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x00167E44 File Offset: 0x00166044
		bool IProducerConsumerQueue<!0>.IsEmpty
		{
			get
			{
				return base.IsEmpty;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00167E4C File Offset: 0x0016604C
		int IProducerConsumerQueue<!0>.Count
		{
			get
			{
				return base.Count;
			}
		}

		// Token: 0x0600918B RID: 37259 RVA: 0x00167E4C File Offset: 0x0016604C
		int IProducerConsumerQueue<!0>.GetCountSafe(object syncObj)
		{
			return base.Count;
		}
	}
}
