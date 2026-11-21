using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020064F0 RID: 25840
[CompilerGenerated]
internal sealed class <>z__ReadOnlyArray<T> : IEnumerable, ICollection, IList, IEnumerable<!0>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
	// Token: 0x0603EB20 RID: 256800 RVA: 0x01243C37 File Offset: 0x01241E37
	public <>z__ReadOnlyArray(T[] items)
	{
		this._items = items;
	}

	// Token: 0x0603EB21 RID: 256801 RVA: 0x01243C46 File Offset: 0x01241E46
	[return: Nullable(1)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this._items.GetEnumerator();
	}

	// Token: 0x1700772F RID: 30511
	// (get) Token: 0x0603EB22 RID: 256802 RVA: 0x01243C53 File Offset: 0x01241E53
	int ICollection.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17007730 RID: 30512
	// (get) Token: 0x0603EB23 RID: 256803 RVA: 0x01243C5D File Offset: 0x01241E5D
	bool ICollection.IsSynchronized
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17007731 RID: 30513
	// (get) Token: 0x0603EB24 RID: 256804 RVA: 0x01243C60 File Offset: 0x01241E60
	object ICollection.SyncRoot
	{
		[return: Nullable(1)]
		get
		{
			return this;
		}
	}

	// Token: 0x0603EB25 RID: 256805 RVA: 0x01243C63 File Offset: 0x01241E63
	void ICollection.CopyTo([Nullable(1)] Array array, int index)
	{
		this._items.CopyTo(array, index);
	}

	// Token: 0x17007732 RID: 30514
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

	// Token: 0x17007733 RID: 30515
	// (get) Token: 0x0603EB28 RID: 256808 RVA: 0x01243C8C File Offset: 0x01241E8C
	bool IList.IsFixedSize
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17007734 RID: 30516
	// (get) Token: 0x0603EB29 RID: 256809 RVA: 0x01243C8F File Offset: 0x01241E8F
	bool IList.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0603EB2A RID: 256810 RVA: 0x01243C92 File Offset: 0x01241E92
	int IList.Add([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB2B RID: 256811 RVA: 0x01243C99 File Offset: 0x01241E99
	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB2C RID: 256812 RVA: 0x01243CA0 File Offset: 0x01241EA0
	bool IList.Contains([Nullable(2)] object value)
	{
		return this._items.Contains(value);
	}

	// Token: 0x0603EB2D RID: 256813 RVA: 0x01243CAE File Offset: 0x01241EAE
	int IList.IndexOf([Nullable(2)] object value)
	{
		return this._items.IndexOf(value);
	}

	// Token: 0x0603EB2E RID: 256814 RVA: 0x01243CBC File Offset: 0x01241EBC
	void IList.Insert(int index, [Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB2F RID: 256815 RVA: 0x01243CC3 File Offset: 0x01241EC3
	void IList.Remove([Nullable(2)] object value)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB30 RID: 256816 RVA: 0x01243CCA File Offset: 0x01241ECA
	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB31 RID: 256817 RVA: 0x01243CD1 File Offset: 0x01241ED1
	[return: Nullable(new byte[]
	{
		1,
		0
	})]
	IEnumerator<T> IEnumerable<!0>.GetEnumerator()
	{
		return this._items.GetEnumerator();
	}

	// Token: 0x17007735 RID: 30517
	// (get) Token: 0x0603EB32 RID: 256818 RVA: 0x01243CDE File Offset: 0x01241EDE
	int IReadOnlyCollection<!0>.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17007736 RID: 30518
	T IReadOnlyList<!0>.this[int index]
	{
		get
		{
			return this._items[index];
		}
	}

	// Token: 0x17007737 RID: 30519
	// (get) Token: 0x0603EB34 RID: 256820 RVA: 0x01243CF6 File Offset: 0x01241EF6
	int ICollection<!0>.Count
	{
		get
		{
			return this._items.Length;
		}
	}

	// Token: 0x17007738 RID: 30520
	// (get) Token: 0x0603EB35 RID: 256821 RVA: 0x01243D00 File Offset: 0x01241F00
	bool ICollection<!0>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0603EB36 RID: 256822 RVA: 0x01243D03 File Offset: 0x01241F03
	void ICollection<!0>.Add(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB37 RID: 256823 RVA: 0x01243D0A File Offset: 0x01241F0A
	void ICollection<!0>.Clear()
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB38 RID: 256824 RVA: 0x01243D11 File Offset: 0x01241F11
	bool ICollection<!0>.Contains(T item)
	{
		return this._items.Contains(item);
	}

	// Token: 0x0603EB39 RID: 256825 RVA: 0x01243D1F File Offset: 0x01241F1F
	void ICollection<!0>.CopyTo([Nullable(new byte[]
	{
		1,
		0
	})] T[] array, int arrayIndex)
	{
		this._items.CopyTo(array, arrayIndex);
	}

	// Token: 0x0603EB3A RID: 256826 RVA: 0x01243D2E File Offset: 0x01241F2E
	bool ICollection<!0>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x17007739 RID: 30521
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

	// Token: 0x0603EB3D RID: 256829 RVA: 0x01243D4A File Offset: 0x01241F4A
	int IList<!0>.IndexOf(T item)
	{
		return this._items.IndexOf(item);
	}

	// Token: 0x0603EB3E RID: 256830 RVA: 0x01243D58 File Offset: 0x01241F58
	void IList<!0>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	// Token: 0x0603EB3F RID: 256831 RVA: 0x01243D5F File Offset: 0x01241F5F
	void IList<!0>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040218C2 RID: 137410
	[CompilerGenerated]
	private readonly T[] _items;
}
