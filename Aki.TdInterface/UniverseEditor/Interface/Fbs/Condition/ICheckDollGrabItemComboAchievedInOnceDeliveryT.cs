using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E8B RID: 20107
	public class ICheckDollGrabItemComboAchievedInOnceDeliveryT
	{
		// Token: 0x17008F68 RID: 36712
		// (get) Token: 0x0601F269 RID: 127593 RVA: 0x00458404 File Offset: 0x00456604
		// (set) Token: 0x0601F26A RID: 127594 RVA: 0x0045840C File Offset: 0x0045660C
		public ECondition Type { get; set; }

		// Token: 0x17008F69 RID: 36713
		// (get) Token: 0x0601F26B RID: 127595 RVA: 0x00458415 File Offset: 0x00456615
		// (set) Token: 0x0601F26C RID: 127596 RVA: 0x0045841D File Offset: 0x0045661D
		public int ShowcaseEntityId { get; set; }

		// Token: 0x0601F26D RID: 127597 RVA: 0x00458426 File Offset: 0x00456626
		public ICheckDollGrabItemComboAchievedInOnceDeliveryT()
		{
			this.Type = ECondition.CompareVar;
			this.ShowcaseEntityId = 0;
		}
	}
}
