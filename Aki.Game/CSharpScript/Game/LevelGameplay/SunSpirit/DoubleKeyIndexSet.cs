using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x020069F1 RID: 27121
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		1,
		1
	})]
	public class DoubleKeyIndexSet<[Nullable(2)] TK1, [Nullable(2)] TK2, [Nullable(2)] TV> : Dictionary<TK1, Dictionary<TK2, HashSet<TV>>>
	{
		// Token: 0x06043789 RID: 276361 RVA: 0x0107E67C File Offset: 0x0107C87C
		public void AddValToSet(TK1 key1, TK2 key2, TV val)
		{
			Dictionary<TK2, HashSet<TV>> dictionary;
			if (!base.TryGetValue(key1, out dictionary))
			{
				dictionary = new Dictionary<TK2, HashSet<TV>>();
				base[key1] = dictionary;
			}
			HashSet<TV> hashSet;
			if (!dictionary.TryGetValue(key2, out hashSet))
			{
				hashSet = new HashSet<TV>();
				dictionary[key2] = hashSet;
			}
			hashSet.Add(val);
		}

		// Token: 0x0604378A RID: 276362 RVA: 0x0107E6C4 File Offset: 0x0107C8C4
		public void DeleteValFromSet(TK1 key1, TK2 key2, TV val)
		{
			Dictionary<TK2, HashSet<TV>> dictionary;
			if (!base.TryGetValue(key1, out dictionary))
			{
				return;
			}
			HashSet<TV> hashSet;
			if (!dictionary.TryGetValue(key2, out hashSet))
			{
				return;
			}
			hashSet.Remove(val);
			if (hashSet.Count == 0)
			{
				dictionary.Remove(key2);
			}
			if (dictionary.Count == 0)
			{
				base.Remove(key1);
			}
		}

		// Token: 0x0604378B RID: 276363 RVA: 0x0107E714 File Offset: 0x0107C914
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<TV> GetSet(TK1 key1, TK2 key2)
		{
			Dictionary<TK2, HashSet<TV>> dictionary;
			HashSet<TV> result;
			if (base.TryGetValue(key1, out dictionary) && dictionary.TryGetValue(key2, out result))
			{
				return result;
			}
			return null;
		}
	}
}
