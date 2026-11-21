using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200075F RID: 1887
	public class ISequenceBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06002838 RID: 10296 RVA: 0x0006B29C File Offset: 0x0006949C
		private ISequenceBatchRefresh_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISequenceBatchRefresh 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISequenceBatchRefresh_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISequenceBatchRefresh_SetValue());
			}
			return result;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0006B2D4 File Offset: 0x000694D4
		public static ISequenceBatchRefresh Create([Nullable(2)] ISequenceBatchRefresh instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceBatchRefresh
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0006B2E7 File Offset: 0x000694E7
		public static ISequenceBatchRefresh CreateFromSetValue([Nullable(2)] ISequenceBatchRefresh_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISequenceBatchRefresh
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0006B2FA File Offset: 0x000694FA
		public new ISequenceBatchRefresh_SetValue ToSetValue()
		{
			return new ISequenceBatchRefresh_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches,
				IsRestartAfterAllBatchesFinished = this.IsRestartAfterAllBatchesFinished
			};
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x0006B325 File Offset: 0x00069525
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x0006B350 File Offset: 0x00069550
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

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x0006B360 File Offset: 0x00069560
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x0006B3F3 File Offset: 0x000695F3
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
					ISequenceBatchRefresh_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x0006B408 File Offset: 0x00069608
		// (set) Token: 0x06002841 RID: 10305 RVA: 0x0006B442 File Offset: 0x00069642
		public virtual bool? IsRestartAfterAllBatchesFinished
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRestartAfterAllBatchesFinished;
				}
				ISequenceBatchRefresh_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRestartAfterAllBatchesFinished;
			}
			set
			{
				this.GetOrCreatePoco().IsRestartAfterAllBatchesFinished = value;
			}
		}

		// Token: 0x04001B61 RID: 7009
		[Nullable(2)]
		protected new ISequenceBatchRefresh FbInstance;

		// Token: 0x04001B62 RID: 7010
		[Nullable(2)]
		protected new ISequenceBatchRefresh_SetValue PocoInterface;

		// Token: 0x04001B63 RID: 7011
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04001B64 RID: 7012
		private bool _EntityBatchesInited;
	}
}
