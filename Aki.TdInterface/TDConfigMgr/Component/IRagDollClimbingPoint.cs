using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E3 RID: 1763
	public class IRagDollClimbingPoint : IHookInteractType
	{
		// Token: 0x06002556 RID: 9558 RVA: 0x00065258 File Offset: 0x00063458
		private IRagDollClimbingPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRagDollClimbingPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRagDollClimbingPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRagDollClimbingPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00065290 File Offset: 0x00063490
		public static IRagDollClimbingPoint Create([Nullable(2)] IRagDollClimbingPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollClimbingPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000652A3 File Offset: 0x000634A3
		public static IRagDollClimbingPoint CreateFromSetValue([Nullable(2)] IRagDollClimbingPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRagDollClimbingPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000652B8 File Offset: 0x000634B8
		public new IRagDollClimbingPoint_SetValue ToSetValue()
		{
			return new IRagDollClimbingPoint_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				IsSummitPoint = this.IsSummitPoint
			};
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x00065312 File Offset: 0x00063512
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x0006533D File Offset: 0x0006353D
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x0006534C File Offset: 0x0006354C
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x000653DF File Offset: 0x000635DF
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000653F4 File Offset: 0x000635F4
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00065487 File Offset: 0x00063687
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x0006549C File Offset: 0x0006369C
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x0006552F File Offset: 0x0006372F
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x00065544 File Offset: 0x00063744
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x000655A5 File Offset: 0x000637A5
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000655BC File Offset: 0x000637BC
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x000655F6 File Offset: 0x000637F6
		public virtual bool? IsSummitPoint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSummitPoint;
				}
				IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSummitPoint;
			}
			set
			{
				this.GetOrCreatePoco().IsSummitPoint = value;
			}
		}

		// Token: 0x040019C6 RID: 6598
		[Nullable(2)]
		protected new IRagDollClimbingPoint FbInstance;

		// Token: 0x040019C7 RID: 6599
		[Nullable(2)]
		protected new IRagDollClimbingPoint_SetValue PocoInterface;

		// Token: 0x040019C8 RID: 6600
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040019C9 RID: 6601
		private bool _HookActionsInited;

		// Token: 0x040019CA RID: 6602
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040019CB RID: 6603
		private bool _ExitHookActionsInited;

		// Token: 0x040019CC RID: 6604
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040019CD RID: 6605
		private bool _FinishActionsInited;

		// Token: 0x040019CE RID: 6606
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040019CF RID: 6607
		private bool _ClientHookActionConfigInited;
	}
}
