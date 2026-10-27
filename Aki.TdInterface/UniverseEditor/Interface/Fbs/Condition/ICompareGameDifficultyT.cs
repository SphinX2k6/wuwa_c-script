using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BAB RID: 19371
	public class ICompareGameDifficultyT
	{
		// Token: 0x17008CA1 RID: 36001
		// (get) Token: 0x0601E8D0 RID: 125136 RVA: 0x004462DA File Offset: 0x004444DA
		// (set) Token: 0x0601E8D1 RID: 125137 RVA: 0x004462E2 File Offset: 0x004444E2
		public ECondition Type { get; set; }

		// Token: 0x17008CA2 RID: 36002
		// (get) Token: 0x0601E8D2 RID: 125138 RVA: 0x004462EB File Offset: 0x004444EB
		// (set) Token: 0x0601E8D3 RID: 125139 RVA: 0x004462F3 File Offset: 0x004444F3
		public EVarCompare CompareType { get; set; }

		// Token: 0x17008CA3 RID: 36003
		// (get) Token: 0x0601E8D4 RID: 125140 RVA: 0x004462FC File Offset: 0x004444FC
		// (set) Token: 0x0601E8D5 RID: 125141 RVA: 0x00446304 File Offset: 0x00444504
		public EGameDifficultyType Difficulty { get; set; }

		// Token: 0x0601E8D6 RID: 125142 RVA: 0x0044630D File Offset: 0x0044450D
		public ICompareGameDifficultyT()
		{
			this.Type = ECondition.CompareVar;
			this.CompareType = EVarCompare.Eq;
			this.Difficulty = EGameDifficultyType.None;
		}
	}
}
