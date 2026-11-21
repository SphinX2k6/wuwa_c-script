using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095D RID: 2397
	public class TComponentsData
	{
		// Token: 0x0600356F RID: 13679 RVA: 0x00088009 File Offset: 0x00086209
		public static TComponentsData Create([Nullable(2)] TComponentsData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TComponentsData
			{
				FbInstance = instance
			};
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x0008801C File Offset: 0x0008621C
		public virtual List<TComponentData> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				if (this.FbInstance != null)
				{
					List<TComponentData> items = this.FbInstance.Items;
					if (items != null)
					{
						this._ItemsCache = new List<TComponentData>(items.Count);
						for (int i = 0; i < items.Count; i++)
						{
							this._ItemsCache.Add(TComponentData.Create(items[i]));
						}
					}
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x040022F8 RID: 8952
		private TComponentsData FbInstance;

		// Token: 0x040022F9 RID: 8953
		private List<TComponentData> _ItemsCache;

		// Token: 0x040022FA RID: 8954
		private bool _ItemsInited;
	}
}
