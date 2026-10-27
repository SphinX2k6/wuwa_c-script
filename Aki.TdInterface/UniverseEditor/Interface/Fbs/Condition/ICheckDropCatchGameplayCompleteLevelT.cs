using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049D7 RID: 18903
	public class ICheckDropCatchGameplayCompleteLevelT
	{
		// Token: 0x170088B2 RID: 34994
		// (get) Token: 0x0601D860 RID: 120928 RVA: 0x00428374 File Offset: 0x00426574
		// (set) Token: 0x0601D861 RID: 120929 RVA: 0x0042837C File Offset: 0x0042657C
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170088B3 RID: 34995
		// (get) Token: 0x0601D862 RID: 120930 RVA: 0x00428385 File Offset: 0x00426585
		// (set) Token: 0x0601D863 RID: 120931 RVA: 0x0042838D File Offset: 0x0042658D
		public int LevelId { get; set; }

		// Token: 0x0601D864 RID: 120932 RVA: 0x00428396 File Offset: 0x00426596
		public ICheckDropCatchGameplayCompleteLevelT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.LevelId = 0;
		}
	}
}
