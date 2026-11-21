using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200049F RID: 1183
	public class IHookSpaceStationEnergyCore : IHookInteractType
	{
		// Token: 0x060017AD RID: 6061 RVA: 0x000484A4 File Offset: 0x000466A4
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

		// Token: 0x060017AE RID: 6062 RVA: 0x000484DC File Offset: 0x000466DC
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

		// Token: 0x060017AF RID: 6063 RVA: 0x000484EF File Offset: 0x000466EF
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

		// Token: 0x060017B0 RID: 6064 RVA: 0x00048504 File Offset: 0x00046704
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

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0004855E File Offset: 0x0004675E
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x00048589 File Offset: 0x00046789
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00048598 File Offset: 0x00046798
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x0004862B File Offset: 0x0004682B
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00048640 File Offset: 0x00046840
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x000486D3 File Offset: 0x000468D3
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x000486E8 File Offset: 0x000468E8
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x0004877B File Offset: 0x0004697B
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
					IHookSpaceStationEnergyCore_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00048790 File Offset: 0x00046990
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x000487F1 File Offset: 0x000469F1
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

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00048808 File Offset: 0x00046A08
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00048842 File Offset: 0x00046A42
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

		// Token: 0x0400120B RID: 4619
		[Nullable(2)]
		protected new IHookSpaceStationEnergyCore FbInstance;

		// Token: 0x0400120C RID: 4620
		[Nullable(2)]
		protected new IHookSpaceStationEnergyCore_SetValue PocoInterface;

		// Token: 0x0400120D RID: 4621
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x0400120E RID: 4622
		private bool _HookActionsInited;

		// Token: 0x0400120F RID: 4623
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001210 RID: 4624
		private bool _ExitHookActionsInited;

		// Token: 0x04001211 RID: 4625
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001212 RID: 4626
		private bool _FinishActionsInited;

		// Token: 0x04001213 RID: 4627
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001214 RID: 4628
		private bool _ClientHookActionConfigInited;
	}
}
