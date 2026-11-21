using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007AA RID: 1962
	public class IStateChangeBehavior
	{
		// Token: 0x060029DD RID: 10717 RVA: 0x0006E778 File Offset: 0x0006C978
		private IStateChangeBehavior_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateChangeBehavior 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateChangeBehavior_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateChangeBehavior_SetValue());
			}
			return result;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x0006E7B0 File Offset: 0x0006C9B0
		public static IStateChangeBehavior Create([Nullable(2)] IStateChangeBehavior instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateChangeBehavior
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x0006E7C3 File Offset: 0x0006C9C3
		public static IStateChangeBehavior CreateFromSetValue([Nullable(2)] IStateChangeBehavior_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateChangeBehavior
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x0006E7D8 File Offset: 0x0006C9D8
		public IStateChangeBehavior_SetValue ToSetValue()
		{
			return new IStateChangeBehavior_SetValue
			{
				State = this.State,
				Action = this.Action,
				DelayChangeState = this.DelayChangeState,
				PendingConditionAvailable = this.PendingConditionAvailable,
				ConditionAction = this.ConditionAction
			};
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0006E826 File Offset: 0x0006CA26
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0006E851 File Offset: 0x0006CA51
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0006E860 File Offset: 0x0006CA60
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x0006E8F3 File Offset: 0x0006CAF3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Action
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ActionInited)
				{
					return this._ActionCache;
				}
				this._ActionInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> action = this.FbInstance.Action;
					if (action != null)
					{
						this._ActionCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(action.Count);
						for (int i = 0; i < action.Count; i++)
						{
							this._ActionCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(action[i]));
						}
					}
				}
				else
				{
					IStateChangeBehavior_SetValue pocoInterface = this.PocoInterface;
					this._ActionCache = ((pocoInterface != null) ? pocoInterface.Action : null);
				}
				return this._ActionCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Action = value;
				this._ActionInited = false;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0006E908 File Offset: 0x0006CB08
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x0006E969 File Offset: 0x0006CB69
		[Nullable(2)]
		public virtual IDelayChangeState DelayChangeState
		{
			[NullableContext(2)]
			get
			{
				if (this._DelayChangeStateInited)
				{
					return this._DelayChangeStateCache;
				}
				this._DelayChangeStateInited = true;
				if (this.FbInstance != null)
				{
					this._DelayChangeStateCache = IDelayChangeState.Create(this.FbInstance.DelayChangeState);
				}
				else
				{
					IStateChangeBehavior_SetValue pocoInterface = this.PocoInterface;
					this._DelayChangeStateCache = ((pocoInterface != null) ? pocoInterface.DelayChangeState : null);
				}
				return this._DelayChangeStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DelayChangeState = value;
				this._DelayChangeStateInited = false;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0006E980 File Offset: 0x0006CB80
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0006E9BA File Offset: 0x0006CBBA
		public virtual bool? PendingConditionAvailable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PendingConditionAvailable;
				}
				IStateChangeBehavior_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PendingConditionAvailable;
			}
			set
			{
				this.GetOrCreatePoco().PendingConditionAvailable = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x0006E9C8 File Offset: 0x0006CBC8
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x0006EA5B File Offset: 0x0006CC5B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IConditionAction> ConditionAction
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ConditionActionInited)
				{
					return this._ConditionActionCache;
				}
				this._ConditionActionInited = true;
				if (this.FbInstance != null)
				{
					List<IConditionAction> conditionAction = this.FbInstance.ConditionAction;
					if (conditionAction != null)
					{
						this._ConditionActionCache = new List<IConditionAction>(conditionAction.Count);
						for (int i = 0; i < conditionAction.Count; i++)
						{
							this._ConditionActionCache.Add(IConditionAction.Create(conditionAction[i]));
						}
					}
				}
				else
				{
					IStateChangeBehavior_SetValue pocoInterface = this.PocoInterface;
					this._ConditionActionCache = ((pocoInterface != null) ? pocoInterface.ConditionAction : null);
				}
				return this._ConditionActionCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().ConditionAction = value;
				this._ConditionActionInited = false;
			}
		}

		// Token: 0x04001C36 RID: 7222
		[Nullable(2)]
		protected IStateChangeBehavior FbInstance;

		// Token: 0x04001C37 RID: 7223
		[Nullable(2)]
		protected IStateChangeBehavior_SetValue PocoInterface;

		// Token: 0x04001C38 RID: 7224
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionCache;

		// Token: 0x04001C39 RID: 7225
		private bool _ActionInited;

		// Token: 0x04001C3A RID: 7226
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04001C3B RID: 7227
		private bool _DelayChangeStateInited;

		// Token: 0x04001C3C RID: 7228
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IConditionAction> _ConditionActionCache;

		// Token: 0x04001C3D RID: 7229
		private bool _ConditionActionInited;
	}
}
