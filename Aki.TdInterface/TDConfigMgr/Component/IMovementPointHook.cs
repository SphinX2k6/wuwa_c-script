using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200053A RID: 1338
	[NullableContext(1)]
	[Nullable(0)]
	public class IMovementPointHook : IHookInteractType
	{
		// Token: 0x06001B56 RID: 6998 RVA: 0x0004F1A8 File Offset: 0x0004D3A8
		private IMovementPointHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMovementPointHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMovementPointHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMovementPointHook_SetValue());
			}
			return result;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x0004F1E0 File Offset: 0x0004D3E0
		public static IMovementPointHook Create([Nullable(2)] IMovementPointHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMovementPointHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0004F1F3 File Offset: 0x0004D3F3
		public static IMovementPointHook CreateFromSetValue([Nullable(2)] IMovementPointHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMovementPointHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0004F208 File Offset: 0x0004D408
		public new IMovementPointHook_SetValue ToSetValue()
		{
			return new IMovementPointHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0004F256 File Offset: 0x0004D456
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0004F281 File Offset: 0x0004D481
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

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0004F290 File Offset: 0x0004D490
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0004F323 File Offset: 0x0004D523
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0004F338 File Offset: 0x0004D538
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0004F3CB File Offset: 0x0004D5CB
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0004F3E0 File Offset: 0x0004D5E0
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0004F473 File Offset: 0x0004D673
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0004F488 File Offset: 0x0004D688
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0004F4E9 File Offset: 0x0004D6E9
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
					IMovementPointHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040013B1 RID: 5041
		[Nullable(2)]
		protected new IMovementPointHook FbInstance;

		// Token: 0x040013B2 RID: 5042
		[Nullable(2)]
		protected new IMovementPointHook_SetValue PocoInterface;

		// Token: 0x040013B3 RID: 5043
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040013B4 RID: 5044
		private bool _HookActionsInited;

		// Token: 0x040013B5 RID: 5045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040013B6 RID: 5046
		private bool _ExitHookActionsInited;

		// Token: 0x040013B7 RID: 5047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040013B8 RID: 5048
		private bool _FinishActionsInited;

		// Token: 0x040013B9 RID: 5049
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040013BA RID: 5050
		private bool _ClientHookActionConfigInited;
	}
}
