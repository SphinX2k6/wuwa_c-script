using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001474 RID: 5236
	public class IQuestScheduleRoleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x0600770C RID: 30476 RVA: 0x0011DD50 File Offset: 0x0011BF50
		public static IQuestScheduleRoleTowerChallengeTitle Create(IQuestScheduleRoleTowerChallengeTitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestScheduleRoleTowerChallengeTitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x0600770D RID: 30477 RVA: 0x0011DD6F File Offset: 0x0011BF6F
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x0600770E RID: 30478 RVA: 0x0011DD7C File Offset: 0x0011BF7C
		public virtual IRoleTowerChallengeTitleTypeBase TitleType
		{
			get
			{
				if (this._TitleTypeInited)
				{
					return this._TitleTypeCache;
				}
				this._TitleTypeInited = true;
				this._TitleTypeCache = QuestReadHelper.ReadIQuestScheduleRoleTowerChallengeTitle_TitleType(this.Instance);
				return this._TitleTypeCache;
			}
		}

		// Token: 0x04004452 RID: 17490
		private IQuestScheduleRoleTowerChallengeTitle Instance;

		// Token: 0x04004453 RID: 17491
		private IRoleTowerChallengeTitleTypeBase _TitleTypeCache;

		// Token: 0x04004454 RID: 17492
		private bool _TitleTypeInited;
	}
}
