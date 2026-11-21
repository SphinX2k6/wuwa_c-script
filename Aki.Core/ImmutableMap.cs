using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200004E RID: 78
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class ImmutableMap<[Nullable(2)] K, [Nullable(2)] V> : Dictionary<K, V>
{
	// Token: 0x06000239 RID: 569 RVA: 0x0000C96F File Offset: 0x0000AB6F
	public ImmutableMap<K, V> set(K key, V value)
	{
		this.LogError("set");
		return this;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000C97D File Offset: 0x0000AB7D
	public bool delete(K key)
	{
		this.LogError("delete");
		return false;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000C98B File Offset: 0x0000AB8B
	public void clear()
	{
		this.LogError("clear");
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0000C998 File Offset: 0x0000AB98
	public new void Add(K key, V value)
	{
		this.LogError("set");
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000C9A5 File Offset: 0x0000ABA5
	public new bool TryAdd(K key, V value)
	{
		this.LogError("set");
		return false;
	}

	// Token: 0x17000047 RID: 71
	public new V this[K key]
	{
		get
		{
			return base[key];
		}
		set
		{
			this.LogError("set");
		}
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000C9C9 File Offset: 0x0000ABC9
	public new bool Remove(K key)
	{
		this.LogError("delete");
		return false;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000C9D7 File Offset: 0x0000ABD7
	public new bool Remove(K key, out V value)
	{
		this.LogError("delete");
		value = default(V);
		return false;
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0000C9EC File Offset: 0x0000ABEC
	public new void Clear()
	{
		this.LogError("clear");
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0000C9FC File Offset: 0x0000ABFC
	private void LogError(string funcName)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Core;
		ELogAuthor author = ELogAuthor.CYK;
		string message = "ImmutableMap 不允许修改";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("函数名", funcName);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}
}
