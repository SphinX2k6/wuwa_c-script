using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005994 RID: 22932
	public class IInhaledItemComponentT
	{
		// Token: 0x1700A68D RID: 42637
		// (get) Token: 0x06025635 RID: 153141 RVA: 0x005216B7 File Offset: 0x0051F8B7
		// (set) Token: 0x06025636 RID: 153142 RVA: 0x005216BF File Offset: 0x0051F8BF
		public bool Disabled { get; set; }

		// Token: 0x1700A68E RID: 42638
		// (get) Token: 0x06025637 RID: 153143 RVA: 0x005216C8 File Offset: 0x0051F8C8
		// (set) Token: 0x06025638 RID: 153144 RVA: 0x005216D0 File Offset: 0x0051F8D0
		public int InhaledStrength { get; set; }

		// Token: 0x1700A68F RID: 42639
		// (get) Token: 0x06025639 RID: 153145 RVA: 0x005216D9 File Offset: 0x0051F8D9
		// (set) Token: 0x0602563A RID: 153146 RVA: 0x005216E1 File Offset: 0x0051F8E1
		public int InhaledInterruptionRecoveryTime { get; set; }

		// Token: 0x1700A690 RID: 42640
		// (get) Token: 0x0602563B RID: 153147 RVA: 0x005216EA File Offset: 0x0051F8EA
		// (set) Token: 0x0602563C RID: 153148 RVA: 0x005216F2 File Offset: 0x0051F8F2
		public IInhaledPerformanceT InhaledPerformance { get; set; }

		// Token: 0x1700A691 RID: 42641
		// (get) Token: 0x0602563D RID: 153149 RVA: 0x005216FB File Offset: 0x0051F8FB
		// (set) Token: 0x0602563E RID: 153150 RVA: 0x00521703 File Offset: 0x0051F903
		public TInhaledPerResultTypeUnion InhaledPerResult { get; set; }

		// Token: 0x1700A692 RID: 42642
		// (get) Token: 0x0602563F RID: 153151 RVA: 0x0052170C File Offset: 0x0051F90C
		// (set) Token: 0x06025640 RID: 153152 RVA: 0x00521714 File Offset: 0x0051F914
		public byte NullMask { get; set; }

		// Token: 0x06025641 RID: 153153 RVA: 0x0052171D File Offset: 0x0051F91D
		public IInhaledItemComponentT()
		{
			this.Disabled = false;
			this.InhaledStrength = 0;
			this.InhaledInterruptionRecoveryTime = 0;
			this.InhaledPerformance = null;
			this.InhaledPerResult = null;
			this.NullMask = 0;
		}
	}
}
