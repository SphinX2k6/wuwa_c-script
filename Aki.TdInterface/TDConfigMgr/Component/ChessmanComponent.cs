using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200003C RID: 60
	[NullableContext(1)]
	[Nullable(0)]
	public class ChessmanComponent : IComponentBase
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00018A84 File Offset: 0x00016C84
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

		// Token: 0x06000215 RID: 533 RVA: 0x00018ABC File Offset: 0x00016CBC
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

		// Token: 0x06000216 RID: 534 RVA: 0x00018ACF File Offset: 0x00016CCF
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

		// Token: 0x06000217 RID: 535 RVA: 0x00018AE2 File Offset: 0x00016CE2
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00018B1C File Offset: 0x00016D1C
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00018B56 File Offset: 0x00016D56
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00018B64 File Offset: 0x00016D64
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00018B8E File Offset: 0x00016D8E
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00018B9C File Offset: 0x00016D9C
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00018C2F File Offset: 0x00016E2F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> StartMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().StartMovingActions = value;
				this._StartMovingActionsInited = false;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00018C44 File Offset: 0x00016E44
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00018CD7 File Offset: 0x00016ED7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> EndMovingActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().EndMovingActions = value;
				this._EndMovingActionsInited = false;
			}
		}

		// Token: 0x04000153 RID: 339
		[Nullable(2)]
		protected new ChessmanComponent FbInstance;

		// Token: 0x04000154 RID: 340
		[Nullable(2)]
		protected new ChessmanComponent_SetValue PocoInterface;

		// Token: 0x04000155 RID: 341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _StartMovingActionsCache;

		// Token: 0x04000156 RID: 342
		private bool _StartMovingActionsInited;

		// Token: 0x04000157 RID: 343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EndMovingActionsCache;

		// Token: 0x04000158 RID: 344
		private bool _EndMovingActionsInited;
	}
}
