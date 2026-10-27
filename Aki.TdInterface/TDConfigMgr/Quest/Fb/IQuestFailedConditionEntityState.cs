using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001431 RID: 5169
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConditionEntityState
	{
		// Token: 0x0600758F RID: 30095 RVA: 0x00118D74 File Offset: 0x00116F74
		public static IQuestFailedConditionEntityState Create(IQuestFailedConditionEntityState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x06007590 RID: 30096 RVA: 0x00118D94 File Offset: 0x00116F94
		public virtual List<IEntityStateCondition> Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				int conditionsLength = this.Instance.ConditionsLength;
				this._ConditionsCache = new List<IEntityStateCondition>(conditionsLength);
				for (int i = 0; i < conditionsLength; i++)
				{
					this._ConditionsCache.Add(IEntityStateCondition.Create(this.Instance.Conditions(i)));
				}
				return this._ConditionsCache;
			}
		}

		// Token: 0x0400441D RID: 17437
		private IQuestFailedConditionEntityState Instance;

		// Token: 0x0400441E RID: 17438
		private List<IEntityStateCondition> _ConditionsCache;

		// Token: 0x0400441F RID: 17439
		private bool _ConditionsInited;
	}
}
