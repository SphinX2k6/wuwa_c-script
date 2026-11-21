using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using Internal;

namespace System.Collections.Concurrent
{
	// Token: 0x02000996 RID: 2454
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(SingleProducerSingleConsumerQueue<>.SingleProducerSingleConsumerQueue_DebugView))]
	internal sealed class SingleProducerSingleConsumerQueue<T> : IProducerConsumerQueue<T>, IEnumerable<!0>, IEnumerable
	{
		// Token: 0x0600918D RID: 37261 RVA: 0x00167E5C File Offset: 0x0016605C
		public SingleProducerSingleConsumerQueue()
		{
			this._head = (this._tail = new SingleProducerSingleConsumerQueue<T>.Segment(32));
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x00167E8C File Offset: 0x0016608C
		public void Enqueue(T item)
		{
			SingleProducerSingleConsumerQueue<T>.Segment tail = this._tail;
			T[] array = tail._array;
			int last = tail._state._last;
			int num = last + 1 & array.Length - 1;
			if (num != tail._state._firstCopy)
			{
				array[last] = item;
				tail._state._last = num;
				return;
			}
			this.EnqueueSlow(item, ref tail);
		}

		// Token: 0x0600918F RID: 37263 RVA: 0x00167EF0 File Offset: 0x001660F0
		private void EnqueueSlow(T item, ref SingleProducerSingleConsumerQueue<T>.Segment segment)
		{
			if (segment._state._firstCopy != segment._state._first)
			{
				segment._state._firstCopy = segment._state._first;
				this.Enqueue(item);
				return;
			}
			SingleProducerSingleConsumerQueue<T>.Segment segment2 = new SingleProducerSingleConsumerQueue<T>.Segment(Math.Min(this._tail._array.Length * 2, 16777216));
			segment2._array[0] = item;
			segment2._state._last = 1;
			segment2._state._lastCopy = 1;
			try
			{
			}
			finally
			{
				Volatile.Write<SingleProducerSingleConsumerQueue<T>.Segment>(ref this._tail._next, segment2);
				this._tail = segment2;
			}
		}

		// Token: 0x06009190 RID: 37264 RVA: 0x00167FB4 File Offset: 0x001661B4
		public bool TryDequeue([MaybeNullWhen(false)] out T result)
		{
			SingleProducerSingleConsumerQueue<T>.Segment head = this._head;
			T[] array = head._array;
			int first = head._state._first;
			if (first != head._state._lastCopy)
			{
				result = array[first];
				array[first] = default(T);
				head._state._first = (first + 1 & array.Length - 1);
				return true;
			}
			return this.TryDequeueSlow(head, array, false, out result);
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x0016802C File Offset: 0x0016622C
		public bool TryPeek([MaybeNullWhen(false)] out T result)
		{
			SingleProducerSingleConsumerQueue<T>.Segment head = this._head;
			T[] array = head._array;
			int first = head._state._first;
			if (first != head._state._lastCopy)
			{
				result = array[first];
				return true;
			}
			return this.TryDequeueSlow(head, array, true, out result);
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x00168080 File Offset: 0x00166280
		private bool TryDequeueSlow(SingleProducerSingleConsumerQueue<T>.Segment segment, T[] array, bool peek, [MaybeNullWhen(false)] out T result)
		{
			if (segment._state._last != segment._state._lastCopy)
			{
				segment._state._lastCopy = segment._state._last;
				if (!peek)
				{
					return this.TryDequeue(out result);
				}
				return this.TryPeek(out result);
			}
			else
			{
				if (segment._next != null && segment._state._first == segment._state._last)
				{
					segment = segment._next;
					array = segment._array;
					this._head = segment;
				}
				int first = segment._state._first;
				if (first == segment._state._last)
				{
					result = default(T);
					return false;
				}
				result = array[first];
				if (!peek)
				{
					array[first] = default(T);
					segment._state._first = (first + 1 & segment._array.Length - 1);
					segment._state._lastCopy = segment._state._last;
				}
				return true;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x00168190 File Offset: 0x00166390
		public bool IsEmpty
		{
			get
			{
				SingleProducerSingleConsumerQueue<T>.Segment head = this._head;
				return head._state._first == head._state._lastCopy && head._state._first == head._state._last && head._next == null;
			}
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x001681E9 File Offset: 0x001663E9
		public IEnumerator<T> GetEnumerator()
		{
			SingleProducerSingleConsumerQueue<T>.Segment segment;
			for (segment = this._head; segment != null; segment = segment._next)
			{
				for (int pt = segment._state._first; pt != segment._state._last; pt = (pt + 1 & segment._array.Length - 1))
				{
					yield return segment._array[pt];
				}
			}
			segment = null;
			yield break;
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x001681F8 File Offset: 0x001663F8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06009196 RID: 37270 RVA: 0x00168200 File Offset: 0x00166400
		public int Count
		{
			get
			{
				int num = 0;
				for (SingleProducerSingleConsumerQueue<T>.Segment segment = this._head; segment != null; segment = segment._next)
				{
					int num2 = segment._array.Length;
					int first;
					int last;
					do
					{
						first = segment._state._first;
						last = segment._state._last;
					}
					while (first != segment._state._first);
					num += (last - first & num2 - 1);
				}
				return num;
			}
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x00168268 File Offset: 0x00166468
		int IProducerConsumerQueue<!0>.GetCountSafe(object syncObj)
		{
			int count;
			lock (syncObj)
			{
				count = this.Count;
			}
			return count;
		}

		// Token: 0x04002245 RID: 8773
		private volatile SingleProducerSingleConsumerQueue<T>.Segment _head;

		// Token: 0x04002246 RID: 8774
		private volatile SingleProducerSingleConsumerQueue<T>.Segment _tail;

		// Token: 0x02000997 RID: 2455
		[StructLayout(LayoutKind.Sequential)]
		private sealed class Segment
		{
			// Token: 0x06009198 RID: 37272 RVA: 0x001682A8 File Offset: 0x001664A8
			internal Segment(int size)
			{
				this._array = new T[size];
			}

			// Token: 0x04002247 RID: 8775
			internal SingleProducerSingleConsumerQueue<T>.Segment _next;

			// Token: 0x04002248 RID: 8776
			internal readonly T[] _array;

			// Token: 0x04002249 RID: 8777
			internal SingleProducerSingleConsumerQueue<T>.SegmentState _state;
		}

		// Token: 0x02000998 RID: 2456
		private struct SegmentState
		{
			// Token: 0x0400224A RID: 8778
			internal PaddingFor32 _pad0;

			// Token: 0x0400224B RID: 8779
			internal volatile int _first;

			// Token: 0x0400224C RID: 8780
			internal int _lastCopy;

			// Token: 0x0400224D RID: 8781
			internal PaddingFor32 _pad1;

			// Token: 0x0400224E RID: 8782
			internal int _firstCopy;

			// Token: 0x0400224F RID: 8783
			internal volatile int _last;

			// Token: 0x04002250 RID: 8784
			internal PaddingFor32 _pad2;
		}

		// Token: 0x02000999 RID: 2457
		private sealed class SingleProducerSingleConsumerQueue_DebugView
		{
			// Token: 0x06009199 RID: 37273 RVA: 0x001682BC File Offset: 0x001664BC
			public SingleProducerSingleConsumerQueue_DebugView(SingleProducerSingleConsumerQueue<T> queue)
			{
				this._queue = queue;
			}

			// Token: 0x170013CE RID: 5070
			// (get) Token: 0x0600919A RID: 37274 RVA: 0x001682CB File Offset: 0x001664CB
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public T[] Items
			{
				get
				{
					return new List<T>(this._queue).ToArray();
				}
			}

			// Token: 0x04002251 RID: 8785
			private readonly SingleProducerSingleConsumerQueue<T> _queue;
		}
	}
}
