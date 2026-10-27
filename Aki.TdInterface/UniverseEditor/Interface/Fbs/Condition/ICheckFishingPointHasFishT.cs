using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A28 RID: 18984
	public class ICheckFishingPointHasFishT
	{
		// Token: 0x1700896D RID: 35181
		// (get) Token: 0x0601DB55 RID: 121685 RVA: 0x0042DC28 File Offset: 0x0042BE28
		// (set) Token: 0x0601DB56 RID: 121686 RVA: 0x0042DC30 File Offset: 0x0042BE30
		public ECondition Type { get; set; }

		// Token: 0x1700896E RID: 35182
		// (get) Token: 0x0601DB57 RID: 121687 RVA: 0x0042DC39 File Offset: 0x0042BE39
		// (set) Token: 0x0601DB58 RID: 121688 RVA: 0x0042DC41 File Offset: 0x0042BE41
		public bool HasFish { get; set; }

		// Token: 0x0601DB59 RID: 121689 RVA: 0x0042DC4A File Offset: 0x0042BE4A
		public ICheckFishingPointHasFishT()
		{
			this.Type = ECondition.CompareVar;
			this.HasFish = false;
		}
	}
}
