using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AEE RID: 2798
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailureStateTrigger
	{
		// Token: 0x06004066 RID: 16486 RVA: 0x000A463A File Offset: 0x000A283A
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

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x000A4659 File Offset: 0x000A2859
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

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x000A4688 File Offset: 0x000A2888
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

		// Token: 0x040023DF RID: 9183
		private IFailureStateTrigger Instance;

		// Token: 0x040023E0 RID: 9184
		private List<IEntityGroupFailureCondition> _FailureConditionsCache;

		// Token: 0x040023E1 RID: 9185
		private bool _FailureConditionsInited;

		// Token: 0x040023E2 RID: 9186
		[Nullable(2)]
		private IOperationsAfterEntityGroupFailure _FailureOperationsCache;

		// Token: 0x040023E3 RID: 9187
		private bool _FailureOperationsInited;
	}
}
