using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005898 RID: 22680
	public class IScaleUpSpiritPerformConfigT
	{
		// Token: 0x1700A9BF RID: 43455
		// (get) Token: 0x060263D8 RID: 156632 RVA: 0x00545628 File Offset: 0x00543828
		// (set) Token: 0x060263D9 RID: 156633 RVA: 0x00545630 File Offset: 0x00543830
		public bool IsInitHide { get; set; }

		// Token: 0x1700A9C0 RID: 43456
		// (get) Token: 0x060263DA RID: 156634 RVA: 0x00545639 File Offset: 0x00543839
		// (set) Token: 0x060263DB RID: 156635 RVA: 0x00545641 File Offset: 0x00543841
		public string AppearEffectDa { get; set; }

		// Token: 0x1700A9C1 RID: 43457
		// (get) Token: 0x060263DC RID: 156636 RVA: 0x0054564A File Offset: 0x0054384A
		// (set) Token: 0x060263DD RID: 156637 RVA: 0x00545652 File Offset: 0x00543852
		public string ScaleUpEffectDa { get; set; }

		// Token: 0x1700A9C2 RID: 43458
		// (get) Token: 0x060263DE RID: 156638 RVA: 0x0054565B File Offset: 0x0054385B
		// (set) Token: 0x060263DF RID: 156639 RVA: 0x00545663 File Offset: 0x00543863
		public int ScaleUpPerformTag { get; set; }

		// Token: 0x1700A9C3 RID: 43459
		// (get) Token: 0x060263E0 RID: 156640 RVA: 0x0054566C File Offset: 0x0054386C
		// (set) Token: 0x060263E1 RID: 156641 RVA: 0x00545674 File Offset: 0x00543874
		public byte NullMask { get; set; }

		// Token: 0x060263E2 RID: 156642 RVA: 0x0054567D File Offset: 0x0054387D
		public IScaleUpSpiritPerformConfigT()
		{
			this.IsInitHide = false;
			this.AppearEffectDa = null;
			this.ScaleUpEffectDa = null;
			this.ScaleUpPerformTag = 0;
			this.NullMask = 0;
		}
	}
}
