using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200023B RID: 571
	[NullableContext(2)]
	[Nullable(0)]
	public class IChessmanPickInteraction : IPickInteraction
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x0002AC3C File Offset: 0x00028E3C
		[NullableContext(1)]
		private IChessmanPickInteraction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChessmanPickInteraction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChessmanPickInteraction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChessmanPickInteraction_SetValue());
			}
			return result;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002AC74 File Offset: 0x00028E74
		[NullableContext(1)]
		public static IChessmanPickInteraction Create([Nullable(2)] IChessmanPickInteraction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChessmanPickInteraction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0002AC87 File Offset: 0x00028E87
		[NullableContext(1)]
		public static IChessmanPickInteraction CreateFromSetValue([Nullable(2)] IChessmanPickInteraction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChessmanPickInteraction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002AC9C File Offset: 0x00028E9C
		[NullableContext(1)]
		public new IChessmanPickInteraction_SetValue ToSetValue()
		{
			return new IChessmanPickInteraction_SetValue
			{
				Type = this.Type,
				CheckedActions = this.CheckedActions,
				UncheckedActions = this.UncheckedActions,
				TargetChessboard = this.TargetChessboard,
				AvailablePosEffect = this.AvailablePosEffect
			};
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002ACEA File Offset: 0x00028EEA
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0002AD15 File Offset: 0x00028F15
		public override EPickInteraction Type
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002AD24 File Offset: 0x00028F24
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0002ADB7 File Offset: 0x00028FB7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> CheckedActions
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
					IChessmanPickInteraction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0002ADCC File Offset: 0x00028FCC
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0002AE5F File Offset: 0x0002905F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> UncheckedActions
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
					IChessmanPickInteraction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0002AE74 File Offset: 0x00029074
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0002AE9F File Offset: 0x0002909F
		public virtual int TargetChessboard
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetChessboard;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetChessboard;
			}
			set
			{
				this.GetOrCreatePoco().TargetChessboard = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002AEAD File Offset: 0x000290AD
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0002AED4 File Offset: 0x000290D4
		public virtual string AvailablePosEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AvailablePosEffect;
				}
				IChessmanPickInteraction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AvailablePosEffect;
			}
			set
			{
				this.GetOrCreatePoco().AvailablePosEffect = value;
			}
		}

		// Token: 0x04000A3A RID: 2618
		protected new IChessmanPickInteraction FbInstance;

		// Token: 0x04000A3B RID: 2619
		protected new IChessmanPickInteraction_SetValue PocoInterface;

		// Token: 0x04000A3C RID: 2620
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _CheckedActionsCache;

		// Token: 0x04000A3D RID: 2621
		private bool _CheckedActionsInited;

		// Token: 0x04000A3E RID: 2622
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _UncheckedActionsCache;

		// Token: 0x04000A3F RID: 2623
		private bool _UncheckedActionsInited;
	}
}
