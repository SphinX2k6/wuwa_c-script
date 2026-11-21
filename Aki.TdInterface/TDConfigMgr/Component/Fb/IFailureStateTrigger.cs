using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB9 RID: 3001
	public class IFailureStateTrigger
	{
		// Token: 0x06004495 RID: 17557 RVA: 0x000ADC6E File Offset: 0x000ABE6E
		public static IFailureStateTrigger Create(IFailureStateTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailureStateTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x000ADC8D File Offset: 0x000ABE8D
		public virtual List<IEntityGroupFailureCondition> FailureConditions
		{
			get
			{
				if (this._FailureConditionsInited)
				{
					return this._FailureConditionsCache;
				}
				this._FailureConditionsInited = true;
				this._FailureConditionsCache = ComponentReadHelper.ReadIFailureStateTrigger_FailureConditions(this.Instance);
				return this._FailureConditionsCache;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x000ADCBC File Offset: 0x000ABEBC
		public virtual IOperationsAfterEntityGroupFailure FailureOperations
		{
			get
			{
				if (this._FailureOperationsInited)
				{
					return this._FailureOperationsCache;
				}
				this._FailureOperationsInited = true;
				this._FailureOperationsCache = IOperationsAfterEntityGroupFailure.Create(this.Instance.FailureOperations);
				return this._FailureOperationsCache;
			}
		}

		// Token: 0x040025FC RID: 9724
		private IFailureStateTrigger Instance;

		// Token: 0x040025FD RID: 9725
		private List<IEntityGroupFailureCondition> _FailureConditionsCache;

		// Token: 0x040025FE RID: 9726
		private bool _FailureConditionsInited;

		// Token: 0x040025FF RID: 9727
		[Nullable(2)]
		private IOperationsAfterEntityGroupFailure _FailureOperationsCache;

		// Token: 0x04002600 RID: 9728
		private bool _FailureOperationsInited;
	}
}
