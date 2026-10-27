using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001126 RID: 4390
	[NullableContext(1)]
	[Nullable(0)]
	public class ISavePoint : ISaveConfigType
	{
		// Token: 0x06006314 RID: 25364 RVA: 0x000EE310 File Offset: 0x000EC510
		private ISavePoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISavePoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISavePoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISavePoint_SetValue());
			}
			return result;
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x000EE348 File Offset: 0x000EC548
		public static ISavePoint Create([Nullable(2)] ISavePoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISavePoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x000EE35B File Offset: 0x000EC55B
		public static ISavePoint CreateFromSetValue([Nullable(2)] ISavePoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISavePoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x000EE36E File Offset: 0x000EC56E
		public new ISavePoint_SetValue ToSetValue()
		{
			return new ISavePoint_SetValue
			{
				Type = this.Type,
				RelinkRollback = this.RelinkRollback,
				PosRollbackCfg = this.PosRollbackCfg
			};
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x000EE399 File Offset: 0x000EC599
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x000EE3C4 File Offset: 0x000EC5C4
		public override ESaveConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESaveConfig.SaveNew;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x000EE3D4 File Offset: 0x000EC5D4
		// (set) Token: 0x0600631B RID: 25371 RVA: 0x000EE40E File Offset: 0x000EC60E
		public virtual bool? RelinkRollback
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelinkRollback;
				}
				ISavePoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RelinkRollback;
			}
			set
			{
				this.GetOrCreatePoco().RelinkRollback = value;
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600631C RID: 25372 RVA: 0x000EE41C File Offset: 0x000EC61C
		// (set) Token: 0x0600631D RID: 25373 RVA: 0x000EE47D File Offset: 0x000EC67D
		[Nullable(2)]
		public virtual IPositionRollbackConfig PosRollbackCfg
		{
			[NullableContext(2)]
			get
			{
				if (this._PosRollbackCfgInited)
				{
					return this._PosRollbackCfgCache;
				}
				this._PosRollbackCfgInited = true;
				if (this.FbInstance != null)
				{
					this._PosRollbackCfgCache = IPositionRollbackConfig.Create(this.FbInstance.PosRollbackCfg);
				}
				else
				{
					ISavePoint_SetValue pocoInterface = this.PocoInterface;
					this._PosRollbackCfgCache = ((pocoInterface != null) ? pocoInterface.PosRollbackCfg : null);
				}
				return this._PosRollbackCfgCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PosRollbackCfg = value;
				this._PosRollbackCfgInited = false;
			}
		}

		// Token: 0x04003B66 RID: 15206
		[Nullable(2)]
		protected new ISavePoint FbInstance;

		// Token: 0x04003B67 RID: 15207
		[Nullable(2)]
		protected new ISavePoint_SetValue PocoInterface;

		// Token: 0x04003B68 RID: 15208
		private IPositionRollbackConfig _PosRollbackCfgCache;

		// Token: 0x04003B69 RID: 15209
		private bool _PosRollbackCfgInited;
	}
}
