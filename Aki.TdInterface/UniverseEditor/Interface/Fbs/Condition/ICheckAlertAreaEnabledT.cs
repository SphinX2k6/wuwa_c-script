using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E3A RID: 20026
	public class ICheckAlertAreaEnabledT
	{
		// Token: 0x17008EA6 RID: 36518
		// (get) Token: 0x0601EF8D RID: 126861 RVA: 0x00453520 File Offset: 0x00451720
		// (set) Token: 0x0601EF8E RID: 126862 RVA: 0x00453528 File Offset: 0x00451728
		public ECondition Type { get; set; }

		// Token: 0x17008EA7 RID: 36519
		// (get) Token: 0x0601EF8F RID: 126863 RVA: 0x00453531 File Offset: 0x00451731
		// (set) Token: 0x0601EF90 RID: 126864 RVA: 0x00453539 File Offset: 0x00451739
		public int AreaId { get; set; }

		// Token: 0x0601EF91 RID: 126865 RVA: 0x00453542 File Offset: 0x00451742
		public ICheckAlertAreaEnabledT()
		{
			this.Type = ECondition.CompareVar;
			this.AreaId = 0;
		}
	}
}
