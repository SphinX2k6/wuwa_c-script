using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200149C RID: 5276
	public class IQuestPlayerHitStatisticsType
	{
		// Token: 0x060077D3 RID: 30675 RVA: 0x0011F4C7 File Offset: 0x0011D6C7
		public static IQuestPlayerHitStatisticsType Create(IQuestPlayerHitStatisticsType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerHitStatisticsType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x0011F4E6 File Offset: 0x0011D6E6
		public virtual EPlayerHitStatisticsType Type
		{
			get
			{
				return (EPlayerHitStatisticsType)this.Instance.Type;
			}
		}

		// Token: 0x040044DA RID: 17626
		private IQuestPlayerHitStatisticsType Instance;
	}
}
