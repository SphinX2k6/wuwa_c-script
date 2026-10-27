using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B06 RID: 15110
	public class IVarFloatValidateConfigT
	{
		// Token: 0x170067A8 RID: 26536
		// (get) Token: 0x060149CD RID: 84429 RVA: 0x003003FD File Offset: 0x002FE5FD
		// (set) Token: 0x060149CE RID: 84430 RVA: 0x00300405 File Offset: 0x002FE605
		public EVar Type { get; set; }

		// Token: 0x170067A9 RID: 26537
		// (get) Token: 0x060149CF RID: 84431 RVA: 0x0030040E File Offset: 0x002FE60E
		// (set) Token: 0x060149D0 RID: 84432 RVA: 0x00300416 File Offset: 0x002FE616
		public List<float> ValidList { get; set; }

		// Token: 0x170067AA RID: 26538
		// (get) Token: 0x060149D1 RID: 84433 RVA: 0x0030041F File Offset: 0x002FE61F
		// (set) Token: 0x060149D2 RID: 84434 RVA: 0x00300427 File Offset: 0x002FE627
		public float MinValue { get; set; }

		// Token: 0x170067AB RID: 26539
		// (get) Token: 0x060149D3 RID: 84435 RVA: 0x00300430 File Offset: 0x002FE630
		// (set) Token: 0x060149D4 RID: 84436 RVA: 0x00300438 File Offset: 0x002FE638
		public float MaxValue { get; set; }

		// Token: 0x170067AC RID: 26540
		// (get) Token: 0x060149D5 RID: 84437 RVA: 0x00300441 File Offset: 0x002FE641
		// (set) Token: 0x060149D6 RID: 84438 RVA: 0x00300449 File Offset: 0x002FE649
		public byte NullMask { get; set; }

		// Token: 0x060149D7 RID: 84439 RVA: 0x00300452 File Offset: 0x002FE652
		public IVarFloatValidateConfigT()
		{
			this.Type = EVar.Boolean;
			this.ValidList = null;
			this.MinValue = 0f;
			this.MaxValue = 0f;
			this.NullMask = 0;
		}
	}
}
