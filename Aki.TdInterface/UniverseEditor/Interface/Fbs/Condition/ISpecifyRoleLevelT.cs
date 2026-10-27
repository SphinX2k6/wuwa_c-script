using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD4 RID: 19668
	public class ISpecifyRoleLevelT
	{
		// Token: 0x17008EBD RID: 36541
		// (get) Token: 0x0601F351 RID: 127825 RVA: 0x0045B1FC File Offset: 0x004593FC
		// (set) Token: 0x0601F352 RID: 127826 RVA: 0x0045B204 File Offset: 0x00459404
		public ERoleLevelType Type { get; set; }

		// Token: 0x17008EBE RID: 36542
		// (get) Token: 0x0601F353 RID: 127827 RVA: 0x0045B20D File Offset: 0x0045940D
		// (set) Token: 0x0601F354 RID: 127828 RVA: 0x0045B215 File Offset: 0x00459415
		public int Index { get; set; }

		// Token: 0x17008EBF RID: 36543
		// (get) Token: 0x0601F355 RID: 127829 RVA: 0x0045B21E File Offset: 0x0045941E
		// (set) Token: 0x0601F356 RID: 127830 RVA: 0x0045B226 File Offset: 0x00459426
		public ECompare Compare { get; set; }

		// Token: 0x17008EC0 RID: 36544
		// (get) Token: 0x0601F357 RID: 127831 RVA: 0x0045B22F File Offset: 0x0045942F
		// (set) Token: 0x0601F358 RID: 127832 RVA: 0x0045B237 File Offset: 0x00459437
		public int Level { get; set; }

		// Token: 0x0601F359 RID: 127833 RVA: 0x0045B240 File Offset: 0x00459440
		public ISpecifyRoleLevelT()
		{
			this.Type = ERoleLevelType.SpecifyRole;
			this.Index = 0;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
