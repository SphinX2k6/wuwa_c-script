using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000171 RID: 369
	[NullableContext(1)]
	[Nullable(0)]
	public class OrderedSet<[Nullable(2)] T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0003B31F File Offset: 0x0003951F
		public int Count
		{
			get
			{
				return this._set.Count;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0003B32C File Offset: 0x0003952C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0003B330 File Offset: 0x00039530
		public bool Add(T item)
		{
			if (!this._set.Add(item))
			{
				return false;
			}
			if (this._staleCount > 0 && this._list.IndexOf(item) >= 0)
			{
				this._staleCount--;
				return true;
			}
			this._list.Add(item);
			return true;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0003B382 File Offset: 0x00039582
		void ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0003B38C File Offset: 0x0003958C
		public bool Remove(T item)
		{
			if (!this._set.Remove(item))
			{
				return false;
			}
			if (this._enumerateDepth == 0)
			{
				this._list.Remove(item);
			}
			else
			{
				this._staleCount++;
			}
			return true;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x0003B3C4 File Offset: 0x000395C4
		public bool Contains(T item)
		{
			return this._set.Contains(item);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0003B3D2 File Offset: 0x000395D2
		public void Clear()
		{
			this._list.Clear();
			this._set.Clear();
			this._staleCount = 0;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0003B3F4 File Offset: 0x000395F4
		public void CopyTo(T[] array, int arrayIndex)
		{
			if (this._staleCount == 0)
			{
				this._list.CopyTo(array, arrayIndex);
				return;
			}
			foreach (T t in this._list)
			{
				if (this._set.Contains(t))
				{
					array[arrayIndex++] = t;
				}
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0003B474 File Offset: 0x00039674
		private void CompactIfNeeded()
		{
			if (this._staleCount > 0)
			{
				this._list.RemoveAll((T item) => !this._set.Contains(item));
				this._staleCount = 0;
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0003B49E File Offset: 0x0003969E
		[NullableContext(0)]
		public OrderedSet<T>.Enumerator GetEnumerator()
		{
			return new OrderedSet<T>.Enumerator(this);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0003B4A6 File Offset: 0x000396A6
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return new OrderedSet<T>.Enumerator(this);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0003B4B3 File Offset: 0x000396B3
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new OrderedSet<T>.Enumerator(this);
		}

		// Token: 0x04000743 RID: 1859
		private readonly List<T> _list = new List<T>();

		// Token: 0x04000744 RID: 1860
		private readonly HashSet<T> _set = new HashSet<T>();

		// Token: 0x04000745 RID: 1861
		private int _enumerateDepth;

		// Token: 0x04000746 RID: 1862
		private int _staleCount;

		// Token: 0x020001E7 RID: 487
		[Nullable(0)]
		public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
		{
			// Token: 0x06000DBA RID: 3514 RVA: 0x0003FADF File Offset: 0x0003DCDF
			internal Enumerator(OrderedSet<T> owner)
			{
				this._owner = owner;
				this._index = 0;
				this._current = default(T);
				this._disposed = false;
				owner._enumerateDepth++;
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0003FB10 File Offset: 0x0003DD10
			public readonly T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0003FB18 File Offset: 0x0003DD18
			[Nullable(2)]
			object IEnumerator.Current
			{
				[NullableContext(2)]
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000DBD RID: 3517 RVA: 0x0003FB28 File Offset: 0x0003DD28
			public bool MoveNext()
			{
				List<T> list = this._owner._list;
				if (this._owner._staleCount == 0)
				{
					if (this._index < list.Count)
					{
						List<T> list2 = list;
						int index = this._index;
						this._index = index + 1;
						this._current = list2[index];
						return true;
					}
				}
				else
				{
					HashSet<T> set = this._owner._set;
					while (this._index < list.Count)
					{
						List<T> list3 = list;
						int index = this._index;
						this._index = index + 1;
						T t = list3[index];
						if (set.Contains(t))
						{
							this._current = t;
							return true;
						}
					}
				}
				this._current = default(T);
				return false;
			}

			// Token: 0x06000DBE RID: 3518 RVA: 0x0003FBCE File Offset: 0x0003DDCE
			public void Reset()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000DBF RID: 3519 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
			public void Dispose()
			{
				if (this._disposed || this._owner == null)
				{
					return;
				}
				this._disposed = true;
				this._owner._enumerateDepth--;
				if (this._owner._enumerateDepth == 0)
				{
					this._owner.CompactIfNeeded();
				}
			}

			// Token: 0x040008EF RID: 2287
			private readonly OrderedSet<T> _owner;

			// Token: 0x040008F0 RID: 2288
			private int _index;

			// Token: 0x040008F1 RID: 2289
			[Nullable(2)]
			private T _current;

			// Token: 0x040008F2 RID: 2290
			private bool _disposed;
		}
	}
}
