using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146E RID: 5230
	public class IQuestScheduleChildQuestCompletedCount : IQuestScheduleType
	{
		// Token: 0x060076F9 RID: 30457 RVA: 0x0011DBB3 File Offset: 0x0011BDB3
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

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x060076FA RID: 30458 RVA: 0x0011DBD2 File Offset: 0x0011BDD2
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x0011DBE0 File Offset: 0x0011BDE0
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

		// Token: 0x0400444A RID: 17482
		private IQuestScheduleChildQuestCompletedCount Instance;

		// Token: 0x0400444B RID: 17483
		private List<int> _AssociatedChildQuestIdsCache;

		// Token: 0x0400444C RID: 17484
		private bool _AssociatedChildQuestIdsInited;
	}
}
