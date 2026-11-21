using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200086E RID: 2158
	public class IWaterBoxBigWeaponHook : IHookInteractType
	{
		// Token: 0x06002E6B RID: 11883 RVA: 0x00077FF0 File Offset: 0x000761F0
		private IWaterBoxBigWeaponHook_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaterBoxBigWeaponHook 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaterBoxBigWeaponHook_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaterBoxBigWeaponHook_SetValue());
			}
			return result;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00078028 File Offset: 0x00076228
		public static IWaterBoxBigWeaponHook Create([Nullable(2)] IWaterBoxBigWeaponHook instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaterBoxBigWeaponHook
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x0007803B File Offset: 0x0007623B
		public static IWaterBoxBigWeaponHook CreateFromSetValue([Nullable(2)] IWaterBoxBigWeaponHook_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaterBoxBigWeaponHook
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00078050 File Offset: 0x00076250
		public new IWaterBoxBigWeaponHook_SetValue ToSetValue()
		{
			return new IWaterBoxBigWeaponHook_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x0007809E File Offset: 0x0007629E
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x000780C9 File Offset: 0x000762C9
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

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x000780D8 File Offset: 0x000762D8
		// (set) Token: 0x06002E72 RID: 11890 RVA: 0x0007816B File Offset: 0x0007636B
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x00078180 File Offset: 0x00076380
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x00078213 File Offset: 0x00076413
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x00078228 File Offset: 0x00076428
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x000782BB File Offset: 0x000764BB
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x000782D0 File Offset: 0x000764D0
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00078331 File Offset: 0x00076531
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001EBE RID: 7870
		[Nullable(2)]
		protected new IWaterBoxBigWeaponHook FbInstance;

		// Token: 0x04001EBF RID: 7871
		[Nullable(2)]
		protected new IWaterBoxBigWeaponHook_SetValue PocoInterface;

		// Token: 0x04001EC0 RID: 7872
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001EC1 RID: 7873
		private bool _HookActionsInited;

		// Token: 0x04001EC2 RID: 7874
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001EC3 RID: 7875
		private bool _ExitHookActionsInited;

		// Token: 0x04001EC4 RID: 7876
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001EC5 RID: 7877
		private bool _FinishActionsInited;

		// Token: 0x04001EC6 RID: 7878
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001EC7 RID: 7879
		private bool _ClientHookActionConfigInited;
	}
}
