using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096D RID: 2413
	public class TrampleUe5Component : IComponentBase
	{
		// Token: 0x060035FF RID: 13823 RVA: 0x00089830 File Offset: 0x00087A30
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

		// Token: 0x06003600 RID: 13824 RVA: 0x00089868 File Offset: 0x00087A68
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

		// Token: 0x06003601 RID: 13825 RVA: 0x0008987B File Offset: 0x00087A7B
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

		// Token: 0x06003602 RID: 13826 RVA: 0x00089890 File Offset: 0x00087A90
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

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x000898E0 File Offset: 0x00087AE0
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x0008991A File Offset: 0x00087B1A
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

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x00089928 File Offset: 0x00087B28
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x00089952 File Offset: 0x00087B52
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

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x00089960 File Offset: 0x00087B60
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x0008998B File Offset: 0x00087B8B
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

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x0008999C File Offset: 0x00087B9C
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x00089A2F File Offset: 0x00087C2F
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

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x00089A44 File Offset: 0x00087C44
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x00089AD7 File Offset: 0x00087CD7
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

		// Token: 0x04002365 RID: 9061
		[Nullable(2)]
		protected new TrampleUe5Component FbInstance;

		// Token: 0x04002366 RID: 9062
		[Nullable(2)]
		protected new TrampleUe5Component_SetValue PocoInterface;

		// Token: 0x04002367 RID: 9063
		private List<Aki.TDConfigMgr.Action.ActionInfo> _TriggerActionsCache;

		// Token: 0x04002368 RID: 9064
		private bool _TriggerActionsInited;

		// Token: 0x04002369 RID: 9065
		private List<Aki.TDConfigMgr.Action.ActionInfo> _RecoveryActionsCache;

		// Token: 0x0400236A RID: 9066
		private bool _RecoveryActionsInited;
	}
}
