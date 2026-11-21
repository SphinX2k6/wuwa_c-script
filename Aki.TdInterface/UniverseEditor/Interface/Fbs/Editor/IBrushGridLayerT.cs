using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C8F RID: 19599
	public class IBrushGridLayerT
	{
		// Token: 0x17008AE3 RID: 35555
		// (get) Token: 0x0601E0D8 RID: 123096 RVA: 0x00436680 File Offset: 0x00434880
		// (set) Token: 0x0601E0D9 RID: 123097 RVA: 0x00436688 File Offset: 0x00434888
		public string Name { get; set; }

		// Token: 0x17008AE4 RID: 35556
		// (get) Token: 0x0601E0DA RID: 123098 RVA: 0x00436691 File Offset: 0x00434891
		// (set) Token: 0x0601E0DB RID: 123099 RVA: 0x00436699 File Offset: 0x00434899
		public List<IVector2T> Cells { get; set; }

		// Token: 0x0601E0DC RID: 123100 RVA: 0x004366A2 File Offset: 0x004348A2
		public IBrushGridLayerT()
		{
			this.Name = null;
			this.Cells = null;
		}
	}
}
