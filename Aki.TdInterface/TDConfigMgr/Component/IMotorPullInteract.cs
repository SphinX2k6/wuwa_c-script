using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052E RID: 1326
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorPullInteract : IHookInteractType
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x0004E1E8 File Offset: 0x0004C3E8
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

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0004E220 File Offset: 0x0004C420
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

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0004E233 File Offset: 0x0004C433
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

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0004E248 File Offset: 0x0004C448
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0004E2D2 File Offset: 0x0004C4D2
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0004E2FD File Offset: 0x0004C4FD
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x0004E30C File Offset: 0x0004C50C
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x0004E39F File Offset: 0x0004C59F
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x0004E3B4 File Offset: 0x0004C5B4
		// (set) Token: 0x06001AFD RID: 6909 RVA: 0x0004E447 File Offset: 0x0004C647
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x0004E45C File Offset: 0x0004C65C
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x0004E4EF File Offset: 0x0004C6EF
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
					IMotorPullInteract_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x0004E504 File Offset: 0x0004C704
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x0004E565 File Offset: 0x0004C765
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0004E57C File Offset: 0x0004C77C
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x0004E5B6 File Offset: 0x0004C7B6
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

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x0004E5C4 File Offset: 0x0004C7C4
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x0004E5FE File Offset: 0x0004C7FE
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

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0004E60C File Offset: 0x0004C80C
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0004E646 File Offset: 0x0004C846
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0004E654 File Offset: 0x0004C854
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0004E68E File Offset: 0x0004C88E
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

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0004E69C File Offset: 0x0004C89C
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0004E6D6 File Offset: 0x0004C8D6
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

		// Token: 0x04001370 RID: 4976
		[Nullable(2)]
		protected new IMotorPullInteract FbInstance;

		// Token: 0x04001371 RID: 4977
		[Nullable(2)]
		protected new IMotorPullInteract_SetValue PocoInterface;

		// Token: 0x04001372 RID: 4978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x04001373 RID: 4979
		private bool _HookActionsInited;

		// Token: 0x04001374 RID: 4980
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x04001375 RID: 4981
		private bool _ExitHookActionsInited;

		// Token: 0x04001376 RID: 4982
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x04001377 RID: 4983
		private bool _FinishActionsInited;

		// Token: 0x04001378 RID: 4984
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04001379 RID: 4985
		private bool _ClientHookActionConfigInited;
	}
}
