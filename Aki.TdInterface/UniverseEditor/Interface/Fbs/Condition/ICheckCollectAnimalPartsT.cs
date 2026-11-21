using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E5B RID: 20059
	public class ICheckCollectAnimalPartsT
	{
		// Token: 0x17008EFC RID: 36604
		// (get) Token: 0x0601F0CD RID: 127181 RVA: 0x00455895 File Offset: 0x00453A95
		// (set) Token: 0x0601F0CE RID: 127182 RVA: 0x0045589D File Offset: 0x00453A9D
		public ECondition Type { get; set; }

		// Token: 0x17008EFD RID: 36605
		// (get) Token: 0x0601F0CF RID: 127183 RVA: 0x004558A6 File Offset: 0x00453AA6
		// (set) Token: 0x0601F0D0 RID: 127184 RVA: 0x004558AE File Offset: 0x00453AAE
		public int TargetAnimal { get; set; }

		// Token: 0x17008EFE RID: 36606
		// (get) Token: 0x0601F0D1 RID: 127185 RVA: 0x004558B7 File Offset: 0x00453AB7
		// (set) Token: 0x0601F0D2 RID: 127186 RVA: 0x004558BF File Offset: 0x00453ABF
		public ECheckEntityPerformanceAttributeType CheckType { get; set; }

		// Token: 0x17008EFF RID: 36607
		// (get) Token: 0x0601F0D3 RID: 127187 RVA: 0x004558C8 File Offset: 0x00453AC8
		// (set) Token: 0x0601F0D4 RID: 127188 RVA: 0x004558D0 File Offset: 0x00453AD0
		public List<ECollectAnimalPartSlot> Slots { get; set; }

		// Token: 0x17008F00 RID: 36608
		// (get) Token: 0x0601F0D5 RID: 127189 RVA: 0x004558D9 File Offset: 0x00453AD9
		// (set) Token: 0x0601F0D6 RID: 127190 RVA: 0x004558E1 File Offset: 0x00453AE1
		public byte NullMask { get; set; }

		// Token: 0x0601F0D7 RID: 127191 RVA: 0x004558EA File Offset: 0x00453AEA
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
