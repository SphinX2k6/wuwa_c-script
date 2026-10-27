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
	// Token: 0x06000238 RID: 568 RVA: 0x0000CC8B File Offset: 0x0000AE8B
	public ImmutableMap<K, V> set(K key, V value)
	{
		this.LogError("set");
		return this;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000CC99 File Offset: 0x0000AE99
	public bool delete(K key)
	{
		this.LogError("delete");
		return false;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x0000CCA7 File Offset: 0x0000AEA7
	public void clear()
	{
		this.LogError("clear");
	}

	// Token: 0x0600023B RID: 571 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
	public new void Add(K key, V value)
	{
		this.LogError("set");
	}

	// Token: 0x0600023C RID: 572 RVA: 0x0000CCC1 File Offset: 0x0000AEC1
	public new bool TryAdd(K key, V value)
	{
		this.LogError("set");
		return false;
	}

	// Token: 0x17000048 RID: 72
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

	// Token: 0x0600023F RID: 575 RVA: 0x0000CCE5 File Offset: 0x0000AEE5
	public new bool Remove(K key)
	{
		this.LogError("delete");
		return false;
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000CCF3 File Offset: 0x0000AEF3
	public new bool Remove(K key, out V value)
	{
		this.LogError("delete");
		value = default(V);
		return false;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000CD08 File Offset: 0x0000AF08
	public new void Clear()
	{
		this.LogError("clear");
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0000CD18 File Offset: 0x0000AF18
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
