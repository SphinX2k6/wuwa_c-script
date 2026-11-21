using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EFD RID: 20221
	public class ICheckGiantStableValueT
	{
		// Token: 0x17009068 RID: 36968
		// (get) Token: 0x0601F68F RID: 128655 RVA: 0x004600FB File Offset: 0x0045E2FB
		// (set) Token: 0x0601F690 RID: 128656 RVA: 0x00460103 File Offset: 0x0045E303
		public ECondition Type { get; set; }

		// Token: 0x17009069 RID: 36969
		// (get) Token: 0x0601F691 RID: 128657 RVA: 0x0046010C File Offset: 0x0045E30C
		// (set) Token: 0x0601F692 RID: 128658 RVA: 0x00460114 File Offset: 0x0045E314
		public TGiantStableValueUnion StableValueOption { get; set; }

		// Token: 0x0601F693 RID: 128659 RVA: 0x0046011D File Offset: 0x0045E31D
		public ICheckGiantStableValueT()
		{
			this.Type = ECondition.CompareVar;
			this.StableValueOption = null;
		}
	}
}
