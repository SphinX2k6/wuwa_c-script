using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x02000038 RID: 56
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SortedSet<[Nullable(2)] T> : ISet<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable, ICollection, IReadOnlyCollection<T>, IReadOnlySet<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x06000283 RID: 643 RVA: 0x000096BB File Offset: 0x000078BB
		public SortedSet()
		{
			this.comparer = Comparer<T>.Default;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000096CE File Offset: 0x000078CE
		public SortedSet([Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer)
		{
			this.comparer = (comparer ?? Comparer<T>.Default);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000096E6 File Offset: 0x000078E6
		public SortedSet(IEnumerable<T> collection) : this(collection, Comparer<T>.Default)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000096F4 File Offset: 0x000078F4
		public SortedSet(IEnumerable<T> collection, [Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer) : this(comparer)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			SortedSet<T> sortedSet = collection as SortedSet<T>;
			if (sortedSet != null && !(sortedSet is SortedSet<T>.TreeSubSet) && this.HasEqualComparer(sortedSet))
			{
				if (sortedSet.Count > 0)
				{
					this.count = sortedSet.count;
					this.root = sortedSet.root.DeepClone(this.count);
				}
				return;
			}
			int num;
			T[] array = EnumerableHelpers.ToArray<T>(collection, out num);
			if (num > 0)
			{
				comparer = this.comparer;
				Array.Sort<T>(array, 0, num, comparer);
				int num2 = 1;
				for (int i = 1; i < num; i++)
				{
					if (comparer.Compare(array[i], array[i - 1]) != 0)
					{
						array[num2++] = array[i];
					}
				}
				num = num2;
				this.root = SortedSet<T>.ConstructRootFromSortedArray(array, 0, num - 1, null);
				this.count = num;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000097D2 File Offset: 0x000079D2
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SortedSet(SerializationInfo info, StreamingContext context)
		{
			this.siInfo = info;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000097E4 File Offset: 0x000079E4
		private void AddAllElements(IEnumerable<T> collection)
		{
			foreach (T item in collection)
			{
				if (!this.Contains(item))
				{
					this.Add(item);
				}
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00009838 File Offset: 0x00007A38
		private void RemoveAllElements(IEnumerable<T> collection)
		{
			T min = this.Min;
			T max = this.Max;
			foreach (T t in collection)
			{
				if (this.comparer.Compare(t, min) >= 0 && this.comparer.Compare(t, max) <= 0 && this.Contains(t))
				{
					this.Remove(t);
				}
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000098B8 File Offset: 0x00007AB8
		private bool ContainsAllElements(IEnumerable<T> collection)
		{
			foreach (T item in collection)
			{
				if (!this.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000990C File Offset: 0x00007B0C
		internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action)
		{
			if (this.root == null)
			{
				return true;
			}
			Stack<SortedSet<T>.Node> stack = new Stack<SortedSet<T>.Node>(2 * SortedSet<T>.Log2(this.Count + 1));
			for (SortedSet<T>.Node node = this.root; node != null; node = node.Left)
			{
				stack.Push(node);
			}
			while (stack.Count != 0)
			{
				SortedSet<T>.Node node = stack.Pop();
				if (!action(node))
				{
					return false;
				}
				for (SortedSet<T>.Node node2 = node.Right; node2 != null; node2 = node2.Left)
				{
					stack.Push(node2);
				}
			}
			return true;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000998C File Offset: 0x00007B8C
		internal virtual bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action)
		{
			if (this.root == null)
			{
				return true;
			}
			Queue<SortedSet<T>.Node> queue = new Queue<SortedSet<T>.Node>();
			queue.Enqueue(this.root);
			while (queue.Count != 0)
			{
				SortedSet<T>.Node node = queue.Dequeue();
				if (!action(node))
				{
					return false;
				}
				if (node.Left != null)
				{
					queue.Enqueue(node.Left);
				}
				if (node.Right != null)
				{
					queue.Enqueue(node.Right);
				}
			}
			return true;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000099FA File Offset: 0x00007BFA
		public int Count
		{
			get
			{
				this.VersionCheck(true);
				return this.count;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00009A09 File Offset: 0x00007C09
		public IComparer<T> Comparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00003922 File Offset: 0x00001B22
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000049AB File Offset: 0x00002BAB
		internal virtual void VersionCheck(bool updateCount = false)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00009A11 File Offset: 0x00007C11
		internal virtual int TotalCount()
		{
			return this.Count;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003ED3 File Offset: 0x000020D3
		internal virtual bool IsWithinRange(T item)
		{
			return true;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00009A19 File Offset: 0x00007C19
		public bool Add(T item)
		{
			return this.AddIfNotPresent(item);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00009A22 File Offset: 0x00007C22
		void ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00009A2C File Offset: 0x00007C2C
		internal virtual bool AddIfNotPresent(T item)
		{
			if (this.root == null)
			{
				this.root = new SortedSet<T>.Node(item, NodeColor.Black);
				this.count = 1;
				this.version++;
				return true;
			}
			SortedSet<T>.Node node = this.root;
			SortedSet<T>.Node node2 = null;
			SortedSet<T>.Node node3 = null;
			SortedSet<T>.Node greatGrandParent = null;
			this.version++;
			int num = 0;
			while (node != null)
			{
				num = this.comparer.Compare(item, node.Item);
				if (num == 0)
				{
					this.root.ColorBlack();
					return false;
				}
				if (node.Is4Node)
				{
					node.Split4Node();
					if (SortedSet<T>.Node.IsNonNullRed(node2))
					{
						this.InsertionBalance(node, ref node2, node3, greatGrandParent);
					}
				}
				greatGrandParent = node3;
				node3 = node2;
				node2 = node;
				node = ((num < 0) ? node.Left : node.Right);
			}
			SortedSet<T>.Node node4 = new SortedSet<T>.Node(item, NodeColor.Red);
			if (num > 0)
			{
				node2.Right = node4;
			}
			else
			{
				node2.Left = node4;
			}
			if (node2.IsRed)
			{
				this.InsertionBalance(node4, ref node2, node3, greatGrandParent);
			}
			this.root.ColorBlack();
			this.count++;
			return true;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00009B36 File Offset: 0x00007D36
		public bool Remove(T item)
		{
			return this.DoRemove(item);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00009B40 File Offset: 0x00007D40
		internal virtual bool DoRemove(T item)
		{
			if (this.root == null)
			{
				return false;
			}
			this.version++;
			SortedSet<T>.Node node = this.root;
			SortedSet<T>.Node node2 = null;
			SortedSet<T>.Node node3 = null;
			SortedSet<T>.Node node4 = null;
			SortedSet<T>.Node parentOfMatch = null;
			bool flag = false;
			while (node != null)
			{
				if (node.Is2Node)
				{
					if (node2 == null)
					{
						node.ColorRed();
					}
					else
					{
						SortedSet<T>.Node sibling = node2.GetSibling(node);
						if (sibling.IsRed)
						{
							if (node2.Right == sibling)
							{
								node2.RotateLeft();
							}
							else
							{
								node2.RotateRight();
							}
							node2.ColorRed();
							sibling.ColorBlack();
							this.ReplaceChildOrRoot(node3, node2, sibling);
							node3 = sibling;
							if (node2 == node4)
							{
								parentOfMatch = sibling;
							}
							sibling = node2.GetSibling(node);
						}
						if (sibling.Is2Node)
						{
							node2.Merge2Nodes();
						}
						else
						{
							SortedSet<T>.Node node5 = node2.Rotate(node2.GetRotation(node, sibling));
							node5.Color = node2.Color;
							node2.ColorBlack();
							node.ColorRed();
							this.ReplaceChildOrRoot(node3, node2, node5);
							if (node2 == node4)
							{
								parentOfMatch = node5;
							}
						}
					}
				}
				int num = flag ? -1 : this.comparer.Compare(item, node.Item);
				if (num == 0)
				{
					flag = true;
					node4 = node;
					parentOfMatch = node2;
				}
				node3 = node2;
				node2 = node;
				node = ((num < 0) ? node.Left : node.Right);
			}
			if (node4 != null)
			{
				this.ReplaceNode(node4, parentOfMatch, node2, node3);
				this.count--;
			}
			SortedSet<T>.Node node6 = this.root;
			if (node6 != null)
			{
				node6.ColorBlack();
			}
			return flag;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00009CA9 File Offset: 0x00007EA9
		public virtual void Clear()
		{
			this.root = null;
			this.count = 0;
			this.version++;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00009CC7 File Offset: 0x00007EC7
		public virtual bool Contains(T item)
		{
			return this.FindNode(item) != null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00009CD3 File Offset: 0x00007ED3
		public void CopyTo(T[] array)
		{
			this.CopyTo(array, 0, this.Count);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00009CE3 File Offset: 0x00007EE3
		public void CopyTo(T[] array, int index)
		{
			this.CopyTo(array, index, this.Count);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public void CopyTo(T[] array, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (count > array.Length - index)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			count += index;
			this.InOrderTreeWalk(delegate(SortedSet<T>.Node node)
			{
				if (index >= count)
				{
					return false;
				}
				T[] array2 = array;
				int index2 = index;
				index = index2 + 1;
				array2[index2] = node.Item;
				return true;
			});
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00009D94 File Offset: 0x00007F94
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
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException(SR.Arg_ArrayPlusOffTooSmall);
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			object[] objects = array as object[];
			if (objects == null)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
			try
			{
				this.InOrderTreeWalk(delegate(SortedSet<T>.Node node)
				{
					object[] objects = objects;
					int index2 = index;
					index = index2 + 1;
					objects[index2] = node.Item;
					return true;
				});
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00009E90 File Offset: 0x00008090
		[NullableContext(0)]
		public SortedSet<T>.Enumerator GetEnumerator()
		{
			return new SortedSet<T>.Enumerator(this);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00009E98 File Offset: 0x00008098
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000484C File Offset: 0x00002A4C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00009EA8 File Offset: 0x000080A8
		private void InsertionBalance(SortedSet<T>.Node current, ref SortedSet<T>.Node parent, SortedSet<T>.Node grandParent, SortedSet<T>.Node greatGrandParent)
		{
			bool flag = grandParent.Right == parent;
			bool flag2 = parent.Right == current;
			SortedSet<T>.Node node;
			if (flag == flag2)
			{
				node = (flag2 ? grandParent.RotateLeft() : grandParent.RotateRight());
			}
			else
			{
				node = (flag2 ? grandParent.RotateLeftRight() : grandParent.RotateRightLeft());
				parent = greatGrandParent;
			}
			grandParent.ColorRed();
			node.ColorBlack();
			this.ReplaceChildOrRoot(greatGrandParent, grandParent, node);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00009F0D File Offset: 0x0000810D
		private void ReplaceChildOrRoot(SortedSet<T>.Node parent, SortedSet<T>.Node child, SortedSet<T>.Node newChild)
		{
			if (parent != null)
			{
				parent.ReplaceChild(child, newChild);
				return;
			}
			this.root = newChild;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009F24 File Offset: 0x00008124
		private void ReplaceNode(SortedSet<T>.Node match, SortedSet<T>.Node parentOfMatch, SortedSet<T>.Node successor, SortedSet<T>.Node parentOfSuccessor)
		{
			if (successor == match)
			{
				successor = match.Left;
			}
			else
			{
				SortedSet<T>.Node right = successor.Right;
				if (right != null)
				{
					right.ColorBlack();
				}
				if (parentOfSuccessor != match)
				{
					parentOfSuccessor.Left = successor.Right;
					successor.Right = match.Right;
				}
				successor.Left = match.Left;
			}
			if (successor != null)
			{
				successor.Color = match.Color;
			}
			this.ReplaceChildOrRoot(parentOfMatch, match, successor);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009F94 File Offset: 0x00008194
		internal virtual SortedSet<T>.Node FindNode(T item)
		{
			int num;
			for (SortedSet<T>.Node node = this.root; node != null; node = ((num < 0) ? node.Left : node.Right))
			{
				num = this.comparer.Compare(item, node.Item);
				if (num == 0)
				{
					return node;
				}
			}
			return null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009FDC File Offset: 0x000081DC
		internal virtual int InternalIndexOf(T item)
		{
			SortedSet<T>.Node node = this.root;
			int num = 0;
			while (node != null)
			{
				int num2 = this.comparer.Compare(item, node.Item);
				if (num2 == 0)
				{
					return num;
				}
				node = ((num2 < 0) ? node.Left : node.Right);
				num = ((num2 < 0) ? (2 * num + 1) : (2 * num + 2));
			}
			return -1;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000A034 File Offset: 0x00008234
		internal SortedSet<T>.Node FindRange(T from, T to, bool lowerBoundActive, bool upperBoundActive)
		{
			SortedSet<T>.Node node = this.root;
			while (node != null)
			{
				if (lowerBoundActive && this.comparer.Compare(from, node.Item) > 0)
				{
					node = node.Right;
				}
				else
				{
					if (!upperBoundActive || this.comparer.Compare(to, node.Item) >= 0)
					{
						return node;
					}
					node = node.Left;
				}
			}
			return null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000A093 File Offset: 0x00008293
		internal void UpdateVersion()
		{
			this.version++;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000A0A3 File Offset: 0x000082A3
		public static IEqualityComparer<SortedSet<T>> CreateSetComparer()
		{
			return SortedSet<T>.CreateSetComparer(null);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000A0AB File Offset: 0x000082AB
		public static IEqualityComparer<SortedSet<T>> CreateSetComparer([Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> memberEqualityComparer)
		{
			return new SortedSetEqualityComparer<T>(memberEqualityComparer);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000A0B4 File Offset: 0x000082B4
		internal static bool SortedSetEquals(SortedSet<T> set1, SortedSet<T> set2, IComparer<T> comparer)
		{
			if (set1 == null)
			{
				return set2 == null;
			}
			if (set2 == null)
			{
				return false;
			}
			if (set1.HasEqualComparer(set2))
			{
				return set1.Count == set2.Count && set1.SetEquals(set2);
			}
			foreach (T x in set1)
			{
				bool flag = false;
				foreach (T y in set2)
				{
					if (comparer.Compare(x, y) == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000A180 File Offset: 0x00008380
		private bool HasEqualComparer(SortedSet<T> other)
		{
			return this.Comparer == other.Comparer || this.Comparer.Equals(other.Comparer);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000A1A4 File Offset: 0x000083A4
		public void UnionWith(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			SortedSet<T> sortedSet = other as SortedSet<T>;
			SortedSet<T>.TreeSubSet treeSubSet = this as SortedSet<T>.TreeSubSet;
			if (treeSubSet != null)
			{
				this.VersionCheck(false);
			}
			if (sortedSet != null && treeSubSet == null && this.Count == 0)
			{
				SortedSet<T> sortedSet2 = new SortedSet<T>(sortedSet, this.comparer);
				this.root = sortedSet2.root;
				this.count = sortedSet2.count;
				this.version++;
				return;
			}
			if (sortedSet != null && treeSubSet == null && this.HasEqualComparer(sortedSet) && sortedSet.Count > this.Count / 2)
			{
				T[] array = new T[sortedSet.Count + this.Count];
				int num = 0;
				SortedSet<T>.Enumerator enumerator = this.GetEnumerator();
				SortedSet<T>.Enumerator enumerator2 = sortedSet.GetEnumerator();
				bool flag = !enumerator.MoveNext();
				bool flag2 = !enumerator2.MoveNext();
				while (!flag && !flag2)
				{
					int num2 = this.Comparer.Compare(enumerator.Current, enumerator2.Current);
					if (num2 < 0)
					{
						array[num++] = enumerator.Current;
						flag = !enumerator.MoveNext();
					}
					else if (num2 == 0)
					{
						array[num++] = enumerator2.Current;
						flag = !enumerator.MoveNext();
						flag2 = !enumerator2.MoveNext();
					}
					else
					{
						array[num++] = enumerator2.Current;
						flag2 = !enumerator2.MoveNext();
					}
				}
				if (!flag || !flag2)
				{
					SortedSet<T>.Enumerator enumerator3 = flag ? enumerator2 : enumerator;
					do
					{
						array[num++] = enumerator3.Current;
					}
					while (enumerator3.MoveNext());
				}
				this.root = null;
				this.root = SortedSet<T>.ConstructRootFromSortedArray(array, 0, num - 1, null);
				this.count = num;
				this.version++;
				return;
			}
			this.AddAllElements(other);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A38C File Offset: 0x0000858C
		private static SortedSet<T>.Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, SortedSet<T>.Node redNode)
		{
			int num = endIndex - startIndex + 1;
			SortedSet<T>.Node node;
			switch (num)
			{
			case 0:
				return null;
			case 1:
				node = new SortedSet<T>.Node(arr[startIndex], NodeColor.Black);
				if (redNode != null)
				{
					node.Left = redNode;
				}
				break;
			case 2:
				node = new SortedSet<T>.Node(arr[startIndex], NodeColor.Black);
				node.Right = new SortedSet<T>.Node(arr[endIndex], NodeColor.Black);
				node.Right.ColorRed();
				if (redNode != null)
				{
					node.Left = redNode;
				}
				break;
			case 3:
				node = new SortedSet<T>.Node(arr[startIndex + 1], NodeColor.Black);
				node.Left = new SortedSet<T>.Node(arr[startIndex], NodeColor.Black);
				node.Right = new SortedSet<T>.Node(arr[endIndex], NodeColor.Black);
				if (redNode != null)
				{
					node.Left.Left = redNode;
				}
				break;
			default:
			{
				int num2 = (startIndex + endIndex) / 2;
				node = new SortedSet<T>.Node(arr[num2], NodeColor.Black);
				node.Left = SortedSet<T>.ConstructRootFromSortedArray(arr, startIndex, num2 - 1, redNode);
				node.Right = ((num % 2 == 0) ? SortedSet<T>.ConstructRootFromSortedArray(arr, num2 + 2, endIndex, new SortedSet<T>.Node(arr[num2 + 1], NodeColor.Red)) : SortedSet<T>.ConstructRootFromSortedArray(arr, num2 + 1, endIndex, null));
				break;
			}
			}
			return node;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000A4B8 File Offset: 0x000086B8
		public virtual void IntersectWith(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this.Count == 0)
			{
				return;
			}
			if (other == this)
			{
				return;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			SortedSet<T>.TreeSubSet treeSubSet = this as SortedSet<T>.TreeSubSet;
			if (treeSubSet != null)
			{
				this.VersionCheck(false);
			}
			if (sortedSet != null && treeSubSet == null && this.HasEqualComparer(sortedSet))
			{
				T[] array = new T[this.Count];
				int num = 0;
				SortedSet<T>.Enumerator enumerator = this.GetEnumerator();
				SortedSet<T>.Enumerator enumerator2 = sortedSet.GetEnumerator();
				bool flag = !enumerator.MoveNext();
				bool flag2 = !enumerator2.MoveNext();
				T max = this.Max;
				while (!flag && !flag2 && this.Comparer.Compare(enumerator2.Current, max) <= 0)
				{
					int num2 = this.Comparer.Compare(enumerator.Current, enumerator2.Current);
					if (num2 < 0)
					{
						flag = !enumerator.MoveNext();
					}
					else if (num2 == 0)
					{
						array[num++] = enumerator2.Current;
						flag = !enumerator.MoveNext();
						flag2 = !enumerator2.MoveNext();
					}
					else
					{
						flag2 = !enumerator2.MoveNext();
					}
				}
				this.root = null;
				this.root = SortedSet<T>.ConstructRootFromSortedArray(array, 0, num - 1, null);
				this.count = num;
				this.version++;
				return;
			}
			this.IntersectWithEnumerable(other);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000A610 File Offset: 0x00008810
		internal virtual void IntersectWithEnumerable(IEnumerable<T> other)
		{
			List<T> list = new List<T>(this.Count);
			foreach (T item in other)
			{
				if (this.Contains(item))
				{
					list.Add(item);
				}
			}
			this.Clear();
			foreach (T item2 in list)
			{
				this.Add(item2);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000A6B4 File Offset: 0x000088B4
		public void ExceptWith(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this.count == 0)
			{
				return;
			}
			if (other == this)
			{
				this.Clear();
				return;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet != null && this.HasEqualComparer(sortedSet))
			{
				if (this.comparer.Compare(sortedSet.Max, this.Min) < 0 || this.comparer.Compare(sortedSet.Min, this.Max) > 0)
				{
					return;
				}
				T min = this.Min;
				T max = this.Max;
				using (IEnumerator<T> enumerator = other.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T t = enumerator.Current;
						if (this.comparer.Compare(t, min) >= 0)
						{
							if (this.comparer.Compare(t, max) > 0)
							{
								break;
							}
							this.Remove(t);
						}
					}
					return;
				}
			}
			this.RemoveAllElements(other);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000A7A8 File Offset: 0x000089A8
		public void SymmetricExceptWith(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this.Count == 0)
			{
				this.UnionWith(other);
				return;
			}
			if (other == this)
			{
				this.Clear();
				return;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet != null && this.HasEqualComparer(sortedSet))
			{
				this.SymmetricExceptWithSameComparer(sortedSet);
				return;
			}
			int length;
			T[] array = EnumerableHelpers.ToArray<T>(other, out length);
			Array.Sort<T>(array, 0, length, this.Comparer);
			this.SymmetricExceptWithSameComparer(array, length);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000A818 File Offset: 0x00008A18
		private void SymmetricExceptWithSameComparer(SortedSet<T> other)
		{
			foreach (T item in other)
			{
				if (!this.Contains(item))
				{
					this.Add(item);
				}
				else
				{
					this.Remove(item);
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000A87C File Offset: 0x00008A7C
		private void SymmetricExceptWithSameComparer(T[] other, int count)
		{
			if (count == 0)
			{
				return;
			}
			T y = other[0];
			for (int i = 0; i < count; i++)
			{
				while (i < count && i != 0 && this.comparer.Compare(other[i], y) == 0)
				{
					i++;
				}
				if (i >= count)
				{
					break;
				}
				T t = other[i];
				if (!this.Contains(t))
				{
					this.Add(t);
				}
				else
				{
					this.Remove(t);
				}
				y = t;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public bool IsSubsetOf(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this.Count == 0)
			{
				return true;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet != null && this.HasEqualComparer(sortedSet))
			{
				return this.Count <= sortedSet.Count && this.IsSubsetOfSortedSetWithSameComparer(sortedSet);
			}
			SortedSet<T>.ElementCount elementCount = this.CheckUniqueAndUnfoundElements(other, false);
			return elementCount.UniqueCount == this.Count && elementCount.UnfoundCount >= 0;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000A960 File Offset: 0x00008B60
		private bool IsSubsetOfSortedSetWithSameComparer(SortedSet<T> asSorted)
		{
			SortedSet<T> viewBetween = asSorted.GetViewBetween(this.Min, this.Max);
			foreach (T item in this)
			{
				if (!viewBetween.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000A9CC File Offset: 0x00008BCC
		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			ICollection collection = other as ICollection;
			if (collection != null && this.Count == 0)
			{
				return collection.Count > 0;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet != null && this.HasEqualComparer(sortedSet))
			{
				return this.Count < sortedSet.Count && this.IsSubsetOfSortedSetWithSameComparer(sortedSet);
			}
			SortedSet<T>.ElementCount elementCount = this.CheckUniqueAndUnfoundElements(other, false);
			return elementCount.UniqueCount == this.Count && elementCount.UnfoundCount > 0;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000AA50 File Offset: 0x00008C50
		public bool IsSupersetOf(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			ICollection collection = other as ICollection;
			if (collection != null && collection.Count == 0)
			{
				return true;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet == null || !this.HasEqualComparer(sortedSet))
			{
				return this.ContainsAllElements(other);
			}
			if (this.Count < sortedSet.Count)
			{
				return false;
			}
			SortedSet<T> viewBetween = this.GetViewBetween(sortedSet.Min, sortedSet.Max);
			foreach (T item in sortedSet)
			{
				if (!viewBetween.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000AB08 File Offset: 0x00008D08
		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this.Count == 0)
			{
				return false;
			}
			ICollection collection = other as ICollection;
			if (collection != null && collection.Count == 0)
			{
				return true;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet == null || !this.HasEqualComparer(sortedSet))
			{
				SortedSet<T>.ElementCount elementCount = this.CheckUniqueAndUnfoundElements(other, true);
				return elementCount.UniqueCount < this.Count && elementCount.UnfoundCount == 0;
			}
			if (sortedSet.Count >= this.Count)
			{
				return false;
			}
			SortedSet<T> viewBetween = this.GetViewBetween(sortedSet.Min, sortedSet.Max);
			foreach (T item in sortedSet)
			{
				if (!viewBetween.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public bool SetEquals(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet != null && this.HasEqualComparer(sortedSet))
			{
				SortedSet<T>.Enumerator enumerator = this.GetEnumerator();
				SortedSet<T>.Enumerator enumerator2 = sortedSet.GetEnumerator();
				bool flag = !enumerator.MoveNext();
				bool flag2 = !enumerator2.MoveNext();
				while (!flag && !flag2)
				{
					if (this.Comparer.Compare(enumerator.Current, enumerator2.Current) != 0)
					{
						return false;
					}
					flag = !enumerator.MoveNext();
					flag2 = !enumerator2.MoveNext();
				}
				return flag && flag2;
			}
			SortedSet<T>.ElementCount elementCount = this.CheckUniqueAndUnfoundElements(other, true);
			return elementCount.UniqueCount == this.Count && elementCount.UnfoundCount == 0;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		public bool Overlaps(IEnumerable<T> other)
		{
			ArgumentNullException.ThrowIfNull(other, "other");
			if (this.Count == 0)
			{
				return false;
			}
			ICollection<T> collection = other as ICollection<!0>;
			if (collection != null && collection.Count == 0)
			{
				return false;
			}
			SortedSet<T> sortedSet = other as SortedSet<T>;
			if (sortedSet != null && this.HasEqualComparer(sortedSet) && (this.comparer.Compare(this.Min, sortedSet.Max) > 0 || this.comparer.Compare(this.Max, sortedSet.Min) < 0))
			{
				return false;
			}
			foreach (T item in other)
			{
				if (this.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000AD68 File Offset: 0x00008F68
		private unsafe SortedSet<T>.ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound)
		{
			SortedSet<T>.ElementCount result;
			if (this.Count == 0)
			{
				int num = 0;
				using (IEnumerator<T> enumerator = other.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						T t = enumerator.Current;
						num++;
					}
				}
				result.UniqueCount = 0;
				result.UnfoundCount = num;
				return result;
			}
			int num2 = BitHelper.ToIntArrayLength(this.Count);
			Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)400], 100);
			BitHelper bitHelper = (num2 <= 100) ? new BitHelper(span.Slice(0, num2), true) : new BitHelper(new int[num2], false);
			int num3 = 0;
			int num4 = 0;
			foreach (T item in other)
			{
				int num5 = this.InternalIndexOf(item);
				if (num5 >= 0)
				{
					if (!bitHelper.IsMarked(num5))
					{
						bitHelper.MarkBit(num5);
						num4++;
					}
				}
				else
				{
					num3++;
					if (returnIfUnfound)
					{
						break;
					}
				}
			}
			result.UniqueCount = num4;
			result.UnfoundCount = num3;
			return result;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public int RemoveWhere(Predicate<T> match)
		{
			ArgumentNullException.ThrowIfNull(match, "match");
			List<T> matches = new List<T>(this.Count);
			this.BreadthFirstTreeWalk(delegate(SortedSet<T>.Node n)
			{
				if (match(n.Item))
				{
					matches.Add(n.Item);
				}
				return true;
			});
			int num = 0;
			for (int i = matches.Count - 1; i >= 0; i--)
			{
				if (this.Remove(matches[i]))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000AF21 File Offset: 0x00009121
		[Nullable(2)]
		public T Min
		{
			[NullableContext(2)]
			get
			{
				return this.MinInternal;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000AF2C File Offset: 0x0000912C
		[Nullable(2)]
		internal virtual T MinInternal
		{
			get
			{
				if (this.root == null)
				{
					return default(T);
				}
				SortedSet<T>.Node left = this.root;
				while (left.Left != null)
				{
					left = left.Left;
				}
				return left.Item;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000AF69 File Offset: 0x00009169
		[Nullable(2)]
		public T Max
		{
			[NullableContext(2)]
			get
			{
				return this.MaxInternal;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000AF74 File Offset: 0x00009174
		[Nullable(2)]
		internal virtual T MaxInternal
		{
			get
			{
				if (this.root == null)
				{
					return default(T);
				}
				SortedSet<T>.Node right = this.root;
				while (right.Right != null)
				{
					right = right.Right;
				}
				return right.Item;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000AFB1 File Offset: 0x000091B1
		public IEnumerable<T> Reverse()
		{
			SortedSet<T>.Enumerator e = new SortedSet<T>.Enumerator(this, true);
			while (e.MoveNext())
			{
				T t = e.Current;
				yield return t;
			}
			yield break;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000AFC1 File Offset: 0x000091C1
		[NullableContext(2)]
		[return: Nullable(1)]
		public virtual SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
		{
			if (this.Comparer.Compare(lowerValue, upperValue) > 0)
			{
				throw new ArgumentException(SR.SortedSet_LowerValueGreaterThanUpperValue, "lowerValue");
			}
			return new SortedSet<T>.TreeSubSet(this, lowerValue, upperValue, true, true);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000AFED File Offset: 0x000091ED
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.GetObjectData(info, context);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000AFF8 File Offset: 0x000091F8
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("Count", this.count);
			info.AddValue("Comparer", this.comparer, typeof(IComparer<T>));
			info.AddValue("Version", this.version);
			if (this.root != null)
			{
				T[] array = new T[this.Count];
				this.CopyTo(array, 0);
				info.AddValue("Items", array, typeof(T[]));
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000B07F File Offset: 0x0000927F
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialization(sender);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000B088 File Offset: 0x00009288
		[NullableContext(2)]
		protected virtual void OnDeserialization(object sender)
		{
			if (this.comparer != null)
			{
				return;
			}
			if (this.siInfo == null)
			{
				throw new SerializationException(SR.Serialization_InvalidOnDeser);
			}
			this.comparer = (IComparer<T>)this.siInfo.GetValue("Comparer", typeof(IComparer<T>));
			int @int = this.siInfo.GetInt32("Count");
			if (@int != 0)
			{
				T[] array = (T[])this.siInfo.GetValue("Items", typeof(T[]));
				if (array == null)
				{
					throw new SerializationException(SR.Serialization_MissingValues);
				}
				for (int i = 0; i < array.Length; i++)
				{
					this.Add(array[i]);
				}
			}
			this.version = this.siInfo.GetInt32("Version");
			if (this.count != @int)
			{
				throw new SerializationException(SR.Serialization_MismatchedCount);
			}
			this.siInfo = null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000B168 File Offset: 0x00009368
		public bool TryGetValue(T equalValue, [MaybeNullWhen(false)] out T actualValue)
		{
			SortedSet<T>.Node node = this.FindNode(equalValue);
			if (node != null)
			{
				actualValue = node.Item;
				return true;
			}
			actualValue = default(T);
			return false;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000B196 File Offset: 0x00009396
		private static int Log2(int value)
		{
			return BitOperations.Log2((uint)value);
		}

		// Token: 0x0400007B RID: 123
		private SortedSet<T>.Node root;

		// Token: 0x0400007C RID: 124
		private IComparer<T> comparer;

		// Token: 0x0400007D RID: 125
		private int count;

		// Token: 0x0400007E RID: 126
		private int version;

		// Token: 0x0400007F RID: 127
		private SerializationInfo siInfo;

		// Token: 0x02000039 RID: 57
		internal sealed class Node
		{
			// Token: 0x060002CB RID: 715 RVA: 0x0000B19E File Offset: 0x0000939E
			public Node(T item, NodeColor color)
			{
				this.Item = item;
				this.Color = color;
			}

			// Token: 0x060002CC RID: 716 RVA: 0x0000B1B4 File Offset: 0x000093B4
			public static bool IsNonNullRed(SortedSet<T>.Node node)
			{
				return node != null && node.IsRed;
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000B1C1 File Offset: 0x000093C1
			public static bool IsNullOrBlack(SortedSet<T>.Node node)
			{
				return node == null || node.IsBlack;
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000B1CE File Offset: 0x000093CE
			// (set) Token: 0x060002CF RID: 719 RVA: 0x0000B1D6 File Offset: 0x000093D6
			public T Item { get; set; }

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000B1DF File Offset: 0x000093DF
			// (set) Token: 0x060002D1 RID: 721 RVA: 0x0000B1E7 File Offset: 0x000093E7
			public SortedSet<T>.Node Left { get; set; }

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000B1F0 File Offset: 0x000093F0
			// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000B1F8 File Offset: 0x000093F8
			public SortedSet<T>.Node Right { get; set; }

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000B201 File Offset: 0x00009401
			// (set) Token: 0x060002D5 RID: 725 RVA: 0x0000B209 File Offset: 0x00009409
			public NodeColor Color { get; set; }

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000B212 File Offset: 0x00009412
			public bool IsBlack
			{
				get
				{
					return this.Color == NodeColor.Black;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000B21D File Offset: 0x0000941D
			public bool IsRed
			{
				get
				{
					return this.Color == NodeColor.Red;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000B228 File Offset: 0x00009428
			public bool Is2Node
			{
				get
				{
					return this.IsBlack && SortedSet<T>.Node.IsNullOrBlack(this.Left) && SortedSet<T>.Node.IsNullOrBlack(this.Right);
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000B24C File Offset: 0x0000944C
			public bool Is4Node
			{
				get
				{
					return SortedSet<T>.Node.IsNonNullRed(this.Left) && SortedSet<T>.Node.IsNonNullRed(this.Right);
				}
			}

			// Token: 0x060002DA RID: 730 RVA: 0x0000B268 File Offset: 0x00009468
			public void ColorBlack()
			{
				this.Color = NodeColor.Black;
			}

			// Token: 0x060002DB RID: 731 RVA: 0x0000B271 File Offset: 0x00009471
			public void ColorRed()
			{
				this.Color = NodeColor.Red;
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0000B27C File Offset: 0x0000947C
			public SortedSet<T>.Node DeepClone(int count)
			{
				SortedSet<T>.Node node = this.ShallowClone();
				Stack<ValueTuple<SortedSet<T>.Node, SortedSet<T>.Node>> stack = new Stack<ValueTuple<SortedSet<T>.Node, SortedSet<T>.Node>>(2 * SortedSet<T>.Log2(count) + 2);
				stack.Push(new ValueTuple<SortedSet<T>.Node, SortedSet<T>.Node>(this, node));
				ValueTuple<SortedSet<T>.Node, SortedSet<T>.Node> valueTuple;
				while (stack.TryPop(out valueTuple))
				{
					SortedSet<T>.Node left = valueTuple.Item1.Left;
					if (left != null)
					{
						SortedSet<T>.Node node2 = left.ShallowClone();
						valueTuple.Item2.Left = node2;
						stack.Push(new ValueTuple<SortedSet<T>.Node, SortedSet<T>.Node>(left, node2));
					}
					SortedSet<T>.Node right = valueTuple.Item1.Right;
					if (right != null)
					{
						SortedSet<T>.Node node2 = right.ShallowClone();
						valueTuple.Item2.Right = node2;
						stack.Push(new ValueTuple<SortedSet<T>.Node, SortedSet<T>.Node>(right, node2));
					}
				}
				return node;
			}

			// Token: 0x060002DD RID: 733 RVA: 0x0000B320 File Offset: 0x00009520
			public TreeRotation GetRotation(SortedSet<T>.Node current, SortedSet<T>.Node sibling)
			{
				bool flag = this.Left == current;
				if (!SortedSet<T>.Node.IsNonNullRed(sibling.Left))
				{
					if (!flag)
					{
						return TreeRotation.LeftRight;
					}
					return TreeRotation.Left;
				}
				else
				{
					if (!flag)
					{
						return TreeRotation.Right;
					}
					return TreeRotation.RightLeft;
				}
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0000B351 File Offset: 0x00009551
			public SortedSet<T>.Node GetSibling(SortedSet<T>.Node node)
			{
				if (node != this.Left)
				{
					return this.Left;
				}
				return this.Right;
			}

			// Token: 0x060002DF RID: 735 RVA: 0x0000B369 File Offset: 0x00009569
			public SortedSet<T>.Node ShallowClone()
			{
				return new SortedSet<T>.Node(this.Item, this.Color);
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x0000B37C File Offset: 0x0000957C
			public void Split4Node()
			{
				this.ColorRed();
				this.Left.ColorBlack();
				this.Right.ColorBlack();
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0000B39C File Offset: 0x0000959C
			public SortedSet<T>.Node Rotate(TreeRotation rotation)
			{
				switch (rotation)
				{
				case TreeRotation.Left:
					this.Right.Right.ColorBlack();
					return this.RotateLeft();
				case TreeRotation.LeftRight:
					return this.RotateLeftRight();
				case TreeRotation.Right:
					this.Left.Left.ColorBlack();
					return this.RotateRight();
				case TreeRotation.RightLeft:
					return this.RotateRightLeft();
				default:
					return null;
				}
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000B400 File Offset: 0x00009600
			public SortedSet<T>.Node RotateLeft()
			{
				SortedSet<T>.Node right = this.Right;
				this.Right = right.Left;
				right.Left = this;
				return right;
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000B428 File Offset: 0x00009628
			public SortedSet<T>.Node RotateLeftRight()
			{
				SortedSet<T>.Node left = this.Left;
				SortedSet<T>.Node right = left.Right;
				this.Left = right.Right;
				right.Right = this;
				left.Right = right.Left;
				right.Left = left;
				return right;
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0000B46C File Offset: 0x0000966C
			public SortedSet<T>.Node RotateRight()
			{
				SortedSet<T>.Node left = this.Left;
				this.Left = left.Right;
				left.Right = this;
				return left;
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x0000B494 File Offset: 0x00009694
			public SortedSet<T>.Node RotateRightLeft()
			{
				SortedSet<T>.Node right = this.Right;
				SortedSet<T>.Node left = right.Left;
				this.Right = left.Left;
				left.Left = this;
				right.Left = left.Right;
				left.Right = right;
				return left;
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0000B4D6 File Offset: 0x000096D6
			public void Merge2Nodes()
			{
				this.ColorBlack();
				this.Left.ColorRed();
				this.Right.ColorRed();
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0000B4F4 File Offset: 0x000096F4
			public void ReplaceChild(SortedSet<T>.Node child, SortedSet<T>.Node newChild)
			{
				if (this.Left == child)
				{
					this.Left = newChild;
					return;
				}
				this.Right = newChild;
			}
		}

		// Token: 0x0200003A RID: 58
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable, ISerializable, IDeserializationCallback
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x0000B50E File Offset: 0x0000970E
			internal Enumerator(SortedSet<T> set)
			{
				this = new SortedSet<T>.Enumerator(set, false);
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0000B518 File Offset: 0x00009718
			internal Enumerator(SortedSet<T> set, bool reverse)
			{
				this._tree = set;
				set.VersionCheck(false);
				this._version = set.version;
				this._stack = new Stack<SortedSet<T>.Node>(2 * SortedSet<T>.Log2(set.TotalCount() + 1));
				this._current = null;
				this._reverse = reverse;
				this.Initialize();
			}

			// Token: 0x060002EA RID: 746 RVA: 0x000049AD File Offset: 0x00002BAD
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060002EB RID: 747 RVA: 0x000049AD File Offset: 0x00002BAD
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0000B570 File Offset: 0x00009770
			private void Initialize()
			{
				this._current = null;
				SortedSet<T>.Node node = this._tree.root;
				while (node != null)
				{
					SortedSet<T>.Node node2 = this._reverse ? node.Right : node.Left;
					SortedSet<T>.Node node3 = this._reverse ? node.Left : node.Right;
					if (this._tree.IsWithinRange(node.Item))
					{
						this._stack.Push(node);
						node = node2;
					}
					else if (node2 == null || !this._tree.IsWithinRange(node2.Item))
					{
						node = node3;
					}
					else
					{
						node = node2;
					}
				}
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0000B604 File Offset: 0x00009804
			public bool MoveNext()
			{
				this._tree.VersionCheck(false);
				if (this._version != this._tree.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._stack.Count == 0)
				{
					this._current = null;
					return false;
				}
				this._current = this._stack.Pop();
				SortedSet<T>.Node node = this._reverse ? this._current.Left : this._current.Right;
				while (node != null)
				{
					SortedSet<T>.Node node2 = this._reverse ? node.Right : node.Left;
					SortedSet<T>.Node node3 = this._reverse ? node.Left : node.Right;
					if (this._tree.IsWithinRange(node.Item))
					{
						this._stack.Push(node);
						node = node2;
					}
					else if (node3 == null || !this._tree.IsWithinRange(node3.Item))
					{
						node = node2;
					}
					else
					{
						node = node3;
					}
				}
				return true;
			}

			// Token: 0x060002EE RID: 750 RVA: 0x000049AB File Offset: 0x00002BAB
			public void Dispose()
			{
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002EF RID: 751 RVA: 0x0000B6F8 File Offset: 0x000098F8
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					if (this._current != null)
					{
						return this._current.Item;
					}
					return default(T);
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000B722 File Offset: 0x00009922
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					if (this._current == null)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this._current.Item;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000B747 File Offset: 0x00009947
			internal bool NotStartedOrEnded
			{
				get
				{
					return this._current == null;
				}
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x0000B752 File Offset: 0x00009952
			internal void Reset()
			{
				if (this._version != this._tree.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._stack.Clear();
				this.Initialize();
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0000B783 File Offset: 0x00009983
			void IEnumerator.Reset()
			{
				this.Reset();
			}

			// Token: 0x04000084 RID: 132
			private readonly SortedSet<T> _tree;

			// Token: 0x04000085 RID: 133
			private readonly int _version;

			// Token: 0x04000086 RID: 134
			private readonly Stack<SortedSet<T>.Node> _stack;

			// Token: 0x04000087 RID: 135
			private SortedSet<T>.Node _current;

			// Token: 0x04000088 RID: 136
			private readonly bool _reverse;
		}

		// Token: 0x0200003B RID: 59
		internal struct ElementCount
		{
			// Token: 0x04000089 RID: 137
			internal int UniqueCount;

			// Token: 0x0400008A RID: 138
			internal int UnfoundCount;
		}

		// Token: 0x0200003C RID: 60
		internal sealed class TreeSubSet : SortedSet<T>, ISerializable, IDeserializationCallback
		{
			// Token: 0x060002F4 RID: 756 RVA: 0x0000B78C File Offset: 0x0000998C
			public TreeSubSet(SortedSet<T> Underlying, T Min, T Max, bool lowerBoundActive, bool upperBoundActive) : base(Underlying.Comparer)
			{
				this._underlying = Underlying;
				this._min = Min;
				this._max = Max;
				this._lBoundActive = lowerBoundActive;
				this._uBoundActive = upperBoundActive;
				this.root = this._underlying.FindRange(this._min, this._max, this._lBoundActive, this._uBoundActive);
				this.count = 0;
				this.version = -1;
				this._countVersion = -1;
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x0000B808 File Offset: 0x00009A08
			internal override bool AddIfNotPresent(T item)
			{
				if (!this.IsWithinRange(item))
				{
					throw new ArgumentOutOfRangeException("item");
				}
				bool result = this._underlying.AddIfNotPresent(item);
				this.VersionCheck(false);
				return result;
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x0000B831 File Offset: 0x00009A31
			public override bool Contains(T item)
			{
				this.VersionCheck(false);
				return base.Contains(item);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0000B841 File Offset: 0x00009A41
			internal override bool DoRemove(T item)
			{
				if (!this.IsWithinRange(item))
				{
					return false;
				}
				bool result = this._underlying.Remove(item);
				this.VersionCheck(false);
				return result;
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0000B864 File Offset: 0x00009A64
			public override void Clear()
			{
				if (base.Count == 0)
				{
					return;
				}
				List<T> toRemove = new List<T>();
				this.BreadthFirstTreeWalk(delegate(SortedSet<T>.Node n)
				{
					toRemove.Add(n.Item);
					return true;
				});
				while (toRemove.Count != 0)
				{
					SortedSet<T> underlying = this._underlying;
					List<T> toRemove2 = toRemove;
					underlying.Remove(toRemove2[toRemove2.Count - 1]);
					toRemove.RemoveAt(toRemove.Count - 1);
				}
				this.root = null;
				this.count = 0;
				this.version = this._underlying.version;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0000B904 File Offset: 0x00009B04
			internal override bool IsWithinRange(T item)
			{
				return (this._lBoundActive ? base.Comparer.Compare(this._min, item) : -1) <= 0 && (this._uBoundActive ? base.Comparer.Compare(this._max, item) : 1) >= 0;
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002FA RID: 762 RVA: 0x0000B958 File Offset: 0x00009B58
			internal override T MinInternal
			{
				get
				{
					this.VersionCheck(false);
					SortedSet<T>.Node node = this.root;
					T result = default(T);
					while (node != null)
					{
						int num = this._lBoundActive ? base.Comparer.Compare(this._min, node.Item) : -1;
						if (num > 0)
						{
							node = node.Right;
						}
						else
						{
							result = node.Item;
							if (num == 0)
							{
								break;
							}
							node = node.Left;
						}
					}
					return result;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002FB RID: 763 RVA: 0x0000B9C4 File Offset: 0x00009BC4
			internal override T MaxInternal
			{
				get
				{
					this.VersionCheck(false);
					SortedSet<T>.Node node = this.root;
					T result = default(T);
					while (node != null)
					{
						int num = this._uBoundActive ? base.Comparer.Compare(this._max, node.Item) : 1;
						if (num < 0)
						{
							node = node.Left;
						}
						else
						{
							result = node.Item;
							if (num == 0)
							{
								break;
							}
							node = node.Right;
						}
					}
					return result;
				}
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0000BA30 File Offset: 0x00009C30
			internal override bool InOrderTreeWalk(TreeWalkPredicate<T> action)
			{
				this.VersionCheck(false);
				if (this.root == null)
				{
					return true;
				}
				Stack<SortedSet<T>.Node> stack = new Stack<SortedSet<T>.Node>(2 * SortedSet<T>.Log2(this.count + 1));
				SortedSet<T>.Node node = this.root;
				while (node != null)
				{
					if (this.IsWithinRange(node.Item))
					{
						stack.Push(node);
						node = node.Left;
					}
					else if (this._lBoundActive && base.Comparer.Compare(this._min, node.Item) > 0)
					{
						node = node.Right;
					}
					else
					{
						node = node.Left;
					}
				}
				while (stack.Count != 0)
				{
					node = stack.Pop();
					if (!action(node))
					{
						return false;
					}
					SortedSet<T>.Node node2 = node.Right;
					while (node2 != null)
					{
						if (this.IsWithinRange(node2.Item))
						{
							stack.Push(node2);
							node2 = node2.Left;
						}
						else if (this._lBoundActive && base.Comparer.Compare(this._min, node2.Item) > 0)
						{
							node2 = node2.Right;
						}
						else
						{
							node2 = node2.Left;
						}
					}
				}
				return true;
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0000BB38 File Offset: 0x00009D38
			internal override bool BreadthFirstTreeWalk(TreeWalkPredicate<T> action)
			{
				this.VersionCheck(false);
				if (this.root == null)
				{
					return true;
				}
				Queue<SortedSet<T>.Node> queue = new Queue<SortedSet<T>.Node>();
				queue.Enqueue(this.root);
				while (queue.Count != 0)
				{
					SortedSet<T>.Node node = queue.Dequeue();
					if (this.IsWithinRange(node.Item) && !action(node))
					{
						return false;
					}
					if (node.Left != null && (!this._lBoundActive || base.Comparer.Compare(this._min, node.Item) < 0))
					{
						queue.Enqueue(node.Left);
					}
					if (node.Right != null && (!this._uBoundActive || base.Comparer.Compare(this._max, node.Item) > 0))
					{
						queue.Enqueue(node.Right);
					}
				}
				return true;
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0000BC05 File Offset: 0x00009E05
			internal override SortedSet<T>.Node FindNode(T item)
			{
				if (!this.IsWithinRange(item))
				{
					return null;
				}
				this.VersionCheck(false);
				return base.FindNode(item);
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0000BC20 File Offset: 0x00009E20
			internal override int InternalIndexOf(T item)
			{
				int num = -1;
				foreach (T y in this)
				{
					num++;
					if (base.Comparer.Compare(item, y) == 0)
					{
						return num;
					}
				}
				return -1;
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0000BC84 File Offset: 0x00009E84
			internal override void VersionCheck(bool updateCount = false)
			{
				this.VersionCheckImpl(updateCount);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0000BC90 File Offset: 0x00009E90
			private void VersionCheckImpl(bool updateCount)
			{
				if (this.version != this._underlying.version)
				{
					this.root = this._underlying.FindRange(this._min, this._max, this._lBoundActive, this._uBoundActive);
					this.version = this._underlying.version;
				}
				if (updateCount && this._countVersion != this._underlying.version)
				{
					this.count = 0;
					this.InOrderTreeWalk(delegate(SortedSet<T>.Node n)
					{
						this.count++;
						return true;
					});
					this._countVersion = this._underlying.version;
				}
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0000BD2B File Offset: 0x00009F2B
			internal override int TotalCount()
			{
				return this._underlying.Count;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x0000BD38 File Offset: 0x00009F38
			public override SortedSet<T> GetViewBetween(T lowerValue, T upperValue)
			{
				if (this._lBoundActive && base.Comparer.Compare(this._min, lowerValue) > 0)
				{
					throw new ArgumentOutOfRangeException("lowerValue");
				}
				if (this._uBoundActive && base.Comparer.Compare(this._max, upperValue) < 0)
				{
					throw new ArgumentOutOfRangeException("upperValue");
				}
				return (SortedSet<T>.TreeSubSet)this._underlying.GetViewBetween(lowerValue, upperValue);
			}

			// Token: 0x06000304 RID: 772 RVA: 0x0000AFED File Offset: 0x000091ED
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				this.GetObjectData(info, context);
			}

			// Token: 0x06000305 RID: 773 RVA: 0x000049AD File Offset: 0x00002BAD
			protected override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06000306 RID: 774 RVA: 0x000049AD File Offset: 0x00002BAD
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06000307 RID: 775 RVA: 0x000049AD File Offset: 0x00002BAD
			protected override void OnDeserialization(object sender)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0400008B RID: 139
			private readonly SortedSet<T> _underlying;

			// Token: 0x0400008C RID: 140
			private readonly T _min;

			// Token: 0x0400008D RID: 141
			private readonly T _max;

			// Token: 0x0400008E RID: 142
			private int _countVersion;

			// Token: 0x0400008F RID: 143
			private readonly bool _lBoundActive;

			// Token: 0x04000090 RID: 144
			private readonly bool _uBoundActive;
		}
	}
}
