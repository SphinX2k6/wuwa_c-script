using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051EB RID: 20971
	public class ITargetEntityInvisibleT
	{
		// Token: 0x17009626 RID: 38438
		// (get) Token: 0x0602106D RID: 135277 RVA: 0x00490A56 File Offset: 0x0048EC56
		// (set) Token: 0x0602106E RID: 135278 RVA: 0x00490A5E File Offset: 0x0048EC5E
		public EVisibleCondition Type { get; set; }

		// Token: 0x17009627 RID: 38439
		// (get) Token: 0x0602106F RID: 135279 RVA: 0x00490A67 File Offset: 0x0048EC67
		// (set) Token: 0x06021070 RID: 135280 RVA: 0x00490A6F File Offset: 0x0048EC6F
		public ECompare Compare { get; set; }

		// Token: 0x17009628 RID: 38440
		// (get) Token: 0x06021071 RID: 135281 RVA: 0x00490A78 File Offset: 0x0048EC78
		// (set) Token: 0x06021072 RID: 135282 RVA: 0x00490A80 File Offset: 0x0048EC80
		public int EntityId { get; set; }

		// Token: 0x06021073 RID: 135283 RVA: 0x00490A89 File Offset: 0x0048EC89
		public ITargetEntityInvisibleT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.EntityId = 0;
		}
	}
}
