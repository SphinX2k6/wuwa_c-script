using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200064C RID: 1612
	[NullableContext(1)]
	[Nullable(0)]
	public class IRandomBatchRefresh : IEntityBatchRefreshMode
	{
		// Token: 0x0600227E RID: 8830 RVA: 0x0005EE2C File Offset: 0x0005D02C
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

		// Token: 0x0600227F RID: 8831 RVA: 0x0005EE64 File Offset: 0x0005D064
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

		// Token: 0x06002280 RID: 8832 RVA: 0x0005EE77 File Offset: 0x0005D077
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

		// Token: 0x06002281 RID: 8833 RVA: 0x0005EE8A File Offset: 0x0005D08A
		public new IRandomBatchRefresh_SetValue ToSetValue()
		{
			return new IRandomBatchRefresh_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches
			};
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x0005EEA9 File Offset: 0x0005D0A9
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x0005EED4 File Offset: 0x0005D0D4
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x0005EEE4 File Offset: 0x0005D0E4
		// (set) Token: 0x06002285 RID: 8837 RVA: 0x0005EF77 File Offset: 0x0005D177
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

		// Token: 0x040017FA RID: 6138
		[Nullable(2)]
		protected new IRandomBatchRefresh FbInstance;

		// Token: 0x040017FB RID: 6139
		[Nullable(2)]
		protected new IRandomBatchRefresh_SetValue PocoInterface;

		// Token: 0x040017FC RID: 6140
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x040017FD RID: 6141
		private bool _EntityBatchesInited;
	}
}
