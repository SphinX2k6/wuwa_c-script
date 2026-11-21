using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E5 RID: 1765
	public class IRagDollJumpingPoint : IHookInteractType
	{
		// Token: 0x06002568 RID: 9576 RVA: 0x00065614 File Offset: 0x00063814
		private IRagDollJumpingPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRagDollJumpingPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRagDollJumpingPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRagDollJumpingPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0006564C File Offset: 0x0006384C
		public static IRagDollJumpingPoint Create([Nullable(2)] IRagDollJumpingPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRagDollJumpingPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0006565F File Offset: 0x0006385F
		public static IRagDollJumpingPoint CreateFromSetValue([Nullable(2)] IRagDollJumpingPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRagDollJumpingPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00065674 File Offset: 0x00063874
		public new IRagDollJumpingPoint_SetValue ToSetValue()
		{
			return new IRagDollJumpingPoint_SetValue
			{
				Type = this.Type,
				HookActions = this.HookActions,
				ExitHookActions = this.ExitHookActions,
				FinishActions = this.FinishActions,
				ClientHookActionConfig = this.ClientHookActionConfig
			};
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000656C2 File Offset: 0x000638C2
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x000656ED File Offset: 0x000638ED
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000656FC File Offset: 0x000638FC
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x0006578F File Offset: 0x0006398F
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000657A4 File Offset: 0x000639A4
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x00065837 File Offset: 0x00063A37
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0006584C File Offset: 0x00063A4C
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x000658DF File Offset: 0x00063ADF
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000658F4 File Offset: 0x00063AF4
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x00065955 File Offset: 0x00063B55
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
					IRagDollJumpingPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040019D6 RID: 6614
		[Nullable(2)]
		protected new IRagDollJumpingPoint FbInstance;

		// Token: 0x040019D7 RID: 6615
		[Nullable(2)]
		protected new IRagDollJumpingPoint_SetValue PocoInterface;

		// Token: 0x040019D8 RID: 6616
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _HookActionsCache;

		// Token: 0x040019D9 RID: 6617
		private bool _HookActionsInited;

		// Token: 0x040019DA RID: 6618
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitHookActionsCache;

		// Token: 0x040019DB RID: 6619
		private bool _ExitHookActionsInited;

		// Token: 0x040019DC RID: 6620
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _FinishActionsCache;

		// Token: 0x040019DD RID: 6621
		private bool _FinishActionsInited;

		// Token: 0x040019DE RID: 6622
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040019DF RID: 6623
		private bool _ClientHookActionConfigInited;
	}
}
