using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F0 RID: 1264
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechPullInteract : IHookInteractType
	{
		// Token: 0x060019B0 RID: 6576 RVA: 0x0004BA84 File Offset: 0x00049C84
		private IMechPullInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechPullInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechPullInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechPullInteract_SetValue());
			}
			return result;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0004BABC File Offset: 0x00049CBC
		public static IMechPullInteract Create([Nullable(2)] IMechPullInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechPullInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0004BACF File Offset: 0x00049CCF
		public static IMechPullInteract CreateFromSetValue([Nullable(2)] IMechPullInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechPullInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		public new IMechPullInteract_SetValue ToSetValue()
		{
			return new IMechPullInteract_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				IsPlayPullProgress = this.IsPlayPullProgress,
				PullMoveSpeed = this.PullMoveSpeed,
				IsFixedWhenNotMech = this.IsFixedWhenNotMech,
				DisableAreaEffect = this.DisableAreaEffect,
				DisableCollectEffect = this.DisableCollectEffect
			};
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x0004BB6E File Offset: 0x00049D6E
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0004BB99 File Offset: 0x00049D99
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

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0004BBA8 File Offset: 0x00049DA8
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x0004BC3B File Offset: 0x00049E3B
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
					IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0004BC50 File Offset: 0x00049E50
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x0004BCE3 File Offset: 0x00049EE3
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
					IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x0004BCF8 File Offset: 0x00049EF8
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x0004BD8B File Offset: 0x00049F8B
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
					IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x0004BDA0 File Offset: 0x00049FA0
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x0004BE01 File Offset: 0x0004A001
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
					IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x0004BE18 File Offset: 0x0004A018
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x0004BE52 File Offset: 0x0004A052
		public virtual bool? IsPlayPullProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayPullProgress;
				}
				IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsPlayPullProgress;
			}
			set
			{
				this.GetOrCreatePoco().IsPlayPullProgress = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0004BE60 File Offset: 0x0004A060
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0004BE9A File Offset: 0x0004A09A
		public virtual float? PullMoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PullMoveSpeed;
				}
				IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PullMoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().PullMoveSpeed = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0004BEA8 File Offset: 0x0004A0A8
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0004BEE2 File Offset: 0x0004A0E2
		public virtual bool? IsFixedWhenNotMech
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFixedWhenNotMech;
				}
				IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFixedWhenNotMech;
			}
			set
			{
				this.GetOrCreatePoco().IsFixedWhenNotMech = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0004BEF0 File Offset: 0x0004A0F0
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0004BF2A File Offset: 0x0004A12A
		public virtual bool? DisableAreaEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAreaEffect;
				}
				IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAreaEffect;
			}
			set
			{
				this.GetOrCreatePoco().DisableAreaEffect = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0004BF38 File Offset: 0x0004A138
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0004BF72 File Offset: 0x0004A172
		public virtual bool? DisableCollectEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableCollectEffect;
				}
				IMechPullInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableCollectEffect;
			}
			set
			{
				this.GetOrCreatePoco().DisableCollectEffect = value;
			}
		}

		// Token: 0x040012CB RID: 4811
		[Nullable(2)]
		protected new IMechPullInteract FbInstance;

		// Token: 0x040012CC RID: 4812
		[Nullable(2)]
		protected new IMechPullInteract_SetValue PocoInterface;

		// Token: 0x040012CD RID: 4813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040012CE RID: 4814
		private bool _HookActionsInited;

		// Token: 0x040012CF RID: 4815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040012D0 RID: 4816
		private bool _ExitHookActionsInited;

		// Token: 0x040012D1 RID: 4817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040012D2 RID: 4818
		private bool _FinishActionsInited;

		// Token: 0x040012D3 RID: 4819
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040012D4 RID: 4820
		private bool _ClientHookActionConfigInited;
	}
}
