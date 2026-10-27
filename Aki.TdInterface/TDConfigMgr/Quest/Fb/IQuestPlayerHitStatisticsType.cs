using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200134C RID: 4940
	public class IQuestPlayerHitStatisticsType
	{
		// Token: 0x06007133 RID: 28979 RVA: 0x00110F5B File Offset: 0x0010F15B
		[NullableContext(1)]
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

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x00110F7A File Offset: 0x0010F17A
		public virtual EPlayerHitStatisticsType Type
		{
			get
			{
				return (EPlayerHitStatisticsType)this.Instance.Type;
			}
		}

		// Token: 0x0400415E RID: 16734
		private IQuestPlayerHitStatisticsType Instance;
	}
}
