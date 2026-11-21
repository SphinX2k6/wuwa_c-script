using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000356 RID: 854
	public class IEntityBatchRefreshMode
	{
		// Token: 0x0600105F RID: 4191 RVA: 0x00038B9C File Offset: 0x00036D9C
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

		// Token: 0x06001060 RID: 4192 RVA: 0x00038BD4 File Offset: 0x00036DD4
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

		// Token: 0x06001061 RID: 4193 RVA: 0x00038BE7 File Offset: 0x00036DE7
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

		// Token: 0x06001062 RID: 4194 RVA: 0x00038BFA File Offset: 0x00036DFA
		public IEntityBatchRefreshMode_SetValue ToSetValue()
		{
			return new IEntityBatchRefreshMode_SetValue
			{
				Type = this.Type,
				EntityBatches = this.EntityBatches
			};
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00038C19 File Offset: 0x00036E19
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00038C44 File Offset: 0x00036E44
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x00038C54 File Offset: 0x00036E54
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x00038CE7 File Offset: 0x00036EE7
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

		// Token: 0x04000E0F RID: 3599
		[Nullable(2)]
		protected IEntityBatchRefreshMode FbInstance;

		// Token: 0x04000E10 RID: 3600
		[Nullable(2)]
		protected IEntityBatchRefreshMode_SetValue PocoInterface;

		// Token: 0x04000E11 RID: 3601
		private List<IEntityListBatch> _EntityBatchesCache;

		// Token: 0x04000E12 RID: 3602
		private bool _EntityBatchesInited;
	}
}
