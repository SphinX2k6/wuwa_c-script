using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D64 RID: 19812
	public class MissionItemViewEndTrackProcess : TPendingProcess
	{
		// Token: 0x06031B92 RID: 203666 RVA: 0x00DE72A6 File Offset: 0x00DE54A6
		public MissionItemViewEndTrackProcess(long id, int reason, bool isSkipAnim)
		{
		}

		// Token: 0x17006229 RID: 25129
		// (get) Token: 0x06031B93 RID: 203667 RVA: 0x00DE72C3 File Offset: 0x00DE54C3
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.MissionItemViewEndTrack;
			}
		}

		// Token: 0x1700622A RID: 25130
		// (get) Token: 0x06031B94 RID: 203668 RVA: 0x00DE72C6 File Offset: 0x00DE54C6
		public override bool IsSkipAnim { get; } = isSkipAnim;

		// Token: 0x0401A52A RID: 107818
		public readonly long Id = id;

		// Token: 0x0401A52B RID: 107819
		public readonly int Reason = reason;
	}
}
