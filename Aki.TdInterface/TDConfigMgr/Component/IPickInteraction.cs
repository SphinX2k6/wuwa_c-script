using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005FC RID: 1532
	[NullableContext(1)]
	[Nullable(0)]
	public class IPickInteraction
	{
		// Token: 0x06002094 RID: 8340 RVA: 0x0005A994 File Offset: 0x00058B94
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

		// Token: 0x06002095 RID: 8341 RVA: 0x0005A9CC File Offset: 0x00058BCC
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

		// Token: 0x06002096 RID: 8342 RVA: 0x0005A9DF File Offset: 0x00058BDF
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

		// Token: 0x06002097 RID: 8343 RVA: 0x0005A9F2 File Offset: 0x00058BF2
		public IPickInteraction_SetValue ToSetValue()
		{
			return new IPickInteraction_SetValue
			{
				Type = this.Type,
				CheckedActions = this.CheckedActions,
				UncheckedActions = this.UncheckedActions
			};
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x0005AA1D File Offset: 0x00058C1D
		// (set) Token: 0x06002099 RID: 8345 RVA: 0x0005AA48 File Offset: 0x00058C48
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x0005AA58 File Offset: 0x00058C58
		// (set) Token: 0x0600209B RID: 8347 RVA: 0x0005AAEB File Offset: 0x00058CEB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> CheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().CheckedActions = value;
				this._CheckedActionsInited = false;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0005AB00 File Offset: 0x00058D00
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x0005AB93 File Offset: 0x00058D93
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> UncheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().UncheckedActions = value;
				this._UncheckedActionsInited = false;
			}
		}

		// Token: 0x040016D5 RID: 5845
		[Nullable(2)]
		protected IPickInteraction FbInstance;

		// Token: 0x040016D6 RID: 5846
		[Nullable(2)]
		protected IPickInteraction_SetValue PocoInterface;

		// Token: 0x040016D7 RID: 5847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _CheckedActionsCache;

		// Token: 0x040016D8 RID: 5848
		private bool _CheckedActionsInited;

		// Token: 0x040016D9 RID: 5849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _UncheckedActionsCache;

		// Token: 0x040016DA RID: 5850
		private bool _UncheckedActionsInited;
	}
}
