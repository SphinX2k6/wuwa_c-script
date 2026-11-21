using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Collections.Concurrent
{
	// Token: 0x0200098D RID: 2445
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	public class ConcurrentQueue<[Nullable(2)] T> : IProducerConsumerCollection<T>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06009156 RID: 37206 RVA: 0x00166EDC File Offset: 0x001650DC
		public ConcurrentQueue()
		{
			this._crossSegmentLock = new object();
			this._tail = (this._head = new ConcurrentQueueSegment<T>(32));
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x00166F14 File Offset: 0x00165114
		public ConcurrentQueue(IEnumerable<T> collection)
		{
			if (collection == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
			}
			this._crossSegmentLock = new object();
			int num = 32;
			ICollection<T> collection2 = collection as ICollection<!0>;
			if (collection2 != null)
			{
				int count = collection2.Count;
				if (count > num)
				{
					num = (int)Math.Min(BitOperations.RoundUpToPowerOf2((uint)count), 1048576U);
				}
			}
			this._tail = (this._head = new ConcurrentQueueSegment<T>(num));
			foreach (T item in collection)
			{
				this.Enqueue(item);
			}
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x00166FC0 File Offset: 0x001651C0
		void ICollection.CopyTo(Array array, int index)
		{
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			this.ToArray().CopyTo(array, index);
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x0600915A RID: 37210 RVA: 0x00166FF6 File Offset: 0x001651F6
		object ICollection.SyncRoot
		{
			get
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.ConcurrentCollection_SyncRoot_NotSupported);
				return null;
			}
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x00167000 File Offset: 0x00165200
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x00167008 File Offset: 0x00165208
		bool IProducerConsumerCollection<!0>.TryAdd(T item)
		{
			this.Enqueue(item);
			return true;
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x00167012 File Offset: 0x00165212
		bool IProducerConsumerCollection<!0>.TryTake([MaybeNullWhen(false)] out T item)
		{
			return this.TryDequeue(out item);
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600915E RID: 37214 RVA: 0x0016701C File Offset: 0x0016521C
		public bool IsEmpty
		{
			get
			{
				T t;
				return !this.TryPeek(out t, false);
			}
		}

		// Token: 0x0600915F RID: 37215 RVA: 0x00167038 File Offset: 0x00165238
		public T[] ToArray()
		{
			ConcurrentQueueSegment<T> head;
			int headHead;
			ConcurrentQueueSegment<T> tail;
			int tailTail;
			this.SnapForObservation(out head, out headHead, out tail, out tailTail);
			T[] array = new T[ConcurrentQueue<T>.GetCount(head, headHead, tail, tailTail)];
			using (IEnumerator<T> enumerator = ConcurrentQueue<T>.Enumerate(head, headHead, tail, tailTail))
			{
				int num = 0;
				while (enumerator.MoveNext())
				{
					!0 ! = enumerator.Current;
					array[num++] = !;
				}
			}
			return array;
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x001670B4 File Offset: 0x001652B4
		public int Count
		{
			get
			{
				SpinWait spinWait = default(SpinWait);
				ConcurrentQueueSegment<T> head;
				ConcurrentQueueSegment<T> tail;
				int num;
				int num2;
				int num3;
				int num4;
				for (;;)
				{
					head = this._head;
					tail = this._tail;
					num = Volatile.Read(ref head._headAndTail.Head);
					num2 = Volatile.Read(ref head._headAndTail.Tail);
					if (head == tail)
					{
						if (head == this._head && tail == this._tail && num == Volatile.Read(ref head._headAndTail.Head) && num2 == Volatile.Read(ref head._headAndTail.Tail))
						{
							break;
						}
					}
					else if (head._nextSegment == tail)
					{
						num3 = Volatile.Read(ref tail._headAndTail.Head);
						num4 = Volatile.Read(ref tail._headAndTail.Tail);
						if (head == this._head && tail == this._tail && num == Volatile.Read(ref head._headAndTail.Head) && num2 == Volatile.Read(ref head._headAndTail.Tail) && num3 == Volatile.Read(ref tail._headAndTail.Head) && num4 == Volatile.Read(ref tail._headAndTail.Tail))
						{
							goto Block_12;
						}
					}
					else
					{
						object crossSegmentLock = this._crossSegmentLock;
						lock (crossSegmentLock)
						{
							if (head == this._head && tail == this._tail)
							{
								int num5 = Volatile.Read(ref tail._headAndTail.Head);
								int num6 = Volatile.Read(ref tail._headAndTail.Tail);
								if (num == Volatile.Read(ref head._headAndTail.Head) && num2 == Volatile.Read(ref head._headAndTail.Tail) && num5 == Volatile.Read(ref tail._headAndTail.Head) && num6 == Volatile.Read(ref tail._headAndTail.Tail))
								{
									int num7 = ConcurrentQueue<T>.GetCount(head, num, num2) + ConcurrentQueue<T>.GetCount(tail, num5, num6);
									for (ConcurrentQueueSegment<T> nextSegment = head._nextSegment; nextSegment != tail; nextSegment = nextSegment._nextSegment)
									{
										num7 += nextSegment._headAndTail.Tail - nextSegment.FreezeOffset;
									}
									return num7;
								}
							}
						}
					}
					spinWait.SpinOnce();
				}
				return ConcurrentQueue<T>.GetCount(head, num, num2);
				Block_12:
				return ConcurrentQueue<T>.GetCount(head, num, num2) + ConcurrentQueue<T>.GetCount(tail, num3, num4);
			}
		}

		// Token: 0x06009161 RID: 37217 RVA: 0x00167330 File Offset: 0x00165530
		private static int GetCount(ConcurrentQueueSegment<T> s, int head, int tail)
		{
			if (head == tail || head == tail - s.FreezeOffset)
			{
				return 0;
			}
			head &= s._slotsMask;
			tail &= s._slotsMask;
			if (head >= tail)
			{
				return s._slots.Length - head + tail;
			}
			return tail - head;
		}

		// Token: 0x06009162 RID: 37218 RVA: 0x0016736C File Offset: 0x0016556C
		private static long GetCount(ConcurrentQueueSegment<T> head, int headHead, ConcurrentQueueSegment<T> tail, int tailTail)
		{
			long num = 0L;
			int num2 = ((head == tail) ? tailTail : Volatile.Read(ref head._headAndTail.Tail)) - head.FreezeOffset;
			if (headHead < num2)
			{
				headHead &= head._slotsMask;
				num2 &= head._slotsMask;
				num += (long)((headHead < num2) ? (num2 - headHead) : (head._slots.Length - headHead + num2));
			}
			if (head != tail)
			{
				for (ConcurrentQueueSegment<T> nextSegment = head._nextSegment; nextSegment != tail; nextSegment = nextSegment._nextSegment)
				{
					num += (long)(nextSegment._headAndTail.Tail - nextSegment.FreezeOffset);
				}
				num += (long)(tailTail - tail.FreezeOffset);
			}
			return num;
		}

		// Token: 0x06009163 RID: 37219 RVA: 0x00167408 File Offset: 0x00165608
		public void CopyTo(T[] array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			ConcurrentQueueSegment<T> head;
			int headHead;
			ConcurrentQueueSegment<T> tail;
			int tailTail;
			this.SnapForObservation(out head, out headHead, out tail, out tailTail);
			long count = ConcurrentQueue<T>.GetCount(head, headHead, tail, tailTail);
			if ((long)index > (long)array.Length - count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			int num = index;
			using (IEnumerator<T> enumerator = ConcurrentQueue<T>.Enumerate(head, headHead, tail, tailTail))
			{
				while (enumerator.MoveNext())
				{
					!0 ! = enumerator.Current;
					array[num++] = !;
				}
			}
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x001674A0 File Offset: 0x001656A0
		public IEnumerator<T> GetEnumerator()
		{
			ConcurrentQueueSegment<T> head;
			int headHead;
			ConcurrentQueueSegment<T> tail;
			int tailTail;
			this.SnapForObservation(out head, out headHead, out tail, out tailTail);
			return ConcurrentQueue<T>.Enumerate(head, headHead, tail, tailTail);
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x001674C4 File Offset: 0x001656C4
		private void SnapForObservation(out ConcurrentQueueSegment<T> head, out int headHead, out ConcurrentQueueSegment<T> tail, out int tailTail)
		{
			object crossSegmentLock = this._crossSegmentLock;
			lock (crossSegmentLock)
			{
				head = this._head;
				tail = this._tail;
				ConcurrentQueueSegment<T> concurrentQueueSegment = head;
				for (;;)
				{
					concurrentQueueSegment._preservedForObservation = true;
					if (concurrentQueueSegment == tail)
					{
						break;
					}
					concurrentQueueSegment = concurrentQueueSegment._nextSegment;
				}
				tail.EnsureFrozenForEnqueues();
				headHead = Volatile.Read(ref head._headAndTail.Head);
				tailTail = Volatile.Read(ref tail._headAndTail.Tail);
			}
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x00167558 File Offset: 0x00165758
		private static T GetItemWhenAvailable(ConcurrentQueueSegment<T> segment, int i)
		{
			int num = i + 1 & segment._slotsMask;
			SpinWait spinWait = default(SpinWait);
			while ((Volatile.Read(ref segment._slots[i].SequenceNumber) & segment._slotsMask) != num)
			{
				spinWait.SpinOnce();
			}
			return segment._slots[i].Item;
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x001675B2 File Offset: 0x001657B2
		private static IEnumerator<T> Enumerate(ConcurrentQueueSegment<T> head, int headHead, ConcurrentQueueSegment<T> tail, int tailTail)
		{
			int headTail = ((head == tail) ? tailTail : Volatile.Read(ref head._headAndTail.Tail)) - head.FreezeOffset;
			if (headHead < headTail)
			{
				headHead &= head._slotsMask;
				headTail &= head._slotsMask;
				if (headHead < headTail)
				{
					int num;
					for (int i = headHead; i < headTail; i = num + 1)
					{
						yield return ConcurrentQueue<T>.GetItemWhenAvailable(head, i);
						num = i;
					}
				}
				else
				{
					int num;
					for (int i = headHead; i < head._slots.Length; i = num + 1)
					{
						yield return ConcurrentQueue<T>.GetItemWhenAvailable(head, i);
						num = i;
					}
					for (int i = 0; i < headTail; i = num + 1)
					{
						yield return ConcurrentQueue<T>.GetItemWhenAvailable(head, i);
						num = i;
					}
				}
			}
			if (head != tail)
			{
				int num;
				ConcurrentQueueSegment<T> s;
				for (s = head._nextSegment; s != tail; s = s._nextSegment)
				{
					int i = s._headAndTail.Tail - s.FreezeOffset;
					for (int j = 0; j < i; j = num + 1)
					{
						yield return ConcurrentQueue<T>.GetItemWhenAvailable(s, j);
						num = j;
					}
				}
				s = null;
				tailTail -= tail.FreezeOffset;
				for (int i = 0; i < tailTail; i = num + 1)
				{
					yield return ConcurrentQueue<T>.GetItemWhenAvailable(tail, i);
					num = i;
				}
			}
			yield break;
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x001675D6 File Offset: 0x001657D6
		public void Enqueue(T item)
		{
			if (!this._tail.TryEnqueue(item))
			{
				this.EnqueueSlow(item);
			}
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x001675F0 File Offset: 0x001657F0
		private void EnqueueSlow(T item)
		{
			for (;;)
			{
				ConcurrentQueueSegment<T> tail = this._tail;
				if (tail.TryEnqueue(item))
				{
					break;
				}
				object crossSegmentLock = this._crossSegmentLock;
				lock (crossSegmentLock)
				{
					if (tail == this._tail)
					{
						tail.EnsureFrozenForEnqueues();
						ConcurrentQueueSegment<T> concurrentQueueSegment = new ConcurrentQueueSegment<T>(tail._preservedForObservation ? 32 : Math.Min(tail.Capacity * 2, 1048576));
						tail._nextSegment = concurrentQueueSegment;
						this._tail = concurrentQueueSegment;
					}
				}
			}
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x00167690 File Offset: 0x00165890
		public bool TryDequeue([MaybeNullWhen(false)] out T result)
		{
			ConcurrentQueueSegment<T> head = this._head;
			if (head.TryDequeue(out result))
			{
				return true;
			}
			if (head._nextSegment == null)
			{
				result = default(T);
				return false;
			}
			return this.TryDequeueSlow(out result);
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x001676CC File Offset: 0x001658CC
		private bool TryDequeueSlow([MaybeNullWhen(false)] out T item)
		{
			for (;;)
			{
				ConcurrentQueueSegment<T> head = this._head;
				if (head.TryDequeue(out item))
				{
					break;
				}
				if (head._nextSegment == null)
				{
					goto Block_1;
				}
				if (head.TryDequeue(out item))
				{
					return true;
				}
				object crossSegmentLock = this._crossSegmentLock;
				lock (crossSegmentLock)
				{
					if (head == this._head)
					{
						this._head = head._nextSegment;
					}
				}
			}
			return true;
			Block_1:
			item = default(T);
			return false;
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x0016775C File Offset: 0x0016595C
		public bool TryPeek([MaybeNullWhen(false)] out T result)
		{
			return this.TryPeek(out result, true);
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x00167768 File Offset: 0x00165968
		private bool TryPeek([MaybeNullWhen(false)] out T result, bool resultUsed)
		{
			ConcurrentQueueSegment<T> concurrentQueueSegment = this._head;
			for (;;)
			{
				ConcurrentQueueSegment<T> concurrentQueueSegment2 = Volatile.Read<ConcurrentQueueSegment<T>>(ref concurrentQueueSegment._nextSegment);
				if (concurrentQueueSegment.TryPeek(out result, resultUsed))
				{
					break;
				}
				if (concurrentQueueSegment2 != null)
				{
					concurrentQueueSegment = concurrentQueueSegment2;
				}
				else if (Volatile.Read<ConcurrentQueueSegment<T>>(ref concurrentQueueSegment._nextSegment) == null)
				{
					goto Block_3;
				}
			}
			return true;
			Block_3:
			result = default(T);
			return false;
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x001677B4 File Offset: 0x001659B4
		public void Clear()
		{
			object crossSegmentLock = this._crossSegmentLock;
			lock (crossSegmentLock)
			{
				this._tail.EnsureFrozenForEnqueues();
				this._tail = (this._head = new ConcurrentQueueSegment<T>(32));
			}
		}

		// Token: 0x0400222D RID: 8749
		private readonly object _crossSegmentLock;

		// Token: 0x0400222E RID: 8750
		private volatile ConcurrentQueueSegment<T> _tail;

		// Token: 0x0400222F RID: 8751
		private volatile ConcurrentQueueSegment<T> _head;
	}
}
