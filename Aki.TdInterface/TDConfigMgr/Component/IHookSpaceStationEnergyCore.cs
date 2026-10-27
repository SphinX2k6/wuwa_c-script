using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000446 RID: 1094
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookSpaceStationEnergyCore : IHookInteractType
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x0004475C File Offset: 0x0004295C
		private IHookSpaceStationEnergyCore_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookSpaceStationEnergyCore 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookSpaceStationEnergyCore_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookSpaceStationEnergyCore_SetValue());
			}
			return result;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00044794 File Offset: 0x00042994
		public static IHookSpaceStationEnergyCore Create([Nullable(2)] IHookSpaceStationEnergyCore instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookSpaceStationEnergyCore
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000447A7 File Offset: 0x000429A7
		public static IHookSpaceStationEnergyCore CreateFromSetValue([Nullable(2)] IHookSpaceStationEnergyCore_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookSpaceStationEnergyCore
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000447BC File Offset: 0x000429BC
		public new IHookSpaceStationEnergyCore_SetValue ToSetValue()
		{
			return new IHookSpaceStationEnergyCore_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				HookSpeed = this.HookSpeed
			};
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00044816 File Offset: 0x00042A16
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00044841 File Offset: 0x00042A41
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00044850 File Offset: 0x00042A50
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x000448E3 File Offset: 0x00042AE3
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x000448F8 File Offset: 0x00042AF8
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x0004498B File Offset: 0x00042B8B
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x000449A0 File Offset: 0x00042BA0
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00044A33 File Offset: 0x00042C33
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00044A48 File Offset: 0x00042C48
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x00044AA9 File Offset: 0x00042CA9
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00044AC0 File Offset: 0x00042CC0
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00044AFA File Offset: 0x00042CFA
		public virtual int? HookSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HookSpeed;
				}
				IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HookSpeed;
			}
			set
			{
				this.GetOrCreatePoco().HookSpeed = value;
			}
		}

		// Token: 0x040010E9 RID: 4329
		[Nullable(2)]
		protected new IHookSpaceStationEnergyCore FbInstance;

		// Token: 0x040010EA RID: 4330
		[Nullable(2)]
		protected new IHookSpaceStationEnergyCore_SetValue PocoInterface;

		// Token: 0x040010EB RID: 4331
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040010EC RID: 4332
		private bool _HookActionsInited;

		// Token: 0x040010ED RID: 4333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040010EE RID: 4334
		private bool _ExitHookActionsInited;

		// Token: 0x040010EF RID: 4335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040010F0 RID: 4336
		private bool _FinishActionsInited;

		// Token: 0x040010F1 RID: 4337
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040010F2 RID: 4338
		private bool _ClientHookActionConfigInited;
	}
}
