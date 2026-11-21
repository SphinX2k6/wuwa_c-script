using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F5D RID: 3933
	public class TComponentsData
	{
		// Token: 0x06005822 RID: 22562 RVA: 0x000D7782 File Offset: 0x000D5982
		public static TComponentsData Create(TComponentsData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TComponentsData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06005823 RID: 22563 RVA: 0x000D77A4 File Offset: 0x000D59A4
		public virtual List<TComponentData> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				int itemsLength = this.Instance.ItemsLength;
				this._ItemsCache = new List<TComponentData>(itemsLength);
				for (int i = 0; i < itemsLength; i++)
				{
					this._ItemsCache.Add(TComponentData.Create(this.Instance.Items(i)));
				}
				return this._ItemsCache;
			}
		}

		// Token: 0x0400329A RID: 12954
		private TComponentsData Instance;

		// Token: 0x0400329B RID: 12955
		private List<TComponentData> _ItemsCache;

		// Token: 0x0400329C RID: 12956
		private bool _ItemsInited;
	}
}
