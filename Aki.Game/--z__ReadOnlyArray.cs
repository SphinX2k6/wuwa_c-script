using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200736D RID: 29549
[CompilerGenerated]
internal sealed class <>z__ReadOnlyArray<T> : IEnumerable, ICollection, IList, IEnumerable<!0>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
	// Token: 0x060486D2 RID: 296658 RVA: 0x012A113B File Offset: 0x0129F33B
	public <>z__ReadOnlyArray(T[] items)
	{
		this._items = items;
	}

	// Token: 0x060486D3 RID: 296659 RVA: 0x012A114A File Offset: 0x0129F34A
	[return: Nullable(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this._items.GetEnumerator();
	}

	// Token: 0x17009F91 RID: 40849
	// (get) Token: 0x060486D4 RID: 296660 RVA: 0x012A1157 File Offset: 0x0129F357
	int ICollection.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17009F92 RID: 40850
	// (get) Token: 0x060486D5 RID: 296661 RVA: 0x012A1161 File Offset: 0x0129F361
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17009F93 RID: 40851
	// (get) Token: 0x060486D6 RID: 296662 RVA: 0x012A1164 File Offset: 0x0129F364
	object ICollection.SyncRoot
	{
		[return: Nullable(1)]
		get
		{
			return this;
		}
	}

	// Token: 0x060486D7 RID: 296663 RVA: 0x012A1167 File Offset: 0x0129F367
	void ICollection.CopyTo([Nullable(1)] Array array, int index)
	{
		this._items.CopyTo(array, index);
	}

	// Token: 0x17009F94 RID: 40852
	object IList.this[int index]
	{
		[return: Nullable(2)]
		get
		{
			return this._items[index];
		}
		[param: Nullable(2)]
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17009F95 RID: 40853
	// (get) Token: 0x060486DA RID: 296666 RVA: 0x012A1190 File Offset: 0x0129F390
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17009F96 RID: 40854
	// (get) Token: 0x060486DB RID: 296667 RVA: 0x012A1193 File Offset: 0x0129F393
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060486DC RID: 296668 RVA: 0x012A1196 File Offset: 0x0129F396
	int IList.Add([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486DD RID: 296669 RVA: 0x012A119D File Offset: 0x0129F39D
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486DE RID: 296670 RVA: 0x012A11A4 File Offset: 0x0129F3A4
	bool IList.Contains([Nullable(2)] object value)
	{
		return this._items.Contains(value);
	}

	// Token: 0x060486DF RID: 296671 RVA: 0x012A11B2 File Offset: 0x0129F3B2
	int IList.IndexOf([Nullable(2)] object value)
	{
		return this._items.IndexOf(value);
	}

	// Token: 0x060486E0 RID: 296672 RVA: 0x012A11C0 File Offset: 0x0129F3C0
	void IList.Insert(int index, [Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486E1 RID: 296673 RVA: 0x012A11C7 File Offset: 0x0129F3C7
	void IList.Remove([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486E2 RID: 296674 RVA: 0x012A11CE File Offset: 0x0129F3CE
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486E3 RID: 296675 RVA: 0x012A11D5 File Offset: 0x0129F3D5
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	IEnumerator<T> IEnumerable<!0>.GetEnumerator()
	{
		return this._items.GetEnumerator();
	}

	// Token: 0x17009F97 RID: 40855
	// (get) Token: 0x060486E4 RID: 296676 RVA: 0x012A11E2 File Offset: 0x0129F3E2
	int IReadOnlyCollection<!0>.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17009F98 RID: 40856
	T IReadOnlyList<!0>.this[int index]
	{
		get
		{
			return this._items[index];
		}
	}

	// Token: 0x17009F99 RID: 40857
	// (get) Token: 0x060486E6 RID: 296678 RVA: 0x012A11FA File Offset: 0x0129F3FA
	int ICollection<!0>.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17009F9A RID: 40858
	// (get) Token: 0x060486E7 RID: 296679 RVA: 0x012A1204 File Offset: 0x0129F404
	bool ICollection<!0>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060486E8 RID: 296680 RVA: 0x012A1207 File Offset: 0x0129F407
	void ICollection<!0>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486E9 RID: 296681 RVA: 0x012A120E File Offset: 0x0129F40E
	void ICollection<!0>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486EA RID: 296682 RVA: 0x012A1215 File Offset: 0x0129F415
	bool ICollection<!0>.Contains(T item)
	{
		return this._items.Contains(item);
	}

	// Token: 0x060486EB RID: 296683 RVA: 0x012A1223 File Offset: 0x0129F423
	void ICollection<!0>.CopyTo([Nullable(new byte[]
	{
		1,
		0
	})] T[] array, int arrayIndex)
	{
		this._items.CopyTo(array, arrayIndex);
	}

	// Token: 0x060486EC RID: 296684 RVA: 0x012A1232 File Offset: 0x0129F432
	bool ICollection<!0>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17009F9B RID: 40859
	T IList<!0>.this[int index]
	{
		get
		{
			return this._items[index];
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x060486EF RID: 296687 RVA: 0x012A124E File Offset: 0x0129F44E
	int IList<!0>.IndexOf(T item)
	{
		return this._items.IndexOf(item);
	}

	// Token: 0x060486F0 RID: 296688 RVA: 0x012A125C File Offset: 0x0129F45C
	void IList<!0>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060486F1 RID: 296689 RVA: 0x012A1263 File Offset: 0x0129F463
	void IList<!0>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040265CC RID: 157132
	[CompilerGenerated]
	private readonly T[] _items;
}
