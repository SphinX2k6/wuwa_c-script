using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008BA RID: 2234
	[NullableContext(1)]
	[Nullable(0)]
	public class TComponentsData
	{
		// Token: 0x06003233 RID: 12851 RVA: 0x00080B21 File Offset: 0x0007ED21
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

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x00080B34 File Offset: 0x0007ED34
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

		// Token: 0x040020E6 RID: 8422
		private TComponentsData FbInstance;

		// Token: 0x040020E7 RID: 8423
		private List<TComponentData> _ItemsCache;

		// Token: 0x040020E8 RID: 8424
		private bool _ItemsInited;
	}
}
