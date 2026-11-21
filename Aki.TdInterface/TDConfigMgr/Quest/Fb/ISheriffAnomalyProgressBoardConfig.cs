using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200156F RID: 5487
	public class ISheriffAnomalyProgressBoardConfig
	{
		// Token: 0x06007BA9 RID: 31657 RVA: 0x00126072 File Offset: 0x00124272
		public static ISheriffAnomalyProgressBoardConfig Create(ISheriffAnomalyProgressBoardConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffAnomalyProgressBoardConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x00126091 File Offset: 0x00124291
		public virtual int AnomalyId
		{
			get
			{
				return this.Instance.AnomalyId;
			}
		}

		// Token: 0x04004741 RID: 18241
		private ISheriffAnomalyProgressBoardConfig Instance;
	}
}
