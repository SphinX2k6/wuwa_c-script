using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005095 RID: 20629
	public class ICompareGameDifficultyT
	{
		// Token: 0x170093BA RID: 37818
		// (get) Token: 0x0602047C RID: 132220 RVA: 0x00478E3E File Offset: 0x0047703E
		// (set) Token: 0x0602047D RID: 132221 RVA: 0x00478E46 File Offset: 0x00477046
		public ECondition Type { get; set; }

		// Token: 0x170093BB RID: 37819
		// (get) Token: 0x0602047E RID: 132222 RVA: 0x00478E4F File Offset: 0x0047704F
		// (set) Token: 0x0602047F RID: 132223 RVA: 0x00478E57 File Offset: 0x00477057
		public EVarCompare CompareType { get; set; }

		// Token: 0x170093BC RID: 37820
		// (get) Token: 0x06020480 RID: 132224 RVA: 0x00478E60 File Offset: 0x00477060
		// (set) Token: 0x06020481 RID: 132225 RVA: 0x00478E68 File Offset: 0x00477068
		public EGameDifficultyType Difficulty { get; set; }

		// Token: 0x06020482 RID: 132226 RVA: 0x00478E71 File Offset: 0x00477071
		public ICompareGameDifficultyT()
		{
			this.Type = ECondition.CompareVar;
			this.CompareType = EVarCompare.Eq;
			this.Difficulty = EGameDifficultyType.None;
		}
	}
}
