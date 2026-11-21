using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000405 RID: 1029
	public class IFoxJumpingPoint : IHookInteractType
	{
		// Token: 0x0600145B RID: 5211 RVA: 0x00041728 File Offset: 0x0003F928
		private IFoxJumpingPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxJumpingPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxJumpingPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxJumpingPoint_SetValue());
			}
			return result;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00041760 File Offset: 0x0003F960
		public static IFoxJumpingPoint Create([Nullable(2)] IFoxJumpingPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxJumpingPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00041773 File Offset: 0x0003F973
		public static IFoxJumpingPoint CreateFromSetValue([Nullable(2)] IFoxJumpingPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxJumpingPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00041788 File Offset: 0x0003F988
		public new IFoxJumpingPoint_SetValue ToSetValue()
		{
			return new IFoxJumpingPoint_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000417D6 File Offset: 0x0003F9D6
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x00041801 File Offset: 0x0003FA01
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00041810 File Offset: 0x0003FA10
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x000418A3 File Offset: 0x0003FAA3
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x000418B8 File Offset: 0x0003FAB8
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x0004194B File Offset: 0x0003FB4B
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x00041960 File Offset: 0x0003FB60
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x000419F3 File Offset: 0x0003FBF3
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00041A08 File Offset: 0x0003FC08
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x00041A69 File Offset: 0x0003FC69
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
					IFoxJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400102F RID: 4143
		[Nullable(2)]
		protected new IFoxJumpingPoint FbInstance;

		// Token: 0x04001030 RID: 4144
		[Nullable(2)]
		protected new IFoxJumpingPoint_SetValue PocoInterface;

		// Token: 0x04001031 RID: 4145
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001032 RID: 4146
		private bool _HookActionsInited;

		// Token: 0x04001033 RID: 4147
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001034 RID: 4148
		private bool _ExitHookActionsInited;

		// Token: 0x04001035 RID: 4149
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001036 RID: 4150
		private bool _FinishActionsInited;

		// Token: 0x04001037 RID: 4151
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001038 RID: 4152
		private bool _ClientHookActionConfigInited;
	}
}
