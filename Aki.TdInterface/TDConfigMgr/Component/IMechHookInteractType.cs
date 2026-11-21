using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200054D RID: 1357
	public class IMechHookInteractType
	{
		// Token: 0x06001B72 RID: 7026 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		private IMechHookInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechHookInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechHookInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechHookInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0004FF30 File Offset: 0x0004E130
		public static IMechHookInteractType Create([Nullable(2)] IMechHookInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0004FF43 File Offset: 0x0004E143
		public static IMechHookInteractType CreateFromSetValue([Nullable(2)] IMechHookInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechHookInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0004FF58 File Offset: 0x0004E158
		public IMechHookInteractType_SetValue ToSetValue()
		{
			return new IMechHookInteractType_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0004FFA6 File Offset: 0x0004E1A6
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0004FFD1 File Offset: 0x0004E1D1
		public virtual EMechHookInteractType Type
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

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0004FFE0 File Offset: 0x0004E1E0
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x00050073 File Offset: 0x0004E273
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
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
					IMechHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00050088 File Offset: 0x0004E288
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0005011B File Offset: 0x0004E31B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
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
					IMechHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00050130 File Offset: 0x0004E330
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x000501C3 File Offset: 0x0004E3C3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
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
					IMechHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000501D8 File Offset: 0x0004E3D8
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x00050239 File Offset: 0x0004E439
		[Nullable(2)]
		public virtual IClientHookActionConfig ClientHookActionConfig
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
					IMechHookInteractType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400140D RID: 5133
		[Nullable(2)]
		protected IMechHookInteractType FbInstance;

		// Token: 0x0400140E RID: 5134
		[Nullable(2)]
		protected IMechHookInteractType_SetValue PocoInterface;

		// Token: 0x0400140F RID: 5135
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001410 RID: 5136
		private bool _HookActionsInited;

		// Token: 0x04001411 RID: 5137
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001412 RID: 5138
		private bool _ExitHookActionsInited;

		// Token: 0x04001413 RID: 5139
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001414 RID: 5140
		private bool _FinishActionsInited;

		// Token: 0x04001415 RID: 5141
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001416 RID: 5142
		private bool _ClientHookActionConfigInited;
	}
}
