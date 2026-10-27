using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006BE RID: 1726
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06002518 RID: 9496 RVA: 0x0006422C File Offset: 0x0006242C
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

		// Token: 0x06002519 RID: 9497 RVA: 0x00064264 File Offset: 0x00062464
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

		// Token: 0x0600251A RID: 9498 RVA: 0x00064277 File Offset: 0x00062477
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

		// Token: 0x0600251B RID: 9499 RVA: 0x0006428A File Offset: 0x0006248A
		public new ISequenceBatchRefresh_SetValue ToSetValue()
		{
			return new ISequenceBatchRefresh_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches,
				IsRestartAfterAllBatchesFinished = this.IsRestartAfterAllBatchesFinished
			};
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000642B5 File Offset: 0x000624B5
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x000642E0 File Offset: 0x000624E0
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

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x000642F0 File Offset: 0x000624F0
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00064383 File Offset: 0x00062583
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x00064398 File Offset: 0x00062598
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x000643D2 File Offset: 0x000625D2
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

		// Token: 0x04001962 RID: 6498
		[Nullable(2)]
		protected new ISequenceBatchRefresh FbInstance;

		// Token: 0x04001963 RID: 6499
		[Nullable(2)]
		protected new ISequenceBatchRefresh_SetValue PocoInterface;

		// Token: 0x04001964 RID: 6500
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04001965 RID: 6501
		private bool _EntityBatchesInited;
	}
}
