using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146F RID: 5231
	public class IQuestScheduleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x060076FD RID: 30461 RVA: 0x0011DC4C File Offset: 0x0011BE4C
		public static IQuestScheduleTowerChallengeTitle Create(IQuestScheduleTowerChallengeTitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleTowerChallengeTitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x060076FE RID: 30462 RVA: 0x0011DC6B File Offset: 0x0011BE6B
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x0400444D RID: 17485
		private IQuestScheduleTowerChallengeTitle Instance;
	}
}
