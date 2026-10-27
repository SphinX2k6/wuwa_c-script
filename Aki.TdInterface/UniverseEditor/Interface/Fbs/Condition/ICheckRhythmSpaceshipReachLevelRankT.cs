using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B09 RID: 19209
	public class ICheckRhythmSpaceshipReachLevelRankT
	{
		// Token: 0x17008B58 RID: 35672
		// (get) Token: 0x0601E35A RID: 123738 RVA: 0x0043C762 File Offset: 0x0043A962
		// (set) Token: 0x0601E35B RID: 123739 RVA: 0x0043C76A File Offset: 0x0043A96A
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008B59 RID: 35673
		// (get) Token: 0x0601E35C RID: 123740 RVA: 0x0043C773 File Offset: 0x0043A973
		// (set) Token: 0x0601E35D RID: 123741 RVA: 0x0043C77B File Offset: 0x0043A97B
		public int RhythmSpaceshipLevelId { get; set; }

		// Token: 0x17008B5A RID: 35674
		// (get) Token: 0x0601E35E RID: 123742 RVA: 0x0043C784 File Offset: 0x0043A984
		// (set) Token: 0x0601E35F RID: 123743 RVA: 0x0043C78C File Offset: 0x0043A98C
		public ERhythmSpaceshipLevelRank Rank { get; set; }

		// Token: 0x0601E360 RID: 123744 RVA: 0x0043C795 File Offset: 0x0043A995
		public ICheckRhythmSpaceshipReachLevelRankT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.RhythmSpaceshipLevelId = 0;
			this.Rank = ERhythmSpaceshipLevelRank.None;
		}
	}
}
