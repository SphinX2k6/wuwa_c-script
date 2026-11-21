using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B83 RID: 23427
	public class INavMeshAkiEntitySourceT
	{
		// Token: 0x1700AB41 RID: 43841
		// (get) Token: 0x060269C0 RID: 158144 RVA: 0x005498B4 File Offset: 0x00547AB4
		// (set) Token: 0x060269C1 RID: 158145 RVA: 0x005498BC File Offset: 0x00547ABC
		public ENavMeshSourceType Type { get; set; }

		// Token: 0x1700AB42 RID: 43842
		// (get) Token: 0x060269C2 RID: 158146 RVA: 0x005498C5 File Offset: 0x00547AC5
		// (set) Token: 0x060269C3 RID: 158147 RVA: 0x005498CD File Offset: 0x00547ACD
		public int SourceId { get; set; }

		// Token: 0x060269C4 RID: 158148 RVA: 0x005498D6 File Offset: 0x00547AD6
		public INavMeshAkiEntitySourceT()
		{
			this.Type = ENavMeshSourceType.AkiEntitySource;
			this.SourceId = 0;
		}
	}
}
