using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063A9 RID: 25513
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskSortedMap<[Nullable(2)] T>
	{
		// Token: 0x06040327 RID: 262951 RVA: 0x00F8B1C1 File Offset: 0x00F893C1
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

		// Token: 0x06040328 RID: 262952 RVA: 0x00F8B200 File Offset: 0x00F89400
		private void Add(T value)
		{
			object key = this.GetUniqueKey(value);
			this.ListCache.Add(value);
			this.MapCache[key] = value;
		}

		// Token: 0x06040329 RID: 262953 RVA: 0x00F8B234 File Offset: 0x00F89434
		public void DeleteByKey(object key)
		{
			if (key == null)
			{
				return;
			}
			this.ListCache.RemoveAll((T item) => this.GetUniqueKey(item).Equals(key));
			this.MapCache.Remove(key);
		}

		// Token: 0x0604032A RID: 262954 RVA: 0x00F8B288 File Offset: 0x00F89488
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

		// Token: 0x0604032B RID: 262955 RVA: 0x00F8B320 File Offset: 0x00F89520
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

		// Token: 0x0604032C RID: 262956 RVA: 0x00F8B34A File Offset: 0x00F8954A
		public IEnumerable<T> GetAll()
		{
			return this.ListCache.AsReadOnly();
		}

		// Token: 0x040216D7 RID: 136919
		private readonly Func<T, object> GetUniqueKey;

		// Token: 0x040216D8 RID: 136920
		private readonly List<T> ListCache = new List<T>();

		// Token: 0x040216D9 RID: 136921
		private readonly Dictionary<object, T> MapCache;
	}
}
