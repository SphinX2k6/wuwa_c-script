using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A37 RID: 14903
	public class IBvbCardFilterCheckIsCoreT
	{
		// Token: 0x17006620 RID: 26144
		// (get) Token: 0x060142AE RID: 82606 RVA: 0x002F2E1C File Offset: 0x002F101C
		// (set) Token: 0x060142AF RID: 82607 RVA: 0x002F2E24 File Offset: 0x002F1024
		public EBvbCardFilterType Type { get; set; }

		// Token: 0x17006621 RID: 26145
		// (get) Token: 0x060142B0 RID: 82608 RVA: 0x002F2E2D File Offset: 0x002F102D
		// (set) Token: 0x060142B1 RID: 82609 RVA: 0x002F2E35 File Offset: 0x002F1035
		public bool IsCore { get; set; }

		// Token: 0x060142B2 RID: 82610 RVA: 0x002F2E3E File Offset: 0x002F103E
		public IBvbCardFilterCheckIsCoreT()
		{
			this.Type = EBvbCardFilterType.CompareCost;
			this.IsCore = false;
		}
	}
}
