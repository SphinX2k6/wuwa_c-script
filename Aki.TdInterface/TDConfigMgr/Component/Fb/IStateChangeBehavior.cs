using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B9B RID: 2971
	public class IStateChangeBehavior
	{
		// Token: 0x060043F4 RID: 17396 RVA: 0x000AC741 File Offset: 0x000AA941
		public static IStateChangeBehavior Create(IStateChangeBehavior? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateChangeBehavior
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x000AC760 File Offset: 0x000AA960
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x000AC770 File Offset: 0x000AA970
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> Action
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int actionLength = this.Instance.ActionLength;
				this._ActionCache = new List<ActionInfo>(actionLength);
				for (int i = 0; i < actionLength; i++)
				{
					this._ActionCache.Add(ActionInfo.Create(this.Instance.Action(i)));
				}
				return this._ActionCache;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x000AC7EA File Offset: 0x000AA9EA
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
				this._DelayChangeStateCache = IDelayChangeState.Create(this.Instance.DelayChangeState);
				return this._DelayChangeStateCache;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x000AC820 File Offset: 0x000AAA20
		public virtual bool? PendingConditionAvailable
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PendingConditionAvailable);
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x000AC858 File Offset: 0x000AAA58
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
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int conditionActionLength = this.Instance.ConditionActionLength;
				this._ConditionActionCache = new List<IConditionAction>(conditionActionLength);
				for (int i = 0; i < conditionActionLength; i++)
				{
					this._ConditionActionCache.Add(IConditionAction.Create(this.Instance.ConditionAction(i)));
				}
				return this._ConditionActionCache;
			}
		}

		// Token: 0x0400259E RID: 9630
		private IStateChangeBehavior Instance;

		// Token: 0x0400259F RID: 9631
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ActionCache;

		// Token: 0x040025A0 RID: 9632
		private bool _ActionInited;

		// Token: 0x040025A1 RID: 9633
		[Nullable(2)]
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x040025A2 RID: 9634
		private bool _DelayChangeStateInited;

		// Token: 0x040025A3 RID: 9635
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IConditionAction> _ConditionActionCache;

		// Token: 0x040025A4 RID: 9636
		private bool _ConditionActionInited;
	}
}
