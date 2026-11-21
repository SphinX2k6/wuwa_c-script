using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x02000020 RID: 32
	internal sealed class PriorityQueueDebugView<TElement, TPriority>
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00007405 File Offset: 0x00005605
		public PriorityQueueDebugView(PriorityQueue<TElement, TPriority> queue)
		{
			ArgumentNullException.ThrowIfNull(queue, "queue");
			this._queue = queue;
			this._sort = true;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007426 File Offset: 0x00005626
		public PriorityQueueDebugView(PriorityQueue<TElement, TPriority>.UnorderedItemsCollection collection)
		{
			PriorityQueue<TElement, TPriority> priorityQueue = (collection != null) ? collection._queue : null;
			if (priorityQueue == null)
			{
				throw new ArgumentNullException("collection");
			}
			this._queue = priorityQueue;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00007450 File Offset: 0x00005650
		[TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public ValueTuple<TElement, TPriority>[] Items
		{
			[return: TupleElementNames(new string[]
			{
				"Element",
				"Priority"
			})]
			get
			{
				List<ValueTuple<TElement, TPriority>> list = new List<ValueTuple<TElement, TPriority>>(this._queue.UnorderedItems);
				if (this._sort)
				{
					list.Sort(([TupleElementNames(new string[]
					{
						"Element",
						"Priority"
					})] ValueTuple<TElement, TPriority> i1, [TupleElementNames(new string[]
					{
						"Element",
						"Priority"
					})] ValueTuple<TElement, TPriority> i2) => this._queue.Comparer.Compare(i1.Item2, i2.Item2));
				}
				return list.ToArray();
			}
		}

		// Token: 0x04000044 RID: 68
		private readonly PriorityQueue<TElement, TPriority> _queue;

		// Token: 0x04000045 RID: 69
		private readonly bool _sort;
	}
}
