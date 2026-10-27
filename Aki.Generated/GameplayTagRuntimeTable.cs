using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using UnrealEngine;

// Token: 0x02000005 RID: 5
[NullableContext(1)]
[Nullable(0)]
public sealed class GameplayTagRuntimeTable
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600001D RID: 29 RVA: 0x0005A64B File Offset: 0x0005884B
	public IReadOnlyDictionary<int, int> TagId2UglyTagIdMap
	{
		get
		{
			return this.TagId2UglyTagIdMapInternal;
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0005A653 File Offset: 0x00058853
	public GameplayTagRuntimeTable()
	{
		this.EUglyGameplayTagId = new GameplayTagIdLookup(this, false);
		this.EGameplayTagId = new GameplayTagIdLookup(this, true);
		this.ParentTagIdMap = new GameplayTagRuntimeTable.ParentTagIdView();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0005A68C File Offset: 0x0005888C
	public bool TryGetTagId(string tagName, bool allowOriginalNameRemap, out int tagId)
	{
		tagId = UGASBPLibrary.FnvHash(tagName);
		int num;
		if (allowOriginalNameRemap && GameplayTagDefine.TryRemapTagId(tagId, out num))
		{
			this.TagId2UglyTagIdMapInternal[tagId] = num;
			tagId = num;
			return true;
		}
		int num2;
		return GameplayTagDefine.TryGetParentTagId(tagId, out num2) || GameplayTagDefine.IsRootTagId(tagId);
	}

	// Token: 0x0400000B RID: 11
	private readonly Dictionary<int, int> TagId2UglyTagIdMapInternal = new Dictionary<int, int>();

	// Token: 0x0400000C RID: 12
	public readonly IReadOnlyDictionary<string, int> EUglyGameplayTagId;

	// Token: 0x0400000D RID: 13
	public readonly IReadOnlyDictionary<string, int> EGameplayTagId;

	// Token: 0x0400000E RID: 14
	public readonly IReadOnlyDictionary<int, int> ParentTagIdMap;

	// Token: 0x020011EE RID: 4590
	[NullableContext(0)]
	private sealed class ParentTagIdView : IReadOnlyDictionary<int, int>, IEnumerable<KeyValuePair<int, int>>, IEnumerable, IReadOnlyCollection<KeyValuePair<int, int>>
	{
		// Token: 0x17003F57 RID: 16215
		public int this[int key]
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
				string message = "GameplayTag不存在父tag或id不合法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TagId", key);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
		}

		// Token: 0x0600EBE9 RID: 60393 RVA: 0x0034E887 File Offset: 0x0034CA87
		public bool TryGetValue(int key, out int value)
		{
			return GameplayTagDefine.TryGetParentTagId(key, out value);
		}

		// Token: 0x0600EBEA RID: 60394 RVA: 0x0034E890 File Offset: 0x0034CA90
		public bool ContainsKey(int key)
		{
			int num;
			return this.TryGetValue(key, out num);
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0600EBEB RID: 60395 RVA: 0x0034E8A6 File Offset: 0x0034CAA6
		public int Count
		{
			get
			{
				return 14442;
			}
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0600EBEC RID: 60396 RVA: 0x0034E8B0 File Offset: 0x0034CAB0
		[Nullable(1)]
		public IEnumerable<int> Keys
		{
			[NullableContext(1)]
			get
			{
				Log.Instance.Error(ELogModule.Game, ELogAuthor.LRX, "ParentTagIdMap为生成查询表，不支持遍历Keys", default(ReadOnlySpan<ValueTuple<string, object>>));
				return Enumerable.Empty<int>();
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0600EBED RID: 60397 RVA: 0x0034E8E0 File Offset: 0x0034CAE0
		[Nullable(1)]
		public IEnumerable<int> Values
		{
			[NullableContext(1)]
			get
			{
				Log.Instance.Error(ELogModule.Game, ELogAuthor.LRX, "ParentTagIdMap为生成查询表，不支持遍历Values", default(ReadOnlySpan<ValueTuple<string, object>>));
				return Enumerable.Empty<int>();
			}
		}

		// Token: 0x0600EBEE RID: 60398 RVA: 0x0034E910 File Offset: 0x0034CB10
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public IEnumerator<KeyValuePair<int, int>> GetEnumerator()
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.LRX, "ParentTagIdMap为生成查询表，不支持遍历", default(ReadOnlySpan<ValueTuple<string, object>>));
			return Enumerable.Empty<KeyValuePair<int, int>>().GetEnumerator();
		}

		// Token: 0x0600EBEF RID: 60399 RVA: 0x0034E943 File Offset: 0x0034CB43
		[NullableContext(1)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
