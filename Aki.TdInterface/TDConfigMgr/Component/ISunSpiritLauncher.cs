using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E2 RID: 2018
	public class ISunSpiritLauncher : IHookInteractType
	{
		// Token: 0x06002B31 RID: 11057 RVA: 0x00071510 File Offset: 0x0006F710
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

		// Token: 0x06002B32 RID: 11058 RVA: 0x00071548 File Offset: 0x0006F748
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

		// Token: 0x06002B33 RID: 11059 RVA: 0x0007155B File Offset: 0x0006F75B
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

		// Token: 0x06002B34 RID: 11060 RVA: 0x00071570 File Offset: 0x0006F770
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

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000715BE File Offset: 0x0006F7BE
		// (set) Token: 0x06002B36 RID: 11062 RVA: 0x000715E9 File Offset: 0x0006F7E9
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

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000715F8 File Offset: 0x0006F7F8
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x0007168B File Offset: 0x0006F88B
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000716A0 File Offset: 0x0006F8A0
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x00071733 File Offset: 0x0006F933
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x00071748 File Offset: 0x0006F948
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x000717DB File Offset: 0x0006F9DB
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
					ISunSpiritLauncher_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000717F0 File Offset: 0x0006F9F0
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x00071851 File Offset: 0x0006FA51
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

		// Token: 0x04001CFA RID: 7418
		[Nullable(2)]
		protected new ISunSpiritLauncher FbInstance;

		// Token: 0x04001CFB RID: 7419
		[Nullable(2)]
		protected new ISunSpiritLauncher_SetValue PocoInterface;

		// Token: 0x04001CFC RID: 7420
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001CFD RID: 7421
		private bool _HookActionsInited;

		// Token: 0x04001CFE RID: 7422
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001CFF RID: 7423
		private bool _ExitHookActionsInited;

		// Token: 0x04001D00 RID: 7424
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001D01 RID: 7425
		private bool _FinishActionsInited;

		// Token: 0x04001D02 RID: 7426
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001D03 RID: 7427
		private bool _ClientHookActionConfigInited;
	}
}
