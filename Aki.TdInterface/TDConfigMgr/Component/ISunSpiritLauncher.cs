using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000741 RID: 1857
	[NullableContext(1)]
	[Nullable(0)]
	public class ISunSpiritLauncher : IHookInteractType
	{
		// Token: 0x0600280D RID: 10253 RVA: 0x0006A368 File Offset: 0x00068568
		private ISunSpiritLauncher_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISunSpiritLauncher 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISunSpiritLauncher_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISunSpiritLauncher_SetValue());
			}
			return result;
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x0006A3A0 File Offset: 0x000685A0
		public static ISunSpiritLauncher Create([Nullable(2)] ISunSpiritLauncher instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISunSpiritLauncher
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0006A3B3 File Offset: 0x000685B3
		public static ISunSpiritLauncher CreateFromSetValue([Nullable(2)] ISunSpiritLauncher_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISunSpiritLauncher
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0006A3C8 File Offset: 0x000685C8
		public new ISunSpiritLauncher_SetValue ToSetValue()
		{
			return new ISunSpiritLauncher_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x0006A416 File Offset: 0x00068616
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x0006A441 File Offset: 0x00068641
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

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x0006A450 File Offset: 0x00068650
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x0006A4E3 File Offset: 0x000686E3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
					this._HookActionsCache = ((pocoInterface != null) ? pocoInterface.HookActions : null);
				}
				return this._HookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().HookActions = value;
				this._HookActionsInited = false;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x0006A4F8 File Offset: 0x000686F8
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x0006A58B File Offset: 0x0006878B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
					this._ExitHookActionsCache = ((pocoInterface != null) ? pocoInterface.ExitHookActions : null);
				}
				return this._ExitHookActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().ExitHookActions = value;
				this._ExitHookActionsInited = false;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x0006A5A0 File Offset: 0x000687A0
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x0006A633 File Offset: 0x00068833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
					this._FinishActionsCache = ((pocoInterface != null) ? pocoInterface.FinishActions : null);
				}
				return this._FinishActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().FinishActions = value;
				this._FinishActionsInited = false;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x0006A648 File Offset: 0x00068848
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x0006A6A9 File Offset: 0x000688A9
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001AF5 RID: 6901
		[Nullable(2)]
		protected new ISunSpiritLauncher FbInstance;

		// Token: 0x04001AF6 RID: 6902
		[Nullable(2)]
		protected new ISunSpiritLauncher_SetValue PocoInterface;

		// Token: 0x04001AF7 RID: 6903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001AF8 RID: 6904
		private bool _HookActionsInited;

		// Token: 0x04001AF9 RID: 6905
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001AFA RID: 6906
		private bool _ExitHookActionsInited;

		// Token: 0x04001AFB RID: 6907
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001AFC RID: 6908
		private bool _FinishActionsInited;

		// Token: 0x04001AFD RID: 6909
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001AFE RID: 6910
		private bool _ClientHookActionConfigInited;
	}
}
