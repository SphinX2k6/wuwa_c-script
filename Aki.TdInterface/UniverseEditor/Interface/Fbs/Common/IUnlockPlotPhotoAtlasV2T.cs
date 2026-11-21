using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064AA RID: 25770
	public class IUnlockPlotPhotoAtlasV2T
	{
		// Token: 0x1700BE21 RID: 48673
		// (get) Token: 0x0602BCED RID: 179437 RVA: 0x005F556C File Offset: 0x005F376C
		// (set) Token: 0x0602BCEE RID: 179438 RVA: 0x005F5574 File Offset: 0x005F3774
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700BE22 RID: 48674
		// (get) Token: 0x0602BCEF RID: 179439 RVA: 0x005F557D File Offset: 0x005F377D
		// (set) Token: 0x0602BCF0 RID: 179440 RVA: 0x005F5585 File Offset: 0x005F3785
		public int Id { get; set; }

		// Token: 0x0602BCF1 RID: 179441 RVA: 0x005F558E File Offset: 0x005F378E
		public IUnlockPlotPhotoAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
