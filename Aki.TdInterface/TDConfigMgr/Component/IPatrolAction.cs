using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000673 RID: 1651
	public class IPatrolAction
	{
		// Token: 0x060022B6 RID: 8886 RVA: 0x0005F918 File Offset: 0x0005DB18
		private IPatrolAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolAction_SetValue());
			}
			return result;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0005F950 File Offset: 0x0005DB50
		public static IPatrolAction Create([Nullable(2)] IPatrolAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0005F963 File Offset: 0x0005DB63
		public static IPatrolAction CreateFromSetValue([Nullable(2)] IPatrolAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0005F976 File Offset: 0x0005DB76
		public IPatrolAction_SetValue ToSetValue()
		{
			return new IPatrolAction_SetValue
			{
				Point = this.Point,
				Actions = this.Actions
			};
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0005F995 File Offset: 0x0005DB95
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0005F9C0 File Offset: 0x0005DBC0
		public virtual int Point
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Point;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Point;
			}
			set
			{
				this.GetOrCreatePoco().Point = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x0005F9D0 File Offset: 0x0005DBD0
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x0005FA63 File Offset: 0x0005DC63
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IPatrolAction_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x0400184A RID: 6218
		[Nullable(2)]
		protected IPatrolAction FbInstance;

		// Token: 0x0400184B RID: 6219
		[Nullable(2)]
		protected IPatrolAction_SetValue PocoInterface;

		// Token: 0x0400184C RID: 6220
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x0400184D RID: 6221
		private bool _ActionsInited;
	}
}
