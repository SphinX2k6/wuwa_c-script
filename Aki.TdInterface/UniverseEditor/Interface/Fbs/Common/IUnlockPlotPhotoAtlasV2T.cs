using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E6A RID: 24170
	public class IUnlockPlotPhotoAtlasV2T
	{
		// Token: 0x1700B4B8 RID: 46264
		// (get) Token: 0x06029651 RID: 169553 RVA: 0x005AC6C4 File Offset: 0x005AA8C4
		// (set) Token: 0x06029652 RID: 169554 RVA: 0x005AC6CC File Offset: 0x005AA8CC
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700B4B9 RID: 46265
		// (get) Token: 0x06029653 RID: 169555 RVA: 0x005AC6D5 File Offset: 0x005AA8D5
		// (set) Token: 0x06029654 RID: 169556 RVA: 0x005AC6DD File Offset: 0x005AA8DD
		public int Id { get; set; }

		// Token: 0x06029655 RID: 169557 RVA: 0x005AC6E6 File Offset: 0x005AA8E6
		public IUnlockPlotPhotoAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
