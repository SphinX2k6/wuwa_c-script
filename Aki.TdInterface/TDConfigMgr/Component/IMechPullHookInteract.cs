using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054F RID: 1359
	public class IMechPullHookInteract : IMechHookInteractType
	{
		// Token: 0x06001B82 RID: 7042 RVA: 0x00050260 File Offset: 0x0004E460
		private IMechPullHookInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechPullHookInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechPullHookInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechPullHookInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00050298 File Offset: 0x0004E498
		public static IMechPullHookInteract Create([Nullable(2)] IMechPullHookInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechPullHookInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000502AB File Offset: 0x0004E4AB
		public static IMechPullHookInteract CreateFromSetValue([Nullable(2)] IMechPullHookInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechPullHookInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000502C0 File Offset: 0x0004E4C0
		public new IMechPullHookInteract_SetValue ToSetValue()
		{
			return new IMechPullHookInteract_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				IsPlayPullProgress = this.IsPlayPullProgress,
				PullMoveSpeed = this.PullMoveSpeed,
				IsFixedWhenNotMech = this.IsFixedWhenNotMech,
				DisableAreaEffect = this.DisableAreaEffect,
				DisableCollectEffect = this.DisableCollectEffect
			};
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0005034A File Offset: 0x0004E54A
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x00050375 File Offset: 0x0004E575
		public override EMechHookInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechHookInteractType.FixedPointHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00050384 File Offset: 0x0004E584
		// (set) Token: 0x06001B89 RID: 7049 RVA: 0x00050417 File Offset: 0x0004E617
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._HookActionsInited)
				{
					return this._HookActionsCache;
				}
				this._HookActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> hookActions = this.FbInstance.HookActions;
					if (hookActions != null)
					{
						this._HookActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(hookActions.Count);
						for (int i = 0; i < hookActions.Count; i++)
						{
							this._HookActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(hookActions[i]));
						}
					}
				}
				else
				{
					IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
					this._HookActionsCache = ((pocoInterface != null) ? pocoInterface.HookActions : null);
				}
				return this._HookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().HookActions = value;
				this._HookActionsInited = false;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0005042C File Offset: 0x0004E62C
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x000504BF File Offset: 0x0004E6BF
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExitHookActionsInited)
				{
					return this._ExitHookActionsCache;
				}
				this._ExitHookActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> exitHookActions = this.FbInstance.ExitHookActions;
					if (exitHookActions != null)
					{
						this._ExitHookActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(exitHookActions.Count);
						for (int i = 0; i < exitHookActions.Count; i++)
						{
							this._ExitHookActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(exitHookActions[i]));
						}
					}
				}
				else
				{
					IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
					this._ExitHookActionsCache = ((pocoInterface != null) ? pocoInterface.ExitHookActions : null);
				}
				return this._ExitHookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ExitHookActions = value;
				this._ExitHookActionsInited = false;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x000504D4 File Offset: 0x0004E6D4
		// (set) Token: 0x06001B8D RID: 7053 RVA: 0x00050567 File Offset: 0x0004E767
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FinishActionsInited)
				{
					return this._FinishActionsCache;
				}
				this._FinishActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> finishActions = this.FbInstance.FinishActions;
					if (finishActions != null)
					{
						this._FinishActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(finishActions.Count);
						for (int i = 0; i < finishActions.Count; i++)
						{
							this._FinishActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(finishActions[i]));
						}
					}
				}
				else
				{
					IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
					this._FinishActionsCache = ((pocoInterface != null) ? pocoInterface.FinishActions : null);
				}
				return this._FinishActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().FinishActions = value;
				this._FinishActionsInited = false;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0005057C File Offset: 0x0004E77C
		// (set) Token: 0x06001B8F RID: 7055 RVA: 0x000505DD File Offset: 0x0004E7DD
		[Nullable(2)]
		public override IClientHookActionConfig ClientHookActionConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._ClientHookActionConfigInited)
				{
					return this._ClientHookActionConfigCache;
				}
				this._ClientHookActionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ClientHookActionConfigCache = IClientHookActionConfig.Create(this.FbInstance.ClientHookActionConfig);
				}
				else
				{
					IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
					this._ClientHookActionConfigCache = ((pocoInterface != null) ? pocoInterface.ClientHookActionConfig : null);
				}
				return this._ClientHookActionConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ClientHookActionConfig = value;
				this._ClientHookActionConfigInited = false;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x000505F4 File Offset: 0x0004E7F4
		// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0005062E File Offset: 0x0004E82E
		public virtual bool? IsPlayPullProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayPullProgress;
				}
				IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPlayPullProgress;
			}
			set
			{
				this.GetOrCreatePoco().IsPlayPullProgress = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0005063C File Offset: 0x0004E83C
		// (set) Token: 0x06001B93 RID: 7059 RVA: 0x00050676 File Offset: 0x0004E876
		public virtual float? PullMoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PullMoveSpeed;
				}
				IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PullMoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PullMoveSpeed = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00050684 File Offset: 0x0004E884
		// (set) Token: 0x06001B95 RID: 7061 RVA: 0x000506BE File Offset: 0x0004E8BE
		public virtual bool? IsFixedWhenNotMech
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFixedWhenNotMech;
				}
				IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFixedWhenNotMech;
			}
			set
			{
				this.GetOrCreatePoco().IsFixedWhenNotMech = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x000506CC File Offset: 0x0004E8CC
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x00050706 File Offset: 0x0004E906
		public virtual bool? DisableAreaEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAreaEffect;
				}
				IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAreaEffect;
			}
			set
			{
				this.GetOrCreatePoco().DisableAreaEffect = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00050714 File Offset: 0x0004E914
		// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0005074E File Offset: 0x0004E94E
		public virtual bool? DisableCollectEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableCollectEffect;
				}
				IMechPullHookInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableCollectEffect;
			}
			set
			{
				this.GetOrCreatePoco().DisableCollectEffect = value;
			}
		}

		// Token: 0x0400141C RID: 5148
		[Nullable(2)]
		protected new IMechPullHookInteract FbInstance;

		// Token: 0x0400141D RID: 5149
		[Nullable(2)]
		protected new IMechPullHookInteract_SetValue PocoInterface;

		// Token: 0x0400141E RID: 5150
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x0400141F RID: 5151
		private bool _HookActionsInited;

		// Token: 0x04001420 RID: 5152
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001421 RID: 5153
		private bool _ExitHookActionsInited;

		// Token: 0x04001422 RID: 5154
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001423 RID: 5155
		private bool _FinishActionsInited;

		// Token: 0x04001424 RID: 5156
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001425 RID: 5157
		private bool _ClientHookActionConfigInited;
	}
}
