using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575E RID: 22366
	public class IPointGroupByLayerT
	{
		// Token: 0x1700A6D8 RID: 42712
		// (get) Token: 0x060257BD RID: 153533 RVA: 0x0052BF3A File Offset: 0x0052A13A
		// (set) Token: 0x060257BE RID: 153534 RVA: 0x0052BF42 File Offset: 0x0052A142
		public EPointGroupGenerateType Type { get; set; }

		// Token: 0x1700A6D9 RID: 42713
		// (get) Token: 0x060257BF RID: 153535 RVA: 0x0052BF4B File Offset: 0x0052A14B
		// (set) Token: 0x060257C0 RID: 153536 RVA: 0x0052BF53 File Offset: 0x0052A153
		public IVectorInfoT Space { get; set; }

		// Token: 0x1700A6DA RID: 42714
		// (get) Token: 0x060257C1 RID: 153537 RVA: 0x0052BF5C File Offset: 0x0052A15C
		// (set) Token: 0x060257C2 RID: 153538 RVA: 0x0052BF64 File Offset: 0x0052A164
		public List<IParkourPointLayerConfigT> Layers { get; set; }

		// Token: 0x060257C3 RID: 153539 RVA: 0x0052BF6D File Offset: 0x0052A16D
		public IPointGroupByLayerT()
		{
			this.Type = EPointGroupGenerateType.Layer;
			this.Space = null;
			this.Layers = null;
		}
	}
}
