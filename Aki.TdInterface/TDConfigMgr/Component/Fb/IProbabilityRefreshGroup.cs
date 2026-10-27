using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB9 RID: 2745
	[NullableContext(1)]
	[Nullable(0)]
	public class IProbabilityRefreshGroup
	{
		// Token: 0x06003F43 RID: 16195 RVA: 0x000A1A81 File Offset: 0x0009FC81
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

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x000A1AA0 File Offset: 0x0009FCA0
		[Nullable(2)]
		public virtual string CheckOccupation
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.CheckOccupation;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06003F45 RID: 16197 RVA: 0x000A1AB0 File Offset: 0x0009FCB0
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

		// Token: 0x04002320 RID: 8992
		private IProbabilityRefreshGroup Instance;

		// Token: 0x04002321 RID: 8993
		private List<IProbabilityRefreshItem> _RefreshItemsCache;

		// Token: 0x04002322 RID: 8994
		private bool _RefreshItemsInited;
	}
}
