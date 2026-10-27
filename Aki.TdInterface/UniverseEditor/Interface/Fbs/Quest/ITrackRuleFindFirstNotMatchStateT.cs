using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420F RID: 16911
	public class ITrackRuleFindFirstNotMatchStateT
	{
		// Token: 0x17007823 RID: 30755
		// (get) Token: 0x06018FDB RID: 102363 RVA: 0x00398CFB File Offset: 0x00396EFB
		// (set) Token: 0x06018FDC RID: 102364 RVA: 0x00398D03 File Offset: 0x00396F03
		public ETrackRuleType Type { get; set; }

		// Token: 0x17007824 RID: 30756
		// (get) Token: 0x06018FDD RID: 102365 RVA: 0x00398D0C File Offset: 0x00396F0C
		// (set) Token: 0x06018FDE RID: 102366 RVA: 0x00398D14 File Offset: 0x00396F14
		public string State { get; set; }

		// Token: 0x06018FDF RID: 102367 RVA: 0x00398D1D File Offset: 0x00396F1D
		public ITrackRuleFindFirstNotMatchStateT()
		{
			this.Type = ETrackRuleType.FindLastMatchState;
			this.State = null;
		}
	}
}
