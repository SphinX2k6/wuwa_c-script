using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F27 RID: 20263
	public class ICheckHonamiStoryPlayerCorruptedLevelT
	{
		// Token: 0x170090BA RID: 37050
		// (get) Token: 0x0601F7E3 RID: 128995 RVA: 0x00462226 File Offset: 0x00460426
		// (set) Token: 0x0601F7E4 RID: 128996 RVA: 0x0046222E File Offset: 0x0046042E
		public ECondition Type { get; set; }

		// Token: 0x170090BB RID: 37051
		// (get) Token: 0x0601F7E5 RID: 128997 RVA: 0x00462237 File Offset: 0x00460437
		// (set) Token: 0x0601F7E6 RID: 128998 RVA: 0x0046223F File Offset: 0x0046043F
		public ECompare Compare { get; set; }

		// Token: 0x170090BC RID: 37052
		// (get) Token: 0x0601F7E7 RID: 128999 RVA: 0x00462248 File Offset: 0x00460448
		// (set) Token: 0x0601F7E8 RID: 129000 RVA: 0x00462250 File Offset: 0x00460450
		public int Level { get; set; }

		// Token: 0x0601F7E9 RID: 129001 RVA: 0x00462259 File Offset: 0x00460459
		public ICheckHonamiStoryPlayerCorruptedLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
