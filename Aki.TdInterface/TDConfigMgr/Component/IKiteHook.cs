using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000505 RID: 1285
	[NullableContext(2)]
	[Nullable(0)]
	public class IKiteHook : IHookInteractType
	{
		// Token: 0x060019BA RID: 6586 RVA: 0x0004C3B8 File Offset: 0x0004A5B8
		[NullableContext(0)]
		private IKiteHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKiteHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKiteHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKiteHook_SetValue());
			}
			return result;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0004C3F0 File Offset: 0x0004A5F0
		[NullableContext(0)]
		public static IKiteHook Create([Nullable(2)] IKiteHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKiteHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0004C403 File Offset: 0x0004A603
		[NullableContext(0)]
		public static IKiteHook CreateFromSetValue([Nullable(2)] IKiteHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKiteHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0004C418 File Offset: 0x0004A618
		[NullableContext(0)]
		public new IKiteHook_SetValue ToSetValue()
		{
			return new IKiteHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				HookDataAssetOverride = this.HookDataAssetOverride,
				SupportSwitchHookMidway = this.SupportSwitchHookMidway
			};
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0004C47E File Offset: 0x0004A67E
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0004C4A9 File Offset: 0x0004A6A9
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

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0004C4B8 File Offset: 0x0004A6B8
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0004C54B File Offset: 0x0004A74B
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0004C560 File Offset: 0x0004A760
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0004C5F3 File Offset: 0x0004A7F3
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0004C608 File Offset: 0x0004A808
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0004C69B File Offset: 0x0004A89B
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0004C711 File Offset: 0x0004A911
		public override IClientHookActionConfig ClientHookActionConfig
		{
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
					IKiteHook_SetValue pocoInterface = this.PocoInterface;
					this._ClientHookActionConfigCache = ((pocoInterface != null) ? pocoInterface.ClientHookActionConfig : null);
				}
				return this._ClientHookActionConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ClientHookActionConfig = value;
				this._ClientHookActionConfigInited = false;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0004C726 File Offset: 0x0004A926
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0004C74D File Offset: 0x0004A94D
		public virtual string HookDataAssetOverride
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookDataAssetOverride;
				}
				IKiteHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HookDataAssetOverride;
			}
			set
			{
				this.GetOrCreatePoco().HookDataAssetOverride = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0004C75C File Offset: 0x0004A95C
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0004C796 File Offset: 0x0004A996
		public virtual bool? SupportSwitchHookMidway
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SupportSwitchHookMidway;
				}
				IKiteHook_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SupportSwitchHookMidway;
			}
			set
			{
				this.GetOrCreatePoco().SupportSwitchHookMidway = value;
			}
		}

		// Token: 0x04001311 RID: 4881
		protected new IKiteHook FbInstance;

		// Token: 0x04001312 RID: 4882
		protected new IKiteHook_SetValue PocoInterface;

		// Token: 0x04001313 RID: 4883
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001314 RID: 4884
		private bool _HookActionsInited;

		// Token: 0x04001315 RID: 4885
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001316 RID: 4886
		private bool _ExitHookActionsInited;

		// Token: 0x04001317 RID: 4887
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001318 RID: 4888
		private bool _FinishActionsInited;

		// Token: 0x04001319 RID: 4889
		[Nullable(0)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x0400131A RID: 4890
		private bool _ClientHookActionConfigInited;
	}
}
