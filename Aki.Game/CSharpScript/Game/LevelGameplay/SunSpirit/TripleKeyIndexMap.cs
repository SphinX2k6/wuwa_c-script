using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x02005B4F RID: 23375
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
		// Token: 0x060397D6 RID: 235478 RVA: 0x01022DF8 File Offset: 0x01020FF8
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

		// Token: 0x060397D7 RID: 235479 RVA: 0x01022E34 File Offset: 0x01021034
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

		// Token: 0x060397D8 RID: 235480 RVA: 0x01022E7C File Offset: 0x0102107C
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

		// Token: 0x060397D9 RID: 235481 RVA: 0x01022ECC File Offset: 0x010210CC
		public bool HasVal(TK1 key1, TK2 key2, TK3 key3)
		{
			Dictionary<TK2, Dictionary<TK3, TV>> dictionary;
			Dictionary<TK3, TV> dictionary2;
			return base.TryGetValue(key1, out dictionary) && dictionary.TryGetValue(key2, out dictionary2) && dictionary2.ContainsKey(key3);
		}

		// Token: 0x060397DA RID: 235482 RVA: 0x01022EF8 File Offset: 0x010210F8
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
