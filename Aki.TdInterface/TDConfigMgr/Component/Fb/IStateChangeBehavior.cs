using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD1 RID: 2769
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateChangeBehavior
	{
		// Token: 0x06003FCA RID: 16330 RVA: 0x000A314D File Offset: 0x000A134D
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

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x000A316C File Offset: 0x000A136C
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x000A317C File Offset: 0x000A137C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> Action
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

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x000A31F6 File Offset: 0x000A13F6
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

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x000A322C File Offset: 0x000A142C
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x000A3264 File Offset: 0x000A1464
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

		// Token: 0x04002382 RID: 9090
		private IStateChangeBehavior Instance;

		// Token: 0x04002383 RID: 9091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ActionCache;

		// Token: 0x04002384 RID: 9092
		private bool _ActionInited;

		// Token: 0x04002385 RID: 9093
		[Nullable(2)]
		private IDelayChangeState _DelayChangeStateCache;

		// Token: 0x04002386 RID: 9094
		private bool _DelayChangeStateInited;

		// Token: 0x04002387 RID: 9095
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IConditionAction> _ConditionActionCache;

		// Token: 0x04002388 RID: 9096
		private bool _ConditionActionInited;
	}
}
