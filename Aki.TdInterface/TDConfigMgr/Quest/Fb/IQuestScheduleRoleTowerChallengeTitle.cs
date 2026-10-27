using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001324 RID: 4900
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestScheduleRoleTowerChallengeTitle : IQuestScheduleType
	{
		// Token: 0x0600706C RID: 28780 RVA: 0x0010F7E4 File Offset: 0x0010D9E4
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

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600706D RID: 28781 RVA: 0x0010F803 File Offset: 0x0010DA03
		public override EQuestScheduleType Type
		{
			get
			{
				return (EQuestScheduleType)this.Instance.Type;
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600706E RID: 28782 RVA: 0x0010F810 File Offset: 0x0010DA10
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

		// Token: 0x040040D6 RID: 16598
		private IQuestScheduleRoleTowerChallengeTitle Instance;

		// Token: 0x040040D7 RID: 16599
		private IRoleTowerChallengeTitleTypeBase _TitleTypeCache;

		// Token: 0x040040D8 RID: 16600
		private bool _TitleTypeInited;
	}
}
