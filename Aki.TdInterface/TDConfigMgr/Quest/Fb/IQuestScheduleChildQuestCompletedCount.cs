using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200131E RID: 4894
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleChildQuestCompletedCount : IQuestScheduleType
	{
		// Token: 0x06007059 RID: 28761 RVA: 0x0010F647 File Offset: 0x0010D847
		public static IQuestScheduleChildQuestCompletedCount Create(IQuestScheduleChildQuestCompletedCount? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleChildQuestCompletedCount
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600705A RID: 28762 RVA: 0x0010F666 File Offset: 0x0010D866
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x0010F674 File Offset: 0x0010D874
		public virtual List<int> AssociatedChildQuestIds
		{
			get
			{
				if (this._AssociatedChildQuestIdsInited)
				{
					return this._AssociatedChildQuestIdsCache;
				}
				this._AssociatedChildQuestIdsInited = true;
				int associatedChildQuestIdsLength = this.Instance.AssociatedChildQuestIdsLength;
				this._AssociatedChildQuestIdsCache = new List<int>(associatedChildQuestIdsLength);
				for (int i = 0; i < associatedChildQuestIdsLength; i++)
				{
					this._AssociatedChildQuestIdsCache.Add(this.Instance.AssociatedChildQuestIds(i));
				}
				return this._AssociatedChildQuestIdsCache;
			}
		}

		// Token: 0x040040CE RID: 16590
		private IQuestScheduleChildQuestCompletedCount Instance;

		// Token: 0x040040CF RID: 16591
		private List<int> _AssociatedChildQuestIdsCache;

		// Token: 0x040040D0 RID: 16592
		private bool _AssociatedChildQuestIdsInited;
	}
}
