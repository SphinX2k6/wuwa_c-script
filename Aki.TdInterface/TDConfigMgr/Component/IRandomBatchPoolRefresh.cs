using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E7 RID: 1767
	public class IRandomBatchPoolRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06002578 RID: 9592 RVA: 0x0006597C File Offset: 0x00063B7C
		private IRandomBatchPoolRefresh_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRandomBatchPoolRefresh 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRandomBatchPoolRefresh_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRandomBatchPoolRefresh_SetValue());
			}
			return result;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000659B4 File Offset: 0x00063BB4
		public static IRandomBatchPoolRefresh Create([Nullable(2)] IRandomBatchPoolRefresh instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomBatchPoolRefresh
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000659C7 File Offset: 0x00063BC7
		public static IRandomBatchPoolRefresh CreateFromSetValue([Nullable(2)] IRandomBatchPoolRefresh_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRandomBatchPoolRefresh
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000659DA File Offset: 0x00063BDA
		public new IRandomBatchPoolRefresh_SetValue ToSetValue()
		{
			return new IRandomBatchPoolRefresh_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches,
				IsRestartAfterAllBatchesFinished = this.IsRestartAfterAllBatchesFinished
			};
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x00065A05 File Offset: 0x00063C05
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x00065A30 File Offset: 0x00063C30
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

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x00065A40 File Offset: 0x00063C40
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00065AD3 File Offset: 0x00063CD3
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
					IRandomBatchPoolRefresh_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x00065AE8 File Offset: 0x00063CE8
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00065B22 File Offset: 0x00063D22
		public virtual bool? IsRestartAfterAllBatchesFinished
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRestartAfterAllBatchesFinished;
				}
				IRandomBatchPoolRefresh_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040019E5 RID: 6629
		[Nullable(2)]
		protected new IRandomBatchPoolRefresh FbInstance;

		// Token: 0x040019E6 RID: 6630
		[Nullable(2)]
		protected new IRandomBatchPoolRefresh_SetValue PocoInterface;

		// Token: 0x040019E7 RID: 6631
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x040019E8 RID: 6632
		private bool _EntityBatchesInited;
	}
}
