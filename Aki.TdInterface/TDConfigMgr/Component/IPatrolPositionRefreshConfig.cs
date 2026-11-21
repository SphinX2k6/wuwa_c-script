using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200067D RID: 1661
	public class IPatrolPositionRefreshConfig
	{
		// Token: 0x060022E2 RID: 8930 RVA: 0x0005FDBC File Offset: 0x0005DFBC
		private IPatrolPositionRefreshConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolPositionRefreshConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolPositionRefreshConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolPositionRefreshConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0005FDF4 File Offset: 0x0005DFF4
		public static IPatrolPositionRefreshConfig Create([Nullable(2)] IPatrolPositionRefreshConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0005FE07 File Offset: 0x0005E007
		public static IPatrolPositionRefreshConfig CreateFromSetValue([Nullable(2)] IPatrolPositionRefreshConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolPositionRefreshConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0005FE1A File Offset: 0x0005E01A
		public IPatrolPositionRefreshConfig_SetValue ToSetValue()
		{
			return new IPatrolPositionRefreshConfig_SetValue
			{
				TriggerConditions = this.TriggerConditions,
				Refresh = this.Refresh
			};
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0005FE39 File Offset: 0x0005E039
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0005FE60 File Offset: 0x0005E060
		public virtual List<IPatrolPositionRefreshTrigger> TriggerConditions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerConditions;
				}
				IPatrolPositionRefreshConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TriggerConditions;
			}
			set
			{
				this.GetOrCreatePoco().TriggerConditions = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0005FE70 File Offset: 0x0005E070
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0005FED1 File Offset: 0x0005E0D1
		public virtual IPatrolPositionRefreshAtNearestSplinePointToPlayer Refresh
		{
			get
			{
				if (this._RefreshInited)
				{
					return this._RefreshCache;
				}
				this._RefreshInited = true;
				if (this.FbInstance != null)
				{
					this._RefreshCache = IPatrolPositionRefreshAtNearestSplinePointToPlayer.Create(this.FbInstance.Refresh);
				}
				else
				{
					IPatrolPositionRefreshConfig_SetValue pocoInterface = this.PocoInterface;
					this._RefreshCache = ((pocoInterface != null) ? pocoInterface.Refresh : null);
				}
				return this._RefreshCache;
			}
			set
			{
				this.GetOrCreatePoco().Refresh = value;
				this._RefreshInited = false;
			}
		}

		// Token: 0x0400185D RID: 6237
		[Nullable(2)]
		protected IPatrolPositionRefreshConfig FbInstance;

		// Token: 0x0400185E RID: 6238
		[Nullable(2)]
		protected IPatrolPositionRefreshConfig_SetValue PocoInterface;

		// Token: 0x0400185F RID: 6239
		private IPatrolPositionRefreshAtNearestSplinePointToPlayer _RefreshCache;

		// Token: 0x04001860 RID: 6240
		private bool _RefreshInited;
	}
}
