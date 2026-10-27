using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E2 RID: 1506
	[NullableContext(1)]
	[Nullable(0)]
	public class IPatrolAction
	{
		// Token: 0x06001FEA RID: 8170 RVA: 0x0005928C File Offset: 0x0005748C
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

		// Token: 0x06001FEB RID: 8171 RVA: 0x000592C4 File Offset: 0x000574C4
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

		// Token: 0x06001FEC RID: 8172 RVA: 0x000592D7 File Offset: 0x000574D7
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

		// Token: 0x06001FED RID: 8173 RVA: 0x000592EA File Offset: 0x000574EA
		public IPatrolAction_SetValue ToSetValue()
		{
			return new IPatrolAction_SetValue
			{
				Point = this.Point,
				Actions = this.Actions
			};
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00059309 File Offset: 0x00057509
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x00059334 File Offset: 0x00057534
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

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x00059344 File Offset: 0x00057544
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x000593D7 File Offset: 0x000575D7
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

		// Token: 0x04001673 RID: 5747
		[Nullable(2)]
		protected IPatrolAction FbInstance;

		// Token: 0x04001674 RID: 5748
		[Nullable(2)]
		protected IPatrolAction_SetValue PocoInterface;

		// Token: 0x04001675 RID: 5749
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001676 RID: 5750
		private bool _ActionsInited;
	}
}
