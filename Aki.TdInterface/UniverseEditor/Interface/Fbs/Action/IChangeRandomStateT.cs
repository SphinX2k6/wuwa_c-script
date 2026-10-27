using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200631B RID: 25371
	public class IChangeRandomStateT
	{
		// Token: 0x1700BD67 RID: 48487
		// (get) Token: 0x0602BE2D RID: 179757 RVA: 0x00608C3D File Offset: 0x00606E3D
		// (set) Token: 0x0602BE2E RID: 179758 RVA: 0x00608C45 File Offset: 0x00606E45
		public List<int> StateIds { get; set; }

		// Token: 0x0602BE2F RID: 179759 RVA: 0x00608C4E File Offset: 0x00606E4E
		public IChangeRandomStateT()
		{
			this.StateIds = null;
		}
	}
}
