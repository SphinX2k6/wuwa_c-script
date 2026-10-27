using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Common
{
	// Token: 0x02007288 RID: 29320
	[NullableContext(1)]
	[Nullable(0)]
	public class LocalStorageCache
	{
		// Token: 0x06047DD7 RID: 294359 RVA: 0x01263CBC File Offset: 0x01261EBC
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

		// Token: 0x06047DD8 RID: 294360 RVA: 0x01263CFB File Offset: 0x01261EFB
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

		// Token: 0x06047DD9 RID: 294361 RVA: 0x01263D14 File Offset: 0x01261F14
		public void Clear()
		{
			this.Lru.Clear();
		}

		// Token: 0x04025C8E RID: 154766
		private const int CACHE_CAPACITY = 50;

		// Token: 0x04025C8F RID: 154767
		private readonly TrimLru<string, CacheObj> Lru = new TrimLru<string, CacheObj>(50, false);
	}
}
