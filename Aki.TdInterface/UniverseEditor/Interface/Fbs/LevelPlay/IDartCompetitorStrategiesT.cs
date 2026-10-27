using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004471 RID: 17521
	public class IDartCompetitorStrategiesT
	{
		// Token: 0x17007BA9 RID: 31657
		// (get) Token: 0x0601A1E2 RID: 106978 RVA: 0x003BB32E File Offset: 0x003B952E
		// (set) Token: 0x0601A1E3 RID: 106979 RVA: 0x003BB336 File Offset: 0x003B9536
		public int Mode301Strategy { get; set; }

		// Token: 0x17007BAA RID: 31658
		// (get) Token: 0x0601A1E4 RID: 106980 RVA: 0x003BB33F File Offset: 0x003B953F
		// (set) Token: 0x0601A1E5 RID: 106981 RVA: 0x003BB347 File Offset: 0x003B9547
		public int Mode501Strategy { get; set; }

		// Token: 0x17007BAB RID: 31659
		// (get) Token: 0x0601A1E6 RID: 106982 RVA: 0x003BB350 File Offset: 0x003B9550
		// (set) Token: 0x0601A1E7 RID: 106983 RVA: 0x003BB358 File Offset: 0x003B9558
		public int Mode701Strategy { get; set; }

		// Token: 0x0601A1E8 RID: 106984 RVA: 0x003BB361 File Offset: 0x003B9561
		public IDartCompetitorStrategiesT()
		{
			this.Mode301Strategy = 0;
			this.Mode501Strategy = 0;
			this.Mode701Strategy = 0;
		}
	}
}
