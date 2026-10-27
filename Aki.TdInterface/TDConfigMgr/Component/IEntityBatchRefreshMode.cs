using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200030F RID: 783
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityBatchRefreshMode
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x00035C68 File Offset: 0x00033E68
		private IEntityBatchRefreshMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityBatchRefreshMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityBatchRefreshMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityBatchRefreshMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00035CA0 File Offset: 0x00033EA0
		public static IEntityBatchRefreshMode Create([Nullable(2)] IEntityBatchRefreshMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityBatchRefreshMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00035CB3 File Offset: 0x00033EB3
		public static IEntityBatchRefreshMode CreateFromSetValue([Nullable(2)] IEntityBatchRefreshMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityBatchRefreshMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00035CC6 File Offset: 0x00033EC6
		public IEntityBatchRefreshMode_SetValue ToSetValue()
		{
			return new IEntityBatchRefreshMode_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches
			};
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00035CE5 File Offset: 0x00033EE5
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00035D10 File Offset: 0x00033F10
		public virtual EEntityBatchRefreshMode Type
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00035D20 File Offset: 0x00033F20
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00035DB3 File Offset: 0x00033FB3
		public virtual List<IEntityListBatch> EntityBatches
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
					IEntityBatchRefreshMode_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04000D25 RID: 3365
		[Nullable(2)]
		protected IEntityBatchRefreshMode FbInstance;

		// Token: 0x04000D26 RID: 3366
		[Nullable(2)]
		protected IEntityBatchRefreshMode_SetValue PocoInterface;

		// Token: 0x04000D27 RID: 3367
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04000D28 RID: 3368
		private bool _EntityBatchesInited;
	}
}
