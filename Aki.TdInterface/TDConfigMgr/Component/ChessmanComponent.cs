using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003C RID: 60
	public class ChessmanComponent : IComponentBase
	{
		// Token: 0x06000218 RID: 536 RVA: 0x000193F8 File Offset: 0x000175F8
		private ChessmanComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChessmanComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChessmanComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChessmanComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00019430 File Offset: 0x00017630
		public static ChessmanComponent Create([Nullable(2)] ChessmanComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChessmanComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00019443 File Offset: 0x00017643
		public static ChessmanComponent CreateFromSetValue([Nullable(2)] ChessmanComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChessmanComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00019456 File Offset: 0x00017656
		public new ChessmanComponent_SetValue ToSetValue()
		{
			return new ChessmanComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				StartMovingActions = this.StartMovingActions,
				EndMovingActions = this.EndMovingActions
			};
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00019490 File Offset: 0x00017690
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000194CA File Offset: 0x000176CA
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ChessmanComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000194D8 File Offset: 0x000176D8
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00019502 File Offset: 0x00017702
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00019510 File Offset: 0x00017710
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000195A3 File Offset: 0x000177A3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> StartMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._StartMovingActionsInited)
				{
					return this._StartMovingActionsCache;
				}
				this._StartMovingActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> startMovingActions = this.FbInstance.StartMovingActions;
					if (startMovingActions != null)
					{
						this._StartMovingActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(startMovingActions.Count);
						for (int i = 0; i < startMovingActions.Count; i++)
						{
							this._StartMovingActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(startMovingActions[i]));
						}
					}
				}
				else
				{
					ChessmanComponent_SetValue pocoInterface = this.PocoInterface;
					this._StartMovingActionsCache = ((pocoInterface != null) ? pocoInterface.StartMovingActions : null);
				}
				return this._StartMovingActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().StartMovingActions = value;
				this._StartMovingActionsInited = false;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000195B8 File Offset: 0x000177B8
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0001964B File Offset: 0x0001784B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> EndMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._EndMovingActionsInited)
				{
					return this._EndMovingActionsCache;
				}
				this._EndMovingActionsInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> endMovingActions = this.FbInstance.EndMovingActions;
					if (endMovingActions != null)
					{
						this._EndMovingActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(endMovingActions.Count);
						for (int i = 0; i < endMovingActions.Count; i++)
						{
							this._EndMovingActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(endMovingActions[i]));
						}
					}
				}
				else
				{
					ChessmanComponent_SetValue pocoInterface = this.PocoInterface;
					this._EndMovingActionsCache = ((pocoInterface != null) ? pocoInterface.EndMovingActions : null);
				}
				return this._EndMovingActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().EndMovingActions = value;
				this._EndMovingActionsInited = false;
			}
		}

		// Token: 0x04000158 RID: 344
		[Nullable(2)]
		protected new ChessmanComponent FbInstance;

		// Token: 0x04000159 RID: 345
		[Nullable(2)]
		protected new ChessmanComponent_SetValue PocoInterface;

		// Token: 0x0400015A RID: 346
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _StartMovingActionsCache;

		// Token: 0x0400015B RID: 347
		private bool _StartMovingActionsInited;

		// Token: 0x0400015C RID: 348
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EndMovingActionsCache;

		// Token: 0x0400015D RID: 349
		private bool _EndMovingActionsInited;
	}
}
