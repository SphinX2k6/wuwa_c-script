using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006000 RID: 24576
	public class ISunSpiritBlockExtraRangeT
	{
		// Token: 0x1700B639 RID: 46649
		// (get) Token: 0x060296B6 RID: 169654 RVA: 0x005A752B File Offset: 0x005A572B
		// (set) Token: 0x060296B7 RID: 169655 RVA: 0x005A7533 File Offset: 0x005A5733
		public EExtraRangeType Type { get; set; }

		// Token: 0x1700B63A RID: 46650
		// (get) Token: 0x060296B8 RID: 169656 RVA: 0x005A753C File Offset: 0x005A573C
		// (set) Token: 0x060296B9 RID: 169657 RVA: 0x005A7544 File Offset: 0x005A5744
		public ICylinderTriggerShapeT CylinderRange { get; set; }

		// Token: 0x060296BA RID: 169658 RVA: 0x005A754D File Offset: 0x005A574D
		public ISunSpiritBlockExtraRangeT()
		{
			this.Type = EExtraRangeType.SunSpiritBlock;
			this.CylinderRange = null;
		}
	}
}
