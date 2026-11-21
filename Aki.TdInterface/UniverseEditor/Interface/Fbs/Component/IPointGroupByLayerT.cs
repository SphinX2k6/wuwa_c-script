using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D65 RID: 23909
	public class IPointGroupByLayerT
	{
		// Token: 0x1700AFFC RID: 45052
		// (get) Token: 0x06027CDD RID: 163037 RVA: 0x005720C6 File Offset: 0x005702C6
		// (set) Token: 0x06027CDE RID: 163038 RVA: 0x005720CE File Offset: 0x005702CE
		public EPointGroupGenerateType Type { get; set; }

		// Token: 0x1700AFFD RID: 45053
		// (get) Token: 0x06027CDF RID: 163039 RVA: 0x005720D7 File Offset: 0x005702D7
		// (set) Token: 0x06027CE0 RID: 163040 RVA: 0x005720DF File Offset: 0x005702DF
		public IVectorInfoT Space { get; set; }

		// Token: 0x1700AFFE RID: 45054
		// (get) Token: 0x06027CE1 RID: 163041 RVA: 0x005720E8 File Offset: 0x005702E8
		// (set) Token: 0x06027CE2 RID: 163042 RVA: 0x005720F0 File Offset: 0x005702F0
		public List<IParkourPointLayerConfigT> Layers { get; set; }

		// Token: 0x06027CE3 RID: 163043 RVA: 0x005720F9 File Offset: 0x005702F9
		public IPointGroupByLayerT()
		{
			this.Type = EPointGroupGenerateType.Layer;
			this.Space = null;
			this.Layers = null;
		}
	}
}
