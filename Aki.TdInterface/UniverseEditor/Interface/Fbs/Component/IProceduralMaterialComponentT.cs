using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005788 RID: 22408
	public class IProceduralMaterialComponentT
	{
		// Token: 0x1700A726 RID: 42790
		// (get) Token: 0x0602591F RID: 153887 RVA: 0x0052EB95 File Offset: 0x0052CD95
		// (set) Token: 0x06025920 RID: 153888 RVA: 0x0052EB9D File Offset: 0x0052CD9D
		public bool Disabled { get; set; }

		// Token: 0x1700A727 RID: 42791
		// (get) Token: 0x06025921 RID: 153889 RVA: 0x0052EBA6 File Offset: 0x0052CDA6
		// (set) Token: 0x06025922 RID: 153890 RVA: 0x0052EBAE File Offset: 0x0052CDAE
		public List<ICustomPrimitiveDataConfigT> ProceduralMaterialConfigs { get; set; }

		// Token: 0x1700A728 RID: 42792
		// (get) Token: 0x06025923 RID: 153891 RVA: 0x0052EBB7 File Offset: 0x0052CDB7
		// (set) Token: 0x06025924 RID: 153892 RVA: 0x0052EBBF File Offset: 0x0052CDBF
		public byte NullMask { get; set; }

		// Token: 0x06025925 RID: 153893 RVA: 0x0052EBC8 File Offset: 0x0052CDC8
		public IProceduralMaterialComponentT()
		{
			this.Disabled = false;
			this.ProceduralMaterialConfigs = null;
			this.NullMask = 0;
		}
	}
}
