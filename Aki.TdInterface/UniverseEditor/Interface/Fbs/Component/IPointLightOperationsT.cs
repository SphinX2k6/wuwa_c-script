using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D6E RID: 23918
	public class IPointLightOperationsT
	{
		// Token: 0x1700B007 RID: 45063
		// (get) Token: 0x06027D15 RID: 163093 RVA: 0x00572643 File Offset: 0x00570843
		// (set) Token: 0x06027D16 RID: 163094 RVA: 0x0057264B File Offset: 0x0057084B
		public IEntityMatchT Match { get; set; }

		// Token: 0x1700B008 RID: 45064
		// (get) Token: 0x06027D17 RID: 163095 RVA: 0x00572654 File Offset: 0x00570854
		// (set) Token: 0x06027D18 RID: 163096 RVA: 0x0057265C File Offset: 0x0057085C
		public string SwitchToTargetState { get; set; }

		// Token: 0x06027D19 RID: 163097 RVA: 0x00572665 File Offset: 0x00570865
		public IPointLightOperationsT()
		{
			this.Match = null;
			this.SwitchToTargetState = null;
		}
	}
}
