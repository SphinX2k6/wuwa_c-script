using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001448 RID: 5192
	[NullableContext(2)]
	[Nullable(0)]
	public class IQuestBuffActiveRange
	{
		// Token: 0x06007563 RID: 30051 RVA: 0x00119D66 File Offset: 0x00117F66
		[NullableContext(0)]
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

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06007564 RID: 30052 RVA: 0x00119D85 File Offset: 0x00117F85
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

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x06007565 RID: 30053 RVA: 0x00119DBC File Offset: 0x00117FBC
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

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x06007566 RID: 30054 RVA: 0x00119E34 File Offset: 0x00118034
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

		// Token: 0x040042FA RID: 17146
		private IQuestBuffActiveRange Instance;

		// Token: 0x040042FB RID: 17147
		private IQuestBuffActiveCenterRange _QuestBuffActiveCenterRangeCache;

		// Token: 0x040042FC RID: 17148
		private bool _QuestBuffActiveCenterRangeInited;

		// Token: 0x040042FD RID: 17149
		private List<int> _QuestBuffActiveRangeEntitiesCache;

		// Token: 0x040042FE RID: 17150
		private bool _QuestBuffActiveRangeEntitiesInited;

		// Token: 0x040042FF RID: 17151
		private List<int> _QuestBuffActiveRangeAreaIdsCache;

		// Token: 0x04004300 RID: 17152
		private bool _QuestBuffActiveRangeAreaIdsInited;
	}
}
