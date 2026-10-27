using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200736E RID: 29550
[CompilerGenerated]
internal sealed class <>z__ReadOnlySingleElementList<T> : IEnumerable, ICollection, IList, IEnumerable<!0>, IReadOnlyCollection<!0>, IReadOnlyList<!0>, ICollection<!0>, IList<!0>
{
	// Token: 0x060486F2 RID: 296690 RVA: 0x012A126A File Offset: 0x0129F46A
	public <>z__ReadOnlySingleElementList(T item)
	{
		this._item = item;
	}

	// Token: 0x060486F3 RID: 296691 RVA: 0x012A1279 File Offset: 0x0129F479
	[return: Nullable(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new <>z__ReadOnlySingleElementList<T>.Enumerator(this._item);
	}

	// Token: 0x17009F9C RID: 40860
	// (get) Token: 0x060486F4 RID: 296692 RVA: 0x012A1286 File Offset: 0x0129F486
	int ICollection.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17009F9D RID: 40861
	// (get) Token: 0x060486F5 RID: 296693 RVA: 0x012A1289 File Offset: 0x0129F489
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17009F9E RID: 40862
	// (get) Token: 0x060486F6 RID: 296694 RVA: 0x012A128C File Offset: 0x0129F48C
	object ICollection.SyncRoot
	{
		[return: Nullable(1)]
		get
		{
			return this;
		}
	}

	// Token: 0x060486F7 RID: 296695 RVA: 0x012A128F File Offset: 0x0129F48F
	void ICollection.CopyTo([Nullable(1)] Array array, int index)
	{
		array.SetValue(this._item, index);
	}

	// Token: 0x17009F9F RID: 40863
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

	// Token: 0x17009FA0 RID: 40864
	// (get) Token: 0x060486FA RID: 296698 RVA: 0x012A12C0 File Offset: 0x0129F4C0
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17009FA1 RID: 40865
	// (get) Token: 0x060486FB RID: 296699 RVA: 0x012A12C3 File Offset: 0x0129F4C3
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060486FC RID: 296700 RVA: 0x012A12C6 File Offset: 0x0129F4C6
	int IList.Add([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486FD RID: 296701 RVA: 0x012A12CD File Offset: 0x0129F4CD
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486FE RID: 296702 RVA: 0x012A12D4 File Offset: 0x0129F4D4
	bool IList.Contains([Nullable(2)] object value)
	{
		return EqualityComparer<T>.Default.Equals(this._item, (T)((object)value));
	}

	// Token: 0x060486FF RID: 296703 RVA: 0x012A12EC File Offset: 0x0129F4EC
	int IList.IndexOf([Nullable(2)] object value)
	{
		if (!EqualityComparer<T>.Default.Equals(this._item, (T)((object)value)))
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06048700 RID: 296704 RVA: 0x012A1309 File Offset: 0x0129F509
	void IList.Insert(int index, [Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06048701 RID: 296705 RVA: 0x012A1310 File Offset: 0x0129F510
	void IList.Remove([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06048702 RID: 296706 RVA: 0x012A1317 File Offset: 0x0129F517
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06048703 RID: 296707 RVA: 0x012A131E File Offset: 0x0129F51E
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	IEnumerator<T> IEnumerable<!0>.GetEnumerator()
	{
		return new <>z__ReadOnlySingleElementList<T>.Enumerator(this._item);
	}

	// Token: 0x17009FA2 RID: 40866
	// (get) Token: 0x06048704 RID: 296708 RVA: 0x012A132B File Offset: 0x0129F52B
	int IReadOnlyCollection<!0>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17009FA3 RID: 40867
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

	// Token: 0x17009FA4 RID: 40868
	// (get) Token: 0x06048706 RID: 296710 RVA: 0x012A133F File Offset: 0x0129F53F
	int ICollection<!0>.Count
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x17009FA5 RID: 40869
	// (get) Token: 0x06048707 RID: 296711 RVA: 0x012A1342 File Offset: 0x0129F542
	bool ICollection<!0>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06048708 RID: 296712 RVA: 0x012A1345 File Offset: 0x0129F545
	void ICollection<!0>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06048709 RID: 296713 RVA: 0x012A134C File Offset: 0x0129F54C
	void ICollection<!0>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0604870A RID: 296714 RVA: 0x012A1353 File Offset: 0x0129F553
	bool ICollection<!0>.Contains(T item)
	{
		return EqualityComparer<T>.Default.Equals(this._item, item);
	}

	// Token: 0x0604870B RID: 296715 RVA: 0x012A1366 File Offset: 0x0129F566
	void ICollection<!0>.CopyTo([Nullable(new byte[]
	{
		1,
		0
	})] T[] array, int arrayIndex)
	{
		array[arrayIndex] = this._item;
	}

	// Token: 0x0604870C RID: 296716 RVA: 0x012A1375 File Offset: 0x0129F575
	bool ICollection<!0>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17009FA6 RID: 40870
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

	// Token: 0x0604870F RID: 296719 RVA: 0x012A1394 File Offset: 0x0129F594
	int IList<!0>.IndexOf(T item)
	{
		if (!EqualityComparer<T>.Default.Equals(this._item, item))
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06048710 RID: 296720 RVA: 0x012A13AC File Offset: 0x0129F5AC
	void IList<!0>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x06048711 RID: 296721 RVA: 0x012A13B3 File Offset: 0x0129F5B3
	void IList<!0>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040265CD RID: 157133
	[CompilerGenerated]
	private readonly T _item;

	// Token: 0x0200D013 RID: 53267
	private sealed class Enumerator : IDisposable, IEnumerator, IEnumerator<!0>
	{
		// Token: 0x060522DB RID: 336603 RVA: 0x01650CA1 File Offset: 0x0164EEA1
		public Enumerator(T item)
		{
			this.System.Collections.Generic.IEnumerator<T>.Current = item;
		}

		// Token: 0x1700A2E2 RID: 41698
		// (get) Token: 0x060522DC RID: 336604 RVA: 0x01650CB0 File Offset: 0x0164EEB0
		object IEnumerator.Current
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x1700A2E3 RID: 41699
		// (get) Token: 0x060522DD RID: 336605 RVA: 0x01650CBD File Offset: 0x0164EEBD
		T IEnumerator<!0>.Current
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x060522DE RID: 336606 RVA: 0x01650CC8 File Offset: 0x0164EEC8
		bool IEnumerator.MoveNext()
		{
			return !this._moveNextCalled && (this._moveNextCalled = true);
		}

		// Token: 0x060522DF RID: 336607 RVA: 0x01650CE9 File Offset: 0x0164EEE9
		void IEnumerator.Reset()
		{
			this._moveNextCalled = false;
		}

		// Token: 0x060522E0 RID: 336608 RVA: 0x01650CF2 File Offset: 0x0164EEF2
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0403E83C RID: 256060
		[CompilerGenerated]
		private readonly T _item;

		// Token: 0x0403E83D RID: 256061
		[CompilerGenerated]
		private bool _moveNextCalled;
	}
}
