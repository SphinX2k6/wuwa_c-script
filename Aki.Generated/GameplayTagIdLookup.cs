using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

// Token: 0x02000004 RID: 4
[NullableContext(1)]
[Nullable(0)]
public sealed class GameplayTagIdLookup : IReadOnlyDictionary<string, int>, IEnumerable<KeyValuePair<string, int>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, int>>
{
	// Token: 0x06000014 RID: 20 RVA: 0x0005A4B5 File Offset: 0x000586B5
	public GameplayTagIdLookup(GameplayTagRuntimeTable table, bool allowOriginalNameRemap)
	{
	}

	// Token: 0x17000008 RID: 8
	public int this[string key]
	{
		get
		{
			int result;
			if (this.TryGetValue(key, out result))
			{
				return result;
			}
			ILog instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "GameplayTag不存在，请检查GameplayTag设置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagName", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0005A528 File Offset: 0x00058728
	public bool TryGetValue(string key, out int value)
	{
		if (this.NameToTagIdCache.TryGetValue(key, out value))
		{
			return true;
		}
		if (this.InvalidNames.Contains(key))
		{
			value = 0;
			return false;
		}
		if (this.<table>P.TryGetTagId(key, this.<allowOriginalNameRemap>P, out value))
		{
			this.NameToTagIdCache[key] = value;
			return true;
		}
		this.InvalidNames.Add(key);
		return false;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0005A58C File Offset: 0x0005878C
	public bool ContainsKey(string key)
	{
		int num;
		return this.TryGetValue(key, out num);
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000018 RID: 24 RVA: 0x0005A5A2 File Offset: 0x000587A2
	public int Count
	{
		get
		{
			return this.NameToTagIdCache.Count;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000019 RID: 25 RVA: 0x0005A5B0 File Offset: 0x000587B0
	public IEnumerable<int> Values
	{
		get
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.LRX, "GameplayTagIdLookup按需构建，不支持遍历Values", default(ReadOnlySpan<ValueTuple<string, object>>));
			return Enumerable.Empty<int>();
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600001A RID: 26 RVA: 0x0005A5E0 File Offset: 0x000587E0
	public IEnumerable<string> Keys
	{
		get
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.LRX, "GameplayTagIdLookup不存储字符串key，不支持遍历Keys", default(ReadOnlySpan<ValueTuple<string, object>>));
			return Enumerable.Empty<string>();
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0005A610 File Offset: 0x00058810
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
	{
		Log.Instance.Error(ELogModule.Game, ELogAuthor.LRX, "GameplayTagIdLookup不存储字符串key，不支持遍历", default(ReadOnlySpan<ValueTuple<string, object>>));
		return Enumerable.Empty<KeyValuePair<string, int>>().GetEnumerator();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0005A643 File Offset: 0x00058843
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.GetEnumerator();
	}

	// Token: 0x04000007 RID: 7
	[CompilerGenerated]
	private GameplayTagRuntimeTable <table>P = table;

	// Token: 0x04000008 RID: 8
	[CompilerGenerated]
	private bool <allowOriginalNameRemap>P = allowOriginalNameRemap;

	// Token: 0x04000009 RID: 9
	private readonly Dictionary<string, int> NameToTagIdCache = new Dictionary<string, int>();

	// Token: 0x0400000A RID: 10
	private readonly HashSet<string> InvalidNames = new HashSet<string>();
}
