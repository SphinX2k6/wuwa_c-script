using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597E RID: 22910
	public class ISphereFactoryComponentT
	{
		// Token: 0x1700ABE8 RID: 44008
		// (get) Token: 0x06026C8B RID: 158859 RVA: 0x00556AB3 File Offset: 0x00554CB3
		// (set) Token: 0x06026C8C RID: 158860 RVA: 0x00556ABB File Offset: 0x00554CBB
		public bool Disabled { get; set; }

		// Token: 0x1700ABE9 RID: 44009
		// (get) Token: 0x06026C8D RID: 158861 RVA: 0x00556AC4 File Offset: 0x00554CC4
		// (set) Token: 0x06026C8E RID: 158862 RVA: 0x00556ACC File Offset: 0x00554CCC
		public IVectorInfoT SphereLocation { get; set; }

		// Token: 0x1700ABEA RID: 44010
		// (get) Token: 0x06026C8F RID: 158863 RVA: 0x00556AD5 File Offset: 0x00554CD5
		// (set) Token: 0x06026C90 RID: 158864 RVA: 0x00556ADD File Offset: 0x00554CDD
		public string SphereGuid { get; set; }

		// Token: 0x1700ABEB RID: 44011
		// (get) Token: 0x06026C91 RID: 158865 RVA: 0x00556AE6 File Offset: 0x00554CE6
		// (set) Token: 0x06026C92 RID: 158866 RVA: 0x00556AEE File Offset: 0x00554CEE
		public byte NullMask { get; set; }

		// Token: 0x06026C93 RID: 158867 RVA: 0x00556AF7 File Offset: 0x00554CF7
		public ISphereFactoryComponentT()
		{
			this.Disabled = false;
			this.SphereLocation = null;
			this.SphereGuid = null;
			this.NullMask = 0;
		}
	}
}
