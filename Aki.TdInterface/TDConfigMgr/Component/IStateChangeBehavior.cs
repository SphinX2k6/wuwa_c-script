using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000709 RID: 1801
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateChangeBehavior
	{
		// Token: 0x060026BD RID: 9917 RVA: 0x00067708 File Offset: 0x00065908
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

		// Token: 0x060026BE RID: 9918 RVA: 0x00067740 File Offset: 0x00065940
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

		// Token: 0x060026BF RID: 9919 RVA: 0x00067753 File Offset: 0x00065953
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

		// Token: 0x060026C0 RID: 9920 RVA: 0x00067768 File Offset: 0x00065968
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

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000677B6 File Offset: 0x000659B6
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x000677E1 File Offset: 0x000659E1
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

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000677F0 File Offset: 0x000659F0
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00067883 File Offset: 0x00065A83
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Action
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().Action = value;
				this._ActionInited = false;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x00067898 File Offset: 0x00065A98
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x000678F9 File Offset: 0x00065AF9
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

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x00067910 File Offset: 0x00065B10
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x0006794A File Offset: 0x00065B4A
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

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x00067958 File Offset: 0x00065B58
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x000679EB File Offset: 0x00065BEB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IConditionAction> ConditionAction
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().ConditionAction = value;
				this._ConditionActionInited = false;
			}
		}

		// Token: 0x04001A37 RID: 6711
		[Nullable(2)]
		protected IStateChangeBehavior FbInstance;

		// Token: 0x04001A38 RID: 6712
		[Nullable(2)]
		protected IStateChangeBehavior_SetValue PocoInterface;

		// Token: 0x04001A39 RID: 6713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionCache;

		// Token: 0x04001A3A RID: 6714
		private bool _ActionInited;

		// Token: 0x04001A3B RID: 6715
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04001A3C RID: 6716
		private bool _DelayChangeStateInited;

		// Token: 0x04001A3D RID: 6717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IConditionAction> _ConditionActionCache;

		// Token: 0x04001A3E RID: 6718
		private bool _ConditionActionInited;
	}
}
