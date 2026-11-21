using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000595 RID: 1429
	public class IMotorPullInteract : IHookInteractType
	{
		// Token: 0x06001CF0 RID: 7408 RVA: 0x00052FA4 File Offset: 0x000511A4
		private IMotorPullInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorPullInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorPullInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorPullInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00052FDC File Offset: 0x000511DC
		public static IMotorPullInteract Create([Nullable(2)] IMotorPullInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorPullInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00052FEF File Offset: 0x000511EF
		public static IMotorPullInteract CreateFromSetValue([Nullable(2)] IMotorPullInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorPullInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00053004 File Offset: 0x00051204
		public new IMotorPullInteract_SetValue ToSetValue()
		{
			return new IMotorPullInteract_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig,
				IsPlayPullProgress = this.IsPlayPullProgress,
				PullMoveSpeed = this.PullMoveSpeed,
				IsFixedWhenNotRide = this.IsFixedWhenNotRide,
				DisableAreaEffect = this.DisableAreaEffect,
				DisableCollectEffect = this.DisableCollectEffect
			};
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0005308E File Offset: 0x0005128E
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x000530B9 File Offset: 0x000512B9
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

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000530C8 File Offset: 0x000512C8
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0005315B File Offset: 0x0005135B
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00053170 File Offset: 0x00051370
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x00053203 File Offset: 0x00051403
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00053218 File Offset: 0x00051418
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x000532AB File Offset: 0x000514AB
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x000532C0 File Offset: 0x000514C0
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00053321 File Offset: 0x00051521
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00053338 File Offset: 0x00051538
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x00053372 File Offset: 0x00051572
		public virtual bool? IsPlayPullProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPlayPullProgress;
				}
				IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00053380 File Offset: 0x00051580
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x000533BA File Offset: 0x000515BA
		public virtual float? PullMoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PullMoveSpeed;
				}
				IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000533C8 File Offset: 0x000515C8
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00053402 File Offset: 0x00051602
		public virtual bool? IsFixedWhenNotRide
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFixedWhenNotRide;
				}
				IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFixedWhenNotRide;
			}
			set
			{
				this.GetOrCreatePoco().IsFixedWhenNotRide = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00053410 File Offset: 0x00051610
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0005344A File Offset: 0x0005164A
		public virtual bool? DisableAreaEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAreaEffect;
				}
				IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00053458 File Offset: 0x00051658
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x00053492 File Offset: 0x00051692
		public virtual bool? DisableCollectEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableCollectEffect;
				}
				IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040014DA RID: 5338
		[Nullable(2)]
		protected new IMotorPullInteract FbInstance;

		// Token: 0x040014DB RID: 5339
		[Nullable(2)]
		protected new IMotorPullInteract_SetValue PocoInterface;

		// Token: 0x040014DC RID: 5340
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040014DD RID: 5341
		private bool _HookActionsInited;

		// Token: 0x040014DE RID: 5342
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040014DF RID: 5343
		private bool _ExitHookActionsInited;

		// Token: 0x040014E0 RID: 5344
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040014E1 RID: 5345
		private bool _FinishActionsInited;

		// Token: 0x040014E2 RID: 5346
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040014E3 RID: 5347
		private bool _ClientHookActionConfigInited;
	}
}
