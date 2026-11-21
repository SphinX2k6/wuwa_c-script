using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200600F RID: 24591
	public class ISunSpiritGearPerformScaleUpT
	{
		// Token: 0x1700B656 RID: 46678
		// (get) Token: 0x0602972E RID: 169774 RVA: 0x005A8335 File Offset: 0x005A6535
		// (set) Token: 0x0602972F RID: 169775 RVA: 0x005A833D File Offset: 0x005A653D
		public ESunSpiritGearPerformType Type { get; set; }

		// Token: 0x1700B657 RID: 46679
		// (get) Token: 0x06029730 RID: 169776 RVA: 0x005A8346 File Offset: 0x005A6546
		// (set) Token: 0x06029731 RID: 169777 RVA: 0x005A834E File Offset: 0x005A654E
		public float Scale { get; set; }

		// Token: 0x1700B658 RID: 46680
		// (get) Token: 0x06029732 RID: 169778 RVA: 0x005A8357 File Offset: 0x005A6557
		// (set) Token: 0x06029733 RID: 169779 RVA: 0x005A835F File Offset: 0x005A655F
		public IScaleUpSpiritPerformConfigT ScaleUpPerformConfig { get; set; }

		// Token: 0x06029734 RID: 169780 RVA: 0x005A8368 File Offset: 0x005A6568
		public ISunSpiritGearPerformScaleUpT()
		{
			this.Type = ESunSpiritGearPerformType.ToGearRelativePos;
			this.Scale = 0f;
			this.ScaleUpPerformConfig = null;
		}
	}
}
