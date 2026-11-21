using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F6 RID: 22006
	public class IDollComboCameraT
	{
		// Token: 0x17009DB9 RID: 40377
		// (get) Token: 0x06023109 RID: 143625 RVA: 0x004D3A83 File Offset: 0x004D1C83
		// (set) Token: 0x0602310A RID: 143626 RVA: 0x004D3A8B File Offset: 0x004D1C8B
		public float Fov { get; set; }

		// Token: 0x17009DBA RID: 40378
		// (get) Token: 0x0602310B RID: 143627 RVA: 0x004D3A94 File Offset: 0x004D1C94
		// (set) Token: 0x0602310C RID: 143628 RVA: 0x004D3A9C File Offset: 0x004D1C9C
		public List<IDollComboCameraConfigT> ComboCameras { get; set; }

		// Token: 0x0602310D RID: 143629 RVA: 0x004D3AA5 File Offset: 0x004D1CA5
		public IDollComboCameraT()
		{
			this.Fov = 0f;
			this.ComboCameras = null;
		}
	}
}
