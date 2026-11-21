using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000262 RID: 610
	public class IChessmanPickInteraction : IPickInteraction
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x0002C3FC File Offset: 0x0002A5FC
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

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002C434 File Offset: 0x0002A634
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

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002C447 File Offset: 0x0002A647
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

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002C45C File Offset: 0x0002A65C
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002C4AA File Offset: 0x0002A6AA
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0002C4D5 File Offset: 0x0002A6D5
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002C4E4 File Offset: 0x0002A6E4
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0002C577 File Offset: 0x0002A777
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> CheckedActions
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
					IChessmanPickInteraction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002C58C File Offset: 0x0002A78C
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0002C61F File Offset: 0x0002A81F
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<Aki.TDConfigMgr.Action.ActionInfo> UncheckedActions
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
					IChessmanPickInteraction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002C634 File Offset: 0x0002A834
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x0002C65F File Offset: 0x0002A85F
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002C66D File Offset: 0x0002A86D
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0002C694 File Offset: 0x0002A894
		[Nullable(2)]
		public virtual string AvailablePosEffect
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AvailablePosEffect = value;
			}
		}

		// Token: 0x04000AC4 RID: 2756
		[Nullable(2)]
		protected new IChessmanPickInteraction FbInstance;

		// Token: 0x04000AC5 RID: 2757
		[Nullable(2)]
		protected new IChessmanPickInteraction_SetValue PocoInterface;

		// Token: 0x04000AC6 RID: 2758
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _CheckedActionsCache;

		// Token: 0x04000AC7 RID: 2759
		private bool _CheckedActionsInited;

		// Token: 0x04000AC8 RID: 2760
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _UncheckedActionsCache;

		// Token: 0x04000AC9 RID: 2761
		private bool _UncheckedActionsInited;
	}
}
