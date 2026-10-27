using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004827 RID: 18471
	public class IBrushGridLayerT
	{
		// Token: 0x17008498 RID: 33944
		// (get) Token: 0x0601C8DB RID: 116955 RVA: 0x00409D30 File Offset: 0x00407F30
		// (set) Token: 0x0601C8DC RID: 116956 RVA: 0x00409D38 File Offset: 0x00407F38
		public string Name { get; set; }

		// Token: 0x17008499 RID: 33945
		// (get) Token: 0x0601C8DD RID: 116957 RVA: 0x00409D41 File Offset: 0x00407F41
		// (set) Token: 0x0601C8DE RID: 116958 RVA: 0x00409D49 File Offset: 0x00407F49
		public List<IVector2T> Cells { get; set; }

		// Token: 0x0601C8DF RID: 116959 RVA: 0x00409D52 File Offset: 0x00407F52
		public IBrushGridLayerT()
		{
			this.Name = null;
			this.Cells = null;
		}
	}
}
