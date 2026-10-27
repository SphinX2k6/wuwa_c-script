using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005B4 RID: 1460
	[NullableContext(1)]
	[Nullable(0)]
	public class IOperationsAfterEntityGroupFailure
	{
		// Token: 0x06001ED2 RID: 7890 RVA: 0x00056EE8 File Offset: 0x000550E8
		private IOperationsAfterEntityGroupFailure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOperationsAfterEntityGroupFailure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOperationsAfterEntityGroupFailure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOperationsAfterEntityGroupFailure_SetValue());
			}
			return result;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00056F20 File Offset: 0x00055120
		public static IOperationsAfterEntityGroupFailure Create([Nullable(2)] IOperationsAfterEntityGroupFailure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperationsAfterEntityGroupFailure
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00056F33 File Offset: 0x00055133
		public static IOperationsAfterEntityGroupFailure CreateFromSetValue([Nullable(2)] IOperationsAfterEntityGroupFailure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOperationsAfterEntityGroupFailure
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00056F46 File Offset: 0x00055146
		public IOperationsAfterEntityGroupFailure_SetValue ToSetValue()
		{
			return new IOperationsAfterEntityGroupFailure_SetValue
			{
				IsResetState = this.IsResetState,
				Actions = this.Actions
			};
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001ED6 RID: 7894 RVA: 0x00056F68 File Offset: 0x00055168
		// (set) Token: 0x06001ED7 RID: 7895 RVA: 0x00056FA2 File Offset: 0x000551A2
		public virtual bool? IsResetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetState;
				}
				IOperationsAfterEntityGroupFailure_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsResetState;
			}
			set
			{
				this.GetOrCreatePoco().IsResetState = value;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x00056FB0 File Offset: 0x000551B0
		// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x00057043 File Offset: 0x00055243
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
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
					IOperationsAfterEntityGroupFailure_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x040015E2 RID: 5602
		[Nullable(2)]
		protected IOperationsAfterEntityGroupFailure FbInstance;

		// Token: 0x040015E3 RID: 5603
		[Nullable(2)]
		protected IOperationsAfterEntityGroupFailure_SetValue PocoInterface;

		// Token: 0x040015E4 RID: 5604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x040015E5 RID: 5605
		private bool _ActionsInited;
	}
}
