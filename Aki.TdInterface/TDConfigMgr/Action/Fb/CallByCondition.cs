using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002604 RID: 9732
	[NullableContext(1)]
	[Nullable(0)]
	public class CallByCondition : ActionParams
	{
		// Token: 0x0600DA99 RID: 55961 RVA: 0x00209189 File Offset: 0x00207389
		public static CallByCondition Create(ICallByCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CallByCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x002091A8 File Offset: 0x002073A8
		public virtual IConditions Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				this._ConditionsCache = IConditions.Create(this.Instance.Conditions);
				return this._ConditionsCache;
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x002091DC File Offset: 0x002073DC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> TrueActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._TrueActionsInited)
				{
					return this._TrueActionsCache;
				}
				this._TrueActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int trueActionsLength = this.Instance.TrueActionsLength;
				this._TrueActionsCache = new List<ActionInfo>(trueActionsLength);
				for (int i = 0; i < trueActionsLength; i++)
				{
					this._TrueActionsCache.Add(ActionInfo.Create(this.Instance.TrueActions(i)));
				}
				return this._TrueActionsCache;
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x0600DA9C RID: 55964 RVA: 0x00209258 File Offset: 0x00207458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> FalseActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._FalseActionsInited)
				{
					return this._FalseActionsCache;
				}
				this._FalseActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int falseActionsLength = this.Instance.FalseActionsLength;
				this._FalseActionsCache = new List<ActionInfo>(falseActionsLength);
				for (int i = 0; i < falseActionsLength; i++)
				{
					this._FalseActionsCache.Add(ActionInfo.Create(this.Instance.FalseActions(i)));
				}
				return this._FalseActionsCache;
			}
		}

		// Token: 0x04007968 RID: 31080
		private ICallByCondition Instance;

		// Token: 0x04007969 RID: 31081
		[Nullable(2)]
		private IConditions _ConditionsCache;

		// Token: 0x0400796A RID: 31082
		private bool _ConditionsInited;

		// Token: 0x0400796B RID: 31083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _TrueActionsCache;

		// Token: 0x0400796C RID: 31084
		private bool _TrueActionsInited;

		// Token: 0x0400796D RID: 31085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FalseActionsCache;

		// Token: 0x0400796E RID: 31086
		private bool _FalseActionsInited;
	}
}
