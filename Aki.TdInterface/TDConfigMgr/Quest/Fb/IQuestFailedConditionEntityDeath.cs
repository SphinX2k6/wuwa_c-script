using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001588 RID: 5512
	public class IQuestFailedConditionEntityDeath
	{
		// Token: 0x06007C51 RID: 31825 RVA: 0x00127734 File Offset: 0x00125934
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

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x06007C52 RID: 31826 RVA: 0x00127754 File Offset: 0x00125954
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

		// Token: 0x040047AE RID: 18350
		private IQuestFailedConditionEntityDeath Instance;

		// Token: 0x040047AF RID: 18351
		private List<int> _EntityIdsCache;

		// Token: 0x040047B0 RID: 18352
		private bool _EntityIdsInited;
	}
}
