using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000699 RID: 1689
	public class IPickInteraction
	{
		// Token: 0x0600239A RID: 9114 RVA: 0x000616A8 File Offset: 0x0005F8A8
		private IPickInteraction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPickInteraction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPickInteraction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPickInteraction_SetValue());
			}
			return result;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000616E0 File Offset: 0x0005F8E0
		public static IPickInteraction Create([Nullable(2)] IPickInteraction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPickInteraction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000616F3 File Offset: 0x0005F8F3
		public static IPickInteraction CreateFromSetValue([Nullable(2)] IPickInteraction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPickInteraction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00061706 File Offset: 0x0005F906
		public IPickInteraction_SetValue ToSetValue()
		{
			return new IPickInteraction_SetValue
			{
				Type = this.Type,
				CheckedActions = this.CheckedActions,
				UncheckedActions = this.UncheckedActions
			};
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x00061731 File Offset: 0x0005F931
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x0006175C File Offset: 0x0005F95C
		public virtual EPickInteraction Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPickInteraction.ChessmanInteract;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x0006176C File Offset: 0x0005F96C
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x000617FF File Offset: 0x0005F9FF
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> CheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._CheckedActionsInited)
				{
					return this._CheckedActionsCache;
				}
				this._CheckedActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> checkedActions = this.FbInstance.CheckedActions;
					if (checkedActions != null)
					{
						this._CheckedActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(checkedActions.Count);
						for (int i = 0; i < checkedActions.Count; i++)
						{
							this._CheckedActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(checkedActions[i]));
						}
					}
				}
				else
				{
					IPickInteraction_SetValue pocoInterface = this.PocoInterface;
					this._CheckedActionsCache = ((pocoInterface != null) ? pocoInterface.CheckedActions : null);
				}
				return this._CheckedActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().CheckedActions = value;
				this._CheckedActionsInited = false;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x00061814 File Offset: 0x0005FA14
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x000618A7 File Offset: 0x0005FAA7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> UncheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._UncheckedActionsInited)
				{
					return this._UncheckedActionsCache;
				}
				this._UncheckedActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> uncheckedActions = this.FbInstance.UncheckedActions;
					if (uncheckedActions != null)
					{
						this._UncheckedActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(uncheckedActions.Count);
						for (int i = 0; i < uncheckedActions.Count; i++)
						{
							this._UncheckedActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(uncheckedActions[i]));
						}
					}
				}
				else
				{
					IPickInteraction_SetValue pocoInterface = this.PocoInterface;
					this._UncheckedActionsCache = ((pocoInterface != null) ? pocoInterface.UncheckedActions : null);
				}
				return this._UncheckedActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().UncheckedActions = value;
				this._UncheckedActionsInited = false;
			}
		}

		// Token: 0x040018C7 RID: 6343
		[Nullable(2)]
		protected IPickInteraction FbInstance;

		// Token: 0x040018C8 RID: 6344
		[Nullable(2)]
		protected IPickInteraction_SetValue PocoInterface;

		// Token: 0x040018C9 RID: 6345
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _CheckedActionsCache;

		// Token: 0x040018CA RID: 6346
		private bool _CheckedActionsInited;

		// Token: 0x040018CB RID: 6347
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _UncheckedActionsCache;

		// Token: 0x040018CC RID: 6348
		private bool _UncheckedActionsInited;
	}
}
