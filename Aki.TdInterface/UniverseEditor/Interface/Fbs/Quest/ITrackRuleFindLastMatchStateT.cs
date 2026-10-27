using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004212 RID: 16914
	public class ITrackRuleFindLastMatchStateT
	{
		// Token: 0x17007828 RID: 30760
		// (get) Token: 0x06018FF3 RID: 102387 RVA: 0x00398F2F File Offset: 0x0039712F
		// (set) Token: 0x06018FF4 RID: 102388 RVA: 0x00398F37 File Offset: 0x00397137
		public ETrackRuleType Type { get; set; }

		// Token: 0x17007829 RID: 30761
		// (get) Token: 0x06018FF5 RID: 102389 RVA: 0x00398F40 File Offset: 0x00397140
		// (set) Token: 0x06018FF6 RID: 102390 RVA: 0x00398F48 File Offset: 0x00397148
		public string State { get; set; }

		// Token: 0x06018FF7 RID: 102391 RVA: 0x00398F51 File Offset: 0x00397151
		public ITrackRuleFindLastMatchStateT()
		{
			this.Type = ETrackRuleType.FindLastMatchState;
			this.State = null;
		}
	}
}
