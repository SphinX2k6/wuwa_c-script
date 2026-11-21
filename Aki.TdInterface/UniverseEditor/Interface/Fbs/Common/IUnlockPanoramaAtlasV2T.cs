using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A7 RID: 25767
	public class IUnlockPanoramaAtlasV2T
	{
		// Token: 0x1700BE1C RID: 48668
		// (get) Token: 0x0602BCD7 RID: 179415 RVA: 0x005F536C File Offset: 0x005F356C
		// (set) Token: 0x0602BCD8 RID: 179416 RVA: 0x005F5374 File Offset: 0x005F3574
		public EUnlockAtlasSystemTypeV2 Type { get; set; }

		// Token: 0x1700BE1D RID: 48669
		// (get) Token: 0x0602BCD9 RID: 179417 RVA: 0x005F537D File Offset: 0x005F357D
		// (set) Token: 0x0602BCDA RID: 179418 RVA: 0x005F5385 File Offset: 0x005F3585
		public int Id { get; set; }

		// Token: 0x0602BCDB RID: 179419 RVA: 0x005F538E File Offset: 0x005F358E
		public IUnlockPanoramaAtlasV2T()
		{
			this.Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas;
			this.Id = 0;
		}
	}
}
