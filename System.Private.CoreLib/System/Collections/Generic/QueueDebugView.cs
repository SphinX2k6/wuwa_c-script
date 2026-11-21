using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x020009DE RID: 2526
	internal sealed class QueueDebugView<T>
	{
		// Token: 0x060093D4 RID: 37844 RVA: 0x00171096 File Offset: 0x0016F296
		public QueueDebugView(Queue<T> queue)
		{
			ArgumentNullException.ThrowIfNull(queue, "queue");
			this._queue = queue;
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060093D5 RID: 37845 RVA: 0x001710B0 File Offset: 0x0016F2B0
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				return this._queue.ToArray();
			}
		}

		// Token: 0x040022AD RID: 8877
		private readonly Queue<T> _queue;
	}
}
