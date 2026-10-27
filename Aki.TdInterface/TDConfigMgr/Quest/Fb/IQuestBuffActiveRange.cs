using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F8 RID: 4856
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestBuffActiveRange
	{
		// Token: 0x06006EC3 RID: 28355 RVA: 0x0010B7FA File Offset: 0x001099FA
		[NullableContext(1)]
		public static IQuestBuffActiveRange Create(IQuestBuffActiveRange? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestBuffActiveRange
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06006EC4 RID: 28356 RVA: 0x0010B819 File Offset: 0x00109A19
		public virtual IQuestBuffActiveCenterRange QuestBuffActiveCenterRange
		{
			get
			{
				if (this._QuestBuffActiveCenterRangeInited)
				{
					return this._QuestBuffActiveCenterRangeCache;
				}
				this._QuestBuffActiveCenterRangeInited = true;
				this._QuestBuffActiveCenterRangeCache = IQuestBuffActiveCenterRange.Create(this.Instance.QuestBuffActiveCenterRange);
				return this._QuestBuffActiveCenterRangeCache;
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06006EC5 RID: 28357 RVA: 0x0010B850 File Offset: 0x00109A50
		public virtual List<int> QuestBuffActiveRangeEntities
		{
			get
			{
				if (this._QuestBuffActiveRangeEntitiesInited)
				{
					return this._QuestBuffActiveRangeEntitiesCache;
				}
				this._QuestBuffActiveRangeEntitiesInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int questBuffActiveRangeEntitiesLength = this.Instance.QuestBuffActiveRangeEntitiesLength;
				this._QuestBuffActiveRangeEntitiesCache = new List<int>(questBuffActiveRangeEntitiesLength);
				for (int i = 0; i < questBuffActiveRangeEntitiesLength; i++)
				{
					this._QuestBuffActiveRangeEntitiesCache.Add(this.Instance.QuestBuffActiveRangeEntities(i));
				}
				return this._QuestBuffActiveRangeEntitiesCache;
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x0010B8C8 File Offset: 0x00109AC8
		public virtual List<int> QuestBuffActiveRangeAreaIds
		{
			get
			{
				if (this._QuestBuffActiveRangeAreaIdsInited)
				{
					return this._QuestBuffActiveRangeAreaIdsCache;
				}
				this._QuestBuffActiveRangeAreaIdsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int questBuffActiveRangeAreaIdsLength = this.Instance.QuestBuffActiveRangeAreaIdsLength;
				this._QuestBuffActiveRangeAreaIdsCache = new List<int>(questBuffActiveRangeAreaIdsLength);
				for (int i = 0; i < questBuffActiveRangeAreaIdsLength; i++)
				{
					this._QuestBuffActiveRangeAreaIdsCache.Add(this.Instance.QuestBuffActiveRangeAreaIds(i));
				}
				return this._QuestBuffActiveRangeAreaIdsCache;
			}
		}

		// Token: 0x04003F7E RID: 16254
		private IQuestBuffActiveRange Instance;

		// Token: 0x04003F7F RID: 16255
		private IQuestBuffActiveCenterRange _QuestBuffActiveCenterRangeCache;

		// Token: 0x04003F80 RID: 16256
		private bool _QuestBuffActiveCenterRangeInited;

		// Token: 0x04003F81 RID: 16257
		private List<int> _QuestBuffActiveRangeEntitiesCache;

		// Token: 0x04003F82 RID: 16258
		private bool _QuestBuffActiveRangeEntitiesInited;

		// Token: 0x04003F83 RID: 16259
		private List<int> _QuestBuffActiveRangeAreaIdsCache;

		// Token: 0x04003F84 RID: 16260
		private bool _QuestBuffActiveRangeAreaIdsInited;
	}
}
