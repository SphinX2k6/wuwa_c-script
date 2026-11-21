using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001587 RID: 5511
	public class IQuestFailedConditionEntityAlert
	{
		// Token: 0x06007C4E RID: 31822 RVA: 0x001276A8 File Offset: 0x001258A8
		public static IQuestFailedConditionEntityAlert Create(IQuestFailedConditionEntityAlert? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestFailedConditionEntityAlert
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x06007C4F RID: 31823 RVA: 0x001276C8 File Offset: 0x001258C8
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

		// Token: 0x040047AB RID: 18347
		private IQuestFailedConditionEntityAlert Instance;

		// Token: 0x040047AC RID: 18348
		private List<int> _EntityIdsCache;

		// Token: 0x040047AD RID: 18349
		private bool _EntityIdsInited;
	}
}
