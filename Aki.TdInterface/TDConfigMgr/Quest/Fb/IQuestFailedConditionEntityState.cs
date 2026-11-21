using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001589 RID: 5513
	public class IQuestFailedConditionEntityState
	{
		// Token: 0x06007C54 RID: 31828 RVA: 0x001277C0 File Offset: 0x001259C0
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

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x06007C55 RID: 31829 RVA: 0x001277E0 File Offset: 0x001259E0
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

		// Token: 0x040047B1 RID: 18353
		private IQuestFailedConditionEntityState Instance;

		// Token: 0x040047B2 RID: 18354
		private List<IEntityStateCondition> _ConditionsCache;

		// Token: 0x040047B3 RID: 18355
		private bool _ConditionsInited;
	}
}
