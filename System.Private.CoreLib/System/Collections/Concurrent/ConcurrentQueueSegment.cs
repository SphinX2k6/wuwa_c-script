using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Collections.Concurrent
{
	// Token: 0x0200098F RID: 2447
	[DebuggerDisplay("Capacity = {Capacity}")]
	internal sealed class ConcurrentQueueSegment<T>
	{
		// Token: 0x06009175 RID: 37237 RVA: 0x00167B2C File Offset: 0x00165D2C
		internal ConcurrentQueueSegment(int boundedLength)
		{
			this._slots = new ConcurrentQueueSegment<T>.Slot[boundedLength];
			this._slotsMask = boundedLength - 1;
			for (int i = 0; i < this._slots.Length; i++)
			{
				this._slots[i].SequenceNumber = i;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x00167B79 File Offset: 0x00165D79
		internal int Capacity
		{
			get
			{
				return this._slots.Length;
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06009177 RID: 37239 RVA: 0x00167B83 File Offset: 0x00165D83
		internal int FreezeOffset
		{
			get
			{
				return this._slots.Length * 2;
			}
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x00167B8F File Offset: 0x00165D8F
		internal void EnsureFrozenForEnqueues()
		{
			if (!this._frozenForEnqueues)
			{
				this._frozenForEnqueues = true;
				Interlocked.Add(ref this._headAndTail.Tail, this.FreezeOffset);
			}
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x00167BB8 File Offset: 0x00165DB8
		public bool TryDequeue([MaybeNullWhen(false)] out T item)
		{
			ConcurrentQueueSegment<T>.Slot[] slots = this._slots;
			SpinWait spinWait = default(SpinWait);
			int num;
			int num2;
			for (;;)
			{
				num = Volatile.Read(ref this._headAndTail.Head);
				num2 = (num & this._slotsMask);
				int num3 = Volatile.Read(ref slots[num2].SequenceNumber) - (num + 1);
				if (num3 == 0)
				{
					if (Interlocked.CompareExchange(ref this._headAndTail.Head, num + 1, num) == num)
					{
						break;
					}
				}
				else if (num3 < 0)
				{
					bool frozenForEnqueues = this._frozenForEnqueues;
					int num4 = Volatile.Read(ref this._headAndTail.Tail);
					if (num4 - num <= 0 || (frozenForEnqueues && num4 - this.FreezeOffset - num <= 0))
					{
						goto IL_E6;
					}
					spinWait.SpinOnce(-1);
				}
			}
			item = slots[num2].Item;
			if (!Volatile.Read(ref this._preservedForObservation))
			{
				if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
				{
					slots[num2].Item = default(T);
				}
				Volatile.Write(ref slots[num2].SequenceNumber, num + slots.Length);
			}
			return true;
			IL_E6:
			item = default(T);
			return false;
		}

		// Token: 0x0600917A RID: 37242 RVA: 0x00167CC0 File Offset: 0x00165EC0
		public bool TryPeek([MaybeNullWhen(false)] out T result, bool resultUsed)
		{
			if (resultUsed)
			{
				this._preservedForObservation = true;
				Interlocked.MemoryBarrier();
			}
			ConcurrentQueueSegment<T>.Slot[] slots = this._slots;
			SpinWait spinWait = default(SpinWait);
			int num2;
			for (;;)
			{
				int num = Volatile.Read(ref this._headAndTail.Head);
				num2 = (num & this._slotsMask);
				int num3 = Volatile.Read(ref slots[num2].SequenceNumber) - (num + 1);
				if (num3 == 0)
				{
					break;
				}
				if (num3 < 0)
				{
					bool frozenForEnqueues = this._frozenForEnqueues;
					int num4 = Volatile.Read(ref this._headAndTail.Tail);
					if (num4 - num <= 0 || (frozenForEnqueues && num4 - this.FreezeOffset - num <= 0))
					{
						goto IL_AE;
					}
					spinWait.SpinOnce(-1);
				}
			}
			result = (resultUsed ? slots[num2].Item : default(T));
			return true;
			IL_AE:
			result = default(T);
			return false;
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x00167D90 File Offset: 0x00165F90
		public bool TryEnqueue(T item)
		{
			ConcurrentQueueSegment<T>.Slot[] slots = this._slots;
			int num;
			int num2;
			for (;;)
			{
				num = Volatile.Read(ref this._headAndTail.Tail);
				num2 = (num & this._slotsMask);
				int num3 = Volatile.Read(ref slots[num2].SequenceNumber) - num;
				if (num3 == 0)
				{
					if (Interlocked.CompareExchange(ref this._headAndTail.Tail, num + 1, num) == num)
					{
						break;
					}
				}
				else if (num3 < 0)
				{
					return false;
				}
			}
			slots[num2].Item = item;
			Volatile.Write(ref slots[num2].SequenceNumber, num + 1);
			return true;
		}

		// Token: 0x0400223A RID: 8762
		internal readonly ConcurrentQueueSegment<T>.Slot[] _slots;

		// Token: 0x0400223B RID: 8763
		internal readonly int _slotsMask;

		// Token: 0x0400223C RID: 8764
		internal PaddedHeadAndTail _headAndTail;

		// Token: 0x0400223D RID: 8765
		internal bool _preservedForObservation;

		// Token: 0x0400223E RID: 8766
		internal bool _frozenForEnqueues;

		// Token: 0x0400223F RID: 8767
		internal ConcurrentQueueSegment<T> _nextSegment;

		// Token: 0x02000990 RID: 2448
		[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
		[StructLayout(LayoutKind.Auto)]
		internal struct Slot
		{
			// Token: 0x04002240 RID: 8768
			public T Item;

			// Token: 0x04002241 RID: 8769
			public int SequenceNumber;
		}
	}
}
