using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064A RID: 1610
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomBatchPoolRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x06002272 RID: 8818 RVA: 0x0005EC68 File Offset: 0x0005CE68
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

		// Token: 0x06002273 RID: 8819 RVA: 0x0005ECA0 File Offset: 0x0005CEA0
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

		// Token: 0x06002274 RID: 8820 RVA: 0x0005ECB3 File Offset: 0x0005CEB3
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

		// Token: 0x06002275 RID: 8821 RVA: 0x0005ECC6 File Offset: 0x0005CEC6
		public new IRandomBatchPoolRefresh_SetValue ToSetValue()
		{
			return new IRandomBatchPoolRefresh_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches,
				IsRestartAfterAllBatchesFinished = this.IsRestartAfterAllBatchesFinished
			};
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0005ECF1 File Offset: 0x0005CEF1
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x0005ED1C File Offset: 0x0005CF1C
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

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0005ED2C File Offset: 0x0005CF2C
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x0005EDBF File Offset: 0x0005CFBF
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x0005EDD4 File Offset: 0x0005CFD4
		// (set) Token: 0x0600227B RID: 8827 RVA: 0x0005EE0E File Offset: 0x0005D00E
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

		// Token: 0x040017F3 RID: 6131
		[Nullable(2)]
		protected new IRandomBatchPoolRefresh FbInstance;

		// Token: 0x040017F4 RID: 6132
		[Nullable(2)]
		protected new IRandomBatchPoolRefresh_SetValue PocoInterface;

		// Token: 0x040017F5 RID: 6133
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x040017F6 RID: 6134
		private bool _EntityBatchesInited;
	}
}
