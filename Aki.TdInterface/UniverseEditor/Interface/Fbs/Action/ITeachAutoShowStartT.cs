using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B49 RID: 31561
	public class ITeachAutoShowStartT
	{
		// Token: 0x1700EC5D RID: 60509
		// (get) Token: 0x06038D73 RID: 232819 RVA: 0x007AF8DF File Offset: 0x007ADADF
		// (set) Token: 0x06038D74 RID: 232820 RVA: 0x007AF8E7 File Offset: 0x007ADAE7
		public ECommonTipType Type { get; set; }

		// Token: 0x1700EC5E RID: 60510
		// (get) Token: 0x06038D75 RID: 232821 RVA: 0x007AF8F0 File Offset: 0x007ADAF0
		// (set) Token: 0x06038D76 RID: 232822 RVA: 0x007AF8F8 File Offset: 0x007ADAF8
		public string TidMainText { get; set; }

		// Token: 0x06038D77 RID: 232823 RVA: 0x007AF901 File Offset: 0x007ADB01
		public ITeachAutoShowStartT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
		}
	}
}
