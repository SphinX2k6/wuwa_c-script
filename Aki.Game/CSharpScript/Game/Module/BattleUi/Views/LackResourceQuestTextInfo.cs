using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D5A RID: 19802
	[NullableContext(1)]
	[Nullable(0)]
	public class LackResourceQuestTextInfo : MissionViewStepTextInfoBase
	{
		// Token: 0x06031B12 RID: 203538 RVA: 0x00DE5CF0 File Offset: 0x00DE3EF0
		public LackResourceQuestTextInfo(string tidTitle) : base(tidTitle, null, null)
		{
		}

		// Token: 0x170061F7 RID: 25079
		// (get) Token: 0x06031B13 RID: 203539 RVA: 0x00DE5CFB File Offset: 0x00DE3EFB
		public override EMissionItemViewDataSource ShowSource
		{
			get
			{
				return EMissionItemViewDataSource.LackResourceQuest;
			}
		}

		// Token: 0x170061F8 RID: 25080
		// (get) Token: 0x06031B14 RID: 203540 RVA: 0x00DE5CFE File Offset: 0x00DE3EFE
		public override string TidTitle
		{
			get
			{
				return this.InnerTidTitle;
			}
		}

		// Token: 0x170061F9 RID: 25081
		// (get) Token: 0x06031B15 RID: 203541 RVA: 0x00DE5D06 File Offset: 0x00DE3F06
		public string QuestScheduleType
		{
			get
			{
				return "FishingEntrust";
			}
		}
	}
}
