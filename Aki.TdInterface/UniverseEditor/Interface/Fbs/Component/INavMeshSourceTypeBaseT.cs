using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EB RID: 21995
	public class INavMeshSourceTypeBaseT
	{
		// Token: 0x1700A2C4 RID: 41668
		// (get) Token: 0x060247E1 RID: 149473 RVA: 0x005097F6 File Offset: 0x005079F6
		// (set) Token: 0x060247E2 RID: 149474 RVA: 0x005097FE File Offset: 0x005079FE
		public ENavMeshSourceType Type { get; set; }

		// Token: 0x060247E3 RID: 149475 RVA: 0x00509807 File Offset: 0x00507A07
		public INavMeshSourceTypeBaseT()
		{
			this.Type = ENavMeshSourceType.AkiEntitySource;
		}
	}
}
