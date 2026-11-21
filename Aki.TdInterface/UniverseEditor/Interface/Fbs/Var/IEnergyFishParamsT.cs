using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E75 RID: 15989
	public class IEnergyFishParamsT
	{
		// Token: 0x17006C00 RID: 27648
		// (get) Token: 0x060158F8 RID: 88312 RVA: 0x0031BB93 File Offset: 0x00319D93
		// (set) Token: 0x060158F9 RID: 88313 RVA: 0x0031BB9B File Offset: 0x00319D9B
		public EParamsPreset Type { get; set; }

		// Token: 0x17006C01 RID: 27649
		// (get) Token: 0x060158FA RID: 88314 RVA: 0x0031BBA4 File Offset: 0x00319DA4
		// (set) Token: 0x060158FB RID: 88315 RVA: 0x0031BBAC File Offset: 0x00319DAC
		public List<IEnergyFishStateConfigT> Configs { get; set; }

		// Token: 0x060158FC RID: 88316 RVA: 0x0031BBB5 File Offset: 0x00319DB5
		public IEnergyFishParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.Configs = null;
		}
	}
}
