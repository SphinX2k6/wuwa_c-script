using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B83 RID: 2947
	public class IProbabilityRefreshGroup
	{
		// Token: 0x0600436D RID: 17261 RVA: 0x000AB075 File Offset: 0x000A9275
		public static IProbabilityRefreshGroup Create(IProbabilityRefreshGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProbabilityRefreshGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x000AB094 File Offset: 0x000A9294
		[Nullable(2)]
		public virtual string CheckOccupation
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CheckOccupation;
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x0600436F RID: 17263 RVA: 0x000AB0A4 File Offset: 0x000A92A4
		public virtual List<IProbabilityRefreshItem> RefreshItems
		{
			get
			{
				if (this._RefreshItemsInited)
				{
					return this._RefreshItemsCache;
				}
				this._RefreshItemsInited = true;
				int refreshItemsLength = this.Instance.RefreshItemsLength;
				this._RefreshItemsCache = new List<IProbabilityRefreshItem>(refreshItemsLength);
				for (int i = 0; i < refreshItemsLength; i++)
				{
					this._RefreshItemsCache.Add(IProbabilityRefreshItem.Create(this.Instance.RefreshItems(i)));
				}
				return this._RefreshItemsCache;
			}
		}

		// Token: 0x0400253C RID: 9532
		private IProbabilityRefreshGroup Instance;

		// Token: 0x0400253D RID: 9533
		private List<IProbabilityRefreshItem> _RefreshItemsCache;

		// Token: 0x0400253E RID: 9534
		private bool _RefreshItemsInited;
	}
}
