using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001254 RID: 4692
	public class ISavePoint : ISaveConfigType
	{
		// Token: 0x0600690F RID: 26895 RVA: 0x000FB484 File Offset: 0x000F9684
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

		// Token: 0x06006910 RID: 26896 RVA: 0x000FB4BC File Offset: 0x000F96BC
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

		// Token: 0x06006911 RID: 26897 RVA: 0x000FB4CF File Offset: 0x000F96CF
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

		// Token: 0x06006912 RID: 26898 RVA: 0x000FB4E2 File Offset: 0x000F96E2
		public new ISavePoint_SetValue ToSetValue()
		{
			return new ISavePoint_SetValue
			{
				Type = this.Type,
				RelinkRollback = this.RelinkRollback,
				PosRollbackCfg = this.PosRollbackCfg
			};
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06006913 RID: 26899 RVA: 0x000FB50D File Offset: 0x000F970D
		// (set) Token: 0x06006914 RID: 26900 RVA: 0x000FB538 File Offset: 0x000F9738
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

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x06006915 RID: 26901 RVA: 0x000FB548 File Offset: 0x000F9748
		// (set) Token: 0x06006916 RID: 26902 RVA: 0x000FB582 File Offset: 0x000F9782
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

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x000FB590 File Offset: 0x000F9790
		// (set) Token: 0x06006918 RID: 26904 RVA: 0x000FB5F1 File Offset: 0x000F97F1
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

		// Token: 0x04003EB4 RID: 16052
		[Nullable(2)]
		protected new ISavePoint FbInstance;

		// Token: 0x04003EB5 RID: 16053
		[Nullable(2)]
		protected new ISavePoint_SetValue PocoInterface;

		// Token: 0x04003EB6 RID: 16054
		private IPositionRollbackConfig _PosRollbackCfgCache;

		// Token: 0x04003EB7 RID: 16055
		private bool _PosRollbackCfgInited;
	}
}
