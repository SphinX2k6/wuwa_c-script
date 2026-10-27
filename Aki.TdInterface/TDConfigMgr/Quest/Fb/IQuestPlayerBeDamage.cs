using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200134E RID: 4942
	public class IQuestPlayerBeDamage : IQuestPlayerHitStatisticsType
	{
		// Token: 0x0600713C RID: 28988 RVA: 0x001110C4 File Offset: 0x0010F2C4
		[NullableContext(1)]
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

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600713D RID: 28989 RVA: 0x001110E3 File Offset: 0x0010F2E3
		public override EPlayerHitStatisticsType Type
		{
			get
			{
				return (EPlayerHitStatisticsType)this.Instance.Type;
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x001110F0 File Offset: 0x0010F2F0
		public virtual EPlayerDamageInfoType StatisticsType
		{
			get
			{
				return (EPlayerDamageInfoType)this.Instance.StatisticsType;
			}
		}

		// Token: 0x04004164 RID: 16740
		private IQuestPlayerBeDamage Instance;
	}
}
