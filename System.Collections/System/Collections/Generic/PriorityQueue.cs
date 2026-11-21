using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x0200001D RID: 29
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(PriorityQueueDebugView<, >))]
	public class PriorityQueue<[Nullable(2)] TElement, [Nullable(2)] TPriority>
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0000660B File Offset: 0x0000480B
		public PriorityQueue()
		{
			this._nodes = Array.Empty<ValueTuple<TElement, TPriority>>();
			this._comparer = PriorityQueue<TElement, TPriority>.InitializeComparer(null);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000662A File Offset: 0x0000482A
		public PriorityQueue(int initialCapacity) : this(initialCapacity, null)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00006634 File Offset: 0x00004834
		public PriorityQueue([Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TPriority> comparer)
		{
			this._nodes = Array.Empty<ValueTuple<TElement, TPriority>>();
			this._comparer = PriorityQueue<TElement, TPriority>.InitializeComparer(comparer);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00006653 File Offset: 0x00004853
		public PriorityQueue(int initialCapacity, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TPriority> comparer)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(initialCapacity, "initialCapacity");
			this._nodes = new ValueTuple<TElement, TPriority>[initialCapacity];
			this._comparer = PriorityQueue<TElement, TPriority>.InitializeComparer(comparer);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000667E File Offset: 0x0000487E
		public PriorityQueue([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<ValueTuple<TElement, TPriority>> items) : this(items, null)
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00006688 File Offset: 0x00004888
		public PriorityQueue([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<ValueTuple<TElement, TPriority>> items, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<TPriority> comparer)
		{
			ArgumentNullException.ThrowIfNull(items, "items");
			this._nodes = EnumerableHelpers.ToArray<ValueTuple<TElement, TPriority>>(items, out this._size);
			this._comparer = PriorityQueue<TElement, TPriority>.InitializeComparer(comparer);
			if (this._size > 1)
			{
				this.Heapify();
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000066C8 File Offset: 0x000048C8
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000066D0 File Offset: 0x000048D0
		public IComparer<TPriority> Comparer
		{
			get
			{
				return this._comparer ?? Comparer<TPriority>.Default;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000066E4 File Offset: 0x000048E4
		[Nullable(new byte[]
		{
			1,
			0,
			0
		})]
		public PriorityQueue<TElement, TPriority>.UnorderedItemsCollection UnorderedItems
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				0
			})]
			get
			{
				PriorityQueue<TElement, TPriority>.UnorderedItemsCollection result;
				if ((result = this._unorderedItems) == null)
				{
					result = (this._unorderedItems = new PriorityQueue<TElement, TPriority>.UnorderedItemsCollection(this));
				}
				return result;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000670C File Offset: 0x0000490C
		public void Enqueue(TElement element, TPriority priority)
		{
			int size = this._size;
			this._version++;
			if (this._nodes.Length == size)
			{
				this.Grow(size + 1);
			}
			this._size = size + 1;
			if (this._comparer == null)
			{
				this.MoveUpDefaultComparer(new ValueTuple<TElement, TPriority>(element, priority), size);
				return;
			}
			this.MoveUpCustomComparer(new ValueTuple<TElement, TPriority>(element, priority), size);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006770 File Offset: 0x00004970
		public TElement Peek()
		{
			if (this._size == 0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_EmptyQueue);
			}
			return this._nodes[0].Item1;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00006796 File Offset: 0x00004996
		public TElement Dequeue()
		{
			if (this._size == 0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_EmptyQueue);
			}
			TElement item = this._nodes[0].Item1;
			this.RemoveRootNode();
			return item;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000067C4 File Offset: 0x000049C4
		public TElement DequeueEnqueue(TElement element, TPriority priority)
		{
			if (this._size == 0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_EmptyQueue);
			}
			ValueTuple<TElement, TPriority> valueTuple = this._nodes[0];
			if (this._comparer == null)
			{
				if (Comparer<TPriority>.Default.Compare(priority, valueTuple.Item2) > 0)
				{
					this.MoveDownDefaultComparer(new ValueTuple<TElement, TPriority>(element, priority), 0);
				}
				else
				{
					this._nodes[0] = new ValueTuple<TElement, TPriority>(element, priority);
				}
			}
			else if (this._comparer.Compare(priority, valueTuple.Item2) > 0)
			{
				this.MoveDownCustomComparer(new ValueTuple<TElement, TPriority>(element, priority), 0);
			}
			else
			{
				this._nodes[0] = new ValueTuple<TElement, TPriority>(element, priority);
			}
			this._version++;
			return valueTuple.Item1;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006880 File Offset: 0x00004A80
		public bool TryDequeue([MaybeNullWhen(false)] out TElement element, [MaybeNullWhen(false)] out TPriority priority)
		{
			if (this._size != 0)
			{
				ValueTuple<TElement, TPriority> valueTuple = this._nodes[0];
				element = valueTuple.Item1;
				priority = valueTuple.Item2;
				this.RemoveRootNode();
				return true;
			}
			element = default(TElement);
			priority = default(TPriority);
			return false;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000068D4 File Offset: 0x00004AD4
		public bool TryPeek([MaybeNullWhen(false)] out TElement element, [MaybeNullWhen(false)] out TPriority priority)
		{
			if (this._size != 0)
			{
				ValueTuple<TElement, TPriority> valueTuple = this._nodes[0];
				element = valueTuple.Item1;
				priority = valueTuple.Item2;
				return true;
			}
			element = default(TElement);
			priority = default(TPriority);
			return false;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00006920 File Offset: 0x00004B20
		public TElement EnqueueDequeue(TElement element, TPriority priority)
		{
			if (this._size != 0)
			{
				ValueTuple<TElement, TPriority> valueTuple = this._nodes[0];
				if (this._comparer == null)
				{
					if (Comparer<TPriority>.Default.Compare(priority, valueTuple.Item2) > 0)
					{
						this.MoveDownDefaultComparer(new ValueTuple<TElement, TPriority>(element, priority), 0);
						this._version++;
						return valueTuple.Item1;
					}
				}
				else if (this._comparer.Compare(priority, valueTuple.Item2) > 0)
				{
					this.MoveDownCustomComparer(new ValueTuple<TElement, TPriority>(element, priority), 0);
					this._version++;
					return valueTuple.Item1;
				}
			}
			return element;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000069C0 File Offset: 0x00004BC0
		public void EnqueueRange([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<ValueTuple<TElement, TPriority>> items)
		{
			ArgumentNullException.ThrowIfNull(items, "items");
			int num = 0;
			ICollection<ValueTuple<TElement, TPriority>> collection = items as ICollection<ValueTuple<TElement, TPriority>>;
			if (collection != null && (num = collection.Count) > this._nodes.Length - this._size)
			{
				this.Grow(checked(this._size + num));
			}
			if (this._size == 0)
			{
				if (collection != null)
				{
					collection.CopyTo(this._nodes, 0);
					this._size = num;
				}
				else
				{
					int num2 = 0;
					ValueTuple<TElement, TPriority>[] nodes = this._nodes;
					foreach (ValueTuple<TElement, TPriority> valueTuple in items)
					{
						TElement item = valueTuple.Item1;
						TPriority item2 = valueTuple.Item2;
						if (nodes.Length == num2)
						{
							this.Grow(num2 + 1);
							nodes = this._nodes;
						}
						nodes[num2++] = new ValueTuple<TElement, TPriority>(item, item2);
					}
					this._size = num2;
				}
				this._version++;
				if (this._size > 1)
				{
					this.Heapify();
					return;
				}
			}
			else
			{
				foreach (ValueTuple<TElement, TPriority> valueTuple2 in items)
				{
					TElement item3 = valueTuple2.Item1;
					TPriority item4 = valueTuple2.Item2;
					this.Enqueue(item3, item4);
				}
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00006B1C File Offset: 0x00004D1C
		public void EnqueueRange(IEnumerable<TElement> elements, TPriority priority)
		{
			ArgumentNullException.ThrowIfNull(elements, "elements");
			ICollection<TElement> collection = elements as ICollection<!0>;
			int count;
			if (collection != null && (count = collection.Count) > this._nodes.Length - this._size)
			{
				this.Grow(checked(this._size + count));
			}
			if (this._size == 0)
			{
				int num = 0;
				ValueTuple<TElement, TPriority>[] nodes = this._nodes;
				foreach (TElement item in elements)
				{
					if (nodes.Length == num)
					{
						this.Grow(num + 1);
						nodes = this._nodes;
					}
					nodes[num++] = new ValueTuple<TElement, TPriority>(item, priority);
				}
				this._size = num;
				this._version++;
				return;
			}
			foreach (TElement element in elements)
			{
				this.Enqueue(element, priority);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00006C30 File Offset: 0x00004E30
		public bool Remove(TElement element, [MaybeNullWhen(false)] out TElement removedElement, [MaybeNullWhen(false)] out TPriority priority, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<TElement> equalityComparer = null)
		{
			int num = this.FindIndex(element, equalityComparer);
			if (num < 0)
			{
				removedElement = default(TElement);
				priority = default(TPriority);
				return false;
			}
			ValueTuple<TElement, TPriority>[] nodes = this._nodes;
			ValueTuple<TElement, TPriority> valueTuple = nodes[num];
			removedElement = valueTuple.Item1;
			priority = valueTuple.Item2;
			int num2 = this._size - 1;
			this._size = num2;
			int num3 = num2;
			if (num < num3)
			{
				ValueTuple<TElement, TPriority> valueTuple2 = nodes[num3];
				if (this._comparer == null)
				{
					if (Comparer<TPriority>.Default.Compare(valueTuple2.Item2, priority) < 0)
					{
						this.MoveUpDefaultComparer(valueTuple2, num);
					}
					else
					{
						this.MoveDownDefaultComparer(valueTuple2, num);
					}
				}
				else if (this._comparer.Compare(valueTuple2.Item2, priority) < 0)
				{
					this.MoveUpCustomComparer(valueTuple2, num);
				}
				else
				{
					this.MoveDownCustomComparer(valueTuple2, num);
				}
			}
			nodes[num3] = default(ValueTuple<TElement, TPriority>);
			this._version++;
			return true;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00006D27 File Offset: 0x00004F27
		public void Clear()
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<TElement, TPriority>>())
			{
				Array.Clear(this._nodes, 0, this._size);
			}
			this._size = 0;
			this._version++;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006D57 File Offset: 0x00004F57
		public int EnsureCapacity(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (this._nodes.Length < capacity)
			{
				this.Grow(capacity);
				this._version++;
			}
			return this._nodes.Length;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00006D8C File Offset: 0x00004F8C
		public void TrimExcess()
		{
			int num = (int)((double)this._nodes.Length * 0.9);
			if (this._size < num)
			{
				Array.Resize<ValueTuple<TElement, TPriority>>(ref this._nodes, this._size);
				this._version++;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006DD8 File Offset: 0x00004FD8
		private void Grow(int minCapacity)
		{
			int num = 2 * this._nodes.Length;
			if ((ulong)num > (ulong)((long)Array.MaxLength))
			{
				num = Array.MaxLength;
			}
			num = Math.Max(num, this._nodes.Length + 4);
			if (num < minCapacity)
			{
				num = minCapacity;
			}
			Array.Resize<ValueTuple<TElement, TPriority>>(ref this._nodes, num);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00006E24 File Offset: 0x00005024
		private void RemoveRootNode()
		{
			int num = this._size - 1;
			this._size = num;
			int num2 = num;
			this._version++;
			if (num2 > 0)
			{
				ValueTuple<TElement, TPriority> node = this._nodes[num2];
				if (this._comparer == null)
				{
					this.MoveDownDefaultComparer(node, 0);
				}
				else
				{
					this.MoveDownCustomComparer(node, 0);
				}
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<TElement, TPriority>>())
			{
				this._nodes[num2] = default(ValueTuple<TElement, TPriority>);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00006E95 File Offset: 0x00005095
		private static int GetParentIndex(int index)
		{
			return index - 1 >> 2;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00006E9C File Offset: 0x0000509C
		private static int GetFirstChildIndex(int index)
		{
			return (index << 2) + 1;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00006EA4 File Offset: 0x000050A4
		private void Heapify()
		{
			ValueTuple<TElement, TPriority>[] nodes = this._nodes;
			int parentIndex = PriorityQueue<TElement, TPriority>.GetParentIndex(this._size - 1);
			if (this._comparer == null)
			{
				for (int i = parentIndex; i >= 0; i--)
				{
					this.MoveDownDefaultComparer(nodes[i], i);
				}
				return;
			}
			for (int j = parentIndex; j >= 0; j--)
			{
				this.MoveDownCustomComparer(nodes[j], j);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00006F04 File Offset: 0x00005104
		private void MoveUpDefaultComparer([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] ValueTuple<TElement, TPriority> node, int nodeIndex)
		{
			ValueTuple<TElement, TPriority>[] nodes = this._nodes;
			while (nodeIndex > 0)
			{
				int parentIndex = PriorityQueue<TElement, TPriority>.GetParentIndex(nodeIndex);
				ValueTuple<TElement, TPriority> valueTuple = nodes[parentIndex];
				if (Comparer<TPriority>.Default.Compare(node.Item2, valueTuple.Item2) >= 0)
				{
					break;
				}
				nodes[nodeIndex] = valueTuple;
				nodeIndex = parentIndex;
			}
			nodes[nodeIndex] = node;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00006F5C File Offset: 0x0000515C
		private void MoveUpCustomComparer([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] ValueTuple<TElement, TPriority> node, int nodeIndex)
		{
			IComparer<TPriority> comparer = this._comparer;
			ValueTuple<TElement, TPriority>[] nodes = this._nodes;
			while (nodeIndex > 0)
			{
				int parentIndex = PriorityQueue<TElement, TPriority>.GetParentIndex(nodeIndex);
				ValueTuple<TElement, TPriority> valueTuple = nodes[parentIndex];
				if (comparer.Compare(node.Item2, valueTuple.Item2) >= 0)
				{
					break;
				}
				nodes[nodeIndex] = valueTuple;
				nodeIndex = parentIndex;
			}
			nodes[nodeIndex] = node;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00006FB4 File Offset: 0x000051B4
		private void MoveDownDefaultComparer([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] ValueTuple<TElement, TPriority> node, int nodeIndex)
		{
			ValueTuple<TElement, TPriority>[] nodes = this._nodes;
			int size = this._size;
			int num;
			while ((num = PriorityQueue<TElement, TPriority>.GetFirstChildIndex(nodeIndex)) < size)
			{
				ValueTuple<TElement, TPriority> valueTuple = nodes[num];
				int num2 = num;
				int num3 = Math.Min(num + 4, size);
				while (++num < num3)
				{
					ValueTuple<TElement, TPriority> valueTuple2 = nodes[num];
					if (Comparer<TPriority>.Default.Compare(valueTuple2.Item2, valueTuple.Item2) < 0)
					{
						valueTuple = valueTuple2;
						num2 = num;
					}
				}
				if (Comparer<TPriority>.Default.Compare(node.Item2, valueTuple.Item2) <= 0)
				{
					break;
				}
				nodes[nodeIndex] = valueTuple;
				nodeIndex = num2;
			}
			nodes[nodeIndex] = node;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00007054 File Offset: 0x00005254
		private void MoveDownCustomComparer([TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})] ValueTuple<TElement, TPriority> node, int nodeIndex)
		{
			IComparer<TPriority> comparer = this._comparer;
			ValueTuple<TElement, TPriority>[] nodes = this._nodes;
			int size = this._size;
			int num;
			while ((num = PriorityQueue<TElement, TPriority>.GetFirstChildIndex(nodeIndex)) < size)
			{
				ValueTuple<TElement, TPriority> valueTuple = nodes[num];
				int num2 = num;
				int num3 = Math.Min(num + 4, size);
				while (++num < num3)
				{
					ValueTuple<TElement, TPriority> valueTuple2 = nodes[num];
					if (comparer.Compare(valueTuple2.Item2, valueTuple.Item2) < 0)
					{
						valueTuple = valueTuple2;
						num2 = num;
					}
				}
				if (comparer.Compare(node.Item2, valueTuple.Item2) <= 0)
				{
					break;
				}
				nodes[nodeIndex] = valueTuple;
				nodeIndex = num2;
			}
			nodes[nodeIndex] = node;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000070F8 File Offset: 0x000052F8
		private int FindIndex(TElement element, IEqualityComparer<TElement> equalityComparer)
		{
			if (equalityComparer == null)
			{
				equalityComparer = EqualityComparer<TElement>.Default;
			}
			ReadOnlySpan<ValueTuple<TElement, TPriority>> readOnlySpan = this._nodes.AsSpan(0, this._size);
			if (typeof(TElement).IsValueType && equalityComparer == EqualityComparer<TElement>.Default)
			{
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					if (EqualityComparer<TElement>.Default.Equals(element, readOnlySpan[i].Item1))
					{
						return i;
					}
				}
			}
			else
			{
				for (int j = 0; j < readOnlySpan.Length; j++)
				{
					if (equalityComparer.Equals(element, readOnlySpan[j].Item1))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000719B File Offset: 0x0000539B
		private static IComparer<TPriority> InitializeComparer(IComparer<TPriority> comparer)
		{
			if (!typeof(TPriority).IsValueType)
			{
				return comparer ?? Comparer<TPriority>.Default;
			}
			if (comparer == Comparer<TPriority>.Default)
			{
				return null;
			}
			return comparer;
		}

		// Token: 0x0400003A RID: 58
		[TupleElementNames(new string[]
		{
			"Element",
			"Priority"
		})]
		private ValueTuple<TElement, TPriority>[] _nodes;

		// Token: 0x0400003B RID: 59
		private readonly IComparer<TPriority> _comparer;

		// Token: 0x0400003C RID: 60
		private PriorityQueue<TElement, TPriority>.UnorderedItemsCollection _unorderedItems;

		// Token: 0x0400003D RID: 61
		private int _size;

		// Token: 0x0400003E RID: 62
		private int _version;

		// Token: 0x0200001E RID: 30
		[NullableContext(0)]
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(PriorityQueueDebugView<, >))]
		public sealed class UnorderedItemsCollection : IReadOnlyCollection<ValueTuple<TElement, TPriority>>, IEnumerable<ValueTuple<TElement, TPriority>>, IEnumerable, ICollection
		{
			// Token: 0x0600018A RID: 394 RVA: 0x000071C4 File Offset: 0x000053C4
			internal UnorderedItemsCollection(PriorityQueue<TElement, TPriority> queue)
			{
				this._queue = queue;
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x0600018B RID: 395 RVA: 0x000071D3 File Offset: 0x000053D3
			public int Count
			{
				get
				{
					return this._queue._size;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00003922 File Offset: 0x00001B22
			[Nullable(1)]
			object ICollection.SyncRoot
			{
				get
				{
					return this;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x0600018D RID: 397 RVA: 0x00003925 File Offset: 0x00001B25
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600018E RID: 398 RVA: 0x000071E0 File Offset: 0x000053E0
			void ICollection.CopyTo(Array array, int index)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
				}
				if (array.GetLowerBound(0) != 0)
				{
					throw new ArgumentException(SR.Arg_NonZeroLowerBound, "array");
				}
				if (index < 0 || index > array.Length)
				{
					throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (array.Length - index < this._queue._size)
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				try
				{
					Array.Copy(this._queue._nodes, 0, array, index, this._queue._size);
				}
				catch (ArrayTypeMismatchException)
				{
					throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
				}
			}

			// Token: 0x0600018F RID: 399 RVA: 0x000072B0 File Offset: 0x000054B0
			public PriorityQueue<TElement, TPriority>.UnorderedItemsCollection.Enumerator GetEnumerator()
			{
				return new PriorityQueue<TElement, TPriority>.UnorderedItemsCollection.Enumerator(this._queue);
			}

			// Token: 0x06000190 RID: 400 RVA: 0x000072C0 File Offset: 0x000054C0
			[return: TupleElementNames(new string[]
			{
				"Element",
				"Priority"
			})]
			IEnumerator<ValueTuple<TElement, TPriority>> IEnumerable<ValueTuple<!0, !1>>.GetEnumerator()
			{
				if (this._queue.Count != 0)
				{
					return this.GetEnumerator();
				}
				return EnumerableHelpers.GetEmptyEnumerator<ValueTuple<TElement, TPriority>>();
			}

			// Token: 0x06000191 RID: 401 RVA: 0x000072ED File Offset: 0x000054ED
			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable<ValueTuple<!0, !1>>)this).GetEnumerator();
			}

			// Token: 0x0400003F RID: 63
			internal readonly PriorityQueue<TElement, TPriority> _queue;

			// Token: 0x0200001F RID: 31
			public struct Enumerator : IEnumerator<ValueTuple<TElement, TPriority>>, IEnumerator, IDisposable
			{
				// Token: 0x06000192 RID: 402 RVA: 0x000072F5 File Offset: 0x000054F5
				internal Enumerator(PriorityQueue<TElement, TPriority> queue)
				{
					this._queue = queue;
					this._index = 0;
					this._version = queue._version;
					this._current = default(ValueTuple<TElement, TPriority>);
				}

				// Token: 0x06000193 RID: 403 RVA: 0x000049AB File Offset: 0x00002BAB
				public void Dispose()
				{
				}

				// Token: 0x06000194 RID: 404 RVA: 0x00007320 File Offset: 0x00005520
				public bool MoveNext()
				{
					PriorityQueue<TElement, TPriority> queue = this._queue;
					if (this._version == queue._version && this._index < queue._size)
					{
						this._current = queue._nodes[this._index];
						this._index++;
						return true;
					}
					return this.MoveNextRare();
				}

				// Token: 0x06000195 RID: 405 RVA: 0x0000737D File Offset: 0x0000557D
				private bool MoveNextRare()
				{
					if (this._version != this._queue._version)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
					}
					this._index = this._queue._size + 1;
					this._current = default(ValueTuple<TElement, TPriority>);
					return false;
				}

				// Token: 0x1700007F RID: 127
				// (get) Token: 0x06000196 RID: 406 RVA: 0x000073BD File Offset: 0x000055BD
				[TupleElementNames(new string[]
				{
					"Element",
					"Priority"
				})]
				[Nullable(new byte[]
				{
					0,
					1,
					1
				})]
				public ValueTuple<TElement, TPriority> Current
				{
					[return: TupleElementNames(new string[]
					{
						"Element",
						"Priority"
					})]
					[return: Nullable(new byte[]
					{
						0,
						1,
						1
					})]
					get
					{
						return this._current;
					}
				}

				// Token: 0x17000080 RID: 128
				// (get) Token: 0x06000197 RID: 407 RVA: 0x000073C5 File Offset: 0x000055C5
				[Nullable(1)]
				object IEnumerator.Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x06000198 RID: 408 RVA: 0x000073D2 File Offset: 0x000055D2
				void IEnumerator.Reset()
				{
					if (this._version != this._queue._version)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
					}
					this._index = 0;
					this._current = default(ValueTuple<TElement, TPriority>);
				}

				// Token: 0x04000040 RID: 64
				private readonly PriorityQueue<TElement, TPriority> _queue;

				// Token: 0x04000041 RID: 65
				private readonly int _version;

				// Token: 0x04000042 RID: 66
				private int _index;

				// Token: 0x04000043 RID: 67
				private ValueTuple<TElement, TPriority> _current;
			}
		}
	}
}
