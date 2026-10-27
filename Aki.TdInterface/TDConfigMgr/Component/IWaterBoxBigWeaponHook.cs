using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007CB RID: 1995
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaterBoxBigWeaponHook : IHookInteractType
	{
		// Token: 0x06002B3B RID: 11067 RVA: 0x00070C8C File Offset: 0x0006EE8C
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

		// Token: 0x06002B3C RID: 11068 RVA: 0x00070CC4 File Offset: 0x0006EEC4
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

		// Token: 0x06002B3D RID: 11069 RVA: 0x00070CD7 File Offset: 0x0006EED7
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

		// Token: 0x06002B3E RID: 11070 RVA: 0x00070CEC File Offset: 0x0006EEEC
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

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x00070D3A File Offset: 0x0006EF3A
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x00070D65 File Offset: 0x0006EF65
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

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x00070D74 File Offset: 0x0006EF74
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x00070E07 File Offset: 0x0006F007
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x00070E1C File Offset: 0x0006F01C
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x00070EAF File Offset: 0x0006F0AF
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x00070EC4 File Offset: 0x0006F0C4
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x00070F57 File Offset: 0x0006F157
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
					IWaterBoxBigWeaponHook_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x00070F6C File Offset: 0x0006F16C
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x00070FCD File Offset: 0x0006F1CD
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

		// Token: 0x04001CB2 RID: 7346
		[Nullable(2)]
		protected new IWaterBoxBigWeaponHook FbInstance;

		// Token: 0x04001CB3 RID: 7347
		[Nullable(2)]
		protected new IWaterBoxBigWeaponHook_SetValue PocoInterface;

		// Token: 0x04001CB4 RID: 7348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001CB5 RID: 7349
		private bool _HookActionsInited;

		// Token: 0x04001CB6 RID: 7350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001CB7 RID: 7351
		private bool _ExitHookActionsInited;

		// Token: 0x04001CB8 RID: 7352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001CB9 RID: 7353
		private bool _FinishActionsInited;

		// Token: 0x04001CBA RID: 7354
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001CBB RID: 7355
		private bool _ClientHookActionConfigInited;
	}
}
