using System;
using System.Runtime.CompilerServices;

// Token: 0x020000EF RID: 239
[NullableContext(1)]
[Nullable(0)]
public class DataTableKeyRow<[Nullable(2)] T>
{
	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000782 RID: 1922 RVA: 0x0002842C File Offset: 0x0002662C
	// (set) Token: 0x06000783 RID: 1923 RVA: 0x00028434 File Offset: 0x00026634
	public string Key
	{
		get
		{
			return this._key;
		}
		set
		{
			this._key = value;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x0002843D File Offset: 0x0002663D
	// (set) Token: 0x06000785 RID: 1925 RVA: 0x00028445 File Offset: 0x00026645
	public T Value
	{
		get
		{
			return this._value;
		}
		set
		{
			this._value = value;
		}
	}

	// Token: 0x170000F9 RID: 249
	public object this[int index]
	{
		get
		{
			if (index == 0)
			{
				return this.Key;
			}
			if (index != 1)
			{
				throw new IndexOutOfRangeException();
			}
			return this.Value;
		}
		set
		{
			if (index == 0)
			{
				this.Key = (string)value;
				return;
			}
			if (index != 1)
			{
				throw new IndexOutOfRangeException();
			}
			this.Value = (T)((object)value);
		}
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0002849B File Offset: 0x0002669B
	public DataTableKeyRow()
	{
		this._key = null;
		this._value = default(T);
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x000284B6 File Offset: 0x000266B6
	public DataTableKeyRow(string key, T value)
	{
		this._key = key;
		this._value = value;
	}

	// Token: 0x040005D2 RID: 1490
	private string _key;

	// Token: 0x040005D3 RID: 1491
	private T _value;
}
