using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CEF RID: 19695
	public class ITargetEntityInvisibleT
	{
		// Token: 0x17008EED RID: 36589
		// (get) Token: 0x0601F428 RID: 128040 RVA: 0x0045CB06 File Offset: 0x0045AD06
		// (set) Token: 0x0601F429 RID: 128041 RVA: 0x0045CB0E File Offset: 0x0045AD0E
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008EEE RID: 36590
		// (get) Token: 0x0601F42A RID: 128042 RVA: 0x0045CB17 File Offset: 0x0045AD17
		// (set) Token: 0x0601F42B RID: 128043 RVA: 0x0045CB1F File Offset: 0x0045AD1F
		public ECompare Compare { get; set; }

		// Token: 0x17008EEF RID: 36591
		// (get) Token: 0x0601F42C RID: 128044 RVA: 0x0045CB28 File Offset: 0x0045AD28
		// (set) Token: 0x0601F42D RID: 128045 RVA: 0x0045CB30 File Offset: 0x0045AD30
		public int EntityId { get; set; }

		// Token: 0x0601F42E RID: 128046 RVA: 0x0045CB39 File Offset: 0x0045AD39
		public ITargetEntityInvisibleT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.EntityId = 0;
		}
	}
}
