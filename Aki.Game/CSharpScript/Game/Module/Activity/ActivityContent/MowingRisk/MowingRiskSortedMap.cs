using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005327 RID: 21287
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskSortedMap<[Nullable(2)] T>
	{
		// Token: 0x06034FE8 RID: 217064 RVA: 0x00ED2159 File Offset: 0x00ED0359
		public MowingRiskSortedMap(Func<T, object> getUniqueKey)
		{
			if (getUniqueKey == null)
			{
				throw new ArgumentNullException("getUniqueKey");
			}
			this.GetUniqueKey = getUniqueKey;
			this.ListCache = new List<T>();
			this.MapCache = new Dictionary<object, T>();
		}

		// Token: 0x06034FE9 RID: 217065 RVA: 0x00ED2198 File Offset: 0x00ED0398
		private void Add(T value)
		{
			object key = this.GetUniqueKey(value);
			this.ListCache.Add(value);
			this.MapCache[key] = value;
		}

		// Token: 0x06034FEA RID: 217066 RVA: 0x00ED21CC File Offset: 0x00ED03CC
		public void DeleteByKey(object key)
		{
			if (key == null)
			{
				return;
			}
			this.ListCache.RemoveAll((T item) => this.GetUniqueKey(item).Equals(key));
			this.MapCache.Remove(key);
		}

		// Token: 0x06034FEB RID: 217067 RVA: 0x00ED2220 File Offset: 0x00ED0420
		public void Set(T value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			object key = this.GetUniqueKey(value);
			if (this.MapCache.ContainsKey(key))
			{
				int num = this.ListCache.FindIndex((T item) => this.GetUniqueKey(item).Equals(key));
				if (num >= 0)
				{
					this.ListCache[num] = value;
				}
				this.MapCache[key] = value;
				return;
			}
			this.Add(value);
		}

		// Token: 0x06034FEC RID: 217068 RVA: 0x00ED22B8 File Offset: 0x00ED04B8
		public T Get(object key)
		{
			if (key == null)
			{
				return default(T);
			}
			T result;
			this.MapCache.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x06034FED RID: 217069 RVA: 0x00ED22E2 File Offset: 0x00ED04E2
		public IEnumerable<T> GetAll()
		{
			return this.ListCache.AsReadOnly();
		}

		// Token: 0x0401C006 RID: 114694
		private readonly Func<T, object> GetUniqueKey;

		// Token: 0x0401C007 RID: 114695
		private readonly List<T> ListCache = new List<T>();

		// Token: 0x0401C008 RID: 114696
		private readonly Dictionary<object, T> MapCache;
	}
}
