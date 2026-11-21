using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BD RID: 21949
	public class ICustomPrimitiveDataConfigT
	{
		// Token: 0x17009D25 RID: 40229
		// (get) Token: 0x06022EB3 RID: 143027 RVA: 0x004CEC97 File Offset: 0x004CCE97
		// (set) Token: 0x06022EB4 RID: 143028 RVA: 0x004CEC9F File Offset: 0x004CCE9F
		public EProceduralMaterialType Type { get; set; }

		// Token: 0x17009D26 RID: 40230
		// (get) Token: 0x06022EB5 RID: 143029 RVA: 0x004CECA8 File Offset: 0x004CCEA8
		// (set) Token: 0x06022EB6 RID: 143030 RVA: 0x004CECB0 File Offset: 0x004CCEB0
		public List<ICustomPrimitiveMappingT> PrimitiveConfigs { get; set; }

		// Token: 0x17009D27 RID: 40231
		// (get) Token: 0x06022EB7 RID: 143031 RVA: 0x004CECB9 File Offset: 0x004CCEB9
		// (set) Token: 0x06022EB8 RID: 143032 RVA: 0x004CECC1 File Offset: 0x004CCEC1
		public bool IsChildEffective { get; set; }

		// Token: 0x17009D28 RID: 40232
		// (get) Token: 0x06022EB9 RID: 143033 RVA: 0x004CECCA File Offset: 0x004CCECA
		// (set) Token: 0x06022EBA RID: 143034 RVA: 0x004CECD2 File Offset: 0x004CCED2
		public byte NullMask { get; set; }

		// Token: 0x06022EBB RID: 143035 RVA: 0x004CECDB File Offset: 0x004CCEDB
		public ICustomPrimitiveDataConfigT()
		{
			this.Type = EProceduralMaterialType.CustomPrimitiveData;
			this.PrimitiveConfigs = null;
			this.IsChildEffective = false;
			this.NullMask = 0;
		}
	}
}
