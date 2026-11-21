using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC8 RID: 23496
	public class INpcModelConfigT
	{
		// Token: 0x1700ABCB RID: 43979
		// (get) Token: 0x06026C18 RID: 158744 RVA: 0x0054DFAA File Offset: 0x0054C1AA
		// (set) Token: 0x06026C19 RID: 158745 RVA: 0x0054DFB2 File Offset: 0x0054C1B2
		public ENpcModelType Type { get; set; }

		// Token: 0x06026C1A RID: 158746 RVA: 0x0054DFBB File Offset: 0x0054C1BB
		public INpcModelConfigT()
		{
			this.Type = ENpcModelType.Mesh;
		}
	}
}
