using System;
using System.Runtime.CompilerServices;

// Token: 0x020000ED RID: 237
[NullableContext(1)]
[Nullable(0)]
public class DataTableKeyRow<[Nullable(2)] T>
{
	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x06000740 RID: 1856 RVA: 0x00027E2C File Offset: 0x0002602C
	// (set) Token: 0x06000741 RID: 1857 RVA: 0x00027E34 File Offset: 0x00026034
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

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000742 RID: 1858 RVA: 0x00027E3D File Offset: 0x0002603D
	// (set) Token: 0x06000743 RID: 1859 RVA: 0x00027E45 File Offset: 0x00026045
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

	// Token: 0x170000E7 RID: 231
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

	// Token: 0x06000746 RID: 1862 RVA: 0x00027E9B File Offset: 0x0002609B
	public DataTableKeyRow()
	{
		this._key = null;
		this._value = default(T);
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00027EB6 File Offset: 0x000260B6
	public DataTableKeyRow(string key, T value)
	{
		this._key = key;
		this._value = value;
	}

	// Token: 0x040005C3 RID: 1475
	private string _key;

	// Token: 0x040005C4 RID: 1476
	private T _value;
}
