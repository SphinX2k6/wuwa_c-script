using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C4 RID: 10436
	public class CallByCondition : ActionParams
	{
		// Token: 0x0600E866 RID: 59494 RVA: 0x002258DD File Offset: 0x00223ADD
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

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x0600E867 RID: 59495 RVA: 0x002258FC File Offset: 0x00223AFC
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

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x0600E868 RID: 59496 RVA: 0x00225930 File Offset: 0x00223B30
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> TrueActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x0600E869 RID: 59497 RVA: 0x002259AC File Offset: 0x00223BAC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> FalseActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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

		// Token: 0x04008002 RID: 32770
		private ICallByCondition Instance;

		// Token: 0x04008003 RID: 32771
		[Nullable(2)]
		private IConditions _ConditionsCache;

		// Token: 0x04008004 RID: 32772
		private bool _ConditionsInited;

		// Token: 0x04008005 RID: 32773
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _TrueActionsCache;

		// Token: 0x04008006 RID: 32774
		private bool _TrueActionsInited;

		// Token: 0x04008007 RID: 32775
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FalseActionsCache;

		// Token: 0x04008008 RID: 32776
		private bool _FalseActionsInited;
	}
}
