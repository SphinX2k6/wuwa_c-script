using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D82 RID: 23938
	public class MissionItemViewEndTrackProcess : TPendingProcess
	{
		// Token: 0x0603CC36 RID: 248886 RVA: 0x00E96A5E File Offset: 0x00E94C5E
		public MissionItemViewEndTrackProcess(long id, int reason, bool isSkipAnim)
		{
		}

		// Token: 0x17008E57 RID: 36439
		// (get) Token: 0x0603CC37 RID: 248887 RVA: 0x00E96A7B File Offset: 0x00E94C7B
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.MissionItemViewEndTrack;
			}
		}

		// Token: 0x17008E58 RID: 36440
		// (get) Token: 0x0603CC38 RID: 248888 RVA: 0x00E96A7E File Offset: 0x00E94C7E
		public override bool IsSkipAnim { get; } = isSkipAnim;

		// Token: 0x0401FA72 RID: 129650
		public readonly long Id = id;

		// Token: 0x0401FA73 RID: 129651
		public readonly int Reason = reason;
	}
}
