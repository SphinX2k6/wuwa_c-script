using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x020069F2 RID: 27122
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1,
		1
	})]
	public class TripleKeyIndexMap<[Nullable(2)] TK1, [Nullable(2)] TK2, [Nullable(2)] TK3, [Nullable(2)] TV> : Dictionary<TK1, Dictionary<TK2, Dictionary<TK3, TV>>>
	{
		// Token: 0x0604378D RID: 276365 RVA: 0x0107E744 File Offset: 0x0107C944
		[return: Nullable(2)]
		public TV GetVal(TK1 key1, TK2 key2, TK3 key3)
		{
			Dictionary<TK2, Dictionary<TK3, TV>> dictionary;
			Dictionary<TK3, TV> dictionary2;
			TV result;
			if (base.TryGetValue(key1, out dictionary) && dictionary.TryGetValue(key2, out dictionary2) && dictionary2.TryGetValue(key3, out result))
			{
				return result;
			}
			return default(TV);
		}

		// Token: 0x0604378E RID: 276366 RVA: 0x0107E780 File Offset: 0x0107C980
		public void SetVal(TK1 key1, TK2 key2, TK3 key3, TV val)
		{
			Dictionary<TK2, Dictionary<TK3, TV>> dictionary;
			if (!base.TryGetValue(key1, out dictionary))
			{
				dictionary = new Dictionary<TK2, Dictionary<TK3, TV>>();
				base[key1] = dictionary;
			}
			Dictionary<TK3, TV> dictionary2;
			if (!dictionary.TryGetValue(key2, out dictionary2))
			{
				dictionary2 = new Dictionary<TK3, TV>();
				dictionary[key2] = dictionary2;
			}
			dictionary2[key3] = val;
		}

		// Token: 0x0604378F RID: 276367 RVA: 0x0107E7C8 File Offset: 0x0107C9C8
		public void DelVal(TK1 key1, TK2 key2, TK3 key3)
		{
			Dictionary<TK2, Dictionary<TK3, TV>> dictionary;
			if (!base.TryGetValue(key1, out dictionary))
			{
				return;
			}
			Dictionary<TK3, TV> dictionary2;
			if (!dictionary.TryGetValue(key2, out dictionary2))
			{
				return;
			}
			dictionary2.Remove(key3);
			if (dictionary2.Count == 0)
			{
				dictionary.Remove(key2);
			}
			if (dictionary.Count == 0)
			{
				base.Remove(key1);
			}
		}

		// Token: 0x06043790 RID: 276368 RVA: 0x0107E818 File Offset: 0x0107CA18
		public bool HasVal(TK1 key1, TK2 key2, TK3 key3)
		{
			Dictionary<TK2, Dictionary<TK3, TV>> dictionary;
			Dictionary<TK3, TV> dictionary2;
			return base.TryGetValue(key1, out dictionary) && dictionary.TryGetValue(key2, out dictionary2) && dictionary2.ContainsKey(key3);
		}

		// Token: 0x06043791 RID: 276369 RVA: 0x0107E844 File Offset: 0x0107CA44
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<TK3, TV> GetValMap(TK1 key1, TK2 key2)
		{
			Dictionary<TK2, Dictionary<TK3, TV>> dictionary;
			Dictionary<TK3, TV> result;
			if (base.TryGetValue(key1, out dictionary) && dictionary.TryGetValue(key2, out result))
			{
				return result;
			}
			return null;
		}
	}
}
