using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004983 RID: 18819
	public class ICheckAlertAreaEnabledT
	{
		// Token: 0x170087EB RID: 34795
		// (get) Token: 0x0601D568 RID: 120168 RVA: 0x0042306C File Offset: 0x0042126C
		// (set) Token: 0x0601D569 RID: 120169 RVA: 0x00423074 File Offset: 0x00421274
		public ECondition Type { get; set; }

		// Token: 0x170087EC RID: 34796
		// (get) Token: 0x0601D56A RID: 120170 RVA: 0x0042307D File Offset: 0x0042127D
		// (set) Token: 0x0601D56B RID: 120171 RVA: 0x00423085 File Offset: 0x00421285
		public int AreaId { get; set; }

		// Token: 0x0601D56C RID: 120172 RVA: 0x0042308E File Offset: 0x0042128E
		public ICheckAlertAreaEnabledT()
		{
			this.Type = ECondition.CompareVar;
			this.AreaId = 0;
		}
	}
}
