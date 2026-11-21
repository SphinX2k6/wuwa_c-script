using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A1 RID: 25761
	public class IUnlockGeographicalAtlasV2T
	{
		// Token: 0x1700BE12 RID: 48658
		// (get) Token: 0x0602BCAB RID: 179371 RVA: 0x005F4F6C File Offset: 0x005F316C
		// (set) Token: 0x0602BCAC RID: 179372 RVA: 0x005F4F74 File Offset: 0x005F3174
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700BE13 RID: 48659
		// (get) Token: 0x0602BCAD RID: 179373 RVA: 0x005F4F7D File Offset: 0x005F317D
		// (set) Token: 0x0602BCAE RID: 179374 RVA: 0x005F4F85 File Offset: 0x005F3185
		public int Id { get; set; }

		// Token: 0x0602BCAF RID: 179375 RVA: 0x005F4F8E File Offset: 0x005F318E
		public IUnlockGeographicalAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
