using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001430 RID: 5168
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConditionEntityDeath
	{
		// Token: 0x0600758C RID: 30092 RVA: 0x00118CE8 File Offset: 0x00116EE8
		public static IQuestFailedConditionEntityDeath Create(IQuestFailedConditionEntityDeath? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityDeath
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x0600758D RID: 30093 RVA: 0x00118D08 File Offset: 0x00116F08
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x0400441A RID: 17434
		private IQuestFailedConditionEntityDeath Instance;

		// Token: 0x0400441B RID: 17435
		private List<int> _EntityIdsCache;

		// Token: 0x0400441C RID: 17436
		private bool _EntityIdsInited;
	}
}
