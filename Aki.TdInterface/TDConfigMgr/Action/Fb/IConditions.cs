using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002603 RID: 9731
	[NullableContext(1)]
	[Nullable(0)]
	public class IConditions
	{
		// Token: 0x0600DA95 RID: 55957 RVA: 0x002090E9 File Offset: 0x002072E9
		public static IConditions Create(IConditions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConditions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x0600DA96 RID: 55958 RVA: 0x00209108 File Offset: 0x00207308
		public virtual string LogicOpType
		{
			get
			{
				return this.Instance.LogicOpType;
			}
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x0600DA97 RID: 55959 RVA: 0x00209118 File Offset: 0x00207318
		public virtual List<ICondition> Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				int conditionsLength = this.Instance.ConditionsLength;
				this._ConditionsCache = new List<ICondition>(conditionsLength);
				for (int i = 0; i < conditionsLength; i++)
				{
					this._ConditionsCache.Add(ICondition.Create(this.Instance.Conditions(i)));
				}
				return this._ConditionsCache;
			}
		}

		// Token: 0x04007965 RID: 31077
		private IConditions Instance;

		// Token: 0x04007966 RID: 31078
		private List<ICondition> _ConditionsCache;

		// Token: 0x04007967 RID: 31079
		private bool _ConditionsInited;
	}
}
