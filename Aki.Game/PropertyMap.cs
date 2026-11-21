using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Extension;

// Token: 0x020016D3 RID: 5843
[NullableContext(1)]
[Nullable(0)]
public class PropertyMap<TK, [Nullable(2)] TV> : IEnumerable<KeyValuePair<TK, TV>>, IEnumerable
{
	// Token: 0x170015AB RID: 5547
	// (get) Token: 0x0600E304 RID: 58116 RVA: 0x0042974B File Offset: 0x0042794B
	public int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this.Entries.Count;
		}
	}

	// Token: 0x0600E305 RID: 58117 RVA: 0x00429758 File Offset: 0x00427958
	public PropertyMap<TK, TV> Add(TK key, TV value)
	{
		return this.Set(key, value);
	}

	// Token: 0x0600E306 RID: 58118 RVA: 0x00429764 File Offset: 0x00427964
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public PropertyMap<TK, TV> Set(TK key, TV value)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		if (!Unsafe.IsNullRef<PropertyEntry<TV>>(ref valueRefOrNullRef))
		{
			if (EqualityComparer<TV>.Default.Equals(valueRefOrNullRef.Value, value))
			{
				return this;
			}
			valueRefOrNullRef.Value = value;
			valueRefOrNullRef.IsDirty = true;
		}
		else
		{
			this.Entries[key] = new PropertyEntry<TV>(value, true);
		}
		return this;
	}

	// Token: 0x0600E307 RID: 58119 RVA: 0x004297BF File Offset: 0x004279BF
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public TV Get(TK key)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		valueRefOrNullRef.IsDirty = false;
		return valueRefOrNullRef.Value;
	}

	// Token: 0x0600E308 RID: 58120 RVA: 0x004297DC File Offset: 0x004279DC
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public TV TryGet(TK key, TV defaultValue = default(TV), bool flushDirty = true)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		if (Unsafe.IsNullRef<PropertyEntry<TV>>(ref valueRefOrNullRef))
		{
			return defaultValue;
		}
		if (flushDirty && valueRefOrNullRef.IsDirty)
		{
			valueRefOrNullRef.IsDirty = false;
		}
		return valueRefOrNullRef.Value;
	}

	// Token: 0x0600E309 RID: 58121 RVA: 0x00429818 File Offset: 0x00427A18
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CleanDirty(TK key)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		if (!Unsafe.IsNullRef<PropertyEntry<TV>>(ref valueRefOrNullRef) && valueRefOrNullRef.IsDirty)
		{
			valueRefOrNullRef.IsDirty = false;
		}
	}

	// Token: 0x0600E30A RID: 58122 RVA: 0x0042984C File Offset: 0x00427A4C
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDirty(TK key)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		if (!Unsafe.IsNullRef<PropertyEntry<TV>>(ref valueRefOrNullRef) && !valueRefOrNullRef.IsDirty)
		{
			valueRefOrNullRef.IsDirty = true;
		}
	}

	// Token: 0x0600E30B RID: 58123 RVA: 0x00429880 File Offset: 0x00427A80
	public void SetAllDirty()
	{
		using (PoolArray<TK> poolArray = this.Entries.Keys.ToPoolArray<TK>())
		{
			foreach (TK key in poolArray)
			{
				ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
				if (!valueRefOrNullRef.IsDirty)
				{
					valueRefOrNullRef.IsDirty = true;
				}
			}
		}
	}

	// Token: 0x0600E30C RID: 58124 RVA: 0x00429910 File Offset: 0x00427B10
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsDirty(TK key)
	{
		PropertyEntry<TV> propertyEntry;
		return this.Entries.TryGetValue(key, out propertyEntry) && propertyEntry.IsDirty;
	}

	// Token: 0x170015AC RID: 5548
	public TV this[TK key]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this.Get(key);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
			this.Set(key, value);
		}
	}

	// Token: 0x0600E30F RID: 58127 RVA: 0x00429949 File Offset: 0x00427B49
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Remove(TK key)
	{
		return this.Entries.Remove(key);
	}

	// Token: 0x0600E310 RID: 58128 RVA: 0x00429957 File Offset: 0x00427B57
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Clear()
	{
		this.Entries.Clear();
	}

	// Token: 0x0600E311 RID: 58129 RVA: 0x00429964 File Offset: 0x00427B64
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool ContainsKey(TK key)
	{
		return this.Entries.ContainsKey(key);
	}

	// Token: 0x0600E312 RID: 58130 RVA: 0x00429974 File Offset: 0x00427B74
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool TryGetValue(TK key, [Nullable(2)] out TV value)
	{
		PropertyEntry<TV> propertyEntry;
		if (this.Entries.TryGetValue(key, out propertyEntry))
		{
			value = propertyEntry.Value;
			return true;
		}
		value = default(TV);
		return false;
	}

	// Token: 0x170015AD RID: 5549
	// (get) Token: 0x0600E313 RID: 58131 RVA: 0x004299A7 File Offset: 0x00427BA7
	public IEnumerable<TK> Keys
	{
		get
		{
			return this.Entries.Keys;
		}
	}

	// Token: 0x170015AE RID: 5550
	// (get) Token: 0x0600E314 RID: 58132 RVA: 0x004299B4 File Offset: 0x00427BB4
	public IEnumerable<TV> Values
	{
		get
		{
			PropertyMap<TK, TV>.<get_Values>d__21 <get_Values>d__ = new PropertyMap<TK, TV>.<get_Values>d__21(-2);
			<get_Values>d__.<>4__this = this;
			return <get_Values>d__;
		}
	}

	// Token: 0x0600E315 RID: 58133 RVA: 0x004299C4 File Offset: 0x00427BC4
	[return: Nullable(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public IEnumerator<KeyValuePair<TK, TV>> GetEnumerator()
	{
		PropertyMap<TK, TV>.<GetEnumerator>d__22 <GetEnumerator>d__ = new PropertyMap<TK, TV>.<GetEnumerator>d__22(0);
		<GetEnumerator>d__.<>4__this = this;
		return <GetEnumerator>d__;
	}

	// Token: 0x0600E316 RID: 58134 RVA: 0x004299D3 File Offset: 0x00427BD3
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x040081B8 RID: 33208
	[Nullable(new byte[]
	{
		1,
		1,
		0,
		1
	})]
	private readonly Dictionary<TK, PropertyEntry<TV>> Entries = new Dictionary<TK, PropertyEntry<TV>>();
}
