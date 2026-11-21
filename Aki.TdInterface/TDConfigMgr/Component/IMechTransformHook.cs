using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000551 RID: 1361
	public class IMechTransformHook : IHookInteractType
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x0005076C File Offset: 0x0004E96C
		private IMechTransformHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechTransformHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechTransformHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechTransformHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000507A4 File Offset: 0x0004E9A4
		public static IMechTransformHook Create([Nullable(2)] IMechTransformHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechTransformHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000507B7 File Offset: 0x0004E9B7
		public static IMechTransformHook CreateFromSetValue([Nullable(2)] IMechTransformHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechTransformHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000507CC File Offset: 0x0004E9CC
		public new IMechTransformHook_SetValue ToSetValue()
		{
			return new IMechTransformHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0005081A File Offset: 0x0004EA1A
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00050845 File Offset: 0x0004EA45
		public override EHookInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHookInteractType.FixedPointHook;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00050854 File Offset: 0x0004EA54
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x000508E7 File Offset: 0x0004EAE7
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
					IMechTransformHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000508FC File Offset: 0x0004EAFC
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0005098F File Offset: 0x0004EB8F
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
					IMechTransformHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x000509A4 File Offset: 0x0004EBA4
		// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00050A37 File Offset: 0x0004EC37
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
					IMechTransformHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00050A4C File Offset: 0x0004EC4C
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00050AAD File Offset: 0x0004ECAD
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
					IMechTransformHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001430 RID: 5168
		[Nullable(2)]
		protected new IMechTransformHook FbInstance;

		// Token: 0x04001431 RID: 5169
		[Nullable(2)]
		protected new IMechTransformHook_SetValue PocoInterface;

		// Token: 0x04001432 RID: 5170
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001433 RID: 5171
		private bool _HookActionsInited;

		// Token: 0x04001434 RID: 5172
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001435 RID: 5173
		private bool _ExitHookActionsInited;

		// Token: 0x04001436 RID: 5174
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001437 RID: 5175
		private bool _FinishActionsInited;

		// Token: 0x04001438 RID: 5176
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001439 RID: 5177
		private bool _ClientHookActionConfigInited;
	}
}
