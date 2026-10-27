using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A2 RID: 930
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlyingFeather : IHookInteractType
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x0003D020 File Offset: 0x0003B220
		private IFlyingFeather_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlyingFeather 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlyingFeather_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlyingFeather_SetValue());
			}
			return result;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0003D058 File Offset: 0x0003B258
		public static IFlyingFeather Create([Nullable(2)] IFlyingFeather instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlyingFeather
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0003D06B File Offset: 0x0003B26B
		public static IFlyingFeather CreateFromSetValue([Nullable(2)] IFlyingFeather_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlyingFeather
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0003D080 File Offset: 0x0003B280
		public new IFlyingFeather_SetValue ToSetValue()
		{
			return new IFlyingFeather_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0003D0DA File Offset: 0x0003B2DA
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x0003D105 File Offset: 0x0003B305
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

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0003D114 File Offset: 0x0003B314
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x0003D1A7 File Offset: 0x0003B3A7
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0003D1BC File Offset: 0x0003B3BC
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x0003D24F File Offset: 0x0003B44F
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0003D264 File Offset: 0x0003B464
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x0003D2F7 File Offset: 0x0003B4F7
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0003D30C File Offset: 0x0003B50C
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x0003D36D File Offset: 0x0003B56D
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0003D384 File Offset: 0x0003B584
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x0003D3BE File Offset: 0x0003B5BE
		public virtual int? EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04000EE3 RID: 3811
		[Nullable(2)]
		protected new IFlyingFeather FbInstance;

		// Token: 0x04000EE4 RID: 3812
		[Nullable(2)]
		protected new IFlyingFeather_SetValue PocoInterface;

		// Token: 0x04000EE5 RID: 3813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000EE6 RID: 3814
		private bool _HookActionsInited;

		// Token: 0x04000EE7 RID: 3815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000EE8 RID: 3816
		private bool _ExitHookActionsInited;

		// Token: 0x04000EE9 RID: 3817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000EEA RID: 3818
		private bool _FinishActionsInited;

		// Token: 0x04000EEB RID: 3819
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000EEC RID: 3820
		private bool _ClientHookActionConfigInited;
	}
}
