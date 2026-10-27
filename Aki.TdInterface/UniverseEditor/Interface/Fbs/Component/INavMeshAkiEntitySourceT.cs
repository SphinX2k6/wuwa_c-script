using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E5 RID: 21989
	public class INavMeshAkiEntitySourceT
	{
		// Token: 0x1700A2B9 RID: 41657
		// (get) Token: 0x060247B3 RID: 149427 RVA: 0x0050933C File Offset: 0x0050753C
		// (set) Token: 0x060247B4 RID: 149428 RVA: 0x00509344 File Offset: 0x00507544
		public ENavMeshSourceType Type { get; set; }

		// Token: 0x1700A2BA RID: 41658
		// (get) Token: 0x060247B5 RID: 149429 RVA: 0x0050934D File Offset: 0x0050754D
		// (set) Token: 0x060247B6 RID: 149430 RVA: 0x00509355 File Offset: 0x00507555
		public int SourceId { get; set; }

		// Token: 0x060247B7 RID: 149431 RVA: 0x0050935E File Offset: 0x0050755E
		public INavMeshAkiEntitySourceT()
		{
			this.Type = ENavMeshSourceType.AkiEntitySource;
			this.SourceId = 0;
		}
	}
}
