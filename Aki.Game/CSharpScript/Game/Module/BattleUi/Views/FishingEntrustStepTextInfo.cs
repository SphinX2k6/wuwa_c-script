using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D77 RID: 23927
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingEntrustStepTextInfo : MissionViewStepTextInfoBase
	{
		// Token: 0x0603CBB1 RID: 248753 RVA: 0x00E9547C File Offset: 0x00E9367C
		public FishingEntrustStepTextInfo(string tidTitle, int progressTargetId) : base(tidTitle, null, null)
		{
		}

		// Token: 0x17008E21 RID: 36385
		// (get) Token: 0x0603CBB2 RID: 248754 RVA: 0x00E9548E File Offset: 0x00E9368E
		public override EMissionItemViewDataSource ShowSource
		{
			get
			{
				return EMissionItemViewDataSource.FishingEntrust;
			}
		}

		// Token: 0x17008E22 RID: 36386
		// (get) Token: 0x0603CBB3 RID: 248755 RVA: 0x00E95491 File Offset: 0x00E93691
		public int ProgressTargetId { get; } = progressTargetId;

		// Token: 0x17008E23 RID: 36387
		// (get) Token: 0x0603CBB4 RID: 248756 RVA: 0x00E95499 File Offset: 0x00E93699
		public override string TidTitle
		{
			get
			{
				return this.InnerTidTitle;
			}
		}

		// Token: 0x17008E24 RID: 36388
		// (get) Token: 0x0603CBB5 RID: 248757 RVA: 0x00E954A1 File Offset: 0x00E936A1
		public string QuestScheduleType
		{
			get
			{
				return "FishingEntrust";
			}
		}
	}
}
