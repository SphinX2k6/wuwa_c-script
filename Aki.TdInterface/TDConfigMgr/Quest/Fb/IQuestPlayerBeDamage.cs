using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200149E RID: 5278
	public class IQuestPlayerBeDamage : IQuestPlayerHitStatisticsType
	{
		// Token: 0x060077DC RID: 30684 RVA: 0x0011F630 File Offset: 0x0011D830
		public static IQuestPlayerBeDamage Create(IQuestPlayerBeDamage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestPlayerBeDamage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x0011F64F File Offset: 0x0011D84F
		public override EPlayerHitStatisticsType Type
		{
			get
			{
				return (EPlayerHitStatisticsType)this.Instance.Type;
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x0011F65C File Offset: 0x0011D85C
		public virtual EPlayerDamageInfoType StatisticsType
		{
			get
			{
				return (EPlayerDamageInfoType)this.Instance.StatisticsType;
			}
		}

		// Token: 0x040044E0 RID: 17632
		private IQuestPlayerBeDamage Instance;
	}
}
