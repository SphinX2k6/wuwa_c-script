using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006BF RID: 1727
	public class IProbabilityRefreshGroup
	{
		// Token: 0x06002484 RID: 9348 RVA: 0x00063778 File Offset: 0x00061978
		private IProbabilityRefreshGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProbabilityRefreshGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProbabilityRefreshGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProbabilityRefreshGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x000637B0 File Offset: 0x000619B0
		public static IProbabilityRefreshGroup Create([Nullable(2)] IProbabilityRefreshGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProbabilityRefreshGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x000637C3 File Offset: 0x000619C3
		public static IProbabilityRefreshGroup CreateFromSetValue([Nullable(2)] IProbabilityRefreshGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProbabilityRefreshGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x000637D6 File Offset: 0x000619D6
		public IProbabilityRefreshGroup_SetValue ToSetValue()
		{
			return new IProbabilityRefreshGroup_SetValue
			{
				CheckOccupation = this.CheckOccupation,
				RefreshItems = this.RefreshItems
			};
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x000637F5 File Offset: 0x000619F5
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x0006381C File Offset: 0x00061A1C
		[Nullable(2)]
		public virtual string CheckOccupation
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CheckOccupation;
				}
				IProbabilityRefreshGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CheckOccupation;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CheckOccupation = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x0006382C File Offset: 0x00061A2C
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x000638BF File Offset: 0x00061ABF
		public virtual List<IProbabilityRefreshItem> RefreshItems
		{
			get
			{
				if (this._RefreshItemsInited)
				{
					return this._RefreshItemsCache;
				}
				this._RefreshItemsInited = true;
				if (this.FbInstance != null)
				{
					List<IProbabilityRefreshItem> refreshItems = this.FbInstance.RefreshItems;
					if (refreshItems != null)
					{
						this._RefreshItemsCache = new List<IProbabilityRefreshItem>(refreshItems.Count);
						for (int i = 0; i < refreshItems.Count; i++)
						{
							this._RefreshItemsCache.Add(IProbabilityRefreshItem.Create(refreshItems[i]));
						}
					}
				}
				else
				{
					IProbabilityRefreshGroup_SetValue pocoInterface = this.PocoInterface;
					this._RefreshItemsCache = ((pocoInterface != null) ? pocoInterface.RefreshItems : null);
				}
				return this._RefreshItemsCache;
			}
			set
			{
				this.GetOrCreatePoco().RefreshItems = value;
				this._RefreshItemsInited = false;
			}
		}

		// Token: 0x04001955 RID: 6485
		[Nullable(2)]
		protected IProbabilityRefreshGroup FbInstance;

		// Token: 0x04001956 RID: 6486
		[Nullable(2)]
		protected IProbabilityRefreshGroup_SetValue PocoInterface;

		// Token: 0x04001957 RID: 6487
		private List<IProbabilityRefreshItem> _RefreshItemsCache;

		// Token: 0x04001958 RID: 6488
		private bool _RefreshItemsInited;
	}
}
