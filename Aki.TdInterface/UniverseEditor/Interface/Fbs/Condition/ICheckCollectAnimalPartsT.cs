using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A4 RID: 18852
	public class ICheckCollectAnimalPartsT
	{
		// Token: 0x17008841 RID: 34881
		// (get) Token: 0x0601D6A8 RID: 120488 RVA: 0x004253E1 File Offset: 0x004235E1
		// (set) Token: 0x0601D6A9 RID: 120489 RVA: 0x004253E9 File Offset: 0x004235E9
		public ECondition Type { get; set; }

		// Token: 0x17008842 RID: 34882
		// (get) Token: 0x0601D6AA RID: 120490 RVA: 0x004253F2 File Offset: 0x004235F2
		// (set) Token: 0x0601D6AB RID: 120491 RVA: 0x004253FA File Offset: 0x004235FA
		public int TargetAnimal { get; set; }

		// Token: 0x17008843 RID: 34883
		// (get) Token: 0x0601D6AC RID: 120492 RVA: 0x00425403 File Offset: 0x00423603
		// (set) Token: 0x0601D6AD RID: 120493 RVA: 0x0042540B File Offset: 0x0042360B
		public ECheckEntityPerformanceAttributeType CheckType { get; set; }

		// Token: 0x17008844 RID: 34884
		// (get) Token: 0x0601D6AE RID: 120494 RVA: 0x00425414 File Offset: 0x00423614
		// (set) Token: 0x0601D6AF RID: 120495 RVA: 0x0042541C File Offset: 0x0042361C
		public List<ECollectAnimalPartSlot> Slots { get; set; }

		// Token: 0x17008845 RID: 34885
		// (get) Token: 0x0601D6B0 RID: 120496 RVA: 0x00425425 File Offset: 0x00423625
		// (set) Token: 0x0601D6B1 RID: 120497 RVA: 0x0042542D File Offset: 0x0042362D
		public byte NullMask { get; set; }

		// Token: 0x0601D6B2 RID: 120498 RVA: 0x00425436 File Offset: 0x00423636
		public ICheckCollectAnimalPartsT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetAnimal = 0;
			this.CheckType = ECheckEntityPerformanceAttributeType.MatchAll;
			this.Slots = null;
			this.NullMask = 0;
		}
	}
}
