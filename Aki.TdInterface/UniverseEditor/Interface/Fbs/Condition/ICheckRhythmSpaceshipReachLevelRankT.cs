using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FF0 RID: 20464
	public class ICheckRhythmSpaceshipReachLevelRankT
	{
		// Token: 0x17009268 RID: 37480
		// (get) Token: 0x0601FEE5 RID: 130789 RVA: 0x0046EF0E File Offset: 0x0046D10E
		// (set) Token: 0x0601FEE6 RID: 130790 RVA: 0x0046EF16 File Offset: 0x0046D116
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17009269 RID: 37481
		// (get) Token: 0x0601FEE7 RID: 130791 RVA: 0x0046EF1F File Offset: 0x0046D11F
		// (set) Token: 0x0601FEE8 RID: 130792 RVA: 0x0046EF27 File Offset: 0x0046D127
		public int RhythmSpaceshipLevelId { get; set; }

		// Token: 0x1700926A RID: 37482
		// (get) Token: 0x0601FEE9 RID: 130793 RVA: 0x0046EF30 File Offset: 0x0046D130
		// (set) Token: 0x0601FEEA RID: 130794 RVA: 0x0046EF38 File Offset: 0x0046D138
		public ERhythmSpaceshipLevelRank Rank { get; set; }

		// Token: 0x0601FEEB RID: 130795 RVA: 0x0046EF41 File Offset: 0x0046D141
		public ICheckRhythmSpaceshipReachLevelRankT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.RhythmSpaceshipLevelId = 0;
			this.Rank = ERhythmSpaceshipLevelRank.None;
		}
	}
}
