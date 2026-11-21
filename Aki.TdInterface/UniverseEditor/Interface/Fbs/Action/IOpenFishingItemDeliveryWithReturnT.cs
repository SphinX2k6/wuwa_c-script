using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735F RID: 29535
	public class IOpenFishingItemDeliveryWithReturnT
	{
		// Token: 0x1700D89C RID: 55452
		// (get) Token: 0x060338A3 RID: 211107 RVA: 0x006F250D File Offset: 0x006F070D
		// (set) Token: 0x060338A4 RID: 211108 RVA: 0x006F2515 File Offset: 0x006F0715
		public ESystemType Type { get; set; }

		// Token: 0x1700D89D RID: 55453
		// (get) Token: 0x060338A5 RID: 211109 RVA: 0x006F251E File Offset: 0x006F071E
		// (set) Token: 0x060338A6 RID: 211110 RVA: 0x006F2526 File Offset: 0x006F0726
		public int PresetId { get; set; }

		// Token: 0x1700D89E RID: 55454
		// (get) Token: 0x060338A7 RID: 211111 RVA: 0x006F252F File Offset: 0x006F072F
		// (set) Token: 0x060338A8 RID: 211112 RVA: 0x006F2537 File Offset: 0x006F0737
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x060338A9 RID: 211113 RVA: 0x006F2540 File Offset: 0x006F0740
		public IOpenFishingItemDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.PresetId = 0;
			this.ReturnVar = null;
		}
	}
}
