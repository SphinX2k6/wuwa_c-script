using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Extension;

// Token: 0x020021EF RID: 8687
[NullableContext(1)]
[Nullable(0)]
public class PropertyMap<TK, [Nullable(2)] TV> : IEnumerable<KeyValuePair<TK, TV>>, IEnumerable
{
	// Token: 0x17001574 RID: 5492
	// (get) Token: 0x06010E71 RID: 69233 RVA: 0x0041CDBB File Offset: 0x0041AFBB
	public int Count
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return this.Entries.Count;
		}
	}

	// Token: 0x06010E72 RID: 69234 RVA: 0x0041CDC8 File Offset: 0x0041AFC8
	public PropertyMap<TK, TV> Add(TK key, TV value)
	{
		return this.Set(key, value);
	}

	// Token: 0x06010E73 RID: 69235 RVA: 0x0041CDD4 File Offset: 0x0041AFD4
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

	// Token: 0x06010E74 RID: 69236 RVA: 0x0041CE2F File Offset: 0x0041B02F
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public TV Get(TK key)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		valueRefOrNullRef.IsDirty = false;
		return valueRefOrNullRef.Value;
	}

	// Token: 0x06010E75 RID: 69237 RVA: 0x0041CE4C File Offset: 0x0041B04C
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

	// Token: 0x06010E76 RID: 69238 RVA: 0x0041CE88 File Offset: 0x0041B088
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void CleanDirty(TK key)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		if (!Unsafe.IsNullRef<PropertyEntry<TV>>(ref valueRefOrNullRef) && valueRefOrNullRef.IsDirty)
		{
			valueRefOrNullRef.IsDirty = false;
		}
	}

	// Token: 0x06010E77 RID: 69239 RVA: 0x0041CEBC File Offset: 0x0041B0BC
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetDirty(TK key)
	{
		ref PropertyEntry<TV> valueRefOrNullRef = ref CollectionsMarshal.GetValueRefOrNullRef<TK, PropertyEntry<TV>>(this.Entries, key);
		if (!Unsafe.IsNullRef<PropertyEntry<TV>>(ref valueRefOrNullRef) && !valueRefOrNullRef.IsDirty)
		{
			valueRefOrNullRef.IsDirty = true;
		}
	}

	// Token: 0x06010E78 RID: 69240 RVA: 0x0041CEF0 File Offset: 0x0041B0F0
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

	// Token: 0x06010E79 RID: 69241 RVA: 0x0041CF7C File Offset: 0x0041B17C
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool IsDirty(TK key)
	{
		PropertyEntry<TV> propertyEntry;
		return this.Entries.TryGetValue(key, out propertyEntry) && propertyEntry.IsDirty;
	}

	// Token: 0x17001575 RID: 5493
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

	// Token: 0x06010E7C RID: 69244 RVA: 0x0041CFB5 File Offset: 0x0041B1B5
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Remove(TK key)
	{
		return this.Entries.Remove(key);
	}

	// Token: 0x06010E7D RID: 69245 RVA: 0x0041CFC3 File Offset: 0x0041B1C3
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Clear()
	{
		this.Entries.Clear();
	}

	// Token: 0x06010E7E RID: 69246 RVA: 0x0041CFD0 File Offset: 0x0041B1D0
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool ContainsKey(TK key)
	{
		return this.Entries.ContainsKey(key);
	}

	// Token: 0x06010E7F RID: 69247 RVA: 0x0041CFE0 File Offset: 0x0041B1E0
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

	// Token: 0x17001576 RID: 5494
	// (get) Token: 0x06010E80 RID: 69248 RVA: 0x0041D013 File Offset: 0x0041B213
	public IEnumerable<TK> Keys
	{
		get
		{
			return this.Entries.Keys;
		}
	}

	// Token: 0x17001577 RID: 5495
	// (get) Token: 0x06010E81 RID: 69249 RVA: 0x0041D020 File Offset: 0x0041B220
	public IEnumerable<TV> Values
	{
		get
		{
			PropertyMap<TK, TV>.<get_Values>d__21 <get_Values>d__ = new PropertyMap<TK, TV>.<get_Values>d__21(-2);
			<get_Values>d__.<>4__this = this;
			return <get_Values>d__;
		}
	}

	// Token: 0x06010E82 RID: 69250 RVA: 0x0041D030 File Offset: 0x0041B230
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

	// Token: 0x06010E83 RID: 69251 RVA: 0x0041D03F File Offset: 0x0041B23F
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x0400807A RID: 32890
	[Nullable(new byte[]
	{
		1,
		1,
		0,
		1
	})]
	private readonly Dictionary<TK, PropertyEntry<TV>> Entries = new Dictionary<TK, PropertyEntry<TV>>();
}
