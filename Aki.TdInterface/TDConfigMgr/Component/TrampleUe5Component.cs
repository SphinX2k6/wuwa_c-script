using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CA RID: 2250
	[NullableContext(1)]
	[Nullable(0)]
	public class TrampleUe5Component : IComponentBase
	{
		// Token: 0x060032C3 RID: 12995 RVA: 0x00082388 File Offset: 0x00080588
		private TrampleUe5Component_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("TrampleUe5Component 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			TrampleUe5Component_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new TrampleUe5Component_SetValue());
			}
			return result;
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000823C0 File Offset: 0x000805C0
		public static TrampleUe5Component Create([Nullable(2)] TrampleUe5Component instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TrampleUe5Component
			{
				FbInstance = instance
			};
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000823D3 File Offset: 0x000805D3
		public static TrampleUe5Component CreateFromSetValue([Nullable(2)] TrampleUe5Component_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new TrampleUe5Component
			{
				PocoInterface = value
			};
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000823E8 File Offset: 0x000805E8
		public new TrampleUe5Component_SetValue ToSetValue()
		{
			return new TrampleUe5Component_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				IsDisposable = this.IsDisposable,
				TriggerActions = this.TriggerActions,
				RecoveryActions = this.RecoveryActions
			};
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x00082438 File Offset: 0x00080638
		// (set) Token: 0x060032C8 RID: 13000 RVA: 0x00082472 File Offset: 0x00080672
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				TrampleUe5Component_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x00082480 File Offset: 0x00080680
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x000824AA File Offset: 0x000806AA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x000824B8 File Offset: 0x000806B8
		// (set) Token: 0x060032CC RID: 13004 RVA: 0x000824E3 File Offset: 0x000806E3
		public virtual bool IsDisposable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisposable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsDisposable;
			}
			set
			{
				this.GetOrCreatePoco().IsDisposable = value;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060032CD RID: 13005 RVA: 0x000824F4 File Offset: 0x000806F4
		// (set) Token: 0x060032CE RID: 13006 RVA: 0x00082587 File Offset: 0x00080787
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> TriggerActions
		{
			get
			{
				if (this._TriggerActionsInited)
				{
					return this._TriggerActionsCache;
				}
				this._TriggerActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> triggerActions = this.FbInstance.TriggerActions;
					if (triggerActions != null)
					{
						this._TriggerActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(triggerActions.Count);
						for (int i = 0; i < triggerActions.Count; i++)
						{
							this._TriggerActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(triggerActions[i]));
						}
					}
				}
				else
				{
					TrampleUe5Component_SetValue pocoInterface = this.PocoInterface;
					this._TriggerActionsCache = ((pocoInterface != null) ? pocoInterface.TriggerActions : null);
				}
				return this._TriggerActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().TriggerActions = value;
				this._TriggerActionsInited = false;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x0008259C File Offset: 0x0008079C
		// (set) Token: 0x060032D0 RID: 13008 RVA: 0x0008262F File Offset: 0x0008082F
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> RecoveryActions
		{
			get
			{
				if (this._RecoveryActionsInited)
				{
					return this._RecoveryActionsCache;
				}
				this._RecoveryActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> recoveryActions = this.FbInstance.RecoveryActions;
					if (recoveryActions != null)
					{
						this._RecoveryActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(recoveryActions.Count);
						for (int i = 0; i < recoveryActions.Count; i++)
						{
							this._RecoveryActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(recoveryActions[i]));
						}
					}
				}
				else
				{
					TrampleUe5Component_SetValue pocoInterface = this.PocoInterface;
					this._RecoveryActionsCache = ((pocoInterface != null) ? pocoInterface.RecoveryActions : null);
				}
				return this._RecoveryActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().RecoveryActions = value;
				this._RecoveryActionsInited = false;
			}
		}

		// Token: 0x04002155 RID: 8533
		[Nullable(2)]
		protected new TrampleUe5Component FbInstance;

		// Token: 0x04002156 RID: 8534
		[Nullable(2)]
		protected new TrampleUe5Component_SetValue PocoInterface;

		// Token: 0x04002157 RID: 8535
		private List<Aki.TDConfigMgr.Action.ActionInfo> _TriggerActionsCache;

		// Token: 0x04002158 RID: 8536
		private bool _TriggerActionsInited;

		// Token: 0x04002159 RID: 8537
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RecoveryActionsCache;

		// Token: 0x0400215A RID: 8538
		private bool _RecoveryActionsInited;
	}
}
