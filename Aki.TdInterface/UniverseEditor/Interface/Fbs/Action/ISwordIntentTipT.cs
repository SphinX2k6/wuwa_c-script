using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A4D RID: 31309
	public class ISwordIntentTipT
	{
		// Token: 0x1700E567 RID: 58727
		// (get) Token: 0x060372EB RID: 226027 RVA: 0x0075F296 File Offset: 0x0075D496
		// (set) Token: 0x060372EC RID: 226028 RVA: 0x0075F29E File Offset: 0x0075D49E
		public ECommonTipType Type { get; set; }

		// Token: 0x060372ED RID: 226029 RVA: 0x0075F2A7 File Offset: 0x0075D4A7
		public ISwordIntentTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
		}
	}
}
