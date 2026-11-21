using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E9 RID: 1769
	public class IRandomBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x00065B40 File Offset: 0x00063D40
		private IRandomBatchRefresh_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomBatchRefresh 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomBatchRefresh_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomBatchRefresh_SetValue());
			}
			return result;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00065B78 File Offset: 0x00063D78
		public static IRandomBatchRefresh Create([Nullable(2)] IRandomBatchRefresh instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomBatchRefresh
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00065B8B File Offset: 0x00063D8B
		public static IRandomBatchRefresh CreateFromSetValue([Nullable(2)] IRandomBatchRefresh_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomBatchRefresh
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00065B9E File Offset: 0x00063D9E
		public new IRandomBatchRefresh_SetValue ToSetValue()
		{
			return new IRandomBatchRefresh_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches
			};
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x00065BBD File Offset: 0x00063DBD
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x00065BE8 File Offset: 0x00063DE8
		public override EEntityBatchRefreshMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityBatchRefreshMode.SequenceBatch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x00065BF8 File Offset: 0x00063DF8
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x00065C8B File Offset: 0x00063E8B
		public override List<IEntityListBatch> EntityBatches
		{
			get
			{
				if (this._EntityBatchesInited)
				{
					return this._EntityBatchesCache;
				}
				this._EntityBatchesInited = true;
				if (this.FbInstance != null)
				{
					List<IEntityListBatch> entityBatches = this.FbInstance.EntityBatches;
					if (entityBatches != null)
					{
						this._EntityBatchesCache = new List<IEntityListBatch>(entityBatches.Count);
						for (int i = 0; i < entityBatches.Count; i++)
						{
							this._EntityBatchesCache.Add(IEntityListBatch.Create(entityBatches[i]));
						}
					}
				}
				else
				{
					IRandomBatchRefresh_SetValue pocoInterface = this.PocoInterface;
					this._EntityBatchesCache = ((pocoInterface != null) ? pocoInterface.EntityBatches : null);
				}
				return this._EntityBatchesCache;
			}
			set
			{
				this.GetOrCreatePoco().EntityBatches = value;
				this._EntityBatchesInited = false;
			}
		}

		// Token: 0x040019EC RID: 6636
		[Nullable(2)]
		protected new IRandomBatchRefresh FbInstance;

		// Token: 0x040019ED RID: 6637
		[Nullable(2)]
		protected new IRandomBatchRefresh_SetValue PocoInterface;

		// Token: 0x040019EE RID: 6638
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x040019EF RID: 6639
		private bool _EntityBatchesInited;
	}
}
