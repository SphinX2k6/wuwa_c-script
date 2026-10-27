using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200131F RID: 4895
	public class IQuestScheduleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x0600705D RID: 28765 RVA: 0x0010F6E0 File Offset: 0x0010D8E0
		[NullableContext(1)]
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

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600705E RID: 28766 RVA: 0x0010F6FF File Offset: 0x0010D8FF
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x040040D1 RID: 16593
		private IQuestScheduleTowerChallengeTitle Instance;
	}
}
