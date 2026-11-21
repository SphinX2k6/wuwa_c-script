using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000547 RID: 1351
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechFixedPointHookInteract : IMechHookInteractType
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x0004F798 File Offset: 0x0004D998
		[NullableContext(0)]
		private IMechFixedPointHookInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechFixedPointHookInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechFixedPointHookInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechFixedPointHookInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		[NullableContext(0)]
		public static IMechFixedPointHookInteract Create([Nullable(2)] IMechFixedPointHookInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechFixedPointHookInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0004F7E3 File Offset: 0x0004D9E3
		[NullableContext(0)]
		public static IMechFixedPointHookInteract CreateFromSetValue([Nullable(2)] IMechFixedPointHookInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechFixedPointHookInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0004F7F8 File Offset: 0x0004D9F8
		[NullableContext(0)]
		public new IMechFixedPointHookInteract_SetValue ToSetValue()
		{
			return new IMechFixedPointHookInteract_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				MechBehaviorConfig = this.MechBehaviorConfig
			};
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0004F852 File Offset: 0x0004DA52
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0004F87D File Offset: 0x0004DA7D
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

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0004F88C File Offset: 0x0004DA8C
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0004F91F File Offset: 0x0004DB1F
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
					IMechFixedPointHookInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0004F934 File Offset: 0x0004DB34
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0004F9C7 File Offset: 0x0004DBC7
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
					IMechFixedPointHookInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0004F9DC File Offset: 0x0004DBDC
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0004FA6F File Offset: 0x0004DC6F
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
					IMechFixedPointHookInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0004FA84 File Offset: 0x0004DC84
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0004FAE5 File Offset: 0x0004DCE5
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
					IMechFixedPointHookInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0004FAFC File Offset: 0x0004DCFC
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0004FB5D File Offset: 0x0004DD5D
		public virtual Aki.TDConfigMgr.Action.IMechBehaviorConfig MechBehaviorConfig
		{
			get
			{
				if (this._MechBehaviorConfigInited)
				{
					return this._MechBehaviorConfigCache;
				}
				this._MechBehaviorConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MechBehaviorConfigCache = Aki.TDConfigMgr.Action.IMechBehaviorConfig.Create(this.FbInstance.MechBehaviorConfig);
				}
				else
				{
					IMechFixedPointHookInteract_SetValue pocoInterface = this.PocoInterface;
					this._MechBehaviorConfigCache = ((pocoInterface != null) ? pocoInterface.MechBehaviorConfig : null);
				}
				return this._MechBehaviorConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MechBehaviorConfig = value;
				this._MechBehaviorConfigInited = false;
			}
		}

		// Token: 0x040013EC RID: 5100
		protected new IMechFixedPointHookInteract FbInstance;

		// Token: 0x040013ED RID: 5101
		protected new IMechFixedPointHookInteract_SetValue PocoInterface;

		// Token: 0x040013EE RID: 5102
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040013EF RID: 5103
		private bool _HookActionsInited;

		// Token: 0x040013F0 RID: 5104
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040013F1 RID: 5105
		private bool _ExitHookActionsInited;

		// Token: 0x040013F2 RID: 5106
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040013F3 RID: 5107
		private bool _FinishActionsInited;

		// Token: 0x040013F4 RID: 5108
		[Nullable(0)]
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040013F5 RID: 5109
		private bool _ClientHookActionConfigInited;

		// Token: 0x040013F6 RID: 5110
		[Nullable(0)]
		private Aki.TDConfigMgr.Action.IMechBehaviorConfig _MechBehaviorConfigCache;

		// Token: 0x040013F7 RID: 5111
		private bool _MechBehaviorConfigInited;
	}
}
