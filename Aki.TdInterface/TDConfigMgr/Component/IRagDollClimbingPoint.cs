using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000646 RID: 1606
	[NullableContext(1)]
	[Nullable(0)]
	public class IRagDollClimbingPoint : IHookInteractType
	{
		// Token: 0x06002250 RID: 8784 RVA: 0x0005E544 File Offset: 0x0005C744
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

		// Token: 0x06002251 RID: 8785 RVA: 0x0005E57C File Offset: 0x0005C77C
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

		// Token: 0x06002252 RID: 8786 RVA: 0x0005E58F File Offset: 0x0005C78F
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

		// Token: 0x06002253 RID: 8787 RVA: 0x0005E5A4 File Offset: 0x0005C7A4
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

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x0005E5FE File Offset: 0x0005C7FE
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x0005E629 File Offset: 0x0005C829
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

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x0005E638 File Offset: 0x0005C838
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x0005E6CB File Offset: 0x0005C8CB
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x0005E773 File Offset: 0x0005C973
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0005E788 File Offset: 0x0005C988
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x0005E81B File Offset: 0x0005CA1B
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
					IRagDollClimbingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x0005E830 File Offset: 0x0005CA30
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0005E891 File Offset: 0x0005CA91
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

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x0005E8A8 File Offset: 0x0005CAA8
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x0005E8E2 File Offset: 0x0005CAE2
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

		// Token: 0x040017D4 RID: 6100
		[Nullable(2)]
		protected new IRagDollClimbingPoint FbInstance;

		// Token: 0x040017D5 RID: 6101
		[Nullable(2)]
		protected new IRagDollClimbingPoint_SetValue PocoInterface;

		// Token: 0x040017D6 RID: 6102
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040017D7 RID: 6103
		private bool _HookActionsInited;

		// Token: 0x040017D8 RID: 6104
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040017D9 RID: 6105
		private bool _ExitHookActionsInited;

		// Token: 0x040017DA RID: 6106
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040017DB RID: 6107
		private bool _FinishActionsInited;

		// Token: 0x040017DC RID: 6108
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040017DD RID: 6109
		private bool _ClientHookActionConfigInited;
	}
}
