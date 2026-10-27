using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D78 RID: 23928
	[NullableContext(1)]
	[Nullable(0)]
	public class LackResourceQuestTextInfo : MissionViewStepTextInfoBase
	{
		// Token: 0x0603CBB6 RID: 248758 RVA: 0x00E954A8 File Offset: 0x00E936A8
		public LackResourceQuestTextInfo(string tidTitle) : base(tidTitle, null, null)
		{
		}

		// Token: 0x17008E25 RID: 36389
		// (get) Token: 0x0603CBB7 RID: 248759 RVA: 0x00E954B3 File Offset: 0x00E936B3
		public override EMissionItemViewDataSource ShowSource
		{
			get
			{
				return EMissionItemViewDataSource.LackResourceQuest;
			}
		}

		// Token: 0x17008E26 RID: 36390
		// (get) Token: 0x0603CBB8 RID: 248760 RVA: 0x00E954B6 File Offset: 0x00E936B6
		public override string TidTitle
		{
			get
			{
				return this.InnerTidTitle;
			}
		}

		// Token: 0x17008E27 RID: 36391
		// (get) Token: 0x0603CBB9 RID: 248761 RVA: 0x00E954BE File Offset: 0x00E936BE
		public string QuestScheduleType
		{
			get
			{
				return "FishingEntrust";
			}
		}
	}
}
