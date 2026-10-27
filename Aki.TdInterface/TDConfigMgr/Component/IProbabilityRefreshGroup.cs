using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000622 RID: 1570
	[NullableContext(1)]
	[Nullable(0)]
	public class IProbabilityRefreshGroup
	{
		// Token: 0x0600217E RID: 8574 RVA: 0x0005CA64 File Offset: 0x0005AC64
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

		// Token: 0x0600217F RID: 8575 RVA: 0x0005CA9C File Offset: 0x0005AC9C
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

		// Token: 0x06002180 RID: 8576 RVA: 0x0005CAAF File Offset: 0x0005ACAF
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

		// Token: 0x06002181 RID: 8577 RVA: 0x0005CAC2 File Offset: 0x0005ACC2
		public IProbabilityRefreshGroup_SetValue ToSetValue()
		{
			return new IProbabilityRefreshGroup_SetValue
			{
				CheckOccupation = this.CheckOccupation,
				RefreshItems = this.RefreshItems
			};
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0005CAE1 File Offset: 0x0005ACE1
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0005CB08 File Offset: 0x0005AD08
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

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0005CB18 File Offset: 0x0005AD18
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x0005CBAB File Offset: 0x0005ADAB
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

		// Token: 0x04001763 RID: 5987
		[Nullable(2)]
		protected IProbabilityRefreshGroup FbInstance;

		// Token: 0x04001764 RID: 5988
		[Nullable(2)]
		protected IProbabilityRefreshGroup_SetValue PocoInterface;

		// Token: 0x04001765 RID: 5989
		private List<IProbabilityRefreshItem> _RefreshItemsCache;

		// Token: 0x04001766 RID: 5990
		private bool _RefreshItemsInited;
	}
}
