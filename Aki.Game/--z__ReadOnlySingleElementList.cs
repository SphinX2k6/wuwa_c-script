using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020064F1 RID: 25841
[CompilerGenerated]
internal sealed class <>z__ReadOnlySingleElementList<T> : IEnumerable, ICollection, IList, IEnumerable<!0>, IReadOnlyCollection<!0>, IReadOnlyList<!0>, ICollection<!0>, IList<!0>
{
	// Token: 0x0603EB40 RID: 256832 RVA: 0x01243D66 File Offset: 0x01241F66
	public <>z__ReadOnlySingleElementList(T item)
	{
		this._item = item;
	}

	// Token: 0x0603EB41 RID: 256833 RVA: 0x01243D75 File Offset: 0x01241F75
	[return: Nullable(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new <>z__ReadOnlySingleElementList<T>.Enumerator(this._item);
	}

	// Token: 0x1700773A RID: 30522
	// (get) Token: 0x0603EB42 RID: 256834 RVA: 0x01243D82 File Offset: 0x01241F82
	int ICollection.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700773B RID: 30523
	// (get) Token: 0x0603EB43 RID: 256835 RVA: 0x01243D85 File Offset: 0x01241F85
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700773C RID: 30524
	// (get) Token: 0x0603EB44 RID: 256836 RVA: 0x01243D88 File Offset: 0x01241F88
	object ICollection.SyncRoot
	{
		[return: Nullable(1)]
		get
		{
			return this;
		}
	}

	// Token: 0x0603EB45 RID: 256837 RVA: 0x01243D8B File Offset: 0x01241F8B
	void ICollection.CopyTo([Nullable(1)] Array array, int index)
	{
		array.SetValue(this._item, index);
	}

	// Token: 0x1700773D RID: 30525
	object IList.this[int index]
	{
		[return: Nullable(2)]
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this._item;
		}
		[param: Nullable(2)]
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x1700773E RID: 30526
	// (get) Token: 0x0603EB48 RID: 256840 RVA: 0x01243DBC File Offset: 0x01241FBC
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700773F RID: 30527
	// (get) Token: 0x0603EB49 RID: 256841 RVA: 0x01243DBF File Offset: 0x01241FBF
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0603EB4A RID: 256842 RVA: 0x01243DC2 File Offset: 0x01241FC2
	int IList.Add([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB4B RID: 256843 RVA: 0x01243DC9 File Offset: 0x01241FC9
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB4C RID: 256844 RVA: 0x01243DD0 File Offset: 0x01241FD0
	bool IList.Contains([Nullable(2)] object value)
	{
		return EqualityComparer<T>.Default.Equals(this._item, (T)((object)value));
	}

	// Token: 0x0603EB4D RID: 256845 RVA: 0x01243DE8 File Offset: 0x01241FE8
	int IList.IndexOf([Nullable(2)] object value)
	{
		if (!EqualityComparer<T>.Default.Equals(this._item, (T)((object)value)))
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x0603EB4E RID: 256846 RVA: 0x01243E05 File Offset: 0x01242005
	void IList.Insert(int index, [Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB4F RID: 256847 RVA: 0x01243E0C File Offset: 0x0124200C
	void IList.Remove([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB50 RID: 256848 RVA: 0x01243E13 File Offset: 0x01242013
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB51 RID: 256849 RVA: 0x01243E1A File Offset: 0x0124201A
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	IEnumerator<T> IEnumerable<!0>.GetEnumerator()
	{
		return new <>z__ReadOnlySingleElementList<T>.Enumerator(this._item);
	}

	// Token: 0x17007740 RID: 30528
	// (get) Token: 0x0603EB52 RID: 256850 RVA: 0x01243E27 File Offset: 0x01242027
	int IReadOnlyCollection<!0>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17007741 RID: 30529
	T IReadOnlyList<!0>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this._item;
		}
	}

	// Token: 0x17007742 RID: 30530
	// (get) Token: 0x0603EB54 RID: 256852 RVA: 0x01243E3B File Offset: 0x0124203B
	int ICollection<!0>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17007743 RID: 30531
	// (get) Token: 0x0603EB55 RID: 256853 RVA: 0x01243E3E File Offset: 0x0124203E
	bool ICollection<!0>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0603EB56 RID: 256854 RVA: 0x01243E41 File Offset: 0x01242041
	void ICollection<!0>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB57 RID: 256855 RVA: 0x01243E48 File Offset: 0x01242048
	void ICollection<!0>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB58 RID: 256856 RVA: 0x01243E4F File Offset: 0x0124204F
	bool ICollection<!0>.Contains(T item)
	{
		return EqualityComparer<T>.Default.Equals(this._item, item);
	}

	// Token: 0x0603EB59 RID: 256857 RVA: 0x01243E62 File Offset: 0x01242062
	void ICollection<!0>.CopyTo([Nullable(new byte[]
	{
		1,
		0
	})] T[] array, int arrayIndex)
	{
		array[arrayIndex] = this._item;
	}

	// Token: 0x0603EB5A RID: 256858 RVA: 0x01243E71 File Offset: 0x01242071
	bool ICollection<!0>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17007744 RID: 30532
	T IList<!0>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return this._item;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x0603EB5D RID: 256861 RVA: 0x01243E90 File Offset: 0x01242090
	int IList<!0>.IndexOf(T item)
	{
		if (!EqualityComparer<T>.Default.Equals(this._item, item))
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x0603EB5E RID: 256862 RVA: 0x01243EA8 File Offset: 0x012420A8
	void IList<!0>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB5F RID: 256863 RVA: 0x01243EAF File Offset: 0x012420AF
	void IList<!0>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040218C3 RID: 137411
	[CompilerGenerated]
	private readonly T _item;

	// Token: 0x0200BBEF RID: 48111
	private sealed class Enumerator : IDisposable, IEnumerator, IEnumerator<!0>
	{
		// Token: 0x06048B76 RID: 297846 RVA: 0x01625DE1 File Offset: 0x01623FE1
		public Enumerator(T item)
		{
			this.System.Collections.Generic.IEnumerator<T>.Current = item;
		}

		// Token: 0x17007A88 RID: 31368
		// (get) Token: 0x06048B77 RID: 297847 RVA: 0x01625DF0 File Offset: 0x01623FF0
		object IEnumerator.Current
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x17007A89 RID: 31369
		// (get) Token: 0x06048B78 RID: 297848 RVA: 0x01625DFD File Offset: 0x01623FFD
		T IEnumerator<!0>.Current
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x06048B79 RID: 297849 RVA: 0x01625E08 File Offset: 0x01624008
		bool IEnumerator.MoveNext()
		{
			return !this._moveNextCalled && (this._moveNextCalled = true);
		}

		// Token: 0x06048B7A RID: 297850 RVA: 0x01625E29 File Offset: 0x01624029
		void IEnumerator.Reset()
		{
			this._moveNextCalled = false;
		}

		// Token: 0x06048B7B RID: 297851 RVA: 0x01625E32 File Offset: 0x01624032
		void IDisposable.Dispose()
		{
		}

		// Token: 0x04039C7C RID: 236668
		[CompilerGenerated]
		private readonly T _item;

		// Token: 0x04039C7D RID: 236669
		[CompilerGenerated]
		private bool _moveNextCalled;
	}
}
