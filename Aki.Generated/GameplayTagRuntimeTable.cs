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
	// (get) Token: 0x0600001D RID: 29 RVA: 0x0005DEC7 File Offset: 0x0005C0C7
	public IReadOnlyDictionary<int, int> TagId2UglyTagIdMap
	{
		get
		{
			return this.TagId2UglyTagIdMapInternal;
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0005DECF File Offset: 0x0005C0CF
	public GameplayTagRuntimeTable()
	{
		this.EUglyGameplayTagId = new GameplayTagIdLookup(this, false);
		this.EGameplayTagId = new GameplayTagIdLookup(this, true);
		this.ParentTagIdMap = new GameplayTagRuntimeTable.ParentTagIdView();
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0005DF08 File Offset: 0x0005C108
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

	// Token: 0x02001327 RID: 4903
	[NullableContext(0)]
	private sealed class ParentTagIdView : IReadOnlyDictionary<int, int>, IEnumerable<KeyValuePair<int, int>>, IEnumerable, IReadOnlyCollection<KeyValuePair<int, int>>
	{
		// Token: 0x170042C7 RID: 17095
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

		// Token: 0x0600F974 RID: 63860 RVA: 0x00379BEB File Offset: 0x00377DEB
		public bool TryGetValue(int key, out int value)
		{
			return GameplayTagDefine.TryGetParentTagId(key, out value);
		}

		// Token: 0x0600F975 RID: 63861 RVA: 0x00379BF4 File Offset: 0x00377DF4
		public bool ContainsKey(int key)
		{
			int num;
			return this.TryGetValue(key, out num);
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x0600F976 RID: 63862 RVA: 0x00379C0A File Offset: 0x00377E0A
		public int Count
		{
			get
			{
				return 14893;
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x0600F977 RID: 63863 RVA: 0x00379C14 File Offset: 0x00377E14
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

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x0600F978 RID: 63864 RVA: 0x00379C44 File Offset: 0x00377E44
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

		// Token: 0x0600F979 RID: 63865 RVA: 0x00379C74 File Offset: 0x00377E74
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

		// Token: 0x0600F97A RID: 63866 RVA: 0x00379CA7 File Offset: 0x00377EA7
		[NullableContext(1)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}
