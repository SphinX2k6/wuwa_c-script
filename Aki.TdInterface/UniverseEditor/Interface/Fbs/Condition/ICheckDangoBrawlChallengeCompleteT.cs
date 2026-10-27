using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B6 RID: 18870
	public class ICheckDangoBrawlChallengeCompleteT
	{
		// Token: 0x17008876 RID: 34934
		// (get) Token: 0x0601D762 RID: 120674 RVA: 0x004268EC File Offset: 0x00424AEC
		// (set) Token: 0x0601D763 RID: 120675 RVA: 0x004268F4 File Offset: 0x00424AF4
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008877 RID: 34935
		// (get) Token: 0x0601D764 RID: 120676 RVA: 0x004268FD File Offset: 0x00424AFD
		// (set) Token: 0x0601D765 RID: 120677 RVA: 0x00426905 File Offset: 0x00424B05
		public int ChallengeId { get; set; }

		// Token: 0x0601D766 RID: 120678 RVA: 0x0042690E File Offset: 0x00424B0E
		public ICheckDangoBrawlChallengeCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.ChallengeId = 0;
		}
	}
}
