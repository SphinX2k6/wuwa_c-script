using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003EB RID: 1003
	public class IFlyingFeather : IHookInteractType
	{
		// Token: 0x060013C9 RID: 5065 RVA: 0x00040358 File Offset: 0x0003E558
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

		// Token: 0x060013CA RID: 5066 RVA: 0x00040390 File Offset: 0x0003E590
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

		// Token: 0x060013CB RID: 5067 RVA: 0x000403A3 File Offset: 0x0003E5A3
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

		// Token: 0x060013CC RID: 5068 RVA: 0x000403B8 File Offset: 0x0003E5B8
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00040412 File Offset: 0x0003E612
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x0004043D File Offset: 0x0003E63D
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0004044C File Offset: 0x0003E64C
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x000404DF File Offset: 0x0003E6DF
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000404F4 File Offset: 0x0003E6F4
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00040587 File Offset: 0x0003E787
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x0004059C File Offset: 0x0003E79C
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0004062F File Offset: 0x0003E82F
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
					IFlyingFeather_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00040644 File Offset: 0x0003E844
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x000406A5 File Offset: 0x0003E8A5
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000406BC File Offset: 0x0003E8BC
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x000406F6 File Offset: 0x0003E8F6
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

		// Token: 0x04000FDB RID: 4059
		[Nullable(2)]
		protected new IFlyingFeather FbInstance;

		// Token: 0x04000FDC RID: 4060
		[Nullable(2)]
		protected new IFlyingFeather_SetValue PocoInterface;

		// Token: 0x04000FDD RID: 4061
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04000FDE RID: 4062
		private bool _HookActionsInited;

		// Token: 0x04000FDF RID: 4063
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04000FE0 RID: 4064
		private bool _ExitHookActionsInited;

		// Token: 0x04000FE1 RID: 4065
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04000FE2 RID: 4066
		private bool _FinishActionsInited;

		// Token: 0x04000FE3 RID: 4067
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04000FE4 RID: 4068
		private bool _ClientHookActionConfigInited;
	}
}
