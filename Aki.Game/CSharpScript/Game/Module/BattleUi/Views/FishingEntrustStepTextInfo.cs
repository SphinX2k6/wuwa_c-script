using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D59 RID: 19801
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingEntrustStepTextInfo : MissionViewStepTextInfoBase
	{
		// Token: 0x06031B0D RID: 203533 RVA: 0x00DE5CC4 File Offset: 0x00DE3EC4
		public FishingEntrustStepTextInfo(string tidTitle, int progressTargetId) : base(tidTitle, null, null)
		{
		}

		// Token: 0x170061F3 RID: 25075
		// (get) Token: 0x06031B0E RID: 203534 RVA: 0x00DE5CD6 File Offset: 0x00DE3ED6
		public override EMissionItemViewDataSource ShowSource
		{
			get
			{
				return EMissionItemViewDataSource.FishingEntrust;
			}
		}

		// Token: 0x170061F4 RID: 25076
		// (get) Token: 0x06031B0F RID: 203535 RVA: 0x00DE5CD9 File Offset: 0x00DE3ED9
		public int ProgressTargetId { get; } = progressTargetId;

		// Token: 0x170061F5 RID: 25077
		// (get) Token: 0x06031B10 RID: 203536 RVA: 0x00DE5CE1 File Offset: 0x00DE3EE1
		public override string TidTitle
		{
			get
			{
				return this.InnerTidTitle;
			}
		}

		// Token: 0x170061F6 RID: 25078
		// (get) Token: 0x06031B11 RID: 203537 RVA: 0x00DE5CE9 File Offset: 0x00DE3EE9
		public string QuestScheduleType
		{
			get
			{
				return "FishingEntrust";
			}
		}
	}
}
