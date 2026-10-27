using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142F RID: 5167
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestFailedConditionEntityAlert
	{
		// Token: 0x06007589 RID: 30089 RVA: 0x00118C5C File Offset: 0x00116E5C
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

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x00118C7C File Offset: 0x00116E7C
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

		// Token: 0x04004417 RID: 17431
		private IQuestFailedConditionEntityAlert Instance;

		// Token: 0x04004418 RID: 17432
		private List<int> _EntityIdsCache;

		// Token: 0x04004419 RID: 17433
		private bool _EntityIdsInited;
	}
}
