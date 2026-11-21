using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common
{
	// Token: 0x02006407 RID: 25607
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorageCache
	{
		// Token: 0x0603E197 RID: 254359 RVA: 0x012046CC File Offset: 0x012028CC
		public void Set(string key, string encodedValue)
		{
			CacheObj cacheObj = this.Lru.Get(key);
			if (cacheObj != null)
			{
				cacheObj.EncodeValue = encodedValue;
				return;
			}
			this.Lru.Put(key, new CacheObj
			{
				EncodeValue = encodedValue
			}, 1);
		}

		// Token: 0x0603E198 RID: 254360 RVA: 0x0120470B File Offset: 0x0120290B
		[return: Nullable(2)]
		public string Get(string key)
		{
			CacheObj cacheObj = this.Lru.Get(key);
			if (cacheObj == null)
			{
				return null;
			}
			return cacheObj.EncodeValue;
		}

		// Token: 0x0603E199 RID: 254361 RVA: 0x01204724 File Offset: 0x01202924
		public void Clear()
		{
			this.Lru.Clear();
		}

		// Token: 0x04020F4E RID: 134990
		private const int CACHE_CAPACITY = 50;

		// Token: 0x04020F4F RID: 134991
		private readonly TrimLru<string, CacheObj> Lru = new TrimLru<string, CacheObj>(50, false);
	}
}
